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
	/// Idea
	///<para>SObject Name: Idea</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfIdea : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "Idea"; }
		}

		///<summary>
		/// Idea ID
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
		/// <para>Name: Title</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "title")]
		public string Title { get; set; }

		///<summary>
		/// Record Type ID
		/// <para>Name: RecordTypeId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recordTypeId")]
		[Updateable(false), Createable(false)]
		public string RecordTypeId { get; set; }

		///<summary>
		/// ReferenceTo: RecordType
		/// <para>RelationshipName: RecordType</para>
		///</summary>
		[JsonProperty(PropertyName = "recordType")]
		[Updateable(false), Createable(false)]
		public SfRecordType RecordType { get; set; }

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
		/// Zone ID
		/// <para>Name: CommunityId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "communityId")]
		[Updateable(false), Createable(true)]
		public string CommunityId { get; set; }

		///<summary>
		/// ReferenceTo: Community
		/// <para>RelationshipName: Community</para>
		///</summary>
		[JsonProperty(PropertyName = "community")]
		[Updateable(false), Createable(false)]
		public SfCommunity Community { get; set; }

		///<summary>
		/// Idea Body
		/// <para>Name: Body</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "body")]
		public string Body { get; set; }

		///<summary>
		/// Number of Comments
		/// <para>Name: NumComments</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "numComments")]
		[Updateable(false), Createable(false)]
		public int? NumComments { get; set; }

		///<summary>
		/// Vote Score
		/// <para>Name: VoteScore</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "voteScore")]
		[Updateable(false), Createable(false)]
		public double? VoteScore { get; set; }

		///<summary>
		/// Vote Total
		/// <para>Name: VoteTotal</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "voteTotal")]
		[Updateable(false), Createable(false)]
		public double? VoteTotal { get; set; }

		///<summary>
		/// Categories
		/// <para>Name: Categories</para>
		/// <para>SF Type: multipicklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "categories")]
		public string Categories { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		public string Status { get; set; }

		///<summary>
		/// Last Idea Comment Date
		/// <para>Name: LastCommentDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastCommentDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastCommentDate { get; set; }

		///<summary>
		/// Idea Comment ID
		/// <para>Name: LastCommentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastCommentId")]
		[Updateable(false), Createable(false)]
		public string LastCommentId { get; set; }

		///<summary>
		/// ReferenceTo: IdeaComment
		/// <para>RelationshipName: LastComment</para>
		///</summary>
		[JsonProperty(PropertyName = "lastComment")]
		[Updateable(false), Createable(false)]
		public SfIdeaComment LastComment { get; set; }

		///<summary>
		/// Idea ID
		/// <para>Name: ParentIdeaId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "parentIdeaId")]
		[Updateable(false), Createable(false)]
		public string ParentIdeaId { get; set; }

		///<summary>
		/// ReferenceTo: Idea
		/// <para>RelationshipName: ParentIdea</para>
		///</summary>
		[JsonProperty(PropertyName = "parentIdea")]
		[Updateable(false), Createable(false)]
		public SfIdea ParentIdea { get; set; }

		///<summary>
		/// IsHtml
		/// <para>Name: IsHtml</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isHtml")]
		[Updateable(false), Createable(false)]
		public bool? IsHtml { get; set; }

		///<summary>
		/// Is Merged
		/// <para>Name: IsMerged</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isMerged")]
		[Updateable(false), Createable(false)]
		public bool? IsMerged { get; set; }

		///<summary>
		/// Url of Creator&#39;s Profile Photo
		/// <para>Name: CreatorFullPhotoUrl</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "creatorFullPhotoUrl")]
		[Updateable(false), Createable(false)]
		public string CreatorFullPhotoUrl { get; set; }

		///<summary>
		/// Url of Creator&#39;s Thumbnail Photo
		/// <para>Name: CreatorSmallPhotoUrl</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "creatorSmallPhotoUrl")]
		[Updateable(false), Createable(false)]
		public string CreatorSmallPhotoUrl { get; set; }

		///<summary>
		/// Name of Creator
		/// <para>Name: CreatorName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "creatorName")]
		[Updateable(false), Createable(false)]
		public string CreatorName { get; set; }

	}
}
