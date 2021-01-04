// SF API version v50.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Flow Interview Log Entry
	///<para>SObject Name: FlowInterviewLogEntry</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfFlowInterviewLogEntry : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "FlowInterviewLogEntry"; }
		}

		///<summary>
		/// Flow Interview Log Entry ID
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
		/// Flow Interview Log ID
		/// <para>Name: FlowInterviewLogId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "flowInterviewLogId")]
		[Updateable(false), Createable(false)]
		public string FlowInterviewLogId { get; set; }

		///<summary>
		/// ReferenceTo: FlowInterviewLog
		/// <para>RelationshipName: FlowInterviewLog</para>
		///</summary>
		[JsonProperty(PropertyName = "flowInterviewLog")]
		[Updateable(false), Createable(false)]
		public SfFlowInterviewLog FlowInterviewLog { get; set; }

		///<summary>
		/// Log Entry Type
		/// <para>Name: LogEntryType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "logEntryType")]
		[Updateable(false), Createable(false)]
		public string LogEntryType { get; set; }

		///<summary>
		/// Element API Name
		/// <para>Name: ElementApiName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "elementApiName")]
		[Updateable(false), Createable(false)]
		public string ElementApiName { get; set; }

		///<summary>
		/// Log Entry Timestamp
		/// <para>Name: LogEntryTimestamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "logEntryTimestamp")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LogEntryTimestamp { get; set; }

		///<summary>
		/// Duration In Minutes Since Flow Start
		/// <para>Name: DurationSinceStartInMinutes</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "durationSinceStartInMinutes")]
		[Updateable(false), Createable(false)]
		public double? DurationSinceStartInMinutes { get; set; }

		///<summary>
		/// Element Duration in Minutes
		/// <para>Name: ElementDurationInMinutes</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "elementDurationInMinutes")]
		[Updateable(false), Createable(false)]
		public double? ElementDurationInMinutes { get; set; }

		///<summary>
		/// Element Label
		/// <para>Name: ElementLabel</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "elementLabel")]
		[Updateable(false), Createable(false)]
		public string ElementLabel { get; set; }

	}
}
