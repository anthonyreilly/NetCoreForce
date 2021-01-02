// SF API version v50.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// User Permission Access
	///<para>SObject Name: UserPermissionAccess</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfUserPermissionAccess : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "UserPermissionAccess"; }
		}

		///<summary>
		/// UserPermissionAccess ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Last Cache Update
		/// <para>Name: LastCacheUpdate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastCacheUpdate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastCacheUpdate { get; set; }

		///<summary>
		/// Send Email
		/// <para>Name: PermissionsEmailSingle</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEmailSingle")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsEmailSingle { get; set; }

		///<summary>
		/// Mass Email
		/// <para>Name: PermissionsEmailMass</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEmailMass")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsEmailMass { get; set; }

		///<summary>
		/// Edit Tasks
		/// <para>Name: PermissionsEditTask</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditTask")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsEditTask { get; set; }

		///<summary>
		/// Edit Events
		/// <para>Name: PermissionsEditEvent</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditEvent")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsEditEvent { get; set; }

		///<summary>
		/// Export Reports
		/// <para>Name: PermissionsExportReport</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsExportReport")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsExportReport { get; set; }

		///<summary>
		/// Import Personal Contacts
		/// <para>Name: PermissionsImportPersonal</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsImportPersonal")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsImportPersonal { get; set; }

		///<summary>
		/// Weekly Data Export
		/// <para>Name: PermissionsDataExport</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsDataExport")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsDataExport { get; set; }

		///<summary>
		/// Manage Users
		/// <para>Name: PermissionsManageUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageUsers")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageUsers { get; set; }

		///<summary>
		/// Manage Public List Views
		/// <para>Name: PermissionsEditPublicFilters</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditPublicFilters")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsEditPublicFilters { get; set; }

		///<summary>
		/// Manage Public Classic Email Templates
		/// <para>Name: PermissionsEditPublicTemplates</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditPublicTemplates")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsEditPublicTemplates { get; set; }

		///<summary>
		/// Modify All Data
		/// <para>Name: PermissionsModifyAllData</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsModifyAllData")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsModifyAllData { get; set; }

		///<summary>
		/// Manage Cases
		/// <para>Name: PermissionsManageCases</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageCases")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageCases { get; set; }

		///<summary>
		/// Mass Edits from Lists
		/// <para>Name: PermissionsMassInlineEdit</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsMassInlineEdit")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsMassInlineEdit { get; set; }

		///<summary>
		/// Manage Articles
		/// <para>Name: PermissionsEditKnowledge</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditKnowledge")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsEditKnowledge { get; set; }

		///<summary>
		/// Manage Salesforce Knowledge
		/// <para>Name: PermissionsManageKnowledge</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageKnowledge")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageKnowledge { get; set; }

		///<summary>
		/// Manage Published Solutions
		/// <para>Name: PermissionsManageSolutions</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageSolutions")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageSolutions { get; set; }

		///<summary>
		/// Customize Application
		/// <para>Name: PermissionsCustomizeApplication</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCustomizeApplication")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsCustomizeApplication { get; set; }

		///<summary>
		/// Edit Read Only Fields
		/// <para>Name: PermissionsEditReadonlyFields</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditReadonlyFields")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsEditReadonlyFields { get; set; }

		///<summary>
		/// Run Reports
		/// <para>Name: PermissionsRunReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsRunReports")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsRunReports { get; set; }

		///<summary>
		/// View Setup and Configuration
		/// <para>Name: PermissionsViewSetup</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewSetup")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsViewSetup { get; set; }

		///<summary>
		/// Transfer Record
		/// <para>Name: PermissionsTransferAnyEntity</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsTransferAnyEntity")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsTransferAnyEntity { get; set; }

		///<summary>
		/// Report Builder
		/// <para>Name: PermissionsNewReportBuilder</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsNewReportBuilder")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsNewReportBuilder { get; set; }

		///<summary>
		/// Activate Contracts
		/// <para>Name: PermissionsActivateContract</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsActivateContract")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsActivateContract { get; set; }

		///<summary>
		/// Activate Orders
		/// <para>Name: PermissionsActivateOrder</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsActivateOrder")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsActivateOrder { get; set; }

		///<summary>
		/// Import Leads
		/// <para>Name: PermissionsImportLeads</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsImportLeads")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsImportLeads { get; set; }

		///<summary>
		/// Manage Leads
		/// <para>Name: PermissionsManageLeads</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageLeads")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageLeads { get; set; }

		///<summary>
		/// Transfer Leads
		/// <para>Name: PermissionsTransferAnyLead</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsTransferAnyLead")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsTransferAnyLead { get; set; }

		///<summary>
		/// View All Data
		/// <para>Name: PermissionsViewAllData</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewAllData")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsViewAllData { get; set; }

		///<summary>
		/// Manage Public Documents
		/// <para>Name: PermissionsEditPublicDocuments</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditPublicDocuments")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsEditPublicDocuments { get; set; }

		///<summary>
		/// Files Connect On-premises
		/// <para>Name: PermissionsContentHubOnPremiseUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsContentHubOnPremiseUser")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsContentHubOnPremiseUser { get; set; }

		///<summary>
		/// View Encrypted Data
		/// <para>Name: PermissionsViewEncryptedData</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewEncryptedData")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsViewEncryptedData { get; set; }

		///<summary>
		/// Manage Letterheads
		/// <para>Name: PermissionsEditBrandTemplates</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditBrandTemplates")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsEditBrandTemplates { get; set; }

		///<summary>
		/// Edit HTML Templates
		/// <para>Name: PermissionsEditHtmlTemplates</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditHtmlTemplates")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsEditHtmlTemplates { get; set; }

		///<summary>
		/// Chatter Internal User
		/// <para>Name: PermissionsChatterInternalUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsChatterInternalUser")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsChatterInternalUser { get; set; }

		///<summary>
		/// Manage Encryption Keys
		/// <para>Name: PermissionsManageEncryptionKeys</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageEncryptionKeys")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageEncryptionKeys { get; set; }

		///<summary>
		/// Delete Activated Contracts
		/// <para>Name: PermissionsDeleteActivatedContract</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsDeleteActivatedContract")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsDeleteActivatedContract { get; set; }

		///<summary>
		/// Invite Customers To Chatter
		/// <para>Name: PermissionsChatterInviteExternalUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsChatterInviteExternalUsers")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsChatterInviteExternalUsers { get; set; }

		///<summary>
		/// Send Stay-in-Touch Requests
		/// <para>Name: PermissionsSendSitRequests</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSendSitRequests")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsSendSitRequests { get; set; }

		///<summary>
		/// Manage Connected Apps
		/// <para>Name: PermissionsManageRemoteAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageRemoteAccess")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageRemoteAccess { get; set; }

		///<summary>
		/// Drag-and-Drop Dashboard Builder
		/// <para>Name: PermissionsCanUseNewDashboardBuilder</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCanUseNewDashboardBuilder")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsCanUseNewDashboardBuilder { get; set; }

		///<summary>
		/// Manage Categories
		/// <para>Name: PermissionsManageCategories</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageCategories")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageCategories { get; set; }

		///<summary>
		/// Convert Leads
		/// <para>Name: PermissionsConvertLeads</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsConvertLeads")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsConvertLeads { get; set; }

		///<summary>
		/// Password Never Expires
		/// <para>Name: PermissionsPasswordNeverExpires</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsPasswordNeverExpires")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsPasswordNeverExpires { get; set; }

		///<summary>
		/// Use Team Reassignment Wizards
		/// <para>Name: PermissionsUseTeamReassignWizards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsUseTeamReassignWizards")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsUseTeamReassignWizards { get; set; }

		///<summary>
		/// Edit Activated Orders
		/// <para>Name: PermissionsEditActivatedOrders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditActivatedOrders")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsEditActivatedOrders { get; set; }

		///<summary>
		/// Download AppExchange Packages
		/// <para>Name: PermissionsInstallPackaging</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsInstallPackaging")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsInstallPackaging { get; set; }

		///<summary>
		/// Upload AppExchange Packages
		/// <para>Name: PermissionsPublishPackaging</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsPublishPackaging")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsPublishPackaging { get; set; }

		///<summary>
		/// Create and Own New Chatter Groups
		/// <para>Name: PermissionsChatterOwnGroups</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsChatterOwnGroups")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsChatterOwnGroups { get; set; }

		///<summary>
		/// Edit Opportunity Product Sales Price
		/// <para>Name: PermissionsEditOppLineItemUnitPrice</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditOppLineItemUnitPrice")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsEditOppLineItemUnitPrice { get; set; }

		///<summary>
		/// Create AppExchange Packages
		/// <para>Name: PermissionsCreatePackaging</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreatePackaging")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsCreatePackaging { get; set; }

		///<summary>
		/// Bulk API Hard Delete
		/// <para>Name: PermissionsBulkApiHardDelete</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsBulkApiHardDelete")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsBulkApiHardDelete { get; set; }

		///<summary>
		/// Import Solutions
		/// <para>Name: PermissionsSolutionImport</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSolutionImport")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsSolutionImport { get; set; }

		///<summary>
		/// Manage Call Centers
		/// <para>Name: PermissionsManageCallCenters</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageCallCenters")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageCallCenters { get; set; }

		///<summary>
		/// Manage Synonyms
		/// <para>Name: PermissionsManageSynonyms</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageSynonyms")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageSynonyms { get; set; }

		///<summary>
		/// View Content in Portals
		/// <para>Name: PermissionsViewContent</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewContent")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsViewContent { get; set; }

		///<summary>
		/// Manage Email Client Configurations
		/// <para>Name: PermissionsManageEmailClientConfig</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageEmailClientConfig")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageEmailClientConfig { get; set; }

		///<summary>
		/// Send Outbound Messages
		/// <para>Name: PermissionsEnableNotifications</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEnableNotifications")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsEnableNotifications { get; set; }

		///<summary>
		/// Manage Data Integrations
		/// <para>Name: PermissionsManageDataIntegrations</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageDataIntegrations")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageDataIntegrations { get; set; }

		///<summary>
		/// Create Content Deliveries
		/// <para>Name: PermissionsDistributeFromPersWksp</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsDistributeFromPersWksp")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsDistributeFromPersWksp { get; set; }

		///<summary>
		/// View Data Categories in Setup
		/// <para>Name: PermissionsViewDataCategories</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewDataCategories")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsViewDataCategories { get; set; }

		///<summary>
		/// Manage Data Categories
		/// <para>Name: PermissionsManageDataCategories</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageDataCategories")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageDataCategories { get; set; }

		///<summary>
		/// Author Apex
		/// <para>Name: PermissionsAuthorApex</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAuthorApex")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsAuthorApex { get; set; }

		///<summary>
		/// Manage Mobile Configurations
		/// <para>Name: PermissionsManageMobile</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageMobile")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageMobile { get; set; }

		///<summary>
		/// API Enabled
		/// <para>Name: PermissionsApiEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsApiEnabled")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsApiEnabled { get; set; }

		///<summary>
		/// Manage Custom Report Types
		/// <para>Name: PermissionsManageCustomReportTypes</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageCustomReportTypes")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageCustomReportTypes { get; set; }

		///<summary>
		/// Edit Case Comments
		/// <para>Name: PermissionsEditCaseComments</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditCaseComments")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsEditCaseComments { get; set; }

		///<summary>
		/// Transfer Cases
		/// <para>Name: PermissionsTransferAnyCase</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsTransferAnyCase")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsTransferAnyCase { get; set; }

		///<summary>
		/// Manage Salesforce CRM Content
		/// <para>Name: PermissionsContentAdministrator</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsContentAdministrator")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsContentAdministrator { get; set; }

		///<summary>
		/// Create Libraries
		/// <para>Name: PermissionsCreateWorkspaces</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateWorkspaces")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsCreateWorkspaces { get; set; }

		///<summary>
		/// Manage Content Permissions
		/// <para>Name: PermissionsManageContentPermissions</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageContentPermissions")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageContentPermissions { get; set; }

		///<summary>
		/// Manage Content Properties
		/// <para>Name: PermissionsManageContentProperties</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageContentProperties")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageContentProperties { get; set; }

		///<summary>
		/// Manage record types and layouts for Files
		/// <para>Name: PermissionsManageContentTypes</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageContentTypes")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageContentTypes { get; set; }

		///<summary>
		/// Manage Lightning Sync
		/// <para>Name: PermissionsManageExchangeConfig</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageExchangeConfig")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageExchangeConfig { get; set; }

		///<summary>
		/// Manage Reporting Snapshots
		/// <para>Name: PermissionsManageAnalyticSnapshots</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageAnalyticSnapshots")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageAnalyticSnapshots { get; set; }

		///<summary>
		/// Schedule Reports
		/// <para>Name: PermissionsScheduleReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsScheduleReports")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsScheduleReports { get; set; }

		///<summary>
		/// Manage Business Hours Holidays
		/// <para>Name: PermissionsManageBusinessHourHolidays</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageBusinessHourHolidays")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageBusinessHourHolidays { get; set; }

		///<summary>
		/// Manage Dynamic Dashboards
		/// <para>Name: PermissionsManageDynamicDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageDynamicDashboards")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageDynamicDashboards { get; set; }

		///<summary>
		/// Show Custom Sidebar On All Pages
		/// <para>Name: PermissionsCustomSidebarOnAllPages</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCustomSidebarOnAllPages")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsCustomSidebarOnAllPages { get; set; }

		///<summary>
		/// Manage Flow
		/// <para>Name: PermissionsManageInteraction</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageInteraction")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageInteraction { get; set; }

		///<summary>
		/// View My Team&#39;s Dashboards
		/// <para>Name: PermissionsViewMyTeamsDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewMyTeamsDashboards")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsViewMyTeamsDashboards { get; set; }

		///<summary>
		/// Moderate Chatter
		/// <para>Name: PermissionsModerateChatter</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsModerateChatter")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsModerateChatter { get; set; }

		///<summary>
		/// Reset User Passwords and Unlock Users
		/// <para>Name: PermissionsResetPasswords</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsResetPasswords")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsResetPasswords { get; set; }

		///<summary>
		/// Require Flow User Feature License
		/// <para>Name: PermissionsFlowUFLRequired</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsFlowUFLRequired")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsFlowUFLRequired { get; set; }

		///<summary>
		/// Insert System Field Values for Chatter Feeds
		/// <para>Name: PermissionsCanInsertFeedSystemFields</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCanInsertFeedSystemFields")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsCanInsertFeedSystemFields { get; set; }

		///<summary>
		/// Access Activities
		/// <para>Name: PermissionsActivitiesAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsActivitiesAccess")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsActivitiesAccess { get; set; }

		///<summary>
		/// Manage Knowledge Article Import/Export
		/// <para>Name: PermissionsManageKnowledgeImportExport</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageKnowledgeImportExport")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageKnowledgeImportExport { get; set; }

		///<summary>
		/// Manage Email Templates
		/// <para>Name: PermissionsEmailTemplateManagement</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEmailTemplateManagement")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsEmailTemplateManagement { get; set; }

		///<summary>
		/// Email Administration
		/// <para>Name: PermissionsEmailAdministration</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEmailAdministration")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsEmailAdministration { get; set; }

		///<summary>
		/// Manage Chatter Messages and Direct Messages
		/// <para>Name: PermissionsManageChatterMessages</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageChatterMessages")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageChatterMessages { get; set; }

		///<summary>
		/// Email-Based Identity Verification Option
		/// <para>Name: PermissionsAllowEmailIC</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAllowEmailIC")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsAllowEmailIC { get; set; }

		///<summary>
		/// Create Public Links
		/// <para>Name: PermissionsChatterFileLink</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsChatterFileLink")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsChatterFileLink { get; set; }

		///<summary>
		/// Multi-Factor Authentication for User Interface Logins
		/// <para>Name: PermissionsForceTwoFactor</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsForceTwoFactor")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsForceTwoFactor { get; set; }

		///<summary>
		/// View Event Log Files
		/// <para>Name: PermissionsViewEventLogFiles</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewEventLogFiles")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsViewEventLogFiles { get; set; }

		///<summary>
		/// Create and Set Up Communities
		/// <para>Name: PermissionsManageNetworks</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageNetworks")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageNetworks { get; set; }

		///<summary>
		/// Manage Auth. Providers
		/// <para>Name: PermissionsManageAuthProviders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageAuthProviders")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageAuthProviders { get; set; }

		///<summary>
		/// Run Flows
		/// <para>Name: PermissionsRunFlow</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsRunFlow")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsRunFlow { get; set; }

		///<summary>
		/// Create and Customize Dashboards
		/// <para>Name: PermissionsCreateCustomizeDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateCustomizeDashboards")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsCreateCustomizeDashboards { get; set; }

		///<summary>
		/// Create Dashboard Folders
		/// <para>Name: PermissionsCreateDashboardFolders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateDashboardFolders")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsCreateDashboardFolders { get; set; }

		///<summary>
		/// View Dashboards in Public Folders
		/// <para>Name: PermissionsViewPublicDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewPublicDashboards")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsViewPublicDashboards { get; set; }

		///<summary>
		/// Manage Dashboards in Public Folders
		/// <para>Name: PermissionsManageDashbdsInPubFolders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageDashbdsInPubFolders")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageDashbdsInPubFolders { get; set; }

		///<summary>
		/// Create and Customize Reports
		/// <para>Name: PermissionsCreateCustomizeReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateCustomizeReports")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsCreateCustomizeReports { get; set; }

		///<summary>
		/// Create Report Folders
		/// <para>Name: PermissionsCreateReportFolders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateReportFolders")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsCreateReportFolders { get; set; }

		///<summary>
		/// View Reports in Public Folders
		/// <para>Name: PermissionsViewPublicReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewPublicReports")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsViewPublicReports { get; set; }

		///<summary>
		/// Manage Reports in Public Folders
		/// <para>Name: PermissionsManageReportsInPubFolders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageReportsInPubFolders")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageReportsInPubFolders { get; set; }

		///<summary>
		/// Edit My Dashboards
		/// <para>Name: PermissionsEditMyDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditMyDashboards")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsEditMyDashboards { get; set; }

		///<summary>
		/// Edit My Reports
		/// <para>Name: PermissionsEditMyReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditMyReports")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsEditMyReports { get; set; }

		///<summary>
		/// View All Users
		/// <para>Name: PermissionsViewAllUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewAllUsers")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsViewAllUsers { get; set; }

		///<summary>
		/// Knowledge One
		/// <para>Name: PermissionsAllowUniversalSearch</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAllowUniversalSearch")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsAllowUniversalSearch { get; set; }

		///<summary>
		/// Connect Organization to Environment Hub
		/// <para>Name: PermissionsConnectOrgToEnvironmentHub</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsConnectOrgToEnvironmentHub")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsConnectOrgToEnvironmentHub { get; set; }

		///<summary>
		/// Enable WDC Calibration
		/// <para>Name: PermissionsWorkCalibrationUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsWorkCalibrationUser")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsWorkCalibrationUser { get; set; }

		///<summary>
		/// Create and Customize List Views
		/// <para>Name: PermissionsCreateCustomizeFilters</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateCustomizeFilters")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsCreateCustomizeFilters { get; set; }

		///<summary>
		/// Enable WDC
		/// <para>Name: PermissionsWorkDotComUserPerm</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsWorkDotComUserPerm")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsWorkDotComUserPerm { get; set; }

		///<summary>
		/// Files Connect Cloud
		/// <para>Name: PermissionsContentHubUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsContentHubUser")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsContentHubUser { get; set; }

		///<summary>
		/// Manage Communities
		/// <para>Name: PermissionsGovernNetworks</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsGovernNetworks")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsGovernNetworks { get; set; }

		///<summary>
		/// Sales Console
		/// <para>Name: PermissionsSalesConsole</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSalesConsole")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsSalesConsole { get; set; }

		///<summary>
		/// Multi-Factor Authentication for API Logins
		/// <para>Name: PermissionsTwoFactorApi</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsTwoFactorApi")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsTwoFactorApi { get; set; }

		///<summary>
		/// Delete Topics
		/// <para>Name: PermissionsDeleteTopics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsDeleteTopics")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsDeleteTopics { get; set; }

		///<summary>
		/// Edit Topics
		/// <para>Name: PermissionsEditTopics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditTopics")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsEditTopics { get; set; }

		///<summary>
		/// Create Topics
		/// <para>Name: PermissionsCreateTopics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateTopics")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsCreateTopics { get; set; }

		///<summary>
		/// Assign Topics
		/// <para>Name: PermissionsAssignTopics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAssignTopics")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsAssignTopics { get; set; }

		///<summary>
		/// Use Identity Features
		/// <para>Name: PermissionsIdentityEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsIdentityEnabled")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsIdentityEnabled { get; set; }

		///<summary>
		/// Use Identity Connect
		/// <para>Name: PermissionsIdentityConnect</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsIdentityConnect")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsIdentityConnect { get; set; }

		///<summary>
		/// Allow View Knowledge
		/// <para>Name: PermissionsAllowViewKnowledge</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAllowViewKnowledge")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsAllowViewKnowledge { get; set; }

		///<summary>
		/// Access Libraries
		/// <para>Name: PermissionsContentWorkspaces</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsContentWorkspaces")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsContentWorkspaces { get; set; }

		///<summary>
		/// Manage Promoted Search Terms
		/// <para>Name: PermissionsManageSearchPromotionRules</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageSearchPromotionRules")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageSearchPromotionRules { get; set; }

		///<summary>
		/// Access Custom Mobile Apps
		/// <para>Name: PermissionsCustomMobileAppsAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCustomMobileAppsAccess")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsCustomMobileAppsAccess { get; set; }

		///<summary>
		/// View Help Link
		/// <para>Name: PermissionsViewHelpLink</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewHelpLink")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsViewHelpLink { get; set; }

		///<summary>
		/// Manage Profiles and Permission Sets
		/// <para>Name: PermissionsManageProfilesPermissionsets</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageProfilesPermissionsets")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageProfilesPermissionsets { get; set; }

		///<summary>
		/// Assign Permission Sets
		/// <para>Name: PermissionsAssignPermissionSets</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAssignPermissionSets")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsAssignPermissionSets { get; set; }

		///<summary>
		/// Manage Roles
		/// <para>Name: PermissionsManageRoles</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageRoles")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageRoles { get; set; }

		///<summary>
		/// Manage IP Addresses
		/// <para>Name: PermissionsManageIpAddresses</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageIpAddresses")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageIpAddresses { get; set; }

		///<summary>
		/// Manage Sharing
		/// <para>Name: PermissionsManageSharing</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageSharing")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageSharing { get; set; }

		///<summary>
		/// Manage Internal Users
		/// <para>Name: PermissionsManageInternalUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageInternalUsers")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageInternalUsers { get; set; }

		///<summary>
		/// Manage Password Policies
		/// <para>Name: PermissionsManagePasswordPolicies</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManagePasswordPolicies")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManagePasswordPolicies { get; set; }

		///<summary>
		/// Manage Login Access Policies
		/// <para>Name: PermissionsManageLoginAccessPolicies</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageLoginAccessPolicies")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageLoginAccessPolicies { get; set; }

		///<summary>
		/// View Login Forensics Events
		/// <para>Name: PermissionsViewPlatformEvents</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewPlatformEvents")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsViewPlatformEvents { get; set; }

		///<summary>
		/// Manage Custom Permissions
		/// <para>Name: PermissionsManageCustomPermissions</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageCustomPermissions")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageCustomPermissions { get; set; }

		///<summary>
		/// Verify Answers to Chatter Questions
		/// <para>Name: PermissionsCanVerifyComment</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCanVerifyComment")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsCanVerifyComment { get; set; }

		///<summary>
		/// Manage Unlisted Groups
		/// <para>Name: PermissionsManageUnlistedGroups</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageUnlistedGroups")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageUnlistedGroups { get; set; }

		///<summary>
		/// Use Einstein Activity Capture Standard
		/// <para>Name: PermissionsStdAutomaticActivityCapture</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsStdAutomaticActivityCapture")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsStdAutomaticActivityCapture { get; set; }

		///<summary>
		/// Modify Secure Agents
		/// <para>Name: PermissionsModifySecureAgents</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsModifySecureAgents")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsModifySecureAgents { get; set; }

		///<summary>
		/// Create and Edit Analytics Dashboards
		/// <para>Name: PermissionsInsightsAppDashboardEditor</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsInsightsAppDashboardEditor")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsInsightsAppDashboardEditor { get; set; }

		///<summary>
		/// Manage Multi-Factor Authentication in API
		/// <para>Name: PermissionsManageTwoFactor</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageTwoFactor")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageTwoFactor { get; set; }

		///<summary>
		/// Use Analytics
		/// <para>Name: PermissionsInsightsAppUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsInsightsAppUser")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsInsightsAppUser { get; set; }

		///<summary>
		/// Manage Analytics
		/// <para>Name: PermissionsInsightsAppAdmin</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsInsightsAppAdmin")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsInsightsAppAdmin { get; set; }

		///<summary>
		/// Edit Analytics Dataflows
		/// <para>Name: PermissionsInsightsAppEltEditor</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsInsightsAppEltEditor")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsInsightsAppEltEditor { get; set; }

		///<summary>
		/// Upload External Data to Analytics
		/// <para>Name: PermissionsInsightsAppUploadUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsInsightsAppUploadUser")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsInsightsAppUploadUser { get; set; }

		///<summary>
		/// Create Analytics Apps
		/// <para>Name: PermissionsInsightsCreateApplication</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsInsightsCreateApplication")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsInsightsCreateApplication { get; set; }

		///<summary>
		/// Lightning Experience User
		/// <para>Name: PermissionsLightningExperienceUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsLightningExperienceUser")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsLightningExperienceUser { get; set; }

		///<summary>
		/// View Real-Time Event Monitoring Data
		/// <para>Name: PermissionsViewDataLeakageEvents</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewDataLeakageEvents")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsViewDataLeakageEvents { get; set; }

		///<summary>
		/// Configure Custom Recommendations
		/// <para>Name: PermissionsConfigCustomRecs</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsConfigCustomRecs")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsConfigCustomRecs { get; set; }

		///<summary>
		/// Manage Macros Users Can&#39;t Undo
		/// <para>Name: PermissionsSubmitMacrosAllowed</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSubmitMacrosAllowed")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsSubmitMacrosAllowed { get; set; }

		///<summary>
		/// Run Macros on Multiple Records
		/// <para>Name: PermissionsBulkMacrosAllowed</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsBulkMacrosAllowed")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsBulkMacrosAllowed { get; set; }

		///<summary>
		/// Share internal Knowledge articles externally
		/// <para>Name: PermissionsShareInternalArticles</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsShareInternalArticles")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsShareInternalArticles { get; set; }

		///<summary>
		/// Manage Session Permission Set Activations
		/// <para>Name: PermissionsManageSessionPermissionSets</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageSessionPermissionSets")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageSessionPermissionSets { get; set; }

		///<summary>
		/// Manage Analytics Templated Apps
		/// <para>Name: PermissionsManageTemplatedApp</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageTemplatedApp")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageTemplatedApp { get; set; }

		///<summary>
		/// Use Analytics Templated Apps
		/// <para>Name: PermissionsUseTemplatedApp</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsUseTemplatedApp")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsUseTemplatedApp { get; set; }

		///<summary>
		/// Send announcement emails
		/// <para>Name: PermissionsSendAnnouncementEmails</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSendAnnouncementEmails")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsSendAnnouncementEmails { get; set; }

		///<summary>
		/// Edit My Own Posts
		/// <para>Name: PermissionsChatterEditOwnPost</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsChatterEditOwnPost")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsChatterEditOwnPost { get; set; }

		///<summary>
		/// Edit Posts on Records I Own
		/// <para>Name: PermissionsChatterEditOwnRecordPost</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsChatterEditOwnRecordPost")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsChatterEditOwnRecordPost { get; set; }

		///<summary>
		/// Download Analytics Data
		/// <para>Name: PermissionsWaveTabularDownload</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsWaveTabularDownload")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsWaveTabularDownload { get; set; }

		///<summary>
		/// Use Einstein Activity Capture
		/// <para>Name: PermissionsAutomaticActivityCapture</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAutomaticActivityCapture")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsAutomaticActivityCapture { get; set; }

		///<summary>
		/// Import Custom Objects
		/// <para>Name: PermissionsImportCustomObjects</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsImportCustomObjects")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsImportCustomObjects { get; set; }

		///<summary>
		/// Manage Multi-Factor Authentication in User Interface
		/// <para>Name: PermissionsDelegatedTwoFactor</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsDelegatedTwoFactor")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsDelegatedTwoFactor { get; set; }

		///<summary>
		/// Allow Inclusion of Code Snippets from UI
		/// <para>Name: PermissionsChatterComposeUiCodesnippet</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsChatterComposeUiCodesnippet")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsChatterComposeUiCodesnippet { get; set; }

		///<summary>
		/// Select Files from Salesforce
		/// <para>Name: PermissionsSelectFilesFromSalesforce</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSelectFilesFromSalesforce")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsSelectFilesFromSalesforce { get; set; }

		///<summary>
		/// Moderate Community Users
		/// <para>Name: PermissionsModerateNetworkUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsModerateNetworkUsers")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsModerateNetworkUsers { get; set; }

		///<summary>
		/// Merge Topics
		/// <para>Name: PermissionsMergeTopics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsMergeTopics")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsMergeTopics { get; set; }

		///<summary>
		/// Subscribe to Reports
		/// <para>Name: PermissionsSubscribeToLightningReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSubscribeToLightningReports")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsSubscribeToLightningReports { get; set; }

		///<summary>
		/// Manage All Private Reports and Dashboards
		/// <para>Name: PermissionsManagePvtRptsAndDashbds</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManagePvtRptsAndDashbds")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManagePvtRptsAndDashbds { get; set; }

		///<summary>
		/// Lightning Login User
		/// <para>Name: PermissionsAllowLightningLogin</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAllowLightningLogin")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsAllowLightningLogin { get; set; }

		///<summary>
		/// Campaign Influence
		/// <para>Name: PermissionsCampaignInfluence2</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCampaignInfluence2")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsCampaignInfluence2 { get; set; }

		///<summary>
		/// Access to view Data Assessment
		/// <para>Name: PermissionsViewDataAssessment</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewDataAssessment")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsViewDataAssessment { get; set; }

		///<summary>
		/// Remove People from Direct Messages
		/// <para>Name: PermissionsRemoveDirectMessageMembers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsRemoveDirectMessageMembers")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsRemoveDirectMessageMembers { get; set; }

		///<summary>
		/// Can Approve Feed Post and Comment
		/// <para>Name: PermissionsCanApproveFeedPost</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCanApproveFeedPost")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsCanApproveFeedPost { get; set; }

		///<summary>
		/// Add People to Direct Messages
		/// <para>Name: PermissionsAddDirectMessageMembers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAddDirectMessageMembers")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsAddDirectMessageMembers { get; set; }

		///<summary>
		/// View and Edit Converted Leads
		/// <para>Name: PermissionsAllowViewEditConvertedLeads</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAllowViewEditConvertedLeads")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsAllowViewEditConvertedLeads { get; set; }

		///<summary>
		/// Show Company Name as Community Role
		/// <para>Name: PermissionsShowCompanyNameAsUserBadge</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsShowCompanyNameAsUserBadge")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsShowCompanyNameAsUserBadge { get; set; }

		///<summary>
		/// Access Community Management
		/// <para>Name: PermissionsAccessCMC</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAccessCMC")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsAccessCMC { get; set; }

		///<summary>
		/// View Health Check
		/// <para>Name: PermissionsViewHealthCheck</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewHealthCheck")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsViewHealthCheck { get; set; }

		///<summary>
		/// Manage Health Check
		/// <para>Name: PermissionsManageHealthCheck</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageHealthCheck")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageHealthCheck { get; set; }

		///<summary>
		/// Create and Update Second-Generation Packages
		/// <para>Name: PermissionsPackaging2</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsPackaging2")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsPackaging2 { get; set; }

		///<summary>
		/// Manage Certificates
		/// <para>Name: PermissionsManageCertificates</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageCertificates")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageCertificates { get; set; }

		///<summary>
		/// Report Builder (Lightning Experience)
		/// <para>Name: PermissionsCreateReportInLightning</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateReportInLightning")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsCreateReportInLightning { get; set; }

		///<summary>
		/// Hide Option to Switch to Salesforce Classic
		/// <para>Name: PermissionsPreventClassicExperience</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsPreventClassicExperience")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsPreventClassicExperience { get; set; }

		///<summary>
		/// Hide the Seen By List
		/// <para>Name: PermissionsHideReadByList</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsHideReadByList")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsHideReadByList { get; set; }

		///<summary>
		/// Allow sending of List Emails
		/// <para>Name: PermissionsListEmailSend</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsListEmailSend")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsListEmailSend { get; set; }

		///<summary>
		/// Pin Posts in Feeds
		/// <para>Name: PermissionsFeedPinning</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsFeedPinning")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsFeedPinning { get; set; }

		///<summary>
		/// Change Dashboard Colors
		/// <para>Name: PermissionsChangeDashboardColors</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsChangeDashboardColors")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsChangeDashboardColors { get; set; }

		///<summary>
		/// IoT User
		/// <para>Name: PermissionsIotUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsIotUser")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsIotUser { get; set; }

		///<summary>
		/// Manage Next Best Action Strategies
		/// <para>Name: PermissionsManageRecommendationStrategies</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageRecommendationStrategies")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageRecommendationStrategies { get; set; }

		///<summary>
		/// Manage Next Best Action Recommendations
		/// <para>Name: PermissionsManagePropositions</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManagePropositions")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManagePropositions { get; set; }

		///<summary>
		/// Close Conversation Threads
		/// <para>Name: PermissionsCloseConversations</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCloseConversations")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsCloseConversations { get; set; }

		///<summary>
		/// Subscribe to Reports: Send to Groups and Roles
		/// <para>Name: PermissionsSubscribeReportRolesGrps</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSubscribeReportRolesGrps")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsSubscribeReportRolesGrps { get; set; }

		///<summary>
		/// Subscribe to Dashboards: Send to Groups and Roles
		/// <para>Name: PermissionsSubscribeDashboardRolesGrps</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSubscribeDashboardRolesGrps")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsSubscribeDashboardRolesGrps { get; set; }

		///<summary>
		/// Allow Access to Customized Actions
		/// <para>Name: PermissionsUseWebLink</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsUseWebLink")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsUseWebLink { get; set; }

		///<summary>
		/// User Has Unlimited Next Best Action Strategy Executions
		/// <para>Name: PermissionsHasUnlimitedNBAExecutions</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsHasUnlimitedNBAExecutions")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsHasUnlimitedNBAExecutions { get; set; }

		///<summary>
		/// Access to View-Only Licensed Templates and Apps
		/// <para>Name: PermissionsViewOnlyEmbeddedAppUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewOnlyEmbeddedAppUser")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsViewOnlyEmbeddedAppUser { get; set; }

		///<summary>
		/// View All Activities
		/// <para>Name: PermissionsViewAllActivities</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewAllActivities")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsViewAllActivities { get; set; }

		///<summary>
		/// Subscribe to Reports: Add Recipients
		/// <para>Name: PermissionsSubscribeReportToOtherUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSubscribeReportToOtherUsers")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsSubscribeReportToOtherUsers { get; set; }

		///<summary>
		/// Lightning Console User
		/// <para>Name: PermissionsLightningConsoleAllowedForUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsLightningConsoleAllowedForUser")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsLightningConsoleAllowedForUser { get; set; }

		///<summary>
		/// Subscribe to Reports: Set Running User
		/// <para>Name: PermissionsSubscribeReportsRunAsUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSubscribeReportsRunAsUser")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsSubscribeReportsRunAsUser { get; set; }

		///<summary>
		/// Subscribe to Dashboards
		/// <para>Name: PermissionsSubscribeToLightningDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSubscribeToLightningDashboards")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsSubscribeToLightningDashboards { get; set; }

		///<summary>
		/// Subscribe to Dashboards: Add Recipients
		/// <para>Name: PermissionsSubscribeDashboardToOtherUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSubscribeDashboardToOtherUsers")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsSubscribeDashboardToOtherUsers { get; set; }

		///<summary>
		/// Manage Public Lightning Email Templates
		/// <para>Name: PermissionsCreateLtngTempInPub</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateLtngTempInPub")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsCreateLtngTempInPub { get; set; }

		///<summary>
		/// Send Non-Commercial Email
		/// <para>Name: PermissionsTransactionalEmailSend</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsTransactionalEmailSend")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsTransactionalEmailSend { get; set; }

		///<summary>
		/// View Private Static Resources
		/// <para>Name: PermissionsViewPrivateStaticResources</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewPrivateStaticResources")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsViewPrivateStaticResources { get; set; }

		///<summary>
		/// Create Folders for Lightning Email Templates
		/// <para>Name: PermissionsCreateLtngTempFolder</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateLtngTempFolder")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsCreateLtngTempFolder { get; set; }

		///<summary>
		/// Apex REST Services
		/// <para>Name: PermissionsApexRestServices</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsApexRestServices")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsApexRestServices { get; set; }

		///<summary>
		/// Show App Launcher in Communities
		/// <para>Name: PermissionsEnableCommunityAppLauncher</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEnableCommunityAppLauncher")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsEnableCommunityAppLauncher { get; set; }

		///<summary>
		/// Give Recognition Badges in Lightning Communities
		/// <para>Name: PermissionsGiveRecognitionBadge</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsGiveRecognitionBadge")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsGiveRecognitionBadge { get; set; }

		///<summary>
		/// Remain in Salesforce Classic
		/// <para>Name: PermissionsLtngPromoReserved01UserPerm</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsLtngPromoReserved01UserPerm")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsLtngPromoReserved01UserPerm { get; set; }

		///<summary>
		/// Manage Analytics Subscriptions
		/// <para>Name: PermissionsManageSubscriptions</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageSubscriptions")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageSubscriptions { get; set; }

		///<summary>
		/// Manage Analytics Private Assets
		/// <para>Name: PermissionsWaveManagePrivateAssetsUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsWaveManagePrivateAssetsUser")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsWaveManagePrivateAssetsUser { get; set; }

		///<summary>
		/// Edit Dataset Recipes
		/// <para>Name: PermissionsCanEditDataPrepRecipe</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCanEditDataPrepRecipe")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsCanEditDataPrepRecipe { get; set; }

		///<summary>
		/// Add Analytics Remote Connections
		/// <para>Name: PermissionsAddAnalyticsRemoteConnections</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAddAnalyticsRemoteConnections")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsAddAnalyticsRemoteConnections { get; set; }

		///<summary>
		/// Manage Surveys
		/// <para>Name: PermissionsManageSurveys</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageSurveys")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageSurveys { get; set; }

		///<summary>
		/// View Roles and Role Hierarchy
		/// <para>Name: PermissionsViewRoles</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewRoles")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsViewRoles { get; set; }

		///<summary>
		/// Manage Analytics Custom Maps
		/// <para>Name: PermissionsCanManageMaps</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCanManageMaps")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsCanManageMaps { get; set; }

		///<summary>
		/// New Salesforce Mobile App - Customizable Navigation (Winter &#39;20 Pilot Only)
		/// <para>Name: PermissionsCustomTabBarOnMobile</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCustomTabBarOnMobile")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsCustomTabBarOnMobile { get; set; }

		///<summary>
		/// Agent Initiated Outbound Messaging
		/// <para>Name: PermissionsLMOutboundMessagingUserPerm</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsLMOutboundMessagingUserPerm")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsLMOutboundMessagingUserPerm { get; set; }

		///<summary>
		/// Modify Data Classification
		/// <para>Name: PermissionsModifyDataClassification</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsModifyDataClassification")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsModifyDataClassification { get; set; }

		///<summary>
		/// Allow user to access privacy data
		/// <para>Name: PermissionsPrivacyDataAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsPrivacyDataAccess")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsPrivacyDataAccess { get; set; }

		///<summary>
		/// Query All Files
		/// <para>Name: PermissionsQueryAllFiles</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsQueryAllFiles")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsQueryAllFiles { get; set; }

		///<summary>
		/// Modify Metadata Through Metadata API Functions
		/// <para>Name: PermissionsModifyMetadata</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsModifyMetadata")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsModifyMetadata { get; set; }

		///<summary>
		/// Create CMS Workspaces and Channels
		/// <para>Name: PermissionsManageCMS</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageCMS")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageCMS { get; set; }

		///<summary>
		/// Enables testing a sandbox community in the Mobile Publisher for Community Cloud app.
		/// <para>Name: PermissionsSandboxTestingInCommunityApp</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSandboxTestingInCommunityApp")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsSandboxTestingInCommunityApp { get; set; }

		///<summary>
		/// View Flow Usage and Flow Event Data
		/// <para>Name: PermissionsViewFlowUsageAndFlowEventData</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewFlowUsageAndFlowEventData")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsViewFlowUsageAndFlowEventData { get; set; }

		///<summary>
		/// Manage Prompts
		/// <para>Name: PermissionsCanEditPrompts</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCanEditPrompts")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsCanEditPrompts { get; set; }

		///<summary>
		/// View User Records with PII
		/// <para>Name: PermissionsViewUserPII</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewUserPII")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsViewUserPII { get; set; }

		///<summary>
		/// Connect Org to Customer 360 Data Manager
		/// <para>Name: PermissionsManageHubConnections</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageHubConnections")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageHubConnections { get; set; }

		///<summary>
		/// Create B2B Marketing Analytics Apps
		/// <para>Name: PermissionsB2BMarketingAnalyticsUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsB2BMarketingAnalyticsUser")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsB2BMarketingAnalyticsUser { get; set; }

		///<summary>
		/// Access Tracer for External Data Sources
		/// <para>Name: PermissionsTraceXdsQueries</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsTraceXdsQueries")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsTraceXdsQueries { get; set; }

		///<summary>
		/// View Security Center pages
		/// <para>Name: PermissionsViewSecurityCommandCenter</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewSecurityCommandCenter")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsViewSecurityCommandCenter { get; set; }

		///<summary>
		/// Manage Security Center
		/// <para>Name: PermissionsManageSecurityCommandCenter</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageSecurityCommandCenter")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageSecurityCommandCenter { get; set; }

		///<summary>
		/// View All Custom Settings
		/// <para>Name: PermissionsViewAllCustomSettings</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewAllCustomSettings")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsViewAllCustomSettings { get; set; }

		///<summary>
		/// View All Lookup Record Names
		/// <para>Name: PermissionsViewAllForeignKeyNames</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewAllForeignKeyNames")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsViewAllForeignKeyNames { get; set; }

		///<summary>
		/// Notification Emails: Add Recipients
		/// <para>Name: PermissionsAddWaveNotificationRecipients</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAddWaveNotificationRecipients")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsAddWaveNotificationRecipients { get; set; }

		///<summary>
		/// Enable Salesforce CMS Integration
		/// <para>Name: PermissionsHeadlessCMSAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsHeadlessCMSAccess")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsHeadlessCMSAccess { get; set; }

		///<summary>
		/// End Messaging Session
		/// <para>Name: PermissionsLMEndMessagingSessionUserPerm</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsLMEndMessagingSessionUserPerm")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsLMEndMessagingSessionUserPerm { get; set; }

		///<summary>
		/// Update Consent Preferences Using REST API
		/// <para>Name: PermissionsConsentApiUpdate</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsConsentApiUpdate")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsConsentApiUpdate { get; set; }

		///<summary>
		/// Access drag-and-drop content builder
		/// <para>Name: PermissionsAccessContentBuilder</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAccessContentBuilder")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsAccessContentBuilder { get; set; }

		///<summary>
		/// Account Switcher User
		/// <para>Name: PermissionsAccountSwitcherUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAccountSwitcherUser")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsAccountSwitcherUser { get; set; }

		///<summary>
		/// Manage your Clearbit Integration
		/// <para>Name: PermissionsManageClearbitIntegration</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageClearbitIntegration")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageClearbitIntegration { get; set; }

		///<summary>
		/// View Threat Detection Events
		/// <para>Name: PermissionsViewAnomalyEvents</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewAnomalyEvents")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsViewAnomalyEvents { get; set; }

		///<summary>
		/// Connect Org to Customer 360 Audiences
		/// <para>Name: PermissionsManageC360AConnections</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageC360AConnections")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageC360AConnections { get; set; }

		///<summary>
		/// Manage your Zapier Integration
		/// <para>Name: PermissionsManageZapierIntegration</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageZapierIntegration")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageZapierIntegration { get; set; }

		///<summary>
		/// Manage Release Updates
		/// <para>Name: PermissionsManageReleaseUpdates</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageReleaseUpdates")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageReleaseUpdates { get; set; }

		///<summary>
		/// View All Profiles
		/// <para>Name: PermissionsViewAllProfiles</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewAllProfiles")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsViewAllProfiles { get; set; }

		///<summary>
		/// Skip Identity Confirmation at Login
		/// <para>Name: PermissionsSkipIdentityConfirmation</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSkipIdentityConfirmation")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsSkipIdentityConfirmation { get; set; }

		///<summary>
		/// Send Custom Notifications
		/// <para>Name: PermissionsSendCustomNotifications</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSendCustomNotifications")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsSendCustomNotifications { get; set; }

		///<summary>
		/// Delete Second-Generation Packages
		/// <para>Name: PermissionsPackaging2Delete</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsPackaging2Delete")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsPackaging2Delete { get; set; }

		///<summary>
		/// User license to access Lightning components and features delivered in Financial Services Cloud.
		/// <para>Name: PermissionsFSCComprehensiveUserAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsFSCComprehensiveUserAccess")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsFSCComprehensiveUserAccess { get; set; }

		///<summary>
		/// Manage Bots
		/// <para>Name: PermissionsBotManageBots</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsBotManageBots")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsBotManageBots { get; set; }

		///<summary>
		/// Manage Bots Training Data
		/// <para>Name: PermissionsBotManageBotsTrainingData</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsBotManageBotsTrainingData")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsBotManageBotsTrainingData { get; set; }

		///<summary>
		/// Salesforce Anywhere Integration Access
		/// <para>Name: PermissionsIsotopeCToCUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsIsotopeCToCUser")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsIsotopeCToCUser { get; set; }

		///<summary>
		/// Salesforce Anywhere on Mobile
		/// <para>Name: PermissionsIsotopeAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsIsotopeAccess")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsIsotopeAccess { get; set; }

		///<summary>
		/// Salesforce Anywhere in Lightning Experience
		/// <para>Name: PermissionsIsotopeLEX</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsIsotopeLEX")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsIsotopeLEX { get; set; }

		///<summary>
		/// Quip Metrics
		/// <para>Name: PermissionsQuipMetricsAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsQuipMetricsAccess")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsQuipMetricsAccess { get; set; }

		///<summary>
		/// Quip User Engagement Metrics
		/// <para>Name: PermissionsQuipUserEngagementMetrics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsQuipUserEngagementMetrics")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsQuipUserEngagementMetrics { get; set; }

		///<summary>
		/// Allow user to modify Private Connections
		/// <para>Name: PermissionsManageExternalConnections</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageExternalConnections")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsManageExternalConnections { get; set; }

		///<summary>
		/// Use Subscription Emails
		/// <para>Name: PermissionsUseSubscriptionEmails</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsUseSubscriptionEmails")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsUseSubscriptionEmails { get; set; }

		///<summary>
		/// Salesforce Mobile App: Native scrolling on webviews
		/// <para>Name: PermissionsNativeWebviewScrolling</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsNativeWebviewScrolling")]
		[Updateable(false), Createable(false)]
		public bool? PermissionsNativeWebviewScrolling { get; set; }

	}
}
