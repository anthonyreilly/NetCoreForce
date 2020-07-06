// SF API version v48.0
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

	}
}
