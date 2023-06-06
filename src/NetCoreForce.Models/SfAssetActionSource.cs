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
	/// Asset Action Source
	///<para>SObject Name: AssetActionSource</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfAssetActionSource : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "AssetActionSource"; }
		}

		///<summary>
		/// Asset Action Source ID
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
		/// <para>Name: AssetActionSourceNumber</para>
		/// <para>SF Type: string</para>
		/// <para>AutoNumber field</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "assetActionSourceNumber")]
		[Updateable(false), Createable(false)]
		public string AssetActionSourceNumber { get; set; }

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
		/// Asset Action ID
		/// <para>Name: AssetActionId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "assetActionId")]
		[Updateable(false), Createable(false)]
		public string AssetActionId { get; set; }

		///<summary>
		/// ReferenceTo: AssetAction
		/// <para>RelationshipName: AssetAction</para>
		///</summary>
		[JsonProperty(PropertyName = "assetAction")]
		[Updateable(false), Createable(false)]
		public SfAssetAction AssetAction { get; set; }

		///<summary>
		/// Reference Entity Item ID
		/// <para>Name: ReferenceEntityItemId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "referenceEntityItemId")]
		[Updateable(false), Createable(false)]
		public string ReferenceEntityItemId { get; set; }

		///<summary>
		/// ReferenceTo: OrderItem
		/// <para>RelationshipName: ReferenceEntityItem</para>
		///</summary>
		[JsonProperty(PropertyName = "referenceEntityItem")]
		[Updateable(false), Createable(false)]
		public SfOrderItem ReferenceEntityItem { get; set; }

		///<summary>
		/// Product Amount
		/// <para>Name: ProductAmount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "productAmount")]
		[Updateable(false), Createable(false)]
		public decimal? ProductAmount { get; set; }

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
		/// Estimated Tax
		/// <para>Name: EstimatedTax</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "estimatedTax")]
		[Updateable(false), Createable(false)]
		public decimal? EstimatedTax { get; set; }

		///<summary>
		/// Actual Tax
		/// <para>Name: ActualTax</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "actualTax")]
		[Updateable(false), Createable(false)]
		public decimal? ActualTax { get; set; }

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
		/// Start Date
		/// <para>Name: StartDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "startDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? StartDate { get; set; }

		///<summary>
		/// End Date
		/// <para>Name: EndDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "endDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? EndDate { get; set; }

		///<summary>
		/// Quantity
		/// <para>Name: Quantity</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "quantity")]
		[Updateable(false), Createable(false)]
		public double? Quantity { get; set; }

		///<summary>
		/// Transaction Date
		/// <para>Name: TransactionDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "transactionDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? TransactionDate { get; set; }

		///<summary>
		/// External Reference
		/// <para>Name: ExternalReference</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "externalReference")]
		[Updateable(false), Createable(false)]
		public string ExternalReference { get; set; }

		///<summary>
		/// External Reference Data Source
		/// <para>Name: ExternalReferenceDataSource</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "externalReferenceDataSource")]
		[Updateable(false), Createable(false)]
		public string ExternalReferenceDataSource { get; set; }

	}
}
