// SF API version v48.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// SAML Single Sign-On Setting
	///<para>SObject Name: SamlSsoConfig</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfSamlSsoConfig : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "SamlSsoConfig"; }
		}

		///<summary>
		/// SAML Single Sign-On Setting ID
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
		/// SAML Version
		/// <para>Name: Version</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "version")]
		[Updateable(false), Createable(false)]
		public string Version { get; set; }

		///<summary>
		/// Issuer
		/// <para>Name: Issuer</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "issuer")]
		[Updateable(false), Createable(false)]
		public string Issuer { get; set; }

		///<summary>
		/// SpInitBinding
		/// <para>Name: OptionsSpInitBinding</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsSpInitBinding")]
		[Updateable(false), Createable(false)]
		public bool? OptionsSpInitBinding { get; set; }

		///<summary>
		/// UserProvisioning
		/// <para>Name: OptionsUserProvisioning</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsUserProvisioning")]
		[Updateable(false), Createable(false)]
		public bool? OptionsUserProvisioning { get; set; }

		///<summary>
		/// Name ID Format
		/// <para>Name: AttributeFormat</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "attributeFormat")]
		[Updateable(false), Createable(false)]
		public string AttributeFormat { get; set; }

		///<summary>
		/// Attribute Name
		/// <para>Name: AttributeName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "attributeName")]
		[Updateable(false), Createable(false)]
		public string AttributeName { get; set; }

		///<summary>
		/// Entity ID
		/// <para>Name: Audience</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "audience")]
		[Updateable(false), Createable(false)]
		public string Audience { get; set; }

		///<summary>
		/// SAML Identity Type
		/// <para>Name: IdentityMapping</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "identityMapping")]
		[Updateable(false), Createable(false)]
		public string IdentityMapping { get; set; }

		///<summary>
		/// SAML Identity Location
		/// <para>Name: IdentityLocation</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "identityLocation")]
		[Updateable(false), Createable(false)]
		public string IdentityLocation { get; set; }

		///<summary>
		/// Class ID
		/// <para>Name: SamlJitHandlerId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "samlJitHandlerId")]
		[Updateable(false), Createable(false)]
		public string SamlJitHandlerId { get; set; }

		///<summary>
		/// ReferenceTo: ApexClass
		/// <para>RelationshipName: SamlJitHandler</para>
		///</summary>
		[JsonProperty(PropertyName = "samlJitHandler")]
		[Updateable(false), Createable(false)]
		public SfApexClass SamlJitHandler { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: ExecutionUserId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "executionUserId")]
		[Updateable(false), Createable(false)]
		public string ExecutionUserId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: ExecutionUser</para>
		///</summary>
		[JsonProperty(PropertyName = "executionUser")]
		[Updateable(false), Createable(false)]
		public SfUser ExecutionUser { get; set; }

		///<summary>
		/// Identity Provider Login URL
		/// <para>Name: LoginUrl</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "loginUrl")]
		[Updateable(false), Createable(false)]
		public string LoginUrl { get; set; }

		///<summary>
		/// Identity Provider Logout URL
		/// <para>Name: LogoutUrl</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "logoutUrl")]
		[Updateable(false), Createable(false)]
		public string LogoutUrl { get; set; }

		///<summary>
		/// Custom Error URL
		/// <para>Name: ErrorUrl</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "errorUrl")]
		[Updateable(false), Createable(false)]
		public string ErrorUrl { get; set; }

		///<summary>
		/// Identity Provider Certificate
		/// <para>Name: ValidationCert</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "validationCert")]
		[Updateable(false), Createable(false)]
		public string ValidationCert { get; set; }

		///<summary>
		/// Request Signature Method
		/// <para>Name: RequestSignatureMethod</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "requestSignatureMethod")]
		[Updateable(false), Createable(false)]
		public string RequestSignatureMethod { get; set; }

		///<summary>
		/// Identity Provider Single Logout URL
		/// <para>Name: SingleLogoutUrl</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "singleLogoutUrl")]
		[Updateable(false), Createable(false)]
		public string SingleLogoutUrl { get; set; }

		///<summary>
		/// Single Logout Request Binding
		/// <para>Name: SingleLogoutBinding</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "singleLogoutBinding")]
		[Updateable(false), Createable(false)]
		public string SingleLogoutBinding { get; set; }

	}
}
