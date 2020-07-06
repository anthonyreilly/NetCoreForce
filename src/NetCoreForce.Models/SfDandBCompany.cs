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
	/// D&amp;B Company
	///<para>SObject Name: DandBCompany</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfDandBCompany : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "DandBCompany"; }
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
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Createable(false)]
		public bool? IsDeleted { get; set; }

		///<summary>
		/// Primary Business Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		///<summary>
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

		///<summary>
		/// Created By ID
		/// <para>Name: CreatedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdById")]
		[Updateable(false), Createable(false)]
		public string CreatedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: CreatedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "createdBy")]
		[Updateable(false), Createable(false)]
		public SfUser CreatedBy { get; set; }

		///<summary>
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

		///<summary>
		/// Last Modified By ID
		/// <para>Name: LastModifiedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedById")]
		[Updateable(false), Createable(false)]
		public string LastModifiedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: LastModifiedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedBy")]
		[Updateable(false), Createable(false)]
		public SfUser LastModifiedBy { get; set; }

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
		/// Last Viewed Date
		/// <para>Name: LastViewedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastViewedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastViewedDate { get; set; }

		///<summary>
		/// Last Referenced Date
		/// <para>Name: LastReferencedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastReferencedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastReferencedDate { get; set; }

		///<summary>
		/// D-U-N-S Number
		/// <para>Name: DunsNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "dunsNumber")]
		public string DunsNumber { get; set; }

		///<summary>
		/// Street Address
		/// <para>Name: Street</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "street")]
		public string Street { get; set; }

		///<summary>
		/// City
		/// <para>Name: City</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "city")]
		public string City { get; set; }

		///<summary>
		/// State
		/// <para>Name: State</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "state")]
		public string State { get; set; }

		///<summary>
		/// Postal Code
		/// <para>Name: PostalCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "postalCode")]
		public string PostalCode { get; set; }

		///<summary>
		/// Country
		/// <para>Name: Country</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "country")]
		public string Country { get; set; }

		///<summary>
		/// Geocode Accuracy
		/// <para>Name: GeocodeAccuracyStandard</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "geocodeAccuracyStandard")]
		public string GeocodeAccuracyStandard { get; set; }

		///<summary>
		/// Primary Address
		/// <para>Name: Address</para>
		/// <para>SF Type: address</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "address")]
		[Updateable(false), Createable(false)]
		public Address Address { get; set; }

		///<summary>
		/// Telephone Number
		/// <para>Name: Phone</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "phone")]
		public string Phone { get; set; }

		///<summary>
		/// Facsimile Number
		/// <para>Name: Fax</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fax")]
		public string Fax { get; set; }

		///<summary>
		/// International Dialing Code
		/// <para>Name: CountryAccessCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "countryAccessCode")]
		public string CountryAccessCode { get; set; }

		///<summary>
		/// Ownership Type Indicator
		/// <para>Name: PublicIndicator</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "publicIndicator")]
		public string PublicIndicator { get; set; }

		///<summary>
		/// Ticker Symbol
		/// <para>Name: StockSymbol</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "stockSymbol")]
		public string StockSymbol { get; set; }

		///<summary>
		/// Stock Exchange
		/// <para>Name: StockExchange</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "stockExchange")]
		public string StockExchange { get; set; }

		///<summary>
		/// Annual Sales Volume
		/// <para>Name: SalesVolume</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "salesVolume")]
		public double? SalesVolume { get; set; }

		///<summary>
		/// URL
		/// <para>Name: URL</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "uRL")]
		public string URL { get; set; }

		///<summary>
		/// Out Of Business Indicator
		/// <para>Name: OutOfBusiness</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "outOfBusiness")]
		public string OutOfBusiness { get; set; }

		///<summary>
		/// Number of Employees - Total
		/// <para>Name: EmployeesTotal</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "employeesTotal")]
		public double? EmployeesTotal { get; set; }

		///<summary>
		/// FIPS MSA Code
		/// <para>Name: FipsMsaCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fipsMsaCode")]
		public string FipsMsaCode { get; set; }

		///<summary>
		/// FIPS MSA Code Description
		/// <para>Name: FipsMsaDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fipsMsaDesc")]
		public string FipsMsaDesc { get; set; }

		///<summary>
		/// Primary Tradestyle
		/// <para>Name: TradeStyle1</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "tradeStyle1")]
		public string TradeStyle1 { get; set; }

		///<summary>
		/// Year Started
		/// <para>Name: YearStarted</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "yearStarted")]
		public string YearStarted { get; set; }

		///<summary>
		/// Mailing Street Address
		/// <para>Name: MailingStreet</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mailingStreet")]
		public string MailingStreet { get; set; }

		///<summary>
		/// Mailing City
		/// <para>Name: MailingCity</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mailingCity")]
		public string MailingCity { get; set; }

		///<summary>
		/// Mailing State
		/// <para>Name: MailingState</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mailingState")]
		public string MailingState { get; set; }

		///<summary>
		/// Mailing Postal Code
		/// <para>Name: MailingPostalCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mailingPostalCode")]
		public string MailingPostalCode { get; set; }

		///<summary>
		/// Mailing Country
		/// <para>Name: MailingCountry</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mailingCountry")]
		public string MailingCountry { get; set; }

		///<summary>
		/// Mailing Geocode Accuracy
		/// <para>Name: MailingGeocodeAccuracy</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mailingGeocodeAccuracy")]
		public string MailingGeocodeAccuracy { get; set; }

		///<summary>
		/// Mailing Address
		/// <para>Name: MailingAddress</para>
		/// <para>SF Type: address</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mailingAddress")]
		[Updateable(false), Createable(false)]
		public Address MailingAddress { get; set; }

		///<summary>
		/// Latitude
		/// <para>Name: Latitude</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "latitude")]
		public string Latitude { get; set; }

		///<summary>
		/// Longitude
		/// <para>Name: Longitude</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "longitude")]
		public string Longitude { get; set; }

		///<summary>
		/// Primary SIC Code
		/// <para>Name: PrimarySic</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "primarySic")]
		public string PrimarySic { get; set; }

		///<summary>
		/// Primary SIC Description
		/// <para>Name: PrimarySicDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "primarySicDesc")]
		public string PrimarySicDesc { get; set; }

		///<summary>
		/// Second SIC Code
		/// <para>Name: SecondSic</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "secondSic")]
		public string SecondSic { get; set; }

		///<summary>
		/// Second SIC Description
		/// <para>Name: SecondSicDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "secondSicDesc")]
		public string SecondSicDesc { get; set; }

		///<summary>
		/// Third SIC Code
		/// <para>Name: ThirdSic</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "thirdSic")]
		public string ThirdSic { get; set; }

		///<summary>
		/// Third SIC Description
		/// <para>Name: ThirdSicDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "thirdSicDesc")]
		public string ThirdSicDesc { get; set; }

		///<summary>
		/// Fourth SIC Code
		/// <para>Name: FourthSic</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fourthSic")]
		public string FourthSic { get; set; }

		///<summary>
		/// Fourth SIC Description
		/// <para>Name: FourthSicDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fourthSicDesc")]
		public string FourthSicDesc { get; set; }

		///<summary>
		/// Fifth SIC Code
		/// <para>Name: FifthSic</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fifthSic")]
		public string FifthSic { get; set; }

		///<summary>
		/// Fifth SIC Description
		/// <para>Name: FifthSicDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fifthSicDesc")]
		public string FifthSicDesc { get; set; }

		///<summary>
		/// Sixth SIC Code
		/// <para>Name: SixthSic</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sixthSic")]
		public string SixthSic { get; set; }

		///<summary>
		/// Sixth SIC Description
		/// <para>Name: SixthSicDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sixthSicDesc")]
		public string SixthSicDesc { get; set; }

		///<summary>
		/// Primary NAICS Code
		/// <para>Name: PrimaryNaics</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "primaryNaics")]
		public string PrimaryNaics { get; set; }

		///<summary>
		/// Primary NAICS Description
		/// <para>Name: PrimaryNaicsDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "primaryNaicsDesc")]
		public string PrimaryNaicsDesc { get; set; }

		///<summary>
		/// Second NAICS Code
		/// <para>Name: SecondNaics</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "secondNaics")]
		public string SecondNaics { get; set; }

		///<summary>
		/// Second NAICS Description
		/// <para>Name: SecondNaicsDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "secondNaicsDesc")]
		public string SecondNaicsDesc { get; set; }

		///<summary>
		/// Third NAICS Code
		/// <para>Name: ThirdNaics</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "thirdNaics")]
		public string ThirdNaics { get; set; }

		///<summary>
		/// Third NAICS Description
		/// <para>Name: ThirdNaicsDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "thirdNaicsDesc")]
		public string ThirdNaicsDesc { get; set; }

		///<summary>
		/// Fourth NAICS Code
		/// <para>Name: FourthNaics</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fourthNaics")]
		public string FourthNaics { get; set; }

		///<summary>
		/// Fourth NAICS Description
		/// <para>Name: FourthNaicsDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fourthNaicsDesc")]
		public string FourthNaicsDesc { get; set; }

		///<summary>
		/// Fifth NAICS Code
		/// <para>Name: FifthNaics</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fifthNaics")]
		public string FifthNaics { get; set; }

		///<summary>
		/// Fifth NAICS Description
		/// <para>Name: FifthNaicsDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fifthNaicsDesc")]
		public string FifthNaicsDesc { get; set; }

		///<summary>
		/// Sixth NAICS Code
		/// <para>Name: SixthNaics</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sixthNaics")]
		public string SixthNaics { get; set; }

		///<summary>
		/// Sixth NAICS Description
		/// <para>Name: SixthNaicsDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sixthNaicsDesc")]
		public string SixthNaicsDesc { get; set; }

		///<summary>
		/// Location Ownership Indicator
		/// <para>Name: OwnOrRent</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "ownOrRent")]
		public string OwnOrRent { get; set; }

		///<summary>
		/// Number of Employees - Location
		/// <para>Name: EmployeesHere</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "employeesHere")]
		public double? EmployeesHere { get; set; }

		///<summary>
		/// Number of Employees - Location Indicator
		/// <para>Name: EmployeesHereReliability</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "employeesHereReliability")]
		public string EmployeesHereReliability { get; set; }

		///<summary>
		/// Annual Sales Volume Indicator
		/// <para>Name: SalesVolumeReliability</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "salesVolumeReliability")]
		public string SalesVolumeReliability { get; set; }

		///<summary>
		/// Local Currency Code
		/// <para>Name: CurrencyCode</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "currencyCode")]
		public string CurrencyCode { get; set; }

		///<summary>
		/// Legal Structure
		/// <para>Name: LegalStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "legalStatus")]
		public string LegalStatus { get; set; }

		///<summary>
		/// Number of Employees - Global
		/// <para>Name: GlobalUltimateTotalEmployees</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "globalUltimateTotalEmployees")]
		public double? GlobalUltimateTotalEmployees { get; set; }

		///<summary>
		/// Number of Employees - Total Indicator
		/// <para>Name: EmployeesTotalReliability</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "employeesTotalReliability")]
		public string EmployeesTotalReliability { get; set; }

		///<summary>
		/// Minority-Owned Indicator
		/// <para>Name: MinorityOwned</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "minorityOwned")]
		public string MinorityOwned { get; set; }

		///<summary>
		/// Woman-Owned Indicator
		/// <para>Name: WomenOwned</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "womenOwned")]
		public string WomenOwned { get; set; }

		///<summary>
		/// Small Business Indicator
		/// <para>Name: SmallBusiness</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "smallBusiness")]
		public string SmallBusiness { get; set; }

		///<summary>
		/// Marketing Segmentation Cluster
		/// <para>Name: MarketingSegmentationCluster</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "marketingSegmentationCluster")]
		public string MarketingSegmentationCluster { get; set; }

		///<summary>
		/// Import/Export
		/// <para>Name: ImportExportAgent</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "importExportAgent")]
		public string ImportExportAgent { get; set; }

		///<summary>
		/// Subsidiary Indicator
		/// <para>Name: Subsidiary</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "subsidiary")]
		public string Subsidiary { get; set; }

		///<summary>
		/// Second Tradestyle
		/// <para>Name: TradeStyle2</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "tradeStyle2")]
		public string TradeStyle2 { get; set; }

		///<summary>
		/// Third Tradestyle
		/// <para>Name: TradeStyle3</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "tradeStyle3")]
		public string TradeStyle3 { get; set; }

		///<summary>
		/// Fourth Tradestyle
		/// <para>Name: TradeStyle4</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "tradeStyle4")]
		public string TradeStyle4 { get; set; }

		///<summary>
		/// Fifth Tradestyle
		/// <para>Name: TradeStyle5</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "tradeStyle5")]
		public string TradeStyle5 { get; set; }

		///<summary>
		/// National Identification Number
		/// <para>Name: NationalId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "nationalId")]
		public string NationalId { get; set; }

		///<summary>
		/// National Identification System
		/// <para>Name: NationalIdType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "nationalIdType")]
		public string NationalIdType { get; set; }

		///<summary>
		/// US Tax ID Number
		/// <para>Name: UsTaxId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "usTaxId")]
		public string UsTaxId { get; set; }

		///<summary>
		/// Geocode Accuracy
		/// <para>Name: GeoCodeAccuracy</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "geoCodeAccuracy")]
		public string GeoCodeAccuracy { get; set; }

		///<summary>
		/// Number of Business Family Members
		/// <para>Name: FamilyMembers</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "familyMembers")]
		public int? FamilyMembers { get; set; }

		///<summary>
		/// Delinquency Risk
		/// <para>Name: MarketingPreScreen</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "marketingPreScreen")]
		public string MarketingPreScreen { get; set; }

		///<summary>
		/// Global Ultimate D-U-N-S Number
		/// <para>Name: GlobalUltimateDunsNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "globalUltimateDunsNumber")]
		public string GlobalUltimateDunsNumber { get; set; }

		///<summary>
		/// Global Ultimate Business Name
		/// <para>Name: GlobalUltimateBusinessName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "globalUltimateBusinessName")]
		public string GlobalUltimateBusinessName { get; set; }

		///<summary>
		/// Parent Company D-U-N-S Number
		/// <para>Name: ParentOrHqDunsNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "parentOrHqDunsNumber")]
		public string ParentOrHqDunsNumber { get; set; }

		///<summary>
		/// Parent Company Business Name
		/// <para>Name: ParentOrHqBusinessName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "parentOrHqBusinessName")]
		public string ParentOrHqBusinessName { get; set; }

		///<summary>
		/// Domestic Ultimate D-U-N-S Number
		/// <para>Name: DomesticUltimateDunsNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "domesticUltimateDunsNumber")]
		public string DomesticUltimateDunsNumber { get; set; }

		///<summary>
		/// Domestic Ultimate Business Name
		/// <para>Name: DomesticUltimateBusinessName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "domesticUltimateBusinessName")]
		public string DomesticUltimateBusinessName { get; set; }

		///<summary>
		/// Location Type
		/// <para>Name: LocationStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "locationStatus")]
		public string LocationStatus { get; set; }

		///<summary>
		/// Local Currency ISO Code
		/// <para>Name: CompanyCurrencyIsoCode</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "companyCurrencyIsoCode")]
		public string CompanyCurrencyIsoCode { get; set; }

		///<summary>
		/// Company Description
		/// <para>Name: Description</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

		///<summary>
		/// Fortune 1000 Rank
		/// <para>Name: FortuneRank</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fortuneRank")]
		public int? FortuneRank { get; set; }

		///<summary>
		/// S&amp;P 500
		/// <para>Name: IncludedInSnP500</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "includedInSnP500")]
		public string IncludedInSnP500 { get; set; }

		///<summary>
		/// Location Size
		/// <para>Name: PremisesMeasure</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "premisesMeasure")]
		public int? PremisesMeasure { get; set; }

		///<summary>
		/// Location Size Accuracy
		/// <para>Name: PremisesMeasureReliability</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "premisesMeasureReliability")]
		public string PremisesMeasureReliability { get; set; }

		///<summary>
		/// Location Size Unit of Measure
		/// <para>Name: PremisesMeasureUnit</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "premisesMeasureUnit")]
		public string PremisesMeasureUnit { get; set; }

		///<summary>
		/// Employee Growth
		/// <para>Name: EmployeeQuantityGrowthRate</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "employeeQuantityGrowthRate")]
		public double? EmployeeQuantityGrowthRate { get; set; }

		///<summary>
		/// Annual Revenue Growth
		/// <para>Name: SalesTurnoverGrowthRate</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "salesTurnoverGrowthRate")]
		public double? SalesTurnoverGrowthRate { get; set; }

		///<summary>
		/// Primary SIC8 Code
		/// <para>Name: PrimarySic8</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "primarySic8")]
		public string PrimarySic8 { get; set; }

		///<summary>
		/// Primary SIC8 Description
		/// <para>Name: PrimarySic8Desc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "primarySic8Desc")]
		public string PrimarySic8Desc { get; set; }

		///<summary>
		/// Second SIC8 Code
		/// <para>Name: SecondSic8</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "secondSic8")]
		public string SecondSic8 { get; set; }

		///<summary>
		/// Second SIC8 Description 
		/// <para>Name: SecondSic8Desc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "secondSic8Desc")]
		public string SecondSic8Desc { get; set; }

		///<summary>
		/// Third SIC8 Code
		/// <para>Name: ThirdSic8</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "thirdSic8")]
		public string ThirdSic8 { get; set; }

		///<summary>
		/// Third SIC8 Description
		/// <para>Name: ThirdSic8Desc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "thirdSic8Desc")]
		public string ThirdSic8Desc { get; set; }

		///<summary>
		/// Fourth SIC8 Code
		/// <para>Name: FourthSic8</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fourthSic8")]
		public string FourthSic8 { get; set; }

		///<summary>
		/// Fourth SIC8 Description
		/// <para>Name: FourthSic8Desc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fourthSic8Desc")]
		public string FourthSic8Desc { get; set; }

		///<summary>
		/// Fifth SIC8 Code
		/// <para>Name: FifthSic8</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fifthSic8")]
		public string FifthSic8 { get; set; }

		///<summary>
		/// Fifth SIC8 Description
		/// <para>Name: FifthSic8Desc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fifthSic8Desc")]
		public string FifthSic8Desc { get; set; }

		///<summary>
		/// Sixth SIC8 Code
		/// <para>Name: SixthSic8</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sixthSic8")]
		public string SixthSic8 { get; set; }

		///<summary>
		/// Sixth SIC8 Description
		/// <para>Name: SixthSic8Desc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sixthSic8Desc")]
		public string SixthSic8Desc { get; set; }

		///<summary>
		/// Prior Year Number of Employees - Total
		/// <para>Name: PriorYearEmployees</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "priorYearEmployees")]
		public int? PriorYearEmployees { get; set; }

		///<summary>
		/// Prior Year Revenue
		/// <para>Name: PriorYearRevenue</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "priorYearRevenue")]
		public double? PriorYearRevenue { get; set; }

	}
}
