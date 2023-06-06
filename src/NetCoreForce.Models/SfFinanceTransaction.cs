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
	/// Finance Transaction
	///<para>SObject Name: FinanceTransaction</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfFinanceTransaction : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "FinanceTransaction"; }
		}

		///<summary>
		/// Finance Transaction ID
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
		/// <para>Name: FinanceTransactionNumber</para>
		/// <para>SF Type: string</para>
		/// <para>AutoNumber field</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "financeTransactionNumber")]
		[Updateable(false), Createable(false)]
		public string FinanceTransactionNumber { get; set; }

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
		/// ReferenceEntity ID
		/// <para>Name: ReferenceEntityId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "referenceEntityId")]
		[Updateable(false), Createable(true)]
		public string ReferenceEntityId { get; set; }

		///<summary>
		/// Reference Entity Type
		/// <para>Name: ReferenceEntityType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "referenceEntityType")]
		[Updateable(false), Createable(true)]
		public string ReferenceEntityType { get; set; }

		///<summary>
		/// Event Action
		/// <para>Name: EventAction</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "eventAction")]
		[Updateable(false), Createable(true)]
		public string EventAction { get; set; }

		///<summary>
		/// Event Type
		/// <para>Name: EventType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "eventType")]
		[Updateable(false), Createable(true)]
		public string EventType { get; set; }

		///<summary>
		/// Charge Amount
		/// <para>Name: ChargeAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "chargeAmount")]
		[Updateable(false), Createable(true)]
		public decimal? ChargeAmount { get; set; }

		///<summary>
		/// Adjustment Amount
		/// <para>Name: AdjustmentAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "adjustmentAmount")]
		[Updateable(false), Createable(true)]
		public decimal? AdjustmentAmount { get; set; }

		///<summary>
		/// Subtotal
		/// <para>Name: Subtotal</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "subtotal")]
		[Updateable(false), Createable(true)]
		public decimal? Subtotal { get; set; }

		///<summary>
		/// Tax Amount
		/// <para>Name: TaxAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "taxAmount")]
		[Updateable(false), Createable(true)]
		public decimal? TaxAmount { get; set; }

		///<summary>
		/// Total Amount With Tax
		/// <para>Name: TotalAmountWithTax</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "totalAmountWithTax")]
		[Updateable(false), Createable(true)]
		public decimal? TotalAmountWithTax { get; set; }

		///<summary>
		/// Impact Amount
		/// <para>Name: ImpactAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "impactAmount")]
		[Updateable(false), Createable(true)]
		public decimal? ImpactAmount { get; set; }

		///<summary>
		/// Resulting Balance
		/// <para>Name: ResultingBalance</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "resultingBalance")]
		[Updateable(false), Createable(true)]
		public decimal? ResultingBalance { get; set; }

		///<summary>
		/// Account ID
		/// <para>Name: AccountId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "accountId")]
		[Updateable(false), Createable(true)]
		public string AccountId { get; set; }

		///<summary>
		/// ReferenceTo: Account
		/// <para>RelationshipName: Account</para>
		///</summary>
		[JsonProperty(PropertyName = "account")]
		[Updateable(false), Createable(false)]
		public SfAccount Account { get; set; }

		///<summary>
		/// SourceEntity ID
		/// <para>Name: SourceEntityId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sourceEntityId")]
		[Updateable(false), Createable(true)]
		public string SourceEntityId { get; set; }

		///<summary>
		/// DestinationEntity ID
		/// <para>Name: DestinationEntityId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "destinationEntityId")]
		[Updateable(false), Createable(true)]
		public string DestinationEntityId { get; set; }

		///<summary>
		/// Transaction Date
		/// <para>Name: TransactionDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "transactionDate")]
		[Updateable(false), Createable(true)]
		public DateTimeOffset? TransactionDate { get; set; }

		///<summary>
		/// Effective Date
		/// <para>Name: EffectiveDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "effectiveDate")]
		[Updateable(false), Createable(true)]
		public DateTimeOffset? EffectiveDate { get; set; }

		///<summary>
		/// Due Date
		/// <para>Name: DueDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dueDate")]
		[Updateable(false), Createable(true)]
		public DateTimeOffset? DueDate { get; set; }

		///<summary>
		/// Base Currency ISO Code
		/// <para>Name: BaseCurrencyIsoCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "baseCurrencyIsoCode")]
		[Updateable(false), Createable(true)]
		public string BaseCurrencyIsoCode { get; set; }

		///<summary>
		/// Base Currency FX Rate
		/// <para>Name: BaseCurrencyFxRate</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "baseCurrencyFxRate")]
		[Updateable(false), Createable(true)]
		public double? BaseCurrencyFxRate { get; set; }

		///<summary>
		/// Base Currency FX Date
		/// <para>Name: BaseCurrencyFxDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "baseCurrencyFxDate")]
		[Updateable(false), Createable(true)]
		public DateTime? BaseCurrencyFxDate { get; set; }

		///<summary>
		/// Base Currency Amount
		/// <para>Name: BaseCurrencyAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "baseCurrencyAmount")]
		[Updateable(false), Createable(true)]
		public decimal? BaseCurrencyAmount { get; set; }

		///<summary>
		/// Base Currency Balance
		/// <para>Name: BaseCurrencyBalance</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "baseCurrencyBalance")]
		[Updateable(false), Createable(true)]
		public decimal? BaseCurrencyBalance { get; set; }

		///<summary>
		/// Legal Entity ID
		/// <para>Name: LegalEntityId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "legalEntityId")]
		[Updateable(false), Createable(true)]
		public string LegalEntityId { get; set; }

		///<summary>
		/// ReferenceTo: LegalEntity
		/// <para>RelationshipName: LegalEntity</para>
		///</summary>
		[JsonProperty(PropertyName = "legalEntity")]
		[Updateable(false), Createable(false)]
		public SfLegalEntity LegalEntity { get; set; }

		///<summary>
		/// Creation Mode
		/// <para>Name: CreationMode</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "creationMode")]
		[Updateable(false), Createable(false)]
		public string CreationMode { get; set; }

		///<summary>
		/// ParentReferenceEntity ID
		/// <para>Name: ParentReferenceEntityId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "parentReferenceEntityId")]
		[Updateable(false), Createable(true)]
		public string ParentReferenceEntityId { get; set; }

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
		/// Original Event Action
		/// <para>Name: OriginalEventAction</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "originalEventAction")]
		[Updateable(false), Createable(false)]
		public string OriginalEventAction { get; set; }

		///<summary>
		/// Original Credit GL Account Name
		/// <para>Name: OriginalCreditGlAccountName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "originalCreditGlAccountName")]
		[Updateable(false), Createable(false)]
		public string OriginalCreditGlAccountName { get; set; }

		///<summary>
		/// Original Credit GL Account Number
		/// <para>Name: OriginalCreditGlAccountNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "originalCreditGlAccountNumber")]
		[Updateable(false), Createable(false)]
		public string OriginalCreditGlAccountNumber { get; set; }

		///<summary>
		/// Original Debit GL Account Name
		/// <para>Name: OriginalDebitGlAccountName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "originalDebitGlAccountName")]
		[Updateable(false), Createable(false)]
		public string OriginalDebitGlAccountName { get; set; }

		///<summary>
		/// Original Debit GL Account Number
		/// <para>Name: OriginalDebitGlAccountNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "originalDebitGlAccountNumber")]
		[Updateable(false), Createable(false)]
		public string OriginalDebitGlAccountNumber { get; set; }

		///<summary>
		/// Original Finance Period Name
		/// <para>Name: OriginalFinancePeriodName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "originalFinancePeriodName")]
		[Updateable(false), Createable(false)]
		public string OriginalFinancePeriodName { get; set; }

		///<summary>
		/// Original Finance Period Start Date
		/// <para>Name: OriginalFinancePeriodStartDate</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "originalFinancePeriodStartDate")]
		[Updateable(false), Createable(false)]
		public string OriginalFinancePeriodStartDate { get; set; }

		///<summary>
		/// Original Finance Period End Date
		/// <para>Name: OriginalFinancePeriodEndDate</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "originalFinancePeriodEndDate")]
		[Updateable(false), Createable(false)]
		public string OriginalFinancePeriodEndDate { get; set; }

		///<summary>
		/// Original Finance Period Status
		/// <para>Name: OriginalFinancePeriodStatus</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "originalFinancePeriodStatus")]
		[Updateable(false), Createable(false)]
		public string OriginalFinancePeriodStatus { get; set; }

		///<summary>
		/// Original GL Rule Name
		/// <para>Name: OriginalGlRuleName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "originalGlRuleName")]
		[Updateable(false), Createable(false)]
		public string OriginalGlRuleName { get; set; }

		///<summary>
		/// Original GL Treatment Name
		/// <para>Name: OriginalGlTreatmentName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "originalGlTreatmentName")]
		[Updateable(false), Createable(false)]
		public string OriginalGlTreatmentName { get; set; }

		///<summary>
		/// Original Finance Book Name
		/// <para>Name: OriginalFinanceBookName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "originalFinanceBookName")]
		[Updateable(false), Createable(false)]
		public string OriginalFinanceBookName { get; set; }

		///<summary>
		/// Finance System Transaction Number
		/// <para>Name: FinanceSystemTransactionNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "financeSystemTransactionNumber")]
		public string FinanceSystemTransactionNumber { get; set; }

		///<summary>
		/// Finance System Name
		/// <para>Name: FinanceSystemName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "financeSystemName")]
		public string FinanceSystemName { get; set; }

		///<summary>
		/// Finance System Integration Mode
		/// <para>Name: FinanceSystemIntegrationMode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "financeSystemIntegrationMode")]
		public string FinanceSystemIntegrationMode { get; set; }

		///<summary>
		/// Finance System Integration Status
		/// <para>Name: FinanceSystemIntegrationStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "financeSystemIntegrationStatus")]
		public string FinanceSystemIntegrationStatus { get; set; }

	}
}
