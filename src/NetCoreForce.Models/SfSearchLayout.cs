// SF API version v39.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Search Layout
	///<para>SObject Name: SearchLayout</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfSearchLayout : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "SearchLayout"; }
		}

		///<summary>
		/// Search Layout ID
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
		/// Label
		/// <para>Name: Label</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "label")]
		[Updateable(false), Createable(false)]
		public string Label { get; set; }

		///<summary>
		/// Layout Type
		/// <para>Name: LayoutType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "layoutType")]
		[Updateable(false), Createable(false)]
		public string LayoutType { get; set; }

		///<summary>
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: LastModifiedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedById")]
		[Updateable(false), Createable(false)]
		public string LastModifiedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: LastModifiedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedBy")]
		[Updateable(false), Createable(false)]
		public SfUser LastModifiedBy { get; set; }

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
		/// Fields Displayed
		/// <para>Name: FieldsDisplayed</para>
		/// <para>SF Type: complexvalue</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fieldsDisplayed")]
		[Updateable(false), Createable(false)]
		public string FieldsDisplayed { get; set; }

		///<summary>
		/// Buttons Displayed
		/// <para>Name: ButtonsDisplayed</para>
		/// <para>SF Type: complexvalue</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "buttonsDisplayed")]
		[Updateable(false), Createable(false)]
		public string ButtonsDisplayed { get; set; }

	}
}
