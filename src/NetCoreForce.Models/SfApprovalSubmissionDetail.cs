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
	/// Approval Submission Detail
	///<para>SObject Name: ApprovalSubmissionDetail</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfApprovalSubmissionDetail : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ApprovalSubmissionDetail"; }
		}

		///<summary>
		/// Approval Submission Detail ID
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
		/// Approval Submission Detail Name
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
		/// Approval Work Item ID
		/// <para>Name: ApprovalWorkItemId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "approvalWorkItemId")]
		[Updateable(false), Createable(false)]
		public string ApprovalWorkItemId { get; set; }

		///<summary>
		/// ReferenceTo: ApprovalWorkItem
		/// <para>RelationshipName: ApprovalWorkItem</para>
		///</summary>
		[JsonProperty(PropertyName = "approvalWorkItem")]
		[Updateable(false), Createable(false)]
		public SfApprovalWorkItem ApprovalWorkItem { get; set; }

		///<summary>
		/// Action Name
		/// <para>Name: ActionName</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "actionName")]
		[Updateable(false), Createable(false)]
		public string ActionName { get; set; }

		///<summary>
		/// Action Context
		/// <para>Name: ActionContext</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "actionContext")]
		[Updateable(false), Createable(false)]
		public string ActionContext { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: ActionPerformedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "actionPerformedById")]
		[Updateable(false), Createable(false)]
		public string ActionPerformedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: ActionPerformedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "actionPerformedBy")]
		[Updateable(false), Createable(false)]
		public SfUser ActionPerformedBy { get; set; }

		///<summary>
		/// Action Performer Role
		/// <para>Name: ActionPerformerRole</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "actionPerformerRole")]
		[Updateable(false), Createable(false)]
		public string ActionPerformerRole { get; set; }

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
		/// Action Channel Name
		/// <para>Name: ActionChannelName</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "actionChannelName")]
		[Updateable(false), Createable(false)]
		public string ActionChannelName { get; set; }

	}
}
