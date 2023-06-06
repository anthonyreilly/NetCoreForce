// SF API version v57.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Publisher
	///<para>SObject Name: Publisher</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfPublisher : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "Publisher"; }
		}

		///<summary>
		/// Publisher ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Publisher Durable ID
		/// <para>Name: DurableId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "durableId")]
		[Updateable(false), Createable(false)]
		public string DurableId { get; set; }

		///<summary>
		/// Publisher Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
		public string Name { get; set; }

		///<summary>
		/// Publisher Namespace Prefix
		/// <para>Name: NamespacePrefix</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "namespacePrefix")]
		[Updateable(false), Createable(false)]
		public string NamespacePrefix { get; set; }

		///<summary>
		/// Is Salesforce the Publisher?
		/// <para>Name: IsSalesforce</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isSalesforce")]
		[Updateable(false), Createable(false)]
		public bool? IsSalesforce { get; set; }

		///<summary>
		/// Publisher Major Version
		/// <para>Name: MajorVersion</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "majorVersion")]
		[Updateable(false), Createable(false)]
		public int? MajorVersion { get; set; }

		///<summary>
		/// Publisher Minor Version
		/// <para>Name: MinorVersion</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "minorVersion")]
		[Updateable(false), Createable(false)]
		public int? MinorVersion { get; set; }

	}
}
