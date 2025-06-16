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
	/// Credit Memo Invoice Application
	///<para>SObject Name: CreditMemoInvApplication</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfCreditMemoInvApplication : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "CreditMemoInvApplication"; }
		}

		///<summary>
		/// Credit Memo Invoice Application ID
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
		/// Name
		/// <para>Name: CreditMemoInvoiceNumber</para>
		/// <para>SF Type: string</para>
		/// <para>AutoNumber field</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "creditMemoInvoiceNumber")]
		[Updateable(false), Createable(false)]
		public string CreditMemoInvoiceNumber { get; set; }

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
		/// Invoice ID
		/// <para>Name: InvoiceId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "invoiceId")]
		[Updateable(false), Createable(false)]
		public string InvoiceId { get; set; }

		///<summary>
		/// ReferenceTo: Invoice
		/// <para>RelationshipName: Invoice</para>
		///</summary>
		[JsonProperty(PropertyName = "invoice")]
		[Updateable(false), Createable(false)]
		public SfInvoice Invoice { get; set; }

		///<summary>
		/// Credit Memo ID
		/// <para>Name: CreditMemoId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "creditMemoId")]
		[Updateable(false), Createable(false)]
		public string CreditMemoId { get; set; }

		///<summary>
		/// ReferenceTo: CreditMemo
		/// <para>RelationshipName: CreditMemo</para>
		///</summary>
		[JsonProperty(PropertyName = "creditMemo")]
		[Updateable(false), Createable(false)]
		public SfCreditMemo CreditMemo { get; set; }

		///<summary>
		/// Amount
		/// <para>Name: Amount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "amount")]
		[Updateable(false), Createable(false)]
		public decimal? Amount { get; set; }

		///<summary>
		/// Type
		/// <para>Name: Type</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		[Updateable(false), Createable(false)]
		public string Type { get; set; }

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
		/// Date
		/// <para>Name: Date</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "date")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? Date { get; set; }

		///<summary>
		/// Applied Date
		/// <para>Name: AppliedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "appliedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? AppliedDate { get; set; }

		///<summary>
		/// Effective Date
		/// <para>Name: EffectiveDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "effectiveDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? EffectiveDate { get; set; }

		///<summary>
		/// Unapplied Date
		/// <para>Name: UnappliedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "unappliedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? UnappliedDate { get; set; }

		///<summary>
		/// Credit Memo Invoice Application ID
		/// <para>Name: AssociatedLineId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "associatedLineId")]
		[Updateable(false), Createable(false)]
		public string AssociatedLineId { get; set; }

		///<summary>
		/// ReferenceTo: CreditMemoInvApplication
		/// <para>RelationshipName: AssociatedLine</para>
		///</summary>
		[JsonProperty(PropertyName = "associatedLine")]
		[Updateable(false), Createable(false)]
		public SfCreditMemoInvApplication AssociatedLine { get; set; }

		///<summary>
		/// Has Been Unapplied
		/// <para>Name: HasBeenUnapplied</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "hasBeenUnapplied")]
		[Updateable(false), Createable(false)]
		public string HasBeenUnapplied { get; set; }

		///<summary>
		/// Impact Amount
		/// <para>Name: ImpactAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "impactAmount")]
		[Updateable(false), Createable(false)]
		public decimal? ImpactAmount { get; set; }

	}
}
