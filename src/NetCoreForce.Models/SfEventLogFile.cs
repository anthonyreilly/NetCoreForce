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
	/// Event Log File
	///<para>SObject Name: EventLogFile</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfEventLogFile : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "EventLogFile"; }
		}

		///<summary>
		/// Event Log File ID
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
		/// Event Type
		/// <para>Name: EventType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "eventType")]
		[Updateable(false), Createable(false)]
		public string EventType { get; set; }

		///<summary>
		/// Log Date
		/// <para>Name: LogDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "logDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LogDate { get; set; }

		///<summary>
		/// Log File Length
		/// <para>Name: LogFileLength</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "logFileLength")]
		[Updateable(false), Createable(false)]
		public double? LogFileLength { get; set; }

		///<summary>
		/// Log File Content Type
		/// <para>Name: LogFileContentType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "logFileContentType")]
		[Updateable(false), Createable(false)]
		public string LogFileContentType { get; set; }

		///<summary>
		/// API Version
		/// <para>Name: ApiVersion</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "apiVersion")]
		[Updateable(false), Createable(false)]
		public double? ApiVersion { get; set; }

		///<summary>
		/// Sequence
		/// <para>Name: Sequence</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "sequence")]
		[Updateable(false), Createable(false)]
		public int? Sequence { get; set; }

		///<summary>
		/// Interval
		/// <para>Name: Interval</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "interval")]
		[Updateable(false), Createable(false)]
		public string Interval { get; set; }

		///<summary>
		/// Log File Field Names
		/// <para>Name: LogFileFieldNames</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "logFileFieldNames")]
		[Updateable(false), Createable(false)]
		public string LogFileFieldNames { get; set; }

		///<summary>
		/// Log File Field Types
		/// <para>Name: LogFileFieldTypes</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "logFileFieldTypes")]
		[Updateable(false), Createable(false)]
		public string LogFileFieldTypes { get; set; }

		///<summary>
		/// Log File
		/// <para>Name: LogFile</para>
		/// <para>SF Type: base64</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "logFile")]
		[Updateable(false), Createable(false)]
		public string LogFile { get; set; }

	}
}
