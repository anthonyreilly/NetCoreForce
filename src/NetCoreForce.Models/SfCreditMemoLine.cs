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
	/// Credit Memo Line
	///<para>SObject Name: CreditMemoLine</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfCreditMemoLine : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "CreditMemoLine"; }
		}

		///<summary>
		/// Credit Memo Line ID
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
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(true), Createable(false)]
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
		/// ReferenceEntityItem ID
		/// <para>Name: ReferenceEntityItemId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "referenceEntityItemId")]
		[Updateable(true), Createable(false)]
		public string ReferenceEntityItemId { get; set; }

		///<summary>
		/// Start Date
		/// <para>Name: StartDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "startDate")]
		[Updateable(true), Createable(false)]
		public DateTime? StartDate { get; set; }

		///<summary>
		/// End Date
		/// <para>Name: EndDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "endDate")]
		[Updateable(true), Createable(false)]
		public DateTime? EndDate { get; set; }

		///<summary>
		/// Tax Effective Date
		/// <para>Name: TaxEffectiveDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "taxEffectiveDate")]
		[Updateable(true), Createable(false)]
		public DateTime? TaxEffectiveDate { get; set; }

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
		/// Tax Code
		/// <para>Name: TaxCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "taxCode")]
		[Updateable(true), Createable(false)]
		public string TaxCode { get; set; }

		///<summary>
		/// Tax Rate
		/// <para>Name: TaxRate</para>
		/// <para>SF Type: percent</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "taxRate")]
		[Updateable(true), Createable(false)]
		public double? TaxRate { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		[Updateable(false), Createable(false)]
		public string Status { get; set; }

		///<summary>
		/// Charge Amount
		/// <para>Name: ChargeAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "chargeAmount")]
		[Updateable(true), Createable(false)]
		public decimal? ChargeAmount { get; set; }

		///<summary>
		/// Tax Amount
		/// <para>Name: TaxAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "taxAmount")]
		[Updateable(true), Createable(false)]
		public decimal? TaxAmount { get; set; }

		///<summary>
		/// Adjustment Amount
		/// <para>Name: AdjustmentAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "adjustmentAmount")]
		[Updateable(true), Createable(false)]
		public decimal? AdjustmentAmount { get; set; }

		///<summary>
		/// Line Amount
		/// <para>Name: LineAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lineAmount")]
		[Updateable(false), Createable(false)]
		public decimal? LineAmount { get; set; }

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
		/// Reference Entity Item Type Code
		/// <para>Name: ReferenceEntityItemTypeCode</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "referenceEntityItemTypeCode")]
		[Updateable(true), Createable(false)]
		public string ReferenceEntityItemTypeCode { get; set; }

		///<summary>
		/// Reference Entity Item Type
		/// <para>Name: ReferenceEntityItemType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "referenceEntityItemType")]
		[Updateable(true), Createable(false)]
		public string ReferenceEntityItemType { get; set; }

		///<summary>
		/// Credit Memo Line ID
		/// <para>Name: RelatedLineId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relatedLineId")]
		[Updateable(true), Createable(false)]
		public string RelatedLineId { get; set; }

		///<summary>
		/// ReferenceTo: CreditMemoLine
		/// <para>RelationshipName: RelatedLine</para>
		///</summary>
		[JsonProperty(PropertyName = "relatedLine")]
		[Updateable(false), Createable(false)]
		public SfCreditMemoLine RelatedLine { get; set; }

		///<summary>
		/// Product ID
		/// <para>Name: Product2Id</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "product2Id")]
		[Updateable(true), Createable(false)]
		public string Product2Id { get; set; }

		///<summary>
		/// ReferenceTo: Product2
		/// <para>RelationshipName: Product2</para>
		///</summary>
		[JsonProperty(PropertyName = "product2")]
		[Updateable(false), Createable(false)]
		public SfProduct2 Product2 { get; set; }

		///<summary>
		/// Tax Name
		/// <para>Name: TaxName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "taxName")]
		[Updateable(true), Createable(false)]
		public string TaxName { get; set; }

		///<summary>
		/// Charge Tax Amount
		/// <para>Name: ChargeTaxAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "chargeTaxAmount")]
		[Updateable(false), Createable(false)]
		public decimal? ChargeTaxAmount { get; set; }

		///<summary>
		/// Charge Amount with Tax
		/// <para>Name: ChargeAmountWithTax</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "chargeAmountWithTax")]
		[Updateable(false), Createable(false)]
		public decimal? ChargeAmountWithTax { get; set; }

		///<summary>
		/// Adjustment Tax Amount
		/// <para>Name: AdjustmentTaxAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "adjustmentTaxAmount")]
		[Updateable(false), Createable(false)]
		public decimal? AdjustmentTaxAmount { get; set; }

		///<summary>
		/// Adjustment Amount with Tax
		/// <para>Name: AdjustmentAmountWithTax</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "adjustmentAmountWithTax")]
		[Updateable(false), Createable(false)]
		public decimal? AdjustmentAmountWithTax { get; set; }

	}
}
