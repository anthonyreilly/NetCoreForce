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
	/// Conversation Entry
	///<para>SObject Name: ConversationEntry</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfConversationEntry : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ConversationEntry"; }
		}

		///<summary>
		/// Conversation Entry ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

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
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

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
		/// <para>Name: ConversationEntityId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "conversationEntityId")]
		public string ConversationEntityId { get; set; }

		///<summary>
		/// Conversation ID
		/// <para>Name: ConversationId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "conversationId")]
		[Updateable(false), Createable(true)]
		public string ConversationId { get; set; }

		///<summary>
		/// Sequence
		/// <para>Name: Seq</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "seq")]
		[Updateable(false), Createable(true)]
		public int? Seq { get; set; }

		///<summary>
		/// Entry Start Time
		/// <para>Name: EntryTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "entryTime")]
		[Updateable(false), Createable(true)]
		public DateTimeOffset? EntryTime { get; set; }

		///<summary>
		/// Entry Time Milli Seconds(last 3 digits)
		/// <para>Name: EntryTimeMilliSecs</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "entryTimeMilliSecs")]
		[Updateable(false), Createable(true)]
		public int? EntryTimeMilliSecs { get; set; }

		///<summary>
		/// Entry Type
		/// <para>Name: EntryType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "entryType")]
		[Updateable(false), Createable(true)]
		public string EntryType { get; set; }

		///<summary>
		/// Actor Type
		/// <para>Name: ActorType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "actorType")]
		[Updateable(false), Createable(true)]
		public string ActorType { get; set; }

		///<summary>
		/// Actor ID
		/// <para>Name: ActorId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "actorId")]
		[Updateable(false), Createable(true)]
		public string ActorId { get; set; }

		///<summary>
		/// Actor Name
		/// <para>Name: ActorName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "actorName")]
		[Updateable(false), Createable(true)]
		public string ActorName { get; set; }

		///<summary>
		/// Message
		/// <para>Name: Message</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "message")]
		[Updateable(false), Createable(true)]
		public string Message { get; set; }

		///<summary>
		/// Message Status
		/// <para>Name: MessageStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "messageStatus")]
		[Updateable(false), Createable(true)]
		public string MessageStatus { get; set; }

		///<summary>
		/// Message Status Code
		/// <para>Name: MessageStatusCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "messageStatusCode")]
		public string MessageStatusCode { get; set; }

		///<summary>
		/// Message Send Time
		/// <para>Name: MessageSendTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "messageSendTime")]
		[Updateable(false), Createable(true)]
		public DateTimeOffset? MessageSendTime { get; set; }

		///<summary>
		/// Message Deliver Time
		/// <para>Name: MessageDeliverTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "messageDeliverTime")]
		[Updateable(false), Createable(true)]
		public DateTimeOffset? MessageDeliverTime { get; set; }

		///<summary>
		/// Message Read Time
		/// <para>Name: MessageReadTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "messageReadTime")]
		[Updateable(false), Createable(true)]
		public DateTimeOffset? MessageReadTime { get; set; }

		///<summary>
		/// Message ID
		/// <para>Name: MessageIdentifier</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "messageIdentifier")]
		[Updateable(false), Createable(true)]
		public string MessageIdentifier { get; set; }

		///<summary>
		/// Has Attachments
		/// <para>Name: HasAttachments</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasAttachments")]
		[Updateable(false), Createable(true)]
		public bool? HasAttachments { get; set; }

		///<summary>
		/// Entry End Time
		/// <para>Name: EntryEndTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "entryEndTime")]
		[Updateable(false), Createable(true)]
		public DateTimeOffset? EntryEndTime { get; set; }

		///<summary>
		/// ClientTimestamp
		/// <para>Name: ClientTimestamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "clientTimestamp")]
		[Updateable(false), Createable(true)]
		public DateTimeOffset? ClientTimestamp { get; set; }

		///<summary>
		/// ClientDuration
		/// <para>Name: ClientDuration</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "clientDuration")]
		[Updateable(false), Createable(true)]
		public int? ClientDuration { get; set; }

		///<summary>
		/// ServerReceivedTimestamp
		/// <para>Name: ServerReceivedTimestamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "serverReceivedTimestamp")]
		[Updateable(false), Createable(true)]
		public DateTimeOffset? ServerReceivedTimestamp { get; set; }

	}
}
