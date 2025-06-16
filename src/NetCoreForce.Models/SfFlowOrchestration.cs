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
	/// Orchestration
	///<para>SObject Name: FlowOrchestration</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfFlowOrchestration : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "FlowOrchestration"; }
		}

		///<summary>
		/// Orchestration ID
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
		/// Orchestration Label
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(true), Createable(false)]
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
		/// Orchestration Definition
		/// <para>Name: OrchestrationDefinition</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "orchestrationDefinition")]
		[Updateable(false), Createable(false)]
		public string OrchestrationDefinition { get; set; }

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
		/// Trigger Type
		/// <para>Name: TriggerType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "triggerType")]
		[Updateable(false), Createable(false)]
		public string TriggerType { get; set; }

		///<summary>
		/// Orchestration Type
		/// <para>Name: OrchestrationType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "orchestrationType")]
		[Updateable(false), Createable(false)]
		public string OrchestrationType { get; set; }

		///<summary>
		/// Orchestration Namespace
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
		/// Orchestration Version ID
		/// <para>Name: ActiveVersionId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "activeVersionId")]
		[Updateable(false), Createable(false)]
		public string ActiveVersionId { get; set; }

		///<summary>
		/// ReferenceTo: FlowOrchestrationVersion
		/// <para>RelationshipName: ActiveVersion</para>
		///</summary>
		[JsonProperty(PropertyName = "activeVersion")]
		[Updateable(false), Createable(false)]
		public SfFlowOrchestrationVersion ActiveVersion { get; set; }

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
		/// Citizen Enabled
		/// <para>Name: IsCitizenEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isCitizenEnabled")]
		[Updateable(false), Createable(false)]
		public bool? IsCitizenEnabled { get; set; }

		///<summary>
		/// Orchestration Label
		/// <para>Name: OrchestrationLabel</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "orchestrationLabel")]
		[Updateable(true), Createable(false)]
		public string OrchestrationLabel { get; set; }

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
		/// Run Count
		/// <para>Name: RunCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "runCount")]
		[Updateable(false), Createable(false)]
		public int? RunCount { get; set; }

		///<summary>
		/// Completion Rate
		/// <para>Name: CompletionRate</para>
		/// <para>SF Type: percent</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "completionRate")]
		[Updateable(false), Createable(false)]
		public double? CompletionRate { get; set; }

		///<summary>
		/// Average Run Time
		/// <para>Name: AverageRunTime</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "averageRunTime")]
		[Updateable(false), Createable(false)]
		public int? AverageRunTime { get; set; }

		///<summary>
		/// Failed Run Count
		/// <para>Name: FailedRunCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "failedRunCount")]
		[Updateable(false), Createable(false)]
		public int? FailedRunCount { get; set; }

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
		/// Orchestration ID
		/// <para>Name: SourceTemplateId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sourceTemplateId")]
		[Updateable(false), Createable(false)]
		public string SourceTemplateId { get; set; }

		///<summary>
		/// ReferenceTo: FlowOrchestration
		/// <para>RelationshipName: SourceTemplate</para>
		///</summary>
		[JsonProperty(PropertyName = "sourceTemplate")]
		[Updateable(false), Createable(false)]
		public SfFlowOrchestration SourceTemplate { get; set; }

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
		/// Orchestration ID
		/// <para>Name: OverriddenById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "overriddenById")]
		[Updateable(false), Createable(false)]
		public string OverriddenById { get; set; }

		///<summary>
		/// ReferenceTo: FlowOrchestration
		/// <para>RelationshipName: OverriddenBy</para>
		///</summary>
		[JsonProperty(PropertyName = "overriddenBy")]
		[Updateable(false), Createable(false)]
		public SfFlowOrchestration OverriddenBy { get; set; }

		///<summary>
		/// Orchestration ID
		/// <para>Name: OverriddenOrchestrationId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "overriddenOrchestrationId")]
		[Updateable(false), Createable(false)]
		public string OverriddenOrchestrationId { get; set; }

		///<summary>
		/// ReferenceTo: FlowOrchestration
		/// <para>RelationshipName: OverriddenOrchestration</para>
		///</summary>
		[JsonProperty(PropertyName = "overriddenOrchestration")]
		[Updateable(false), Createable(false)]
		public SfFlowOrchestration OverriddenOrchestration { get; set; }

	}
}
