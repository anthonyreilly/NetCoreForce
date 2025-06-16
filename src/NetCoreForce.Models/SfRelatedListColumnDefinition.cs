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
	/// Related List Column Definition
	///<para>SObject Name: RelatedListColumnDefinition</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfRelatedListColumnDefinition : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "RelatedListColumnDefinition"; }
		}

		///<summary>
		/// Related List Column Definition Id
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Durable Id
		/// <para>Name: DurableId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "durableId")]
		[Updateable(false), Createable(false)]
		public string DurableId { get; set; }

		///<summary>
		/// Related List Definition Id
		/// <para>Name: RelatedListDefinitionId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relatedListDefinitionId")]
		[Updateable(false), Createable(false)]
		public string RelatedListDefinitionId { get; set; }

		///<summary>
		/// Field Definition ID
		/// <para>Name: FieldDefinitionId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fieldDefinitionId")]
		[Updateable(false), Createable(false)]
		public string FieldDefinitionId { get; set; }

		///<summary>
		/// Label
		/// <para>Name: Label</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "label")]
		[Updateable(false), Createable(false)]
		public string Label { get; set; }

		///<summary>
		/// Related List Column Definition SOQL String
		/// <para>Name: ColumnSoql</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "columnSoql")]
		[Updateable(false), Createable(false)]
		public string ColumnSoql { get; set; }

		///<summary>
		/// Related List Column Definition Alias
		/// <para>Name: Alias</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "alias")]
		[Updateable(false), Createable(false)]
		public string Alias { get; set; }

		///<summary>
		/// Lookup Id
		/// <para>Name: LookupId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lookupId")]
		[Updateable(false), Createable(false)]
		public string LookupId { get; set; }

		///<summary>
		/// Data Type
		/// <para>Name: DataType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dataType")]
		[Updateable(false), Createable(false)]
		public string DataType { get; set; }

		///<summary>
		/// Is Describe Enabled
		/// <para>Name: IsDescribable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDescribable")]
		[Updateable(false), Createable(false)]
		public bool? IsDescribable { get; set; }

		///<summary>
		/// Is Default
		/// <para>Name: IsDefault</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDefault")]
		[Updateable(false), Createable(false)]
		public bool? IsDefault { get; set; }

	}
}
