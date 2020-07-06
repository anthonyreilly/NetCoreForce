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
	/// Content Workspace Subscription
	///<para>SObject Name: ContentWorkspaceSubscription</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfContentWorkspaceSubscription : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ContentWorkspaceSubscription"; }
		}

		///<summary>
		/// ContentWorkspaceSubscription ID
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
		/// Workspace ID
		/// <para>Name: ContentWorkspaceId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "contentWorkspaceId")]
		[Updateable(false), Createable(false)]
		public string ContentWorkspaceId { get; set; }

		///<summary>
		/// ReferenceTo: ContentWorkspace
		/// <para>RelationshipName: ContentWorkspace</para>
		///</summary>
		[JsonProperty(PropertyName = "contentWorkspace")]
		[Updateable(false), Createable(false)]
		public SfContentWorkspace ContentWorkspace { get; set; }

	}
}
