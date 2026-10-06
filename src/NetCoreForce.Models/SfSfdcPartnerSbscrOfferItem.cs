// SF API version v67.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Partner Offer Item
	///<para>SObject Name: SfdcPartnerSbscrOfferItem</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfSfdcPartnerSbscrOfferItem : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "SfdcPartnerSbscrOfferItem"; }
		}

		///<summary>
		/// Partner Subscriber Offer Item ID
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
		/// Offer Item Number
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
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
		/// Partner Subscriber Offer ID
		/// <para>Name: PartnerSubscriberOfferId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "partnerSubscriberOfferId")]
		[Updateable(false), Createable(false)]
		public string PartnerSubscriberOfferId { get; set; }

		///<summary>
		/// ReferenceTo: SfdcPartnerSbscrOffer
		/// <para>RelationshipName: PartnerSubscriberOffer</para>
		///</summary>
		[JsonProperty(PropertyName = "partnerSubscriberOffer")]
		[Updateable(false), Createable(false)]
		public SfSfdcPartnerSbscrOffer PartnerSubscriberOffer { get; set; }

		///<summary>
		/// Product Name
		/// <para>Name: PartnerProvisionProductName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "partnerProvisionProductName")]
		[Updateable(false), Createable(false)]
		public string PartnerProvisionProductName { get; set; }

		///<summary>
		/// Product Quantity
		/// <para>Name: Quantity</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "quantity")]
		[Updateable(false), Createable(false)]
		public int? Quantity { get; set; }

		///<summary>
		/// Unit Price Per Month
		/// <para>Name: CustomerUnitPricePerMonth</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "customerUnitPricePerMonth")]
		[Updateable(false), Createable(false)]
		public decimal? CustomerUnitPricePerMonth { get; set; }

		///<summary>
		/// Line Item Period Total
		/// <para>Name: LineItemPeriodTotal</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lineItemPeriodTotal")]
		[Updateable(false), Createable(false)]
		public decimal? LineItemPeriodTotal { get; set; }

		///<summary>
		/// Line Item Total
		/// <para>Name: LineItemTotal</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lineItemTotal")]
		[Updateable(false), Createable(false)]
		public decimal? LineItemTotal { get; set; }

		///<summary>
		/// Service Start Date
		/// <para>Name: ServiceStartDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "serviceStartDate")]
		[Updateable(false), Createable(false)]
		public DateTime? ServiceStartDate { get; set; }

	}
}
