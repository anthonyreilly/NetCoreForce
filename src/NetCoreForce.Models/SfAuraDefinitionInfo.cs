// SF API version v41.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// AuraDefinition Info
	///<para>SObject Name: AuraDefinitionInfo</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfAuraDefinitionInfo : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "AuraDefinitionInfo"; }
		}

		///<summary>
		/// Lightning Definition ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// Durable ID
		/// <para>Name: DurableId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "durableId")]
		[Updateable(false), Creatable(false)]
		public string DurableId { get; set; }

		///<summary>
		/// Lightning Definition Bundle ID
		/// <para>Name: AuraDefinitionBundleInfoId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "auraDefinitionBundleInfoId")]
		[Updateable(false), Creatable(false)]
		public string AuraDefinitionBundleInfoId { get; set; }

		///<summary>
		/// Lightning Definition ID
		/// <para>Name: AuraDefinitionId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "auraDefinitionId")]
		[Updateable(false), Creatable(false)]
		public string AuraDefinitionId { get; set; }

		///<summary>
		/// Definition Type
		/// <para>Name: DefType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "defType")]
		[Updateable(false), Creatable(false)]
		public string DefType { get; set; }

		///<summary>
		/// Format
		/// <para>Name: Format</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "format")]
		[Updateable(false), Creatable(false)]
		public string Format { get; set; }

		///<summary>
		/// Source
		/// <para>Name: Source</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "source")]
		[Updateable(false), Creatable(false)]
		public string Source { get; set; }

		///<summary>
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

		///<summary>
		/// Bundle Name
		/// <para>Name: DeveloperName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "developerName")]
		[Updateable(false), Creatable(false)]
		public string DeveloperName { get; set; }

		///<summary>
		/// Namespace Prefix
		/// <para>Name: NamespacePrefix</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "namespacePrefix")]
		[Updateable(false), Creatable(false)]
		public string NamespacePrefix { get; set; }

	}
}
