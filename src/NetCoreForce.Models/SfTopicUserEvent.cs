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
	/// Topic User Event
	///<para>SObject Name: TopicUserEvent</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfTopicUserEvent : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "TopicUserEvent"; }
		}

		///<summary>
		/// Event ID
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
		/// Topic ID
		/// <para>Name: TopicId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "topicId")]
		[Updateable(false), Createable(false)]
		public string TopicId { get; set; }

		///<summary>
		/// Action
		/// <para>Name: ActionEnum</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "actionEnum")]
		[Updateable(false), Createable(false)]
		public string ActionEnum { get; set; }

		///<summary>
		/// Create Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

	}
}
