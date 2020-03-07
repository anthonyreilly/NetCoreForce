// SF API version v41.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Background Operation
	///<para>SObject Name: BackgroundOperation</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfBackgroundOperation : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "BackgroundOperation"; }
		}

		///<summary>
		/// Background Operation ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Creatable(false)]
		public bool? IsDeleted { get; set; }

		///<summary>
		/// Background Operation Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Creatable(false)]
		public string Name { get; set; }

		///<summary>
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

		///<summary>
		/// Created By ID
		/// <para>Name: CreatedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdById")]
		[Updateable(false), Creatable(false)]
		public string CreatedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: CreatedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "createdBy")]
		[Updateable(false), Creatable(false)]
		public SfUser CreatedBy { get; set; }

		///<summary>
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

		///<summary>
		/// Last Modified By ID
		/// <para>Name: LastModifiedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedById")]
		[Updateable(false), Creatable(false)]
		public string LastModifiedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: LastModifiedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedBy")]
		[Updateable(false), Creatable(false)]
		public SfUser LastModifiedBy { get; set; }

		///<summary>
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

		///<summary>
		/// Submitted
		/// <para>Name: SubmittedAt</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "submittedAt")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? SubmittedAt { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		[Updateable(false), Creatable(false)]
		public string Status { get; set; }

		///<summary>
		/// Execution Group
		/// <para>Name: ExecutionGroup</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "executionGroup")]
		[Updateable(false), Creatable(false)]
		public string ExecutionGroup { get; set; }

		///<summary>
		/// Sequence Group
		/// <para>Name: SequenceGroup</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sequenceGroup")]
		[Updateable(false), Creatable(false)]
		public string SequenceGroup { get; set; }

		///<summary>
		/// Sequence Number
		/// <para>Name: SequenceNumber</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sequenceNumber")]
		[Updateable(false), Creatable(false)]
		public int? SequenceNumber { get; set; }

		///<summary>
		/// Background Operation ID
		/// <para>Name: GroupLeaderId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "groupLeaderId")]
		[Updateable(false), Creatable(false)]
		public string GroupLeaderId { get; set; }

		///<summary>
		/// ReferenceTo: BackgroundOperation
		/// <para>RelationshipName: GroupLeader</para>
		///</summary>
		[JsonProperty(PropertyName = "groupLeader")]
		[Updateable(false), Creatable(false)]
		public SfBackgroundOperation GroupLeader { get; set; }

		///<summary>
		/// Started
		/// <para>Name: StartedAt</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "startedAt")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? StartedAt { get; set; }

		///<summary>
		/// Finished
		/// <para>Name: FinishedAt</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "finishedAt")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? FinishedAt { get; set; }

		///<summary>
		/// Worker URI
		/// <para>Name: WorkerUri</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "workerUri")]
		[Updateable(false), Creatable(false)]
		public string WorkerUri { get; set; }

		///<summary>
		/// Timeout
		/// <para>Name: Timeout</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "timeout")]
		[Updateable(false), Creatable(false)]
		public int? Timeout { get; set; }

		///<summary>
		/// ExpiresAt
		/// <para>Name: ExpiresAt</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "expiresAt")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? ExpiresAt { get; set; }

		///<summary>
		/// NumFollowers
		/// <para>Name: NumFollowers</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "numFollowers")]
		[Updateable(false), Creatable(false)]
		public int? NumFollowers { get; set; }

		///<summary>
		/// ProcessAfter
		/// <para>Name: ProcessAfter</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "processAfter")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? ProcessAfter { get; set; }

		///<summary>
		/// ParentKey
		/// <para>Name: ParentKey</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "parentKey")]
		[Updateable(false), Creatable(false)]
		public string ParentKey { get; set; }

		///<summary>
		/// RetryLimit
		/// <para>Name: RetryLimit</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "retryLimit")]
		[Updateable(false), Creatable(false)]
		public int? RetryLimit { get; set; }

		///<summary>
		/// RetryCount
		/// <para>Name: RetryCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "retryCount")]
		[Updateable(false), Creatable(false)]
		public int? RetryCount { get; set; }

		///<summary>
		/// RetryBackoff
		/// <para>Name: RetryBackoff</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "retryBackoff")]
		[Updateable(false), Creatable(false)]
		public int? RetryBackoff { get; set; }

		///<summary>
		/// Error
		/// <para>Name: Error</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "error")]
		[Updateable(false), Creatable(false)]
		public string Error { get; set; }

	}
}
