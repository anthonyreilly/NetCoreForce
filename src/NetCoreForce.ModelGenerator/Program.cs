using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using McMaster.Extensions.CommandLineUtils;
using NetCoreForce.Client;
using NetCoreForce.Client.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NetCoreForce.ModelGenerator
{
    class Program
    {
        /// <summary>
        /// Gets a human-readable string for which value maps to which auth method type
        /// </summary>
        /// <returns>
        /// For example: <c>1 or UsernamePassword, 2 or ClientCredentials</c>
        /// </returns>
        private static string ValidAuthTypesInputString =>
            string.Join(", ", Enum.GetValues(typeof(AuthInfo.AuthMethodType)).Cast<AuthInfo.AuthMethodType>().Select(v => $"{(int)v} or {v}"));

        const string defaultConfigFilename = "modelgenerator_config.json";

        //environment variables for secrets - command line options are visible in shell history and process listings
        const string ClientSecretEnvVar = "NETCOREFORCE_CLIENT_SECRET";
        const string PasswordEnvVar = "NETCOREFORCE_PASSWORD";

        static int Main(string[] args)
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
                "Client Credentials is the recommended auth method - Salesforce has deprecated the Username-Password flow, and it may be disabled in your org." + Environment.NewLine +
                "If you choose to save the config file, be careful with it as it may contain your API credentials.";

                //Authentication options
                var clientIdOption = command.Option("--client-id",
                    "API Client ID, a.k.a. Consumer Key",
                    CommandOptionType.SingleValue);

                var clientSecretOption = command.Option("--client-secret",
                    "API Client Secret, a.k.a. Consumer Secret",
                    CommandOptionType.SingleValue);

                var usernameOption = command.Option("--username",
                    "API Username (UsernamePassword auth method only)",
                    CommandOptionType.SingleValue);

                var passwordOption = command.Option("--password",
                    "API Password (UsernamePassword auth method only)",
                    CommandOptionType.SingleValue);

                var authMethodOption = command.Option("--auth-method",
                    $"Auth method, valid inputs: {ValidAuthTypesInputString}",
                    CommandOptionType.SingleValue);

                var tokenRequestEndpointOption = command.Option("--token-request-endpoint",
                    $"Token request endpoint, default: {GenConfig.DefaultTokenRequestEndpoint}. The ClientCredentials auth method requires your org's My Domain token endpoint, e.g. https://your-domain.my.salesforce.com/services/oauth2/token",
                    CommandOptionType.SingleValue);

                //Config options
                var configFileOption = command.Option("--config-file",
                    $"Config file path, default: {defaultConfigFilename} in the current directory",
                    CommandOptionType.SingleValue);

                var saveConfigOption = command.Option("--save-config",
                    "Save options to the config file, using the --config-file path if specified",
                    CommandOptionType.NoValue);

                //generation options
                var includeOption = command.Option("-o|--objects <objects>",
                    "Object model to generate. Repeat for multiple objects, or use 'all' to generate all objects. If omitted, you will be prompted",
                    CommandOptionType.MultipleValue);

                var outputDirectory = command.Option("-d|--output-directory <directory>",
                    "Destination directory for generated file(s), created if it doesn't exist. Defaults to the current directory",
                    CommandOptionType.SingleValue);

                var suffixOption = command.Option("-s|--suffix <suffix>",
                    "Suffix to append to object names, e.g. 'Sf' for 'AccountSf'",
                    CommandOptionType.SingleValue);

                var prefixOption = command.Option("-p|--prefix <prefix>",
                    "Prefix to prepend to object names, e.g. 'Sf' for 'SfAccount'",
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

                    //secrets: command line option, then environment variable, then config file, then prompt
                    if (clientSecretOption.HasValue())
                    {
                        WarnSecretOnCommandLine("--client-secret", ClientSecretEnvVar);
                        config.AuthInfo.ClientSecret = clientSecretOption.Value();
                    }
                    else if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable(ClientSecretEnvVar)))
                    {
                        config.AuthInfo.ClientSecret = Environment.GetEnvironmentVariable(ClientSecretEnvVar);
                    }

                    if (usernameOption.HasValue())
                    {
                        config.AuthInfo.Username = usernameOption.Value();
                    }

                    if (passwordOption.HasValue())
                    {
                        WarnSecretOnCommandLine("--password", PasswordEnvVar);
                        config.AuthInfo.Password = passwordOption.Value();
                    }
                    else if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable(PasswordEnvVar)))
                    {
                        config.AuthInfo.Password = Environment.GetEnvironmentVariable(PasswordEnvVar);
                    }

                    if (authMethodOption.HasValue())
                    {
                        if (Enum.TryParse(authMethodOption.Value(), ignoreCase: true, out AuthInfo.AuthMethodType authMethod))
                            config.AuthInfo.AuthMethod = authMethod;
                        else
                        {
                            Console.WriteLine($"Invalid auth method input, valid inputs: {ValidAuthTypesInputString}");
                            return 1;
                        }
                    }

                    if (tokenRequestEndpointOption.HasValue())
                    {
                        config.AuthInfo.TokenRequestEndpoint = tokenRequestEndpointOption.Value();
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

                    if (namespaceName.HasValue())
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

                    //these are written into the generated source
                    CodeGenValidation.Affix(config.ClassPrefix, "Class prefix");
                    CodeGenValidation.Affix(config.ClassSuffix, "Class suffix");
                    CodeGenValidation.Namespace(config.ClassNamespace);

                    if (saveConfigOption.HasValue())
                    {
                        SaveConfig(config, configFileOption.Value());
                    }

                    //check the output directory before logging in, so an invalid path fails fast
                    if (!EnsureOutputDirectory(config))
                    {
                        return 1;
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
                return app.Execute(args);
            }
            catch (CommandParsingException ex)
            {
                Console.WriteLine(ex.Message);
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to execute application: {0}", ex.Message);
                return 1;
            }
        }

        /// <summary>
        /// Checks that the minimum required options are supplied, otherwise prompts user to enter them immediately
        /// </summary>
        private static GenConfig CheckOptions(GenConfig config)
        {
            //check required auth options
            while (config.AuthInfo.AuthMethod == null)
            {
                Console.WriteLine("Enter Auth Method:");
                string consoleReadLine = Console.ReadLine();

                if (Enum.TryParse(consoleReadLine, ignoreCase: true, out AuthInfo.AuthMethodType authMethod))
                    config.AuthInfo.AuthMethod = authMethod;
                else
                    Console.WriteLine($"Invalid input, valid inputs: {ValidAuthTypesInputString}");

                Console.WriteLine();
            }

            while ((
                       string.IsNullOrEmpty(config.AuthInfo.TokenRequestEndpoint) ||
                       config.AuthInfo.TokenRequestEndpoint == GenConfig.DefaultTokenRequestEndpoint
                   ) &&
                   config.AuthInfo.AuthMethod == AuthInfo.AuthMethodType.ClientCredentials)
            {
                Console.WriteLine("Enter Token Request Endpoint:");
                config.AuthInfo.TokenRequestEndpoint = Console.ReadLine();
                Console.WriteLine();
            }

            while (string.IsNullOrEmpty(config.AuthInfo.ClientId))
            {
                Console.WriteLine("Enter API Client ID:");
                config.AuthInfo.ClientId = Console.ReadLine();
                Console.WriteLine();
            }

            while (string.IsNullOrEmpty(config.AuthInfo.ClientSecret))
            {
                Console.WriteLine("Enter API Client Secret:");
                config.AuthInfo.ClientSecret = ReadSecret();
                Console.WriteLine();
            }

            while (string.IsNullOrEmpty(config.AuthInfo.Username) && config.AuthInfo.AuthMethod == AuthInfo.AuthMethodType.UsernamePassword)
            {
                Console.WriteLine("Enter API username:");
                config.AuthInfo.Username = Console.ReadLine();
                Console.WriteLine();
            }

            while (string.IsNullOrEmpty(config.AuthInfo.Password) && config.AuthInfo.AuthMethod == AuthInfo.AuthMethodType.UsernamePassword)
            {
                Console.WriteLine("Enter API password:");
                config.AuthInfo.Password = ReadSecret();
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

        /// <summary>
        /// Read a secret from the console without echoing it. Falls back to a plain read when input is redirected.
        /// </summary>
        private static string ReadSecret()
        {
            if (Console.IsInputRedirected)
            {
                return Console.ReadLine();
            }

            StringBuilder secret = new StringBuilder();
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(intercept: true);
                if (key.Key == ConsoleKey.Enter)
                {
                    break;
                }

                if (key.Key == ConsoleKey.Backspace)
                {
                    if (secret.Length > 0)
                    {
                        secret.Length--;
                    }
                    continue;
                }

                if (!char.IsControl(key.KeyChar))
                {
                    secret.Append(key.KeyChar);
                }
            }

            Console.WriteLine();
            return secret.ToString();
        }

        private static void WarnSecretOnCommandLine(string optionName, string envVarName)
        {
            Console.Error.WriteLine($"Warning: {optionName} exposes the secret in shell history and process listings. Set the {envVarName} environment variable instead, or omit it to be prompted.");
        }

        /// <summary>
        /// Resolves the output directory, defaulting to the current directory, and creates it if it doesn't exist
        /// </summary>
        /// <returns>True if the output directory exists or was created</returns>
        private static bool EnsureOutputDirectory(GenConfig config)
        {
            string outputDirectory = config.OutputDirectory;

            if (string.IsNullOrEmpty(outputDirectory))
            {
                outputDirectory = Directory.GetCurrentDirectory();
            }

            //expand a leading ~ to the user's home directory, since it isn't expanded by the shell when set in the config file
            if (outputDirectory == "~" || outputDirectory.StartsWith("~/") || outputDirectory.StartsWith("~\\"))
            {
                string homeDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                outputDirectory = Path.Combine(homeDirectory, outputDirectory.Substring(1).TrimStart('/', '\\'));
            }

            try
            {
                outputDirectory = Path.GetFullPath(outputDirectory);
                config.OutputDirectory = outputDirectory;

                if (Directory.Exists(outputDirectory))
                {
                    Console.WriteLine("Output directory: " + outputDirectory);
                }
                else
                {
                    Directory.CreateDirectory(outputDirectory);
                    Console.WriteLine("Created output directory: " + outputDirectory);
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unable to create output directory {outputDirectory}: {ex.Message}");
                return false;
            }
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
                if (!Path.IsPathRooted(filePath))
                {
                    filePath = Path.Combine(Directory.GetCurrentDirectory(), filePath);
                }

                Console.WriteLine($"Saving config file to {filePath}");

                //secrets are not saved - the file is easily committed or shared by mistake
                JObject contents = JObject.FromObject(config);
                if (contents["AuthInfo"] is JObject authInfo)
                {
                    authInfo.Remove("clientSecret");
                    authInfo.Remove("password");
                    authInfo.Remove("refreshToken");
                }

                File.WriteAllText(filePath, contents.ToString(Formatting.Indented), Encoding.Unicode);

                Console.WriteLine($"The client secret and password are not saved - set the {ClientSecretEnvVar} and {PasswordEnvVar} environment variables, or enter them when prompted.");

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
                if (!Path.IsPathRooted(filePath))
                {
                    filePath = Path.Combine(Directory.GetCurrentDirectory(), filePath);
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

            AuthenticationClient auth = new AuthenticationClient(config.AuthInfo.ApiVersion);

            //show where the credentials are being sent, so a config file pointing somewhere unexpected is noticed
            if (Uri.TryCreate(config.AuthInfo.TokenRequestEndpoint, UriKind.Absolute, out Uri tokenEndpoint))
            {
                Console.WriteLine($"Logging in via {tokenEndpoint.Host}");
            }

            try
            {
                switch (config.AuthInfo.AuthMethod)
                {
                    case AuthInfo.AuthMethodType.UsernamePassword:
                        await auth.UsernamePasswordAsync(config.AuthInfo.ClientId, config.AuthInfo.ClientSecret,
                            config.AuthInfo.Username, config.AuthInfo.Password, config.AuthInfo.TokenRequestEndpoint);
                        break;
                    case AuthInfo.AuthMethodType.ClientCredentials:
                        await auth.ClientCredentialsAsync(config.AuthInfo.ClientId, config.AuthInfo.ClientSecret,
                            config.AuthInfo.TokenRequestEndpoint);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(config.AuthInfo.AuthMethod), $"authMethodInt is out of range, value: {(int)config.AuthInfo.AuthMethod}");
                }

                Console.WriteLine("Connected to Salesforce");
            }
            catch (ForceAuthException ex)
            {
                Console.WriteLine("Error authenticating: " + ex.Message);
                throw;
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
                        bool incl = config.Objects.Where(o => o.ToLowerInvariant() == obj.Name.ToLowerInvariant()).Count() > 0;
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

                //the class name is also the file name, so it must not contain path characters
                string className = CodeGenValidation.Identifier(GetPrefixedSuffixed(config, CodeGenValidation.Identifier(obj.Name, "Object name")), "Class name");

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

            //names from the describe response are written into the generated source
            CodeGenValidation.Identifier(data.Name, "Object name");

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
            gen.AppendLine($"\t/// {DocCommentText(data.Label)}");
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

                    CodeGenValidation.Identifier(field.Name, $"Field name on {data.Name}");

                    gen.AppendLine("\t\t///<summary>");
                    gen.AppendLine("\t\t/// " + DocCommentText(field.Label));
                    gen.AppendLine("\t\t/// <para>Name: " + field.Name + "</para>");
                    gen.AppendLine("\t\t/// <para>SF Type: " + DocCommentText(field.Type) + "</para>");
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
                    if (csTypeName == "bool" || csTypeName == "DateTimeOffset" || csTypeName == "DateTime" || csTypeName == "int" || csTypeName == "double" || csTypeName == "decimal")
                    {
                        csTypeName += "?";
                    }

                    gen.AppendLine(string.Format("\t\tpublic {0} {1} {{ get; set; }}", csTypeName, field.Name));
                    gen.AppendLine();

                    if (field.Type == "reference" && config.IncludeReferences)
                    {
                        if (string.IsNullOrEmpty(field.RelationshipName) || field.ReferenceTo == null || field.ReferenceTo.Count != 1)
                        {
                            //only do single-object relationships
                            continue;
                        }

                        CodeGenValidation.Identifier(field.RelationshipName, $"Relationship name on {data.Name}");
                        CodeGenValidation.Identifier(field.ReferenceTo[0], $"Referenced object name on {data.Name}");

                        if(field.RelationshipName == "ContentBody")
                        {
                            //exception for non-serializable type
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
                    throw;
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

        /// <summary>
        /// Formats text for a single line XML doc comment - collapses line breaks and repeated whitespace, and encodes XML characters.
        /// <para>Some Salesforce labels contain line breaks, which would otherwise end the doc comment early and produce badly formed XML.</para>
        /// </summary>
        private static string DocCommentText(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            string singleLine = Regex.Replace(text, @"\s+", " ").Trim();
            return WebUtility.HtmlEncode(singleLine);
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