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
	/// Flow Version
	///<para>SObject Name: FlowRecordVersion</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfFlowRecordVersion : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "FlowRecordVersion"; }
		}

		///<summary>
		/// Flow Version ID
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
		/// Flow Version Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
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
		/// Last Viewed Date
		/// <para>Name: LastViewedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastViewedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastViewedDate { get; set; }

		///<summary>
		/// Last Referenced Date
		/// <para>Name: LastReferencedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastReferencedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastReferencedDate { get; set; }

		///<summary>
		/// Flow ID
		/// <para>Name: FlowRecordId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "flowRecordId")]
		[Updateable(false), Createable(false)]
		public string FlowRecordId { get; set; }

		///<summary>
		/// ReferenceTo: FlowRecord
		/// <para>RelationshipName: FlowRecord</para>
		///</summary>
		[JsonProperty(PropertyName = "flowRecord")]
		[Updateable(false), Createable(false)]
		public SfFlowRecord FlowRecord { get; set; }

		///<summary>
		/// Version Number
		/// <para>Name: VersionNumber</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "versionNumber")]
		[Updateable(false), Createable(false)]
		public int? VersionNumber { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: ActivatedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "activatedById")]
		[Updateable(false), Createable(false)]
		public string ActivatedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: ActivatedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "activatedBy")]
		[Updateable(false), Createable(false)]
		public SfUser ActivatedBy { get; set; }

		///<summary>
		/// Activated Date
		/// <para>Name: ActivatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "activatedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? ActivatedDate { get; set; }

		///<summary>
		/// Progress Status
		/// <para>Name: ProgressStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "progressStatus")]
		[Updateable(false), Createable(false)]
		public string ProgressStatus { get; set; }

		///<summary>
		/// Paused
		/// <para>Name: IsPaused</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isPaused")]
		[Updateable(false), Createable(false)]
		public bool? IsPaused { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: PausingUserId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "pausingUserId")]
		[Updateable(false), Createable(false)]
		public string PausingUserId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: PausingUser</para>
		///</summary>
		[JsonProperty(PropertyName = "pausingUser")]
		[Updateable(false), Createable(false)]
		public SfUser PausingUser { get; set; }

		///<summary>
		/// Paused Date
		/// <para>Name: PausedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "pausedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? PausedDate { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: ResumingUserId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "resumingUserId")]
		[Updateable(false), Createable(false)]
		public string ResumingUserId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: ResumingUser</para>
		///</summary>
		[JsonProperty(PropertyName = "resumingUser")]
		[Updateable(false), Createable(false)]
		public SfUser ResumingUser { get; set; }

		///<summary>
		/// Resumed Date
		/// <para>Name: ResumedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "resumedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? ResumedDate { get; set; }

		///<summary>
		/// Reason Paused
		/// <para>Name: ReasonPaused</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "reasonPaused")]
		[Updateable(false), Createable(false)]
		public string ReasonPaused { get; set; }

		///<summary>
		/// Scheduled Start Date
		/// <para>Name: ScheduledStartDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "scheduledStartDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? ScheduledStartDate { get; set; }

		///<summary>
		/// Flow Type
		/// <para>Name: FlowType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "flowType")]
		[Updateable(false), Createable(false)]
		public string FlowType { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		[Updateable(false), Createable(false)]
		public string Status { get; set; }

		///<summary>
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		[Updateable(false), Createable(false)]
		public string Description { get; set; }

		///<summary>
		/// Run in Mode
		/// <para>Name: RunInMode</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "runInMode")]
		[Updateable(false), Createable(false)]
		public string RunInMode { get; set; }

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
		/// Template
		/// <para>Name: IsTemplate</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isTemplate")]
		[Updateable(false), Createable(false)]
		public bool? IsTemplate { get; set; }

		///<summary>
		/// Triggering Object or Platform Event Label
		/// <para>Name: TriggerObjectOrEventLabel</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "triggerObjectOrEventLabel")]
		[Updateable(false), Createable(false)]
		public string TriggerObjectOrEventLabel { get; set; }

		///<summary>
		/// Built with
		/// <para>Name: Builder</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "builder")]
		[Updateable(false), Createable(false)]
		public string Builder { get; set; }

		///<summary>
		/// Flow ID
		/// <para>Name: SourceTemplateId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sourceTemplateId")]
		[Updateable(false), Createable(false)]
		public string SourceTemplateId { get; set; }

		///<summary>
		/// ReferenceTo: FlowRecord
		/// <para>RelationshipName: SourceTemplate</para>
		///</summary>
		[JsonProperty(PropertyName = "sourceTemplate")]
		[Updateable(false), Createable(false)]
		public SfFlowRecord SourceTemplate { get; set; }

		///<summary>
		/// Overridable
		/// <para>Name: IsOverridable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isOverridable")]
		[Updateable(false), Createable(false)]
		public bool? IsOverridable { get; set; }

		///<summary>
		/// Flow ID
		/// <para>Name: OverriddenById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "overriddenById")]
		[Updateable(false), Createable(false)]
		public string OverriddenById { get; set; }

		///<summary>
		/// ReferenceTo: FlowRecord
		/// <para>RelationshipName: OverriddenBy</para>
		///</summary>
		[JsonProperty(PropertyName = "overriddenBy")]
		[Updateable(false), Createable(false)]
		public SfFlowRecord OverriddenBy { get; set; }

		///<summary>
		/// Flow ID
		/// <para>Name: OverriddenFlowId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "overriddenFlowId")]
		[Updateable(false), Createable(false)]
		public string OverriddenFlowId { get; set; }

		///<summary>
		/// ReferenceTo: FlowRecord
		/// <para>RelationshipName: OverriddenFlow</para>
		///</summary>
		[JsonProperty(PropertyName = "overriddenFlow")]
		[Updateable(false), Createable(false)]
		public SfFlowRecord OverriddenFlow { get; set; }

		///<summary>
		/// Capacity Category
		/// <para>Name: CapacityCategory</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "capacityCategory")]
		[Updateable(false), Createable(false)]
		public string CapacityCategory { get; set; }

		///<summary>
		/// Log Metrics to Data Cloud
		/// <para>Name: AreMetricsLoggedToDataCloud</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "areMetricsLoggedToDataCloud")]
		[Updateable(false), Createable(false)]
		public bool? AreMetricsLoggedToDataCloud { get; set; }

	}
}
