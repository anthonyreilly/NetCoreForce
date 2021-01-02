// SF API version v50.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Payment
	///<para>SObject Name: Payment</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfPayment : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "Payment"; }
		}

		///<summary>
		/// Payment ID
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
		/// Payment Number
		/// <para>Name: PaymentNumber</para>
		/// <para>SF Type: string</para>
		/// <para>AutoNumber field</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentNumber")]
		[Updateable(false), Createable(false)]
		public string PaymentNumber { get; set; }

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
		/// Payment Group ID
		/// <para>Name: PaymentGroupId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentGroupId")]
		public string PaymentGroupId { get; set; }

		///<summary>
		/// ReferenceTo: PaymentGroup
		/// <para>RelationshipName: PaymentGroup</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentGroup")]
		[Updateable(false), Createable(false)]
		public SfPaymentGroup PaymentGroup { get; set; }

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
		/// Payment Authorization ID
		/// <para>Name: PaymentAuthorizationId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
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
		/// Date
		/// <para>Name: Date</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "date")]
		public DateTimeOffset? Date { get; set; }

		///<summary>
		/// Cancellation Date
		/// <para>Name: CancellationDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "cancellationDate")]
		public DateTimeOffset? CancellationDate { get; set; }

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
		/// Type
		/// <para>Name: Type</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		public string Type { get; set; }

		///<summary>
		/// Processing Mode
		/// <para>Name: ProcessingMode</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "processingMode")]
		[Updateable(false), Createable(true)]
		public string ProcessingMode { get; set; }

		///<summary>
		/// Gateway Reference Number
		/// <para>Name: GatewayRefNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "gatewayRefNumber")]
		public string GatewayRefNumber { get; set; }

		///<summary>
		/// Client Context
		/// <para>Name: ClientContext</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "clientContext")]
		[Updateable(false), Createable(false)]
		public string ClientContext { get; set; }

		///<summary>
		/// Gateway ResultCode
		/// <para>Name: GatewayResultCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "gatewayResultCode")]
		public string GatewayResultCode { get; set; }

		///<summary>
		/// Salesforce ResultCode
		/// <para>Name: SfResultCode</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sfResultCode")]
		public string SfResultCode { get; set; }

		///<summary>
		/// Gateway Date
		/// <para>Name: GatewayDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "gatewayDate")]
		public DateTimeOffset? GatewayDate { get; set; }

		///<summary>
		/// Cancellation Gateway Reference Number
		/// <para>Name: CancellationGatewayRefNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "cancellationGatewayRefNumber")]
		public string CancellationGatewayRefNumber { get; set; }

		///<summary>
		/// Cancellation Gateway ResultCode
		/// <para>Name: CancellationGatewayResultCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "cancellationGatewayResultCode")]
		public string CancellationGatewayResultCode { get; set; }

		///<summary>
		/// Cancellation Salesforce ResultCode
		/// <para>Name: CancellationSfResultCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "cancellationSfResultCode")]
		public string CancellationSfResultCode { get; set; }

		///<summary>
		/// Cancellation Gateway Date
		/// <para>Name: CancellationGatewayDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "cancellationGatewayDate")]
		public DateTimeOffset? CancellationGatewayDate { get; set; }

		///<summary>
		/// Comments
		/// <para>Name: Comments</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "comments")]
		public string Comments { get; set; }

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
		/// Effective Date
		/// <para>Name: EffectiveDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "effectiveDate")]
		public DateTimeOffset? EffectiveDate { get; set; }

		///<summary>
		/// Cancellation Effective Date
		/// <para>Name: CancellationEffectiveDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "cancellationEffectiveDate")]
		public DateTimeOffset? CancellationEffectiveDate { get; set; }

		///<summary>
		/// Gateway ResultCode Description
		/// <para>Name: GatewayResultCodeDescription</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "gatewayResultCodeDescription")]
		public string GatewayResultCodeDescription { get; set; }

		///<summary>
		/// Gateway Reference Details
		/// <para>Name: GatewayRefDetails</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "gatewayRefDetails")]
		public string GatewayRefDetails { get; set; }

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

		///<summary>
		/// Payment Gateway ID
		/// <para>Name: PaymentGatewayId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentGatewayId")]
		public string PaymentGatewayId { get; set; }

		///<summary>
		/// ReferenceTo: PaymentGateway
		/// <para>RelationshipName: PaymentGateway</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentGateway")]
		[Updateable(false), Createable(false)]
		public SfPaymentGateway PaymentGateway { get; set; }

		///<summary>
		/// Payment Method ID
		/// <para>Name: PaymentMethodId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentMethodId")]
		public string PaymentMethodId { get; set; }

		///<summary>
		/// ReferenceTo: PaymentMethod
		/// <para>RelationshipName: PaymentMethod</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentMethod")]
		[Updateable(false), Createable(false)]
		public SfPaymentMethod PaymentMethod { get; set; }

		///<summary>
		/// Total Applied
		/// <para>Name: TotalApplied</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalApplied")]
		[Updateable(false), Createable(false)]
		public decimal? TotalApplied { get; set; }

		///<summary>
		/// Total Unapplied
		/// <para>Name: TotalUnapplied</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalUnapplied")]
		[Updateable(false), Createable(false)]
		public decimal? TotalUnapplied { get; set; }

		///<summary>
		/// Net Applied
		/// <para>Name: NetApplied</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "netApplied")]
		[Updateable(false), Createable(false)]
		public decimal? NetApplied { get; set; }

		///<summary>
		/// Balance
		/// <para>Name: Balance</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "balance")]
		[Updateable(false), Createable(false)]
		public decimal? Balance { get; set; }

		///<summary>
		/// Total Refund Applied
		/// <para>Name: TotalRefundApplied</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalRefundApplied")]
		[Updateable(false), Createable(false)]
		public decimal? TotalRefundApplied { get; set; }

		///<summary>
		/// Total Refund Unapplied
		/// <para>Name: TotalRefundUnapplied</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalRefundUnapplied")]
		[Updateable(false), Createable(false)]
		public decimal? TotalRefundUnapplied { get; set; }

		///<summary>
		/// Net Refund Applied
		/// <para>Name: NetRefundApplied</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "netRefundApplied")]
		[Updateable(false), Createable(false)]
		public decimal? NetRefundApplied { get; set; }

	}
}
