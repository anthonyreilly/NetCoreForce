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
                command.Description = "Generate SObject models";
                command.HelpOption("-?|-h|--help");

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
                    GenConfig config = new GenConfig()
                    {
                        IncludeCustom = customOption.HasValue(),
                        Objects = includeOption.Values,
                        ClassPrefix = prefixOption.Value(),
                        ClassSuffix = suffixOption.Value(),
                        ClassNamespace = namespaceName.Value(),
                        OutputDirectory = outputDirectory.Value(),
                        IncludeReferences = includeReferences.HasValue()
                    };

                    Console.Write("Generate models for " + string.Join(", ", includeOption.Values));

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

        private static AuthInfo GetAuthInfo(string filePath = null)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath))
                {
                    string executabledirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
                    string fileName = "credentials.json";
                    filePath = Path.Combine(executabledirectory, fileName);
                }

                Console.WriteLine("Reading credentials file {0}", filePath);

                string contents = File.ReadAllText(filePath);
                AuthInfo info = JsonConvert.DeserializeObject<AuthInfo>(contents);
                return info;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading credentials file: " + ex.Message);
                throw ex;
            }
        }

        private static async Task<ForceClient> Login()
        {
            AuthInfo authInfo = GetAuthInfo();

            AuthenticationClient auth = new AuthenticationClient();
            try
            {
                await auth.UsernamePasswordAsync(authInfo.ClientId, authInfo.ClientSecret,
                    authInfo.Username, authInfo.Password, authInfo.TokenRequestEndpoint);
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
            ForceClient client = await Login();

            config.ApiVersion = client.ApiVersion;

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

                string className = obj.Name.Replace("__c", "");
                className = string.Format("{0}{1}{2}", config.ClassPrefix ?? string.Empty, className, config.ClassSuffix ?? string.Empty);

                await CreateModel(client, obj.Name, className, config);

                //Console.WriteLine("Generated model for " + obj.Name);

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
            gen.AppendLine("// SF API version " + config.ApiVersion);
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
                    if(field.AutoNumber)
                    {
                        gen.AppendLine("\t\t/// <para>AutoNumber field</para>");
                    }
                    //gen.AppendLine("\t\t/// <para>Custom: " + field.Custom.ToString() + "</para>");
                    if(field.Custom)
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