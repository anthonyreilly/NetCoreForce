// SF API version v41.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Content Version
	///<para>SObject Name: ContentVersion</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfContentVersion : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ContentVersion"; }
		}

		///<summary>
		/// ContentVersion ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// ContentDocument ID
		/// <para>Name: ContentDocumentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "contentDocumentId")]
		[Updateable(false), Createable(true)]
		public string ContentDocumentId { get; set; }

		///<summary>
		/// ReferenceTo: ContentDocument
		/// <para>RelationshipName: ContentDocument</para>
		///</summary>
		[JsonProperty(PropertyName = "contentDocument")]
		[Updateable(false), Createable(false)]
		public SfContentDocument ContentDocument { get; set; }

		///<summary>
		/// Is Latest
		/// <para>Name: IsLatest</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isLatest")]
		[Updateable(false), Createable(false)]
		public bool? IsLatest { get; set; }

		///<summary>
		/// Content URL
		/// <para>Name: ContentUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contentUrl")]
		public string ContentUrl { get; set; }

		///<summary>
		/// Content Body ID
		/// <para>Name: ContentBodyId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contentBodyId")]
		[Updateable(false), Createable(true)]
		public string ContentBodyId { get; set; }

		// Commenting out since its not directly queryable
		///<summary>
		/// ReferenceTo: ContentBody
		/// <para>RelationshipName: ContentBody</para>
		///</summary>
		// [JsonProperty(PropertyName = "contentBody")]
		// [Updateable(false), Createable(false)]
		// public SfContentBody ContentBody { get; set; }		

		///<summary>
		/// Version Number
		/// <para>Name: VersionNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "versionNumber")]
		[Updateable(false), Createable(false)]
		public string VersionNumber { get; set; }

		///<summary>
		/// Title
		/// <para>Name: Title</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "title")]
		public string Title { get; set; }

		///<summary>
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

		///<summary>
		/// Reason For Change
		/// <para>Name: ReasonForChange</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "reasonForChange")]
		public string ReasonForChange { get; set; }

		///<summary>
		/// Prevent others from sharing and unsharing
		/// <para>Name: SharingOption</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "sharingOption")]
		public string SharingOption { get; set; }

		///<summary>
		/// File Privacy on Records
		/// <para>Name: SharingPrivacy</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "sharingPrivacy")]
		public string SharingPrivacy { get; set; }

		///<summary>
		/// Path On Client
		/// <para>Name: PathOnClient</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "pathOnClient")]
		[Updateable(false), Createable(true)]
		public string PathOnClient { get; set; }

		///<summary>
		/// Rating Count
		/// <para>Name: RatingCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "ratingCount")]
		[Updateable(false), Createable(false)]
		public int? RatingCount { get; set; }

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
		/// Content Modified Date
		/// <para>Name: ContentModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contentModifiedDate")]
		[Updateable(false), Createable(true)]
		public DateTimeOffset? ContentModifiedDate { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: ContentModifiedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contentModifiedById")]
		[Updateable(false), Createable(false)]
		public string ContentModifiedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: ContentModifiedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "contentModifiedBy")]
		[Updateable(false), Createable(false)]
		public SfUser ContentModifiedBy { get; set; }

		///<summary>
		/// Positive Rating Count
		/// <para>Name: PositiveRatingCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "positiveRatingCount")]
		[Updateable(false), Createable(false)]
		public int? PositiveRatingCount { get; set; }

		///<summary>
		/// Negative Rating Count
		/// <para>Name: NegativeRatingCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "negativeRatingCount")]
		[Updateable(false), Createable(false)]
		public int? NegativeRatingCount { get; set; }

		///<summary>
		/// Featured Content Boost
		/// <para>Name: FeaturedContentBoost</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "featuredContentBoost")]
		[Updateable(false), Createable(false)]
		public int? FeaturedContentBoost { get; set; }

		///<summary>
		/// Featured Content Date
		/// <para>Name: FeaturedContentDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "featuredContentDate")]
		[Updateable(false), Createable(false)]
		public string FeaturedContentDate { get; set; }

		///<summary>
		/// Owner ID
		/// <para>Name: OwnerId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "ownerId")]
		public string OwnerId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: Owner</para>
		///</summary>
		[JsonProperty(PropertyName = "owner")]
		[Updateable(false), Createable(false)]
		public SfUser Owner { get; set; }

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
		/// Created Date
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
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

		///<summary>
		/// Tags
		/// <para>Name: TagCsv</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "tagCsv")]
		public string TagCsv { get; set; }

		///<summary>
		/// File Type
		/// <para>Name: FileType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "fileType")]
		[Updateable(false), Createable(false)]
		public string FileType { get; set; }

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
		/// Version Data
		/// <para>Name: VersionData</para>
		/// <para>SF Type: base64</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "versionData")]
		public string VersionData { get; set; }

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
		/// File Extension
		/// <para>Name: FileExtension</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fileExtension")]
		[Updateable(false), Createable(false)]
		public string FileExtension { get; set; }

		///<summary>
		/// First Publish Location ID
		/// <para>Name: FirstPublishLocationId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "firstPublishLocationId")]
		[Updateable(false), Createable(true)]
		public string FirstPublishLocationId { get; set; }

		///<summary>
		/// Content Origin
		/// <para>Name: Origin</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "origin")]
		[Updateable(false), Createable(true)]
		public string Origin { get; set; }

		///<summary>
		/// Content Location
		/// <para>Name: ContentLocation</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "contentLocation")]
		[Updateable(false), Createable(true)]
		public string ContentLocation { get; set; }

		///<summary>
		/// Text Preview
		/// <para>Name: TextPreview</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "textPreview")]
		[Updateable(false), Createable(false)]
		public string TextPreview { get; set; }

		///<summary>
		/// External Document Info1
		/// <para>Name: ExternalDocumentInfo1</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "externalDocumentInfo1")]
		public string ExternalDocumentInfo1 { get; set; }

		///<summary>
		/// External Document Info2
		/// <para>Name: ExternalDocumentInfo2</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "externalDocumentInfo2")]
		public string ExternalDocumentInfo2 { get; set; }

		///<summary>
		/// External Data Source ID
		/// <para>Name: ExternalDataSourceId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "externalDataSourceId")]
		public string ExternalDataSourceId { get; set; }

		///<summary>
		/// ReferenceTo: ExternalDataSource
		/// <para>RelationshipName: ExternalDataSource</para>
		///</summary>
		[JsonProperty(PropertyName = "externalDataSource")]
		[Updateable(false), Createable(false)]
		public SfExternalDataSource ExternalDataSource { get; set; }

		///<summary>
		/// Checksum
		/// <para>Name: Checksum</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "checksum")]
		[Updateable(false), Createable(false)]
		public string Checksum { get; set; }

		///<summary>
		/// Major Version
		/// <para>Name: IsMajorVersion</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isMajorVersion")]
		[Updateable(false), Createable(true)]
		public bool? IsMajorVersion { get; set; }

		///<summary>
		/// Asset File Enabled
		/// <para>Name: IsAssetEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isAssetEnabled")]
		[Updateable(false), Createable(true)]
		public bool? IsAssetEnabled { get; set; }

	}
}
