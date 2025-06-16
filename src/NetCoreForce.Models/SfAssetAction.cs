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
	/// Asset Action
	///<para>SObject Name: AssetAction</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfAssetAction : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "AssetAction"; }
		}

		///<summary>
		/// Asset Action ID
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
		/// <para>Name: AssetActionNumber</para>
		/// <para>SF Type: string</para>
		/// <para>AutoNumber field</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "assetActionNumber")]
		[Updateable(false), Createable(false)]
		public string AssetActionNumber { get; set; }

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
		/// Asset ID
		/// <para>Name: AssetId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "assetId")]
		[Updateable(false), Createable(false)]
		public string AssetId { get; set; }

		///<summary>
		/// ReferenceTo: Asset
		/// <para>RelationshipName: Asset</para>
		///</summary>
		[JsonProperty(PropertyName = "asset")]
		[Updateable(false), Createable(false)]
		public SfAsset Asset { get; set; }

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
		/// Business Category
		/// <para>Name: CategoryEnum</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "categoryEnum")]
		[Updateable(false), Createable(false)]
		public string CategoryEnum { get; set; }

		///<summary>
		/// Action Date
		/// <para>Name: ActionDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "actionDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? ActionDate { get; set; }

		///<summary>
		/// Change in Product Amount
		/// <para>Name: ProductAmountChange</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "productAmountChange")]
		[Updateable(false), Createable(false)]
		public decimal? ProductAmountChange { get; set; }

		///<summary>
		/// Change in Adjustment Amount
		/// <para>Name: AdjustmentAmountChange</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "adjustmentAmountChange")]
		[Updateable(false), Createable(false)]
		public decimal? AdjustmentAmountChange { get; set; }

		///<summary>
		/// Change in Estimated Tax
		/// <para>Name: EstimatedTaxChange</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "estimatedTaxChange")]
		[Updateable(false), Createable(false)]
		public decimal? EstimatedTaxChange { get; set; }

		///<summary>
		/// Change in Actual Tax
		/// <para>Name: ActualTaxChange</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "actualTaxChange")]
		[Updateable(false), Createable(false)]
		public decimal? ActualTaxChange { get; set; }

		///<summary>
		/// Change in Subtotal
		/// <para>Name: SubtotalChange</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "subtotalChange")]
		[Updateable(false), Createable(false)]
		public decimal? SubtotalChange { get; set; }

		///<summary>
		/// Change in Quantity
		/// <para>Name: QuantityChange</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "quantityChange")]
		[Updateable(false), Createable(false)]
		public double? QuantityChange { get; set; }

		///<summary>
		/// Change in Monthly Recurring Revenue
		/// <para>Name: MrrChange</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "mrrChange")]
		[Updateable(false), Createable(false)]
		public decimal? MrrChange { get; set; }

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
		/// Total Initial Sale Amount
		/// <para>Name: TotalInitialSaleAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalInitialSaleAmount")]
		[Updateable(false), Createable(false)]
		public decimal? TotalInitialSaleAmount { get; set; }

		///<summary>
		/// Total Renewals Amount
		/// <para>Name: TotalRenewalsAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalRenewalsAmount")]
		[Updateable(false), Createable(false)]
		public decimal? TotalRenewalsAmount { get; set; }

		///<summary>
		/// Total Upsells Amount
		/// <para>Name: TotalUpsellsAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalUpsellsAmount")]
		[Updateable(false), Createable(false)]
		public decimal? TotalUpsellsAmount { get; set; }

		///<summary>
		/// Total Downsells Amount
		/// <para>Name: TotalDownsellsAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalDownsellsAmount")]
		[Updateable(false), Createable(false)]
		public decimal? TotalDownsellsAmount { get; set; }

		///<summary>
		/// Total Cross-Sells Amount
		/// <para>Name: TotalCrossSellsAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalCrossSellsAmount")]
		[Updateable(false), Createable(false)]
		public decimal? TotalCrossSellsAmount { get; set; }

		///<summary>
		/// Total Cancellations Amount
		/// <para>Name: TotalCancellationsAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalCancellationsAmount")]
		[Updateable(false), Createable(false)]
		public decimal? TotalCancellationsAmount { get; set; }

		///<summary>
		/// Total Transfers Amount
		/// <para>Name: TotalTransfersAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalTransfersAmount")]
		[Updateable(false), Createable(false)]
		public decimal? TotalTransfersAmount { get; set; }

		///<summary>
		/// Total Terms And Conditions Changes Amount
		/// <para>Name: TotalTermsAndConditionsAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalTermsAndConditionsAmount")]
		[Updateable(false), Createable(false)]
		public decimal? TotalTermsAndConditionsAmount { get; set; }

		///<summary>
		/// Total Other Amount
		/// <para>Name: TotalOtherAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalOtherAmount")]
		[Updateable(false), Createable(false)]
		public decimal? TotalOtherAmount { get; set; }

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
		/// Total Quantity
		/// <para>Name: TotalQuantity</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalQuantity")]
		[Updateable(false), Createable(false)]
		public double? TotalQuantity { get; set; }

		///<summary>
		/// Total Monthly Recurring Revenue
		/// <para>Name: TotalMrr</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalMrr")]
		[Updateable(false), Createable(false)]
		public decimal? TotalMrr { get; set; }

	}
}
