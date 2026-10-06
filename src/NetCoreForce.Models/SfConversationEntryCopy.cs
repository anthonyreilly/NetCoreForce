// SF API version v67.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Conversation Entry Copy
	///<para>SObject Name: ConversationEntryCopy</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfConversationEntryCopy : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ConversationEntryCopy"; }
		}

		///<summary>
		/// Conversation Entry Copy ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Owner ID
		/// <para>Name: OwnerId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "ownerId")]
		[Updateable(false), Createable(false)]
		public string OwnerId { get; set; }

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
		/// Conversation Entry Copy Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
		public string Name { get; set; }

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
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

		///<summary>
		/// Conversation Entry Identifier
		/// <para>Name: ConversationEntryIdentifier</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "conversationEntryIdentifier")]
		[Updateable(false), Createable(false)]
		public string ConversationEntryIdentifier { get; set; }

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
		/// ReferenceTo: Conversation
		/// <para>RelationshipName: Conversation</para>
		///</summary>
		[JsonProperty(PropertyName = "conversation")]
		[Updateable(false), Createable(false)]
		public SfConversation Conversation { get; set; }

		///<summary>
		/// Conversation Participant ID
		/// <para>Name: ConversationParticipantId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "conversationParticipantId")]
		[Updateable(false), Createable(false)]
		public string ConversationParticipantId { get; set; }

		///<summary>
		/// ReferenceTo: ConversationParticipant
		/// <para>RelationshipName: ConversationParticipant</para>
		///</summary>
		[JsonProperty(PropertyName = "conversationParticipant")]
		[Updateable(false), Createable(false)]
		public SfConversationParticipant ConversationParticipant { get; set; }

		///<summary>
		/// Client Timestamp
		/// <para>Name: ClientTimestamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "clientTimestamp")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? ClientTimestamp { get; set; }

		///<summary>
		/// Client Duration
		/// <para>Name: ClientDuration</para>
		/// <para>SF Type: long</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "clientDuration")]
		[Updateable(false), Createable(false)]
		public string ClientDuration { get; set; }

		///<summary>
		/// Transcripted Timestamp
		/// <para>Name: TranscriptedTimestamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "transcriptedTimestamp")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? TranscriptedTimestamp { get; set; }

		///<summary>
		/// Entry Type
		/// <para>Name: EntryType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "entryType")]
		[Updateable(false), Createable(false)]
		public string EntryType { get; set; }

		///<summary>
		/// Entry Payload
		/// <para>Name: EntryPayload</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "entryPayload")]
		[Updateable(false), Createable(false)]
		public string EntryPayload { get; set; }

		///<summary>
		/// Language
		/// <para>Name: Language</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "language")]
		[Updateable(false), Createable(false)]
		public string Language { get; set; }

		///<summary>
		/// Version
		/// <para>Name: Version</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "version")]
		[Updateable(false), Createable(false)]
		public int? Version { get; set; }

		///<summary>
		/// Visibility Strategy
		/// <para>Name: VisibilityStrategy</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "visibilityStrategy")]
		[Updateable(false), Createable(false)]
		public string VisibilityStrategy { get; set; }

		///<summary>
		/// Conversation Entry Copy ID
		/// <para>Name: ParentConvEntryCopyId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "parentConvEntryCopyId")]
		[Updateable(false), Createable(false)]
		public string ParentConvEntryCopyId { get; set; }

		///<summary>
		/// ReferenceTo: ConversationEntryCopy
		/// <para>RelationshipName: ParentConvEntryCopy</para>
		///</summary>
		[JsonProperty(PropertyName = "parentConvEntryCopy")]
		[Updateable(false), Createable(false)]
		public SfConversationEntryCopy ParentConvEntryCopy { get; set; }

		///<summary>
		/// Modality
		/// <para>Name: Modality</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "modality")]
		[Updateable(false), Createable(false)]
		public string Modality { get; set; }

	}
}
