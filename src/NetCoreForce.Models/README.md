# NetCoreForce.Models

Strongly typed C# model classes for the standard Salesforce objects, such as Account, Contact, Opportunity and Case, for use with the [NetCoreForce.Client](https://www.nuget.org/packages/NetCoreForce.Client/) Salesforce REST API library for .NET.

The models were generated from a standard Salesforce org using Salesforce API v67.0. They don't include any custom objects or custom fields.

Documentation: [https://netcoreforce.com/](https://netcoreforce.com/)

## Install

```
dotnet add package NetCoreForce.Models
```

## Usage

```csharp
List<SfContact> contacts = await client.Query<SfContact>("SELECT Id, FirstName, LastName, Email, Account.Name FROM Contact");

SfAccount account = await client.GetObjectById<SfAccount>(SfAccount.SObjectTypeName, "001XXXXXXXXXXXXXXX");
```

Each class exposes its Salesforce object name through the static `SObjectTypeName` property, e.g. `SfAccount.SObjectTypeName` is `"Account"`.

Using these models is optional, but strongly typed models are preferable in most cases.

## Custom Objects and Fields

To generate models for your own org, including custom objects and custom fields, use the [NetCoreForce.ModelGenerator](https://www.nuget.org/packages/NetCoreForce.ModelGenerator/) tool. It can also generate models for a newer Salesforce API version.

If you only need to add a few custom fields, you can inherit from a model class and add the properties:
```csharp
public class MyCustomAccount : SfAccount
{
    [JsonProperty(PropertyName = "myCustomField__c")]
    public string MyCustomField__c { get; set; }
}
```

## Naming

The classes are all prefixed with "Sf", e.g. `SfAccount`, `SfContact`. This avoids naming conflicts with reserved names such as **Namespace** and **Domain**, and confusion with common .NET types such as **Case** and **Task**. It also makes the models easy to find in IntelliSense by typing "Sf". The ModelGenerator can generate the classes with plain object names, or another prefix or suffix, if preferred.

## Field Metadata and Serialization

Each field is annotated with basic Salesforce metadata: the label, name, type, and whether it is nillable.

```csharp
///<summary>
/// Account ID
/// <para>Name: Id</para>
/// <para>SF Type: id</para>
/// <para>Nillable: False</para>
///</summary>
[JsonProperty(PropertyName = "id")]
[Updateable(false), Createable(false)]
public string Id { get; set; }
```

The **Updateable** and **Createable** attributes control which properties are serialized when creating and updating records, so each request only includes the fields appropriate for that operation. For example, the Id field is assigned by Salesforce and can never be set on create or update, so it is deserialized when retrieving records but omitted from create and update requests.

Properties that can be used on both create and update omit the attributes, which default to **true**:
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

## Relationships

Object relationships are included in the models:
```csharp
///<summary>
/// ReferenceTo: Account
/// <para>RelationshipName: Parent</para>
///</summary>
[JsonProperty(PropertyName = "parent")]
[Updateable(false), Createable(false)]
public SfAccount Parent { get; set; }
```
This supports query results that include related objects. For example, querying `Parent.Name` on Account deserializes the related account into the `Parent` property. To set or change a relationship, update the lookup Id field instead, e.g. `ParentId`.

## Nullable Values

Value types such as `int` and `decimal` are generated as nullable properties (`int?`, `decimal?`), since most Salesforce fields can be null. A non-nullable property would deserialize a null field as its default value, e.g. `0`, instead of null.

Null properties are not serialized by default, so setting a property to `null` leaves the field unchanged when updating a record. To clear a field, set it to `null` and include its name in the `fieldsToNull` parameter of `UpdateRecord`. See the [Examples](https://netcoreforce.com/examples.html#setting-a-field-to-null) for details.

## Links

- [Documentation](https://netcoreforce.com/)
- [NetCoreForce.Client](https://www.nuget.org/packages/NetCoreForce.Client/)
- [NetCoreForce.ModelGenerator](https://www.nuget.org/packages/NetCoreForce.ModelGenerator/)
- [GitHub repository](https://github.com/anthonyreilly/NetCoreForce)

Licensed under the MIT license.
