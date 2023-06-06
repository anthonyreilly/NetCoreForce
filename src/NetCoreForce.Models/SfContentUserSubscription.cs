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
	/// Content User Subscription
	///<para>SObject Name: ContentUserSubscription</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfContentUserSubscription : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ContentUserSubscription"; }
		}

		///<summary>
		/// ContentUserSubscription ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: SubscriberUserId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "subscriberUserId")]
		[Updateable(false), Createable(false)]
		public string SubscriberUserId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: SubscriberUser</para>
		///</summary>
		[JsonProperty(PropertyName = "subscriberUser")]
		[Updateable(false), Createable(false)]
		public SfUser SubscriberUser { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: SubscribedToUserId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "subscribedToUserId")]
		[Updateable(false), Createable(false)]
		public string SubscribedToUserId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: SubscribedToUser</para>
		///</summary>
		[JsonProperty(PropertyName = "subscribedToUser")]
		[Updateable(false), Createable(false)]
		public SfUser SubscribedToUser { get; set; }

	}
}
