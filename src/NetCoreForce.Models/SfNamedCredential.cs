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
	/// Named Credential
	///<para>SObject Name: NamedCredential</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfNamedCredential : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "NamedCredential"; }
		}

		///<summary>
		/// Named Credential ID
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
		/// URL
		/// <para>Name: Endpoint</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "endpoint")]
		[Updateable(false), Createable(false)]
		public string Endpoint { get; set; }

		///<summary>
		/// Identity Type
		/// <para>Name: PrincipalType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "principalType")]
		[Updateable(false), Createable(false)]
		public string PrincipalType { get; set; }

		///<summary>
		/// GenerateAuthorizationHeader
		/// <para>Name: CalloutOptionsGenerateAuthorizationHeader</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "calloutOptionsGenerateAuthorizationHeader")]
		[Updateable(false), Createable(false)]
		public bool? CalloutOptionsGenerateAuthorizationHeader { get; set; }

		///<summary>
		/// AllowMergeFieldsInHeader
		/// <para>Name: CalloutOptionsAllowMergeFieldsInHeader</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "calloutOptionsAllowMergeFieldsInHeader")]
		[Updateable(false), Createable(false)]
		public bool? CalloutOptionsAllowMergeFieldsInHeader { get; set; }

		///<summary>
		/// AllowMergeFieldsInBody
		/// <para>Name: CalloutOptionsAllowMergeFieldsInBody</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "calloutOptionsAllowMergeFieldsInBody")]
		[Updateable(false), Createable(false)]
		public bool? CalloutOptionsAllowMergeFieldsInBody { get; set; }

		///<summary>
		/// Auth. Provider ID
		/// <para>Name: AuthProviderId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "authProviderId")]
		[Updateable(false), Createable(false)]
		public string AuthProviderId { get; set; }

		///<summary>
		/// ReferenceTo: AuthProvider
		/// <para>RelationshipName: AuthProvider</para>
		///</summary>
		[JsonProperty(PropertyName = "authProvider")]
		[Updateable(false), Createable(false)]
		public SfAuthProvider AuthProvider { get; set; }

		///<summary>
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		[Updateable(false), Createable(false)]
		public string Description { get; set; }

		///<summary>
		/// JWT Issuer
		/// <para>Name: JwtIssuer</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "jwtIssuer")]
		[Updateable(false), Createable(false)]
		public string JwtIssuer { get; set; }

		///<summary>
		/// JWT Formula Subject
		/// <para>Name: JwtFormulaSubject</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "jwtFormulaSubject")]
		[Updateable(false), Createable(false)]
		public string JwtFormulaSubject { get; set; }

		///<summary>
		/// JWT Text Subject
		/// <para>Name: JwtTextSubject</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "jwtTextSubject")]
		[Updateable(false), Createable(false)]
		public string JwtTextSubject { get; set; }

		///<summary>
		/// JWT Validity Period in Seconds
		/// <para>Name: JwtValidityPeriodSeconds</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "jwtValidityPeriodSeconds")]
		[Updateable(false), Createable(false)]
		public int? JwtValidityPeriodSeconds { get; set; }

		///<summary>
		/// JWT Audience(s)
		/// <para>Name: JwtAudience</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "jwtAudience")]
		[Updateable(false), Createable(false)]
		public string JwtAudience { get; set; }

		///<summary>
		/// Auth Token Endpoint URL
		/// <para>Name: AuthTokenEndpointUrl</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "authTokenEndpointUrl")]
		[Updateable(false), Createable(false)]
		public string AuthTokenEndpointUrl { get; set; }

	}
}
