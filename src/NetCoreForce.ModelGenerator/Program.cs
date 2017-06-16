using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Reflection;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.CommandLineUtils;
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
            while (config.Objects.Count < 1)
            {
                Console.WriteLine("Enter an object to generate:");
                config.Objects.Add(Console.ReadLine());
                Console.WriteLine();
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

            //config.ApiVersion = client.ApiVersion;

            //should we keep the __c on custom objects/fields?

#if DEBUG
            //basic set of objects with complete referential integrity
            // if (config.Objects == null || config.Objects.Count == 0)
            // {
            //     config.Objects = new List<string>() { "User", "UserLicense", "UserRole", "Profile", "BusinessHours", "RecordType", "Account", "Contact", "Asset", "Case", "Product2"};
            // }
#endif

            var global = await client.DescribeGlobal();

            if (string.IsNullOrEmpty(config.OutputDirectory))
            {
                config.OutputDirectory = Directory.GetCurrentDirectory();
            }

            Console.WriteLine("Output directory: " + config.OutputDirectory);
            Console.WriteLine("included: " + string.Join(", ", config.Objects));

            foreach (var obj in global.SObjects)
            {
                //dont include non queryable?
                if (!obj.Queryable)
                {
                    //Console.WriteLine("Skipping " + obj.Name);
                    continue;
                }

                if (config.Objects != null && config.Objects.Count > 0)
                {
                    bool incl = config.Objects.Where(o => o.ToLowerInvariant() == obj.Name.ToLowerInvariant()).Count() > 0;
                    if (!incl)
                    {
                        //Console.WriteLine("Skipping " + obj.Name);
                        continue;
                    }
                }

                // Name and Domain non-queryable objects cause compiler errors due to name/member dupe

                Console.Write("Generating model for {0} - ", obj.Name);

                //TODO: see if there is a better way to clean up object nameing (or if it should be done at all)
                //string className = obj.Name.Replace("__c", "");

                string className = obj.Name;

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
            gen.AppendLine("using NetCoreForce.Client.Models;");
            gen.AppendLine("using NetCoreForce.Client.Attributes;");
            gen.AppendLine("using Newtonsoft.Json;");
            gen.AppendLine();
            if (!string.IsNullOrEmpty(config.ClassNamespace))
            {
                gen.AppendLine("namespace " + config.ClassNamespace);
                gen.AppendLine("{");
            }
            gen.AppendLine("\t///<summary>");
            gen.AppendLine($"\t/// {data.Label}");
            gen.AppendLine($"\t///<para>SObject Name: {data.Name}</para>");
            gen.AppendLine($"\t///<para>Custom Object: {data.Custom.ToString()}</para>");
            gen.AppendLine("\t///</summary>");
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

            foreach (var field in data.Fields)
            {
                try
                {
                    if (field.Custom && !config.IncludeCustom)
                    {
                        continue;
                    }

                    gen.AppendLine("\t\t///<summary>");
                    gen.AppendLine("\t\t/// " + field.Label);
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

                    gen.AppendLine(string.Format("\t\t[JsonProperty(PropertyName = \"{0}\")]", JsonName(field.Name)));

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
                    if (csTypeName == "bool" || csTypeName == "DateTimeOffset" || csTypeName == "int" || csTypeName == "double" || csTypeName == "decimal")
                    {
                        csTypeName += "?";
                    }

                    gen.AppendLine(string.Format("\t\tpublic {0} {1} {{ get; set; }}", csTypeName, field.Name.Replace("__c", "")));
                    gen.AppendLine();

                    if (field.Type == "reference" && config.IncludeReferences)
                    {
                        if (string.IsNullOrEmpty(field.RelationshipName) || field.ReferenceTo.Count > 1)
                        {
                            //only do single-object relationships
                            continue;
                        }

                        gen.AppendLine("\t\t///<summary>");
                        gen.AppendLine("\t\t/// ReferenceTo: " + field.ReferenceTo[0]);
                        gen.AppendLine("\t\t/// <para>RelationshipName: " + field.RelationshipName + "</para>");
                        gen.AppendLine("\t\t///</summary>");
                        gen.AppendLine(string.Format("\t\t[JsonProperty(PropertyName = \"{0}\")]", JsonName(field.RelationshipName)));
                        gen.AppendLine("\t\t[Updateable(false), Createable(false)]");

                        string referenceClass = GetPrefixedSuffixed(config, field.ReferenceTo[0]);

                        gen.AppendLine(string.Format("\t\tpublic {0} {1} {{ get; set; }}", referenceClass, field.RelationshipName));
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