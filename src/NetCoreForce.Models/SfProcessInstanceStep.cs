// SF API version v41.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Process Instance Step
	///<para>SObject Name: ProcessInstanceStep</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfProcessInstanceStep : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ProcessInstanceStep"; }
		}

		///<summary>
		/// Process Instance Step ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

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
		/// Step Status
		/// <para>Name: StepStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "stepStatus")]
		[Updateable(false), Createable(false)]
		public string StepStatus { get; set; }

		///<summary>
		/// Original Actor ID
		/// <para>Name: OriginalActorId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "originalActorId")]
		[Updateable(false), Createable(false)]
		public string OriginalActorId { get; set; }

		///<summary>
		/// Actor ID
		/// <para>Name: ActorId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "actorId")]
		[Updateable(false), Createable(false)]
		public string ActorId { get; set; }

		///<summary>
		/// Comments
		/// <para>Name: Comments</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "comments")]
		[Updateable(false), Createable(false)]
		public string Comments { get; set; }

		///<summary>
		/// Process Node ID
		/// <para>Name: StepNodeId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "stepNodeId")]
		[Updateable(false), Createable(false)]
		public string StepNodeId { get; set; }

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
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

	}
}
