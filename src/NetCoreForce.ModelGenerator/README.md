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
dotnet modelgenerator --help
```

```
Usage: modelgenerator generate [options]


Options:
  -?|-h|--help                       Show help information
  -o|--objects <objects>             Object models to generate, if omitted all objects will be generated
  -d|--output-directory <directory>  Destination directory for generated file(s)
  -s|--suffix <suffix>               Suffix to append to object names, e.g. 'Sf' for 'AccountSf'
  -p|--prefix <prefix>               Prefix to for object names, e.g. 'Sf' for 'SfAccount'
  -n|--namespace <namespace>         Namespace to use for generated classes
  -c|--include-custom                Include custom objects and fields
  -r|--include-references            Include referenced objects as properties
```

  There are a few SObjects that either have reserved names (e.g. Namespace, Domain), or may otherwise cause confustion with other C# objects (e.g. Task).
  To avoid this, the prefix/suffix option can append a prefix/suffix to the class names, e.g use a "Sf" prefix to end up with SfTask instead of Task.
  Using the prefix is recommended - it is safer, and it makes intellisense easier since you can start with "Sf" to filter the SF object models.
  the <Summary> tags on the generated classes will specify the original SObject name, exposed by the static SObjectTypeName property.

 ## Example usage
  ```
  dotnet modelgenerator generate -p Sf -r -c -n MyProject.Models -d ~/git/myproject.models 
  ```
  * Prefix classes with "Sf"
  * Include referenced objects
  * Include custom objects
  * Use the "MyProject.Models" namespace
  * Place the generated classes in ~/git/myproject.models
