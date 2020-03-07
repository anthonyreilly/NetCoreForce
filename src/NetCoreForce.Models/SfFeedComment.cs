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
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// Feed Item ID
		/// <para>Name: FeedItemId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "feedItemId")]
		[Updateable(false), Creatable(true)]
		public string FeedItemId { get; set; }

		///<summary>
		/// Parent ID
		/// <para>Name: ParentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "parentId")]
		[Updateable(false), Creatable(false)]
		public string ParentId { get; set; }

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
		[Updateable(false), Creatable(false)]
		public bool? IsDeleted { get; set; }

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
		/// Comment Type
		/// <para>Name: CommentType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "commentType")]
		[Updateable(false), Creatable(true)]
		public string CommentType { get; set; }

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
		[Updateable(false), Creatable(false)]
		public bool? IsVerified { get; set; }

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
