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
	/// Custom Object Usage By User License Metric
	///<para>SObject Name: CustomObjectUserLicenseMetrics</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfCustomObjectUserLicenseMetrics : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "CustomObjectUserLicenseMetrics"; }
		}

		///<summary>
		/// Custom Object Usage By User License Metrics Id
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Metrics Date
		/// <para>Name: MetricsDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "metricsDate")]
		[Updateable(false), Createable(false)]
		public DateTime? MetricsDate { get; set; }

		///<summary>
		/// User License ID
		/// <para>Name: UserLicenseId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userLicenseId")]
		[Updateable(false), Createable(false)]
		public string UserLicenseId { get; set; }

		///<summary>
		/// ReferenceTo: UserLicense
		/// <para>RelationshipName: UserLicense</para>
		///</summary>
		[JsonProperty(PropertyName = "userLicense")]
		[Updateable(false), Createable(false)]
		public SfUserLicense UserLicense { get; set; }

		///<summary>
		/// Custom Object Id
		/// <para>Name: CustomObjectId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "customObjectId")]
		[Updateable(false), Createable(false)]
		public string CustomObjectId { get; set; }

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
		/// Custom Object Type
		/// <para>Name: CustomObjectType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "customObjectType")]
		[Updateable(false), Createable(false)]
		public string CustomObjectType { get; set; }

		///<summary>
		/// Custom Object Name
		/// <para>Name: CustomObjectName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "customObjectName")]
		[Updateable(false), Createable(false)]
		public string CustomObjectName { get; set; }

		///<summary>
		/// Count of Objects assigned
		/// <para>Name: ObjectCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "objectCount")]
		[Updateable(false), Createable(false)]
		public int? ObjectCount { get; set; }

	}
}
