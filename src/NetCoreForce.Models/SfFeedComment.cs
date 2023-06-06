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
	/// Feed Comment
	///<para>SObject Name: FeedComment</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfFeedComment : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "FeedComment"; }
		}

		///<summary>
		/// Feed Comment ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Feed Item ID
		/// <para>Name: FeedItemId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "feedItemId")]
		[Updateable(false), Createable(true)]
		public string FeedItemId { get; set; }

		///<summary>
		/// Parent ID
		/// <para>Name: ParentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "parentId")]
		[Updateable(false), Createable(false)]
		public string ParentId { get; set; }

		///<summary>
		/// Created By ID
		/// <para>Name: CreatedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdById")]
		[Updateable(false), Createable(true)]
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
		[Updateable(false), Createable(true)]
		public DateTimeOffset? CreatedDate { get; set; }

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
		/// Revision
		/// <para>Name: Revision</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "revision")]
		[Updateable(false), Createable(true)]
		public int? Revision { get; set; }

		///<summary>
		/// Last Edit By ID
		/// <para>Name: LastEditById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastEditById")]
		[Updateable(false), Createable(true)]
		public string LastEditById { get; set; }

		///<summary>
		/// Last Edit Date
		/// <para>Name: LastEditDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastEditDate")]
		[Updateable(false), Createable(true)]
		public DateTimeOffset? LastEditDate { get; set; }

		///<summary>
		/// Comment Body
		/// <para>Name: CommentBody</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "commentBody")]
		public string CommentBody { get; set; }

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
		/// InsertedBy ID
		/// <para>Name: InsertedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
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
		/// Comment Type
		/// <para>Name: CommentType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "commentType")]
		[Updateable(false), Createable(true)]
		public string CommentType { get; set; }

		///<summary>
		/// Related Record ID
		/// <para>Name: RelatedRecordId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relatedRecordId")]
		[Updateable(false), Createable(true)]
		public string RelatedRecordId { get; set; }

		///<summary>
		/// Is Rich Text
		/// <para>Name: IsRichText</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isRichText")]
		public bool? IsRichText { get; set; }

		///<summary>
		/// Is a Verified Comment
		/// <para>Name: IsVerified</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isVerified")]
		[Updateable(false), Createable(false)]
		public bool? IsVerified { get; set; }

		///<summary>
		/// Has entity links
		/// <para>Name: HasEntityLinks</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasEntityLinks")]
		[Updateable(false), Createable(false)]
		public bool? HasEntityLinks { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		public string Status { get; set; }

		///<summary>
		/// Feed Comment ID
		/// <para>Name: ThreadParentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "threadParentId")]
		[Updateable(false), Createable(true)]
		public string ThreadParentId { get; set; }

		///<summary>
		/// ReferenceTo: FeedComment
		/// <para>RelationshipName: ThreadParent</para>
		///</summary>
		[JsonProperty(PropertyName = "threadParent")]
		[Updateable(false), Createable(false)]
		public SfFeedComment ThreadParent { get; set; }

		///<summary>
		/// Thread Level
		/// <para>Name: ThreadLevel</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "threadLevel")]
		[Updateable(false), Createable(true)]
		public int? ThreadLevel { get; set; }

		///<summary>
		/// Thread Children Count
		/// <para>Name: ThreadChildrenCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "threadChildrenCount")]
		[Updateable(false), Createable(true)]
		public int? ThreadChildrenCount { get; set; }

		///<summary>
		/// Thread Last Updated Date
		/// <para>Name: ThreadLastUpdatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "threadLastUpdatedDate")]
		[Updateable(false), Createable(true)]
		public DateTimeOffset? ThreadLastUpdatedDate { get; set; }

	}
}
