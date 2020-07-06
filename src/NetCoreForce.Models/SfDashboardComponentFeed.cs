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
	/// Dashboard Component Feed
	///<para>SObject Name: DashboardComponentFeed</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfDashboardComponentFeed : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "DashboardComponentFeed"; }
		}

		///<summary>
		/// Feed Item ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Parent ID
		/// <para>Name: ParentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "parentId")]
		[Updateable(false), Createable(false)]
		public string ParentId { get; set; }

		///<summary>
		/// ReferenceTo: DashboardComponent
		/// <para>RelationshipName: Parent</para>
		///</summary>
		[JsonProperty(PropertyName = "parent")]
		[Updateable(false), Createable(false)]
		public SfDashboardComponent Parent { get; set; }

		///<summary>
		/// Feed Item Type
		/// <para>Name: Type</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		[Updateable(false), Createable(false)]
		public string Type { get; set; }

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
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Createable(false)]
		public bool? IsDeleted { get; set; }

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
		/// Comment Count
		/// <para>Name: CommentCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "commentCount")]
		[Updateable(false), Createable(false)]
		public int? CommentCount { get; set; }

		///<summary>
		/// Like Count
		/// <para>Name: LikeCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "likeCount")]
		[Updateable(false), Createable(false)]
		public int? LikeCount { get; set; }

		///<summary>
		/// Title
		/// <para>Name: Title</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "title")]
		[Updateable(false), Createable(false)]
		public string Title { get; set; }

		///<summary>
		/// Body
		/// <para>Name: Body</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "body")]
		[Updateable(false), Createable(false)]
		public string Body { get; set; }

		///<summary>
		/// Link Url
		/// <para>Name: LinkUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "linkUrl")]
		[Updateable(false), Createable(false)]
		public string LinkUrl { get; set; }

		///<summary>
		/// Is Rich Text
		/// <para>Name: IsRichText</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isRichText")]
		[Updateable(false), Createable(false)]
		public bool? IsRichText { get; set; }

		///<summary>
		/// Related Record ID
		/// <para>Name: RelatedRecordId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relatedRecordId")]
		[Updateable(false), Createable(false)]
		public string RelatedRecordId { get; set; }

		///<summary>
		/// InsertedBy ID
		/// <para>Name: InsertedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "insertedById")]
		[Updateable(false), Createable(false)]
		public string InsertedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: InsertedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "insertedBy")]
		[Updateable(false), Createable(false)]
		public SfUser InsertedBy { get; set; }

		///<summary>
		/// Best Comment ID
		/// <para>Name: BestCommentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "bestCommentId")]
		[Updateable(false), Createable(false)]
		public string BestCommentId { get; set; }

		///<summary>
		/// ReferenceTo: FeedComment
		/// <para>RelationshipName: BestComment</para>
		///</summary>
		[JsonProperty(PropertyName = "bestComment")]
		[Updateable(false), Createable(false)]
		public SfFeedComment BestComment { get; set; }

	}
}
