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
	/// Email Service
	///<para>SObject Name: EmailServicesFunction</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfEmailServicesFunction : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "EmailServicesFunction"; }
		}

		///<summary>
		/// Service ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Active
		/// <para>Name: IsActive</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isActive")]
		public bool? IsActive { get; set; }

		///<summary>
		/// Email Service Name
		/// <para>Name: FunctionName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "functionName")]
		public string FunctionName { get; set; }

		///<summary>
		/// Accept Email From
		/// <para>Name: AuthorizedSenders</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "authorizedSenders")]
		public string AuthorizedSenders { get; set; }

		///<summary>
		/// Advanced Email Security Settings
		/// <para>Name: IsAuthenticationRequired</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isAuthenticationRequired")]
		public bool? IsAuthenticationRequired { get; set; }

		///<summary>
		/// TLS Required
		/// <para>Name: IsTlsRequired</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isTlsRequired")]
		public bool? IsTlsRequired { get; set; }

		///<summary>
		/// Accept Attachments
		/// <para>Name: AttachmentOption</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "attachmentOption")]
		public string AttachmentOption { get; set; }

		///<summary>
		/// Class ID
		/// <para>Name: ApexClassId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "apexClassId")]
		public string ApexClassId { get; set; }

		///<summary>
		/// Over email rate limit action
		/// <para>Name: OverLimitAction</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "overLimitAction")]
		public string OverLimitAction { get; set; }

		///<summary>
		/// Deactivated Email Service Action
		/// <para>Name: FunctionInactiveAction</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "functionInactiveAction")]
		public string FunctionInactiveAction { get; set; }

		///<summary>
		/// Deactivated Email Address Action
		/// <para>Name: AddressInactiveAction</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "addressInactiveAction")]
		public string AddressInactiveAction { get; set; }

		///<summary>
		/// Unauthenticated sender action
		/// <para>Name: AuthenticationFailureAction</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "authenticationFailureAction")]
		public string AuthenticationFailureAction { get; set; }

		///<summary>
		/// Unauthorized sender action
		/// <para>Name: AuthorizationFailureAction</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "authorizationFailureAction")]
		public string AuthorizationFailureAction { get; set; }

		///<summary>
		/// Enable Error Routing
		/// <para>Name: IsErrorRoutingEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isErrorRoutingEnabled")]
		public bool? IsErrorRoutingEnabled { get; set; }

		///<summary>
		/// Route Error Emails to This Email Address
		/// <para>Name: ErrorRoutingAddress</para>
		/// <para>SF Type: email</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "errorRoutingAddress")]
		public string ErrorRoutingAddress { get; set; }

		///<summary>
		/// Convert Text Attachments to Binary Attachments
		/// <para>Name: IsTextAttachmentsAsBinary</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isTextAttachmentsAsBinary")]
		public bool? IsTextAttachmentsAsBinary { get; set; }

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
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

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
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

		///<summary>
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

	}
}
