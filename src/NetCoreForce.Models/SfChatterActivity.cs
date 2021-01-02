// SF API version v50.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Chatter Activity
	///<para>SObject Name: ChatterActivity</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfChatterActivity : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ChatterActivity"; }
		}

		///<summary>
		/// Chatter Activity ID
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
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "parentId")]
		[Updateable(false), Createable(false)]
		public string ParentId { get; set; }

		///<summary>
		/// Post Count
		/// <para>Name: PostCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "postCount")]
		[Updateable(false), Createable(false)]
		public int? PostCount { get; set; }

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
		/// Comment Received Count
		/// <para>Name: CommentReceivedCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "commentReceivedCount")]
		[Updateable(false), Createable(false)]
		public int? CommentReceivedCount { get; set; }

		///<summary>
		/// Like Received Count
		/// <para>Name: LikeReceivedCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "likeReceivedCount")]
		[Updateable(false), Createable(false)]
		public int? LikeReceivedCount { get; set; }

		///<summary>
		/// Influence Raw Rank
		/// <para>Name: InfluenceRawRank</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "influenceRawRank")]
		[Updateable(false), Createable(false)]
		public int? InfluenceRawRank { get; set; }

		///<summary>
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

	}
}
