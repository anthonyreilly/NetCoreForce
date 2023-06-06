// SF API version v57.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Apex Job
	///<para>SObject Name: AsyncApexJob</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfAsyncApexJob : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "AsyncApexJob"; }
		}

		///<summary>
		/// Apex Job ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

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
		/// Job Type
		/// <para>Name: JobType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "jobType")]
		[Updateable(false), Createable(false)]
		public string JobType { get; set; }

		///<summary>
		/// Class ID
		/// <para>Name: ApexClassId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "apexClassId")]
		[Updateable(false), Createable(false)]
		public string ApexClassId { get; set; }

		///<summary>
		/// ReferenceTo: ApexClass
		/// <para>RelationshipName: ApexClass</para>
		///</summary>
		[JsonProperty(PropertyName = "apexClass")]
		[Updateable(false), Createable(false)]
		public SfApexClass ApexClass { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		[Updateable(false), Createable(false)]
		public string Status { get; set; }

		///<summary>
		/// Batches Processed
		/// <para>Name: JobItemsProcessed</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "jobItemsProcessed")]
		[Updateable(false), Createable(false)]
		public int? JobItemsProcessed { get; set; }

		///<summary>
		/// Total Batches
		/// <para>Name: TotalJobItems</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalJobItems")]
		[Updateable(false), Createable(false)]
		public int? TotalJobItems { get; set; }

		///<summary>
		/// Failures
		/// <para>Name: NumberOfErrors</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "numberOfErrors")]
		[Updateable(false), Createable(false)]
		public int? NumberOfErrors { get; set; }

		///<summary>
		/// Completion Date
		/// <para>Name: CompletedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "completedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? CompletedDate { get; set; }

		///<summary>
		/// Apex Method
		/// <para>Name: MethodName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "methodName")]
		[Updateable(false), Createable(false)]
		public string MethodName { get; set; }

		///<summary>
		/// Status Detail
		/// <para>Name: ExtendedStatus</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "extendedStatus")]
		[Updateable(false), Createable(false)]
		public string ExtendedStatus { get; set; }

		///<summary>
		/// Apex Job ID
		/// <para>Name: ParentJobId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "parentJobId")]
		[Updateable(false), Createable(false)]
		public string ParentJobId { get; set; }

		///<summary>
		/// Last ID processed and committed
		/// <para>Name: LastProcessed</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastProcessed")]
		[Updateable(false), Createable(false)]
		public string LastProcessed { get; set; }

		///<summary>
		/// Offset of last ID processed and committed
		/// <para>Name: LastProcessedOffset</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastProcessedOffset")]
		[Updateable(false), Createable(false)]
		public int? LastProcessedOffset { get; set; }

		///<summary>
		/// Scheduled Job ID
		/// <para>Name: CronTriggerId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "cronTriggerId")]
		[Updateable(false), Createable(false)]
		public string CronTriggerId { get; set; }

		///<summary>
		/// ReferenceTo: CronTrigger
		/// <para>RelationshipName: CronTrigger</para>
		///</summary>
		[JsonProperty(PropertyName = "cronTrigger")]
		[Updateable(false), Createable(false)]
		public SfCronTrigger CronTrigger { get; set; }

	}
}
