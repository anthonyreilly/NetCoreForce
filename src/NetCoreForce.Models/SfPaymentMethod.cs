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
	/// Payment Method
	///<para>SObject Name: PaymentMethod</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfPaymentMethod : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "PaymentMethod"; }
		}

		///<summary>
		/// Payment Method ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Implementor Type
		/// <para>Name: ImplementorType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "implementorType")]
		[Updateable(false), Createable(false)]
		public string ImplementorType { get; set; }

		///<summary>
		/// Account ID
		/// <para>Name: AccountId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "accountId")]
		[Updateable(false), Createable(false)]
		public string AccountId { get; set; }

		///<summary>
		/// ReferenceTo: Account
		/// <para>RelationshipName: Account</para>
		///</summary>
		[JsonProperty(PropertyName = "account")]
		[Updateable(false), Createable(false)]
		public SfAccount Account { get; set; }

		///<summary>
		/// Nickname
		/// <para>Name: NickName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "nickName")]
		[Updateable(false), Createable(false)]
		public string NickName { get; set; }

		///<summary>
		/// Company Name
		/// <para>Name: CompanyName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "companyName")]
		[Updateable(false), Createable(false)]
		public string CompanyName { get; set; }

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
		/// Comments
		/// <para>Name: Comments</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "comments")]
		[Updateable(false), Createable(false)]
		public string Comments { get; set; }

		///<summary>
		/// Auto Pay
		/// <para>Name: IsAutoPayEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isAutoPayEnabled")]
		[Updateable(false), Createable(false)]
		public bool? IsAutoPayEnabled { get; set; }

		///<summary>
		/// Street
		/// <para>Name: PaymentMethodStreet</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentMethodStreet")]
		[Updateable(false), Createable(false)]
		public string PaymentMethodStreet { get; set; }

		///<summary>
		/// City
		/// <para>Name: PaymentMethodCity</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentMethodCity")]
		[Updateable(false), Createable(false)]
		public string PaymentMethodCity { get; set; }

		///<summary>
		/// State
		/// <para>Name: PaymentMethodState</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentMethodState")]
		[Updateable(false), Createable(false)]
		public string PaymentMethodState { get; set; }

		///<summary>
		/// Postal Code
		/// <para>Name: PaymentMethodPostalCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentMethodPostalCode")]
		[Updateable(false), Createable(false)]
		public string PaymentMethodPostalCode { get; set; }

		///<summary>
		/// Country
		/// <para>Name: PaymentMethodCountry</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentMethodCountry")]
		[Updateable(false), Createable(false)]
		public string PaymentMethodCountry { get; set; }

		///<summary>
		/// Latitude
		/// <para>Name: PaymentMethodLatitude</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentMethodLatitude")]
		[Updateable(false), Createable(false)]
		public double? PaymentMethodLatitude { get; set; }

		///<summary>
		/// Longitude
		/// <para>Name: PaymentMethodLongitude</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentMethodLongitude")]
		[Updateable(false), Createable(false)]
		public double? PaymentMethodLongitude { get; set; }

		///<summary>
		/// Geo Code Accuracy
		/// <para>Name: PaymentMethodGeocodeAccuracy</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentMethodGeocodeAccuracy")]
		[Updateable(false), Createable(false)]
		public string PaymentMethodGeocodeAccuracy { get; set; }

		///<summary>
		/// Payment Method Address
		/// <para>Name: PaymentMethodAddress</para>
		/// <para>SF Type: address</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentMethodAddress")]
		[Updateable(false), Createable(false)]
		public Address PaymentMethodAddress { get; set; }

		///<summary>
		/// Payment Method Type
		/// <para>Name: PaymentMethodType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentMethodType")]
		[Updateable(false), Createable(false)]
		public string PaymentMethodType { get; set; }

		///<summary>
		/// Payment Method Sub Type
		/// <para>Name: PaymentMethodSubType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentMethodSubType")]
		[Updateable(false), Createable(false)]
		public string PaymentMethodSubType { get; set; }

		///<summary>
		/// Payment Method Details
		/// <para>Name: PaymentMethodDetails</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentMethodDetails")]
		[Updateable(false), Createable(false)]
		public string PaymentMethodDetails { get; set; }

		///<summary>
		/// User ID
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
		/// __MISSING LABEL__ PropertyFile - val CreatedDate not found in section udd_PaymentMethod
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

		///<summary>
		/// User ID
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
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

		///<summary>
		/// __MISSING LABEL__ PropertyFile - val SystemModstamp not found in section udd_PaymentMethod
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

		///<summary>
		/// __MISSING LABEL__ PropertyFile - val IsDeleted not found in section udd_PaymentMethod
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Createable(false)]
		public bool? IsDeleted { get; set; }

		///<summary>
		/// Payment Method Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
		public string Name { get; set; }

	}
}
