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
	/// Custom Help Menu Item
	///<para>SObject Name: CustomHelpMenuItem</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfCustomHelpMenuItem : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "CustomHelpMenuItem"; }
		}

		///<summary>
		/// Custom Help Menu Item ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Createable(false)]
		public bool? IsDeleted { get; set; }

		///<summary>
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

		///<summary>
		/// Created By ID
		/// <para>Name: CreatedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdById")]
		[Updateable(false), Createable(false)]
		public string CreatedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: CreatedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "createdBy")]
		[Updateable(false), Createable(false)]
		public SfUser CreatedBy { get; set; }

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
		/// Last Modified By ID
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
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

		///<summary>
		/// Custom Help Menu Section ID
		/// <para>Name: ParentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "parentId")]
		[Updateable(false), Createable(true)]
		public string ParentId { get; set; }

		///<summary>
		/// ReferenceTo: CustomHelpMenuSection
		/// <para>RelationshipName: Parent</para>
		///</summary>
		[JsonProperty(PropertyName = "parent")]
		[Updateable(false), Createable(false)]
		public SfCustomHelpMenuSection Parent { get; set; }

		///<summary>
		/// Item Label
		/// <para>Name: MasterLabel</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "masterLabel")]
		public string MasterLabel { get; set; }

		///<summary>
		/// Link Url
		/// <para>Name: LinkUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "linkUrl")]
		public string LinkUrl { get; set; }

		///<summary>
		/// Sort Order
		/// <para>Name: SortOrder</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "sortOrder")]
		public int? SortOrder { get; set; }

	}
}
