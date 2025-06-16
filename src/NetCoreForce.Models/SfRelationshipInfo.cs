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
	/// Relationship
	///<para>SObject Name: RelationshipInfo</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfRelationshipInfo : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "RelationshipInfo"; }
		}

		///<summary>
		/// Relationship Info ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Relationship Info Durable ID
		/// <para>Name: DurableId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "durableId")]
		[Updateable(false), Createable(false)]
		public string DurableId { get; set; }

		///<summary>
		/// Entity Definition ID
		/// <para>Name: ChildSobjectId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "childSobjectId")]
		[Updateable(false), Createable(false)]
		public string ChildSobjectId { get; set; }

		///<summary>
		/// Field Definition ID
		/// <para>Name: FieldId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fieldId")]
		[Updateable(false), Createable(false)]
		public string FieldId { get; set; }

		///<summary>
		/// Is Cascade Delete?
		/// <para>Name: IsCascadeDelete</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isCascadeDelete")]
		[Updateable(false), Createable(false)]
		public bool? IsCascadeDelete { get; set; }

		///<summary>
		/// Is Deprecated And Hidden?
		/// <para>Name: IsDeprecatedAndHidden</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeprecatedAndHidden")]
		[Updateable(false), Createable(false)]
		public bool? IsDeprecatedAndHidden { get; set; }

		///<summary>
		/// Is Restricted Delete?
		/// <para>Name: IsRestrictedDelete</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isRestrictedDelete")]
		[Updateable(false), Createable(false)]
		public bool? IsRestrictedDelete { get; set; }

		///<summary>
		/// Names of the Junction Id Lists
		/// <para>Name: JunctionIdListNames</para>
		/// <para>SF Type: complexvalue</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "junctionIdListNames")]
		[Updateable(false), Createable(false)]
		public string JunctionIdListNames { get; set; }

	}
}
