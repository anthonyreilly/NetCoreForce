using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xunit;
#if !XUNIT_V3
using Xunit.Abstractions;
#endif
using NetCoreForce.Client;
using NetCoreForce.Client.Models;

namespace NetCoreForce.FunctionalTests
{
    /// <summary>
    /// Manual only - describes every queryable object in the org, which makes hundreds of API calls.
    /// <para>The ModelGenerator validates object, field and relationship names before writing them into generated code.
    /// This checks that no legitimate name in a real org is rejected by that validation.</para>
    /// <para>.NET 8+ and .NET Framework 4.7.2+ (xUnit v3): marked Explicit. Run with:
    /// dotnet test -f net10.0 --filter "FullyQualifiedName~MetadataNameTests" -- xUnit.Explicit=on</para>
    /// <para>.NET Framework 4.6.2 (xUnit v2): Explicit is not supported, so the test is skipped. Temporarily remove the Skip to run it.</para>
    /// </summary>
    public class MetadataNameTests : IClassFixture<ForceClientFixture>
    {
        private const string ManualOnlyReason = "Manual only: describes every queryable object in the org, which makes hundreds of API calls.";

        // same rule as NetCoreForce.ModelGenerator CodeGenValidation.IdentifierRegex - keep in sync
        private static readonly Regex IdentifierRegex = new Regex(@"^[A-Za-z_][A-Za-z0-9_]*\z");

        ForceClientFixture forceClientFixture;
        ITestOutputHelper output;

        public MetadataNameTests(ForceClientFixture fixture, ITestOutputHelper output)
        {
            this.forceClientFixture = fixture;
            this.output = output;
        }

        //manual only, see class summary
#if XUNIT_V3
        [Fact(Explicit = true)]
#else
        [Fact(Skip = ManualOnlyReason)]
#endif
        public async Task AllMetadataNamesAreValidIdentifiers()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            DescribeGlobal global = await client.DescribeGlobal();

            List<string> invalidNames = new List<string>();
            List<string> describeFailures = new List<string>();
            int objectCount = 0;

            foreach (SObjectDescribeBasic obj in global.SObjects)
            {
                // the generator only generates queryable objects
                if (!obj.Queryable)
                {
                    continue;
                }

                objectCount++;
                CheckName(obj.Name, "object", invalidNames);

                SObjectDescribeFull describe;
                Stopwatch sw = Stopwatch.StartNew();
                try
                {
                    describe = await client.GetObjectDescribe(obj.Name);
                }
                catch (ForceApiException ex)
                {
                    // a describe failure (e.g. a timeout) isn't a name validation failure - report it and carry on
                    describeFailures.Add($"{obj.Name} after {sw.Elapsed.TotalSeconds:0}s: {ex.Message}");
                    continue;
                }

                foreach (SObjectFieldMetadata field in describe.Fields)
                {
                    CheckName(field.Name, $"field {obj.Name}", invalidNames);

                    if (!string.IsNullOrEmpty(field.RelationshipName))
                    {
                        CheckName(field.RelationshipName, $"relationship {obj.Name}", invalidNames);
                    }

                    if (field.ReferenceTo != null)
                    {
                        foreach (string referenceTo in field.ReferenceTo)
                        {
                            CheckName(referenceTo, $"referenceTo {obj.Name}.{field.Name}", invalidNames);
                        }
                    }
                }
            }

            output.WriteLine($"Checked {objectCount} queryable objects, {describeFailures.Count} could not be described");
            foreach (string describeFailure in describeFailures)
            {
                output.WriteLine("Describe failed: " + describeFailure);
            }

            foreach (string invalidName in invalidNames)
            {
                output.WriteLine("Invalid: " + invalidName);
            }

            Assert.Empty(invalidNames);
        }

        private static void CheckName(string name, string description, List<string> invalidNames)
        {
            if (name == null || !IdentifierRegex.IsMatch(name))
            {
                invalidNames.Add($"{description}: '{name}'");
            }
        }
    }
}
