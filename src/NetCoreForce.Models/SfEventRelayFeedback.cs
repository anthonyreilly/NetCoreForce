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
	/// Event Relay Feedback
	///<para>SObject Name: EventRelayFeedback</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfEventRelayFeedback : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "EventRelayFeedback"; }
		}

		///<summary>
		/// Event Relay Feedback ID
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
		/// Event Relay Feedback Name
		/// <para>Name: EventRelayNumber</para>
		/// <para>SF Type: string</para>
		/// <para>AutoNumber field</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "eventRelayNumber")]
		[Updateable(false), Createable(false)]
		public string EventRelayNumber { get; set; }

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
		/// Event Relay Config ID
		/// <para>Name: EventRelayConfigId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "eventRelayConfigId")]
		[Updateable(false), Createable(false)]
		public string EventRelayConfigId { get; set; }

		///<summary>
		/// ReferenceTo: EventRelayConfig
		/// <para>RelationshipName: EventRelayConfig</para>
		///</summary>
		[JsonProperty(PropertyName = "eventRelayConfig")]
		[Updateable(false), Createable(false)]
		public SfEventRelayConfig EventRelayConfig { get; set; }

		///<summary>
		/// Remote Resource
		/// <para>Name: RemoteResource</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "remoteResource")]
		[Updateable(false), Createable(false)]
		public string RemoteResource { get; set; }

		///<summary>
		/// Current Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		[Updateable(false), Createable(false)]
		public string Status { get; set; }

		///<summary>
		/// Error Message
		/// <para>Name: ErrorMessage</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "errorMessage")]
		[Updateable(false), Createable(false)]
		public string ErrorMessage { get; set; }

		///<summary>
		/// Error Time
		/// <para>Name: ErrorTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "errorTime")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? ErrorTime { get; set; }

		///<summary>
		/// Error Identifier
		/// <para>Name: ErrorIdentifier</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "errorIdentifier")]
		[Updateable(false), Createable(false)]
		public string ErrorIdentifier { get; set; }

		///<summary>
		/// Error Code
		/// <para>Name: ErrorCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "errorCode")]
		[Updateable(false), Createable(false)]
		public string ErrorCode { get; set; }

		///<summary>
		/// Last Relayed Event Timestamp
		/// <para>Name: LastRelayedEventTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastRelayedEventTime")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastRelayedEventTime { get; set; }

		///<summary>
		/// Event Relay Usage Type
		/// <para>Name: UsageType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "usageType")]
		[Updateable(false), Createable(false)]
		public string UsageType { get; set; }

	}
}
