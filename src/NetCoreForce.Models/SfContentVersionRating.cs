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
	/// Content Version Rating
	///<para>SObject Name: ContentVersionRating</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfContentVersionRating : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ContentVersionRating"; }
		}

		///<summary>
		/// ContentVersionRating ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: UserId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userId")]
		[Updateable(false), Createable(false)]
		public string UserId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: User</para>
		///</summary>
		[JsonProperty(PropertyName = "user")]
		[Updateable(false), Createable(false)]
		public SfUser User { get; set; }

		///<summary>
		/// Version ID
		/// <para>Name: ContentVersionId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "contentVersionId")]
		[Updateable(false), Createable(false)]
		public string ContentVersionId { get; set; }

		///<summary>
		/// ReferenceTo: ContentVersion
		/// <para>RelationshipName: ContentVersion</para>
		///</summary>
		[JsonProperty(PropertyName = "contentVersion")]
		[Updateable(false), Createable(false)]
		public SfContentVersion ContentVersion { get; set; }

		///<summary>
		/// Rating
		/// <para>Name: Rating</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "rating")]
		[Updateable(false), Createable(false)]
		public int? Rating { get; set; }

		///<summary>
		/// User Comment
		/// <para>Name: UserComment</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "userComment")]
		[Updateable(false), Createable(false)]
		public string UserComment { get; set; }

		///<summary>
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

	}
}
