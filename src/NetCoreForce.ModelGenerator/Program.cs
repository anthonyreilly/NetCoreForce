﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Reflection;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using McMaster.Extensions.CommandLineUtils;
using NetCoreForce.Client;
using NetCoreForce.Client.Models;
using Newtonsoft.Json;

namespace NetCoreForce.ModelGenerator
{
    class Program
    {
        const string defaultConfigFilename = "modelgenerator_config.json";

        static void Main(string[] args)
        {
            var app = new CommandLineApplication();
            app.Name = "modelgenerator";
            app.HelpOption("-?|-h|--help");

            app.OnExecute(() =>
            {
                app.ShowHint();
                return 0;
            });

            app.VersionOption("-v|--version", () =>
            {
                return string.Format("Version {0}", Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion);
            });

            app.Command("generate", (command) =>
            {
                command.Description = "Generate SObject models.";
                command.HelpOption("-?|-h|--help");

                command.ExtendedHelpText = Environment.NewLine +
                "You can supply the API credentials either in the config file, the command parameters, or wait to be prompted for that information." + Environment.NewLine +
                "If you choose to save the config file, be careful with it as it may contain your API credentials.";

                //Authentication
                var clientIdOption = command.Option("--client-id",
                    "API Client ID, a.k.a. Consumer Key",
                    CommandOptionType.SingleValue);

                var clientSecretOption = command.Option("--client-secret",
                    "API Client Secret, a.k.a. Consumer Secret",
                    CommandOptionType.SingleValue);

                var usernameOption = command.Option("--username",
                    "API Username",
                    CommandOptionType.SingleValue);

                var passwordOption = command.Option("--password",
                    "API Password",
                    CommandOptionType.SingleValue);

                var configFileOption = command.Option("--config-file",
                    "Config file path",
                    CommandOptionType.SingleValue);

                var saveConfigOption = command.Option("--save-config",
                    "Save options to config file, uses filename from --config-file option",
                    CommandOptionType.NoValue);

                //generation options
                var includeOption = command.Option("-o|--objects <objects>",
                    "Object models to generate, if omitted all objects will be generated",
                    CommandOptionType.MultipleValue);

                var outputDirectory = command.Option("-d|--output-directory <directory>",
                    "Destination directory for generated file(s)",
                    CommandOptionType.SingleValue);

                var suffixOption = command.Option("-s|--suffix <suffix>",
                    "Suffix to append to object names, e.g. 'Sf' for 'AccountSf'",
                    CommandOptionType.SingleValue);

                var prefixOption = command.Option("-p|--prefix <prefix>",
                    "Prefix to for object names, e.g. 'Sf' for 'SfAccount'",
                    CommandOptionType.SingleValue);

                var namespaceName = command.Option("-n|--namespace <namespace>",
                    "Namespace to use for generated classes",
                    CommandOptionType.SingleValue);

                var customOption = command.Option("-c|--include-custom",
                    "Include custom objects and fields",
                    CommandOptionType.NoValue);

                var includeReferences = command.Option("-r|--include-references",
                    "Include referenced objects as properties",
                    CommandOptionType.NoValue);

                command.OnExecute(() =>
                {
                    //load config file, if available
                    GenConfig config = LoadConfig(configFileOption.Value());

                    if (config == null)
                    {
                        config = new GenConfig();
                    }

                    //only override config file option if option is manually specified
                    if (clientIdOption.HasValue())
                    {
                        config.AuthInfo.ClientId = clientIdOption.Value();
                    }

                    if (clientSecretOption.HasValue())
                    {
                        config.AuthInfo.ClientSecret = clientSecretOption.Value();
                    }

                    if (usernameOption.HasValue())
                    {
                        config.AuthInfo.Username = usernameOption.Value();
                    }

                    if (passwordOption.HasValue())
                    {
                        config.AuthInfo.Password = passwordOption.Value();
                    }

                    if (customOption.HasValue())
                    {
                        config.IncludeCustom = customOption.HasValue();
                    }

                    if (includeOption.HasValue())
                    {
                        config.Objects = includeOption.Values;
                    }

                    if (prefixOption.HasValue())
                    {
                        config.ClassPrefix = prefixOption.Value();
                    }

                    if (suffixOption.HasValue())
                    {
                        config.ClassSuffix = suffixOption.Value();
                    }

                    if (suffixOption.HasValue())
                    {
                        config.ClassNamespace = namespaceName.Value();
                    }

                    if (outputDirectory.HasValue())
                    {
                        config.OutputDirectory = outputDirectory.Value();
                    }

                    if (includeReferences.HasValue())
                    {
                        config.IncludeReferences = includeReferences.HasValue();
                    }

                    //check for minimum needed options and prompt if necessary
                    config = CheckOptions(config);

                    if (saveConfigOption.HasValue())
                    {
                        SaveConfig(config, configFileOption.Value());
                    }

                    Console.Write("Generate models for " + string.Join(", ", config.Objects));

                    if (customOption.HasValue())
                    {
                        Console.Write(" including custom objects and fields");
                    }

                    Console.WriteLine();

                    GenModels(config).Wait();

                    Console.WriteLine("Done.");
                    return 0;
                });
            });

            try
            {
                app.Execute(args);
            }
            catch (CommandParsingException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to execute application: {0}", ex.Message);
            }
        }

        /// <summary>
        /// Checks that the minimum required options are supplied, otherwise prompts user to enter them immediately
        /// </summary>
        private static GenConfig CheckOptions(GenConfig config)
        {
            //check required auth options
            while (string.IsNullOrEmpty(config.AuthInfo.ClientId))
            {
                Console.WriteLine("Enter API Client ID:");
                config.AuthInfo.ClientId = Console.ReadLine();
                Console.WriteLine();
            }

            while (string.IsNullOrEmpty(config.AuthInfo.ClientSecret))
            {
                Console.WriteLine("Enter API Client Secret:");
                config.AuthInfo.ClientSecret = Console.ReadLine();
                Console.WriteLine();
            }

            while (string.IsNullOrEmpty(config.AuthInfo.Username))
            {
                Console.WriteLine("Enter API username:");
                config.AuthInfo.Username = Console.ReadLine();
                Console.WriteLine();
            }

            while (string.IsNullOrEmpty(config.AuthInfo.Password))
            {
                Console.WriteLine("Enter API password:");
                config.AuthInfo.Password = Console.ReadLine();
                Console.WriteLine();
            }

            //object to generate
            if (config.Objects == null)
            {
                config.Objects = new List<string>();
            }

            while (config.Objects.Count == 0)
            {
                Console.WriteLine("Enter an object name to generate, or enter \"all\" to generate all objects");
                string objectName = Console.ReadLine();
                if (!string.IsNullOrEmpty(objectName))
                {
                    config.Objects.Add(objectName);
                    Console.WriteLine();
                }
            }

            while (string.IsNullOrEmpty(config.ClassNamespace))
            {
                Console.WriteLine("Enter namespace for generated class(es):");
                config.ClassNamespace = Console.ReadLine();
                Console.WriteLine();
            }

            return config;
        }

        private static bool SaveConfig(GenConfig config, string filePath = null)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath))
                {
                    filePath = defaultConfigFilename;
                }

                //if using the default filename, or just a filename was given, set the path to the current directory
                if (System.IO.Path.IsPathRooted(filePath))
                {
                    string executabledirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
                    filePath = Path.Combine(executabledirectory, filePath);
                }

                Console.WriteLine($"Saving config file to {filePath}");

                string contents = JsonConvert.SerializeObject(config, Formatting.Indented);

                File.WriteAllText(filePath, contents, Encoding.Unicode);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving config file: " + ex.Message);
                return false;
            }
        }

        private static GenConfig LoadConfig(string filePath = null)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath))
                {
                    filePath = defaultConfigFilename;
                }

                //if using the default filename, or just a filename was given, set the path to the current directory
                if (System.IO.Path.IsPathRooted(filePath))
                {
                    string executabledirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
                    filePath = Path.Combine(executabledirectory, filePath);
                }

                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"No config file found at {filePath}");
                    return null;
                }

                Console.WriteLine($"Loading config file {filePath}");

                string contents = File.ReadAllText(filePath);

                GenConfig config = JsonConvert.DeserializeObject<GenConfig>(contents);

                return config;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading config file: " + ex.Message);
                return null;
            }
        }

        private static async Task<ForceClient> Login(GenConfig config)
        {

            AuthenticationClient auth = new AuthenticationClient();
            try
            {
                await auth.UsernamePasswordAsync(config.AuthInfo.ClientId, config.AuthInfo.ClientSecret,
                    config.AuthInfo.Username, config.AuthInfo.Password, config.AuthInfo.TokenRequestEndpoint);

                Console.WriteLine("Connected to Salesforce");
            }
            catch (ForceAuthException ex)
            {
                Console.WriteLine("Error authenticating: " + ex.Message);
                throw ex;
            }

            ForceClient client = new ForceClient(auth.AccessInfo.InstanceUrl, auth.ApiVersion, auth.AccessInfo.AccessToken);

            return client;
        }

        private static async Task GenModels(GenConfig config)
        {
            ForceClient client = await Login(config);

            if (config.Objects == null || config.Objects.Count == 0)
            {
                Console.WriteLine("Configured list of objects to generate is empty, nothing will be generated");
                return;
            }

            if(string.IsNullOrEmpty(config.AuthInfo.ApiVersion))
            {
                config.AuthInfo.ApiVersion = client.ApiVersion;
            }

            var global = await client.DescribeGlobal();

            if (string.IsNullOrEmpty(config.OutputDirectory))
            {
                config.OutputDirectory = Directory.GetCurrentDirectory();
            }

            Console.WriteLine("Output directory: " + config.OutputDirectory);

            if (!Directory.Exists(config.OutputDirectory))
            {
                Directory.CreateDirectory(config.OutputDirectory);

                Console.WriteLine("Output directory created : " + config.OutputDirectory);
            }


            bool generateAll = false;
            if (config.Objects != null && config.Objects.Count > 0)
            {
                if (config.Objects[0].ToLower() == "all")
                {
                    generateAll = true;
                    Console.WriteLine("Including all objects");
                }
                else
                {
                    Console.WriteLine("Included: " + string.Join(", ", config.Objects));
                }
            }

            foreach (var obj in global.SObjects)
            {
                //TODO: verify if we should skip all non queryable?
                if (!obj.Queryable)
                {
#if DEBUG
                    Console.WriteLine("Skipping non-queryable object " + obj.Name);
#endif
                    continue;
                }

                if (!generateAll)
                {
                    if (config.Objects != null && config.Objects.Count > 0)
                    {
                        bool incl = config.Objects.Any(o => o.ToLowerInvariant() == obj.Name.ToLowerInvariant());
                        if (!incl)
                        {
#if DEBUG
                            Console.WriteLine("Skipping " + obj.Name);
#endif
                            continue;
                        }
                    }
                }

                //TODO: verify Name and Domain non-queryable objects cause compiler errors due to name/member dupe

                Console.Write("Generating model for {0} - ", obj.Name);

                var classMapping = config.Mapping(obj.Name);
                var className = classMapping.Name ?? obj.Name;

                className = string.Format("{0}{1}{2}", config.ClassPrefix ?? string.Empty, className, config.ClassSuffix ?? string.Empty);

                await CreateModel(client, obj.Name, className, config);
            }
        }

        public static async Task CreateModel(ForceClient client, string objectName, string className, GenConfig config)
        {
            string model = await GenClass(client, objectName, className, config);

            string fileName = fileName = string.Format("{0}.cs", className);

            string filePath = Path.Combine(config.OutputDirectory, fileName);

            Console.WriteLine("Writing: " + filePath);

            File.WriteAllText(filePath, model);

            return;
        }

        public static async Task<string> GenClass(ForceClient client, string objectName, string className, GenConfig config)
        {
            SObjectDescribeFull data = await client.GetObjectDescribe(objectName);

            StringBuilder gen = new StringBuilder();

            //gen.AppendLine("// Model generated on " + DateTime.Now.ToString("yyyy-MM-dd"));
            gen.AppendLine("// SF API version " + config.AuthInfo.ApiVersion);
            gen.AppendLine("// Custom fields included: " + config.IncludeCustom.ToString());
            gen.AppendLine("// Relationship objects included: " + config.IncludeReferences.ToString());
            gen.AppendLine();

            //need rename of Task to Task_sf, Domain => Domain_sf, Name => Name_sf

            string newline = Environment.NewLine;

            gen.AppendLine("using System;");
            gen.AppendLine("using System.CodeDom.Compiler;");
            gen.AppendLine("using NetCoreForce.Client.Models;");
            gen.AppendLine("using NetCoreForce.Client.Attributes;");

            if (config.AddNetCoreForceModelsUsings)
                gen.AppendLine("using NetCoreForce.Models;");

            gen.AppendLine("using Newtonsoft.Json;");
            
            gen.AppendLine();
            if (!string.IsNullOrEmpty(config.ClassNamespace))
            {
                gen.AppendLine("namespace " + config.ClassNamespace);
                gen.AppendLine("{");
            }

            var assembly = Assembly.GetEntryAssembly().GetName();

            gen.AppendLine("\t///<summary>");
            gen.AppendLine($"\t/// {WebUtility.HtmlEncode(data.Label)}");
            gen.AppendLine($"\t///<para>SObject Name: {data.Name}</para>");
            gen.AppendLine($"\t///<para>Custom Object: {data.Custom.ToString()}</para>");
            gen.AppendLine("\t///</summary>");
            gen.AppendLine($"\t[GeneratedCodeAttribute(\"{typeof(Program).Namespace}\", \"{assembly.Version}\")]");
            gen.AppendLine($"\tpublic class {className} : SObject");
            gen.AppendLine("\t{");

            gen.AppendLine("\t\t[JsonIgnore]");
            gen.AppendLine("\t\tpublic static string SObjectTypeName");
            gen.AppendLine("\t\t{");
            // gen.AppendLine("\t\t\tget { return \"" + data.Name + "\"; }");
            gen.AppendLine($"\t\t\tget {{ return \"{data.Name}\"; }}");
            gen.AppendLine("\t\t}");
            gen.AppendLine();

            // gen.AppendLine("\t\tpublic " + className + "() : base (\"" + objectName + "\")");
            // gen.AppendLine("\t\t{}");
            // gen.AppendLine();

            var classMapping = config.Mapping(objectName);

            foreach (var field in data.Fields)
            {
                try
                {
                    var fieldMapping = classMapping.Field(field.Name);

                    if (field.Custom && !config.IncludeCustom || fieldMapping.Ignore)
                        continue;

                    gen.AppendLine("\t\t///<summary>");
                    gen.AppendLine("\t\t/// " + WebUtility.HtmlEncode(field.Label));
                    gen.AppendLine("\t\t/// <para>Name: " + field.Name + "</para>");
                    gen.AppendLine("\t\t/// <para>SF Type: " + field.Type + "</para>");
                    if (field.AutoNumber)
                    {
                        gen.AppendLine("\t\t/// <para>AutoNumber field</para>");
                    }
                    //gen.AppendLine("\t\t/// <para>Custom: " + field.Custom.ToString() + "</para>");
                    if (field.Custom)
                    {
                        gen.AppendLine("\t\t/// <para>Custom field</para>");
                    }

                    gen.AppendLine("\t\t/// <para>Nillable: " + field.Nillable.ToString() + "</para>");

                    gen.AppendLine("\t\t///</summary>");

                    var jsonName = JsonName(field.Name);
                    gen.AppendLine(string.Format("\t\t[JsonProperty(PropertyName = \"{0}\")]", jsonName));

                    if (!field.Creatable || !field.Updateable)
                    {
                        gen.AppendLine(string.Format("\t\t[Updateable({0}), Createable({1})]", field.Updateable.ToString().ToLower(), field.Creatable.ToString().ToLower()));
                    }

                    string csTypeName = SfTypeConverter.GetTypeName(field.Type);

                    switch (csTypeName)
                    {
                        case "Boolean":
                            csTypeName = "bool";
                            break;
                        case "String":
                            csTypeName = "string";
                            break;
                        case "Double":
                            csTypeName = "double";
                            break;
                        case "Int32":
                            csTypeName = "int";
                            break;
                        case "Decimal":
                            csTypeName = "decimal";
                            break;
                        default:
                            break;
                    }

                    //we want all nullable types in the model, so that they are not serialized/initialized with default values
                    if (csTypeName == "bool" || csTypeName == "DateTimeOffset" || csTypeName == "DateTime" || csTypeName == "int" || csTypeName == "double" || csTypeName == "decimal")
                    {
                        csTypeName += "?";
                    }

                    gen.AppendLine(string.Format("\t\tpublic {0} {1} {{ get; set; }}", csTypeName, fieldMapping.Name ?? field.Name));
                    gen.AppendLine();

                    if (field.Type == "reference" && config.IncludeReferences)
                    {
                        var relationshipfieldMapping = classMapping.Field(field.RelationshipName);

                        if (string.IsNullOrEmpty(field.RelationshipName) || field.ReferenceTo.Count > 1 || relationshipfieldMapping.Ignore)
                        {
                            //only do single-object relationships
                            continue;
                        }

                        if(field.RelationshipName == "ContentBody")
                        {
                            //exception for non-serializable type
                            continue;
                        }

                        var targetMapping = config.Mapping(field.ReferenceTo[0]);

                        if (targetMapping.Ignore) // if we ignore the target class --> ignore the relationship
                            continue;

                        string referenceClass = GetPrefixedSuffixed(config, targetMapping.Name ?? field.ReferenceTo[0]);

                        if (!string.IsNullOrEmpty(config.ClassNamespace) && config.AddNetCoreForceModelsUsings)
                            referenceClass = config.ClassNamespace + "." + referenceClass;

                        gen.AppendLine("\t\t///<summary>");
                        gen.AppendLine("\t\t/// ReferenceTo: " + field.ReferenceTo[0]);
                        gen.AppendLine("\t\t/// <para>RelationshipName: " + field.RelationshipName + "</para>");
                        gen.AppendLine("\t\t///</summary>");
                        gen.AppendLine(string.Format("\t\t[JsonProperty(PropertyName = \"{0}\")]", JsonName(field.RelationshipName)));
                        gen.AppendLine("\t\t[Updateable(false), Createable(false)]");

                        

                        gen.AppendLine(string.Format("\t\tpublic {0} {1} {{ get; set; }}", referenceClass, relationshipfieldMapping.Name ?? field.RelationshipName));
                        gen.AppendLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception generating models: " + ex.Message);
                    throw ex;
                }
            }

            gen.AppendLine("\t}");
            if (!string.IsNullOrEmpty(config.ClassNamespace))
            {
                gen.AppendLine("}");
            }

            string result = gen.ToString();

            return result;
        }

        private static string GetPrefixedSuffixed(GenConfig config, string name)
        {
            return string.Format("{0}{1}{2}", config.ClassPrefix ?? string.Empty, name, config.ClassSuffix ?? string.Empty);
        }

        private static string JsonName(string fieldName)
        {
            string jsonName = fieldName;
            string first = jsonName.Substring(0, 1).ToLower();
            jsonName = first + jsonName.Substring(1, jsonName.Length - 1);
            return jsonName;
        }
    }
}