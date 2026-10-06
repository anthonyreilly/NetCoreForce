# NetCoreForce.ModelGenerator

A .NET CLI tool that generates C# model classes from your Salesforce org, optionally including custom objects and custom fields. It generates one file per class, named `[ClassName].cs`, for use with [NetCoreForce.Client](https://www.nuget.org/packages/NetCoreForce.Client/).

Documentation: [https://netcoreforce.com/](https://netcoreforce.com/)

## Install

Requires .NET 8.0 or later.

```
dotnet tool install --global NetCoreForce.ModelGenerator
```

To update an existing install:
```
dotnet tool update --global NetCoreForce.ModelGenerator
```

The tool is then available as a global command:
```
NetCoreForce.ModelGenerator generate --help
```

## Authentication

The generator logs in to Salesforce using an OAuth 2.0 flow, set with the `--auth-method` option or the `authMethod` config file setting:

| Auth method | Value | Required settings |
|---|---|---|
| Client Credentials (recommended) | `2` or `ClientCredentials` | Client ID, client secret, and your org's My Domain token endpoint |
| Username-Password | `1` or `UsernamePassword` | Client ID, client secret, username, and password |

The client ID and secret are the Consumer Key and Consumer Secret from your org's connected app or external client app.

**Client Credentials** requires your org's My Domain token endpoint, e.g. `https://your-domain.my.salesforce.com/services/oauth2/token`, rather than the default `https://login.salesforce.com/services/oauth2/token`. The connected app must have the Client Credentials flow enabled, with a run-as user assigned. If no token endpoint is given, the generator prompts for one.

**Username-Password** is deprecated by Salesforce. It's blocked by default in orgs created in Summer '23 or later, and admins can disable it in any org, so it may not be available in your org. Use Client Credentials where possible.

## Usage

Generate models for Account and Contact using Client Credentials:
```
NetCoreForce.ModelGenerator generate --auth-method ClientCredentials --client-id your_client_id --client-secret your_client_secret --token-request-endpoint https://your-domain.my.salesforce.com/services/oauth2/token -o Account -o Contact -p Sf -n MyProject.Models -d ./Models
```

Generate models including custom objects and referenced objects:
```
NetCoreForce.ModelGenerator generate -p Sf -r -c -n MyProject.Models -d ~/git/myproject.models
```
* Prefix classes with "Sf"
* Include referenced objects
* Include custom objects and fields
* Use the "MyProject.Models" namespace
* Place the generated classes in ~/git/myproject.models

Any required settings not given as options or in a config file are prompted for interactively, including the auth method, credentials, objects to generate, and namespace.

### Options

| Option | Description |
|---|---|
| `--auth-method` | Auth method: `1` / `UsernamePassword` or `2` / `ClientCredentials` |
| `--client-id` | API client ID, a.k.a. Consumer Key |
| `--client-secret` | API client secret, a.k.a. Consumer Secret |
| `--username` | API username (Username-Password only) |
| `--password` | API password (Username-Password only) |
| `--token-request-endpoint` | Token request endpoint, default `https://login.salesforce.com/services/oauth2/token`. Required for Client Credentials. |
| `--config-file` | Config file path |
| `--save-config` | Save the options to the config file given by `--config-file`, or `modelgenerator_config.json` by default |
| `-o\|--objects <objects>` | Object to generate. Repeat for multiple objects, or use `all` |
| `-d\|--output-directory <directory>` | Destination directory for the generated files, created if it doesn't exist. Defaults to the current directory. |
| `-p\|--prefix <prefix>` | Prefix for class names, e.g. `Sf` for `SfAccount` |
| `-s\|--suffix <suffix>` | Suffix for class names, e.g. `Sf` for `AccountSf` |
| `-n\|--namespace <namespace>` | Namespace for the generated classes |
| `-c\|--include-custom` | Include custom objects and fields |
| `-r\|--include-references` | Include referenced objects as properties |
| `-?\|-h\|--help` | Show help |

**Generating all objects:** to generate all queryable objects, use `-o all`, add `"all"` as the first or only item in the `Objects` array of the config file, or enter `all` when prompted.

**Referenced objects:** with the `-r`/`--include-references` option, the generated classes may not compile if a referenced object wasn't also generated. For instance, the Salesforce User object is referenced by many objects. Either generate the referenced objects too, or remove those properties from the generated classes.

## Configuration

A config file is optional. Settings given as command options override those in the config file.

By default the generator looks for `modelgenerator_config.json` in the current directory. Use `--config-file` to load a different file, and `--save-config` to save the current options, including any values entered at the prompts, so you don't need to re-enter them next time.

The config file can contain your API credentials, so keep it secure and out of source control.

The `apiVersion` setting controls the Salesforce API version used to generate the models, and defaults to `v67.0`.

### Example config file

Client Credentials:
```json
{
  "AuthInfo": {
    "authMethod": 2,
    "clientId": "your_client_id",
    "clientSecret": "your_client_secret",
    "tokenRequestEndpoint": "https://your-domain.my.salesforce.com/services/oauth2/token",
    "apiVersion": "v67.0"
  },
  "OutputDirectory": "Models",
  "Objects": [
    "Account",
    "Contact"
  ],
  "ClassPrefix": "Sf",
  "ClassSuffix": null,
  "ClassNamespace": "MyProject.Models",
  "IncludeCustom": true,
  "IncludeReferences": true
}
```

For Username-Password, set `"authMethod": 1` and add `"username"` and `"password"` to `AuthInfo`.

## Object Naming

A few Salesforce objects have names that are reserved or easily confused in C#, such as **Namespace**, **Domain**, **Case**, and **Task**. Use the prefix or suffix option to avoid this, e.g. a "Sf" prefix generates `SfTask` instead of `Task`.

Using a prefix is recommended. It avoids naming conflicts, and makes the models easy to find in IntelliSense by typing the prefix. Each generated class records the original Salesforce object name in its summary documentation, and exposes it through the static `SObjectTypeName` property.

## Links

- [Documentation](https://netcoreforce.com/)
- [NetCoreForce.Client](https://www.nuget.org/packages/NetCoreForce.Client/)
- [NetCoreForce.Models](https://www.nuget.org/packages/NetCoreForce.Models/) - pre-generated models for standard objects
- [GitHub repository](https://github.com/anthonyreilly/NetCoreForce)

Licensed under the MIT license.
