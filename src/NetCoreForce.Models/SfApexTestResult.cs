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
	/// Apex Test Result
	///<para>SObject Name: ApexTestResult</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfApexTestResult : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ApexTestResult"; }
		}

		///<summary>
		/// Apex Test Result ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

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
		/// Time Started
		/// <para>Name: TestTimestamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "testTimestamp")]
		public DateTimeOffset? TestTimestamp { get; set; }

		///<summary>
		/// Pass/Fail
		/// <para>Name: Outcome</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "outcome")]
		public string Outcome { get; set; }

		///<summary>
		/// Class ID
		/// <para>Name: ApexClassId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "apexClassId")]
		public string ApexClassId { get; set; }

		///<summary>
		/// ReferenceTo: ApexClass
		/// <para>RelationshipName: ApexClass</para>
		///</summary>
		[JsonProperty(PropertyName = "apexClass")]
		[Updateable(false), Createable(false)]
		public SfApexClass ApexClass { get; set; }

		///<summary>
		/// Method Name
		/// <para>Name: MethodName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "methodName")]
		public string MethodName { get; set; }

		///<summary>
		/// Error Message
		/// <para>Name: Message</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "message")]
		public string Message { get; set; }

		///<summary>
		/// Stack Trace
		/// <para>Name: StackTrace</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "stackTrace")]
		public string StackTrace { get; set; }

		///<summary>
		/// Apex Job ID
		/// <para>Name: AsyncApexJobId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "asyncApexJobId")]
		public string AsyncApexJobId { get; set; }

		///<summary>
		/// ReferenceTo: AsyncApexJob
		/// <para>RelationshipName: AsyncApexJob</para>
		///</summary>
		[JsonProperty(PropertyName = "asyncApexJob")]
		[Updateable(false), Createable(false)]
		public SfAsyncApexJob AsyncApexJob { get; set; }

		///<summary>
		/// Apex Test Queue Item ID
		/// <para>Name: QueueItemId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "queueItemId")]
		public string QueueItemId { get; set; }

		///<summary>
		/// ReferenceTo: ApexTestQueueItem
		/// <para>RelationshipName: QueueItem</para>
		///</summary>
		[JsonProperty(PropertyName = "queueItem")]
		[Updateable(false), Createable(false)]
		public SfApexTestQueueItem QueueItem { get; set; }

		///<summary>
		/// Log ID
		/// <para>Name: ApexLogId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "apexLogId")]
		public string ApexLogId { get; set; }

		///<summary>
		/// ReferenceTo: ApexLog
		/// <para>RelationshipName: ApexLog</para>
		///</summary>
		[JsonProperty(PropertyName = "apexLog")]
		[Updateable(false), Createable(false)]
		public SfApexLog ApexLog { get; set; }

		///<summary>
		/// ApexTestRunResult ID
		/// <para>Name: ApexTestRunResultId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "apexTestRunResultId")]
		public string ApexTestRunResultId { get; set; }

		///<summary>
		/// ReferenceTo: ApexTestRunResult
		/// <para>RelationshipName: ApexTestRunResult</para>
		///</summary>
		[JsonProperty(PropertyName = "apexTestRunResult")]
		[Updateable(false), Createable(false)]
		public SfApexTestRunResult ApexTestRunResult { get; set; }

		///<summary>
		/// Run Time
		/// <para>Name: RunTime</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "runTime")]
		public int? RunTime { get; set; }

	}
}
