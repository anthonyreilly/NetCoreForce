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
	/// Order
	///<para>SObject Name: Order</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfOrder : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "Order"; }
		}

		///<summary>
		/// Order ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Owner ID
		/// <para>Name: OwnerId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "ownerId")]
		public string OwnerId { get; set; }

		///<summary>
		/// Contract ID
		/// <para>Name: ContractId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contractId")]
		public string ContractId { get; set; }

		///<summary>
		/// ReferenceTo: Contract
		/// <para>RelationshipName: Contract</para>
		///</summary>
		[JsonProperty(PropertyName = "contract")]
		[Updateable(false), Createable(false)]
		public SfContract Contract { get; set; }

		///<summary>
		/// Account ID
		/// <para>Name: AccountId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "accountId")]
		public string AccountId { get; set; }

		///<summary>
		/// ReferenceTo: Account
		/// <para>RelationshipName: Account</para>
		///</summary>
		[JsonProperty(PropertyName = "account")]
		[Updateable(false), Createable(false)]
		public SfAccount Account { get; set; }

		///<summary>
		/// Price Book ID
		/// <para>Name: Pricebook2Id</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "pricebook2Id")]
		public string Pricebook2Id { get; set; }

		///<summary>
		/// ReferenceTo: Pricebook2
		/// <para>RelationshipName: Pricebook2</para>
		///</summary>
		[JsonProperty(PropertyName = "pricebook2")]
		[Updateable(false), Createable(false)]
		public SfPricebook2 Pricebook2 { get; set; }

		///<summary>
		/// Order ID
		/// <para>Name: OriginalOrderId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "originalOrderId")]
		[Updateable(false), Createable(true)]
		public string OriginalOrderId { get; set; }

		///<summary>
		/// ReferenceTo: Order
		/// <para>RelationshipName: OriginalOrder</para>
		///</summary>
		[JsonProperty(PropertyName = "originalOrder")]
		[Updateable(false), Createable(false)]
		public SfOrder OriginalOrder { get; set; }

		///<summary>
		/// Order Start Date
		/// <para>Name: EffectiveDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "effectiveDate")]
		public DateTime? EffectiveDate { get; set; }

		///<summary>
		/// Order End Date
		/// <para>Name: EndDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "endDate")]
		public DateTime? EndDate { get; set; }

		///<summary>
		/// Reduction Order
		/// <para>Name: IsReductionOrder</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReductionOrder")]
		[Updateable(false), Createable(true)]
		public bool? IsReductionOrder { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		public string Status { get; set; }

		///<summary>
		/// Internal Comments
		/// <para>Name: Description</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

		///<summary>
		/// Customer Authorized By ID
		/// <para>Name: CustomerAuthorizedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "customerAuthorizedById")]
		public string CustomerAuthorizedById { get; set; }

		///<summary>
		/// ReferenceTo: Contact
		/// <para>RelationshipName: CustomerAuthorizedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "customerAuthorizedBy")]
		[Updateable(false), Createable(false)]
		public SfContact CustomerAuthorizedBy { get; set; }

		///<summary>
		/// Customer Authorized Date
		/// <para>Name: CustomerAuthorizedDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "customerAuthorizedDate")]
		public DateTime? CustomerAuthorizedDate { get; set; }

		///<summary>
		/// Company Authorized By ID
		/// <para>Name: CompanyAuthorizedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "companyAuthorizedById")]
		public string CompanyAuthorizedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: CompanyAuthorizedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "companyAuthorizedBy")]
		[Updateable(false), Createable(false)]
		public SfUser CompanyAuthorizedBy { get; set; }

		///<summary>
		/// Company Authorized Date
		/// <para>Name: CompanyAuthorizedDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "companyAuthorizedDate")]
		public DateTime? CompanyAuthorizedDate { get; set; }

		///<summary>
		/// Order Type
		/// <para>Name: Type</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		public string Type { get; set; }

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
		/// Order Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		///<summary>
		/// PO Date
		/// <para>Name: PoDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "poDate")]
		public DateTime? PoDate { get; set; }

		///<summary>
		/// PO Number
		/// <para>Name: PoNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "poNumber")]
		public string PoNumber { get; set; }

		///<summary>
		/// Order Reference Number
		/// <para>Name: OrderReferenceNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "orderReferenceNumber")]
		public string OrderReferenceNumber { get; set; }

		///<summary>
		/// Bill To Contact ID
		/// <para>Name: BillToContactId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "billToContactId")]
		public string BillToContactId { get; set; }

		///<summary>
		/// ReferenceTo: Contact
		/// <para>RelationshipName: BillToContact</para>
		///</summary>
		[JsonProperty(PropertyName = "billToContact")]
		[Updateable(false), Createable(false)]
		public SfContact BillToContact { get; set; }

		///<summary>
		/// Ship To Contact ID
		/// <para>Name: ShipToContactId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "shipToContactId")]
		public string ShipToContactId { get; set; }

		///<summary>
		/// ReferenceTo: Contact
		/// <para>RelationshipName: ShipToContact</para>
		///</summary>
		[JsonProperty(PropertyName = "shipToContact")]
		[Updateable(false), Createable(false)]
		public SfContact ShipToContact { get; set; }

		///<summary>
		/// Activated Date
		/// <para>Name: ActivatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "activatedDate")]
		[Updateable(true), Createable(false)]
		public DateTimeOffset? ActivatedDate { get; set; }

		///<summary>
		/// Activated By ID
		/// <para>Name: ActivatedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "activatedById")]
		[Updateable(true), Createable(false)]
		public string ActivatedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: ActivatedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "activatedBy")]
		[Updateable(false), Createable(false)]
		public SfUser ActivatedBy { get; set; }

		///<summary>
		/// Status Category
		/// <para>Name: StatusCode</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "statusCode")]
		[Updateable(true), Createable(false)]
		public string StatusCode { get; set; }

		///<summary>
		/// Order Number
		/// <para>Name: OrderNumber</para>
		/// <para>SF Type: string</para>
		/// <para>AutoNumber field</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "orderNumber")]
		[Updateable(false), Createable(false)]
		public string OrderNumber { get; set; }

		///<summary>
		/// Order Amount
		/// <para>Name: TotalAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "totalAmount")]
		[Updateable(false), Createable(false)]
		public decimal? TotalAmount { get; set; }

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
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Createable(false)]
		public bool? IsDeleted { get; set; }

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

	}
}
