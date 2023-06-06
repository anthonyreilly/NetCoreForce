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
	/// Finance Balance Snapshot
	///<para>SObject Name: FinanceBalanceSnapshot</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfFinanceBalanceSnapshot : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "FinanceBalanceSnapshot"; }
		}

		///<summary>
		/// Finance Balance Snapshot ID
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
		[Updateable(true), Createable(false)]
		public string OwnerId { get; set; }

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
		/// Name
		/// <para>Name: FinanceBalanceSnapshotNumber</para>
		/// <para>SF Type: string</para>
		/// <para>AutoNumber field</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "financeBalanceSnapshotNumber")]
		[Updateable(false), Createable(false)]
		public string FinanceBalanceSnapshotNumber { get; set; }

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
		/// Finance Transaction ID
		/// <para>Name: FinanceTransactionId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "financeTransactionId")]
		[Updateable(false), Createable(false)]
		public string FinanceTransactionId { get; set; }

		///<summary>
		/// ReferenceTo: FinanceTransaction
		/// <para>RelationshipName: FinanceTransaction</para>
		///</summary>
		[JsonProperty(PropertyName = "financeTransaction")]
		[Updateable(false), Createable(false)]
		public SfFinanceTransaction FinanceTransaction { get; set; }

		///<summary>
		/// ReferenceEntity ID
		/// <para>Name: ReferenceEntityId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "referenceEntityId")]
		[Updateable(false), Createable(false)]
		public string ReferenceEntityId { get; set; }

		///<summary>
		/// Reference Entity Type
		/// <para>Name: ReferenceEntityType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "referenceEntityType")]
		[Updateable(false), Createable(false)]
		public string ReferenceEntityType { get; set; }

		///<summary>
		/// Event Type
		/// <para>Name: EventType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "eventType")]
		[Updateable(false), Createable(false)]
		public string EventType { get; set; }

		///<summary>
		/// Charge Amount
		/// <para>Name: ChargeAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "chargeAmount")]
		[Updateable(false), Createable(false)]
		public decimal? ChargeAmount { get; set; }

		///<summary>
		/// Adjustment Amount
		/// <para>Name: AdjustmentAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "adjustmentAmount")]
		[Updateable(false), Createable(false)]
		public decimal? AdjustmentAmount { get; set; }

		///<summary>
		/// Subtotal
		/// <para>Name: Subtotal</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "subtotal")]
		[Updateable(false), Createable(false)]
		public decimal? Subtotal { get; set; }

		///<summary>
		/// Tax Amount
		/// <para>Name: TaxAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "taxAmount")]
		[Updateable(false), Createable(false)]
		public decimal? TaxAmount { get; set; }

		///<summary>
		/// Total Amount With Tax
		/// <para>Name: TotalAmountWithTax</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalAmountWithTax")]
		[Updateable(false), Createable(false)]
		public decimal? TotalAmountWithTax { get; set; }

		///<summary>
		/// Impact Amount
		/// <para>Name: ImpactAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "impactAmount")]
		[Updateable(false), Createable(false)]
		public decimal? ImpactAmount { get; set; }

		///<summary>
		/// Balance
		/// <para>Name: Balance</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "balance")]
		[Updateable(false), Createable(false)]
		public decimal? Balance { get; set; }

		///<summary>
		/// Account ID
		/// <para>Name: AccountId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "accountId")]
		[Updateable(false), Createable(false)]
		public string AccountId { get; set; }

		///<summary>
		/// ReferenceTo: Account
		/// <para>RelationshipName: Account</para>
		///</summary>
		[JsonProperty(PropertyName = "account")]
		[Updateable(false), Createable(false)]
		public SfAccount Account { get; set; }

		///<summary>
		/// Transaction Date
		/// <para>Name: TransactionDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "transactionDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? TransactionDate { get; set; }

		///<summary>
		/// Effective Date
		/// <para>Name: EffectiveDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "effectiveDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? EffectiveDate { get; set; }

		///<summary>
		/// Due Date
		/// <para>Name: DueDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dueDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? DueDate { get; set; }

		///<summary>
		/// Base Currency ISO Code
		/// <para>Name: BaseCurrencyIsoCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "baseCurrencyIsoCode")]
		[Updateable(false), Createable(false)]
		public string BaseCurrencyIsoCode { get; set; }

		///<summary>
		/// Base Currency FX Rate
		/// <para>Name: BaseCurrencyFxRate</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "baseCurrencyFxRate")]
		[Updateable(false), Createable(false)]
		public double? BaseCurrencyFxRate { get; set; }

		///<summary>
		/// Base Currency FX Date
		/// <para>Name: BaseCurrencyFxDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "baseCurrencyFxDate")]
		[Updateable(false), Createable(false)]
		public DateTime? BaseCurrencyFxDate { get; set; }

		///<summary>
		/// Base Currency Amount
		/// <para>Name: BaseCurrencyAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "baseCurrencyAmount")]
		[Updateable(false), Createable(false)]
		public decimal? BaseCurrencyAmount { get; set; }

		///<summary>
		/// Base Currency Balance
		/// <para>Name: BaseCurrencyBalance</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "baseCurrencyBalance")]
		[Updateable(false), Createable(false)]
		public decimal? BaseCurrencyBalance { get; set; }

		///<summary>
		/// Legal Entity ID
		/// <para>Name: LegalEntityId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "legalEntityId")]
		[Updateable(false), Createable(false)]
		public string LegalEntityId { get; set; }

		///<summary>
		/// ReferenceTo: LegalEntity
		/// <para>RelationshipName: LegalEntity</para>
		///</summary>
		[JsonProperty(PropertyName = "legalEntity")]
		[Updateable(false), Createable(false)]
		public SfLegalEntity LegalEntity { get; set; }

		///<summary>
		/// Original Reference Entity Type
		/// <para>Name: OriginalReferenceEntityType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "originalReferenceEntityType")]
		[Updateable(false), Createable(false)]
		public string OriginalReferenceEntityType { get; set; }

		///<summary>
		/// Original Event Type
		/// <para>Name: OriginalEventType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "originalEventType")]
		[Updateable(false), Createable(false)]
		public string OriginalEventType { get; set; }

		///<summary>
		/// Finance System Transaction Number
		/// <para>Name: FinanceSystemTransactionNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "financeSystemTransactionNumber")]
		[Updateable(true), Createable(false)]
		public string FinanceSystemTransactionNumber { get; set; }

		///<summary>
		/// Finance System Name
		/// <para>Name: FinanceSystemName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "financeSystemName")]
		[Updateable(true), Createable(false)]
		public string FinanceSystemName { get; set; }

		///<summary>
		/// Finance System Integration Mode
		/// <para>Name: FinanceSystemIntegrationMode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "financeSystemIntegrationMode")]
		[Updateable(true), Createable(false)]
		public string FinanceSystemIntegrationMode { get; set; }

		///<summary>
		/// Finance System Integration Status
		/// <para>Name: FinanceSystemIntegrationStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "financeSystemIntegrationStatus")]
		[Updateable(true), Createable(false)]
		public string FinanceSystemIntegrationStatus { get; set; }

	}
}
