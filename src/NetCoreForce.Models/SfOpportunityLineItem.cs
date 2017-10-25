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
	/// Opportunity Product
	///<para>SObject Name: OpportunityLineItem</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfOpportunityLineItem : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "OpportunityLineItem"; }
		}

		///<summary>
		/// Line Item ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Opportunity ID
		/// <para>Name: OpportunityId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "opportunityId")]
		[Updateable(false), Createable(true)]
		public string OpportunityId { get; set; }

		///<summary>
		/// ReferenceTo: Opportunity
		/// <para>RelationshipName: Opportunity</para>
		///</summary>
		[JsonProperty(PropertyName = "opportunity")]
		[Updateable(false), Createable(false)]
		public SfOpportunity Opportunity { get; set; }

		///<summary>
		/// Sort Order
		/// <para>Name: SortOrder</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sortOrder")]
		[Updateable(false), Createable(false)]
		public int? SortOrder { get; set; }

		///<summary>
		/// Price Book Entry ID
		/// <para>Name: PricebookEntryId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "pricebookEntryId")]
		[Updateable(false), Createable(true)]
		public string PricebookEntryId { get; set; }

		///<summary>
		/// ReferenceTo: PricebookEntry
		/// <para>RelationshipName: PricebookEntry</para>
		///</summary>
		[JsonProperty(PropertyName = "pricebookEntry")]
		[Updateable(false), Createable(false)]
		public SfPricebookEntry PricebookEntry { get; set; }

		///<summary>
		/// Product ID
		/// <para>Name: Product2Id</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "product2Id")]
		[Updateable(false), Createable(true)]
		public string Product2Id { get; set; }

		///<summary>
		/// ReferenceTo: Product2
		/// <para>RelationshipName: Product2</para>
		///</summary>
		[JsonProperty(PropertyName = "product2")]
		[Updateable(false), Createable(false)]
		public SfProduct2 Product2 { get; set; }

		///<summary>
		/// Product Code
		/// <para>Name: ProductCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "productCode")]
		[Updateable(false), Createable(false)]
		public string ProductCode { get; set; }

		///<summary>
		/// Opportunity Product Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
		public string Name { get; set; }

		///<summary>
		/// Quantity
		/// <para>Name: Quantity</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "quantity")]
		public double? Quantity { get; set; }

		///<summary>
		/// Total Price
		/// <para>Name: TotalPrice</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalPrice")]
		public decimal? TotalPrice { get; set; }

		///<summary>
		/// Sales Price
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
		[Updateable(false), Createable(false)]
		public decimal? ListPrice { get; set; }

		///<summary>
		/// Date
		/// <para>Name: ServiceDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "serviceDate")]
		public string ServiceDate { get; set; }

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
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Createable(false)]
		public bool? IsDeleted { get; set; }

	}
}
