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
	/// Login History
	///<para>SObject Name: LoginHistory</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfLoginHistory : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "LoginHistory"; }
		}

		///<summary>
		/// Login History Id
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

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
		/// Login Time
		/// <para>Name: LoginTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "loginTime")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LoginTime { get; set; }

		///<summary>
		/// Login Type
		/// <para>Name: LoginType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "loginType")]
		[Updateable(false), Createable(false)]
		public string LoginType { get; set; }

		///<summary>
		/// Source IP
		/// <para>Name: SourceIp</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sourceIp")]
		[Updateable(false), Createable(false)]
		public string SourceIp { get; set; }

		///<summary>
		/// Login URL
		/// <para>Name: LoginUrl</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "loginUrl")]
		[Updateable(false), Createable(false)]
		public string LoginUrl { get; set; }

		///<summary>
		/// Authentication Service ID
		/// <para>Name: AuthenticationServiceId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "authenticationServiceId")]
		[Updateable(false), Createable(false)]
		public string AuthenticationServiceId { get; set; }

		///<summary>
		/// Login Geo Data ID
		/// <para>Name: LoginGeoId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "loginGeoId")]
		[Updateable(false), Createable(false)]
		public string LoginGeoId { get; set; }

		///<summary>
		/// ReferenceTo: LoginGeo
		/// <para>RelationshipName: LoginGeo</para>
		///</summary>
		[JsonProperty(PropertyName = "loginGeo")]
		[Updateable(false), Createable(false)]
		public SfLoginGeo LoginGeo { get; set; }

		///<summary>
		/// TLS Protocol
		/// <para>Name: TlsProtocol</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "tlsProtocol")]
		[Updateable(false), Createable(false)]
		public string TlsProtocol { get; set; }

		///<summary>
		/// TLS Cipher Suite
		/// <para>Name: CipherSuite</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "cipherSuite")]
		[Updateable(false), Createable(false)]
		public string CipherSuite { get; set; }

		///<summary>
		/// Browser
		/// <para>Name: Browser</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "browser")]
		[Updateable(false), Createable(false)]
		public string Browser { get; set; }

		///<summary>
		/// Platform
		/// <para>Name: Platform</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "platform")]
		[Updateable(false), Createable(false)]
		public string Platform { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		[Updateable(false), Createable(false)]
		public string Status { get; set; }

		///<summary>
		/// Application
		/// <para>Name: Application</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "application")]
		[Updateable(false), Createable(false)]
		public string Application { get; set; }

		///<summary>
		/// Client Version
		/// <para>Name: ClientVersion</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "clientVersion")]
		[Updateable(false), Createable(false)]
		public string ClientVersion { get; set; }

		///<summary>
		/// API Type
		/// <para>Name: ApiType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "apiType")]
		[Updateable(false), Createable(false)]
		public string ApiType { get; set; }

		///<summary>
		/// API Version
		/// <para>Name: ApiVersion</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "apiVersion")]
		[Updateable(false), Createable(false)]
		public string ApiVersion { get; set; }

		///<summary>
		/// Country Code
		/// <para>Name: CountryIso</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "countryIso")]
		[Updateable(false), Createable(false)]
		public string CountryIso { get; set; }

	}
}
