This is a set of model objects generated from a generic Salesforce Org, wihout any custom objects or fields.

Although using these models is optional, having strongly typed model objects is preferable in most cases. In addition to these predefined models, you can use the ModelGenerator tool to generate these classes against your own Org's data, including custom objects and custom fields.

If you just need to add a few custom fields, you can just inherit the class and add the properties as needed:
```csharp
public class MyCustomAccount : SfAccount
{
    public string MyCustomField__c { get; set; }
    public string MyOtherField__c { get; set; }
}
```

The pre-generated classes are all prefixed with "Sf", e.g. SfAccount, SfContact.
This was done to avoid a few object naming conflicts with reserved names such as **Namespace** and **Domain**, as well as some other objects that could cause class confusion such as **Case** and **Task**. This has the added bonus of making the model objects very easy to filter in Intellisense by typing "Sf" to get the list in your editor. The ModelGenerator can regenerate these with the plain object names, or another combination of prefixes and suffixes, if preferred.

Each object field is annotated with some basic Salesforce metadata, from the Label, Name, Type, and Custom flags.

```csharp
///<summary>
/// Account ID
/// <para>Name: Id</para>
/// <para>SF Type: id</para>
/// <para>Custom: False</para>
///</summary>
[JsonProperty(PropertyName = "id")]
[Updateable(false), Createable(false)]
public string Id { get; set; }
```
They are also decorated with the **Updatedable** and **Creatable** attributes. These attributes control serialization behavior when creating and updating object records in Salesforce. The properties will be selectively serialized as appropriate for API action being called.  
For instance, the Id field can never be supplied when creating or updating an object, as it is assigned by the system. While it will be deserialized when retrieving data, on creation and update it will be omitted from the request.

Properties that can be used on both create and updates can omit the attributes entirely and they will default to **true**:
```csharp
[JsonProperty(PropertyName = "name")]
public string Name { get; set; }
```
This is the same as:
```csharp
[JsonProperty(PropertyName = "name")]
[Updateable(true), Createable(true)]
public string Name { get; set; }
```

Object relationships are included in the models.
```csharp
///<summary>
/// ReferenceTo: Account
/// <para>RelationshipName: Parent</para>
///</summary>
[JsonProperty(PropertyName = "parent")]
[Updateable(false), Createable(false)]
public SfAccount Parent { get; set; }
```
This is primarily to support query results, where you might query Parent.Name to get a parent account object. That related object and field will be deserialized into that relationship property.

Typically non-nullable types (e.g. int, decimal) are in the models as nullable properties (e.g. int?, decimal?). Most SF fields are flagged as "nillable" and may return null in results. If they are not made nullable, a null field can deserialize to the default value, e.g. int = 0, instead of the null value. The JSON serializer is set to not serialize null values.