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
	/// Permission Set
	///<para>SObject Name: PermissionSet</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfPermissionSet : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "PermissionSet"; }
		}

		///<summary>
		/// PermissionSet ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Permission Set Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		///<summary>
		/// Permission Set Label
		/// <para>Name: Label</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "label")]
		public string Label { get; set; }

		///<summary>
		/// License ID
		/// <para>Name: LicenseId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "licenseId")]
		[Updateable(false), Createable(true)]
		public string LicenseId { get; set; }

		///<summary>
		/// Profile ID
		/// <para>Name: ProfileId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "profileId")]
		[Updateable(false), Createable(false)]
		public string ProfileId { get; set; }

		///<summary>
		/// ReferenceTo: Profile
		/// <para>RelationshipName: Profile</para>
		///</summary>
		[JsonProperty(PropertyName = "profile")]
		[Updateable(false), Createable(false)]
		public SfProfile Profile { get; set; }

		///<summary>
		/// Is Owned By Profile
		/// <para>Name: IsOwnedByProfile</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isOwnedByProfile")]
		[Updateable(false), Createable(false)]
		public bool? IsOwnedByProfile { get; set; }

		///<summary>
		/// Is Custom
		/// <para>Name: IsCustom</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isCustom")]
		[Updateable(false), Createable(false)]
		public bool? IsCustom { get; set; }

		///<summary>
		/// Send Email
		/// <para>Name: PermissionsEmailSingle</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEmailSingle")]
		public bool? PermissionsEmailSingle { get; set; }

		///<summary>
		/// Mass Email
		/// <para>Name: PermissionsEmailMass</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEmailMass")]
		public bool? PermissionsEmailMass { get; set; }

		///<summary>
		/// Edit Tasks
		/// <para>Name: PermissionsEditTask</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditTask")]
		public bool? PermissionsEditTask { get; set; }

		///<summary>
		/// Edit Events
		/// <para>Name: PermissionsEditEvent</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditEvent")]
		public bool? PermissionsEditEvent { get; set; }

		///<summary>
		/// Export Reports
		/// <para>Name: PermissionsExportReport</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsExportReport")]
		public bool? PermissionsExportReport { get; set; }

		///<summary>
		/// Import Personal Contacts
		/// <para>Name: PermissionsImportPersonal</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsImportPersonal")]
		public bool? PermissionsImportPersonal { get; set; }

		///<summary>
		/// Weekly Data Export
		/// <para>Name: PermissionsDataExport</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsDataExport")]
		public bool? PermissionsDataExport { get; set; }

		///<summary>
		/// Manage Users
		/// <para>Name: PermissionsManageUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageUsers")]
		public bool? PermissionsManageUsers { get; set; }

		///<summary>
		/// Manage Public List Views
		/// <para>Name: PermissionsEditPublicFilters</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditPublicFilters")]
		public bool? PermissionsEditPublicFilters { get; set; }

		///<summary>
		/// Manage Public Classic Email Templates
		/// <para>Name: PermissionsEditPublicTemplates</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditPublicTemplates")]
		public bool? PermissionsEditPublicTemplates { get; set; }

		///<summary>
		/// Modify All Data
		/// <para>Name: PermissionsModifyAllData</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsModifyAllData")]
		public bool? PermissionsModifyAllData { get; set; }

		///<summary>
		/// Manage Billing
		/// <para>Name: PermissionsEditBillingInfo</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditBillingInfo")]
		public bool? PermissionsEditBillingInfo { get; set; }

		///<summary>
		/// Manage Cases
		/// <para>Name: PermissionsManageCases</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageCases")]
		public bool? PermissionsManageCases { get; set; }

		///<summary>
		/// Mass Edits from Lists
		/// <para>Name: PermissionsMassInlineEdit</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsMassInlineEdit")]
		public bool? PermissionsMassInlineEdit { get; set; }

		///<summary>
		/// Manage Articles
		/// <para>Name: PermissionsEditKnowledge</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditKnowledge")]
		public bool? PermissionsEditKnowledge { get; set; }

		///<summary>
		/// Manage Salesforce Knowledge
		/// <para>Name: PermissionsManageKnowledge</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageKnowledge")]
		public bool? PermissionsManageKnowledge { get; set; }

		///<summary>
		/// Manage Published Solutions
		/// <para>Name: PermissionsManageSolutions</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageSolutions")]
		public bool? PermissionsManageSolutions { get; set; }

		///<summary>
		/// Customize Application
		/// <para>Name: PermissionsCustomizeApplication</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCustomizeApplication")]
		public bool? PermissionsCustomizeApplication { get; set; }

		///<summary>
		/// Edit Read Only Fields
		/// <para>Name: PermissionsEditReadonlyFields</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditReadonlyFields")]
		public bool? PermissionsEditReadonlyFields { get; set; }

		///<summary>
		/// Run Reports
		/// <para>Name: PermissionsRunReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsRunReports")]
		public bool? PermissionsRunReports { get; set; }

		///<summary>
		/// View Setup and Configuration
		/// <para>Name: PermissionsViewSetup</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewSetup")]
		public bool? PermissionsViewSetup { get; set; }

		///<summary>
		/// Transfer Record
		/// <para>Name: PermissionsTransferAnyEntity</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsTransferAnyEntity")]
		public bool? PermissionsTransferAnyEntity { get; set; }

		///<summary>
		/// Report Builder
		/// <para>Name: PermissionsNewReportBuilder</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsNewReportBuilder")]
		public bool? PermissionsNewReportBuilder { get; set; }

		///<summary>
		/// Activate Contracts
		/// <para>Name: PermissionsActivateContract</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsActivateContract")]
		public bool? PermissionsActivateContract { get; set; }

		///<summary>
		/// Activate Orders
		/// <para>Name: PermissionsActivateOrder</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsActivateOrder")]
		public bool? PermissionsActivateOrder { get; set; }

		///<summary>
		/// Import Leads
		/// <para>Name: PermissionsImportLeads</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsImportLeads")]
		public bool? PermissionsImportLeads { get; set; }

		///<summary>
		/// Manage Leads
		/// <para>Name: PermissionsManageLeads</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageLeads")]
		public bool? PermissionsManageLeads { get; set; }

		///<summary>
		/// Transfer Leads
		/// <para>Name: PermissionsTransferAnyLead</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsTransferAnyLead")]
		public bool? PermissionsTransferAnyLead { get; set; }

		///<summary>
		/// View All Data
		/// <para>Name: PermissionsViewAllData</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewAllData")]
		public bool? PermissionsViewAllData { get; set; }

		///<summary>
		/// Manage Public Documents
		/// <para>Name: PermissionsEditPublicDocuments</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditPublicDocuments")]
		public bool? PermissionsEditPublicDocuments { get; set; }

		///<summary>
		/// View Encrypted Data
		/// <para>Name: PermissionsViewEncryptedData</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewEncryptedData")]
		public bool? PermissionsViewEncryptedData { get; set; }

		///<summary>
		/// Manage Letterheads
		/// <para>Name: PermissionsEditBrandTemplates</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditBrandTemplates")]
		public bool? PermissionsEditBrandTemplates { get; set; }

		///<summary>
		/// Edit HTML Templates
		/// <para>Name: PermissionsEditHtmlTemplates</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditHtmlTemplates")]
		public bool? PermissionsEditHtmlTemplates { get; set; }

		///<summary>
		/// Chatter Internal User
		/// <para>Name: PermissionsChatterInternalUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsChatterInternalUser")]
		public bool? PermissionsChatterInternalUser { get; set; }

		///<summary>
		/// Manage Encryption Keys
		/// <para>Name: PermissionsManageEncryptionKeys</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageEncryptionKeys")]
		public bool? PermissionsManageEncryptionKeys { get; set; }

		///<summary>
		/// Delete Activated Contracts
		/// <para>Name: PermissionsDeleteActivatedContract</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsDeleteActivatedContract")]
		public bool? PermissionsDeleteActivatedContract { get; set; }

		///<summary>
		/// Invite Customers To Chatter
		/// <para>Name: PermissionsChatterInviteExternalUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsChatterInviteExternalUsers")]
		public bool? PermissionsChatterInviteExternalUsers { get; set; }

		///<summary>
		/// Send Stay-in-Touch Requests
		/// <para>Name: PermissionsSendSitRequests</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSendSitRequests")]
		public bool? PermissionsSendSitRequests { get; set; }

		///<summary>
		/// Manage Connected Apps
		/// <para>Name: PermissionsManageRemoteAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageRemoteAccess")]
		public bool? PermissionsManageRemoteAccess { get; set; }

		///<summary>
		/// Drag-and-Drop Dashboard Builder
		/// <para>Name: PermissionsCanUseNewDashboardBuilder</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCanUseNewDashboardBuilder")]
		public bool? PermissionsCanUseNewDashboardBuilder { get; set; }

		///<summary>
		/// Manage Categories
		/// <para>Name: PermissionsManageCategories</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageCategories")]
		public bool? PermissionsManageCategories { get; set; }

		///<summary>
		/// Convert Leads
		/// <para>Name: PermissionsConvertLeads</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsConvertLeads")]
		public bool? PermissionsConvertLeads { get; set; }

		///<summary>
		/// Password Never Expires
		/// <para>Name: PermissionsPasswordNeverExpires</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsPasswordNeverExpires")]
		public bool? PermissionsPasswordNeverExpires { get; set; }

		///<summary>
		/// Use Team Reassignment Wizards
		/// <para>Name: PermissionsUseTeamReassignWizards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsUseTeamReassignWizards")]
		public bool? PermissionsUseTeamReassignWizards { get; set; }

		///<summary>
		/// Edit Activated Orders
		/// <para>Name: PermissionsEditActivatedOrders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditActivatedOrders")]
		public bool? PermissionsEditActivatedOrders { get; set; }

		///<summary>
		/// Download AppExchange Packages
		/// <para>Name: PermissionsInstallPackaging</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsInstallPackaging")]
		public bool? PermissionsInstallPackaging { get; set; }

		///<summary>
		/// Upload AppExchange Packages
		/// <para>Name: PermissionsPublishPackaging</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsPublishPackaging")]
		public bool? PermissionsPublishPackaging { get; set; }

		///<summary>
		/// Create and Own New Chatter Groups
		/// <para>Name: PermissionsChatterOwnGroups</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsChatterOwnGroups")]
		public bool? PermissionsChatterOwnGroups { get; set; }

		///<summary>
		/// Edit Opportunity Product Sales Price
		/// <para>Name: PermissionsEditOppLineItemUnitPrice</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditOppLineItemUnitPrice")]
		public bool? PermissionsEditOppLineItemUnitPrice { get; set; }

		///<summary>
		/// Create AppExchange Packages
		/// <para>Name: PermissionsCreatePackaging</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreatePackaging")]
		public bool? PermissionsCreatePackaging { get; set; }

		///<summary>
		/// Bulk API Hard Delete
		/// <para>Name: PermissionsBulkApiHardDelete</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsBulkApiHardDelete")]
		public bool? PermissionsBulkApiHardDelete { get; set; }

		///<summary>
		/// Import Solutions
		/// <para>Name: PermissionsSolutionImport</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSolutionImport")]
		public bool? PermissionsSolutionImport { get; set; }

		///<summary>
		/// Manage Call Centers
		/// <para>Name: PermissionsManageCallCenters</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageCallCenters")]
		public bool? PermissionsManageCallCenters { get; set; }

		///<summary>
		/// Manage Synonyms
		/// <para>Name: PermissionsManageSynonyms</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageSynonyms")]
		public bool? PermissionsManageSynonyms { get; set; }

		///<summary>
		/// View Content in Portals
		/// <para>Name: PermissionsViewContent</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewContent")]
		public bool? PermissionsViewContent { get; set; }

		///<summary>
		/// Manage Email Client Configurations
		/// <para>Name: PermissionsManageEmailClientConfig</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageEmailClientConfig")]
		public bool? PermissionsManageEmailClientConfig { get; set; }

		///<summary>
		/// Send Outbound Messages
		/// <para>Name: PermissionsEnableNotifications</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEnableNotifications")]
		public bool? PermissionsEnableNotifications { get; set; }

		///<summary>
		/// Manage Data Integrations
		/// <para>Name: PermissionsManageDataIntegrations</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageDataIntegrations")]
		public bool? PermissionsManageDataIntegrations { get; set; }

		///<summary>
		/// Create Content Deliveries
		/// <para>Name: PermissionsDistributeFromPersWksp</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsDistributeFromPersWksp")]
		public bool? PermissionsDistributeFromPersWksp { get; set; }

		///<summary>
		/// View Data Categories in Setup
		/// <para>Name: PermissionsViewDataCategories</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewDataCategories")]
		public bool? PermissionsViewDataCategories { get; set; }

		///<summary>
		/// Manage Data Categories
		/// <para>Name: PermissionsManageDataCategories</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageDataCategories")]
		public bool? PermissionsManageDataCategories { get; set; }

		///<summary>
		/// Author Apex
		/// <para>Name: PermissionsAuthorApex</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAuthorApex")]
		public bool? PermissionsAuthorApex { get; set; }

		///<summary>
		/// Manage Mobile Configurations
		/// <para>Name: PermissionsManageMobile</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageMobile")]
		public bool? PermissionsManageMobile { get; set; }

		///<summary>
		/// API Enabled
		/// <para>Name: PermissionsApiEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsApiEnabled")]
		public bool? PermissionsApiEnabled { get; set; }

		///<summary>
		/// Manage Custom Report Types
		/// <para>Name: PermissionsManageCustomReportTypes</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageCustomReportTypes")]
		public bool? PermissionsManageCustomReportTypes { get; set; }

		///<summary>
		/// Edit Case Comments
		/// <para>Name: PermissionsEditCaseComments</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditCaseComments")]
		public bool? PermissionsEditCaseComments { get; set; }

		///<summary>
		/// Transfer Cases
		/// <para>Name: PermissionsTransferAnyCase</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsTransferAnyCase")]
		public bool? PermissionsTransferAnyCase { get; set; }

		///<summary>
		/// Manage Salesforce CRM Content
		/// <para>Name: PermissionsContentAdministrator</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsContentAdministrator")]
		public bool? PermissionsContentAdministrator { get; set; }

		///<summary>
		/// Create Libraries
		/// <para>Name: PermissionsCreateWorkspaces</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateWorkspaces")]
		public bool? PermissionsCreateWorkspaces { get; set; }

		///<summary>
		/// Manage Content Permissions
		/// <para>Name: PermissionsManageContentPermissions</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageContentPermissions")]
		public bool? PermissionsManageContentPermissions { get; set; }

		///<summary>
		/// Manage Content Properties
		/// <para>Name: PermissionsManageContentProperties</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageContentProperties")]
		public bool? PermissionsManageContentProperties { get; set; }

		///<summary>
		/// Manage record types and layouts for Files
		/// <para>Name: PermissionsManageContentTypes</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageContentTypes")]
		public bool? PermissionsManageContentTypes { get; set; }

		///<summary>
		/// Manage Lightning Sync
		/// <para>Name: PermissionsManageExchangeConfig</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageExchangeConfig")]
		public bool? PermissionsManageExchangeConfig { get; set; }

		///<summary>
		/// Manage Reporting Snapshots
		/// <para>Name: PermissionsManageAnalyticSnapshots</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageAnalyticSnapshots")]
		public bool? PermissionsManageAnalyticSnapshots { get; set; }

		///<summary>
		/// Schedule Reports
		/// <para>Name: PermissionsScheduleReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsScheduleReports")]
		public bool? PermissionsScheduleReports { get; set; }

		///<summary>
		/// Manage Business Hours Holidays
		/// <para>Name: PermissionsManageBusinessHourHolidays</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageBusinessHourHolidays")]
		public bool? PermissionsManageBusinessHourHolidays { get; set; }

		///<summary>
		/// Manage Dynamic Dashboards
		/// <para>Name: PermissionsManageDynamicDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageDynamicDashboards")]
		public bool? PermissionsManageDynamicDashboards { get; set; }

		///<summary>
		/// Show Custom Sidebar On All Pages
		/// <para>Name: PermissionsCustomSidebarOnAllPages</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCustomSidebarOnAllPages")]
		public bool? PermissionsCustomSidebarOnAllPages { get; set; }

		///<summary>
		/// Manage Flow
		/// <para>Name: PermissionsManageInteraction</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageInteraction")]
		public bool? PermissionsManageInteraction { get; set; }

		///<summary>
		/// View My Team&#39;s Dashboards
		/// <para>Name: PermissionsViewMyTeamsDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewMyTeamsDashboards")]
		public bool? PermissionsViewMyTeamsDashboards { get; set; }

		///<summary>
		/// Moderate Chatter
		/// <para>Name: PermissionsModerateChatter</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsModerateChatter")]
		public bool? PermissionsModerateChatter { get; set; }

		///<summary>
		/// Reset User Passwords and Unlock Users
		/// <para>Name: PermissionsResetPasswords</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsResetPasswords")]
		public bool? PermissionsResetPasswords { get; set; }

		///<summary>
		/// Require Flow User Feature License
		/// <para>Name: PermissionsFlowUFLRequired</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsFlowUFLRequired")]
		public bool? PermissionsFlowUFLRequired { get; set; }

		///<summary>
		/// Insert System Field Values for Chatter Feeds
		/// <para>Name: PermissionsCanInsertFeedSystemFields</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCanInsertFeedSystemFields")]
		public bool? PermissionsCanInsertFeedSystemFields { get; set; }

		///<summary>
		/// Access Activities
		/// <para>Name: PermissionsActivitiesAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsActivitiesAccess")]
		public bool? PermissionsActivitiesAccess { get; set; }

		///<summary>
		/// Manage Knowledge Article Import/Export
		/// <para>Name: PermissionsManageKnowledgeImportExport</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageKnowledgeImportExport")]
		public bool? PermissionsManageKnowledgeImportExport { get; set; }

		///<summary>
		/// Manage Email Templates
		/// <para>Name: PermissionsEmailTemplateManagement</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEmailTemplateManagement")]
		public bool? PermissionsEmailTemplateManagement { get; set; }

		///<summary>
		/// Email Administration
		/// <para>Name: PermissionsEmailAdministration</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEmailAdministration")]
		public bool? PermissionsEmailAdministration { get; set; }

		///<summary>
		/// Manage Chatter Messages and Direct Messages
		/// <para>Name: PermissionsManageChatterMessages</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageChatterMessages")]
		public bool? PermissionsManageChatterMessages { get; set; }

		///<summary>
		/// Email-Based Identity Verification Option
		/// <para>Name: PermissionsAllowEmailIC</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAllowEmailIC")]
		public bool? PermissionsAllowEmailIC { get; set; }

		///<summary>
		/// Create Public Links
		/// <para>Name: PermissionsChatterFileLink</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsChatterFileLink")]
		public bool? PermissionsChatterFileLink { get; set; }

		///<summary>
		/// Multi-Factor Authentication for User Interface Logins
		/// <para>Name: PermissionsForceTwoFactor</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsForceTwoFactor")]
		public bool? PermissionsForceTwoFactor { get; set; }

		///<summary>
		/// View Event Log Files
		/// <para>Name: PermissionsViewEventLogFiles</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewEventLogFiles")]
		public bool? PermissionsViewEventLogFiles { get; set; }

		///<summary>
		/// Create and Set Up Experiences
		/// <para>Name: PermissionsManageNetworks</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageNetworks")]
		public bool? PermissionsManageNetworks { get; set; }

		///<summary>
		/// Manage Auth. Providers
		/// <para>Name: PermissionsManageAuthProviders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageAuthProviders")]
		public bool? PermissionsManageAuthProviders { get; set; }

		///<summary>
		/// Run Flows
		/// <para>Name: PermissionsRunFlow</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsRunFlow")]
		public bool? PermissionsRunFlow { get; set; }

		///<summary>
		/// Create and Customize Dashboards
		/// <para>Name: PermissionsCreateCustomizeDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateCustomizeDashboards")]
		public bool? PermissionsCreateCustomizeDashboards { get; set; }

		///<summary>
		/// Create Dashboard Folders
		/// <para>Name: PermissionsCreateDashboardFolders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateDashboardFolders")]
		public bool? PermissionsCreateDashboardFolders { get; set; }

		///<summary>
		/// View Dashboards in Public Folders
		/// <para>Name: PermissionsViewPublicDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewPublicDashboards")]
		public bool? PermissionsViewPublicDashboards { get; set; }

		///<summary>
		/// Manage Dashboards in Public Folders
		/// <para>Name: PermissionsManageDashbdsInPubFolders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageDashbdsInPubFolders")]
		public bool? PermissionsManageDashbdsInPubFolders { get; set; }

		///<summary>
		/// Create and Customize Reports
		/// <para>Name: PermissionsCreateCustomizeReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateCustomizeReports")]
		public bool? PermissionsCreateCustomizeReports { get; set; }

		///<summary>
		/// Create Report Folders
		/// <para>Name: PermissionsCreateReportFolders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateReportFolders")]
		public bool? PermissionsCreateReportFolders { get; set; }

		///<summary>
		/// View Reports in Public Folders
		/// <para>Name: PermissionsViewPublicReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewPublicReports")]
		public bool? PermissionsViewPublicReports { get; set; }

		///<summary>
		/// Manage Reports in Public Folders
		/// <para>Name: PermissionsManageReportsInPubFolders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageReportsInPubFolders")]
		public bool? PermissionsManageReportsInPubFolders { get; set; }

		///<summary>
		/// Edit My Dashboards
		/// <para>Name: PermissionsEditMyDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditMyDashboards")]
		public bool? PermissionsEditMyDashboards { get; set; }

		///<summary>
		/// Edit My Reports
		/// <para>Name: PermissionsEditMyReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditMyReports")]
		public bool? PermissionsEditMyReports { get; set; }

		///<summary>
		/// View All Users
		/// <para>Name: PermissionsViewAllUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewAllUsers")]
		public bool? PermissionsViewAllUsers { get; set; }

		///<summary>
		/// Knowledge One
		/// <para>Name: PermissionsAllowUniversalSearch</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAllowUniversalSearch")]
		public bool? PermissionsAllowUniversalSearch { get; set; }

		///<summary>
		/// Connect Organization to Environment Hub
		/// <para>Name: PermissionsConnectOrgToEnvironmentHub</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsConnectOrgToEnvironmentHub")]
		public bool? PermissionsConnectOrgToEnvironmentHub { get; set; }

		///<summary>
		/// Enable WDC Calibration
		/// <para>Name: PermissionsWorkCalibrationUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsWorkCalibrationUser")]
		public bool? PermissionsWorkCalibrationUser { get; set; }

		///<summary>
		/// Create and Customize List Views
		/// <para>Name: PermissionsCreateCustomizeFilters</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateCustomizeFilters")]
		public bool? PermissionsCreateCustomizeFilters { get; set; }

		///<summary>
		/// Enable WDC
		/// <para>Name: PermissionsWorkDotComUserPerm</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsWorkDotComUserPerm")]
		public bool? PermissionsWorkDotComUserPerm { get; set; }

		///<summary>
		/// Files Connect Cloud
		/// <para>Name: PermissionsContentHubUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsContentHubUser")]
		public bool? PermissionsContentHubUser { get; set; }

		///<summary>
		/// Manage Experiences
		/// <para>Name: PermissionsGovernNetworks</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsGovernNetworks")]
		public bool? PermissionsGovernNetworks { get; set; }

		///<summary>
		/// Sales Console
		/// <para>Name: PermissionsSalesConsole</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSalesConsole")]
		public bool? PermissionsSalesConsole { get; set; }

		///<summary>
		/// Multi-Factor Authentication for API Logins
		/// <para>Name: PermissionsTwoFactorApi</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsTwoFactorApi")]
		public bool? PermissionsTwoFactorApi { get; set; }

		///<summary>
		/// Delete Topics
		/// <para>Name: PermissionsDeleteTopics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsDeleteTopics")]
		public bool? PermissionsDeleteTopics { get; set; }

		///<summary>
		/// Edit Topics
		/// <para>Name: PermissionsEditTopics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditTopics")]
		public bool? PermissionsEditTopics { get; set; }

		///<summary>
		/// Create Topics
		/// <para>Name: PermissionsCreateTopics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateTopics")]
		public bool? PermissionsCreateTopics { get; set; }

		///<summary>
		/// Assign Topics
		/// <para>Name: PermissionsAssignTopics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAssignTopics")]
		public bool? PermissionsAssignTopics { get; set; }

		///<summary>
		/// Use Identity Features
		/// <para>Name: PermissionsIdentityEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsIdentityEnabled")]
		public bool? PermissionsIdentityEnabled { get; set; }

		///<summary>
		/// Use Identity Connect
		/// <para>Name: PermissionsIdentityConnect</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsIdentityConnect")]
		public bool? PermissionsIdentityConnect { get; set; }

		///<summary>
		/// Allow View Knowledge
		/// <para>Name: PermissionsAllowViewKnowledge</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAllowViewKnowledge")]
		public bool? PermissionsAllowViewKnowledge { get; set; }

		///<summary>
		/// Access Libraries
		/// <para>Name: PermissionsContentWorkspaces</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsContentWorkspaces")]
		public bool? PermissionsContentWorkspaces { get; set; }

		///<summary>
		/// Manage Promoted Search Terms
		/// <para>Name: PermissionsManageSearchPromotionRules</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageSearchPromotionRules")]
		public bool? PermissionsManageSearchPromotionRules { get; set; }

		///<summary>
		/// Access Custom Mobile Apps
		/// <para>Name: PermissionsCustomMobileAppsAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCustomMobileAppsAccess")]
		public bool? PermissionsCustomMobileAppsAccess { get; set; }

		///<summary>
		/// View Help Link
		/// <para>Name: PermissionsViewHelpLink</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewHelpLink")]
		public bool? PermissionsViewHelpLink { get; set; }

		///<summary>
		/// Manage Profiles and Permission Sets
		/// <para>Name: PermissionsManageProfilesPermissionsets</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageProfilesPermissionsets")]
		public bool? PermissionsManageProfilesPermissionsets { get; set; }

		///<summary>
		/// Assign Permission Sets
		/// <para>Name: PermissionsAssignPermissionSets</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAssignPermissionSets")]
		public bool? PermissionsAssignPermissionSets { get; set; }

		///<summary>
		/// Manage Roles
		/// <para>Name: PermissionsManageRoles</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageRoles")]
		public bool? PermissionsManageRoles { get; set; }

		///<summary>
		/// Manage IP Addresses
		/// <para>Name: PermissionsManageIpAddresses</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageIpAddresses")]
		public bool? PermissionsManageIpAddresses { get; set; }

		///<summary>
		/// Manage Sharing
		/// <para>Name: PermissionsManageSharing</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageSharing")]
		public bool? PermissionsManageSharing { get; set; }

		///<summary>
		/// Manage Internal Users
		/// <para>Name: PermissionsManageInternalUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageInternalUsers")]
		public bool? PermissionsManageInternalUsers { get; set; }

		///<summary>
		/// Manage Password Policies
		/// <para>Name: PermissionsManagePasswordPolicies</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManagePasswordPolicies")]
		public bool? PermissionsManagePasswordPolicies { get; set; }

		///<summary>
		/// Manage Login Access Policies
		/// <para>Name: PermissionsManageLoginAccessPolicies</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageLoginAccessPolicies")]
		public bool? PermissionsManageLoginAccessPolicies { get; set; }

		///<summary>
		/// View Login Forensics Events
		/// <para>Name: PermissionsViewPlatformEvents</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewPlatformEvents")]
		public bool? PermissionsViewPlatformEvents { get; set; }

		///<summary>
		/// Manage Custom Permissions
		/// <para>Name: PermissionsManageCustomPermissions</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageCustomPermissions")]
		public bool? PermissionsManageCustomPermissions { get; set; }

		///<summary>
		/// Verify Answers to Chatter Questions
		/// <para>Name: PermissionsCanVerifyComment</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCanVerifyComment")]
		public bool? PermissionsCanVerifyComment { get; set; }

		///<summary>
		/// Manage Unlisted Groups
		/// <para>Name: PermissionsManageUnlistedGroups</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageUnlistedGroups")]
		public bool? PermissionsManageUnlistedGroups { get; set; }

		///<summary>
		/// Use Einstein Activity Capture Standard
		/// <para>Name: PermissionsStdAutomaticActivityCapture</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsStdAutomaticActivityCapture")]
		public bool? PermissionsStdAutomaticActivityCapture { get; set; }

		///<summary>
		/// Create and Edit CRM Analytics Dashboards
		/// <para>Name: PermissionsInsightsAppDashboardEditor</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsInsightsAppDashboardEditor")]
		public bool? PermissionsInsightsAppDashboardEditor { get; set; }

		///<summary>
		/// Manage Multi-Factor Authentication in API
		/// <para>Name: PermissionsManageTwoFactor</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageTwoFactor")]
		public bool? PermissionsManageTwoFactor { get; set; }

		///<summary>
		/// Use CRM Analytics
		/// <para>Name: PermissionsInsightsAppUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsInsightsAppUser")]
		public bool? PermissionsInsightsAppUser { get; set; }

		///<summary>
		/// Manage CRM Analytics
		/// <para>Name: PermissionsInsightsAppAdmin</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsInsightsAppAdmin")]
		public bool? PermissionsInsightsAppAdmin { get; set; }

		///<summary>
		/// Edit CRM Analytics Dataflows
		/// <para>Name: PermissionsInsightsAppEltEditor</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsInsightsAppEltEditor")]
		public bool? PermissionsInsightsAppEltEditor { get; set; }

		///<summary>
		/// Upload External Data to CRM Analytics
		/// <para>Name: PermissionsInsightsAppUploadUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsInsightsAppUploadUser")]
		public bool? PermissionsInsightsAppUploadUser { get; set; }

		///<summary>
		/// Create CRM Analytics Apps
		/// <para>Name: PermissionsInsightsCreateApplication</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsInsightsCreateApplication")]
		public bool? PermissionsInsightsCreateApplication { get; set; }

		///<summary>
		/// Lightning Experience User
		/// <para>Name: PermissionsLightningExperienceUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsLightningExperienceUser")]
		public bool? PermissionsLightningExperienceUser { get; set; }

		///<summary>
		/// View Real-Time Event Monitoring Data
		/// <para>Name: PermissionsViewDataLeakageEvents</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewDataLeakageEvents")]
		public bool? PermissionsViewDataLeakageEvents { get; set; }

		///<summary>
		/// Configure Custom Recommendations
		/// <para>Name: PermissionsConfigCustomRecs</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsConfigCustomRecs")]
		public bool? PermissionsConfigCustomRecs { get; set; }

		///<summary>
		/// Manage Macros Users Can&#39;t Undo
		/// <para>Name: PermissionsSubmitMacrosAllowed</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSubmitMacrosAllowed")]
		public bool? PermissionsSubmitMacrosAllowed { get; set; }

		///<summary>
		/// Run Macros on Multiple Records
		/// <para>Name: PermissionsBulkMacrosAllowed</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsBulkMacrosAllowed")]
		public bool? PermissionsBulkMacrosAllowed { get; set; }

		///<summary>
		/// Share internal Knowledge articles externally
		/// <para>Name: PermissionsShareInternalArticles</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsShareInternalArticles")]
		public bool? PermissionsShareInternalArticles { get; set; }

		///<summary>
		/// Manage Session Permission Set Activations
		/// <para>Name: PermissionsManageSessionPermissionSets</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageSessionPermissionSets")]
		public bool? PermissionsManageSessionPermissionSets { get; set; }

		///<summary>
		/// Manage CRM Analytics Templated Apps
		/// <para>Name: PermissionsManageTemplatedApp</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageTemplatedApp")]
		public bool? PermissionsManageTemplatedApp { get; set; }

		///<summary>
		/// Use CRM Analytics Templated Apps
		/// <para>Name: PermissionsUseTemplatedApp</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsUseTemplatedApp")]
		public bool? PermissionsUseTemplatedApp { get; set; }

		///<summary>
		/// Send announcement emails
		/// <para>Name: PermissionsSendAnnouncementEmails</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSendAnnouncementEmails")]
		public bool? PermissionsSendAnnouncementEmails { get; set; }

		///<summary>
		/// Edit My Own Posts
		/// <para>Name: PermissionsChatterEditOwnPost</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsChatterEditOwnPost")]
		public bool? PermissionsChatterEditOwnPost { get; set; }

		///<summary>
		/// Edit Posts on Records I Own
		/// <para>Name: PermissionsChatterEditOwnRecordPost</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsChatterEditOwnRecordPost")]
		public bool? PermissionsChatterEditOwnRecordPost { get; set; }

		///<summary>
		/// Download CRM Analytics Data
		/// <para>Name: PermissionsWaveTabularDownload</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsWaveTabularDownload")]
		public bool? PermissionsWaveTabularDownload { get; set; }

		///<summary>
		/// Use Einstein Activity Capture
		/// <para>Name: PermissionsAutomaticActivityCapture</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAutomaticActivityCapture")]
		public bool? PermissionsAutomaticActivityCapture { get; set; }

		///<summary>
		/// Import Custom Objects
		/// <para>Name: PermissionsImportCustomObjects</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsImportCustomObjects")]
		public bool? PermissionsImportCustomObjects { get; set; }

		///<summary>
		/// Manage Multi-Factor Authentication in User Interface
		/// <para>Name: PermissionsDelegatedTwoFactor</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsDelegatedTwoFactor")]
		public bool? PermissionsDelegatedTwoFactor { get; set; }

		///<summary>
		/// Allow Inclusion of Code Snippets from UI
		/// <para>Name: PermissionsChatterComposeUiCodesnippet</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsChatterComposeUiCodesnippet")]
		public bool? PermissionsChatterComposeUiCodesnippet { get; set; }

		///<summary>
		/// Select Files from Salesforce
		/// <para>Name: PermissionsSelectFilesFromSalesforce</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSelectFilesFromSalesforce")]
		public bool? PermissionsSelectFilesFromSalesforce { get; set; }

		///<summary>
		/// Moderate Experience Cloud Site Users
		/// <para>Name: PermissionsModerateNetworkUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsModerateNetworkUsers")]
		public bool? PermissionsModerateNetworkUsers { get; set; }

		///<summary>
		/// Merge Topics
		/// <para>Name: PermissionsMergeTopics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsMergeTopics")]
		public bool? PermissionsMergeTopics { get; set; }

		///<summary>
		/// Subscribe to Reports
		/// <para>Name: PermissionsSubscribeToLightningReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSubscribeToLightningReports")]
		public bool? PermissionsSubscribeToLightningReports { get; set; }

		///<summary>
		/// Manage All Private Reports and Dashboards
		/// <para>Name: PermissionsManagePvtRptsAndDashbds</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManagePvtRptsAndDashbds")]
		public bool? PermissionsManagePvtRptsAndDashbds { get; set; }

		///<summary>
		/// Lightning Login User
		/// <para>Name: PermissionsAllowLightningLogin</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAllowLightningLogin")]
		public bool? PermissionsAllowLightningLogin { get; set; }

		///<summary>
		/// Campaign Influence
		/// <para>Name: PermissionsCampaignInfluence2</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCampaignInfluence2")]
		public bool? PermissionsCampaignInfluence2 { get; set; }

		///<summary>
		/// Access to view Data Assessment
		/// <para>Name: PermissionsViewDataAssessment</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewDataAssessment")]
		public bool? PermissionsViewDataAssessment { get; set; }

		///<summary>
		/// Remove People from Direct Messages
		/// <para>Name: PermissionsRemoveDirectMessageMembers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsRemoveDirectMessageMembers")]
		public bool? PermissionsRemoveDirectMessageMembers { get; set; }

		///<summary>
		/// Can Approve Feed Post and Comment
		/// <para>Name: PermissionsCanApproveFeedPost</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCanApproveFeedPost")]
		public bool? PermissionsCanApproveFeedPost { get; set; }

		///<summary>
		/// Add People to Direct Messages
		/// <para>Name: PermissionsAddDirectMessageMembers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAddDirectMessageMembers")]
		public bool? PermissionsAddDirectMessageMembers { get; set; }

		///<summary>
		/// View and Edit Converted Leads
		/// <para>Name: PermissionsAllowViewEditConvertedLeads</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAllowViewEditConvertedLeads")]
		public bool? PermissionsAllowViewEditConvertedLeads { get; set; }

		///<summary>
		/// Show Company Name as Site Role
		/// <para>Name: PermissionsShowCompanyNameAsUserBadge</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsShowCompanyNameAsUserBadge")]
		public bool? PermissionsShowCompanyNameAsUserBadge { get; set; }

		///<summary>
		/// Access Experience Management
		/// <para>Name: PermissionsAccessCMC</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAccessCMC")]
		public bool? PermissionsAccessCMC { get; set; }

		///<summary>
		/// View Health Check
		/// <para>Name: PermissionsViewHealthCheck</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewHealthCheck")]
		public bool? PermissionsViewHealthCheck { get; set; }

		///<summary>
		/// Manage Health Check
		/// <para>Name: PermissionsManageHealthCheck</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageHealthCheck")]
		public bool? PermissionsManageHealthCheck { get; set; }

		///<summary>
		/// Create and Update Second-Generation Packages
		/// <para>Name: PermissionsPackaging2</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsPackaging2")]
		public bool? PermissionsPackaging2 { get; set; }

		///<summary>
		/// Manage Certificates
		/// <para>Name: PermissionsManageCertificates</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageCertificates")]
		public bool? PermissionsManageCertificates { get; set; }

		///<summary>
		/// Report Builder (Lightning Experience)
		/// <para>Name: PermissionsCreateReportInLightning</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateReportInLightning")]
		public bool? PermissionsCreateReportInLightning { get; set; }

		///<summary>
		/// Hide Option to Switch to Salesforce Classic
		/// <para>Name: PermissionsPreventClassicExperience</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsPreventClassicExperience")]
		public bool? PermissionsPreventClassicExperience { get; set; }

		///<summary>
		/// Hide the Seen By List
		/// <para>Name: PermissionsHideReadByList</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsHideReadByList")]
		public bool? PermissionsHideReadByList { get; set; }

		///<summary>
		/// Allow sending of List Emails
		/// <para>Name: PermissionsListEmailSend</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsListEmailSend")]
		public bool? PermissionsListEmailSend { get; set; }

		///<summary>
		/// Pin Posts in Feeds
		/// <para>Name: PermissionsFeedPinning</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsFeedPinning")]
		public bool? PermissionsFeedPinning { get; set; }

		///<summary>
		/// Change Dashboard Colors
		/// <para>Name: PermissionsChangeDashboardColors</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsChangeDashboardColors")]
		public bool? PermissionsChangeDashboardColors { get; set; }

		///<summary>
		/// IoT User
		/// <para>Name: PermissionsIotUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsIotUser")]
		public bool? PermissionsIotUser { get; set; }

		///<summary>
		/// Manage Next Best Action Strategies
		/// <para>Name: PermissionsManageRecommendationStrategies</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageRecommendationStrategies")]
		public bool? PermissionsManageRecommendationStrategies { get; set; }

		///<summary>
		/// Manage Next Best Action Recommendations
		/// <para>Name: PermissionsManagePropositions</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManagePropositions")]
		public bool? PermissionsManagePropositions { get; set; }

		///<summary>
		/// Close Conversation Threads
		/// <para>Name: PermissionsCloseConversations</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCloseConversations")]
		public bool? PermissionsCloseConversations { get; set; }

		///<summary>
		/// Subscribe to Reports: Send to Groups and Roles
		/// <para>Name: PermissionsSubscribeReportRolesGrps</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSubscribeReportRolesGrps")]
		public bool? PermissionsSubscribeReportRolesGrps { get; set; }

		///<summary>
		/// Subscribe to Dashboards: Send to Groups and Roles
		/// <para>Name: PermissionsSubscribeDashboardRolesGrps</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSubscribeDashboardRolesGrps")]
		public bool? PermissionsSubscribeDashboardRolesGrps { get; set; }

		///<summary>
		/// Allow Access to Customized Actions
		/// <para>Name: PermissionsUseWebLink</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsUseWebLink")]
		public bool? PermissionsUseWebLink { get; set; }

		///<summary>
		/// User Has Unlimited Next Best Action Strategy Executions
		/// <para>Name: PermissionsHasUnlimitedNBAExecutions</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsHasUnlimitedNBAExecutions")]
		public bool? PermissionsHasUnlimitedNBAExecutions { get; set; }

		///<summary>
		/// Access to View-Only Licensed Templates and Apps
		/// <para>Name: PermissionsViewOnlyEmbeddedAppUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewOnlyEmbeddedAppUser")]
		public bool? PermissionsViewOnlyEmbeddedAppUser { get; set; }

		///<summary>
		/// View All Activities
		/// <para>Name: PermissionsViewAllActivities</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewAllActivities")]
		public bool? PermissionsViewAllActivities { get; set; }

		///<summary>
		/// Subscribe to Reports: Add Recipients
		/// <para>Name: PermissionsSubscribeReportToOtherUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSubscribeReportToOtherUsers")]
		public bool? PermissionsSubscribeReportToOtherUsers { get; set; }

		///<summary>
		/// Lightning Console User
		/// <para>Name: PermissionsLightningConsoleAllowedForUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsLightningConsoleAllowedForUser")]
		public bool? PermissionsLightningConsoleAllowedForUser { get; set; }

		///<summary>
		/// Subscribe to Reports: Set Running User
		/// <para>Name: PermissionsSubscribeReportsRunAsUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSubscribeReportsRunAsUser")]
		public bool? PermissionsSubscribeReportsRunAsUser { get; set; }

		///<summary>
		/// Subscribe to Dashboards
		/// <para>Name: PermissionsSubscribeToLightningDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSubscribeToLightningDashboards")]
		public bool? PermissionsSubscribeToLightningDashboards { get; set; }

		///<summary>
		/// Subscribe to Dashboards: Add Recipients
		/// <para>Name: PermissionsSubscribeDashboardToOtherUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSubscribeDashboardToOtherUsers")]
		public bool? PermissionsSubscribeDashboardToOtherUsers { get; set; }

		///<summary>
		/// Manage Public Lightning Email Templates
		/// <para>Name: PermissionsCreateLtngTempInPub</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateLtngTempInPub")]
		public bool? PermissionsCreateLtngTempInPub { get; set; }

		///<summary>
		/// Send Non-Commercial Email
		/// <para>Name: PermissionsTransactionalEmailSend</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsTransactionalEmailSend")]
		public bool? PermissionsTransactionalEmailSend { get; set; }

		///<summary>
		/// View Private Static Resources
		/// <para>Name: PermissionsViewPrivateStaticResources</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewPrivateStaticResources")]
		public bool? PermissionsViewPrivateStaticResources { get; set; }

		///<summary>
		/// Create Folders for Lightning Email Templates
		/// <para>Name: PermissionsCreateLtngTempFolder</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateLtngTempFolder")]
		public bool? PermissionsCreateLtngTempFolder { get; set; }

		///<summary>
		/// Apex REST Services
		/// <para>Name: PermissionsApexRestServices</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsApexRestServices")]
		public bool? PermissionsApexRestServices { get; set; }

		///<summary>
		/// Show App Launcher in Experience Cloud Sites
		/// <para>Name: PermissionsEnableCommunityAppLauncher</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEnableCommunityAppLauncher")]
		public bool? PermissionsEnableCommunityAppLauncher { get; set; }

		///<summary>
		/// Give Recognition Badges in Experience Builder Sites
		/// <para>Name: PermissionsGiveRecognitionBadge</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsGiveRecognitionBadge")]
		public bool? PermissionsGiveRecognitionBadge { get; set; }

		///<summary>
		/// Einstein Search
		/// <para>Name: PermissionsUseMySearch</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsUseMySearch")]
		public bool? PermissionsUseMySearch { get; set; }

		///<summary>
		/// Remain in Salesforce Classic
		/// <para>Name: PermissionsLtngPromoReserved01UserPerm</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsLtngPromoReserved01UserPerm")]
		public bool? PermissionsLtngPromoReserved01UserPerm { get; set; }

		///<summary>
		/// Manage CRM Analytics Subscriptions
		/// <para>Name: PermissionsManageSubscriptions</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageSubscriptions")]
		public bool? PermissionsManageSubscriptions { get; set; }

		///<summary>
		/// Manage CRM Analytics Private Assets
		/// <para>Name: PermissionsWaveManagePrivateAssetsUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsWaveManagePrivateAssetsUser")]
		public bool? PermissionsWaveManagePrivateAssetsUser { get; set; }

		///<summary>
		/// Edit Dataset Recipes
		/// <para>Name: PermissionsCanEditDataPrepRecipe</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCanEditDataPrepRecipe")]
		public bool? PermissionsCanEditDataPrepRecipe { get; set; }

		///<summary>
		/// Add CRM Analytics Remote Connections
		/// <para>Name: PermissionsAddAnalyticsRemoteConnections</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAddAnalyticsRemoteConnections")]
		public bool? PermissionsAddAnalyticsRemoteConnections { get; set; }

		///<summary>
		/// Manage Surveys
		/// <para>Name: PermissionsManageSurveys</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageSurveys")]
		public bool? PermissionsManageSurveys { get; set; }

		///<summary>
		/// Instant Actionable Results
		/// <para>Name: PermissionsUseAssistantDialog</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsUseAssistantDialog")]
		public bool? PermissionsUseAssistantDialog { get; set; }

		///<summary>
		/// Natural Language Search
		/// <para>Name: PermissionsUseQuerySuggestions</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsUseQuerySuggestions")]
		public bool? PermissionsUseQuerySuggestions { get; set; }

		///<summary>
		/// View Roles and Role Hierarchy
		/// <para>Name: PermissionsViewRoles</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewRoles")]
		public bool? PermissionsViewRoles { get; set; }

		///<summary>
		/// Manage CRM Analytics Custom Maps
		/// <para>Name: PermissionsCanManageMaps</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCanManageMaps")]
		public bool? PermissionsCanManageMaps { get; set; }

		///<summary>
		/// Salesforce Mobile App - Customizable Navigation (Winter &#39;20 Pilot Only)
		/// <para>Name: PermissionsCustomTabBarOnMobile</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCustomTabBarOnMobile")]
		public bool? PermissionsCustomTabBarOnMobile { get; set; }

		///<summary>
		/// Agent Initiated Outbound Messaging
		/// <para>Name: PermissionsLMOutboundMessagingUserPerm</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsLMOutboundMessagingUserPerm")]
		public bool? PermissionsLMOutboundMessagingUserPerm { get; set; }

		///<summary>
		/// Modify Data Classification
		/// <para>Name: PermissionsModifyDataClassification</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsModifyDataClassification")]
		public bool? PermissionsModifyDataClassification { get; set; }

		///<summary>
		/// Allow user to access privacy data
		/// <para>Name: PermissionsPrivacyDataAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsPrivacyDataAccess")]
		public bool? PermissionsPrivacyDataAccess { get; set; }

		///<summary>
		/// Query All Files
		/// <para>Name: PermissionsQueryAllFiles</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsQueryAllFiles")]
		public bool? PermissionsQueryAllFiles { get; set; }

		///<summary>
		/// Modify Metadata Through Metadata API Functions
		/// <para>Name: PermissionsModifyMetadata</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsModifyMetadata")]
		public bool? PermissionsModifyMetadata { get; set; }

		///<summary>
		/// Create CMS Workspaces and Channels
		/// <para>Name: PermissionsManageCMS</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageCMS")]
		public bool? PermissionsManageCMS { get; set; }

		///<summary>
		/// Test Sandboxes in Mobile Publisher for Experience Cloud
		/// <para>Name: PermissionsSandboxTestingInCommunityApp</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSandboxTestingInCommunityApp")]
		public bool? PermissionsSandboxTestingInCommunityApp { get; set; }

		///<summary>
		/// Manage Prompts
		/// <para>Name: PermissionsCanEditPrompts</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCanEditPrompts")]
		public bool? PermissionsCanEditPrompts { get; set; }

		///<summary>
		/// View Concealed Field Data
		/// <para>Name: PermissionsViewUserPII</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewUserPII")]
		public bool? PermissionsViewUserPII { get; set; }

		///<summary>
		/// Connect Org to Customer 360 Data Manager
		/// <para>Name: PermissionsManageHubConnections</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageHubConnections")]
		public bool? PermissionsManageHubConnections { get; set; }

		///<summary>
		/// Create B2B Marketing Analytics Apps
		/// <para>Name: PermissionsB2BMarketingAnalyticsUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsB2BMarketingAnalyticsUser")]
		public bool? PermissionsB2BMarketingAnalyticsUser { get; set; }

		///<summary>
		/// Access Tracer for External Data Sources
		/// <para>Name: PermissionsTraceXdsQueries</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsTraceXdsQueries")]
		public bool? PermissionsTraceXdsQueries { get; set; }

		///<summary>
		/// View Security Center pages
		/// <para>Name: PermissionsViewSecurityCommandCenter</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewSecurityCommandCenter")]
		public bool? PermissionsViewSecurityCommandCenter { get; set; }

		///<summary>
		/// Manage Security Center
		/// <para>Name: PermissionsManageSecurityCommandCenter</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageSecurityCommandCenter")]
		public bool? PermissionsManageSecurityCommandCenter { get; set; }

		///<summary>
		/// View All Custom Settings
		/// <para>Name: PermissionsViewAllCustomSettings</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewAllCustomSettings")]
		public bool? PermissionsViewAllCustomSettings { get; set; }

		///<summary>
		/// View All Lookup Record Names
		/// <para>Name: PermissionsViewAllForeignKeyNames</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewAllForeignKeyNames")]
		public bool? PermissionsViewAllForeignKeyNames { get; set; }

		///<summary>
		/// Add Recipients to CRM Analytics Notifications
		/// <para>Name: PermissionsAddWaveNotificationRecipients</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAddWaveNotificationRecipients")]
		public bool? PermissionsAddWaveNotificationRecipients { get; set; }

		///<summary>
		/// Enable Salesforce CMS Integration
		/// <para>Name: PermissionsHeadlessCMSAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsHeadlessCMSAccess")]
		public bool? PermissionsHeadlessCMSAccess { get; set; }

		///<summary>
		/// End Messaging Session
		/// <para>Name: PermissionsLMEndMessagingSessionUserPerm</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsLMEndMessagingSessionUserPerm")]
		public bool? PermissionsLMEndMessagingSessionUserPerm { get; set; }

		///<summary>
		/// Update Consent Preferences Using REST API
		/// <para>Name: PermissionsConsentApiUpdate</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsConsentApiUpdate")]
		public bool? PermissionsConsentApiUpdate { get; set; }

		///<summary>
		/// Payments Api User
		/// <para>Name: PermissionsPaymentsAPIUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsPaymentsAPIUser")]
		public bool? PermissionsPaymentsAPIUser { get; set; }

		///<summary>
		/// Access drag-and-drop content builder
		/// <para>Name: PermissionsAccessContentBuilder</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAccessContentBuilder")]
		public bool? PermissionsAccessContentBuilder { get; set; }

		///<summary>
		/// Account Switcher User
		/// <para>Name: PermissionsAccountSwitcherUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAccountSwitcherUser")]
		public bool? PermissionsAccountSwitcherUser { get; set; }

		///<summary>
		/// View Threat Detection Events
		/// <para>Name: PermissionsViewAnomalyEvents</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewAnomalyEvents")]
		public bool? PermissionsViewAnomalyEvents { get; set; }

		///<summary>
		/// Connect Org to Customer Data Cloud
		/// <para>Name: PermissionsManageC360AConnections</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageC360AConnections")]
		public bool? PermissionsManageC360AConnections { get; set; }

		///<summary>
		/// Manage Release Updates
		/// <para>Name: PermissionsManageReleaseUpdates</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageReleaseUpdates")]
		public bool? PermissionsManageReleaseUpdates { get; set; }

		///<summary>
		/// View All Profiles
		/// <para>Name: PermissionsViewAllProfiles</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewAllProfiles")]
		public bool? PermissionsViewAllProfiles { get; set; }

		///<summary>
		/// Skip Device Activation at Login
		/// <para>Name: PermissionsSkipIdentityConfirmation</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSkipIdentityConfirmation")]
		public bool? PermissionsSkipIdentityConfirmation { get; set; }

		///<summary>
		/// Manage Learning
		/// <para>Name: PermissionsLearningManager</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsLearningManager")]
		public bool? PermissionsLearningManager { get; set; }

		///<summary>
		/// Send Custom Notifications
		/// <para>Name: PermissionsSendCustomNotifications</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSendCustomNotifications")]
		public bool? PermissionsSendCustomNotifications { get; set; }

		///<summary>
		/// Delete Second-Generation Packages
		/// <para>Name: PermissionsPackaging2Delete</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsPackaging2Delete")]
		public bool? PermissionsPackaging2Delete { get; set; }

		///<summary>
		/// Use Omnichannel Inventory APIs
		/// <para>Name: PermissionsUseOmnichannelInventoryAPIs</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsUseOmnichannelInventoryAPIs")]
		public bool? PermissionsUseOmnichannelInventoryAPIs { get; set; }

		///<summary>
		/// View Restriction and Scoping Rules
		/// <para>Name: PermissionsViewRestrictionAndScopingRules</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewRestrictionAndScopingRules")]
		public bool? PermissionsViewRestrictionAndScopingRules { get; set; }

		///<summary>
		/// User license to access Lightning components and features delivered in Financial Services Cloud.
		/// <para>Name: PermissionsFSCComprehensiveUserAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsFSCComprehensiveUserAccess")]
		public bool? PermissionsFSCComprehensiveUserAccess { get; set; }

		///<summary>
		/// Manage Bots
		/// <para>Name: PermissionsBotManageBots</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsBotManageBots")]
		public bool? PermissionsBotManageBots { get; set; }

		///<summary>
		/// Manage Bots Training Data
		/// <para>Name: PermissionsBotManageBotsTrainingData</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsBotManageBotsTrainingData")]
		public bool? PermissionsBotManageBotsTrainingData { get; set; }

		///<summary>
		/// Omnichannel Inventory Sync
		/// <para>Name: PermissionsOmnichannelInventorySync</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsOmnichannelInventorySync")]
		public bool? PermissionsOmnichannelInventorySync { get; set; }

		///<summary>
		/// Manage Learning Reporting
		/// <para>Name: PermissionsManageLearningReporting</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageLearningReporting")]
		public bool? PermissionsManageLearningReporting { get; set; }

		///<summary>
		/// Salesforce Anywhere Integration Access
		/// <para>Name: PermissionsIsotopeCToCUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsIsotopeCToCUser")]
		public bool? PermissionsIsotopeCToCUser { get; set; }

		///<summary>
		/// Salesforce Anywhere on Mobile
		/// <para>Name: PermissionsIsotopeAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsIsotopeAccess")]
		public bool? PermissionsIsotopeAccess { get; set; }

		///<summary>
		/// Salesforce Anywhere in Lightning Experience
		/// <para>Name: PermissionsIsotopeLEX</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsIsotopeLEX")]
		public bool? PermissionsIsotopeLEX { get; set; }

		///<summary>
		/// Quip Metrics
		/// <para>Name: PermissionsQuipMetricsAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsQuipMetricsAccess")]
		public bool? PermissionsQuipMetricsAccess { get; set; }

		///<summary>
		/// Quip User Engagement Metrics
		/// <para>Name: PermissionsQuipUserEngagementMetrics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsQuipUserEngagementMetrics")]
		public bool? PermissionsQuipUserEngagementMetrics { get; set; }

		///<summary>
		/// Exempt from Transaction Security
		/// <para>Name: PermissionsTransactionSecurityExempt</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsTransactionSecurityExempt")]
		public bool? PermissionsTransactionSecurityExempt { get; set; }

		///<summary>
		/// Allow user to modify Private Connections
		/// <para>Name: PermissionsManageExternalConnections</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageExternalConnections")]
		public bool? PermissionsManageExternalConnections { get; set; }

		///<summary>
		/// Subscribe to CRM Analytics Assets
		/// <para>Name: PermissionsUseSubscriptionEmails</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsUseSubscriptionEmails")]
		public bool? PermissionsUseSubscriptionEmails { get; set; }

		///<summary>
		/// View AI Insight Objects
		/// <para>Name: PermissionsAIViewInsightObjects</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAIViewInsightObjects")]
		public bool? PermissionsAIViewInsightObjects { get; set; }

		///<summary>
		/// Create AI Insight Objects
		/// <para>Name: PermissionsAICreateInsightObjects</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAICreateInsightObjects")]
		public bool? PermissionsAICreateInsightObjects { get; set; }

		///<summary>
		/// Allow users to view MLModels and related Entities
		/// <para>Name: PermissionsViewMLModels</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewMLModels")]
		public bool? PermissionsViewMLModels { get; set; }

		///<summary>
		/// Access Customer Asset Lifecycle Management APIs
		/// <para>Name: PermissionsLifecycleManagementAPIUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsLifecycleManagementAPIUser")]
		public bool? PermissionsLifecycleManagementAPIUser { get; set; }

		///<summary>
		/// Salesforce Mobile App: Native scrolling on webviews
		/// <para>Name: PermissionsNativeWebviewScrolling</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsNativeWebviewScrolling")]
		public bool? PermissionsNativeWebviewScrolling { get; set; }

		///<summary>
		/// View DeveloperName
		/// <para>Name: PermissionsViewDeveloperName</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewDeveloperName")]
		public bool? PermissionsViewDeveloperName { get; set; }

		///<summary>
		/// Waive Multi-Factor Authentication for Exempt Users
		/// <para>Name: PermissionsBypassMFAForUiLogins</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsBypassMFAForUiLogins")]
		public bool? PermissionsBypassMFAForUiLogins { get; set; }

		///<summary>
		/// Allow consumer key and secret rotation
		/// <para>Name: PermissionsClientSecretRotation</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsClientSecretRotation")]
		public bool? PermissionsClientSecretRotation { get; set; }

		///<summary>
		/// View and generate Einstein Conversation Mining reports
		/// <para>Name: PermissionsManageConvMiningReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageConvMiningReports")]
		public bool? PermissionsManageConvMiningReports { get; set; }

		///<summary>
		/// Manage Multi-Step Scheduling features
		/// <para>Name: PermissionsMultiStepSchedulingUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsMultiStepSchedulingUser")]
		public bool? PermissionsMultiStepSchedulingUser { get; set; }

		///<summary>
		/// Service Process User
		/// <para>Name: PermissionsAccessToServiceProcess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAccessToServiceProcess")]
		public bool? PermissionsAccessToServiceProcess { get; set; }

		///<summary>
		/// Manage Orchestration Runs and Work Items
		/// <para>Name: PermissionsManageOrchInstsAndWorkItems</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageOrchInstsAndWorkItems")]
		public bool? PermissionsManageOrchInstsAndWorkItems { get; set; }

		///<summary>
		/// Migrate Enablement Content
		/// <para>Name: PermissionsCMSECEAuthoringAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCMSECEAuthoringAccess")]
		public bool? PermissionsCMSECEAuthoringAccess { get; set; }

		///<summary>
		/// Manage Dataspace Scope
		/// <para>Name: PermissionsManageDataspaceScope</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageDataspaceScope")]
		public bool? PermissionsManageDataspaceScope { get; set; }

		///<summary>
		/// Configure Dataspace Scope
		/// <para>Name: PermissionsConfigureDataspaceScope</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsConfigureDataspaceScope")]
		public bool? PermissionsConfigureDataspaceScope { get; set; }

		///<summary>
		/// Allow blockchain data upload
		/// <para>Name: PermissionsEnableIPFSUpload</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEnableIPFSUpload")]
		public bool? PermissionsEnableIPFSUpload { get; set; }

		///<summary>
		/// Enable blockchain transaction polling API
		/// <para>Name: PermissionsEnableBCTransactionPolling</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEnableBCTransactionPolling")]
		public bool? PermissionsEnableBCTransactionPolling { get; set; }

		///<summary>
		/// Access Actionable Relationship Center for partner users
		/// <para>Name: PermissionsFSCArcGraphCommunityUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsFSCArcGraphCommunityUser")]
		public bool? PermissionsFSCArcGraphCommunityUser { get; set; }

		///<summary>
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

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
		/// Namespace Prefix
		/// <para>Name: NamespacePrefix</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "namespacePrefix")]
		[Updateable(false), Createable(false)]
		public string NamespacePrefix { get; set; }

		///<summary>
		/// Session Activation Required
		/// <para>Name: HasActivationRequired</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasActivationRequired")]
		public bool? HasActivationRequired { get; set; }

		///<summary>
		/// PermissionSetGroup ID
		/// <para>Name: PermissionSetGroupId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionSetGroupId")]
		[Updateable(false), Createable(false)]
		public string PermissionSetGroupId { get; set; }

		///<summary>
		/// ReferenceTo: PermissionSetGroup
		/// <para>RelationshipName: PermissionSetGroup</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionSetGroup")]
		[Updateable(false), Createable(false)]
		public SfPermissionSetGroup PermissionSetGroup { get; set; }

		///<summary>
		/// Permission Set Type
		/// <para>Name: Type</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		[Updateable(false), Createable(false)]
		public string Type { get; set; }

	}
}
