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
	/// Privacy Job Session
	///<para>SObject Name: PrivacyJobSession</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfPrivacyJobSession : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "PrivacyJobSession"; }
		}

		///<summary>
		/// Privacy Job Session ID
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
		/// Name
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
		/// Job Status
		/// <para>Name: JobStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "jobStatus")]
		[Updateable(false), Createable(false)]
		public string JobStatus { get; set; }

		///<summary>
		/// Start Time
		/// <para>Name: StartTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "startTime")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? StartTime { get; set; }

		///<summary>
		/// End Time
		/// <para>Name: EndTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "endTime")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? EndTime { get; set; }

		///<summary>
		/// Creation Date
		/// <para>Name: CreationDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "creationDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? CreationDate { get; set; }

		///<summary>
		/// Serialized Policy
		/// <para>Name: SerializedPolicy</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "serializedPolicy")]
		[Updateable(false), Createable(false)]
		public string SerializedPolicy { get; set; }

		///<summary>
		/// Failure Log
		/// <para>Name: FailureLog</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "failureLog")]
		[Updateable(false), Createable(false)]
		public string FailureLog { get; set; }

		///<summary>
		/// Current Object
		/// <para>Name: CurrentObject</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "currentObject")]
		[Updateable(false), Createable(false)]
		public string CurrentObject { get; set; }

		///<summary>
		/// Privacy Policy Definition ID
		/// <para>Name: PrivacyPolicyDefinitionId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "privacyPolicyDefinitionId")]
		[Updateable(false), Createable(false)]
		public string PrivacyPolicyDefinitionId { get; set; }

		///<summary>
		/// ReferenceTo: PrivacyPolicyDefinition
		/// <para>RelationshipName: PrivacyPolicyDefinition</para>
		///</summary>
		[JsonProperty(PropertyName = "privacyPolicyDefinition")]
		[Updateable(false), Createable(false)]
		public SfPrivacyPolicyDefinition PrivacyPolicyDefinition { get; set; }

		///<summary>
		/// Scheduled Time
		/// <para>Name: ScheduledTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "scheduledTime")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? ScheduledTime { get; set; }

		///<summary>
		/// Job Start Type
		/// <para>Name: JobStartType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "jobStartType")]
		[Updateable(false), Createable(false)]
		public string JobStartType { get; set; }

		///<summary>
		/// TraversalComplete
		/// <para>Name: OptionsTraversalComplete</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsTraversalComplete")]
		[Updateable(false), Createable(false)]
		public bool? OptionsTraversalComplete { get; set; }

		///<summary>
		/// TraversalFailed
		/// <para>Name: OptionsTraversalFailed</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsTraversalFailed")]
		[Updateable(false), Createable(false)]
		public bool? OptionsTraversalFailed { get; set; }

		///<summary>
		/// ProcessingFailed
		/// <para>Name: OptionsProcessingFailed</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsProcessingFailed")]
		[Updateable(false), Createable(false)]
		public bool? OptionsProcessingFailed { get; set; }

		///<summary>
		/// Preview
		/// <para>Name: OptionsPreview</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsPreview")]
		[Updateable(false), Createable(false)]
		public bool? OptionsPreview { get; set; }

		///<summary>
		/// Acknowledged
		/// <para>Name: OptionsAcknowledged</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsAcknowledged")]
		[Updateable(false), Createable(false)]
		public bool? OptionsAcknowledged { get; set; }

		///<summary>
		/// ErrorBypassOccurred
		/// <para>Name: OptionsErrorBypassOccurred</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsErrorBypassOccurred")]
		[Updateable(false), Createable(false)]
		public bool? OptionsErrorBypassOccurred { get; set; }

		///<summary>
		/// Policy Name
		/// <para>Name: PolicyName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "policyName")]
		[Updateable(false), Createable(false)]
		public string PolicyName { get; set; }

		///<summary>
		/// Policy Description
		/// <para>Name: PolicyDescription</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "policyDescription")]
		[Updateable(false), Createable(false)]
		public string PolicyDescription { get; set; }

		///<summary>
		/// Policy Type
		/// <para>Name: PolicyType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "policyType")]
		[Updateable(false), Createable(false)]
		public string PolicyType { get; set; }

		///<summary>
		/// Privacy RTBF Request ID
		/// <para>Name: PrivacyRtbfRequestId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "privacyRtbfRequestId")]
		[Updateable(false), Createable(false)]
		public string PrivacyRtbfRequestId { get; set; }

		///<summary>
		/// ReferenceTo: PrivacyRTBFRequest
		/// <para>RelationshipName: PrivacyRtbfRequest</para>
		///</summary>
		[JsonProperty(PropertyName = "privacyRtbfRequest")]
		[Updateable(false), Createable(false)]
		public SfPrivacyRTBFRequest PrivacyRtbfRequest { get; set; }

		///<summary>
		/// Job Management Type
		/// <para>Name: JobManagementType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "jobManagementType")]
		[Updateable(false), Createable(false)]
		public string JobManagementType { get; set; }

		///<summary>
		/// Job Policy Name
		/// <para>Name: JobPolicyName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "jobPolicyName")]
		[Updateable(false), Createable(false)]
		public string JobPolicyName { get; set; }

		///<summary>
		/// Preview
		/// <para>Name: IsPreview</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isPreview")]
		[Updateable(false), Createable(false)]
		public bool? IsPreview { get; set; }

		///<summary>
		/// Permission Set
		/// <para>Name: PermissionSet</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionSet")]
		[Updateable(false), Createable(false)]
		public string PermissionSet { get; set; }

	}
}
