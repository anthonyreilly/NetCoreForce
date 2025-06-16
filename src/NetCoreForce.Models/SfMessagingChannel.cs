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
	/// Messaging Channel
	///<para>SObject Name: MessagingChannel</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfMessagingChannel : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "MessagingChannel"; }
		}

		///<summary>
		/// Messaging Channel ID
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
		/// Developer Name
		/// <para>Name: DeveloperName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "developerName")]
		public string DeveloperName { get; set; }

		///<summary>
		/// Master Language
		/// <para>Name: Language</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "language")]
		public string Language { get; set; }

		///<summary>
		/// Channel Name
		/// <para>Name: MasterLabel</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "masterLabel")]
		public string MasterLabel { get; set; }

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
		/// Modified On
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
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

		///<summary>
		/// Channel Address Identifier
		/// <para>Name: ChannelAddressIdentifier</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "channelAddressIdentifier")]
		[Updateable(false), Createable(false)]
		public string ChannelAddressIdentifier { get; set; }

		///<summary>
		/// Type
		/// <para>Name: MessageType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "messageType")]
		public string MessageType { get; set; }

		///<summary>
		/// Messaging Platform Key
		/// <para>Name: MessagingPlatformKey</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "messagingPlatformKey")]
		public string MessagingPlatformKey { get; set; }

		///<summary>
		/// ISO Country Code
		/// <para>Name: IsoCountryCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "isoCountryCode")]
		[Updateable(false), Createable(true)]
		public string IsoCountryCode { get; set; }

		///<summary>
		/// Platform Type
		/// <para>Name: PlatformType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "platformType")]
		[Updateable(false), Createable(true)]
		public string PlatformType { get; set; }

		///<summary>
		/// Active
		/// <para>Name: IsActive</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isActive")]
		public bool? IsActive { get; set; }

		///<summary>
		/// Routing Type
		/// <para>Name: RoutingType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "routingType")]
		public string RoutingType { get; set; }

		///<summary>
		/// Queue ID
		/// <para>Name: TargetQueueId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "targetQueueId")]
		public string TargetQueueId { get; set; }

		///<summary>
		/// ReferenceTo: Group
		/// <para>RelationshipName: TargetQueue</para>
		///</summary>
		[JsonProperty(PropertyName = "targetQueue")]
		[Updateable(false), Createable(false)]
		public SfGroup TargetQueue { get; set; }

		///<summary>
		/// Routing Type ID
		/// <para>Name: SessionHandlerId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sessionHandlerId")]
		public string SessionHandlerId { get; set; }

		///<summary>
		/// Queue ID
		/// <para>Name: FallbackQueueId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fallbackQueueId")]
		public string FallbackQueueId { get; set; }

		///<summary>
		/// ReferenceTo: Group
		/// <para>RelationshipName: FallbackQueue</para>
		///</summary>
		[JsonProperty(PropertyName = "fallbackQueue")]
		[Updateable(false), Createable(false)]
		public SfGroup FallbackQueue { get; set; }

		///<summary>
		/// Consent Type
		/// <para>Name: ConsentType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "consentType")]
		public string ConsentType { get; set; }

		///<summary>
		/// Opt-In Prompt
		/// <para>Name: OptInPrompt</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "optInPrompt")]
		public string OptInPrompt { get; set; }

		///<summary>
		/// Double Opt-In Prompt
		/// <para>Name: DoubleOptInPrompt</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "doubleOptInPrompt")]
		public string DoubleOptInPrompt { get; set; }

		///<summary>
		/// Require Double Opt-In?
		/// <para>Name: IsRequireDoubleOptIn</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isRequireDoubleOptIn")]
		public bool? IsRequireDoubleOptIn { get; set; }

		///<summary>
		/// Conversation Acknowledgement
		/// <para>Name: InitialResponse</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "initialResponse")]
		public string InitialResponse { get; set; }

		///<summary>
		/// Start Conversation
		/// <para>Name: EngagedResponse</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "engagedResponse")]
		public string EngagedResponse { get; set; }

		///<summary>
		/// End Conversation
		/// <para>Name: ConversationEndResponse</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "conversationEndResponse")]
		public string ConversationEndResponse { get; set; }

		///<summary>
		/// Offline Agents Response
		/// <para>Name: OfflineAgentsResponse</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "offlineAgentsResponse")]
		public string OfflineAgentsResponse { get; set; }

		///<summary>
		/// Outside Business Hours Response
		/// <para>Name: OutsideBusinessHoursResponse</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "outsideBusinessHoursResponse")]
		public string OutsideBusinessHoursResponse { get; set; }

		///<summary>
		/// Business Hours ID
		/// <para>Name: BusinessHoursId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "businessHoursId")]
		public string BusinessHoursId { get; set; }

		///<summary>
		/// ReferenceTo: BusinessHours
		/// <para>RelationshipName: BusinessHours</para>
		///</summary>
		[JsonProperty(PropertyName = "businessHours")]
		[Updateable(false), Createable(false)]
		public SfBusinessHours BusinessHours { get; set; }

		///<summary>
		/// Is Restricted to Business Hours
		/// <para>Name: IsRestrictedToBusinessHours</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isRestrictedToBusinessHours")]
		public bool? IsRestrictedToBusinessHours { get; set; }

		///<summary>
		/// Select record type to link
		/// <para>Name: LinkingPreference</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "linkingPreference")]
		public string LinkingPreference { get; set; }

		///<summary>
		/// Open linked record as a subtab within the Messaging Session
		/// <para>Name: IsLinkedRecordOpenedAsSubTab</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isLinkedRecordOpenedAsSubTab")]
		public bool? IsLinkedRecordOpenedAsSubTab { get; set; }

	}
}
