// SF API version v67.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Partner Subscriber Offer
	///<para>SObject Name: SfdcPartnerSbscrOffer</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfSfdcPartnerSbscrOffer : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "SfdcPartnerSbscrOffer"; }
		}

		///<summary>
		/// Partner Subscriber Offer ID
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
		/// Offer Number
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
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
		/// Partner Org
		/// <para>Name: PartnerOrg</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "partnerOrg")]
		[Updateable(false), Createable(false)]
		public string PartnerOrg { get; set; }

		///<summary>
		/// Provider Name
		/// <para>Name: PartnerCompanyName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "partnerCompanyName")]
		[Updateable(false), Createable(false)]
		public string PartnerCompanyName { get; set; }

		///<summary>
		/// Customer Name
		/// <para>Name: CustomerName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "customerName")]
		[Updateable(false), Createable(false)]
		public string CustomerName { get; set; }

		///<summary>
		/// Offer Type
		/// <para>Name: OfferType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "offerType")]
		[Updateable(false), Createable(false)]
		public string OfferType { get; set; }

		///<summary>
		/// Terms and Conditions
		/// <para>Name: TermsAndConditions</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "termsAndConditions")]
		[Updateable(false), Createable(false)]
		public string TermsAndConditions { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		[Updateable(false), Createable(false)]
		public string Status { get; set; }

		///<summary>
		/// Contract Term (Months)
		/// <para>Name: ContractTerm</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contractTerm")]
		[Updateable(false), Createable(false)]
		public int? ContractTerm { get; set; }

		///<summary>
		/// Service Start Date
		/// <para>Name: ServiceStartDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "serviceStartDate")]
		[Updateable(false), Createable(false)]
		public DateTime? ServiceStartDate { get; set; }

		///<summary>
		/// Service End Date
		/// <para>Name: ServiceEndDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "serviceEndDate")]
		[Updateable(false), Createable(false)]
		public DateTime? ServiceEndDate { get; set; }

		///<summary>
		/// Customer Billing Street
		/// <para>Name: CustBillingStreet</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "custBillingStreet")]
		[Updateable(false), Createable(false)]
		public string CustBillingStreet { get; set; }

		///<summary>
		/// Customer Billing City
		/// <para>Name: CustBillingCity</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "custBillingCity")]
		[Updateable(false), Createable(false)]
		public string CustBillingCity { get; set; }

		///<summary>
		/// Customer Billing State
		/// <para>Name: CustBillingState</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "custBillingState")]
		[Updateable(false), Createable(false)]
		public string CustBillingState { get; set; }

		///<summary>
		/// Customer Billing Postal Code
		/// <para>Name: CustBillingPostalCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "custBillingPostalCode")]
		[Updateable(false), Createable(false)]
		public string CustBillingPostalCode { get; set; }

		///<summary>
		/// Customer Billing Country
		/// <para>Name: CustBillingCountry</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "custBillingCountry")]
		[Updateable(false), Createable(false)]
		public string CustBillingCountry { get; set; }

		///<summary>
		/// Customer Billing Latitude
		/// <para>Name: CustBillingLatitude</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "custBillingLatitude")]
		[Updateable(false), Createable(false)]
		public double? CustBillingLatitude { get; set; }

		///<summary>
		/// Customer Billing Longitude
		/// <para>Name: CustBillingLongitude</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "custBillingLongitude")]
		[Updateable(false), Createable(false)]
		public double? CustBillingLongitude { get; set; }

		///<summary>
		/// Customer Billing Geocode Accuracy
		/// <para>Name: CustBillingGeocodeAccuracy</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "custBillingGeocodeAccuracy")]
		[Updateable(false), Createable(false)]
		public string CustBillingGeocodeAccuracy { get; set; }

		///<summary>
		/// Customer Billing Address
		/// <para>Name: CustBillingAddress</para>
		/// <para>SF Type: address</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "custBillingAddress")]
		[Updateable(false), Createable(false)]
		public Address CustBillingAddress { get; set; }

		///<summary>
		/// Customer Shipping Street
		/// <para>Name: CustShippingStreet</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "custShippingStreet")]
		[Updateable(false), Createable(false)]
		public string CustShippingStreet { get; set; }

		///<summary>
		/// Customer Shipping City
		/// <para>Name: CustShippingCity</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "custShippingCity")]
		[Updateable(false), Createable(false)]
		public string CustShippingCity { get; set; }

		///<summary>
		/// Customer Shipping State
		/// <para>Name: CustShippingState</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "custShippingState")]
		[Updateable(false), Createable(false)]
		public string CustShippingState { get; set; }

		///<summary>
		/// Customer Shipping Postal Code
		/// <para>Name: CustShippingPostalCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "custShippingPostalCode")]
		[Updateable(false), Createable(false)]
		public string CustShippingPostalCode { get; set; }

		///<summary>
		/// Customer Shipping Country
		/// <para>Name: CustShippingCountry</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "custShippingCountry")]
		[Updateable(false), Createable(false)]
		public string CustShippingCountry { get; set; }

		///<summary>
		/// Customer Shipping Latitude
		/// <para>Name: CustShippingLatitude</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "custShippingLatitude")]
		[Updateable(false), Createable(false)]
		public double? CustShippingLatitude { get; set; }

		///<summary>
		/// Customer Shipping Longitude
		/// <para>Name: CustShippingLongitude</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "custShippingLongitude")]
		[Updateable(false), Createable(false)]
		public double? CustShippingLongitude { get; set; }

		///<summary>
		/// Customer Shipping Geocode Accuracy
		/// <para>Name: CustShippingGeocodeAccuracy</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "custShippingGeocodeAccuracy")]
		[Updateable(false), Createable(false)]
		public string CustShippingGeocodeAccuracy { get; set; }

		///<summary>
		/// Customer Shipping Address
		/// <para>Name: CustShippingAddress</para>
		/// <para>SF Type: address</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "custShippingAddress")]
		[Updateable(false), Createable(false)]
		public Address CustShippingAddress { get; set; }

		///<summary>
		/// Billing Email Address
		/// <para>Name: CustomerBillingEmailAddress</para>
		/// <para>SF Type: email</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "customerBillingEmailAddress")]
		[Updateable(false), Createable(false)]
		public string CustomerBillingEmailAddress { get; set; }

		///<summary>
		/// Subtotal
		/// <para>Name: SubTotal</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "subTotal")]
		[Updateable(false), Createable(false)]
		public decimal? SubTotal { get; set; }

		///<summary>
		/// Customer PO Number
		/// <para>Name: CustomerPurchaseOrderNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "customerPurchaseOrderNumber")]
		[Updateable(false), Createable(false)]
		public string CustomerPurchaseOrderNumber { get; set; }

		///<summary>
		/// Offer Recipient Email Address
		/// <para>Name: CustomerEmailAddress</para>
		/// <para>SF Type: email</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "customerEmailAddress")]
		[Updateable(false), Createable(false)]
		public string CustomerEmailAddress { get; set; }

		///<summary>
		/// Billing Lead Time (Days)
		/// <para>Name: OrderPrebillDays</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "orderPrebillDays")]
		[Updateable(false), Createable(false)]
		public int? OrderPrebillDays { get; set; }

		///<summary>
		/// Billing Frequency (Months)
		/// <para>Name: BillingFrequency</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "billingFrequency")]
		[Updateable(false), Createable(false)]
		public string BillingFrequency { get; set; }

		///<summary>
		/// Payment Method
		/// <para>Name: PaymentMethod</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentMethod")]
		[Updateable(false), Createable(false)]
		public string PaymentMethod { get; set; }

		///<summary>
		/// Valid Until
		/// <para>Name: ExpirationDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "expirationDate")]
		[Updateable(false), Createable(false)]
		public DateTime? ExpirationDate { get; set; }

		///<summary>
		/// Customer Payment Terms
		/// <para>Name: CustomerPaymentTerms</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "customerPaymentTerms")]
		[Updateable(false), Createable(false)]
		public string CustomerPaymentTerms { get; set; }

		///<summary>
		/// Sync To PBO Last Updated
		/// <para>Name: SyncToPboLastUpdate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "syncToPboLastUpdate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? SyncToPboLastUpdate { get; set; }

		///<summary>
		/// Sync To PBO Status
		/// <para>Name: SyncToPboStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "syncToPboStatus")]
		[Updateable(false), Createable(false)]
		public string SyncToPboStatus { get; set; }

		///<summary>
		/// Partner Offer
		/// <para>Name: PartnerOffer</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "partnerOffer")]
		[Updateable(false), Createable(false)]
		public string PartnerOffer { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: RespondingUserId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "respondingUserId")]
		[Updateable(false), Createable(false)]
		public string RespondingUserId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: RespondingUser</para>
		///</summary>
		[JsonProperty(PropertyName = "respondingUser")]
		[Updateable(false), Createable(false)]
		public SfUser RespondingUser { get; set; }

		///<summary>
		/// Service Term
		/// <para>Name: ServiceTerm</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "serviceTerm")]
		[Updateable(false), Createable(false)]
		public double? ServiceTerm { get; set; }

		///<summary>
		/// Sync To PBO Error
		/// <para>Name: SyncToPboError</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "syncToPboError")]
		[Updateable(false), Createable(false)]
		public string SyncToPboError { get; set; }

	}
}
