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
	/// Contract
	///<para>SObject Name: Contract</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfContract : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "Contract"; }
		}

		///<summary>
		/// Contract ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Account ID
		/// <para>Name: AccountId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
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
		/// Owner Expiration Notice
		/// <para>Name: OwnerExpirationNotice</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "ownerExpirationNotice")]
		public string OwnerExpirationNotice { get; set; }

		///<summary>
		/// Contract Start Date
		/// <para>Name: StartDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "startDate")]
		public DateTime? StartDate { get; set; }

		///<summary>
		/// Contract End Date
		/// <para>Name: EndDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "endDate")]
		[Updateable(false), Createable(false)]
		public DateTime? EndDate { get; set; }

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
		/// Contract Term
		/// <para>Name: ContractTerm</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contractTerm")]
		public int? ContractTerm { get; set; }

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
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		public string Status { get; set; }

		///<summary>
		/// Company Signed By ID
		/// <para>Name: CompanySignedId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "companySignedId")]
		public string CompanySignedId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: CompanySigned</para>
		///</summary>
		[JsonProperty(PropertyName = "companySigned")]
		[Updateable(false), Createable(false)]
		public SfUser CompanySigned { get; set; }

		///<summary>
		/// Company Signed Date
		/// <para>Name: CompanySignedDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "companySignedDate")]
		public DateTime? CompanySignedDate { get; set; }

		///<summary>
		/// Customer Signed By ID
		/// <para>Name: CustomerSignedId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "customerSignedId")]
		public string CustomerSignedId { get; set; }

		///<summary>
		/// ReferenceTo: Contact
		/// <para>RelationshipName: CustomerSigned</para>
		///</summary>
		[JsonProperty(PropertyName = "customerSigned")]
		[Updateable(false), Createable(false)]
		public SfContact CustomerSigned { get; set; }

		///<summary>
		/// Customer Signed Title
		/// <para>Name: CustomerSignedTitle</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "customerSignedTitle")]
		public string CustomerSignedTitle { get; set; }

		///<summary>
		/// Customer Signed Date
		/// <para>Name: CustomerSignedDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "customerSignedDate")]
		public DateTime? CustomerSignedDate { get; set; }

		///<summary>
		/// Special Terms
		/// <para>Name: SpecialTerms</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "specialTerms")]
		public string SpecialTerms { get; set; }

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
		/// Activated Date
		/// <para>Name: ActivatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "activatedDate")]
		[Updateable(true), Createable(false)]
		public DateTimeOffset? ActivatedDate { get; set; }

		///<summary>
		/// Status Category
		/// <para>Name: StatusCode</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "statusCode")]
		[Updateable(false), Createable(false)]
		public string StatusCode { get; set; }

		///<summary>
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

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
		/// Contract Number
		/// <para>Name: ContractNumber</para>
		/// <para>SF Type: string</para>
		/// <para>AutoNumber field</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "contractNumber")]
		[Updateable(false), Createable(false)]
		public string ContractNumber { get; set; }

		///<summary>
		/// Last Approved Date
		/// <para>Name: LastApprovedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastApprovedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastApprovedDate { get; set; }

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

	}
}
