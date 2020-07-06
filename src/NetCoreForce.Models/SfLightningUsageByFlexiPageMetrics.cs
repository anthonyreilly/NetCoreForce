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
	/// LightningUsageByFlexiPageMetrics
	///<para>SObject Name: LightningUsageByFlexiPageMetrics</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfLightningUsageByFlexiPageMetrics : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "LightningUsageByFlexiPageMetrics"; }
		}

		///<summary>
		/// LightningUsageByFlexiPageMetrics ID
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
		/// FlexiPage Type
		/// <para>Name: FlexiPageType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "flexiPageType")]
		[Updateable(false), Createable(false)]
		public string FlexiPageType { get; set; }

		///<summary>
		/// FlexiPage Name Or Id
		/// <para>Name: FlexiPageNameOrId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "flexiPageNameOrId")]
		[Updateable(false), Createable(false)]
		public string FlexiPageNameOrId { get; set; }

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
		/// Record Count EPT
		/// <para>Name: RecordCountEPT</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recordCountEPT")]
		[Updateable(false), Createable(false)]
		public int? RecordCountEPT { get; set; }

		///<summary>
		/// Total Count
		/// <para>Name: TotalCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalCount")]
		[Updateable(false), Createable(false)]
		public int? TotalCount { get; set; }

		///<summary>
		/// Sum EPT
		/// <para>Name: SumEPT</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sumEPT")]
		[Updateable(false), Createable(false)]
		public int? SumEPT { get; set; }

	}
}
