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
	/// Privacy Object Session
	///<para>SObject Name: PrivacyObjectSession</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfPrivacyObjectSession : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "PrivacyObjectSession"; }
		}

		///<summary>
		/// Privacy Object Session ID
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
		/// Privacy Job Session ID
		/// <para>Name: PrivacyJobSessionObjectId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "privacyJobSessionObjectId")]
		[Updateable(false), Createable(false)]
		public string PrivacyJobSessionObjectId { get; set; }

		///<summary>
		/// ReferenceTo: PrivacyJobSession
		/// <para>RelationshipName: PrivacyJobSessionObject</para>
		///</summary>
		[JsonProperty(PropertyName = "privacyJobSessionObject")]
		[Updateable(false), Createable(false)]
		public SfPrivacyJobSession PrivacyJobSessionObject { get; set; }

		///<summary>
		/// Policy Node
		/// <para>Name: PolicyNode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "policyNode")]
		[Updateable(false), Createable(false)]
		public string PolicyNode { get; set; }

		///<summary>
		/// Current Entity
		/// <para>Name: CurrentEntity</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "currentEntity")]
		[Updateable(false), Createable(false)]
		public string CurrentEntity { get; set; }

		///<summary>
		/// Object Status
		/// <para>Name: ObjectStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "objectStatus")]
		[Updateable(false), Createable(false)]
		public string ObjectStatus { get; set; }

		///<summary>
		/// Traversal Start Time
		/// <para>Name: TraversalStartTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "traversalStartTime")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? TraversalStartTime { get; set; }

		///<summary>
		/// Traversal End Time
		/// <para>Name: TraversalEndTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "traversalEndTime")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? TraversalEndTime { get; set; }

		///<summary>
		/// Object Failure Log
		/// <para>Name: ObjectFailureLog</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "objectFailureLog")]
		[Updateable(false), Createable(false)]
		public string ObjectFailureLog { get; set; }

		///<summary>
		/// Processed Successes
		/// <para>Name: ProcessedSuccesses</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "processedSuccesses")]
		[Updateable(false), Createable(false)]
		public int? ProcessedSuccesses { get; set; }

		///<summary>
		/// Processed Failures
		/// <para>Name: ProcessedFailures</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "processedFailures")]
		[Updateable(false), Createable(false)]
		public int? ProcessedFailures { get; set; }

		///<summary>
		/// Processed Total
		/// <para>Name: ProcessedTotal</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "processedTotal")]
		[Updateable(false), Createable(false)]
		public int? ProcessedTotal { get; set; }

		///<summary>
		/// Records Affected
		/// <para>Name: RecordsAffected</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recordsAffected")]
		[Updateable(false), Createable(false)]
		public int? RecordsAffected { get; set; }

		///<summary>
		/// Queue
		/// <para>Name: Queue</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "queue")]
		[Updateable(false), Createable(false)]
		public string Queue { get; set; }

		///<summary>
		/// Queue Length
		/// <para>Name: QueueLength</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "queueLength")]
		[Updateable(false), Createable(false)]
		public int? QueueLength { get; set; }

		///<summary>
		/// Process Type
		/// <para>Name: ProcessType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "processType")]
		[Updateable(false), Createable(false)]
		public string ProcessType { get; set; }

		///<summary>
		/// Processor
		/// <para>Name: Processor</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "processor")]
		[Updateable(false), Createable(false)]
		public string Processor { get; set; }

		///<summary>
		/// Retry
		/// <para>Name: Retry</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "retry")]
		[Updateable(false), Createable(false)]
		public int? Retry { get; set; }

		///<summary>
		/// Position
		/// <para>Name: Position</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "position")]
		[Updateable(false), Createable(false)]
		public int? Position { get; set; }

		///<summary>
		/// Unique Constraint
		/// <para>Name: UniqueConstraint</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "uniqueConstraint")]
		[Updateable(false), Createable(false)]
		public string UniqueConstraint { get; set; }

	}
}
