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
	/// Account
	///<para>SObject Name: Account</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfAccount : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "Account"; }
		}

		///<summary>
		/// Account ID
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
		/// Master Record ID
		/// <para>Name: MasterRecordId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "masterRecordId")]
		[Updateable(false), Createable(false)]
		public string MasterRecordId { get; set; }

		///<summary>
		/// ReferenceTo: Account
		/// <para>RelationshipName: MasterRecord</para>
		///</summary>
		[JsonProperty(PropertyName = "masterRecord")]
		[Updateable(false), Createable(false)]
		public SfAccount MasterRecord { get; set; }

		///<summary>
		/// Account Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		///<summary>
		/// Account Type
		/// <para>Name: Type</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		public string Type { get; set; }

		///<summary>
		/// Parent Account ID
		/// <para>Name: ParentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "parentId")]
		public string ParentId { get; set; }

		///<summary>
		/// ReferenceTo: Account
		/// <para>RelationshipName: Parent</para>
		///</summary>
		[JsonProperty(PropertyName = "parent")]
		[Updateable(false), Createable(false)]
		public SfAccount Parent { get; set; }

		///<summary>
		/// Billing Street
		/// <para>Name: BillingStreet</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "billingStreet")]
		public string BillingStreet { get; set; }

		///<summary>
		/// Billing City
		/// <para>Name: BillingCity</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "billingCity")]
		public string BillingCity { get; set; }

		///<summary>
		/// Billing State/Province
		/// <para>Name: BillingState</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "billingState")]
		public string BillingState { get; set; }

		///<summary>
		/// Billing Zip/Postal Code
		/// <para>Name: BillingPostalCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "billingPostalCode")]
		public string BillingPostalCode { get; set; }

		///<summary>
		/// Billing Country
		/// <para>Name: BillingCountry</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "billingCountry")]
		public string BillingCountry { get; set; }

		///<summary>
		/// Billing Latitude
		/// <para>Name: BillingLatitude</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "billingLatitude")]
		public double? BillingLatitude { get; set; }

		///<summary>
		/// Billing Longitude
		/// <para>Name: BillingLongitude</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "billingLongitude")]
		public double? BillingLongitude { get; set; }

		///<summary>
		/// Billing Geocode Accuracy
		/// <para>Name: BillingGeocodeAccuracy</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "billingGeocodeAccuracy")]
		public string BillingGeocodeAccuracy { get; set; }

		///<summary>
		/// Billing Address
		/// <para>Name: BillingAddress</para>
		/// <para>SF Type: address</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "billingAddress")]
		[Updateable(false), Createable(false)]
		public Address BillingAddress { get; set; }

		///<summary>
		/// Shipping Street
		/// <para>Name: ShippingStreet</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "shippingStreet")]
		public string ShippingStreet { get; set; }

		///<summary>
		/// Shipping City
		/// <para>Name: ShippingCity</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "shippingCity")]
		public string ShippingCity { get; set; }

		///<summary>
		/// Shipping State/Province
		/// <para>Name: ShippingState</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "shippingState")]
		public string ShippingState { get; set; }

		///<summary>
		/// Shipping Zip/Postal Code
		/// <para>Name: ShippingPostalCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "shippingPostalCode")]
		public string ShippingPostalCode { get; set; }

		///<summary>
		/// Shipping Country
		/// <para>Name: ShippingCountry</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "shippingCountry")]
		public string ShippingCountry { get; set; }

		///<summary>
		/// Shipping Latitude
		/// <para>Name: ShippingLatitude</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "shippingLatitude")]
		public double? ShippingLatitude { get; set; }

		///<summary>
		/// Shipping Longitude
		/// <para>Name: ShippingLongitude</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "shippingLongitude")]
		public double? ShippingLongitude { get; set; }

		///<summary>
		/// Shipping Geocode Accuracy
		/// <para>Name: ShippingGeocodeAccuracy</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "shippingGeocodeAccuracy")]
		public string ShippingGeocodeAccuracy { get; set; }

		///<summary>
		/// Shipping Address
		/// <para>Name: ShippingAddress</para>
		/// <para>SF Type: address</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "shippingAddress")]
		[Updateable(false), Createable(false)]
		public Address ShippingAddress { get; set; }

		///<summary>
		/// Account Phone
		/// <para>Name: Phone</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "phone")]
		public string Phone { get; set; }

		///<summary>
		/// Account Fax
		/// <para>Name: Fax</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fax")]
		public string Fax { get; set; }

		///<summary>
		/// Account Number
		/// <para>Name: AccountNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "accountNumber")]
		public string AccountNumber { get; set; }

		///<summary>
		/// Website
		/// <para>Name: Website</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "website")]
		public string Website { get; set; }

		///<summary>
		/// Photo URL
		/// <para>Name: PhotoUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "photoUrl")]
		[Updateable(false), Createable(false)]
		public string PhotoUrl { get; set; }

		///<summary>
		/// SIC Code
		/// <para>Name: Sic</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sic")]
		public string Sic { get; set; }

		///<summary>
		/// Industry
		/// <para>Name: Industry</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "industry")]
		public string Industry { get; set; }

		///<summary>
		/// Annual Revenue
		/// <para>Name: AnnualRevenue</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "annualRevenue")]
		public decimal? AnnualRevenue { get; set; }

		///<summary>
		/// Employees
		/// <para>Name: NumberOfEmployees</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "numberOfEmployees")]
		public int? NumberOfEmployees { get; set; }

		///<summary>
		/// Ownership
		/// <para>Name: Ownership</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "ownership")]
		public string Ownership { get; set; }

		///<summary>
		/// Ticker Symbol
		/// <para>Name: TickerSymbol</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "tickerSymbol")]
		public string TickerSymbol { get; set; }

		///<summary>
		/// Account Description
		/// <para>Name: Description</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

		///<summary>
		/// Account Rating
		/// <para>Name: Rating</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "rating")]
		public string Rating { get; set; }

		///<summary>
		/// Account Site
		/// <para>Name: Site</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "site")]
		public string Site { get; set; }

		///<summary>
		/// Owner ID
		/// <para>Name: OwnerId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "ownerId")]
		public string OwnerId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: Owner</para>
		///</summary>
		[JsonProperty(PropertyName = "owner")]
		[Updateable(false), Createable(false)]
		public SfUser Owner { get; set; }

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
		/// Last Activity
		/// <para>Name: LastActivityDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastActivityDate")]
		[Updateable(false), Createable(false)]
		public DateTime? LastActivityDate { get; set; }

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
		/// Data.com Key
		/// <para>Name: Jigsaw</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "jigsaw")]
		public string Jigsaw { get; set; }

		///<summary>
		/// Jigsaw Company ID
		/// <para>Name: JigsawCompanyId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "jigsawCompanyId")]
		[Updateable(false), Createable(false)]
		public string JigsawCompanyId { get; set; }

		///<summary>
		/// Clean Status
		/// <para>Name: CleanStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "cleanStatus")]
		public string CleanStatus { get; set; }

		///<summary>
		/// Account Source
		/// <para>Name: AccountSource</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "accountSource")]
		public string AccountSource { get; set; }

		///<summary>
		/// D-U-N-S Number
		/// <para>Name: DunsNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dunsNumber")]
		public string DunsNumber { get; set; }

		///<summary>
		/// Tradestyle
		/// <para>Name: Tradestyle</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "tradestyle")]
		public string Tradestyle { get; set; }

		///<summary>
		/// NAICS Code
		/// <para>Name: NaicsCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "naicsCode")]
		public string NaicsCode { get; set; }

		///<summary>
		/// NAICS Description
		/// <para>Name: NaicsDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "naicsDesc")]
		public string NaicsDesc { get; set; }

		///<summary>
		/// Year Started
		/// <para>Name: YearStarted</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "yearStarted")]
		public string YearStarted { get; set; }

		///<summary>
		/// SIC Description
		/// <para>Name: SicDesc</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sicDesc")]
		public string SicDesc { get; set; }

		///<summary>
		/// D&amp;B Company ID
		/// <para>Name: DandbCompanyId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dandbCompanyId")]
		public string DandbCompanyId { get; set; }

		///<summary>
		/// ReferenceTo: DandBCompany
		/// <para>RelationshipName: DandbCompany</para>
		///</summary>
		[JsonProperty(PropertyName = "dandbCompany")]
		[Updateable(false), Createable(false)]
		public SfDandBCompany DandbCompany { get; set; }

	}
}
