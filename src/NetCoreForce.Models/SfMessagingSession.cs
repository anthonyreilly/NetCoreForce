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
	/// Messaging Session
	///<para>SObject Name: MessagingSession</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfMessagingSession : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "MessagingSession"; }
		}

		///<summary>
		/// Messaging Session ID
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
		/// Messaging Session Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>AutoNumber field</para>
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
		/// Last Viewed Date
		/// <para>Name: LastViewedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastViewedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastViewedDate { get; set; }

		///<summary>
		/// Last Referenced Date
		/// <para>Name: LastReferencedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastReferencedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastReferencedDate { get; set; }

		///<summary>
		/// Messaging Channel ID
		/// <para>Name: MessagingChannelId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "messagingChannelId")]
		[Updateable(false), Createable(true)]
		public string MessagingChannelId { get; set; }

		///<summary>
		/// ReferenceTo: MessagingChannel
		/// <para>RelationshipName: MessagingChannel</para>
		///</summary>
		[JsonProperty(PropertyName = "messagingChannel")]
		[Updateable(false), Createable(false)]
		public SfMessagingChannel MessagingChannel { get; set; }

		///<summary>
		/// Messaging User ID
		/// <para>Name: MessagingEndUserId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "messagingEndUserId")]
		[Updateable(false), Createable(true)]
		public string MessagingEndUserId { get; set; }

		///<summary>
		/// ReferenceTo: MessagingEndUser
		/// <para>RelationshipName: MessagingEndUser</para>
		///</summary>
		[JsonProperty(PropertyName = "messagingEndUser")]
		[Updateable(false), Createable(false)]
		public SfMessagingEndUser MessagingEndUser { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		[Updateable(false), Createable(true)]
		public string Status { get; set; }

		///<summary>
		/// Case ID
		/// <para>Name: CaseId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "caseId")]
		public string CaseId { get; set; }

		///<summary>
		/// ReferenceTo: Case
		/// <para>RelationshipName: Case</para>
		///</summary>
		[JsonProperty(PropertyName = "case")]
		[Updateable(false), Createable(false)]
		public SfCase Case { get; set; }

		///<summary>
		/// Lead ID
		/// <para>Name: LeadId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "leadId")]
		public string LeadId { get; set; }

		///<summary>
		/// ReferenceTo: Lead
		/// <para>RelationshipName: Lead</para>
		///</summary>
		[JsonProperty(PropertyName = "lead")]
		[Updateable(false), Createable(false)]
		public SfLead Lead { get; set; }

		///<summary>
		/// Opportunity ID
		/// <para>Name: OpportunityId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "opportunityId")]
		public string OpportunityId { get; set; }

		///<summary>
		/// ReferenceTo: Opportunity
		/// <para>RelationshipName: Opportunity</para>
		///</summary>
		[JsonProperty(PropertyName = "opportunity")]
		[Updateable(false), Createable(false)]
		public SfOpportunity Opportunity { get; set; }

		///<summary>
		/// Accept Time
		/// <para>Name: AcceptTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "acceptTime")]
		public DateTimeOffset? AcceptTime { get; set; }

		///<summary>
		/// Start Time
		/// <para>Name: StartTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "startTime")]
		[Updateable(false), Createable(true)]
		public DateTimeOffset? StartTime { get; set; }

		///<summary>
		/// End Time
		/// <para>Name: EndTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "endTime")]
		[Updateable(false), Createable(true)]
		public DateTimeOffset? EndTime { get; set; }

		///<summary>
		/// Origin
		/// <para>Name: Origin</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "origin")]
		[Updateable(false), Createable(true)]
		public string Origin { get; set; }

		///<summary>
		/// Agent Type
		/// <para>Name: AgentType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "agentType")]
		[Updateable(false), Createable(true)]
		public string AgentType { get; set; }

		///<summary>
		/// Session Key
		/// <para>Name: SessionKey</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sessionKey")]
		[Updateable(false), Createable(true)]
		public string SessionKey { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: TargetUserId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "targetUserId")]
		public string TargetUserId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: TargetUser</para>
		///</summary>
		[JsonProperty(PropertyName = "targetUser")]
		[Updateable(false), Createable(false)]
		public SfUser TargetUser { get; set; }

		///<summary>
		/// Group
		/// <para>Name: ChannelGroup</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "channelGroup")]
		public string ChannelGroup { get; set; }

		///<summary>
		/// Intent
		/// <para>Name: ChannelIntent</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "channelIntent")]
		public string ChannelIntent { get; set; }

		///<summary>
		/// Locale
		/// <para>Name: ChannelLocale</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "channelLocale")]
		public string ChannelLocale { get; set; }

		///<summary>
		/// Conversation ID
		/// <para>Name: ConversationId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "conversationId")]
		[Updateable(false), Createable(true)]
		public string ConversationId { get; set; }

		///<summary>
		/// ReferenceTo: Conversation
		/// <para>RelationshipName: Conversation</para>
		///</summary>
		[JsonProperty(PropertyName = "conversation")]
		[Updateable(false), Createable(false)]
		public SfConversation Conversation { get; set; }

		///<summary>
		/// Account ID
		/// <para>Name: EndUserAccountId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "endUserAccountId")]
		[Updateable(false), Createable(false)]
		public string EndUserAccountId { get; set; }

		///<summary>
		/// ReferenceTo: Account
		/// <para>RelationshipName: EndUserAccount</para>
		///</summary>
		[JsonProperty(PropertyName = "endUserAccount")]
		[Updateable(false), Createable(false)]
		public SfAccount EndUserAccount { get; set; }

		///<summary>
		/// Contact ID
		/// <para>Name: EndUserContactId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "endUserContactId")]
		[Updateable(false), Createable(false)]
		public string EndUserContactId { get; set; }

		///<summary>
		/// ReferenceTo: Contact
		/// <para>RelationshipName: EndUserContact</para>
		///</summary>
		[JsonProperty(PropertyName = "endUserContact")]
		[Updateable(false), Createable(false)]
		public SfContact EndUserContact { get; set; }

		///<summary>
		/// Channel Type
		/// <para>Name: ChannelType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "channelType")]
		[Updateable(false), Createable(false)]
		public string ChannelType { get; set; }

		///<summary>
		/// Channel Name
		/// <para>Name: ChannelName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "channelName")]
		[Updateable(false), Createable(false)]
		public string ChannelName { get; set; }

		///<summary>
		/// Channel Key
		/// <para>Name: ChannelKey</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "channelKey")]
		[Updateable(false), Createable(false)]
		public string ChannelKey { get; set; }

		///<summary>
		/// Preview Details
		/// <para>Name: PreviewDetails</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "previewDetails")]
		[Updateable(false), Createable(false)]
		public string PreviewDetails { get; set; }

		///<summary>
		/// End User Message Count
		/// <para>Name: EndUserMessageCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "endUserMessageCount")]
		[Updateable(false), Createable(false)]
		public int? EndUserMessageCount { get; set; }

		///<summary>
		/// Agent Message Count
		/// <para>Name: AgentMessageCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "agentMessageCount")]
		[Updateable(false), Createable(false)]
		public int? AgentMessageCount { get; set; }

		///<summary>
		/// Ended By Type
		/// <para>Name: EndedByType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "endedByType")]
		[Updateable(false), Createable(true)]
		public string EndedByType { get; set; }

		///<summary>
		/// Concatenated Messaging Channel and Messaging User
		/// <para>Name: ChannelEndUserFormula</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "channelEndUserFormula")]
		[Updateable(false), Createable(false)]
		public string ChannelEndUserFormula { get; set; }

	}
}
