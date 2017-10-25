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
	/// AuraDefinitionBundle Info
	///<para>SObject Name: AuraDefinitionBundleInfo</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfAuraDefinitionBundleInfo : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "AuraDefinitionBundleInfo"; }
		}

		///<summary>
		/// Lightning Definition Bundle ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Durable ID
		/// <para>Name: DurableId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "durableId")]
		[Updateable(false), Createable(false)]
		public string DurableId { get; set; }

		///<summary>
		/// Lightning Definition Bundle ID
		/// <para>Name: AuraDefinitionBundleId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "auraDefinitionBundleId")]
		[Updateable(false), Createable(false)]
		public string AuraDefinitionBundleId { get; set; }

		///<summary>
		/// Api Version
		/// <para>Name: ApiVersion</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "apiVersion")]
		[Updateable(false), Createable(false)]
		public double? ApiVersion { get; set; }

		///<summary>
		/// Bundle Name
		/// <para>Name: DeveloperName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "developerName")]
		[Updateable(false), Createable(false)]
		public string DeveloperName { get; set; }

		///<summary>
		/// Namespace Prefix
		/// <para>Name: NamespacePrefix</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "namespacePrefix")]
		[Updateable(false), Createable(false)]
		public string NamespacePrefix { get; set; }

	}
}
