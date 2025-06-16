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
	/// Conversation Message Send Request
	///<para>SObject Name: ConvMessageSendRequest</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfConvMessageSendRequest : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ConvMessageSendRequest"; }
		}

		///<summary>
		/// Conversation Message Send Request ID
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
		/// Conversation Message Send Request Name
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
		/// Message Definition
		/// <para>Name: MessageDefinition</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "messageDefinition")]
		[Updateable(false), Createable(false)]
		public string MessageDefinition { get; set; }

		///<summary>
		/// Request Type
		/// <para>Name: RequestType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "requestType")]
		[Updateable(false), Createable(false)]
		public string RequestType { get; set; }

		///<summary>
		/// Request Status
		/// <para>Name: RequestStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "requestStatus")]
		[Updateable(false), Createable(false)]
		public string RequestStatus { get; set; }

		///<summary>
		/// Completed Date
		/// <para>Name: CompletedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "completedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? CompletedDate { get; set; }

		///<summary>
		/// Should Enforce Channel Consent
		/// <para>Name: ShouldEnforceChannelConsent</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "shouldEnforceChannelConsent")]
		[Updateable(false), Createable(false)]
		public bool? ShouldEnforceChannelConsent { get; set; }

		///<summary>
		/// Allow Existing Session Status
		/// <para>Name: AllowExistingSessionStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "allowExistingSessionStatus")]
		[Updateable(false), Createable(false)]
		public string AllowExistingSessionStatus { get; set; }

		///<summary>
		/// Total Message Count
		/// <para>Name: TotalMessageCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalMessageCount")]
		[Updateable(false), Createable(false)]
		public int? TotalMessageCount { get; set; }

		///<summary>
		/// Pending Message Count
		/// <para>Name: PendingMessageCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "pendingMessageCount")]
		[Updateable(false), Createable(false)]
		public int? PendingMessageCount { get; set; }

		///<summary>
		/// Pending Message Identifiers
		/// <para>Name: PendingMessageIdentifiers</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "pendingMessageIdentifiers")]
		[Updateable(false), Createable(false)]
		public string PendingMessageIdentifiers { get; set; }

		///<summary>
		/// In Progress Message Count
		/// <para>Name: InProgressMessageCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "inProgressMessageCount")]
		[Updateable(false), Createable(false)]
		public int? InProgressMessageCount { get; set; }

		///<summary>
		/// In Progress Message Identifiers
		/// <para>Name: InProgressMessageIdentifiers</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "inProgressMessageIdentifiers")]
		[Updateable(false), Createable(false)]
		public string InProgressMessageIdentifiers { get; set; }

		///<summary>
		/// Success Message Count
		/// <para>Name: SuccessMessageCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "successMessageCount")]
		[Updateable(false), Createable(false)]
		public int? SuccessMessageCount { get; set; }

		///<summary>
		/// Success Message Identifiers
		/// <para>Name: SuccessMessageIdentifiers</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "successMessageIdentifiers")]
		[Updateable(false), Createable(false)]
		public string SuccessMessageIdentifiers { get; set; }

		///<summary>
		/// Failed Message Count
		/// <para>Name: FailedMessageCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "failedMessageCount")]
		[Updateable(false), Createable(false)]
		public int? FailedMessageCount { get; set; }

		///<summary>
		/// Failed Message Identifiers
		/// <para>Name: FailedMessageIdentifiers</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "failedMessageIdentifiers")]
		[Updateable(false), Createable(false)]
		public string FailedMessageIdentifiers { get; set; }

		///<summary>
		/// Failed Message Error Reasons
		/// <para>Name: FailedMessageErrorReasons</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "failedMessageErrorReasons")]
		[Updateable(false), Createable(false)]
		public string FailedMessageErrorReasons { get; set; }

		///<summary>
		/// Type of Channel Consent to Enforce
		/// <para>Name: RequestConsentType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "requestConsentType")]
		[Updateable(false), Createable(false)]
		public string RequestConsentType { get; set; }

		///<summary>
		/// Communication Subscription ID
		/// <para>Name: CommSubscriptionId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "commSubscriptionId")]
		[Updateable(false), Createable(false)]
		public string CommSubscriptionId { get; set; }

		///<summary>
		/// ReferenceTo: CommSubscription
		/// <para>RelationshipName: CommSubscription</para>
		///</summary>
		[JsonProperty(PropertyName = "commSubscription")]
		[Updateable(false), Createable(false)]
		public SfCommSubscription CommSubscription { get; set; }

		///<summary>
		/// Messaging Session Longevity
		/// <para>Name: SessionLongevityPreference</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sessionLongevityPreference")]
		[Updateable(false), Createable(false)]
		public string SessionLongevityPreference { get; set; }

	}
}
