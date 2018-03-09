This component is currently alpha/pre-release status

The goal is to provide a way to query Salesforce objects in a LINQ like way:

```csharp
    var singleCase = await client
                    .Query<SfCase>()
                    .Select(c => new SfCase
                    {
                        Id = c.Id,
                        CaseNumber = c.CaseNumber,
                        SystemModstamp = c.SystemModstamp,
                        Account = new SfAccount
                        {
                            Name = c.Account.Name,
                            SystemModstamp = c.Account.SystemModstamp
                        },
                        Contact = new SfContact
                        {
                            Name = c.Contact.Name,
                            SystemModstamp = c.Contact.SystemModstamp
                        }
                    })
                    .FirstOrDefault();
```

Portions of this code came from the [IQToolkit](https://github.com/mattwar/iqtoolkit)

NuGet Package: [NetCoreForce.Linq](https://www.nuget.org/packages/NetCoreForce.Linq/)