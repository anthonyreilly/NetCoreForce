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
	/// Feed Item
	///<para>SObject Name: FeedItem</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfFeedItem : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "FeedItem"; }
		}

		///<summary>
		/// Feed Item ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// Parent ID
		/// <para>Name: ParentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "parentId")]
		[Updateable(false), Creatable(true)]
		public string ParentId { get; set; }

		///<summary>
		/// Feed Item Type
		/// <para>Name: Type</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		[Updateable(false), Creatable(true)]
		public string Type { get; set; }

		///<summary>
		/// Created By ID
		/// <para>Name: CreatedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdById")]
		[Updateable(false), Creatable(true)]
		public string CreatedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: CreatedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "createdBy")]
		[Updateable(false), Creatable(false)]
		public SfUser CreatedBy { get; set; }

		///<summary>
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Creatable(true)]
		public DateTimeOffset? CreatedDate { get; set; }

		///<summary>
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Creatable(false)]
		public bool? IsDeleted { get; set; }

		///<summary>
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

		///<summary>
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

		///<summary>
		/// Revision
		/// <para>Name: Revision</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "revision")]
		[Updateable(false), Creatable(true)]
		public int? Revision { get; set; }

		///<summary>
		/// Last Edit By ID
		/// <para>Name: LastEditById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastEditById")]
		[Updateable(false), Creatable(true)]
		public string LastEditById { get; set; }

		///<summary>
		/// Last Edit Date
		/// <para>Name: LastEditDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastEditDate")]
		[Updateable(false), Creatable(true)]
		public DateTimeOffset? LastEditDate { get; set; }

		///<summary>
		/// Comment Count
		/// <para>Name: CommentCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "commentCount")]
		[Updateable(false), Creatable(false)]
		public int? CommentCount { get; set; }

		///<summary>
		/// Like Count
		/// <para>Name: LikeCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "likeCount")]
		[Updateable(false), Creatable(false)]
		public int? LikeCount { get; set; }

		///<summary>
		/// Title
		/// <para>Name: Title</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "title")]
		public string Title { get; set; }

		///<summary>
		/// Body
		/// <para>Name: Body</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "body")]
		public string Body { get; set; }

		///<summary>
		/// Link Url
		/// <para>Name: LinkUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "linkUrl")]
		[Updateable(false), Creatable(true)]
		public string LinkUrl { get; set; }

		///<summary>
		/// Is Rich Text
		/// <para>Name: IsRichText</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isRichText")]
		public bool? IsRichText { get; set; }

		///<summary>
		/// Related Record ID
		/// <para>Name: RelatedRecordId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relatedRecordId")]
		[Updateable(false), Creatable(true)]
		public string RelatedRecordId { get; set; }

		///<summary>
		/// InsertedBy ID
		/// <para>Name: InsertedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "insertedById")]
		[Updateable(false), Creatable(false)]
		public string InsertedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: InsertedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "insertedBy")]
		[Updateable(false), Creatable(false)]
		public SfUser InsertedBy { get; set; }

		///<summary>
		/// Best Comment ID
		/// <para>Name: BestCommentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "bestCommentId")]
		[Updateable(false), Creatable(false)]
		public string BestCommentId { get; set; }

		///<summary>
		/// ReferenceTo: FeedComment
		/// <para>RelationshipName: BestComment</para>
		///</summary>
		[JsonProperty(PropertyName = "bestComment")]
		[Updateable(false), Creatable(false)]
		public SfFeedComment BestComment { get; set; }

		///<summary>
		/// Has Content
		/// <para>Name: HasContent</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasContent")]
		[Updateable(false), Creatable(false)]
		public bool? HasContent { get; set; }

		///<summary>
		/// Has Link
		/// <para>Name: HasLink</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasLink")]
		[Updateable(false), Creatable(false)]
		public bool? HasLink { get; set; }

		///<summary>
		/// Has Feed Entity Attachment
		/// <para>Name: HasFeedEntity</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasFeedEntity")]
		[Updateable(false), Creatable(false)]
		public bool? HasFeedEntity { get; set; }

		///<summary>
		/// Has Verified Comment
		/// <para>Name: HasVerifiedComment</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasVerifiedComment")]
		[Updateable(false), Creatable(false)]
		public bool? HasVerifiedComment { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		public string Status { get; set; }

	}
}
