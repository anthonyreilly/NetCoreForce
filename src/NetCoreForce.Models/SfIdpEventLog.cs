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
	/// Identity Provider Event Log
	///<para>SObject Name: IdpEventLog</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfIdpEventLog : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "IdpEventLog"; }
		}

		///<summary>
		/// Event Log Entry ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// Usage Type
		/// <para>Name: InitiatedBy</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "initiatedBy")]
		[Updateable(false), Creatable(false)]
		public string InitiatedBy { get; set; }

		///<summary>
		/// Timestamp
		/// <para>Name: Timestamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "timestamp")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? Timestamp { get; set; }

		///<summary>
		/// Status
		/// <para>Name: ErrorCode</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "errorCode")]
		[Updateable(false), Creatable(false)]
		public string ErrorCode { get; set; }

		///<summary>
		/// Entity ID
		/// <para>Name: SamlEntityUrl</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "samlEntityUrl")]
		[Updateable(false), Creatable(false)]
		public string SamlEntityUrl { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: UserId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "userId")]
		[Updateable(false), Creatable(false)]
		public string UserId { get; set; }

		///<summary>
		/// Auth Session ID
		/// <para>Name: AuthSessionId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "authSessionId")]
		[Updateable(false), Creatable(false)]
		public string AuthSessionId { get; set; }

		///<summary>
		/// SSO Type
		/// <para>Name: SsoType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "ssoType")]
		[Updateable(false), Creatable(false)]
		public string SsoType { get; set; }

		///<summary>
		/// Connected App ID
		/// <para>Name: AppId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "appId")]
		[Updateable(false), Creatable(false)]
		public string AppId { get; set; }

		///<summary>
		/// Identity Used
		/// <para>Name: IdentityUsed</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "identityUsed")]
		[Updateable(false), Creatable(false)]
		public string IdentityUsed { get; set; }

		///<summary>
		/// Has Logout URL
		/// <para>Name: OptionsHasLogoutUrl</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsHasLogoutUrl")]
		[Updateable(false), Creatable(false)]
		public bool? OptionsHasLogoutUrl { get; set; }

	}
}
