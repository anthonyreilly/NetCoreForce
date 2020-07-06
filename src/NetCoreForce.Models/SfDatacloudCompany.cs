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
	/// Data.com Company
	///<para>SObject Name: DatacloudCompany</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfDatacloudCompany : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "DatacloudCompany"; }
		}

		///<summary>
		/// System ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Data.com Company ID
		/// <para>Name: ExternalId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "externalId")]
		[Updateable(false), Createable(false)]
		public string ExternalId { get; set; }

		///<summary>
		/// Data.com Company ID
		/// <para>Name: CompanyId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "companyId")]
		[Updateable(false), Createable(false)]
		public string CompanyId { get; set; }

		///<summary>
		/// Company Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
		public string Name { get; set; }

		///<summary>
		/// Company Synopsis
		/// <para>Name: Description</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		[Updateable(false), Createable(false)]
		public string Description { get; set; }

		///<summary>
		/// Inactive Status
		/// <para>Name: IsInactive</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isInactive")]
		[Updateable(false), Createable(false)]
		public bool? IsInactive { get; set; }

		///<summary>
		/// Phone Number
		/// <para>Name: Phone</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "phone")]
		[Updateable(false), Createable(false)]
		public string Phone { get; set; }

		///<summary>
		/// Fax Number
		/// <para>Name: Fax</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fax")]
		[Updateable(false), Createable(false)]
		public string Fax { get; set; }

		///<summary>
		/// Street Address
		/// <para>Name: Street</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "street")]
		[Updateable(false), Createable(false)]
		public string Street { get; set; }

		///<summary>
		/// City
		/// <para>Name: City</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "city")]
		[Updateable(false), Createable(false)]
		public string City { get; set; }

		///<summary>
		/// State
		/// <para>Name: State</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "state")]
		[Updateable(false), Createable(false)]
		public string State { get; set; }

		///<summary>
		/// State
		/// <para>Name: StateCode</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "stateCode")]
		[Updateable(false), Createable(false)]
		public string StateCode { get; set; }

		///<summary>
		/// Country/Territory
		/// <para>Name: Country</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "country")]
		[Updateable(false), Createable(false)]
		public string Country { get; set; }

		///<summary>
		/// Country/Territory
		/// <para>Name: CountryCode</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "countryCode")]
		[Updateable(false), Createable(false)]
		public string CountryCode { get; set; }

		///<summary>
		/// Zip
		/// <para>Name: Zip</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "zip")]
		[Updateable(false), Createable(false)]
		public string Zip { get; set; }

		///<summary>
		/// Location Type
		/// <para>Name: Site</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "site")]
		[Updateable(false), Createable(false)]
		public string Site { get; set; }

		///<summary>
		/// Industry
		/// <para>Name: Industry</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "industry")]
		[Updateable(false), Createable(false)]
		public string Industry { get; set; }

		///<summary>
		/// Employee Count
		/// <para>Name: NumberOfEmployees</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "numberOfEmployees")]
		[Updateable(false), Createable(false)]
		public int? NumberOfEmployees { get; set; }

		///<summary>
		/// Annual Revenue
		/// <para>Name: AnnualRevenue</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "annualRevenue")]
		[Updateable(false), Createable(false)]
		public decimal? AnnualRevenue { get; set; }

		///<summary>
		/// Duns Number
		/// <para>Name: DunsNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dunsNumber")]
		[Updateable(false), Createable(false)]
		public string DunsNumber { get; set; }

		///<summary>
		/// NAICS Code
		/// <para>Name: NaicsCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "naicsCode")]
		[Updateable(false), Createable(false)]
		public string NaicsCode { get; set; }

		///<summary>
		/// NAICS Description
		/// <para>Name: NaicsDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "naicsDesc")]
		[Updateable(false), Createable(false)]
		public string NaicsDesc { get; set; }

		///<summary>
		/// SIC Code
		/// <para>Name: Sic</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sic")]
		[Updateable(false), Createable(false)]
		public string Sic { get; set; }

		///<summary>
		/// SIC Description
		/// <para>Name: SicDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sicDesc")]
		[Updateable(false), Createable(false)]
		public string SicDesc { get; set; }

		///<summary>
		/// Ownership Status
		/// <para>Name: Ownership</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "ownership")]
		[Updateable(false), Createable(false)]
		public string Ownership { get; set; }

		///<summary>
		/// Owned
		/// <para>Name: IsOwned</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isOwned")]
		[Updateable(false), Createable(false)]
		public bool? IsOwned { get; set; }

		///<summary>
		/// Stock Ticker Symbol
		/// <para>Name: TickerSymbol</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "tickerSymbol")]
		[Updateable(false), Createable(false)]
		public string TickerSymbol { get; set; }

		///<summary>
		/// Trade Style
		/// <para>Name: TradeStyle</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "tradeStyle")]
		[Updateable(false), Createable(false)]
		public string TradeStyle { get; set; }

		///<summary>
		/// Company or Website
		/// <para>Name: Website</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "website")]
		[Updateable(false), Createable(false)]
		public string Website { get; set; }

		///<summary>
		/// Company Founding Date
		/// <para>Name: YearStarted</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "yearStarted")]
		[Updateable(false), Createable(false)]
		public string YearStarted { get; set; }

		///<summary>
		/// Active Contacts
		/// <para>Name: ActiveContacts</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "activeContacts")]
		[Updateable(false), Createable(false)]
		public int? ActiveContacts { get; set; }

		///<summary>
		/// Updated Date
		/// <para>Name: UpdatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "updatedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? UpdatedDate { get; set; }

		///<summary>
		/// Fortune Rank
		/// <para>Name: FortuneRank</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fortuneRank")]
		[Updateable(false), Createable(false)]
		public int? FortuneRank { get; set; }

		///<summary>
		/// Included In S&amp;P 500
		/// <para>Name: IncludedInSnP500</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "includedInSnP500")]
		[Updateable(false), Createable(false)]
		public string IncludedInSnP500 { get; set; }

		///<summary>
		/// Premises Area Measurement
		/// <para>Name: PremisesMeasure</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "premisesMeasure")]
		[Updateable(false), Createable(false)]
		public int? PremisesMeasure { get; set; }

		///<summary>
		/// Premises Area Measurement Reliability Text
		/// <para>Name: PremisesMeasureReliability</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "premisesMeasureReliability")]
		[Updateable(false), Createable(false)]
		public string PremisesMeasureReliability { get; set; }

		///<summary>
		/// Premises Area Unit of Measurement
		/// <para>Name: PremisesMeasureUnit</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "premisesMeasureUnit")]
		[Updateable(false), Createable(false)]
		public string PremisesMeasureUnit { get; set; }

		///<summary>
		/// Employee Quantity Growth Rate
		/// <para>Name: EmployeeQuantityGrowthRate</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "employeeQuantityGrowthRate")]
		[Updateable(false), Createable(false)]
		public double? EmployeeQuantityGrowthRate { get; set; }

		///<summary>
		/// Sales Turnover Growth Rate
		/// <para>Name: SalesTurnoverGrowthRate</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "salesTurnoverGrowthRate")]
		[Updateable(false), Createable(false)]
		public double? SalesTurnoverGrowthRate { get; set; }

		///<summary>
		/// Prior Year Employee
		/// <para>Name: PriorYearEmployees</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "priorYearEmployees")]
		[Updateable(false), Createable(false)]
		public int? PriorYearEmployees { get; set; }

		///<summary>
		/// Prior Year Revenue
		/// <para>Name: PriorYearRevenue</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "priorYearRevenue")]
		[Updateable(false), Createable(false)]
		public decimal? PriorYearRevenue { get; set; }

		///<summary>
		/// In CRM
		/// <para>Name: IsInCrm</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isInCrm")]
		[Updateable(false), Createable(false)]
		public bool? IsInCrm { get; set; }

		///<summary>
		/// Address
		/// <para>Name: FullAddress</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fullAddress")]
		[Updateable(false), Createable(false)]
		public string FullAddress { get; set; }

		///<summary>
		/// Industry Codes
		/// <para>Name: SicCodeDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sicCodeDesc")]
		[Updateable(false), Createable(false)]
		public string SicCodeDesc { get; set; }

	}
}
