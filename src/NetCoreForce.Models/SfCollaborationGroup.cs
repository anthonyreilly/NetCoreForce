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
	/// Group
	///<para>SObject Name: CollaborationGroup</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfCollaborationGroup : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "CollaborationGroup"; }
		}

		///<summary>
		/// Group Id
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		///<summary>
		/// Member Count
		/// <para>Name: MemberCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "memberCount")]
		[Updateable(false), Createable(false)]
		public int? MemberCount { get; set; }

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
		/// Access Type
		/// <para>Name: CollaborationType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "collaborationType")]
		public string CollaborationType { get; set; }

		///<summary>
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

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
		/// Url for full-sized Photo
		/// <para>Name: FullPhotoUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fullPhotoUrl")]
		[Updateable(false), Createable(false)]
		public string FullPhotoUrl { get; set; }

		///<summary>
		/// Url for medium profile photo
		/// <para>Name: MediumPhotoUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mediumPhotoUrl")]
		[Updateable(false), Createable(false)]
		public string MediumPhotoUrl { get; set; }

		///<summary>
		/// Photo
		/// <para>Name: SmallPhotoUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "smallPhotoUrl")]
		[Updateable(false), Createable(false)]
		public string SmallPhotoUrl { get; set; }

		///<summary>
		/// Last Feed Modified Date
		/// <para>Name: LastFeedModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastFeedModifiedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastFeedModifiedDate { get; set; }

		///<summary>
		/// Information Title
		/// <para>Name: InformationTitle</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "informationTitle")]
		public string InformationTitle { get; set; }

		///<summary>
		/// Information
		/// <para>Name: InformationBody</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "informationBody")]
		public string InformationBody { get; set; }

		///<summary>
		/// Has Private Fields Access
		/// <para>Name: HasPrivateFieldsAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasPrivateFieldsAccess")]
		[Updateable(false), Createable(false)]
		public bool? HasPrivateFieldsAccess { get; set; }

		///<summary>
		/// Allow customers
		/// <para>Name: CanHaveGuests</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "canHaveGuests")]
		public bool? CanHaveGuests { get; set; }

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
		/// Archive
		/// <para>Name: IsArchived</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isArchived")]
		public bool? IsArchived { get; set; }

		///<summary>
		/// Disable automatic archiving
		/// <para>Name: IsAutoArchiveDisabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isAutoArchiveDisabled")]
		public bool? IsAutoArchiveDisabled { get; set; }

		///<summary>
		/// Announcement ID
		/// <para>Name: AnnouncementId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "announcementId")]
		public string AnnouncementId { get; set; }

		///<summary>
		/// ReferenceTo: Announcement
		/// <para>RelationshipName: Announcement</para>
		///</summary>
		[JsonProperty(PropertyName = "announcement")]
		[Updateable(false), Createable(false)]
		public SfAnnouncement Announcement { get; set; }

		///<summary>
		/// Banner Photo Url
		/// <para>Name: BannerPhotoUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "bannerPhotoUrl")]
		[Updateable(false), Createable(false)]
		public string BannerPhotoUrl { get; set; }

		///<summary>
		/// Broadcast Only
		/// <para>Name: IsBroadcast</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isBroadcast")]
		public bool? IsBroadcast { get; set; }

	}
}
