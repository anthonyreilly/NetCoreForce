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
	/// Period
	///<para>SObject Name: Period</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfPeriod : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "Period"; }
		}

		///<summary>
		/// Period ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Fiscal Year Settings ID
		/// <para>Name: FiscalYearSettingsId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fiscalYearSettingsId")]
		[Updateable(false), Createable(false)]
		public string FiscalYearSettingsId { get; set; }

		///<summary>
		/// ReferenceTo: FiscalYearSettings
		/// <para>RelationshipName: FiscalYearSettings</para>
		///</summary>
		[JsonProperty(PropertyName = "fiscalYearSettings")]
		[Updateable(false), Createable(false)]
		public SfFiscalYearSettings FiscalYearSettings { get; set; }

		///<summary>
		/// Type
		/// <para>Name: Type</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		[Updateable(false), Createable(false)]
		public string Type { get; set; }

		///<summary>
		/// Start Date
		/// <para>Name: StartDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "startDate")]
		[Updateable(false), Createable(false)]
		public DateTime? StartDate { get; set; }

		///<summary>
		/// End Date
		/// <para>Name: EndDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "endDate")]
		[Updateable(false), Createable(false)]
		public DateTime? EndDate { get; set; }

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
		/// Is Forecast Period
		/// <para>Name: IsForecastPeriod</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isForecastPeriod")]
		[Updateable(false), Createable(false)]
		public bool? IsForecastPeriod { get; set; }

		///<summary>
		/// Quarter Name
		/// <para>Name: QuarterLabel</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "quarterLabel")]
		[Updateable(false), Createable(false)]
		public string QuarterLabel { get; set; }

		///<summary>
		/// Period Name
		/// <para>Name: PeriodLabel</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "periodLabel")]
		[Updateable(false), Createable(false)]
		public string PeriodLabel { get; set; }

		///<summary>
		/// Number
		/// <para>Name: Number</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "number")]
		[Updateable(false), Createable(false)]
		public int? Number { get; set; }

		///<summary>
		/// Fully Qualified Label
		/// <para>Name: FullyQualifiedLabel</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fullyQualifiedLabel")]
		[Updateable(false), Createable(false)]
		public string FullyQualifiedLabel { get; set; }

	}
}
