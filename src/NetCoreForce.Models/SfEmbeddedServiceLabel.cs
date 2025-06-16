// SF API version v64.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Embedded Service Label
	///<para>SObject Name: EmbeddedServiceLabel</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfEmbeddedServiceLabel : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "EmbeddedServiceLabel"; }
		}

		///<summary>
		/// Embedded Service Label ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Embedded Service Label Durable ID
		/// <para>Name: DurableId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "durableId")]
		[Updateable(false), Createable(false)]
		public string DurableId { get; set; }

		///<summary>
		///  Embedded Service Config Developer Name
		/// <para>Name: EmbeddedServiceConfigDeveloperName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "embeddedServiceConfigDeveloperName")]
		[Updateable(false), Createable(false)]
		public string EmbeddedServiceConfigDeveloperName { get; set; }

		///<summary>
		/// Label Key
		/// <para>Name: LabelKey</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "labelKey")]
		[Updateable(false), Createable(false)]
		public string LabelKey { get; set; }

		///<summary>
		/// Custom Label Name
		/// <para>Name: CustomLabelName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "customLabelName")]
		[Updateable(false), Createable(false)]
		public string CustomLabelName { get; set; }

	}
}
