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
	/// Payment Gateway Log
	///<para>SObject Name: PaymentGatewayLog</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfPaymentGatewayLog : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "PaymentGatewayLog"; }
		}

		///<summary>
		/// Payment Gateway Log ID
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
		/// PaymentGatewayLogNumber
		/// <para>Name: PaymentGatewayLogNumber</para>
		/// <para>SF Type: string</para>
		/// <para>AutoNumber field</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "paymentGatewayLogNumber")]
		[Updateable(false), Createable(false)]
		public string PaymentGatewayLogNumber { get; set; }

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
		/// ReferencedEntity ID
		/// <para>Name: ReferencedEntityId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "referencedEntityId")]
		public string ReferencedEntityId { get; set; }

		///<summary>
		/// Interaction Type
		/// <para>Name: InteractionType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "interactionType")]
		[Updateable(false), Createable(true)]
		public string InteractionType { get; set; }

		///<summary>
		/// SalesforceReferenceNumber
		/// <para>Name: SfRefNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sfRefNumber")]
		public string SfRefNumber { get; set; }

		///<summary>
		/// Status
		/// <para>Name: InteractionStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "interactionStatus")]
		public string InteractionStatus { get; set; }

		///<summary>
		/// GatewayAuthCode
		/// <para>Name: GatewayAuthCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "gatewayAuthCode")]
		public string GatewayAuthCode { get; set; }

		///<summary>
		/// GatewayReferenceNumber
		/// <para>Name: GatewayRefNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "gatewayRefNumber")]
		public string GatewayRefNumber { get; set; }

		///<summary>
		/// SalesforceResultCode
		/// <para>Name: SfResultCode</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sfResultCode")]
		public string SfResultCode { get; set; }

		///<summary>
		/// GatewayResultCode
		/// <para>Name: GatewayResultCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "gatewayResultCode")]
		public string GatewayResultCode { get; set; }

		///<summary>
		/// GatewayResultCode
		/// <para>Name: GatewayResultCodeDescription</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "gatewayResultCodeDescription")]
		public string GatewayResultCodeDescription { get; set; }

		///<summary>
		/// GatewayDate
		/// <para>Name: GatewayDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "gatewayDate")]
		public DateTimeOffset? GatewayDate { get; set; }

		///<summary>
		/// Gateway Message
		/// <para>Name: GatewayMessage</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "gatewayMessage")]
		public string GatewayMessage { get; set; }

		///<summary>
		/// GatewayAvsCode
		/// <para>Name: GatewayAvsCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "gatewayAvsCode")]
		public string GatewayAvsCode { get; set; }

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
		/// IsNotification
		/// <para>Name: IsNotification</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "isNotification")]
		public string IsNotification { get; set; }

		///<summary>
		/// Request
		/// <para>Name: Request</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "request")]
		public string Request { get; set; }

		///<summary>
		/// Response
		/// <para>Name: Response</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "response")]
		public string Response { get; set; }

	}
}
