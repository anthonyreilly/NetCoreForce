// SF API version v41.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Order Product
	///<para>SObject Name: OrderItem</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfOrderItem : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "OrderItem"; }
		}

		///<summary>
		/// Order Product ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// Product ID
		/// <para>Name: Product2Id</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "product2Id")]
		[Updateable(false), Creatable(true)]
		public string Product2Id { get; set; }

		///<summary>
		/// ReferenceTo: Product2
		/// <para>RelationshipName: Product2</para>
		///</summary>
		[JsonProperty(PropertyName = "product2")]
		[Updateable(false), Creatable(false)]
		public SfProduct2 Product2 { get; set; }

		///<summary>
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Creatable(false)]
		public bool? IsDeleted { get; set; }

		///<summary>
		/// Order ID
		/// <para>Name: OrderId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "orderId")]
		[Updateable(false), Creatable(true)]
		public string OrderId { get; set; }

		///<summary>
		/// ReferenceTo: Order
		/// <para>RelationshipName: Order</para>
		///</summary>
		[JsonProperty(PropertyName = "order")]
		[Updateable(false), Creatable(false)]
		public SfOrder Order { get; set; }

		///<summary>
		/// Price Book Entry ID
		/// <para>Name: PricebookEntryId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "pricebookEntryId")]
		[Updateable(false), Creatable(true)]
		public string PricebookEntryId { get; set; }

		///<summary>
		/// ReferenceTo: PricebookEntry
		/// <para>RelationshipName: PricebookEntry</para>
		///</summary>
		[JsonProperty(PropertyName = "pricebookEntry")]
		[Updateable(false), Creatable(false)]
		public SfPricebookEntry PricebookEntry { get; set; }

		///<summary>
		/// Original Order Item ID
		/// <para>Name: OriginalOrderItemId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "originalOrderItemId")]
		[Updateable(false), Creatable(true)]
		public string OriginalOrderItemId { get; set; }

		///<summary>
		/// ReferenceTo: OrderItem
		/// <para>RelationshipName: OriginalOrderItem</para>
		///</summary>
		[JsonProperty(PropertyName = "originalOrderItem")]
		[Updateable(false), Creatable(false)]
		public SfOrderItem OriginalOrderItem { get; set; }

		///<summary>
		/// Available Quantity
		/// <para>Name: AvailableQuantity</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "availableQuantity")]
		[Updateable(false), Creatable(false)]
		public double? AvailableQuantity { get; set; }

		///<summary>
		/// Quantity
		/// <para>Name: Quantity</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "quantity")]
		public double? Quantity { get; set; }

		///<summary>
		/// Unit Price
		/// <para>Name: UnitPrice</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "unitPrice")]
		public decimal? UnitPrice { get; set; }

		///<summary>
		/// List Price
		/// <para>Name: ListPrice</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "listPrice")]
		[Updateable(false), Creatable(false)]
		public decimal? ListPrice { get; set; }

		///<summary>
		/// Total Price
		/// <para>Name: TotalPrice</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalPrice")]
		[Updateable(false), Creatable(false)]
		public decimal? TotalPrice { get; set; }

		///<summary>
		/// Start Date
		/// <para>Name: ServiceDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "serviceDate")]
		public DateTime? ServiceDate { get; set; }

		///<summary>
		/// End Date
		/// <para>Name: EndDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "endDate")]
		public DateTime? EndDate { get; set; }

		///<summary>
		/// Line Description
		/// <para>Name: Description</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

		///<summary>
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

		///<summary>
		/// Created By ID
		/// <para>Name: CreatedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdById")]
		[Updateable(false), Creatable(false)]
		public string CreatedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: CreatedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "createdBy")]
		[Updateable(false), Creatable(false)]
		public SfUser CreatedBy { get; set; }

		///<summary>
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

		///<summary>
		/// Last Modified By ID
		/// <para>Name: LastModifiedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedById")]
		[Updateable(false), Creatable(false)]
		public string LastModifiedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: LastModifiedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedBy")]
		[Updateable(false), Creatable(false)]
		public SfUser LastModifiedBy { get; set; }

		///<summary>
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

		///<summary>
		/// Order Product Number
		/// <para>Name: OrderItemNumber</para>
		/// <para>SF Type: string</para>
		/// <para>AutoNumber field</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "orderItemNumber")]
		[Updateable(false), Creatable(false)]
		public string OrderItemNumber { get; set; }

	}
}
