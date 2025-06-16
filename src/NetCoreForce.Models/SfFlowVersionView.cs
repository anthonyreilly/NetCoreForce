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
	///<para>SObject Name: FlowVersionView</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfFlowVersionView : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "FlowVersionView"; }
		}

		///<summary>
		/// Flow Version View ID
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
		/// Flow Definition View ID
		/// <para>Name: FlowDefinitionViewId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "flowDefinitionViewId")]
		[Updateable(false), Createable(false)]
		public string FlowDefinitionViewId { get; set; }

		///<summary>
		/// Version Label
		/// <para>Name: Label</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "label")]
		[Updateable(false), Createable(false)]
		public string Label { get; set; }

		///<summary>
		/// Version Description
		/// <para>Name: Description</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		[Updateable(false), Createable(false)]
		public string Description { get; set; }

		///<summary>
		/// Version Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		[Updateable(false), Createable(false)]
		public string Status { get; set; }

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
		/// Process Type
		/// <para>Name: ProcessType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "processType")]
		[Updateable(false), Createable(false)]
		public string ProcessType { get; set; }

		///<summary>
		/// Is Template
		/// <para>Name: IsTemplate</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isTemplate")]
		[Updateable(false), Createable(false)]
		public bool? IsTemplate { get; set; }

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
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

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
		/// Api Version
		/// <para>Name: ApiVersion</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "apiVersion")]
		[Updateable(false), Createable(false)]
		public double? ApiVersion { get; set; }

		///<summary>
		/// Api Version Runtime
		/// <para>Name: ApiVersionRuntime</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "apiVersionRuntime")]
		[Updateable(false), Createable(false)]
		public double? ApiVersionRuntime { get; set; }

		///<summary>
		/// Capability Type
		/// <para>Name: CapabilityType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "capabilityType")]
		[Updateable(false), Createable(false)]
		public string CapabilityType { get; set; }

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
