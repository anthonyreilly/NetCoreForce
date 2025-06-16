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
	/// Orchestration Run Log
	///<para>SObject Name: FlowOrchestrationLog</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfFlowOrchestrationLog : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "FlowOrchestrationLog"; }
		}

		///<summary>
		/// Orchestration Run Log ID
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
		/// Orchestration Name
		/// <para>Name: OrchestrationName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "orchestrationName")]
		[Updateable(false), Createable(false)]
		public string OrchestrationName { get; set; }

		///<summary>
		/// Orchestration Version
		/// <para>Name: OrchestrationVersion</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "orchestrationVersion")]
		[Updateable(false), Createable(false)]
		public int? OrchestrationVersion { get; set; }

		///<summary>
		/// Orchestration Run ID
		/// <para>Name: OrchestrationInstanceId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "orchestrationInstanceId")]
		[Updateable(false), Createable(false)]
		public string OrchestrationInstanceId { get; set; }

		///<summary>
		/// ReferenceTo: FlowOrchestrationInstance
		/// <para>RelationshipName: OrchestrationInstance</para>
		///</summary>
		[JsonProperty(PropertyName = "orchestrationInstance")]
		[Updateable(false), Createable(false)]
		public SfFlowOrchestrationInstance OrchestrationInstance { get; set; }

		///<summary>
		/// Stage
		/// <para>Name: StageName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "stageName")]
		[Updateable(false), Createable(false)]
		public string StageName { get; set; }

		///<summary>
		/// Step
		/// <para>Name: StepName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "stepName")]
		[Updateable(false), Createable(false)]
		public string StepName { get; set; }

		///<summary>
		/// Completed By
		/// <para>Name: Actor</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "actor")]
		[Updateable(false), Createable(false)]
		public string Actor { get; set; }

		///<summary>
		/// Milestone
		/// <para>Name: Kind</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "kind")]
		[Updateable(false), Createable(false)]
		public string Kind { get; set; }

		///<summary>
		/// Timestamp
		/// <para>Name: Timestamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "timestamp")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? Timestamp { get; set; }

		///<summary>
		/// Duration (seconds)
		/// <para>Name: Duration</para>
		/// <para>SF Type: long</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "duration")]
		[Updateable(false), Createable(false)]
		public string Duration { get; set; }

		///<summary>
		/// Context Record
		/// <para>Name: Context</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "context")]
		[Updateable(false), Createable(false)]
		public string Context { get; set; }

		///<summary>
		/// Assignment Type
		/// <para>Name: AssigneeType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "assigneeType")]
		[Updateable(false), Createable(false)]
		public string AssigneeType { get; set; }

		///<summary>
		/// Assigned To
		/// <para>Name: Assignee</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "assignee")]
		[Updateable(false), Createable(false)]
		public string Assignee { get; set; }

		///<summary>
		/// Comments
		/// <para>Name: Comments</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "comments")]
		[Updateable(false), Createable(false)]
		public string Comments { get; set; }

	}
}
