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
	/// Payment Line Invoice
	///<para>SObject Name: PaymentLineInvoice</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfPaymentLineInvoice : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "PaymentLineInvoice"; }
		}

		///<summary>
		/// Payment Line Invoice ID
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
		/// Payment Line Invoice Number
		/// <para>Name: PaymentLineInvoiceNumber</para>
		/// <para>SF Type: string</para>
		/// <para>AutoNumber field</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentLineInvoiceNumber")]
		[Updateable(false), Createable(false)]
		public string PaymentLineInvoiceNumber { get; set; }

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
		/// Invoice ID
		/// <para>Name: InvoiceId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "invoiceId")]
		[Updateable(false), Createable(true)]
		public string InvoiceId { get; set; }

		///<summary>
		/// ReferenceTo: Invoice
		/// <para>RelationshipName: Invoice</para>
		///</summary>
		[JsonProperty(PropertyName = "invoice")]
		[Updateable(false), Createable(false)]
		public SfInvoice Invoice { get; set; }

		///<summary>
		/// Payment ID
		/// <para>Name: PaymentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentId")]
		[Updateable(false), Createable(true)]
		public string PaymentId { get; set; }

		///<summary>
		/// ReferenceTo: Payment
		/// <para>RelationshipName: Payment</para>
		///</summary>
		[JsonProperty(PropertyName = "payment")]
		[Updateable(false), Createable(false)]
		public SfPayment Payment { get; set; }

		///<summary>
		/// Amount
		/// <para>Name: Amount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "amount")]
		[Updateable(false), Createable(true)]
		public decimal? Amount { get; set; }

		///<summary>
		/// Type
		/// <para>Name: Type</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		[Updateable(false), Createable(true)]
		public string Type { get; set; }

		///<summary>
		/// Has Been Unapplied
		/// <para>Name: HasBeenUnapplied</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasBeenUnapplied")]
		[Updateable(false), Createable(true)]
		public string HasBeenUnapplied { get; set; }

		///<summary>
		/// Comments
		/// <para>Name: Comments</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "comments")]
		public string Comments { get; set; }

		///<summary>
		/// Date
		/// <para>Name: Date</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "date")]
		[Updateable(false), Createable(true)]
		public DateTimeOffset? Date { get; set; }

		///<summary>
		/// Applied Date
		/// <para>Name: AppliedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "appliedDate")]
		[Updateable(false), Createable(true)]
		public DateTimeOffset? AppliedDate { get; set; }

		///<summary>
		/// Effective Date
		/// <para>Name: EffectiveDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "effectiveDate")]
		[Updateable(false), Createable(true)]
		public DateTimeOffset? EffectiveDate { get; set; }

		///<summary>
		/// Unapplied Date
		/// <para>Name: UnappliedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "unappliedDate")]
		[Updateable(false), Createable(true)]
		public DateTimeOffset? UnappliedDate { get; set; }

		///<summary>
		/// Account ID
		/// <para>Name: AssociatedAccountId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "associatedAccountId")]
		[Updateable(false), Createable(true)]
		public string AssociatedAccountId { get; set; }

		///<summary>
		/// ReferenceTo: Account
		/// <para>RelationshipName: AssociatedAccount</para>
		///</summary>
		[JsonProperty(PropertyName = "associatedAccount")]
		[Updateable(false), Createable(false)]
		public SfAccount AssociatedAccount { get; set; }

		///<summary>
		/// Payment Line Invoice ID
		/// <para>Name: AssociatedPaymentLineId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "associatedPaymentLineId")]
		[Updateable(false), Createable(true)]
		public string AssociatedPaymentLineId { get; set; }

		///<summary>
		/// ReferenceTo: PaymentLineInvoice
		/// <para>RelationshipName: AssociatedPaymentLine</para>
		///</summary>
		[JsonProperty(PropertyName = "associatedPaymentLine")]
		[Updateable(false), Createable(false)]
		public SfPaymentLineInvoice AssociatedPaymentLine { get; set; }

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
		/// Effective Impact Amount
		/// <para>Name: EffectiveImpactAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "effectiveImpactAmount")]
		[Updateable(false), Createable(false)]
		public decimal? EffectiveImpactAmount { get; set; }

		///<summary>
		/// Payment Balance
		/// <para>Name: PaymentBalance</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentBalance")]
		[Updateable(false), Createable(false)]
		public decimal? PaymentBalance { get; set; }

	}
}
