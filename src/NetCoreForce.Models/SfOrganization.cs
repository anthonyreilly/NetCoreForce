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
	/// Organization
	///<para>SObject Name: Organization</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfOrganization : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "Organization"; }
		}

		///<summary>
		/// Organization ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(true), Creatable(false)]
		public string Name { get; set; }

		///<summary>
		/// Division
		/// <para>Name: Division</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "division")]
		[Updateable(true), Creatable(false)]
		public string Division { get; set; }

		///<summary>
		/// Street
		/// <para>Name: Street</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "street")]
		[Updateable(true), Creatable(false)]
		public string Street { get; set; }

		///<summary>
		/// City
		/// <para>Name: City</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "city")]
		[Updateable(true), Creatable(false)]
		public string City { get; set; }

		///<summary>
		/// State/Province
		/// <para>Name: State</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "state")]
		[Updateable(true), Creatable(false)]
		public string State { get; set; }

		///<summary>
		/// Zip/Postal Code
		/// <para>Name: PostalCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "postalCode")]
		[Updateable(true), Creatable(false)]
		public string PostalCode { get; set; }

		///<summary>
		/// Country
		/// <para>Name: Country</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "country")]
		[Updateable(false), Creatable(false)]
		public string Country { get; set; }

		///<summary>
		/// Latitude
		/// <para>Name: Latitude</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "latitude")]
		[Updateable(true), Creatable(false)]
		public double? Latitude { get; set; }

		///<summary>
		/// Longitude
		/// <para>Name: Longitude</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "longitude")]
		[Updateable(true), Creatable(false)]
		public double? Longitude { get; set; }

		///<summary>
		/// Geocode Accuracy
		/// <para>Name: GeocodeAccuracy</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "geocodeAccuracy")]
		[Updateable(true), Creatable(false)]
		public string GeocodeAccuracy { get; set; }

		///<summary>
		/// Address
		/// <para>Name: Address</para>
		/// <para>SF Type: address</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "address")]
		[Updateable(false), Creatable(false)]
		public Address Address { get; set; }

		///<summary>
		/// Phone
		/// <para>Name: Phone</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "phone")]
		[Updateable(true), Creatable(false)]
		public string Phone { get; set; }

		///<summary>
		/// Fax
		/// <para>Name: Fax</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fax")]
		[Updateable(true), Creatable(false)]
		public string Fax { get; set; }

		///<summary>
		/// Primary Contact
		/// <para>Name: PrimaryContact</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "primaryContact")]
		[Updateable(true), Creatable(false)]
		public string PrimaryContact { get; set; }

		///<summary>
		/// Locale
		/// <para>Name: DefaultLocaleSidKey</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "defaultLocaleSidKey")]
		[Updateable(true), Creatable(false)]
		public string DefaultLocaleSidKey { get; set; }

		///<summary>
		/// Language
		/// <para>Name: LanguageLocaleKey</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "languageLocaleKey")]
		[Updateable(true), Creatable(false)]
		public string LanguageLocaleKey { get; set; }

		///<summary>
		/// Info Emails
		/// <para>Name: ReceivesInfoEmails</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "receivesInfoEmails")]
		[Updateable(true), Creatable(false)]
		public bool? ReceivesInfoEmails { get; set; }

		///<summary>
		/// Info Emails Admin
		/// <para>Name: ReceivesAdminInfoEmails</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "receivesAdminInfoEmails")]
		[Updateable(true), Creatable(false)]
		public bool? ReceivesAdminInfoEmails { get; set; }

		///<summary>
		/// RequireOpportunityProducts
		/// <para>Name: PreferencesRequireOpportunityProducts</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "preferencesRequireOpportunityProducts")]
		[Updateable(true), Creatable(false)]
		public bool? PreferencesRequireOpportunityProducts { get; set; }

		///<summary>
		/// TransactionSecurityPolicy
		/// <para>Name: PreferencesTransactionSecurityPolicy</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "preferencesTransactionSecurityPolicy")]
		[Updateable(true), Creatable(false)]
		public bool? PreferencesTransactionSecurityPolicy { get; set; }

		///<summary>
		/// TerminateOldestSession
		/// <para>Name: PreferencesTerminateOldestSession</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "preferencesTerminateOldestSession")]
		[Updateable(true), Creatable(false)]
		public bool? PreferencesTerminateOldestSession { get; set; }

		///<summary>
		/// LightningLoginEnabled
		/// <para>Name: PreferencesLightningLoginEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "preferencesLightningLoginEnabled")]
		[Updateable(true), Creatable(false)]
		public bool? PreferencesLightningLoginEnabled { get; set; }

		///<summary>
		/// OnlyLLPermUserAllowed
		/// <para>Name: PreferencesOnlyLLPermUserAllowed</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "preferencesOnlyLLPermUserAllowed")]
		[Updateable(true), Creatable(false)]
		public bool? PreferencesOnlyLLPermUserAllowed { get; set; }

		///<summary>
		/// Fiscal Year Starts In
		/// <para>Name: FiscalYearStartMonth</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fiscalYearStartMonth")]
		[Updateable(false), Creatable(false)]
		public int? FiscalYearStartMonth { get; set; }

		///<summary>
		/// Fiscal Year Name by Start
		/// <para>Name: UsesStartDateAsFiscalYearName</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "usesStartDateAsFiscalYearName")]
		[Updateable(false), Creatable(false)]
		public bool? UsesStartDateAsFiscalYearName { get; set; }

		///<summary>
		/// Default Account Access
		/// <para>Name: DefaultAccountAccess</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "defaultAccountAccess")]
		[Updateable(false), Creatable(false)]
		public string DefaultAccountAccess { get; set; }

		///<summary>
		/// Default Contact Access
		/// <para>Name: DefaultContactAccess</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "defaultContactAccess")]
		[Updateable(false), Creatable(false)]
		public string DefaultContactAccess { get; set; }

		///<summary>
		/// Default Opportunity Access
		/// <para>Name: DefaultOpportunityAccess</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "defaultOpportunityAccess")]
		[Updateable(false), Creatable(false)]
		public string DefaultOpportunityAccess { get; set; }

		///<summary>
		/// Default Lead Access
		/// <para>Name: DefaultLeadAccess</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "defaultLeadAccess")]
		[Updateable(false), Creatable(false)]
		public string DefaultLeadAccess { get; set; }

		///<summary>
		/// Default Case Access
		/// <para>Name: DefaultCaseAccess</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "defaultCaseAccess")]
		[Updateable(false), Creatable(false)]
		public string DefaultCaseAccess { get; set; }

		///<summary>
		/// Default Calendar Access
		/// <para>Name: DefaultCalendarAccess</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "defaultCalendarAccess")]
		[Updateable(false), Creatable(false)]
		public string DefaultCalendarAccess { get; set; }

		///<summary>
		/// Default Price Book Access
		/// <para>Name: DefaultPricebookAccess</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "defaultPricebookAccess")]
		[Updateable(false), Creatable(false)]
		public string DefaultPricebookAccess { get; set; }

		///<summary>
		/// Default Campaign Access
		/// <para>Name: DefaultCampaignAccess</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "defaultCampaignAccess")]
		[Updateable(false), Creatable(false)]
		public string DefaultCampaignAccess { get; set; }

		///<summary>
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

		///<summary>
		/// Compliance BCC Email
		/// <para>Name: ComplianceBccEmail</para>
		/// <para>SF Type: email</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "complianceBccEmail")]
		[Updateable(false), Creatable(false)]
		public string ComplianceBccEmail { get; set; }

		///<summary>
		/// UI Skin
		/// <para>Name: UiSkin</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "uiSkin")]
		[Updateable(true), Creatable(false)]
		public string UiSkin { get; set; }

		///<summary>
		/// Signup Country
		/// <para>Name: SignupCountryIsoCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "signupCountryIsoCode")]
		[Updateable(false), Creatable(false)]
		public string SignupCountryIsoCode { get; set; }

		///<summary>
		/// Trial Expiration Date
		/// <para>Name: TrialExpirationDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "trialExpirationDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? TrialExpirationDate { get; set; }

		///<summary>
		/// Knowledge Licenses
		/// <para>Name: NumKnowledgeService</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "numKnowledgeService")]
		[Updateable(false), Creatable(false)]
		public int? NumKnowledgeService { get; set; }

		///<summary>
		/// Edition
		/// <para>Name: OrganizationType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "organizationType")]
		[Updateable(false), Creatable(false)]
		public string OrganizationType { get; set; }

		///<summary>
		/// Namespace Prefix
		/// <para>Name: NamespacePrefix</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "namespacePrefix")]
		[Updateable(false), Creatable(false)]
		public string NamespacePrefix { get; set; }

		///<summary>
		/// Instance Name
		/// <para>Name: InstanceName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "instanceName")]
		[Updateable(false), Creatable(false)]
		public string InstanceName { get; set; }

		///<summary>
		/// Is Sandbox
		/// <para>Name: IsSandbox</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isSandbox")]
		[Updateable(false), Creatable(false)]
		public bool? IsSandbox { get; set; }

		///<summary>
		/// Web to Cases Default Origin
		/// <para>Name: WebToCaseDefaultOrigin</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "webToCaseDefaultOrigin")]
		[Updateable(true), Creatable(false)]
		public string WebToCaseDefaultOrigin { get; set; }

		///<summary>
		/// Monthly Page Views Used
		/// <para>Name: MonthlyPageViewsUsed</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "monthlyPageViewsUsed")]
		[Updateable(false), Creatable(false)]
		public int? MonthlyPageViewsUsed { get; set; }

		///<summary>
		/// Monthly Page Views Allowed
		/// <para>Name: MonthlyPageViewsEntitlement</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "monthlyPageViewsEntitlement")]
		[Updateable(false), Creatable(false)]
		public int? MonthlyPageViewsEntitlement { get; set; }

		///<summary>
		/// Is Read Only
		/// <para>Name: IsReadOnly</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReadOnly")]
		[Updateable(false), Creatable(false)]
		public bool? IsReadOnly { get; set; }

		///<summary>
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

		///<summary>
		/// Created By ID
		/// <para>Name: CreatedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdById")]
		[Updateable(false), Creatable(false)]
		public string CreatedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: CreatedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "createdBy")]
		[Updateable(false), Creatable(false)]
		public SfUser CreatedBy { get; set; }

		///<summary>
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

		///<summary>
		/// Last Modified By ID
		/// <para>Name: LastModifiedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedById")]
		[Updateable(false), Creatable(false)]
		public string LastModifiedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: LastModifiedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedBy")]
		[Updateable(false), Creatable(false)]
		public SfUser LastModifiedBy { get; set; }

	}
}
