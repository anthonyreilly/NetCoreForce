// SF API version v64.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Content Document Subscription
	///<para>SObject Name: ContentDocumentSubscription</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfContentDocumentSubscription : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ContentDocumentSubscription"; }
		}

		///<summary>
		/// ContentDocumentSubscription ID
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
		/// Document ID
		/// <para>Name: ContentDocumentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "contentDocumentId")]
		[Updateable(false), Createable(false)]
		public string ContentDocumentId { get; set; }

		///<summary>
		/// ReferenceTo: ContentDocument
		/// <para>RelationshipName: ContentDocument</para>
		///</summary>
		[JsonProperty(PropertyName = "contentDocument")]
		[Updateable(false), Createable(false)]
		public SfContentDocument ContentDocument { get; set; }

		///<summary>
		/// Is Comment Subscription
		/// <para>Name: IsCommentSub</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isCommentSub")]
		[Updateable(false), Createable(false)]
		public bool? IsCommentSub { get; set; }

		///<summary>
		/// Is Document Subscription
		/// <para>Name: IsDocumentSub</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDocumentSub")]
		[Updateable(false), Createable(false)]
		public bool? IsDocumentSub { get; set; }

	}
}
