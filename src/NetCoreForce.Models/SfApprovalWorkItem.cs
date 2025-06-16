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
	/// Approval Work Item
	///<para>SObject Name: ApprovalWorkItem</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfApprovalWorkItem : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ApprovalWorkItem"; }
		}

		///<summary>
		/// Approval Work Item ID
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
		/// Approval Work Item Name
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
		/// Approval Submission ID
		/// <para>Name: ApprovalSubmissionId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "approvalSubmissionId")]
		[Updateable(false), Createable(false)]
		public string ApprovalSubmissionId { get; set; }

		///<summary>
		/// ReferenceTo: ApprovalSubmission
		/// <para>RelationshipName: ApprovalSubmission</para>
		///</summary>
		[JsonProperty(PropertyName = "approvalSubmission")]
		[Updateable(false), Createable(false)]
		public SfApprovalSubmission ApprovalSubmission { get; set; }

		///<summary>
		/// Related Record ID
		/// <para>Name: RelatedRecordId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relatedRecordId")]
		[Updateable(false), Createable(false)]
		public string RelatedRecordId { get; set; }

		///<summary>
		/// Orchestration Work Item ID
		/// <para>Name: FlowOrchestrationWorkItemId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "flowOrchestrationWorkItemId")]
		[Updateable(false), Createable(false)]
		public string FlowOrchestrationWorkItemId { get; set; }

		///<summary>
		/// ReferenceTo: FlowOrchestrationWorkItem
		/// <para>RelationshipName: FlowOrchestrationWorkItem</para>
		///</summary>
		[JsonProperty(PropertyName = "flowOrchestrationWorkItem")]
		[Updateable(false), Createable(false)]
		public SfFlowOrchestrationWorkItem FlowOrchestrationWorkItem { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		[Updateable(false), Createable(false)]
		public string Status { get; set; }

		///<summary>
		/// Assigned To ID
		/// <para>Name: AssignedToId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "assignedToId")]
		[Updateable(false), Createable(false)]
		public string AssignedToId { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: ReviewedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "reviewedById")]
		[Updateable(false), Createable(false)]
		public string ReviewedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: ReviewedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "reviewedBy")]
		[Updateable(false), Createable(false)]
		public SfUser ReviewedBy { get; set; }

		///<summary>
		/// Comments
		/// <para>Name: Comments</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "comments")]
		[Updateable(false), Createable(false)]
		public string Comments { get; set; }

		///<summary>
		/// Related Record Object Name
		/// <para>Name: RelatedRecordObjectName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relatedRecordObjectName")]
		[Updateable(false), Createable(false)]
		public string RelatedRecordObjectName { get; set; }

		///<summary>
		/// Approval Condition Name
		/// <para>Name: ApprovalConditionName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "approvalConditionName")]
		[Updateable(false), Createable(false)]
		public string ApprovalConditionName { get; set; }

		///<summary>
		/// Reviewed Date
		/// <para>Name: ReviewedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "reviewedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? ReviewedDate { get; set; }

	}
}
