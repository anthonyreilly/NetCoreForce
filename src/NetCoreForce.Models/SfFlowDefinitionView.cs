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
	/// Flow Definition
	///<para>SObject Name: FlowDefinitionView</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfFlowDefinitionView : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "FlowDefinitionView"; }
		}

		///<summary>
		/// Flow Definition View ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Durable ID
		/// <para>Name: DurableId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "durableId")]
		[Updateable(false), Createable(false)]
		public string DurableId { get; set; }

		///<summary>
		/// Flow API Name
		/// <para>Name: ApiName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "apiName")]
		[Updateable(false), Createable(false)]
		public string ApiName { get; set; }

		///<summary>
		/// Flow Label
		/// <para>Name: Label</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "label")]
		[Updateable(false), Createable(false)]
		public string Label { get; set; }

		///<summary>
		/// Flow Description
		/// <para>Name: Description</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		[Updateable(false), Createable(false)]
		public string Description { get; set; }

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
		/// Trigger
		/// <para>Name: TriggerType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "triggerType")]
		[Updateable(false), Createable(false)]
		public string TriggerType { get; set; }

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
		/// Active Flow Version API Name or ID
		/// <para>Name: ActiveVersionId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "activeVersionId")]
		[Updateable(false), Createable(false)]
		public string ActiveVersionId { get; set; }

		///<summary>
		/// Latest Flow Version API Name or ID
		/// <para>Name: LatestVersionId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "latestVersionId")]
		[Updateable(false), Createable(false)]
		public string LatestVersionId { get; set; }

		///<summary>
		/// Last Modified By
		/// <para>Name: LastModifiedBy</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedBy")]
		[Updateable(false), Createable(false)]
		public string LastModifiedBy { get; set; }

		///<summary>
		/// Active
		/// <para>Name: IsActive</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isActive")]
		[Updateable(false), Createable(false)]
		public bool? IsActive { get; set; }

		///<summary>
		/// Is Using an Older Version
		/// <para>Name: IsOutOfDate</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isOutOfDate")]
		[Updateable(false), Createable(false)]
		public bool? IsOutOfDate { get; set; }

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
		/// Template
		/// <para>Name: IsTemplate</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isTemplate")]
		[Updateable(false), Createable(false)]
		public bool? IsTemplate { get; set; }

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
		/// Flow Definition View ID
		/// <para>Name: OverriddenById</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "overriddenById")]
		[Updateable(false), Createable(false)]
		public string OverriddenById { get; set; }

		///<summary>
		/// Flow Definition View ID
		/// <para>Name: SourceTemplateId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sourceTemplateId")]
		[Updateable(false), Createable(false)]
		public string SourceTemplateId { get; set; }

		///<summary>
		/// Flow Definition View ID
		/// <para>Name: OverriddenFlowId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "overriddenFlowId")]
		[Updateable(false), Createable(false)]
		public string OverriddenFlowId { get; set; }

		///<summary>
		/// Is Swing Flow
		/// <para>Name: IsSwingFlow</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isSwingFlow")]
		[Updateable(false), Createable(false)]
		public bool? IsSwingFlow { get; set; }

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
		/// Package State
		/// <para>Name: ManageableState</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "manageableState")]
		[Updateable(false), Createable(false)]
		public string ManageableState { get; set; }

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
		/// Triggering Object or Platform Event Label
		/// <para>Name: TriggerObjectOrEventLabel</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "triggerObjectOrEventLabel")]
		[Updateable(false), Createable(false)]
		public string TriggerObjectOrEventLabel { get; set; }

		///<summary>
		/// Entity Definition ID
		/// <para>Name: TriggerObjectOrEventId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "triggerObjectOrEventId")]
		[Updateable(false), Createable(false)]
		public string TriggerObjectOrEventId { get; set; }

		///<summary>
		/// Record Trigger Type
		/// <para>Name: RecordTriggerType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recordTriggerType")]
		[Updateable(false), Createable(false)]
		public string RecordTriggerType { get; set; }

		///<summary>
		/// Has Asynchronous After Commit Path
		/// <para>Name: HasAsyncAfterCommitPath</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasAsyncAfterCommitPath")]
		[Updateable(false), Createable(false)]
		public bool? HasAsyncAfterCommitPath { get; set; }

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
		/// Trigger Order
		/// <para>Name: TriggerOrder</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "triggerOrder")]
		[Updateable(false), Createable(false)]
		public int? TriggerOrder { get; set; }

		///<summary>
		/// Environments
		/// <para>Name: Environments</para>
		/// <para>SF Type: multipicklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "environments")]
		[Updateable(false), Createable(false)]
		public string Environments { get; set; }

		///<summary>
		/// Api Version
		/// <para>Name: ApiVersion</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "apiVersion")]
		[Updateable(false), Createable(false)]
		public int? ApiVersion { get; set; }

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

		///<summary>
		/// Supported Environments
		/// <para>Name: SupportedEnvironments</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "supportedEnvironments")]
		[Updateable(false), Createable(false)]
		public string SupportedEnvironments { get; set; }

	}
}
