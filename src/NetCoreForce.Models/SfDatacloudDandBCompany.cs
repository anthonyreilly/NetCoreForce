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
	/// D&amp;B Company
	///<para>SObject Name: DatacloudDandBCompany</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfDatacloudDandBCompany : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "DatacloudDandBCompany"; }
		}

		///<summary>
		/// D&amp;B Company ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// D&amp;B Company ID
		/// <para>Name: ExternalId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "externalId")]
		[Updateable(false), Createable(false)]
		public string ExternalId { get; set; }

		///<summary>
		/// D&amp;B Company Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
		public string Name { get; set; }

		///<summary>
		/// D-U-N-S Number
		/// <para>Name: DunsNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dunsNumber")]
		[Updateable(false), Createable(false)]
		public string DunsNumber { get; set; }

		///<summary>
		/// D&amp;B Company ID
		/// <para>Name: CompanyId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "companyId")]
		[Updateable(false), Createable(false)]
		public string CompanyId { get; set; }

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
		/// State Code
		/// <para>Name: StateCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "stateCode")]
		[Updateable(false), Createable(false)]
		public string StateCode { get; set; }

		///<summary>
		/// Country
		/// <para>Name: Country</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "country")]
		[Updateable(false), Createable(false)]
		public string Country { get; set; }

		///<summary>
		/// Country Code
		/// <para>Name: CountryCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "countryCode")]
		[Updateable(false), Createable(false)]
		public string CountryCode { get; set; }

		///<summary>
		/// Postal Code
		/// <para>Name: Zip</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "zip")]
		[Updateable(false), Createable(false)]
		public string Zip { get; set; }

		///<summary>
		/// Telephone Number
		/// <para>Name: Phone</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "phone")]
		[Updateable(false), Createable(false)]
		public string Phone { get; set; }

		///<summary>
		/// Facsimile Number
		/// <para>Name: Fax</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fax")]
		[Updateable(false), Createable(false)]
		public string Fax { get; set; }

		///<summary>
		/// International Dialing Code
		/// <para>Name: CountryAccessCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "countryAccessCode")]
		[Updateable(false), Createable(false)]
		public string CountryAccessCode { get; set; }

		///<summary>
		/// Ownership Type Indicator
		/// <para>Name: PublicIndicator</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "publicIndicator")]
		[Updateable(false), Createable(false)]
		public string PublicIndicator { get; set; }

		///<summary>
		/// Ticker Symbol
		/// <para>Name: StockSymbol</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "stockSymbol")]
		[Updateable(false), Createable(false)]
		public string StockSymbol { get; set; }

		///<summary>
		/// Stock Exchange
		/// <para>Name: StockExchange</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "stockExchange")]
		[Updateable(false), Createable(false)]
		public string StockExchange { get; set; }

		///<summary>
		/// Annual Sales Volume
		/// <para>Name: SalesVolume</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "salesVolume")]
		[Updateable(false), Createable(false)]
		public double? SalesVolume { get; set; }

		///<summary>
		/// URL
		/// <para>Name: URL</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "uRL")]
		[Updateable(false), Createable(false)]
		public string URL { get; set; }

		///<summary>
		/// Out Of Business Indicator
		/// <para>Name: OutOfBusiness</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "outOfBusiness")]
		[Updateable(false), Createable(false)]
		public string OutOfBusiness { get; set; }

		///<summary>
		/// Number of Employees - Total
		/// <para>Name: EmployeesTotal</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "employeesTotal")]
		[Updateable(false), Createable(false)]
		public double? EmployeesTotal { get; set; }

		///<summary>
		/// FIPS MSA Code
		/// <para>Name: FipsMsaCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fipsMsaCode")]
		[Updateable(false), Createable(false)]
		public string FipsMsaCode { get; set; }

		///<summary>
		/// FIPS MSA Code Description
		/// <para>Name: FipsMsaDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fipsMsaDesc")]
		[Updateable(false), Createable(false)]
		public string FipsMsaDesc { get; set; }

		///<summary>
		/// Primary Tradestyle
		/// <para>Name: TradeStyle1</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "tradeStyle1")]
		[Updateable(false), Createable(false)]
		public string TradeStyle1 { get; set; }

		///<summary>
		/// Year Started
		/// <para>Name: YearStarted</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "yearStarted")]
		[Updateable(false), Createable(false)]
		public string YearStarted { get; set; }

		///<summary>
		/// Mailing Street Address
		/// <para>Name: MailingStreet</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mailingStreet")]
		[Updateable(false), Createable(false)]
		public string MailingStreet { get; set; }

		///<summary>
		/// Mailing City
		/// <para>Name: MailingCity</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mailingCity")]
		[Updateable(false), Createable(false)]
		public string MailingCity { get; set; }

		///<summary>
		/// Mailing State
		/// <para>Name: MailingState</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mailingState")]
		[Updateable(false), Createable(false)]
		public string MailingState { get; set; }

		///<summary>
		/// Mailing State Code
		/// <para>Name: MailingStateCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mailingStateCode")]
		[Updateable(false), Createable(false)]
		public string MailingStateCode { get; set; }

		///<summary>
		/// Mailing Country
		/// <para>Name: MailingCountry</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mailingCountry")]
		[Updateable(false), Createable(false)]
		public string MailingCountry { get; set; }

		///<summary>
		/// Mailing Country Code
		/// <para>Name: MailingCountryCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mailingCountryCode")]
		[Updateable(false), Createable(false)]
		public string MailingCountryCode { get; set; }

		///<summary>
		/// Mailing Postal Code
		/// <para>Name: MailingZip</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mailingZip")]
		[Updateable(false), Createable(false)]
		public string MailingZip { get; set; }

		///<summary>
		/// Latitude
		/// <para>Name: Latitude</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "latitude")]
		[Updateable(false), Createable(false)]
		public string Latitude { get; set; }

		///<summary>
		/// Longitude
		/// <para>Name: Longitude</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "longitude")]
		[Updateable(false), Createable(false)]
		public string Longitude { get; set; }

		///<summary>
		/// Primary SIC Code
		/// <para>Name: PrimarySic</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "primarySic")]
		[Updateable(false), Createable(false)]
		public string PrimarySic { get; set; }

		///<summary>
		/// Primary SIC Description
		/// <para>Name: PrimarySicDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "primarySicDesc")]
		[Updateable(false), Createable(false)]
		public string PrimarySicDesc { get; set; }

		///<summary>
		/// Second SIC Code
		/// <para>Name: SecondSic</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "secondSic")]
		[Updateable(false), Createable(false)]
		public string SecondSic { get; set; }

		///<summary>
		/// Second SIC Description
		/// <para>Name: SecondSicDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "secondSicDesc")]
		[Updateable(false), Createable(false)]
		public string SecondSicDesc { get; set; }

		///<summary>
		/// Third SIC Code
		/// <para>Name: ThirdSic</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "thirdSic")]
		[Updateable(false), Createable(false)]
		public string ThirdSic { get; set; }

		///<summary>
		/// Third SIC Description
		/// <para>Name: ThirdSicDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "thirdSicDesc")]
		[Updateable(false), Createable(false)]
		public string ThirdSicDesc { get; set; }

		///<summary>
		/// Fourth SIC Code
		/// <para>Name: FourthSic</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fourthSic")]
		[Updateable(false), Createable(false)]
		public string FourthSic { get; set; }

		///<summary>
		/// Fourth SIC Description
		/// <para>Name: FourthSicDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fourthSicDesc")]
		[Updateable(false), Createable(false)]
		public string FourthSicDesc { get; set; }

		///<summary>
		/// Fourth SIC Description
		/// <para>Name: FifthSic</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fifthSic")]
		[Updateable(false), Createable(false)]
		public string FifthSic { get; set; }

		///<summary>
		/// Fifth SIC Description
		/// <para>Name: FifthSicDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fifthSicDesc")]
		[Updateable(false), Createable(false)]
		public string FifthSicDesc { get; set; }

		///<summary>
		/// Sixth SIC Code
		/// <para>Name: SixthSic</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sixthSic")]
		[Updateable(false), Createable(false)]
		public string SixthSic { get; set; }

		///<summary>
		/// Sixth SIC Description
		/// <para>Name: SixthSicDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sixthSicDesc")]
		[Updateable(false), Createable(false)]
		public string SixthSicDesc { get; set; }

		///<summary>
		/// Primary NAICS Code
		/// <para>Name: PrimaryNaics</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "primaryNaics")]
		[Updateable(false), Createable(false)]
		public string PrimaryNaics { get; set; }

		///<summary>
		/// Primary NAICS Description
		/// <para>Name: PrimaryNaicsDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "primaryNaicsDesc")]
		[Updateable(false), Createable(false)]
		public string PrimaryNaicsDesc { get; set; }

		///<summary>
		/// Second NAICS Code
		/// <para>Name: SecondNaics</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "secondNaics")]
		[Updateable(false), Createable(false)]
		public string SecondNaics { get; set; }

		///<summary>
		/// Second NAICS Description
		/// <para>Name: SecondNaicsDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "secondNaicsDesc")]
		[Updateable(false), Createable(false)]
		public string SecondNaicsDesc { get; set; }

		///<summary>
		/// Third NAICS Code
		/// <para>Name: ThirdNaics</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "thirdNaics")]
		[Updateable(false), Createable(false)]
		public string ThirdNaics { get; set; }

		///<summary>
		/// Third NAICS Description
		/// <para>Name: ThirdNaicsDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "thirdNaicsDesc")]
		[Updateable(false), Createable(false)]
		public string ThirdNaicsDesc { get; set; }

		///<summary>
		/// Fourth NAICS Code
		/// <para>Name: FourthNaics</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fourthNaics")]
		[Updateable(false), Createable(false)]
		public string FourthNaics { get; set; }

		///<summary>
		/// Fourth NAICS Description
		/// <para>Name: FourthNaicsDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fourthNaicsDesc")]
		[Updateable(false), Createable(false)]
		public string FourthNaicsDesc { get; set; }

		///<summary>
		/// Fifth NAICS Code
		/// <para>Name: FifthNaics</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fifthNaics")]
		[Updateable(false), Createable(false)]
		public string FifthNaics { get; set; }

		///<summary>
		/// Fifth NAICS Description
		/// <para>Name: FifthNaicsDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fifthNaicsDesc")]
		[Updateable(false), Createable(false)]
		public string FifthNaicsDesc { get; set; }

		///<summary>
		/// Sixth NAICS Code
		/// <para>Name: SixthNaics</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sixthNaics")]
		[Updateable(false), Createable(false)]
		public string SixthNaics { get; set; }

		///<summary>
		/// Sixth NAICS Description
		/// <para>Name: SixthNaicsDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sixthNaicsDesc")]
		[Updateable(false), Createable(false)]
		public string SixthNaicsDesc { get; set; }

		///<summary>
		/// Location Ownership Indicator
		/// <para>Name: OwnOrRent</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "ownOrRent")]
		[Updateable(false), Createable(false)]
		public string OwnOrRent { get; set; }

		///<summary>
		/// Number of Employees - Location
		/// <para>Name: EmployeesHere</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "employeesHere")]
		[Updateable(false), Createable(false)]
		public double? EmployeesHere { get; set; }

		///<summary>
		/// Number of Employees - Location Indicator
		/// <para>Name: EmployeesHereReliability</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "employeesHereReliability")]
		[Updateable(false), Createable(false)]
		public string EmployeesHereReliability { get; set; }

		///<summary>
		/// Annual Sales Volume Indicator
		/// <para>Name: SalesVolumeReliability</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "salesVolumeReliability")]
		[Updateable(false), Createable(false)]
		public string SalesVolumeReliability { get; set; }

		///<summary>
		/// Local Currency Code
		/// <para>Name: CurrencyCode</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "currencyCode")]
		[Updateable(false), Createable(false)]
		public string CurrencyCode { get; set; }

		///<summary>
		/// Legal Structure
		/// <para>Name: LegalStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "legalStatus")]
		[Updateable(false), Createable(false)]
		public string LegalStatus { get; set; }

		///<summary>
		/// Number of Employees - Global
		/// <para>Name: GlobalUltimateTotalEmployees</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "globalUltimateTotalEmployees")]
		[Updateable(false), Createable(false)]
		public double? GlobalUltimateTotalEmployees { get; set; }

		///<summary>
		/// Number of Employees - Total Indicator
		/// <para>Name: EmployeesTotalReliability</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "employeesTotalReliability")]
		[Updateable(false), Createable(false)]
		public string EmployeesTotalReliability { get; set; }

		///<summary>
		/// Minority-Owned Indicator
		/// <para>Name: MinorityOwned</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "minorityOwned")]
		[Updateable(false), Createable(false)]
		public string MinorityOwned { get; set; }

		///<summary>
		/// Woman-Owned Indicator
		/// <para>Name: WomenOwned</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "womenOwned")]
		[Updateable(false), Createable(false)]
		public string WomenOwned { get; set; }

		///<summary>
		/// Small Business Indicator
		/// <para>Name: SmallBusiness</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "smallBusiness")]
		[Updateable(false), Createable(false)]
		public string SmallBusiness { get; set; }

		///<summary>
		/// Marketing Segmentation Cluster
		/// <para>Name: MarketingSegmentationCluster</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "marketingSegmentationCluster")]
		[Updateable(false), Createable(false)]
		public string MarketingSegmentationCluster { get; set; }

		///<summary>
		/// Import/Export
		/// <para>Name: ImportExportAgent</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "importExportAgent")]
		[Updateable(false), Createable(false)]
		public string ImportExportAgent { get; set; }

		///<summary>
		/// Subsidiary Indicator
		/// <para>Name: Subsidiary</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "subsidiary")]
		[Updateable(false), Createable(false)]
		public string Subsidiary { get; set; }

		///<summary>
		/// Second Tradestyle
		/// <para>Name: TradeStyle2</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "tradeStyle2")]
		[Updateable(false), Createable(false)]
		public string TradeStyle2 { get; set; }

		///<summary>
		/// Third Tradestyle
		/// <para>Name: TradeStyle3</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "tradeStyle3")]
		[Updateable(false), Createable(false)]
		public string TradeStyle3 { get; set; }

		///<summary>
		/// Fourth Tradestyle
		/// <para>Name: TradeStyle4</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "tradeStyle4")]
		[Updateable(false), Createable(false)]
		public string TradeStyle4 { get; set; }

		///<summary>
		/// Fifth Tradestyle
		/// <para>Name: TradeStyle5</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "tradeStyle5")]
		[Updateable(false), Createable(false)]
		public string TradeStyle5 { get; set; }

		///<summary>
		/// National Identification Number
		/// <para>Name: NationalId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "nationalId")]
		[Updateable(false), Createable(false)]
		public string NationalId { get; set; }

		///<summary>
		/// National Identification System
		/// <para>Name: NationalIdType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "nationalIdType")]
		[Updateable(false), Createable(false)]
		public string NationalIdType { get; set; }

		///<summary>
		/// US Tax ID Number
		/// <para>Name: UsTaxId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "usTaxId")]
		[Updateable(false), Createable(false)]
		public string UsTaxId { get; set; }

		///<summary>
		/// Geocode Accuracy
		/// <para>Name: GeoCodeAccuracy</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "geoCodeAccuracy")]
		[Updateable(false), Createable(false)]
		public string GeoCodeAccuracy { get; set; }

		///<summary>
		/// Number of Business Family Members
		/// <para>Name: FamilyMembers</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "familyMembers")]
		[Updateable(false), Createable(false)]
		public int? FamilyMembers { get; set; }

		///<summary>
		/// Delinquency Risk
		/// <para>Name: MarketingPreScreen</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "marketingPreScreen")]
		[Updateable(false), Createable(false)]
		public string MarketingPreScreen { get; set; }

		///<summary>
		/// Global Ultimate D-U-N-S Number
		/// <para>Name: GlobalUltimateDunsNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "globalUltimateDunsNumber")]
		[Updateable(false), Createable(false)]
		public string GlobalUltimateDunsNumber { get; set; }

		///<summary>
		/// Global Ultimate Business Name
		/// <para>Name: GlobalUltimateBusinessName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "globalUltimateBusinessName")]
		[Updateable(false), Createable(false)]
		public string GlobalUltimateBusinessName { get; set; }

		///<summary>
		/// Parent Company D-U-N-S Number
		/// <para>Name: ParentOrHqDunsNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "parentOrHqDunsNumber")]
		[Updateable(false), Createable(false)]
		public string ParentOrHqDunsNumber { get; set; }

		///<summary>
		/// Parent Company Business Name
		/// <para>Name: ParentOrHqBusinessName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "parentOrHqBusinessName")]
		[Updateable(false), Createable(false)]
		public string ParentOrHqBusinessName { get; set; }

		///<summary>
		/// Domestic Ultimate D-U-N-S Number
		/// <para>Name: DomesticUltimateDunsNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "domesticUltimateDunsNumber")]
		[Updateable(false), Createable(false)]
		public string DomesticUltimateDunsNumber { get; set; }

		///<summary>
		/// Domestic Ultimate Business Name
		/// <para>Name: DomesticUltimateBusinessName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "domesticUltimateBusinessName")]
		[Updateable(false), Createable(false)]
		public string DomesticUltimateBusinessName { get; set; }

		///<summary>
		/// Location Type
		/// <para>Name: LocationStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "locationStatus")]
		[Updateable(false), Createable(false)]
		public string LocationStatus { get; set; }

		///<summary>
		/// Local Currency ISO Code
		/// <para>Name: CompanyCurrencyIsoCode</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "companyCurrencyIsoCode")]
		[Updateable(false), Createable(false)]
		public string CompanyCurrencyIsoCode { get; set; }

		///<summary>
		/// Company Description
		/// <para>Name: Description</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		[Updateable(false), Createable(false)]
		public string Description { get; set; }

		///<summary>
		/// Owned Status
		/// <para>Name: IsOwned</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isOwned")]
		[Updateable(false), Createable(false)]
		public bool? IsOwned { get; set; }

		///<summary>
		/// Parent
		/// <para>Name: IsParent</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isParent")]
		[Updateable(false), Createable(false)]
		public bool? IsParent { get; set; }

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
		/// SIC8 Code
		/// <para>Name: PrimarySic8</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "primarySic8")]
		[Updateable(false), Createable(false)]
		public string PrimarySic8 { get; set; }

		///<summary>
		/// SIC8 Description
		/// <para>Name: PrimarySic8Desc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "primarySic8Desc")]
		[Updateable(false), Createable(false)]
		public string PrimarySic8Desc { get; set; }

		///<summary>
		/// Second SIC8 Code
		/// <para>Name: SecondSic8</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "secondSic8")]
		[Updateable(false), Createable(false)]
		public string SecondSic8 { get; set; }

		///<summary>
		/// Second SIC8 Description 
		/// <para>Name: SecondSic8Desc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "secondSic8Desc")]
		[Updateable(false), Createable(false)]
		public string SecondSic8Desc { get; set; }

		///<summary>
		/// Third SIC8 Code
		/// <para>Name: ThirdSic8</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "thirdSic8")]
		[Updateable(false), Createable(false)]
		public string ThirdSic8 { get; set; }

		///<summary>
		/// Third SIC8 Description
		/// <para>Name: ThirdSic8Desc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "thirdSic8Desc")]
		[Updateable(false), Createable(false)]
		public string ThirdSic8Desc { get; set; }

		///<summary>
		/// Fourth SIC8 Code
		/// <para>Name: FourthSic8</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fourthSic8")]
		[Updateable(false), Createable(false)]
		public string FourthSic8 { get; set; }

		///<summary>
		/// Fourth SIC8 Description
		/// <para>Name: FourthSic8Desc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fourthSic8Desc")]
		[Updateable(false), Createable(false)]
		public string FourthSic8Desc { get; set; }

		///<summary>
		/// Fifth SIC8 Code
		/// <para>Name: FifthSic8</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fifthSic8")]
		[Updateable(false), Createable(false)]
		public string FifthSic8 { get; set; }

		///<summary>
		/// Fifth SIC8 Description
		/// <para>Name: FifthSic8Desc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fifthSic8Desc")]
		[Updateable(false), Createable(false)]
		public string FifthSic8Desc { get; set; }

		///<summary>
		/// Sixth SIC8 Code
		/// <para>Name: SixthSic8</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sixthSic8")]
		[Updateable(false), Createable(false)]
		public string SixthSic8 { get; set; }

		///<summary>
		/// Sixth SIC8 Description
		/// <para>Name: SixthSic8Desc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sixthSic8Desc")]
		[Updateable(false), Createable(false)]
		public string SixthSic8Desc { get; set; }

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
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "priorYearRevenue")]
		[Updateable(false), Createable(false)]
		public double? PriorYearRevenue { get; set; }

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
		/// Revenue
		/// <para>Name: Revenue</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "revenue")]
		[Updateable(false), Createable(false)]
		public double? Revenue { get; set; }

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
