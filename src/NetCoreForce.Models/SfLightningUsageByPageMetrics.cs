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
	/// LightningUsageByPageMetrics
	///<para>SObject Name: LightningUsageByPageMetrics</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfLightningUsageByPageMetrics : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "LightningUsageByPageMetrics"; }
		}

		///<summary>
		/// LightningUsageByPageMetrics ID
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
		/// User ID
		/// <para>Name: UserId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userId")]
		[Updateable(false), Createable(false)]
		public string UserId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: User</para>
		///</summary>
		[JsonProperty(PropertyName = "user")]
		[Updateable(false), Createable(false)]
		public SfUser User { get; set; }

		///<summary>
		/// Page Name
		/// <para>Name: PageName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "pageName")]
		[Updateable(false), Createable(false)]
		public string PageName { get; set; }

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

		///<summary>
		/// EptBinUnder3
		/// <para>Name: EptBinUnder3</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "eptBinUnder3")]
		[Updateable(false), Createable(false)]
		public int? EptBinUnder3 { get; set; }

		///<summary>
		/// EptBin3To5
		/// <para>Name: EptBin3To5</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "eptBin3To5")]
		[Updateable(false), Createable(false)]
		public int? EptBin3To5 { get; set; }

		///<summary>
		/// EptBin5To8
		/// <para>Name: EptBin5To8</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "eptBin5To8")]
		[Updateable(false), Createable(false)]
		public int? EptBin5To8 { get; set; }

		///<summary>
		/// EptBin8To10
		/// <para>Name: EptBin8To10</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "eptBin8To10")]
		[Updateable(false), Createable(false)]
		public int? EptBin8To10 { get; set; }

		///<summary>
		/// EptBinOver10
		/// <para>Name: EptBinOver10</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "eptBinOver10")]
		[Updateable(false), Createable(false)]
		public int? EptBinOver10 { get; set; }

	}
}
