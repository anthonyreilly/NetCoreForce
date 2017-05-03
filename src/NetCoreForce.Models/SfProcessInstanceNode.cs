// SF API version v39.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Process Instance Node
	///<para>SObject Name: ProcessInstanceNode</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfProcessInstanceNode : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ProcessInstanceNode"; }
		}

		///<summary>
		/// Process Instance Node ID
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
		/// Process Instance ID
		/// <para>Name: ProcessInstanceId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "processInstanceId")]
		[Updateable(false), Createable(false)]
		public string ProcessInstanceId { get; set; }

		///<summary>
		/// ReferenceTo: ProcessInstance
		/// <para>RelationshipName: ProcessInstance</para>
		///</summary>
		[JsonProperty(PropertyName = "processInstance")]
		[Updateable(false), Createable(false)]
		public SfProcessInstance ProcessInstance { get; set; }

		///<summary>
		/// Process Node ID
		/// <para>Name: ProcessNodeId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "processNodeId")]
		[Updateable(false), Createable(false)]
		public string ProcessNodeId { get; set; }

		///<summary>
		/// ReferenceTo: ProcessNode
		/// <para>RelationshipName: ProcessNode</para>
		///</summary>
		[JsonProperty(PropertyName = "processNode")]
		[Updateable(false), Createable(false)]
		public SfProcessNode ProcessNode { get; set; }

		///<summary>
		/// Node Status
		/// <para>Name: NodeStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "nodeStatus")]
		[Updateable(false), Createable(false)]
		public string NodeStatus { get; set; }

		///<summary>
		/// Completed Date
		/// <para>Name: CompletedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "completedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? CompletedDate { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: LastActorId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastActorId")]
		[Updateable(false), Createable(false)]
		public string LastActorId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: LastActor</para>
		///</summary>
		[JsonProperty(PropertyName = "lastActor")]
		[Updateable(false), Createable(false)]
		public SfUser LastActor { get; set; }

		///<summary>
		/// Name
		/// <para>Name: ProcessNodeName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "processNodeName")]
		[Updateable(false), Createable(false)]
		public string ProcessNodeName { get; set; }

		///<summary>
		/// Elapsed Time in Days
		/// <para>Name: ElapsedTimeInDays</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "elapsedTimeInDays")]
		[Updateable(false), Createable(false)]
		public double? ElapsedTimeInDays { get; set; }

		///<summary>
		/// Elapsed Time in Hours
		/// <para>Name: ElapsedTimeInHours</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "elapsedTimeInHours")]
		[Updateable(false), Createable(false)]
		public double? ElapsedTimeInHours { get; set; }

		///<summary>
		/// Elapsed Time in Minutes
		/// <para>Name: ElapsedTimeInMinutes</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "elapsedTimeInMinutes")]
		[Updateable(false), Createable(false)]
		public double? ElapsedTimeInMinutes { get; set; }

	}
}
