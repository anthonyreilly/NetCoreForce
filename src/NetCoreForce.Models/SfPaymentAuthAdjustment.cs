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
	/// Payment Authorization Adjustment
	///<para>SObject Name: PaymentAuthAdjustment</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfPaymentAuthAdjustment : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "PaymentAuthAdjustment"; }
		}

		///<summary>
		/// Payment Authorization Adjustment ID
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
		/// Payment Authorization Adjustment Number
		/// <para>Name: PaymentAuthAdjustmentNumber</para>
		/// <para>SF Type: string</para>
		/// <para>AutoNumber field</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentAuthAdjustmentNumber")]
		[Updateable(false), Createable(false)]
		public string PaymentAuthAdjustmentNumber { get; set; }

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
		/// Payment Authorization ID
		/// <para>Name: PaymentAuthorizationId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentAuthorizationId")]
		public string PaymentAuthorizationId { get; set; }

		///<summary>
		/// ReferenceTo: PaymentAuthorization
		/// <para>RelationshipName: PaymentAuthorization</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentAuthorization")]
		[Updateable(false), Createable(false)]
		public SfPaymentAuthorization PaymentAuthorization { get; set; }

		///<summary>
		/// Processing Mode
		/// <para>Name: ProcessingMode</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "processingMode")]
		public string ProcessingMode { get; set; }

		///<summary>
		/// Amount
		/// <para>Name: Amount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "amount")]
		public decimal? Amount { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		public string Status { get; set; }

		///<summary>
		/// Adjustment Type
		/// <para>Name: Type</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		public string Type { get; set; }

		///<summary>
		/// Date
		/// <para>Name: Date</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "date")]
		public DateTimeOffset? Date { get; set; }

		///<summary>
		/// Gateway Date
		/// <para>Name: GatewayDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "gatewayDate")]
		public DateTimeOffset? GatewayDate { get; set; }

		///<summary>
		/// Effective Date
		/// <para>Name: EffectiveDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "effectiveDate")]
		public DateTimeOffset? EffectiveDate { get; set; }

		///<summary>
		/// Comments
		/// <para>Name: Comments</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "comments")]
		public string Comments { get; set; }

		///<summary>
		/// Gateway Reference Number
		/// <para>Name: GatewayRefNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "gatewayRefNumber")]
		public string GatewayRefNumber { get; set; }

		///<summary>
		/// Gateway Result Code
		/// <para>Name: GatewayResultCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "gatewayResultCode")]
		public string GatewayResultCode { get; set; }

		///<summary>
		/// Salesforce Result Code
		/// <para>Name: SfResultCode</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sfResultCode")]
		public string SfResultCode { get; set; }

		///<summary>
		/// Account ID
		/// <para>Name: AccountId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "accountId")]
		public string AccountId { get; set; }

		///<summary>
		/// ReferenceTo: Account
		/// <para>RelationshipName: Account</para>
		///</summary>
		[JsonProperty(PropertyName = "account")]
		[Updateable(false), Createable(false)]
		public SfAccount Account { get; set; }

		///<summary>
		/// Gateway Reference Details
		/// <para>Name: GatewayRefDetails</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "gatewayRefDetails")]
		public string GatewayRefDetails { get; set; }

		///<summary>
		/// Gateway Result Code Description
		/// <para>Name: GatewayResultCodeDescription</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "gatewayResultCodeDescription")]
		public string GatewayResultCodeDescription { get; set; }

		///<summary>
		/// IP Address
		/// <para>Name: IpAddress</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "ipAddress")]
		public string IpAddress { get; set; }

		///<summary>
		/// MAC Address
		/// <para>Name: MacAddress</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "macAddress")]
		public string MacAddress { get; set; }

		///<summary>
		/// Phone
		/// <para>Name: Phone</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "phone")]
		public string Phone { get; set; }

		///<summary>
		/// Audit Email
		/// <para>Name: Email</para>
		/// <para>SF Type: email</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "email")]
		public string Email { get; set; }

	}
}
