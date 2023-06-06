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
	/// Icon Definition
	///<para>SObject Name: IconDefinition</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfIconDefinition : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "IconDefinition"; }
		}

		///<summary>
		/// Icon Definition ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Icon Definition Durable ID
		/// <para>Name: DurableId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "durableId")]
		[Updateable(false), Createable(false)]
		public string DurableId { get; set; }

		///<summary>
		/// Tab Definition ID
		/// <para>Name: TabDefinitionId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "tabDefinitionId")]
		[Updateable(false), Createable(false)]
		public string TabDefinitionId { get; set; }

		///<summary>
		/// URL
		/// <para>Name: Url</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "url")]
		[Updateable(false), Createable(false)]
		public string Url { get; set; }

		///<summary>
		/// Content Type
		/// <para>Name: ContentType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contentType")]
		[Updateable(false), Createable(false)]
		public string ContentType { get; set; }

		///<summary>
		/// Theme
		/// <para>Name: Theme</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "theme")]
		[Updateable(false), Createable(false)]
		public string Theme { get; set; }

		///<summary>
		/// Height
		/// <para>Name: Height</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "height")]
		[Updateable(false), Createable(false)]
		public int? Height { get; set; }

		///<summary>
		/// Width
		/// <para>Name: Width</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "width")]
		[Updateable(false), Createable(false)]
		public int? Width { get; set; }

	}
}
