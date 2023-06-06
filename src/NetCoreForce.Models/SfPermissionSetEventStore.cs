// SF API version v57.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Permission Set Event Store 
	///<para>SObject Name: PermissionSetEventStore</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfPermissionSetEventStore : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "PermissionSetEventStore"; }
		}

		///<summary>
		/// Permission Set Event Store ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

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
		/// Event Identifier
		/// <para>Name: EventIdentifier</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "eventIdentifier")]
		[Updateable(false), Createable(false)]
		public string EventIdentifier { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: UserId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
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
		/// Username
		/// <para>Name: Username</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "username")]
		[Updateable(false), Createable(false)]
		public string Username { get; set; }

		///<summary>
		/// Event Date
		/// <para>Name: EventDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "eventDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? EventDate { get; set; }

		///<summary>
		/// Related Event Identifier
		/// <para>Name: RelatedEventIdentifier</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relatedEventIdentifier")]
		[Updateable(false), Createable(false)]
		public string RelatedEventIdentifier { get; set; }

		///<summary>
		/// Transaction Security Policy ID
		/// <para>Name: PolicyId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "policyId")]
		[Updateable(false), Createable(false)]
		public string PolicyId { get; set; }

		///<summary>
		/// ReferenceTo: TransactionSecurityPolicy
		/// <para>RelationshipName: Policy</para>
		///</summary>
		[JsonProperty(PropertyName = "policy")]
		[Updateable(false), Createable(false)]
		public SfTransactionSecurityPolicy Policy { get; set; }

		///<summary>
		/// Policy Outcome
		/// <para>Name: PolicyOutcome</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "policyOutcome")]
		[Updateable(false), Createable(false)]
		public string PolicyOutcome { get; set; }

		///<summary>
		/// Evaluation Time
		/// <para>Name: EvaluationTime</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "evaluationTime")]
		[Updateable(false), Createable(false)]
		public double? EvaluationTime { get; set; }

		///<summary>
		/// Session Key
		/// <para>Name: SessionKey</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sessionKey")]
		[Updateable(false), Createable(false)]
		public string SessionKey { get; set; }

		///<summary>
		/// Login Key
		/// <para>Name: LoginKey</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "loginKey")]
		[Updateable(false), Createable(false)]
		public string LoginKey { get; set; }

		///<summary>
		/// Session Level
		/// <para>Name: SessionLevel</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sessionLevel")]
		[Updateable(false), Createable(false)]
		public string SessionLevel { get; set; }

		///<summary>
		/// Source IP
		/// <para>Name: SourceIp</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sourceIp")]
		[Updateable(false), Createable(false)]
		public string SourceIp { get; set; }

		///<summary>
		/// Login History ID
		/// <para>Name: LoginHistoryId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "loginHistoryId")]
		[Updateable(false), Createable(false)]
		public string LoginHistoryId { get; set; }

		///<summary>
		/// ReferenceTo: LoginHistory
		/// <para>RelationshipName: LoginHistory</para>
		///</summary>
		[JsonProperty(PropertyName = "loginHistory")]
		[Updateable(false), Createable(false)]
		public SfLoginHistory LoginHistory { get; set; }

		///<summary>
		/// Event Source
		/// <para>Name: EventSource</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "eventSource")]
		[Updateable(false), Createable(false)]
		public string EventSource { get; set; }

		///<summary>
		/// Operation
		/// <para>Name: Operation</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "operation")]
		[Updateable(false), Createable(false)]
		public string Operation { get; set; }

		///<summary>
		/// Parent Id List
		/// <para>Name: ParentIdList</para>
		/// <para>SF Type: json</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "parentIdList")]
		[Updateable(false), Createable(false)]
		public string ParentIdList { get; set; }

		///<summary>
		/// Parent Name List
		/// <para>Name: ParentNameList</para>
		/// <para>SF Type: json</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "parentNameList")]
		[Updateable(false), Createable(false)]
		public string ParentNameList { get; set; }

		///<summary>
		/// Permission Type
		/// <para>Name: PermissionType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionType")]
		[Updateable(false), Createable(false)]
		public string PermissionType { get; set; }

		///<summary>
		/// Permission List
		/// <para>Name: PermissionList</para>
		/// <para>SF Type: json</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionList")]
		[Updateable(false), Createable(false)]
		public string PermissionList { get; set; }

		///<summary>
		/// Has External Users
		/// <para>Name: HasExternalUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasExternalUsers")]
		[Updateable(false), Createable(false)]
		public bool? HasExternalUsers { get; set; }

		///<summary>
		/// Impacted User Ids
		/// <para>Name: ImpactedUserIds</para>
		/// <para>SF Type: json</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "impactedUserIds")]
		[Updateable(false), Createable(false)]
		public string ImpactedUserIds { get; set; }

		///<summary>
		/// User Count
		/// <para>Name: UserCount</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "userCount")]
		[Updateable(false), Createable(false)]
		public string UserCount { get; set; }

		///<summary>
		/// Permission Expiration
		/// <para>Name: PermissionExpiration</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionExpiration")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? PermissionExpiration { get; set; }

		///<summary>
		/// Permission Expiration List
		/// <para>Name: PermissionExpirationList</para>
		/// <para>SF Type: json</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionExpirationList")]
		[Updateable(false), Createable(false)]
		public string PermissionExpirationList { get; set; }

	}
}
