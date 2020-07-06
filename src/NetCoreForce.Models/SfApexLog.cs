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
	/// Apex Debug Log
	///<para>SObject Name: ApexLog</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfApexLog : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ApexLog"; }
		}

		///<summary>
		/// Log ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Log User ID
		/// <para>Name: LogUserId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "logUserId")]
		[Updateable(false), Createable(false)]
		public string LogUserId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: LogUser</para>
		///</summary>
		[JsonProperty(PropertyName = "logUser")]
		[Updateable(false), Createable(false)]
		public SfUser LogUser { get; set; }

		///<summary>
		/// Log Size (bytes)
		/// <para>Name: LogLength</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "logLength")]
		[Updateable(false), Createable(false)]
		public int? LogLength { get; set; }

		///<summary>
		/// Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

		///<summary>
		/// Request Type
		/// <para>Name: Request</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "request")]
		[Updateable(false), Createable(false)]
		public string Request { get; set; }

		///<summary>
		/// Operation
		/// <para>Name: Operation</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "operation")]
		[Updateable(false), Createable(false)]
		public string Operation { get; set; }

		///<summary>
		/// Application
		/// <para>Name: Application</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "application")]
		[Updateable(false), Createable(false)]
		public string Application { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		[Updateable(false), Createable(false)]
		public string Status { get; set; }

		///<summary>
		/// Duration (ms)
		/// <para>Name: DurationMilliseconds</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "durationMilliseconds")]
		[Updateable(false), Createable(false)]
		public int? DurationMilliseconds { get; set; }

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
		/// Start Time
		/// <para>Name: StartTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "startTime")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? StartTime { get; set; }

		///<summary>
		/// Location
		/// <para>Name: Location</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "location")]
		[Updateable(false), Createable(false)]
		public string Location { get; set; }

	}
}
