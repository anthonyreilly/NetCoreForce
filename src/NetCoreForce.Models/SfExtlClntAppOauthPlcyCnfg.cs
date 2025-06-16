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
	/// External Client App OAuth Policy Config
	///<para>SObject Name: ExtlClntAppOauthPlcyCnfg</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfExtlClntAppOauthPlcyCnfg : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ExtlClntAppOauthPlcyCnfg"; }
		}

		///<summary>
		/// External Client App OAuth Policy Config ID
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
		/// Name
		/// <para>Name: DeveloperName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "developerName")]
		[Updateable(false), Createable(false)]
		public string DeveloperName { get; set; }

		///<summary>
		/// Master Language
		/// <para>Name: Language</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "language")]
		[Updateable(false), Createable(false)]
		public string Language { get; set; }

		///<summary>
		/// Label
		/// <para>Name: MasterLabel</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "masterLabel")]
		[Updateable(false), Createable(false)]
		public string MasterLabel { get; set; }

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
		/// External App ID
		/// <para>Name: ExternalClientApplicationId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "externalClientApplicationId")]
		[Updateable(false), Createable(false)]
		public string ExternalClientApplicationId { get; set; }

		///<summary>
		/// ReferenceTo: ExternalClientApplication
		/// <para>RelationshipName: ExternalClientApplication</para>
		///</summary>
		[JsonProperty(PropertyName = "externalClientApplication")]
		[Updateable(false), Createable(false)]
		public SfExternalClientApplication ExternalClientApplication { get; set; }

		///<summary>
		/// Refresh Token Policy Type
		/// <para>Name: RefreshTokenPolicyType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "refreshTokenPolicyType")]
		[Updateable(false), Createable(false)]
		public string RefreshTokenPolicyType { get; set; }

		///<summary>
		/// Refresh Token Validity Period
		/// <para>Name: RefreshTokenValidityPeriod</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "refreshTokenValidityPeriod")]
		[Updateable(false), Createable(false)]
		public int? RefreshTokenValidityPeriod { get; set; }

		///<summary>
		/// Refresh Token Validity Unit
		/// <para>Name: RefreshTokenValidityUnit</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "refreshTokenValidityUnit")]
		[Updateable(false), Createable(false)]
		public string RefreshTokenValidityUnit { get; set; }

		///<summary>
		/// IP Relaxation Policy Type
		/// <para>Name: IpRelaxationPolicyType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "ipRelaxationPolicyType")]
		[Updateable(false), Createable(false)]
		public string IpRelaxationPolicyType { get; set; }

		///<summary>
		/// Permitted Users Policy Type
		/// <para>Name: PermittedUsersPolicyType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permittedUsersPolicyType")]
		[Updateable(false), Createable(false)]
		public string PermittedUsersPolicyType { get; set; }

		///<summary>
		/// Session Timeout Value
		/// <para>Name: SessionTimeoutInMinutes</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sessionTimeoutInMinutes")]
		[Updateable(false), Createable(false)]
		public int? SessionTimeoutInMinutes { get; set; }

		///<summary>
		/// Required Session Level
		/// <para>Name: RequiredSessionLevel</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "requiredSessionLevel")]
		[Updateable(false), Createable(false)]
		public string RequiredSessionLevel { get; set; }

		///<summary>
		/// Policy Action
		/// <para>Name: PolicyAction</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "policyAction")]
		[Updateable(false), Createable(false)]
		public string PolicyAction { get; set; }

		///<summary>
		/// External Client Application OAuth Settings ID
		/// <para>Name: ExtlClntAppOauthSettingsId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "extlClntAppOauthSettingsId")]
		[Updateable(false), Createable(false)]
		public string ExtlClntAppOauthSettingsId { get; set; }

		///<summary>
		/// ReferenceTo: ExtlClntAppOauthSettings
		/// <para>RelationshipName: ExtlClntAppOauthSettings</para>
		///</summary>
		[JsonProperty(PropertyName = "extlClntAppOauthSettings")]
		[Updateable(false), Createable(false)]
		public SfExtlClntAppOauthSettings ExtlClntAppOauthSettings { get; set; }

		///<summary>
		/// Is Client Credentials Flow Enabled
		/// <para>Name: IsClientCredentialsFlowEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isClientCredentialsFlowEnabled")]
		[Updateable(false), Createable(false)]
		public bool? IsClientCredentialsFlowEnabled { get; set; }

		///<summary>
		/// OAuth Client Credentials Flow User
		/// <para>Name: ClientCredentialsFlowUser</para>
		/// <para>SF Type: email</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "clientCredentialsFlowUser")]
		[Updateable(false), Createable(false)]
		public string ClientCredentialsFlowUser { get; set; }

		///<summary>
		/// Class ID
		/// <para>Name: ApexHandlerId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "apexHandlerId")]
		[Updateable(false), Createable(false)]
		public string ApexHandlerId { get; set; }

		///<summary>
		/// ReferenceTo: ApexClass
		/// <para>RelationshipName: ApexHandler</para>
		///</summary>
		[JsonProperty(PropertyName = "apexHandler")]
		[Updateable(false), Createable(false)]
		public SfApexClass ApexHandler { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: ExecuteHandlerAsId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "executeHandlerAsId")]
		[Updateable(false), Createable(false)]
		public string ExecuteHandlerAsId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: ExecuteHandlerAs</para>
		///</summary>
		[JsonProperty(PropertyName = "executeHandlerAs")]
		[Updateable(false), Createable(false)]
		public SfUser ExecuteHandlerAs { get; set; }

		///<summary>
		/// Single Logout Url
		/// <para>Name: SingleLogoutUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "singleLogoutUrl")]
		[Updateable(false), Createable(false)]
		public string SingleLogoutUrl { get; set; }

		///<summary>
		/// Start Url
		/// <para>Name: StartUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "startUrl")]
		[Updateable(false), Createable(false)]
		public string StartUrl { get; set; }

		///<summary>
		/// Is Token Exchange Flow Enabled
		/// <para>Name: IsTokenExchangeFlowEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isTokenExchangeFlowEnabled")]
		[Updateable(false), Createable(false)]
		public bool? IsTokenExchangeFlowEnabled { get; set; }

		///<summary>
		/// Is Code and Credential Flow Enabled for Guest
		/// <para>Name: IsGuestCodeCredFlowEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isGuestCodeCredFlowEnabled")]
		[Updateable(false), Createable(false)]
		public bool? IsGuestCodeCredFlowEnabled { get; set; }

		///<summary>
		/// Is Named User JWTs Enabled
		/// <para>Name: IsNamedUserJwtEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isNamedUserJwtEnabled")]
		[Updateable(false), Createable(false)]
		public bool? IsNamedUserJwtEnabled { get; set; }

		///<summary>
		/// Guest JWT Timeout
		/// <para>Name: GuestJwtTimeout</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "guestJwtTimeout")]
		[Updateable(false), Createable(false)]
		public string GuestJwtTimeout { get; set; }

		///<summary>
		/// Named User JWT Timeout
		/// <para>Name: NamedUserJwtTimeout</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "namedUserJwtTimeout")]
		[Updateable(false), Createable(false)]
		public string NamedUserJwtTimeout { get; set; }

	}
}
