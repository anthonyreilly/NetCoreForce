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
	/// Login Event
	///<para>SObject Name: LoginEvent</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfLoginEvent : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "LoginEvent"; }
		}

		///<summary>
		/// Login Event ID
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
		/// Username
		/// <para>Name: Username</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "username")]
		[Updateable(false), Createable(false)]
		public string Username { get; set; }

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
		/// Related Event Identifier
		/// <para>Name: RelatedEventIdentifier</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relatedEventIdentifier")]
		[Updateable(false), Createable(false)]
		public string RelatedEventIdentifier { get; set; }

		///<summary>
		/// Transaction Security Policy ID
		/// <para>Name: PolicyId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "policyId")]
		[Updateable(false), Createable(false)]
		public string PolicyId { get; set; }

		///<summary>
		/// ReferenceTo: TransactionSecurityPolicy
		/// <para>RelationshipName: Policy</para>
		///</summary>
		[JsonProperty(PropertyName = "policy")]
		[Updateable(false), Createable(false)]
		public SfTransactionSecurityPolicy Policy { get; set; }

		///<summary>
		/// Policy Outcome
		/// <para>Name: PolicyOutcome</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "policyOutcome")]
		[Updateable(false), Createable(false)]
		public string PolicyOutcome { get; set; }

		///<summary>
		/// Evaluation Time
		/// <para>Name: EvaluationTime</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "evaluationTime")]
		[Updateable(false), Createable(false)]
		public double? EvaluationTime { get; set; }

		///<summary>
		/// Session Key
		/// <para>Name: SessionKey</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sessionKey")]
		[Updateable(false), Createable(false)]
		public string SessionKey { get; set; }

		///<summary>
		/// Login Key
		/// <para>Name: LoginKey</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "loginKey")]
		[Updateable(false), Createable(false)]
		public string LoginKey { get; set; }

		///<summary>
		/// Session Level
		/// <para>Name: SessionLevel</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sessionLevel")]
		[Updateable(false), Createable(false)]
		public string SessionLevel { get; set; }

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
		/// Additional Information
		/// <para>Name: AdditionalInfo</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "additionalInfo")]
		[Updateable(false), Createable(false)]
		public string AdditionalInfo { get; set; }

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
		/// Application
		/// <para>Name: Application</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "application")]
		[Updateable(false), Createable(false)]
		public string Application { get; set; }

		///<summary>
		/// Authentication Service ID
		/// <para>Name: AuthServiceId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "authServiceId")]
		[Updateable(false), Createable(false)]
		public string AuthServiceId { get; set; }

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
		/// HTTP Method
		/// <para>Name: HttpMethod</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "httpMethod")]
		[Updateable(false), Createable(false)]
		public string HttpMethod { get; set; }

		///<summary>
		/// Country Code
		/// <para>Name: CountryIso</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "countryIso")]
		[Updateable(false), Createable(false)]
		public string CountryIso { get; set; }

		///<summary>
		/// Latitude
		/// <para>Name: LoginLatitude</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "loginLatitude")]
		[Updateable(false), Createable(false)]
		public double? LoginLatitude { get; set; }

		///<summary>
		/// Longitude
		/// <para>Name: LoginLongitude</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "loginLongitude")]
		[Updateable(false), Createable(false)]
		public double? LoginLongitude { get; set; }

		///<summary>
		/// Country
		/// <para>Name: Country</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "country")]
		[Updateable(false), Createable(false)]
		public string Country { get; set; }

		///<summary>
		/// City
		/// <para>Name: City</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "city")]
		[Updateable(false), Createable(false)]
		public string City { get; set; }

		///<summary>
		/// PostalCode
		/// <para>Name: PostalCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "postalCode")]
		[Updateable(false), Createable(false)]
		public string PostalCode { get; set; }

		///<summary>
		/// Subdivision
		/// <para>Name: Subdivision</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "subdivision")]
		[Updateable(false), Createable(false)]
		public string Subdivision { get; set; }

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
		/// Client Version
		/// <para>Name: ClientVersion</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "clientVersion")]
		[Updateable(false), Createable(false)]
		public string ClientVersion { get; set; }

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
		/// Login History ID
		/// <para>Name: LoginHistoryId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "loginHistoryId")]
		[Updateable(false), Createable(false)]
		public string LoginHistoryId { get; set; }

		///<summary>
		/// Login Type
		/// <para>Name: LoginType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "loginType")]
		[Updateable(false), Createable(false)]
		public string LoginType { get; set; }

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
		/// TLS Protocol
		/// <para>Name: TlsProtocol</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "tlsProtocol")]
		[Updateable(false), Createable(false)]
		public string TlsProtocol { get; set; }

		///<summary>
		/// User Type
		/// <para>Name: UserType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "userType")]
		[Updateable(false), Createable(false)]
		public string UserType { get; set; }

		///<summary>
		/// Authentication Method Reference
		/// <para>Name: AuthMethodReference</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "authMethodReference")]
		[Updateable(false), Createable(false)]
		public string AuthMethodReference { get; set; }

	}
}
