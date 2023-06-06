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
	/// API Event
	///<para>SObject Name: ApiEvent</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfApiEvent : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ApiEvent"; }
		}

		///<summary>
		/// API Event ID
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
		/// Rows Processed
		/// <para>Name: RowsProcessed</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "rowsProcessed")]
		[Updateable(false), Createable(false)]
		public double? RowsProcessed { get; set; }

		///<summary>
		/// Rows Returned
		/// <para>Name: RowsReturned</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "rowsReturned")]
		[Updateable(false), Createable(false)]
		public double? RowsReturned { get; set; }

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
		/// Queried Entities
		/// <para>Name: QueriedEntities</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "queriedEntities")]
		[Updateable(false), Createable(false)]
		public string QueriedEntities { get; set; }

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
		/// Additional Information
		/// <para>Name: AdditionalInfo</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "additionalInfo")]
		[Updateable(false), Createable(false)]
		public string AdditionalInfo { get; set; }

		///<summary>
		/// API Type
		/// <para>Name: ApiType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "apiType")]
		[Updateable(false), Createable(false)]
		public string ApiType { get; set; }

		///<summary>
		/// API Version
		/// <para>Name: ApiVersion</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "apiVersion")]
		[Updateable(false), Createable(false)]
		public double? ApiVersion { get; set; }

		///<summary>
		/// Application
		/// <para>Name: Application</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "application")]
		[Updateable(false), Createable(false)]
		public string Application { get; set; }

		///<summary>
		/// Client
		/// <para>Name: Client</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "client")]
		[Updateable(false), Createable(false)]
		public string Client { get; set; }

		///<summary>
		/// Connected App ID
		/// <para>Name: ConnectedAppId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "connectedAppId")]
		[Updateable(false), Createable(false)]
		public string ConnectedAppId { get; set; }

		///<summary>
		/// ReferenceTo: ConnectedApplication
		/// <para>RelationshipName: ConnectedApp</para>
		///</summary>
		[JsonProperty(PropertyName = "connectedApp")]
		[Updateable(false), Createable(false)]
		public SfConnectedApplication ConnectedApp { get; set; }

		///<summary>
		/// Elapsed Time
		/// <para>Name: ElapsedTime</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "elapsedTime")]
		[Updateable(false), Createable(false)]
		public int? ElapsedTime { get; set; }

		///<summary>
		/// Platform
		/// <para>Name: Platform</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "platform")]
		[Updateable(false), Createable(false)]
		public string Platform { get; set; }

		///<summary>
		/// Query
		/// <para>Name: Query</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "query")]
		[Updateable(false), Createable(false)]
		public string Query { get; set; }

		///<summary>
		/// Records
		/// <para>Name: Records</para>
		/// <para>SF Type: json</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "records")]
		[Updateable(false), Createable(false)]
		public string Records { get; set; }

		///<summary>
		/// User Agent
		/// <para>Name: UserAgent</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "userAgent")]
		[Updateable(false), Createable(false)]
		public string UserAgent { get; set; }

	}
}
