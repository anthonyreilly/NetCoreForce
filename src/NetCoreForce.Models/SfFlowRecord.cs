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
	/// Flow
	///<para>SObject Name: FlowRecord</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfFlowRecord : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "FlowRecord"; }
		}

		///<summary>
		/// Flow ID
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
		[Updateable(true), Createable(false)]
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
		/// Flow Label
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
		/// Flow Definition
		/// <para>Name: FlowDefinition</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "flowDefinition")]
		[Updateable(false), Createable(false)]
		public string FlowDefinition { get; set; }

		///<summary>
		/// Associated Record ID
		/// <para>Name: AssociatedRecordId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "associatedRecordId")]
		[Updateable(true), Createable(false)]
		public string AssociatedRecordId { get; set; }

		///<summary>
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		[Updateable(true), Createable(false)]
		public string Description { get; set; }

		///<summary>
		/// Type
		/// <para>Name: Type</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		[Updateable(false), Createable(false)]
		public string Type { get; set; }

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
		/// Scheduled Start Date
		/// <para>Name: ScheduledStartDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "scheduledStartDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? ScheduledStartDate { get; set; }

		///<summary>
		/// Error Code
		/// <para>Name: ErrorCode</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "errorCode")]
		[Updateable(false), Createable(false)]
		public string ErrorCode { get; set; }

		///<summary>
		/// Error Details
		/// <para>Name: ErrorDetails</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "errorDetails")]
		[Updateable(false), Createable(false)]
		public string ErrorDetails { get; set; }

		///<summary>
		/// Category
		/// <para>Name: FlowCategory</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "flowCategory")]
		[Updateable(true), Createable(false)]
		public string FlowCategory { get; set; }

		///<summary>
		/// Subcategory
		/// <para>Name: FlowSubcategory</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "flowSubcategory")]
		[Updateable(true), Createable(false)]
		public string FlowSubcategory { get; set; }

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
		/// Flow Type
		/// <para>Name: FlowType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "flowType")]
		[Updateable(false), Createable(false)]
		public string FlowType { get; set; }

		///<summary>
		/// Flow Namespace
		/// <para>Name: NamespacePrefix</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "namespacePrefix")]
		[Updateable(false), Createable(false)]
		public string NamespacePrefix { get; set; }

		///<summary>
		/// Package State
		/// <para>Name: ManageableState</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "manageableState")]
		[Updateable(false), Createable(false)]
		public string ManageableState { get; set; }

		///<summary>
		/// Flow Version ID
		/// <para>Name: ActiveVersionId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "activeVersionId")]
		[Updateable(false), Createable(false)]
		public string ActiveVersionId { get; set; }

		///<summary>
		/// ReferenceTo: FlowRecordVersion
		/// <para>RelationshipName: ActiveVersion</para>
		///</summary>
		[JsonProperty(PropertyName = "activeVersion")]
		[Updateable(false), Createable(false)]
		public SfFlowRecordVersion ActiveVersion { get; set; }

		///<summary>
		/// API Version
		/// <para>Name: ApiVersion</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "apiVersion")]
		[Updateable(false), Createable(false)]
		public int? ApiVersion { get; set; }

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
		/// Start Trigger
		/// <para>Name: StartSource</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "startSource")]
		[Updateable(false), Createable(false)]
		public string StartSource { get; set; }

		///<summary>
		/// Enabled for Non-Admins
		/// <para>Name: IsCitizenEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isCitizenEnabled")]
		[Updateable(false), Createable(false)]
		public bool? IsCitizenEnabled { get; set; }

		///<summary>
		/// Flow Label
		/// <para>Name: FlowLabel</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "flowLabel")]
		[Updateable(true), Createable(false)]
		public string FlowLabel { get; set; }

		///<summary>
		/// API Name
		/// <para>Name: ApiName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "apiName")]
		[Updateable(false), Createable(false)]
		public string ApiName { get; set; }

		///<summary>
		/// Package Name
		/// <para>Name: InstalledPackageName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "installedPackageName")]
		[Updateable(false), Createable(false)]
		public string InstalledPackageName { get; set; }

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
