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
	/// Account Clean Info
	///<para>SObject Name: AccountCleanInfo</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfAccountCleanInfo : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "AccountCleanInfo"; }
		}

		///<summary>
		/// Account Clean Info ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Creatable(false)]
		public bool? IsDeleted { get; set; }

		///<summary>
		/// Account Clean Info Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(true), Creatable(false)]
		public string Name { get; set; }

		///<summary>
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

		///<summary>
		/// Created By ID
		/// <para>Name: CreatedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdById")]
		[Updateable(false), Creatable(false)]
		public string CreatedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: CreatedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "createdBy")]
		[Updateable(false), Creatable(false)]
		public SfUser CreatedBy { get; set; }

		///<summary>
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

		///<summary>
		/// Last Modified By ID
		/// <para>Name: LastModifiedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedById")]
		[Updateable(false), Creatable(false)]
		public string LastModifiedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: LastModifiedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedBy")]
		[Updateable(false), Creatable(false)]
		public SfUser LastModifiedBy { get; set; }

		///<summary>
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

		///<summary>
		/// Account ID
		/// <para>Name: AccountId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "accountId")]
		[Updateable(false), Creatable(false)]
		public string AccountId { get; set; }

		///<summary>
		/// ReferenceTo: Account
		/// <para>RelationshipName: Account</para>
		///</summary>
		[JsonProperty(PropertyName = "account")]
		[Updateable(false), Creatable(false)]
		public SfAccount Account { get; set; }

		///<summary>
		/// Last Matched Date
		/// <para>Name: LastMatchedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastMatchedDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? LastMatchedDate { get; set; }

		///<summary>
		/// Last Status Changed Date
		/// <para>Name: LastStatusChangedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastStatusChangedDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? LastStatusChangedDate { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: LastStatusChangedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastStatusChangedById")]
		[Updateable(false), Creatable(false)]
		public string LastStatusChangedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: LastStatusChangedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "lastStatusChangedBy")]
		[Updateable(false), Creatable(false)]
		public SfUser LastStatusChangedBy { get; set; }

		///<summary>
		/// Company Status in Salesforce
		/// <para>Name: IsInactive</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isInactive")]
		[Updateable(true), Creatable(false)]
		public bool? IsInactive { get; set; }

		///<summary>
		/// Company Name
		/// <para>Name: CompanyName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "companyName")]
		[Updateable(false), Creatable(false)]
		public string CompanyName { get; set; }

		///<summary>
		/// Phone
		/// <para>Name: Phone</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "phone")]
		[Updateable(false), Creatable(false)]
		public string Phone { get; set; }

		///<summary>
		/// Street
		/// <para>Name: Street</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "street")]
		[Updateable(false), Creatable(false)]
		public string Street { get; set; }

		///<summary>
		/// City
		/// <para>Name: City</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "city")]
		[Updateable(false), Creatable(false)]
		public string City { get; set; }

		///<summary>
		/// State
		/// <para>Name: State</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "state")]
		[Updateable(false), Creatable(false)]
		public string State { get; set; }

		///<summary>
		/// Zip
		/// <para>Name: PostalCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "postalCode")]
		[Updateable(false), Creatable(false)]
		public string PostalCode { get; set; }

		///<summary>
		/// Country
		/// <para>Name: Country</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "country")]
		[Updateable(false), Creatable(false)]
		public string Country { get; set; }

		///<summary>
		/// Latitude
		/// <para>Name: Latitude</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "latitude")]
		[Updateable(false), Creatable(false)]
		public double? Latitude { get; set; }

		///<summary>
		/// Longitude
		/// <para>Name: Longitude</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "longitude")]
		[Updateable(false), Creatable(false)]
		public double? Longitude { get; set; }

		///<summary>
		/// Geocode Accuracy
		/// <para>Name: GeocodeAccuracy</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "geocodeAccuracy")]
		[Updateable(false), Creatable(false)]
		public string GeocodeAccuracy { get; set; }

		///<summary>
		/// Address
		/// <para>Name: Address</para>
		/// <para>SF Type: address</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "address")]
		[Updateable(false), Creatable(false)]
		public Address Address { get; set; }

		///<summary>
		/// Website
		/// <para>Name: Website</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "website")]
		[Updateable(false), Creatable(false)]
		public string Website { get; set; }

		///<summary>
		/// Ticker Symbol
		/// <para>Name: TickerSymbol</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "tickerSymbol")]
		[Updateable(false), Creatable(false)]
		public string TickerSymbol { get; set; }

		///<summary>
		/// Annual Revenue
		/// <para>Name: AnnualRevenue</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "annualRevenue")]
		[Updateable(false), Creatable(false)]
		public decimal? AnnualRevenue { get; set; }

		///<summary>
		/// Number of Employees
		/// <para>Name: NumberOfEmployees</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "numberOfEmployees")]
		[Updateable(false), Creatable(false)]
		public int? NumberOfEmployees { get; set; }

		///<summary>
		/// Industry
		/// <para>Name: Industry</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "industry")]
		[Updateable(false), Creatable(false)]
		public string Industry { get; set; }

		///<summary>
		/// Ownership
		/// <para>Name: Ownership</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "ownership")]
		[Updateable(false), Creatable(false)]
		public string Ownership { get; set; }

		///<summary>
		/// D-U-N-S Number
		/// <para>Name: DunsNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dunsNumber")]
		[Updateable(false), Creatable(false)]
		public string DunsNumber { get; set; }

		///<summary>
		/// SIC Code
		/// <para>Name: Sic</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sic")]
		[Updateable(false), Creatable(false)]
		public string Sic { get; set; }

		///<summary>
		/// SIC Description
		/// <para>Name: SicDescription</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sicDescription")]
		[Updateable(false), Creatable(false)]
		public string SicDescription { get; set; }

		///<summary>
		/// NAICS Code
		/// <para>Name: NaicsCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "naicsCode")]
		[Updateable(false), Creatable(false)]
		public string NaicsCode { get; set; }

		///<summary>
		/// NAICS Description
		/// <para>Name: NaicsDescription</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "naicsDescription")]
		[Updateable(false), Creatable(false)]
		public string NaicsDescription { get; set; }

		///<summary>
		/// Year Started
		/// <para>Name: YearStarted</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "yearStarted")]
		[Updateable(false), Creatable(false)]
		public string YearStarted { get; set; }

		///<summary>
		/// Fax
		/// <para>Name: Fax</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fax")]
		[Updateable(false), Creatable(false)]
		public string Fax { get; set; }

		///<summary>
		/// Account Site
		/// <para>Name: AccountSite</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "accountSite")]
		[Updateable(false), Creatable(false)]
		public string AccountSite { get; set; }

		///<summary>
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		[Updateable(false), Creatable(false)]
		public string Description { get; set; }

		///<summary>
		/// Tradestyle
		/// <para>Name: Tradestyle</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "tradestyle")]
		[Updateable(false), Creatable(false)]
		public string Tradestyle { get; set; }

		///<summary>
		/// D&amp;B Company D-U-N-S Number
		/// <para>Name: DandBCompanyDunsNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dandBCompanyDunsNumber")]
		[Updateable(false), Creatable(false)]
		public string DandBCompanyDunsNumber { get; set; }

		///<summary>
		/// DUNSRight™ Match Grade
		/// <para>Name: DunsRightMatchGrade</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dunsRightMatchGrade")]
		[Updateable(false), Creatable(false)]
		public string DunsRightMatchGrade { get; set; }

		///<summary>
		/// DUNSRight™ Match Confidence
		/// <para>Name: DunsRightMatchConfidence</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dunsRightMatchConfidence")]
		[Updateable(false), Creatable(false)]
		public int? DunsRightMatchConfidence { get; set; }

		///<summary>
		/// Company Status per Data.com
		/// <para>Name: CompanyStatusDataDotCom</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "companyStatusDataDotCom")]
		[Updateable(false), Creatable(false)]
		public string CompanyStatusDataDotCom { get; set; }

		///<summary>
		/// Company Name is Reviewed
		/// <para>Name: IsReviewedCompanyName</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedCompanyName")]
		[Updateable(true), Creatable(false)]
		public bool? IsReviewedCompanyName { get; set; }

		///<summary>
		/// Phone is Reviewed
		/// <para>Name: IsReviewedPhone</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedPhone")]
		[Updateable(true), Creatable(false)]
		public bool? IsReviewedPhone { get; set; }

		///<summary>
		/// Address is Reviewed
		/// <para>Name: IsReviewedAddress</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedAddress")]
		[Updateable(true), Creatable(false)]
		public bool? IsReviewedAddress { get; set; }

		///<summary>
		/// Website is Reviewed
		/// <para>Name: IsReviewedWebsite</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedWebsite")]
		[Updateable(true), Creatable(false)]
		public bool? IsReviewedWebsite { get; set; }

		///<summary>
		/// Ticker Symbol is Reviewed
		/// <para>Name: IsReviewedTickerSymbol</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedTickerSymbol")]
		[Updateable(true), Creatable(false)]
		public bool? IsReviewedTickerSymbol { get; set; }

		///<summary>
		/// Annual Revenue is Reviewed
		/// <para>Name: IsReviewedAnnualRevenue</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedAnnualRevenue")]
		[Updateable(true), Creatable(false)]
		public bool? IsReviewedAnnualRevenue { get; set; }

		///<summary>
		/// Number of Employees is Reviewed
		/// <para>Name: IsReviewedNumberOfEmployees</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedNumberOfEmployees")]
		[Updateable(true), Creatable(false)]
		public bool? IsReviewedNumberOfEmployees { get; set; }

		///<summary>
		/// Industry is Reviewed
		/// <para>Name: IsReviewedIndustry</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedIndustry")]
		[Updateable(true), Creatable(false)]
		public bool? IsReviewedIndustry { get; set; }

		///<summary>
		/// Ownership is Reviewed
		/// <para>Name: IsReviewedOwnership</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedOwnership")]
		[Updateable(true), Creatable(false)]
		public bool? IsReviewedOwnership { get; set; }

		///<summary>
		/// D-U-N-S Number is Reviewed
		/// <para>Name: IsReviewedDunsNumber</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedDunsNumber")]
		[Updateable(true), Creatable(false)]
		public bool? IsReviewedDunsNumber { get; set; }

		///<summary>
		/// SIC Code is Reviewed
		/// <para>Name: IsReviewedSic</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedSic")]
		[Updateable(true), Creatable(false)]
		public bool? IsReviewedSic { get; set; }

		///<summary>
		/// SIC Description is Reviewed
		/// <para>Name: IsReviewedSicDescription</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedSicDescription")]
		[Updateable(true), Creatable(false)]
		public bool? IsReviewedSicDescription { get; set; }

		///<summary>
		/// NAICS Code is Reviewed
		/// <para>Name: IsReviewedNaicsCode</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedNaicsCode")]
		[Updateable(true), Creatable(false)]
		public bool? IsReviewedNaicsCode { get; set; }

		///<summary>
		/// NAICS Description is Reviewed
		/// <para>Name: IsReviewedNaicsDescription</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedNaicsDescription")]
		[Updateable(true), Creatable(false)]
		public bool? IsReviewedNaicsDescription { get; set; }

		///<summary>
		/// Year Started is Reviewed
		/// <para>Name: IsReviewedYearStarted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedYearStarted")]
		[Updateable(true), Creatable(false)]
		public bool? IsReviewedYearStarted { get; set; }

		///<summary>
		/// Fax is Reviewed
		/// <para>Name: IsReviewedFax</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedFax")]
		[Updateable(true), Creatable(false)]
		public bool? IsReviewedFax { get; set; }

		///<summary>
		/// Account Site is Reviewed
		/// <para>Name: IsReviewedAccountSite</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedAccountSite")]
		[Updateable(true), Creatable(false)]
		public bool? IsReviewedAccountSite { get; set; }

		///<summary>
		/// Description is Reviewed
		/// <para>Name: IsReviewedDescription</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedDescription")]
		[Updateable(true), Creatable(false)]
		public bool? IsReviewedDescription { get; set; }

		///<summary>
		/// Tradestyle is Reviewed
		/// <para>Name: IsReviewedTradestyle</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedTradestyle")]
		[Updateable(true), Creatable(false)]
		public bool? IsReviewedTradestyle { get; set; }

		///<summary>
		/// D&amp;B Company D-U-N-S Number is Reviewed
		/// <para>Name: IsReviewedDandBCompanyDunsNumber</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedDandBCompanyDunsNumber")]
		[Updateable(true), Creatable(false)]
		public bool? IsReviewedDandBCompanyDunsNumber { get; set; }

		///<summary>
		/// Company Name is Different
		/// <para>Name: IsDifferentCompanyName</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentCompanyName")]
		[Updateable(false), Creatable(false)]
		public bool? IsDifferentCompanyName { get; set; }

		///<summary>
		/// Phone is Different
		/// <para>Name: IsDifferentPhone</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentPhone")]
		[Updateable(false), Creatable(false)]
		public bool? IsDifferentPhone { get; set; }

		///<summary>
		/// Street is Different
		/// <para>Name: IsDifferentStreet</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentStreet")]
		[Updateable(false), Creatable(false)]
		public bool? IsDifferentStreet { get; set; }

		///<summary>
		/// City is Different
		/// <para>Name: IsDifferentCity</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentCity")]
		[Updateable(false), Creatable(false)]
		public bool? IsDifferentCity { get; set; }

		///<summary>
		/// State is Different
		/// <para>Name: IsDifferentState</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentState")]
		[Updateable(false), Creatable(false)]
		public bool? IsDifferentState { get; set; }

		///<summary>
		/// ZIP is Different
		/// <para>Name: IsDifferentPostalCode</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentPostalCode")]
		[Updateable(false), Creatable(false)]
		public bool? IsDifferentPostalCode { get; set; }

		///<summary>
		/// Country is Different
		/// <para>Name: IsDifferentCountry</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentCountry")]
		[Updateable(false), Creatable(false)]
		public bool? IsDifferentCountry { get; set; }

		///<summary>
		/// Website is Different
		/// <para>Name: IsDifferentWebsite</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentWebsite")]
		[Updateable(false), Creatable(false)]
		public bool? IsDifferentWebsite { get; set; }

		///<summary>
		/// Ticker Symbol is Different
		/// <para>Name: IsDifferentTickerSymbol</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentTickerSymbol")]
		[Updateable(false), Creatable(false)]
		public bool? IsDifferentTickerSymbol { get; set; }

		///<summary>
		/// Annual Revenue is Different
		/// <para>Name: IsDifferentAnnualRevenue</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentAnnualRevenue")]
		[Updateable(false), Creatable(false)]
		public bool? IsDifferentAnnualRevenue { get; set; }

		///<summary>
		/// Number of Employees is Different
		/// <para>Name: IsDifferentNumberOfEmployees</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentNumberOfEmployees")]
		[Updateable(false), Creatable(false)]
		public bool? IsDifferentNumberOfEmployees { get; set; }

		///<summary>
		/// Industry is Different
		/// <para>Name: IsDifferentIndustry</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentIndustry")]
		[Updateable(false), Creatable(false)]
		public bool? IsDifferentIndustry { get; set; }

		///<summary>
		/// Ownership is Different
		/// <para>Name: IsDifferentOwnership</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentOwnership")]
		[Updateable(false), Creatable(false)]
		public bool? IsDifferentOwnership { get; set; }

		///<summary>
		/// D-U-N-S Number is Different
		/// <para>Name: IsDifferentDunsNumber</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentDunsNumber")]
		[Updateable(false), Creatable(false)]
		public bool? IsDifferentDunsNumber { get; set; }

		///<summary>
		/// SIC Code is Different
		/// <para>Name: IsDifferentSic</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentSic")]
		[Updateable(false), Creatable(false)]
		public bool? IsDifferentSic { get; set; }

		///<summary>
		/// SIC Description is Different
		/// <para>Name: IsDifferentSicDescription</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentSicDescription")]
		[Updateable(false), Creatable(false)]
		public bool? IsDifferentSicDescription { get; set; }

		///<summary>
		/// NAICS Code is Different
		/// <para>Name: IsDifferentNaicsCode</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentNaicsCode")]
		[Updateable(false), Creatable(false)]
		public bool? IsDifferentNaicsCode { get; set; }

		///<summary>
		/// NAICS Description is Different
		/// <para>Name: IsDifferentNaicsDescription</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentNaicsDescription")]
		[Updateable(false), Creatable(false)]
		public bool? IsDifferentNaicsDescription { get; set; }

		///<summary>
		/// Year Started is Different
		/// <para>Name: IsDifferentYearStarted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentYearStarted")]
		[Updateable(false), Creatable(false)]
		public bool? IsDifferentYearStarted { get; set; }

		///<summary>
		/// Fax is Different
		/// <para>Name: IsDifferentFax</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentFax")]
		[Updateable(false), Creatable(false)]
		public bool? IsDifferentFax { get; set; }

		///<summary>
		/// Account Site is Different
		/// <para>Name: IsDifferentAccountSite</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentAccountSite")]
		[Updateable(false), Creatable(false)]
		public bool? IsDifferentAccountSite { get; set; }

		///<summary>
		/// Description is Different
		/// <para>Name: IsDifferentDescription</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentDescription")]
		[Updateable(false), Creatable(false)]
		public bool? IsDifferentDescription { get; set; }

		///<summary>
		/// Tradestyle is Different
		/// <para>Name: IsDifferentTradestyle</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentTradestyle")]
		[Updateable(false), Creatable(false)]
		public bool? IsDifferentTradestyle { get; set; }

		///<summary>
		/// D&amp;B Company D-U-N-S Number is Different
		/// <para>Name: IsDifferentDandBCompanyDunsNumber</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentDandBCompanyDunsNumber")]
		[Updateable(false), Creatable(false)]
		public bool? IsDifferentDandBCompanyDunsNumber { get; set; }

		///<summary>
		/// State Code is Different
		/// <para>Name: IsDifferentStateCode</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentStateCode")]
		[Updateable(false), Creatable(false)]
		public bool? IsDifferentStateCode { get; set; }

		///<summary>
		/// Country Code is Different
		/// <para>Name: IsDifferentCountryCode</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentCountryCode")]
		[Updateable(false), Creatable(false)]
		public bool? IsDifferentCountryCode { get; set; }

		///<summary>
		/// Cleaned by Job
		/// <para>Name: CleanedByJob</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "cleanedByJob")]
		[Updateable(false), Creatable(false)]
		public bool? CleanedByJob { get; set; }

		///<summary>
		/// Cleaned by User
		/// <para>Name: CleanedByUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "cleanedByUser")]
		[Updateable(false), Creatable(false)]
		public bool? CleanedByUser { get; set; }

		///<summary>
		/// Company Name is Flagged Wrong
		/// <para>Name: IsFlaggedWrongCompanyName</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongCompanyName")]
		[Updateable(true), Creatable(false)]
		public bool? IsFlaggedWrongCompanyName { get; set; }

		///<summary>
		/// Phone is Flagged Wrong
		/// <para>Name: IsFlaggedWrongPhone</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongPhone")]
		[Updateable(true), Creatable(false)]
		public bool? IsFlaggedWrongPhone { get; set; }

		///<summary>
		/// Address is Flagged Wrong
		/// <para>Name: IsFlaggedWrongAddress</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongAddress")]
		[Updateable(true), Creatable(false)]
		public bool? IsFlaggedWrongAddress { get; set; }

		///<summary>
		/// Website is Flagged Wrong
		/// <para>Name: IsFlaggedWrongWebsite</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongWebsite")]
		[Updateable(true), Creatable(false)]
		public bool? IsFlaggedWrongWebsite { get; set; }

		///<summary>
		/// Ticker Symbol is Flagged Wrong
		/// <para>Name: IsFlaggedWrongTickerSymbol</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongTickerSymbol")]
		[Updateable(true), Creatable(false)]
		public bool? IsFlaggedWrongTickerSymbol { get; set; }

		///<summary>
		/// Annual Revenue is Flagged Wrong
		/// <para>Name: IsFlaggedWrongAnnualRevenue</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongAnnualRevenue")]
		[Updateable(true), Creatable(false)]
		public bool? IsFlaggedWrongAnnualRevenue { get; set; }

		///<summary>
		/// Number of Employees is Flagged Wrong
		/// <para>Name: IsFlaggedWrongNumberOfEmployees</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongNumberOfEmployees")]
		[Updateable(true), Creatable(false)]
		public bool? IsFlaggedWrongNumberOfEmployees { get; set; }

		///<summary>
		/// Industry is Flagged Wrong
		/// <para>Name: IsFlaggedWrongIndustry</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongIndustry")]
		[Updateable(true), Creatable(false)]
		public bool? IsFlaggedWrongIndustry { get; set; }

		///<summary>
		/// Ownership is Flagged Wrong
		/// <para>Name: IsFlaggedWrongOwnership</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongOwnership")]
		[Updateable(true), Creatable(false)]
		public bool? IsFlaggedWrongOwnership { get; set; }

		///<summary>
		/// D-U-N-S Number is Flagged Wrong
		/// <para>Name: IsFlaggedWrongDunsNumber</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongDunsNumber")]
		[Updateable(true), Creatable(false)]
		public bool? IsFlaggedWrongDunsNumber { get; set; }

		///<summary>
		/// SIC Code is Flagged Wrong
		/// <para>Name: IsFlaggedWrongSic</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongSic")]
		[Updateable(true), Creatable(false)]
		public bool? IsFlaggedWrongSic { get; set; }

		///<summary>
		/// SIC Description is Flagged Wrong
		/// <para>Name: IsFlaggedWrongSicDescription</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongSicDescription")]
		[Updateable(true), Creatable(false)]
		public bool? IsFlaggedWrongSicDescription { get; set; }

		///<summary>
		/// NAICS Code is Flagged Wrong
		/// <para>Name: IsFlaggedWrongNaicsCode</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongNaicsCode")]
		[Updateable(true), Creatable(false)]
		public bool? IsFlaggedWrongNaicsCode { get; set; }

		///<summary>
		/// NAICS Description is Flagged Wrong
		/// <para>Name: IsFlaggedWrongNaicsDescription</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongNaicsDescription")]
		[Updateable(true), Creatable(false)]
		public bool? IsFlaggedWrongNaicsDescription { get; set; }

		///<summary>
		/// Year Started is Flagged Wrong
		/// <para>Name: IsFlaggedWrongYearStarted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongYearStarted")]
		[Updateable(true), Creatable(false)]
		public bool? IsFlaggedWrongYearStarted { get; set; }

		///<summary>
		/// Fax is Flagged Wrong
		/// <para>Name: IsFlaggedWrongFax</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongFax")]
		[Updateable(true), Creatable(false)]
		public bool? IsFlaggedWrongFax { get; set; }

		///<summary>
		/// Account Site is Flagged Wrong
		/// <para>Name: IsFlaggedWrongAccountSite</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongAccountSite")]
		[Updateable(true), Creatable(false)]
		public bool? IsFlaggedWrongAccountSite { get; set; }

		///<summary>
		/// Description is Flagged Wrong
		/// <para>Name: IsFlaggedWrongDescription</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongDescription")]
		[Updateable(true), Creatable(false)]
		public bool? IsFlaggedWrongDescription { get; set; }

		///<summary>
		/// Tradestyle is Flagged Wrong
		/// <para>Name: IsFlaggedWrongTradestyle</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongTradestyle")]
		[Updateable(true), Creatable(false)]
		public bool? IsFlaggedWrongTradestyle { get; set; }

		///<summary>
		/// Data.com ID
		/// <para>Name: DataDotComId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dataDotComId")]
		[Updateable(false), Creatable(false)]
		public string DataDotComId { get; set; }

	}
}
