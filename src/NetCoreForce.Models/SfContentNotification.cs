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
	/// Content Notification
	///<para>SObject Name: ContentNotification</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfContentNotification : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ContentNotification"; }
		}

		///<summary>
		/// ContentNotification ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Nature
		/// <para>Name: Nature</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "nature")]
		[Updateable(false), Createable(false)]
		public string Nature { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: UsersId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "usersId")]
		[Updateable(false), Createable(false)]
		public string UsersId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: Users</para>
		///</summary>
		[JsonProperty(PropertyName = "users")]
		[Updateable(false), Createable(false)]
		public SfUser Users { get; set; }

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
		/// Entity Type
		/// <para>Name: EntityType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "entityType")]
		[Updateable(false), Createable(false)]
		public string EntityType { get; set; }

		///<summary>
		/// Entity ID
		/// <para>Name: EntityIdentifierId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "entityIdentifierId")]
		[Updateable(false), Createable(false)]
		public string EntityIdentifierId { get; set; }

		///<summary>
		/// Subject
		/// <para>Name: Subject</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "subject")]
		[Updateable(false), Createable(false)]
		public string Subject { get; set; }

		///<summary>
		/// Text
		/// <para>Name: Text</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "text")]
		[Updateable(false), Createable(false)]
		public string Text { get; set; }

	}
}
