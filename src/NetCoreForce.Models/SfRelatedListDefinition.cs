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
	/// Related List Definition
	///<para>SObject Name: RelatedListDefinition</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfRelatedListDefinition : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "RelatedListDefinition"; }
		}

		///<summary>
		/// Related List Definition Id
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
		/// Entity Definition ID
		/// <para>Name: EntityDefinitionId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "entityDefinitionId")]
		[Updateable(false), Createable(false)]
		public string EntityDefinitionId { get; set; }

		///<summary>
		/// Entity Definition ID
		/// <para>Name: ParentEntityDefinitionId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "parentEntityDefinitionId")]
		[Updateable(false), Createable(false)]
		public string ParentEntityDefinitionId { get; set; }

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
		/// Related List Definition Id
		/// <para>Name: RelatedListId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relatedListId")]
		[Updateable(false), Createable(false)]
		public string RelatedListId { get; set; }

		///<summary>
		/// Related List Definition Name
		/// <para>Name: RelatedListName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relatedListName")]
		[Updateable(false), Createable(false)]
		public string RelatedListName { get; set; }

		///<summary>
		/// Related List Default Sort
		/// <para>Name: DefaultSort</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "defaultSort")]
		[Updateable(false), Createable(false)]
		public string DefaultSort { get; set; }

		///<summary>
		/// Is Layout Enabled
		/// <para>Name: IsLayoutable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isLayoutable")]
		[Updateable(false), Createable(false)]
		public bool? IsLayoutable { get; set; }

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
		/// Is Customizable
		/// <para>Name: IsCustomizable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isCustomizable")]
		[Updateable(false), Createable(false)]
		public bool? IsCustomizable { get; set; }

	}
}
