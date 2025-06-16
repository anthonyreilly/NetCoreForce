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
	/// Identity Provider Event Store
	///<para>SObject Name: IdentityProviderEventStore</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfIdentityProviderEventStore : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "IdentityProviderEventStore"; }
		}

		///<summary>
		/// Identity Provider Event Store ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

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
		/// Event Identifier
		/// <para>Name: EventIdentifier</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "eventIdentifier")]
		[Updateable(false), Createable(false)]
		public string EventIdentifier { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: UserId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "userId")]
		[Updateable(false), Createable(false)]
		public string UserId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: User</para>
		///</summary>
		[JsonProperty(PropertyName = "user")]
		[Updateable(false), Createable(false)]
		public SfUser User { get; set; }

		///<summary>
		/// Event Date
		/// <para>Name: EventDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "eventDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? EventDate { get; set; }

		///<summary>
		/// Identity Used
		/// <para>Name: IdentityUsed</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "identityUsed")]
		[Updateable(false), Createable(false)]
		public string IdentityUsed { get; set; }

		///<summary>
		/// Entity ID
		/// <para>Name: SamlEntityUrl</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "samlEntityUrl")]
		[Updateable(false), Createable(false)]
		public string SamlEntityUrl { get; set; }

		///<summary>
		/// Usage Type
		/// <para>Name: InitiatedBy</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "initiatedBy")]
		[Updateable(false), Createable(false)]
		public string InitiatedBy { get; set; }

		///<summary>
		/// Status
		/// <para>Name: ErrorCode</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "errorCode")]
		[Updateable(false), Createable(false)]
		public string ErrorCode { get; set; }

		///<summary>
		/// SSO Type
		/// <para>Name: SsoType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "ssoType")]
		[Updateable(false), Createable(false)]
		public string SsoType { get; set; }

		///<summary>
		/// Auth Session ID
		/// <para>Name: AuthSessionId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "authSessionId")]
		[Updateable(false), Createable(false)]
		public string AuthSessionId { get; set; }

		///<summary>
		/// ReferenceTo: AuthSession
		/// <para>RelationshipName: AuthSession</para>
		///</summary>
		[JsonProperty(PropertyName = "authSession")]
		[Updateable(false), Createable(false)]
		public SfAuthSession AuthSession { get; set; }

		///<summary>
		/// Connected App ID
		/// <para>Name: AppId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "appId")]
		[Updateable(false), Createable(false)]
		public string AppId { get; set; }

		///<summary>
		/// ReferenceTo: ConnectedApplication
		/// <para>RelationshipName: App</para>
		///</summary>
		[JsonProperty(PropertyName = "app")]
		[Updateable(false), Createable(false)]
		public SfConnectedApplication App { get; set; }

		///<summary>
		/// Has Logout URL
		/// <para>Name: HasLogoutUrl</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasLogoutUrl")]
		[Updateable(false), Createable(false)]
		public bool? HasLogoutUrl { get; set; }

	}
}
