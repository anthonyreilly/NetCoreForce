# NetCoreForce.ModelGenerator  

Generates model classes according to your enviroment, optionally including any custom objects or fields. One file per class, named [ClassName].cs

This is packaged as a custom dotnet CLI tool. You can add it via
```
dotnet add package NetCoreForce.ModelGenerator
```
However, you may need to manually update your csproj to add it as a DotNetCliToolReference like other CLI tools, since currently the add package commands will incorrectly add it as a dependency:

```xml
<ItemGroup>
  <DotNetCliToolReference Include="NetCoreForce.ModelGenerator" Version="X.X.X" />
</ItemGroup>
```

Then you will be able to use the tool by invoking it as a dotnet command:
```
dotnet modelgenerator generate --help

Usage: modelgenerator generate [options]

Options:
  -?|-h|--help                       Show help information
  --client-id                        API Client ID, a.k.a. Consumer Key
  --client-secret                    API Client Secret, a.k.a. Consumer Secret
  --username                         API Username
  --password                         API Password
  --config-file                      Config file path
  --save-config                      Save options to config file, uses filename from --config-file option
  -o|--objects <objects>             Object models to generate, if omitted all objects will be generated
  -d|--output-directory <directory>  Destination directory for generated file(s)
  -s|--suffix <suffix>               Suffix to append to object names, e.g. 'Sf' for 'AccountSf'
  -p|--prefix <prefix>               Prefix to for object names, e.g. 'Sf' for 'SfAccount'
  -n|--namespace <namespace>         Namespace to use for generated classes
  -c|--include-custom                Include custom objects and fields
  -r|--include-references            Include referenced objects as properties

You can supply the API credentials either in the config file, the command parameters, or wait to be prompted for that information.
If you choose to save the config file, be careful with it as it may contain your API credentials.
```

  There are a few SObjects that either have reserved names (e.g. Namespace, Domain), or may otherwise cause confustion with other C# objects (e.g. Task).
  To avoid this, the prefix/suffix option can append a prefix/suffix to the class names, e.g use a "Sf" prefix to end up with SfTask instead of Task.
  Using the prefix is recommended - it is safer, and it makes intellisense easier since you can start with "Sf" to filter the SF object models.
  the triple-slash Summary documentation tags on the generated classes will specify the original SObject name, exposed by the static SObjectTypeName property.

## Configuration

No configuration file is required, however you can indlude the --save-config option with an optional filename or file path to save the API credentials and generation options to. the filename will default to modelgenerator-config.json in the local directory for saving and loading if not otherwise specified.

## Example usage
  ```
  dotnet modelgenerator generate -p Sf -r -c -n MyProject.Models -d ~/git/myproject.models 
  ```
  * Prefix classes with "Sf"
  * Include referenced objects
  * Include custom objects
  * Use the "MyProject.Models" namespace
  * Place the generated classes in ~/git/myproject.models

### Example config file
```json
{
  "comment": "Example config file - Make a copy of this file named modegenerator_config.json with your login info",
  "AuthInfo": {    
    "clientId": "your_client_id",
    "clientSecret": "your_client_secret",
    "username": "username",
    "password": "password",
    "apiVersion": "v39.0",
    "authorizationEndpoint": "https://login.salesforce.com/services/oauth2/authorize",
    "tokenRequestEndpoint": "https://login.salesforce.com/services/oauth2/token",
    "tokenRevocationEndpoint": "https://login.salesforce.com/services/oauth2/revoke"
  },
  "OutputDirectory": null,
  "Objects": [
    "Account",
    "Contact"
  ],
  "ClassPrefix": "Sf",
  "ClassSuffix": null,
  "ClassNamespace": "NetCoreForce.Models",
  "IncludeCustom": true,
  "IncludeReferences": true
}
```

Note: if you use the -r/--include-references option, you may run into compile errors with missing classes. For instance, the Salesforce "User" object appears on many objects - if you didnt include this in your list of models to generate, you will either need to include it, or manually remove those properties from the generated classes.
