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
	/// Active Feature License Metric
	///<para>SObject Name: ActiveFeatureLicenseMetric</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfActiveFeatureLicenseMetric : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ActiveFeatureLicenseMetric"; }
		}

		///<summary>
		/// Active Feature License Metric ID
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
		/// Primary Grain
		/// <para>Name: FeatureType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "featureType")]
		[Updateable(false), Createable(false)]
		public string FeatureType { get; set; }

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
		/// Assigned User Count
		/// <para>Name: AssignedUserCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "assignedUserCount")]
		[Updateable(false), Createable(false)]
		public int? AssignedUserCount { get; set; }

		///<summary>
		/// Active User Count
		/// <para>Name: ActiveUserCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "activeUserCount")]
		[Updateable(false), Createable(false)]
		public int? ActiveUserCount { get; set; }

		///<summary>
		/// Total License Count
		/// <para>Name: TotalLicenseCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalLicenseCount")]
		[Updateable(false), Createable(false)]
		public int? TotalLicenseCount { get; set; }

	}
}
