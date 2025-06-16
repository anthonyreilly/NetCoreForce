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
	/// External Client Application OAuth Settings
	///<para>SObject Name: ExtlClntAppOauthSettings</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfExtlClntAppOauthSettings : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ExtlClntAppOauthSettings"; }
		}

		///<summary>
		/// External Client Application OAuth Settings ID
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
		/// Namespace Prefix
		/// <para>Name: NamespacePrefix</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "namespacePrefix")]
		[Updateable(false), Createable(false)]
		public string NamespacePrefix { get; set; }

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
		/// SSO
		/// <para>Name: OauthScopesSSO</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesSSO")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesSSO { get; set; }

		///<summary>
		/// API
		/// <para>Name: OauthScopesAPI</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesAPI")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesAPI { get; set; }

		///<summary>
		/// WEB
		/// <para>Name: OauthScopesWEB</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesWEB")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesWEB { get; set; }

		///<summary>
		/// FULL
		/// <para>Name: OauthScopesFULL</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesFULL")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesFULL { get; set; }

		///<summary>
		/// CHATTER_REST_API
		/// <para>Name: OauthScopesCHATTER_REST_API</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesCHATTER_REST_API")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesCHATTER_REST_API { get; set; }

		///<summary>
		/// VF
		/// <para>Name: OauthScopesVF</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesVF")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesVF { get; set; }

		///<summary>
		/// REFRESH_TOKEN
		/// <para>Name: OauthScopesREFRESH_TOKEN</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesREFRESH_TOKEN")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesREFRESH_TOKEN { get; set; }

		///<summary>
		/// OPENID
		/// <para>Name: OauthScopesOPENID</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesOPENID")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesOPENID { get; set; }

		///<summary>
		/// PROFILE
		/// <para>Name: OauthScopesPROFILE</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesPROFILE")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesPROFILE { get; set; }

		///<summary>
		/// EMAIL
		/// <para>Name: OauthScopesEMAIL</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesEMAIL")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesEMAIL { get; set; }

		///<summary>
		/// ADDRESS
		/// <para>Name: OauthScopesADDRESS</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesADDRESS")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesADDRESS { get; set; }

		///<summary>
		/// PHONE
		/// <para>Name: OauthScopesPHONE</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesPHONE")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesPHONE { get; set; }

		///<summary>
		/// OFFLINE_ACCESS
		/// <para>Name: OauthScopesOFFLINE_ACCESS</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesOFFLINE_ACCESS")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesOFFLINE_ACCESS { get; set; }

		///<summary>
		/// CUSTOM_PERMISSIONS
		/// <para>Name: OauthScopesCUSTOM_PERMISSIONS</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesCUSTOM_PERMISSIONS")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesCUSTOM_PERMISSIONS { get; set; }

		///<summary>
		/// WAVE_REST_API
		/// <para>Name: OauthScopesWAVE_REST_API</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesWAVE_REST_API")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesWAVE_REST_API { get; set; }

		///<summary>
		/// ECLAIR_REST_API
		/// <para>Name: OauthScopesECLAIR_REST_API</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesECLAIR_REST_API")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesECLAIR_REST_API { get; set; }

		///<summary>
		/// HUB_API
		/// <para>Name: OauthScopesHUB_API</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesHUB_API")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesHUB_API { get; set; }

		///<summary>
		/// PARDOT_API
		/// <para>Name: OauthScopesPARDOT_API</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesPARDOT_API")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesPARDOT_API { get; set; }

		///<summary>
		/// LIGHTNING
		/// <para>Name: OauthScopesLIGHTNING</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesLIGHTNING")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesLIGHTNING { get; set; }

		///<summary>
		/// CONTENT
		/// <para>Name: OauthScopesCONTENT</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesCONTENT")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesCONTENT { get; set; }

		///<summary>
		/// CDP_INGEST_API
		/// <para>Name: OauthScopesCDP_INGEST_API</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesCDP_INGEST_API")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesCDP_INGEST_API { get; set; }

		///<summary>
		/// CDP_PROFILE_API
		/// <para>Name: OauthScopesCDP_PROFILE_API</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesCDP_PROFILE_API")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesCDP_PROFILE_API { get; set; }

		///<summary>
		/// CDP_QUERY_API
		/// <para>Name: OauthScopesCDP_QUERY_API</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesCDP_QUERY_API")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesCDP_QUERY_API { get; set; }

		///<summary>
		/// CHATBOT_API
		/// <para>Name: OauthScopesCHATBOT_API</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesCHATBOT_API")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesCHATBOT_API { get; set; }

		///<summary>
		/// CDP_SEGMENT_API
		/// <para>Name: OauthScopesCDP_SEGMENT_API</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesCDP_SEGMENT_API")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesCDP_SEGMENT_API { get; set; }

		///<summary>
		/// CDP_IDENTITYRESOLUTION_API
		/// <para>Name: OauthScopesCDP_IDENTITYRESOLUTION_API</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesCDP_IDENTITYRESOLUTION_API")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesCDP_IDENTITYRESOLUTION_API { get; set; }

		///<summary>
		/// FORGOT_PASSWORD
		/// <para>Name: OauthScopesFORGOT_PASSWORD</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesFORGOT_PASSWORD")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesFORGOT_PASSWORD { get; set; }

		///<summary>
		/// CDP_CALCULATED_INSIGHT_API
		/// <para>Name: OauthScopesCDP_CALCULATED_INSIGHT_API</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesCDP_CALCULATED_INSIGHT_API")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesCDP_CALCULATED_INSIGHT_API { get; set; }

		///<summary>
		/// USER_REGISTRATION_API
		/// <para>Name: OauthScopesUSER_REGISTRATION_API</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesUSER_REGISTRATION_API")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesUSER_REGISTRATION_API { get; set; }

		///<summary>
		/// SFAP_API
		/// <para>Name: OauthScopesSFAP_API</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesSFAP_API")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesSFAP_API { get; set; }

		///<summary>
		/// INTERACTION_API
		/// <para>Name: OauthScopesINTERACTION_API</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesINTERACTION_API")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesINTERACTION_API { get; set; }

		///<summary>
		/// CDP_API
		/// <para>Name: OauthScopesCDP_API</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesCDP_API")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesCDP_API { get; set; }

		///<summary>
		/// EINSTEIN_GPT_API
		/// <para>Name: OauthScopesEINSTEIN_GPT_API</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesEINSTEIN_GPT_API")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesEINSTEIN_GPT_API { get; set; }

		///<summary>
		/// PWDLESS_LOGIN_API
		/// <para>Name: OauthScopesPWDLESS_LOGIN_API</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthScopesPWDLESS_LOGIN_API")]
		[Updateable(false), Createable(false)]
		public bool? OauthScopesPWDLESS_LOGIN_API { get; set; }

		///<summary>
		/// OAuth Link
		/// <para>Name: OauthLink</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthLink")]
		[Updateable(false), Createable(false)]
		public string OauthLink { get; set; }

		///<summary>
		/// Single Logout URL
		/// <para>Name: SingleLogoutUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "singleLogoutUrl")]
		[Updateable(false), Createable(false)]
		public string SingleLogoutUrl { get; set; }

		///<summary>
		/// FirstPartyAppEnabled
		/// <para>Name: ExtlClntAppOauthOptionsFirstPartyAppEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "extlClntAppOauthOptionsFirstPartyAppEnabled")]
		[Updateable(false), Createable(false)]
		public bool? ExtlClntAppOauthOptionsFirstPartyAppEnabled { get; set; }

		///<summary>
		/// Client Assertion Certificate
		/// <para>Name: ClientAssertionCertificate</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "clientAssertionCertificate")]
		[Updateable(false), Createable(false)]
		public string ClientAssertionCertificate { get; set; }

	}
}
