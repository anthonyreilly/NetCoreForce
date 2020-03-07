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
	/// Idea Comment
	///<para>SObject Name: IdeaComment</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfIdeaComment : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "IdeaComment"; }
		}

		///<summary>
		/// Idea Comment ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// Idea ID
		/// <para>Name: IdeaId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "ideaId")]
		[Updateable(false), Creatable(true)]
		public string IdeaId { get; set; }

		///<summary>
		/// ReferenceTo: Idea
		/// <para>RelationshipName: Idea</para>
		///</summary>
		[JsonProperty(PropertyName = "idea")]
		[Updateable(false), Creatable(false)]
		public SfIdea Idea { get; set; }

		///<summary>
		/// Zone ID
		/// <para>Name: CommunityId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "communityId")]
		[Updateable(false), Creatable(false)]
		public string CommunityId { get; set; }

		///<summary>
		/// Comment Body
		/// <para>Name: CommentBody</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "commentBody")]
		public string CommentBody { get; set; }

		///<summary>
		/// Created By ID
		/// <para>Name: CreatedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdById")]
		[Updateable(false), Creatable(false)]
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
		[Updateable(false), Creatable(false)]
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
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Creatable(false)]
		public bool? IsDeleted { get; set; }

		///<summary>
		/// IsHtml
		/// <para>Name: IsHtml</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isHtml")]
		[Updateable(false), Creatable(false)]
		public bool? IsHtml { get; set; }

		///<summary>
		/// Url of Creator&#39;s Profile Photo
		/// <para>Name: CreatorFullPhotoUrl</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "creatorFullPhotoUrl")]
		[Updateable(false), Creatable(false)]
		public string CreatorFullPhotoUrl { get; set; }

		///<summary>
		/// Url of Creator&#39;s Thumbnail Photo
		/// <para>Name: CreatorSmallPhotoUrl</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "creatorSmallPhotoUrl")]
		[Updateable(false), Creatable(false)]
		public string CreatorSmallPhotoUrl { get; set; }

		///<summary>
		/// Name of Creator
		/// <para>Name: CreatorName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "creatorName")]
		[Updateable(false), Creatable(false)]
		public string CreatorName { get; set; }

		///<summary>
		/// Up Votes
		/// <para>Name: UpVotes</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "upVotes")]
		[Updateable(false), Creatable(false)]
		public int? UpVotes { get; set; }

	}
}
