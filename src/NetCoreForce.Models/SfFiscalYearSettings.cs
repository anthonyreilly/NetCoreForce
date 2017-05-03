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
	/// Fiscal Year Settings
	///<para>SObject Name: FiscalYearSettings</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfFiscalYearSettings : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "FiscalYearSettings"; }
		}

		///<summary>
		/// Fiscal Year Settings ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Period ID
		/// <para>Name: PeriodId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "periodId")]
		[Updateable(false), Createable(false)]
		public string PeriodId { get; set; }

		///<summary>
		/// Start Date
		/// <para>Name: StartDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "startDate")]
		[Updateable(false), Createable(false)]
		public string StartDate { get; set; }

		///<summary>
		/// End Date
		/// <para>Name: EndDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "endDate")]
		[Updateable(false), Createable(false)]
		public string EndDate { get; set; }

		///<summary>
		/// Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
		public string Name { get; set; }

		///<summary>
		/// Is Standard Year
		/// <para>Name: IsStandardYear</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isStandardYear")]
		[Updateable(false), Createable(false)]
		public bool? IsStandardYear { get; set; }

		///<summary>
		/// Year Type
		/// <para>Name: YearType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "yearType")]
		[Updateable(false), Createable(false)]
		public string YearType { get; set; }

		///<summary>
		/// Quarter Name Scheme
		/// <para>Name: QuarterLabelScheme</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "quarterLabelScheme")]
		[Updateable(false), Createable(false)]
		public string QuarterLabelScheme { get; set; }

		///<summary>
		/// Period Name Scheme
		/// <para>Name: PeriodLabelScheme</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "periodLabelScheme")]
		[Updateable(false), Createable(false)]
		public string PeriodLabelScheme { get; set; }

		///<summary>
		/// Week Name Scheme
		/// <para>Name: WeekLabelScheme</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "weekLabelScheme")]
		[Updateable(false), Createable(false)]
		public string WeekLabelScheme { get; set; }

		///<summary>
		/// Quarter Prefix
		/// <para>Name: QuarterPrefix</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "quarterPrefix")]
		[Updateable(false), Createable(false)]
		public string QuarterPrefix { get; set; }

		///<summary>
		/// Period Prefix
		/// <para>Name: PeriodPrefix</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "periodPrefix")]
		[Updateable(false), Createable(false)]
		public string PeriodPrefix { get; set; }

		///<summary>
		/// Week Start Day
		/// <para>Name: WeekStartDay</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "weekStartDay")]
		[Updateable(false), Createable(false)]
		public int? WeekStartDay { get; set; }

		///<summary>
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		[Updateable(false), Createable(false)]
		public string Description { get; set; }

		///<summary>
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

	}
}
