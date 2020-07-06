// SF API version v48.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Content Document
	///<para>SObject Name: ContentDocument</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfContentDocument : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ContentDocument"; }
		}

		///<summary>
		/// ContentDocument ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

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
		/// Created
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

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
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

		///<summary>
		/// Is Archived
		/// <para>Name: IsArchived</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isArchived")]
		[Updateable(true), Createable(false)]
		public bool? IsArchived { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: ArchivedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "archivedById")]
		[Updateable(false), Createable(false)]
		public string ArchivedById { get; set; }

		///<summary>
		/// Archived Date
		/// <para>Name: ArchivedDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "archivedDate")]
		[Updateable(false), Createable(false)]
		public DateTime? ArchivedDate { get; set; }

		///<summary>
		/// Is Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Createable(false)]
		public bool? IsDeleted { get; set; }

		///<summary>
		/// Owner ID
		/// <para>Name: OwnerId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "ownerId")]
		[Updateable(true), Createable(false)]
		public string OwnerId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: Owner</para>
		///</summary>
		[JsonProperty(PropertyName = "owner")]
		[Updateable(false), Createable(false)]
		public SfUser Owner { get; set; }

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
		/// Title
		/// <para>Name: Title</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "title")]
		[Updateable(true), Createable(false)]
		public string Title { get; set; }

		///<summary>
		/// Publish Status
		/// <para>Name: PublishStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "publishStatus")]
		[Updateable(false), Createable(false)]
		public string PublishStatus { get; set; }

		///<summary>
		/// Latest Published Version ID
		/// <para>Name: LatestPublishedVersionId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "latestPublishedVersionId")]
		[Updateable(false), Createable(false)]
		public string LatestPublishedVersionId { get; set; }

		///<summary>
		/// ReferenceTo: ContentVersion
		/// <para>RelationshipName: LatestPublishedVersion</para>
		///</summary>
		[JsonProperty(PropertyName = "latestPublishedVersion")]
		[Updateable(false), Createable(false)]
		public SfContentVersion LatestPublishedVersion { get; set; }

		///<summary>
		/// Parent ID
		/// <para>Name: ParentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "parentId")]
		[Updateable(true), Createable(false)]
		public string ParentId { get; set; }

		///<summary>
		/// Last Viewed Date
		/// <para>Name: LastViewedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastViewedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastViewedDate { get; set; }

		///<summary>
		/// Last Referenced Date
		/// <para>Name: LastReferencedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastReferencedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastReferencedDate { get; set; }

		///<summary>
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		[Updateable(true), Createable(false)]
		public string Description { get; set; }

		///<summary>
		/// Size
		/// <para>Name: ContentSize</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contentSize")]
		[Updateable(false), Createable(false)]
		public int? ContentSize { get; set; }

		///<summary>
		/// File Type
		/// <para>Name: FileType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fileType")]
		[Updateable(false), Createable(false)]
		public string FileType { get; set; }

		///<summary>
		/// File Extension
		/// <para>Name: FileExtension</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fileExtension")]
		[Updateable(false), Createable(false)]
		public string FileExtension { get; set; }

		///<summary>
		/// Prevent others from sharing and unsharing
		/// <para>Name: SharingOption</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sharingOption")]
		[Updateable(true), Createable(false)]
		public string SharingOption { get; set; }

		///<summary>
		/// File Privacy on Records
		/// <para>Name: SharingPrivacy</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sharingPrivacy")]
		[Updateable(true), Createable(false)]
		public string SharingPrivacy { get; set; }

		///<summary>
		/// Content Modified Date
		/// <para>Name: ContentModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contentModifiedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? ContentModifiedDate { get; set; }

		///<summary>
		/// Asset File ID
		/// <para>Name: ContentAssetId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contentAssetId")]
		[Updateable(true), Createable(false)]
		public string ContentAssetId { get; set; }

		///<summary>
		/// ReferenceTo: ContentAsset
		/// <para>RelationshipName: ContentAsset</para>
		///</summary>
		[JsonProperty(PropertyName = "contentAsset")]
		[Updateable(false), Createable(false)]
		public SfContentAsset ContentAsset { get; set; }

	}
}
