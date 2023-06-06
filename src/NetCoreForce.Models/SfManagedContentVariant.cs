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
	/// Managed Content Variant
	///<para>SObject Name: ManagedContentVariant</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfManagedContentVariant : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ManagedContentVariant"; }
		}

		///<summary>
		/// Managed Content Variant ID
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
		/// Title
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
		public string Name { get; set; }

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
		/// Variant Type
		/// <para>Name: VariantType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "variantType")]
		[Updateable(false), Createable(false)]
		public string VariantType { get; set; }

		///<summary>
		/// Language
		/// <para>Name: Language</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "language")]
		[Updateable(false), Createable(false)]
		public string Language { get; set; }

		///<summary>
		/// Content Slug
		/// <para>Name: UrlName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "urlName")]
		[Updateable(false), Createable(false)]
		public string UrlName { get; set; }

		///<summary>
		/// Managed Content ID
		/// <para>Name: ManagedContentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "managedContentId")]
		[Updateable(false), Createable(false)]
		public string ManagedContentId { get; set; }

		///<summary>
		/// ReferenceTo: ManagedContent
		/// <para>RelationshipName: ManagedContent</para>
		///</summary>
		[JsonProperty(PropertyName = "managedContent")]
		[Updateable(false), Createable(false)]
		public SfManagedContent ManagedContent { get; set; }

		///<summary>
		/// Ready to be Published
		/// <para>Name: IsReady</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReady")]
		[Updateable(false), Createable(false)]
		public bool? IsReady { get; set; }

		///<summary>
		/// Content Key
		/// <para>Name: ManagedContentKey</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "managedContentKey")]
		[Updateable(false), Createable(false)]
		public string ManagedContentKey { get; set; }

		///<summary>
		/// Published
		/// <para>Name: IsPublished</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isPublished")]
		[Updateable(false), Createable(false)]
		public bool? IsPublished { get; set; }

		///<summary>
		/// Status
		/// <para>Name: ManagedContentVariantStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "managedContentVariantStatus")]
		[Updateable(false), Createable(false)]
		public string ManagedContentVariantStatus { get; set; }

		///<summary>
		/// Locked for Updates
		/// <para>Name: HasLocks</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasLocks")]
		[Updateable(false), Createable(false)]
		public bool? HasLocks { get; set; }

		///<summary>
		/// Is Primary Variant
		/// <para>Name: IsPrimary</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isPrimary")]
		[Updateable(false), Createable(false)]
		public bool? IsPrimary { get; set; }

	}
}
