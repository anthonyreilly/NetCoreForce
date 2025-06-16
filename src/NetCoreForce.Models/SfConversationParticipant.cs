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
	/// Conversation Participant
	///<para>SObject Name: ConversationParticipant</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfConversationParticipant : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ConversationParticipant"; }
		}

		///<summary>
		/// Conversation Participant ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Conversation Participant Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>AutoNumber field</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
		public string Name { get; set; }

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
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

		///<summary>
		/// Created By ID
		/// <para>Name: CreatedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdById")]
		[Updateable(false), Createable(false)]
		public string CreatedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: CreatedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "createdBy")]
		[Updateable(false), Createable(false)]
		public SfUser CreatedBy { get; set; }

		///<summary>
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

		///<summary>
		/// Last Modified By ID
		/// <para>Name: LastModifiedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedById")]
		[Updateable(false), Createable(false)]
		public string LastModifiedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: LastModifiedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedBy")]
		[Updateable(false), Createable(false)]
		public SfUser LastModifiedBy { get; set; }

		///<summary>
		/// Conversation ID
		/// <para>Name: ConversationId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "conversationId")]
		[Updateable(false), Createable(false)]
		public string ConversationId { get; set; }

		///<summary>
		/// App Type
		/// <para>Name: AppType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "appType")]
		[Updateable(false), Createable(false)]
		public string AppType { get; set; }

		///<summary>
		/// Joined Time
		/// <para>Name: JoinedTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "joinedTime")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? JoinedTime { get; set; }

		///<summary>
		/// ParticipantEntity ID
		/// <para>Name: ParticipantEntityId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "participantEntityId")]
		[Updateable(false), Createable(false)]
		public string ParticipantEntityId { get; set; }

		///<summary>
		/// Participant Key
		/// <para>Name: ParticipantKey</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "participantKey")]
		[Updateable(false), Createable(false)]
		public string ParticipantKey { get; set; }

		///<summary>
		/// Participant Role
		/// <para>Name: ParticipantRole</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "participantRole")]
		[Updateable(false), Createable(false)]
		public string ParticipantRole { get; set; }

		///<summary>
		/// Participant Context
		/// <para>Name: ParticipantContext</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "participantContext")]
		[Updateable(false), Createable(false)]
		public string ParticipantContext { get; set; }

		///<summary>
		/// Participant Display Name
		/// <para>Name: ParticipantDisplayName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "participantDisplayName")]
		[Updateable(false), Createable(false)]
		public string ParticipantDisplayName { get; set; }

		///<summary>
		/// Left Time
		/// <para>Name: LeftTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "leftTime")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LeftTime { get; set; }

		///<summary>
		/// Last Active Time
		/// <para>Name: LastActiveTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastActiveTime")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastActiveTime { get; set; }

	}
}
