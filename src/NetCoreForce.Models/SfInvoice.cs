// SF API version v64.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Invoice
	///<para>SObject Name: Invoice</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfInvoice : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "Invoice"; }
		}

		///<summary>
		/// Invoice ID
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
		/// Document Number
		/// <para>Name: DocumentNumber</para>
		/// <para>SF Type: string</para>
		/// <para>AutoNumber field</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "documentNumber")]
		[Updateable(false), Createable(false)]
		public string DocumentNumber { get; set; }

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
		[Updateable(true), Createable(false)]
		public string ReferenceEntityId { get; set; }

		///<summary>
		/// Invoice Number
		/// <para>Name: InvoiceNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "invoiceNumber")]
		[Updateable(true), Createable(false)]
		public string InvoiceNumber { get; set; }

		///<summary>
		/// Account ID
		/// <para>Name: BillingAccountId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "billingAccountId")]
		[Updateable(true), Createable(false)]
		public string BillingAccountId { get; set; }

		///<summary>
		/// ReferenceTo: Account
		/// <para>RelationshipName: BillingAccount</para>
		///</summary>
		[JsonProperty(PropertyName = "billingAccount")]
		[Updateable(false), Createable(false)]
		public SfAccount BillingAccount { get; set; }

		///<summary>
		/// Total Amount
		/// <para>Name: TotalAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalAmount")]
		[Updateable(false), Createable(false)]
		public decimal? TotalAmount { get; set; }

		///<summary>
		/// Total with Tax
		/// <para>Name: TotalAmountWithTax</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalAmountWithTax")]
		[Updateable(false), Createable(false)]
		public decimal? TotalAmountWithTax { get; set; }

		///<summary>
		/// Total Charges
		/// <para>Name: TotalChargeAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalChargeAmount")]
		[Updateable(false), Createable(false)]
		public decimal? TotalChargeAmount { get; set; }

		///<summary>
		/// Total Adjustment Amount
		/// <para>Name: TotalAdjustmentAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalAdjustmentAmount")]
		[Updateable(false), Createable(false)]
		public decimal? TotalAdjustmentAmount { get; set; }

		///<summary>
		/// Total Tax
		/// <para>Name: TotalTaxAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalTaxAmount")]
		[Updateable(false), Createable(false)]
		public decimal? TotalTaxAmount { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		[Updateable(false), Createable(false)]
		public string Status { get; set; }

		///<summary>
		/// Invoice Date
		/// <para>Name: InvoiceDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "invoiceDate")]
		[Updateable(true), Createable(false)]
		public DateTime? InvoiceDate { get; set; }

		///<summary>
		/// Due Date
		/// <para>Name: DueDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "dueDate")]
		[Updateable(true), Createable(false)]
		public DateTime? DueDate { get; set; }

		///<summary>
		/// Contact ID
		/// <para>Name: BillToContactId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "billToContactId")]
		[Updateable(true), Createable(false)]
		public string BillToContactId { get; set; }

		///<summary>
		/// ReferenceTo: Contact
		/// <para>RelationshipName: BillToContact</para>
		///</summary>
		[JsonProperty(PropertyName = "billToContact")]
		[Updateable(false), Createable(false)]
		public SfContact BillToContact { get; set; }

		///<summary>
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		[Updateable(true), Createable(false)]
		public string Description { get; set; }

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
		/// Total Charge Tax Amount
		/// <para>Name: TotalChargeTaxAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalChargeTaxAmount")]
		[Updateable(false), Createable(false)]
		public decimal? TotalChargeTaxAmount { get; set; }

		///<summary>
		/// Total Charge Amount with Tax
		/// <para>Name: TotalChargeAmountWithTax</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalChargeAmountWithTax")]
		[Updateable(false), Createable(false)]
		public decimal? TotalChargeAmountWithTax { get; set; }

		///<summary>
		/// Total Adjustment Tax Amount
		/// <para>Name: TotalAdjustmentTaxAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalAdjustmentTaxAmount")]
		[Updateable(false), Createable(false)]
		public decimal? TotalAdjustmentTaxAmount { get; set; }

		///<summary>
		/// Total Adjustment Amount with Tax
		/// <para>Name: TotalAdjustmentAmountWithTax</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalAdjustmentAmountWithTax")]
		[Updateable(false), Createable(false)]
		public decimal? TotalAdjustmentAmountWithTax { get; set; }

		///<summary>
		/// Net Credits Applied
		/// <para>Name: NetCreditsApplied</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "netCreditsApplied")]
		[Updateable(false), Createable(false)]
		public decimal? NetCreditsApplied { get; set; }

		///<summary>
		/// Net Payments Applied
		/// <para>Name: NetPaymentsApplied</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "netPaymentsApplied")]
		[Updateable(false), Createable(false)]
		public decimal? NetPaymentsApplied { get; set; }

		///<summary>
		/// Invoice Locked
		/// <para>Name: IsInvoiceLocked</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isInvoiceLocked")]
		[Updateable(false), Createable(false)]
		public bool? IsInvoiceLocked { get; set; }

		///<summary>
		/// Invoice Locked Date Time
		/// <para>Name: InvoiceLockedDateTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "invoiceLockedDateTime")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? InvoiceLockedDateTime { get; set; }

		///<summary>
		/// Write Off Status
		/// <para>Name: WriteOffStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "writeOffStatus")]
		[Updateable(false), Createable(false)]
		public string WriteOffStatus { get; set; }

		///<summary>
		/// Write Off Total Charge Amount
		/// <para>Name: WriteOffTotalChargeAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "writeOffTotalChargeAmount")]
		[Updateable(false), Createable(false)]
		public decimal? WriteOffTotalChargeAmount { get; set; }

		///<summary>
		/// Write Off Total Tax Amount
		/// <para>Name: WriteOffTotalTaxAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "writeOffTotalTaxAmount")]
		[Updateable(false), Createable(false)]
		public decimal? WriteOffTotalTaxAmount { get; set; }

	}
}
