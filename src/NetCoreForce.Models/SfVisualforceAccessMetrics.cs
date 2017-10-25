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
	/// Visualforce Access Metric
	///<para>SObject Name: VisualforceAccessMetrics</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfVisualforceAccessMetrics : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "VisualforceAccessMetrics"; }
		}

		///<summary>
		/// Visualforce Access Metric Id
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
		public string MetricsDate { get; set; }

		///<summary>
		/// Page ID
		/// <para>Name: ApexPageId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "apexPageId")]
		[Updateable(false), Createable(false)]
		public string ApexPageId { get; set; }

		///<summary>
		/// ReferenceTo: ApexPage
		/// <para>RelationshipName: ApexPage</para>
		///</summary>
		[JsonProperty(PropertyName = "apexPage")]
		[Updateable(false), Createable(false)]
		public SfApexPage ApexPage { get; set; }

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
		/// Daily Page View Count
		/// <para>Name: DailyPageViewCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dailyPageViewCount")]
		[Updateable(false), Createable(false)]
		public int? DailyPageViewCount { get; set; }

	}
}
