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
	/// Profile
	///<para>SObject Name: Profile</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfProfile : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "Profile"; }
		}

		///<summary>
		/// Profile ID
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
		/// Send Email
		/// <para>Name: PermissionsEmailSingle</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEmailSingle")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsEmailSingle { get; set; }

		///<summary>
		/// Mass Email
		/// <para>Name: PermissionsEmailMass</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEmailMass")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsEmailMass { get; set; }

		///<summary>
		/// Edit Tasks
		/// <para>Name: PermissionsEditTask</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditTask")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsEditTask { get; set; }

		///<summary>
		/// Edit Events
		/// <para>Name: PermissionsEditEvent</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditEvent")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsEditEvent { get; set; }

		///<summary>
		/// Export Reports
		/// <para>Name: PermissionsExportReport</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsExportReport")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsExportReport { get; set; }

		///<summary>
		/// Import Personal Contacts
		/// <para>Name: PermissionsImportPersonal</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsImportPersonal")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsImportPersonal { get; set; }

		///<summary>
		/// Manage Users
		/// <para>Name: PermissionsManageUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageUsers")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageUsers { get; set; }

		///<summary>
		/// Manage Public List Views
		/// <para>Name: PermissionsEditPublicFilters</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditPublicFilters")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsEditPublicFilters { get; set; }

		///<summary>
		/// Manage Public Templates
		/// <para>Name: PermissionsEditPublicTemplates</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditPublicTemplates")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsEditPublicTemplates { get; set; }

		///<summary>
		/// Modify All Data
		/// <para>Name: PermissionsModifyAllData</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsModifyAllData")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsModifyAllData { get; set; }

		///<summary>
		/// Manage Cases
		/// <para>Name: PermissionsManageCases</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageCases")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageCases { get; set; }

		///<summary>
		/// Mass Edits from Lists
		/// <para>Name: PermissionsMassInlineEdit</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsMassInlineEdit")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsMassInlineEdit { get; set; }

		///<summary>
		/// Manage Articles
		/// <para>Name: PermissionsEditKnowledge</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditKnowledge")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsEditKnowledge { get; set; }

		///<summary>
		/// Manage Salesforce Knowledge
		/// <para>Name: PermissionsManageKnowledge</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageKnowledge")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageKnowledge { get; set; }

		///<summary>
		/// Manage Published Solutions
		/// <para>Name: PermissionsManageSolutions</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageSolutions")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageSolutions { get; set; }

		///<summary>
		/// Customize Application
		/// <para>Name: PermissionsCustomizeApplication</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCustomizeApplication")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsCustomizeApplication { get; set; }

		///<summary>
		/// Edit Read Only Fields
		/// <para>Name: PermissionsEditReadonlyFields</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditReadonlyFields")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsEditReadonlyFields { get; set; }

		///<summary>
		/// Run Reports
		/// <para>Name: PermissionsRunReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsRunReports")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsRunReports { get; set; }

		///<summary>
		/// View Setup and Configuration
		/// <para>Name: PermissionsViewSetup</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewSetup")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsViewSetup { get; set; }

		///<summary>
		/// Transfer Record
		/// <para>Name: PermissionsTransferAnyEntity</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsTransferAnyEntity")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsTransferAnyEntity { get; set; }

		///<summary>
		/// Report Builder
		/// <para>Name: PermissionsNewReportBuilder</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsNewReportBuilder")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsNewReportBuilder { get; set; }

		///<summary>
		/// Activate Contracts
		/// <para>Name: PermissionsActivateContract</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsActivateContract")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsActivateContract { get; set; }

		///<summary>
		/// Activate Orders
		/// <para>Name: PermissionsActivateOrder</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsActivateOrder")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsActivateOrder { get; set; }

		///<summary>
		/// Import Leads
		/// <para>Name: PermissionsImportLeads</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsImportLeads")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsImportLeads { get; set; }

		///<summary>
		/// Manage Leads
		/// <para>Name: PermissionsManageLeads</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageLeads")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageLeads { get; set; }

		///<summary>
		/// Transfer Leads
		/// <para>Name: PermissionsTransferAnyLead</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsTransferAnyLead")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsTransferAnyLead { get; set; }

		///<summary>
		/// View All Data
		/// <para>Name: PermissionsViewAllData</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewAllData")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsViewAllData { get; set; }

		///<summary>
		/// Manage Public Documents
		/// <para>Name: PermissionsEditPublicDocuments</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditPublicDocuments")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsEditPublicDocuments { get; set; }

		///<summary>
		/// View Encrypted Data
		/// <para>Name: PermissionsViewEncryptedData</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewEncryptedData")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsViewEncryptedData { get; set; }

		///<summary>
		/// Manage Letterheads
		/// <para>Name: PermissionsEditBrandTemplates</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditBrandTemplates")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsEditBrandTemplates { get; set; }

		///<summary>
		/// Edit HTML Templates
		/// <para>Name: PermissionsEditHtmlTemplates</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditHtmlTemplates")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsEditHtmlTemplates { get; set; }

		///<summary>
		/// Chatter Internal User
		/// <para>Name: PermissionsChatterInternalUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsChatterInternalUser")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsChatterInternalUser { get; set; }

		///<summary>
		/// Manage Encryption Keys
		/// <para>Name: PermissionsManageEncryptionKeys</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageEncryptionKeys")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageEncryptionKeys { get; set; }

		///<summary>
		/// Delete Activated Contracts
		/// <para>Name: PermissionsDeleteActivatedContract</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsDeleteActivatedContract")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsDeleteActivatedContract { get; set; }

		///<summary>
		/// Invite Customers To Chatter
		/// <para>Name: PermissionsChatterInviteExternalUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsChatterInviteExternalUsers")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsChatterInviteExternalUsers { get; set; }

		///<summary>
		/// Send Stay-in-Touch Requests
		/// <para>Name: PermissionsSendSitRequests</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSendSitRequests")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsSendSitRequests { get; set; }

		///<summary>
		/// Manage Connected Apps
		/// <para>Name: PermissionsManageRemoteAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageRemoteAccess")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageRemoteAccess { get; set; }

		///<summary>
		/// Drag-and-Drop Dashboard Builder
		/// <para>Name: PermissionsCanUseNewDashboardBuilder</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCanUseNewDashboardBuilder")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsCanUseNewDashboardBuilder { get; set; }

		///<summary>
		/// Manage Categories
		/// <para>Name: PermissionsManageCategories</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageCategories")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageCategories { get; set; }

		///<summary>
		/// Convert Leads
		/// <para>Name: PermissionsConvertLeads</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsConvertLeads")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsConvertLeads { get; set; }

		///<summary>
		/// Password Never Expires
		/// <para>Name: PermissionsPasswordNeverExpires</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsPasswordNeverExpires")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsPasswordNeverExpires { get; set; }

		///<summary>
		/// Use Team Reassignment Wizards
		/// <para>Name: PermissionsUseTeamReassignWizards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsUseTeamReassignWizards")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsUseTeamReassignWizards { get; set; }

		///<summary>
		/// Edit Activated Orders
		/// <para>Name: PermissionsEditActivatedOrders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditActivatedOrders")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsEditActivatedOrders { get; set; }

		///<summary>
		/// Download AppExchange Packages
		/// <para>Name: PermissionsInstallMultiforce</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsInstallMultiforce")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsInstallMultiforce { get; set; }

		///<summary>
		/// Upload AppExchange Packages
		/// <para>Name: PermissionsPublishMultiforce</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsPublishMultiforce")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsPublishMultiforce { get; set; }

		///<summary>
		/// Create and Own New Chatter Groups
		/// <para>Name: PermissionsChatterOwnGroups</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsChatterOwnGroups")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsChatterOwnGroups { get; set; }

		///<summary>
		/// Edit Opportunity Product Sales Price
		/// <para>Name: PermissionsEditOppLineItemUnitPrice</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditOppLineItemUnitPrice")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsEditOppLineItemUnitPrice { get; set; }

		///<summary>
		/// Create AppExchange Packages
		/// <para>Name: PermissionsCreateMultiforce</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateMultiforce")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsCreateMultiforce { get; set; }

		///<summary>
		/// Bulk API Hard Delete
		/// <para>Name: PermissionsBulkApiHardDelete</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsBulkApiHardDelete")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsBulkApiHardDelete { get; set; }

		///<summary>
		/// Import Solutions
		/// <para>Name: PermissionsSolutionImport</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSolutionImport")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsSolutionImport { get; set; }

		///<summary>
		/// Manage Call Centers
		/// <para>Name: PermissionsManageCallCenters</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageCallCenters")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageCallCenters { get; set; }

		///<summary>
		/// Manage Synonyms
		/// <para>Name: PermissionsManageSynonyms</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageSynonyms")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageSynonyms { get; set; }

		///<summary>
		/// View Content in Portals
		/// <para>Name: PermissionsViewContent</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewContent")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsViewContent { get; set; }

		///<summary>
		/// Manage Email Client Configurations
		/// <para>Name: PermissionsManageEmailClientConfig</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageEmailClientConfig")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageEmailClientConfig { get; set; }

		///<summary>
		/// Send Outbound Messages
		/// <para>Name: PermissionsEnableNotifications</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEnableNotifications")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsEnableNotifications { get; set; }

		///<summary>
		/// Manage Data Integrations
		/// <para>Name: PermissionsManageDataIntegrations</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageDataIntegrations")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageDataIntegrations { get; set; }

		///<summary>
		/// Create Content Deliveries
		/// <para>Name: PermissionsDistributeFromPersWksp</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsDistributeFromPersWksp")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsDistributeFromPersWksp { get; set; }

		///<summary>
		/// View Data Categories
		/// <para>Name: PermissionsViewDataCategories</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewDataCategories")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsViewDataCategories { get; set; }

		///<summary>
		/// Manage Data Categories
		/// <para>Name: PermissionsManageDataCategories</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageDataCategories")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageDataCategories { get; set; }

		///<summary>
		/// Author Apex
		/// <para>Name: PermissionsAuthorApex</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAuthorApex")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsAuthorApex { get; set; }

		///<summary>
		/// Manage Mobile Configurations
		/// <para>Name: PermissionsManageMobile</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageMobile")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageMobile { get; set; }

		///<summary>
		/// API Enabled
		/// <para>Name: PermissionsApiEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsApiEnabled")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsApiEnabled { get; set; }

		///<summary>
		/// Manage Custom Report Types
		/// <para>Name: PermissionsManageCustomReportTypes</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageCustomReportTypes")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageCustomReportTypes { get; set; }

		///<summary>
		/// Edit Case Comments
		/// <para>Name: PermissionsEditCaseComments</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditCaseComments")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsEditCaseComments { get; set; }

		///<summary>
		/// Transfer Cases
		/// <para>Name: PermissionsTransferAnyCase</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsTransferAnyCase")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsTransferAnyCase { get; set; }

		///<summary>
		/// Manage Salesforce CRM Content
		/// <para>Name: PermissionsContentAdministrator</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsContentAdministrator")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsContentAdministrator { get; set; }

		///<summary>
		/// Create Libraries
		/// <para>Name: PermissionsCreateWorkspaces</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateWorkspaces")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsCreateWorkspaces { get; set; }

		///<summary>
		/// Manage Content Permissions
		/// <para>Name: PermissionsManageContentPermissions</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageContentPermissions")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageContentPermissions { get; set; }

		///<summary>
		/// Manage Content Properties
		/// <para>Name: PermissionsManageContentProperties</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageContentProperties")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageContentProperties { get; set; }

		///<summary>
		/// Manage record types and layouts for Files
		/// <para>Name: PermissionsManageContentTypes</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageContentTypes")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageContentTypes { get; set; }

		///<summary>
		/// Manage Lightning Sync
		/// <para>Name: PermissionsManageExchangeConfig</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageExchangeConfig")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageExchangeConfig { get; set; }

		///<summary>
		/// Manage Reporting Snapshots
		/// <para>Name: PermissionsManageAnalyticSnapshots</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageAnalyticSnapshots")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageAnalyticSnapshots { get; set; }

		///<summary>
		/// Schedule Reports
		/// <para>Name: PermissionsScheduleReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsScheduleReports")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsScheduleReports { get; set; }

		///<summary>
		/// Manage Business Hours Holidays
		/// <para>Name: PermissionsManageBusinessHourHolidays</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageBusinessHourHolidays")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageBusinessHourHolidays { get; set; }

		///<summary>
		/// Manage Dynamic Dashboards
		/// <para>Name: PermissionsManageDynamicDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageDynamicDashboards")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageDynamicDashboards { get; set; }

		///<summary>
		/// Show Custom Sidebar On All Pages
		/// <para>Name: PermissionsCustomSidebarOnAllPages</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCustomSidebarOnAllPages")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsCustomSidebarOnAllPages { get; set; }

		///<summary>
		/// Manage Force.com Flow
		/// <para>Name: PermissionsManageInteraction</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageInteraction")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageInteraction { get; set; }

		///<summary>
		/// View My Team&#39;s Dashboards
		/// <para>Name: PermissionsViewMyTeamsDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewMyTeamsDashboards")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsViewMyTeamsDashboards { get; set; }

		///<summary>
		/// Moderate Chatter
		/// <para>Name: PermissionsModerateChatter</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsModerateChatter")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsModerateChatter { get; set; }

		///<summary>
		/// Reset User Passwords and Unlock Users
		/// <para>Name: PermissionsResetPasswords</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsResetPasswords")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsResetPasswords { get; set; }

		///<summary>
		/// Require Force.com Flow User Feature License
		/// <para>Name: PermissionsFlowUFLRequired</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsFlowUFLRequired")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsFlowUFLRequired { get; set; }

		///<summary>
		/// Insert System Field Values for Chatter Feeds
		/// <para>Name: PermissionsCanInsertFeedSystemFields</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCanInsertFeedSystemFields")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsCanInsertFeedSystemFields { get; set; }

		///<summary>
		/// Manage Knowledge Article Import/Export
		/// <para>Name: PermissionsManageKnowledgeImportExport</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageKnowledgeImportExport")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageKnowledgeImportExport { get; set; }

		///<summary>
		/// Manage Email Templates
		/// <para>Name: PermissionsEmailTemplateManagement</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEmailTemplateManagement")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsEmailTemplateManagement { get; set; }

		///<summary>
		/// Email Administration
		/// <para>Name: PermissionsEmailAdministration</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEmailAdministration")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsEmailAdministration { get; set; }

		///<summary>
		/// Manage Chatter Messages and Direct Messages
		/// <para>Name: PermissionsManageChatterMessages</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageChatterMessages")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageChatterMessages { get; set; }

		///<summary>
		/// Email-Based Identity Verification Option
		/// <para>Name: PermissionsAllowEmailIC</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAllowEmailIC")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsAllowEmailIC { get; set; }

		///<summary>
		/// Create Public Links
		/// <para>Name: PermissionsChatterFileLink</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsChatterFileLink")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsChatterFileLink { get; set; }

		///<summary>
		/// Two-Factor Authentication for User Interface Logins
		/// <para>Name: PermissionsForceTwoFactor</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsForceTwoFactor")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsForceTwoFactor { get; set; }

		///<summary>
		/// View Event Log Files
		/// <para>Name: PermissionsViewEventLogFiles</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewEventLogFiles")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsViewEventLogFiles { get; set; }

		///<summary>
		/// Create and Set Up Communities
		/// <para>Name: PermissionsManageNetworks</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageNetworks")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageNetworks { get; set; }

		///<summary>
		/// Manage Auth. Providers
		/// <para>Name: PermissionsManageAuthProviders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageAuthProviders")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageAuthProviders { get; set; }

		///<summary>
		/// Run Flows
		/// <para>Name: PermissionsRunFlow</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsRunFlow")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsRunFlow { get; set; }

		///<summary>
		/// Create and Customize Dashboards
		/// <para>Name: PermissionsCreateCustomizeDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateCustomizeDashboards")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsCreateCustomizeDashboards { get; set; }

		///<summary>
		/// Create Dashboard Folders
		/// <para>Name: PermissionsCreateDashboardFolders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateDashboardFolders")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsCreateDashboardFolders { get; set; }

		///<summary>
		/// View Dashboards in Public Folders
		/// <para>Name: PermissionsViewPublicDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewPublicDashboards")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsViewPublicDashboards { get; set; }

		///<summary>
		/// Manage Dashboards in Public Folders
		/// <para>Name: PermissionsManageDashbdsInPubFolders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageDashbdsInPubFolders")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageDashbdsInPubFolders { get; set; }

		///<summary>
		/// Create and Customize Reports
		/// <para>Name: PermissionsCreateCustomizeReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateCustomizeReports")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsCreateCustomizeReports { get; set; }

		///<summary>
		/// Create Report Folders
		/// <para>Name: PermissionsCreateReportFolders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateReportFolders")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsCreateReportFolders { get; set; }

		///<summary>
		/// View Reports in Public Folders
		/// <para>Name: PermissionsViewPublicReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewPublicReports")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsViewPublicReports { get; set; }

		///<summary>
		/// Manage Reports in Public Folders
		/// <para>Name: PermissionsManageReportsInPubFolders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageReportsInPubFolders")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageReportsInPubFolders { get; set; }

		///<summary>
		/// Edit My Dashboards
		/// <para>Name: PermissionsEditMyDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditMyDashboards")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsEditMyDashboards { get; set; }

		///<summary>
		/// Edit My Reports
		/// <para>Name: PermissionsEditMyReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditMyReports")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsEditMyReports { get; set; }

		///<summary>
		/// View All Users
		/// <para>Name: PermissionsViewAllUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewAllUsers")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsViewAllUsers { get; set; }

		///<summary>
		/// Knowledge One
		/// <para>Name: PermissionsAllowUniversalSearch</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAllowUniversalSearch")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsAllowUniversalSearch { get; set; }

		///<summary>
		/// Connect Organization to Environment Hub
		/// <para>Name: PermissionsConnectOrgToEnvironmentHub</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsConnectOrgToEnvironmentHub")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsConnectOrgToEnvironmentHub { get; set; }

		///<summary>
		/// Enable Work.com Calibration
		/// <para>Name: PermissionsWorkCalibrationUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsWorkCalibrationUser")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsWorkCalibrationUser { get; set; }

		///<summary>
		/// Create and Customize List Views
		/// <para>Name: PermissionsCreateCustomizeFilters</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateCustomizeFilters")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsCreateCustomizeFilters { get; set; }

		///<summary>
		/// Enable Work.com
		/// <para>Name: PermissionsWorkDotComUserPerm</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsWorkDotComUserPerm")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsWorkDotComUserPerm { get; set; }

		///<summary>
		/// Manage Communities
		/// <para>Name: PermissionsGovernNetworks</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsGovernNetworks")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsGovernNetworks { get; set; }

		///<summary>
		/// Sales Console
		/// <para>Name: PermissionsSalesConsole</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSalesConsole")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsSalesConsole { get; set; }

		///<summary>
		/// Two-Factor Authentication for API Logins
		/// <para>Name: PermissionsTwoFactorApi</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsTwoFactorApi")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsTwoFactorApi { get; set; }

		///<summary>
		/// Delete Topics
		/// <para>Name: PermissionsDeleteTopics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsDeleteTopics")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsDeleteTopics { get; set; }

		///<summary>
		/// Edit Topics
		/// <para>Name: PermissionsEditTopics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEditTopics")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsEditTopics { get; set; }

		///<summary>
		/// Create Topics
		/// <para>Name: PermissionsCreateTopics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateTopics")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsCreateTopics { get; set; }

		///<summary>
		/// Assign Topics
		/// <para>Name: PermissionsAssignTopics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAssignTopics")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsAssignTopics { get; set; }

		///<summary>
		/// Use Identity Features
		/// <para>Name: PermissionsIdentityEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsIdentityEnabled")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsIdentityEnabled { get; set; }

		///<summary>
		/// Use Identity Connect
		/// <para>Name: PermissionsIdentityConnect</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsIdentityConnect")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsIdentityConnect { get; set; }

		///<summary>
		/// Allow View Knowledge
		/// <para>Name: PermissionsAllowViewKnowledge</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAllowViewKnowledge")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsAllowViewKnowledge { get; set; }

		///<summary>
		/// Access Libraries
		/// <para>Name: PermissionsContentWorkspaces</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsContentWorkspaces")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsContentWorkspaces { get; set; }

		///<summary>
		/// Manage Promoted Search Terms
		/// <para>Name: PermissionsManageSearchPromotionRules</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageSearchPromotionRules")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageSearchPromotionRules { get; set; }

		///<summary>
		/// Access Custom Mobile Apps
		/// <para>Name: PermissionsCustomMobileAppsAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCustomMobileAppsAccess")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsCustomMobileAppsAccess { get; set; }

		///<summary>
		/// View Help Link
		/// <para>Name: PermissionsViewHelpLink</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewHelpLink")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsViewHelpLink { get; set; }

		///<summary>
		/// Manage Profiles and Permission Sets
		/// <para>Name: PermissionsManageProfilesPermissionsets</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageProfilesPermissionsets")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageProfilesPermissionsets { get; set; }

		///<summary>
		/// Assign Permission Sets
		/// <para>Name: PermissionsAssignPermissionSets</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAssignPermissionSets")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsAssignPermissionSets { get; set; }

		///<summary>
		/// Manage Roles
		/// <para>Name: PermissionsManageRoles</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageRoles")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageRoles { get; set; }

		///<summary>
		/// Manage IP Addresses
		/// <para>Name: PermissionsManageIpAddresses</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageIpAddresses")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageIpAddresses { get; set; }

		///<summary>
		/// Manage Sharing
		/// <para>Name: PermissionsManageSharing</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageSharing")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageSharing { get; set; }

		///<summary>
		/// Manage Internal Users
		/// <para>Name: PermissionsManageInternalUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageInternalUsers")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageInternalUsers { get; set; }

		///<summary>
		/// Manage Password Policies
		/// <para>Name: PermissionsManagePasswordPolicies</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManagePasswordPolicies")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManagePasswordPolicies { get; set; }

		///<summary>
		/// Manage Login Access Policies
		/// <para>Name: PermissionsManageLoginAccessPolicies</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageLoginAccessPolicies")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageLoginAccessPolicies { get; set; }

		///<summary>
		/// Manage Custom Permissions
		/// <para>Name: PermissionsManageCustomPermissions</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageCustomPermissions")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageCustomPermissions { get; set; }

		///<summary>
		/// Verify Answers to Chatter Questions
		/// <para>Name: PermissionsCanVerifyComment</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCanVerifyComment")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsCanVerifyComment { get; set; }

		///<summary>
		/// Manage Unlisted Groups
		/// <para>Name: PermissionsManageUnlistedGroups</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageUnlistedGroups")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageUnlistedGroups { get; set; }

		///<summary>
		/// Modify Secure Agents
		/// <para>Name: PermissionsModifySecureAgents</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsModifySecureAgents")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsModifySecureAgents { get; set; }

		///<summary>
		/// Manage Two-Factor Authentication in API
		/// <para>Name: PermissionsManageTwoFactor</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageTwoFactor")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageTwoFactor { get; set; }

		///<summary>
		/// Access Chatter For SharePoint
		/// <para>Name: PermissionsChatterForSharePoint</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsChatterForSharePoint")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsChatterForSharePoint { get; set; }

		///<summary>
		/// Lightning Experience User
		/// <para>Name: PermissionsLightningExperienceUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsLightningExperienceUser")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsLightningExperienceUser { get; set; }

		///<summary>
		/// Configure Custom Recommendations
		/// <para>Name: PermissionsConfigCustomRecs</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsConfigCustomRecs")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsConfigCustomRecs { get; set; }

		///<summary>
		/// Manage Macros Users Can&#39;t Undo
		/// <para>Name: PermissionsSubmitMacrosAllowed</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSubmitMacrosAllowed")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsSubmitMacrosAllowed { get; set; }

		///<summary>
		/// Run Macros on Multiple Records
		/// <para>Name: PermissionsBulkMacrosAllowed</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsBulkMacrosAllowed")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsBulkMacrosAllowed { get; set; }

		///<summary>
		/// Share internal Knowledge articles externally
		/// <para>Name: PermissionsShareInternalArticles</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsShareInternalArticles")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsShareInternalArticles { get; set; }

		///<summary>
		/// Manage Session Permission Set Activations
		/// <para>Name: PermissionsManageSessionPermissionSets</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageSessionPermissionSets")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageSessionPermissionSets { get; set; }

		///<summary>
		/// Send announcement emails
		/// <para>Name: PermissionsSendAnnouncementEmails</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSendAnnouncementEmails")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsSendAnnouncementEmails { get; set; }

		///<summary>
		/// Edit My Own Posts
		/// <para>Name: PermissionsChatterEditOwnPost</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsChatterEditOwnPost")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsChatterEditOwnPost { get; set; }

		///<summary>
		/// Edit Posts on Records I Own
		/// <para>Name: PermissionsChatterEditOwnRecordPost</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsChatterEditOwnRecordPost")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsChatterEditOwnRecordPost { get; set; }

		///<summary>
		/// Import Custom Objects
		/// <para>Name: PermissionsImportCustomObjects</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsImportCustomObjects")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsImportCustomObjects { get; set; }

		///<summary>
		/// Manage Two-Factor Authentication in User Interface
		/// <para>Name: PermissionsDelegatedTwoFactor</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsDelegatedTwoFactor")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsDelegatedTwoFactor { get; set; }

		///<summary>
		/// Allow Inclusion of Code Snippets from UI
		/// <para>Name: PermissionsChatterComposeUiCodesnippet</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsChatterComposeUiCodesnippet")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsChatterComposeUiCodesnippet { get; set; }

		///<summary>
		/// Select Files from Salesforce
		/// <para>Name: PermissionsSelectFilesFromSalesforce</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSelectFilesFromSalesforce")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsSelectFilesFromSalesforce { get; set; }

		///<summary>
		/// Moderate Community Users
		/// <para>Name: PermissionsModerateNetworkUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsModerateNetworkUsers")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsModerateNetworkUsers { get; set; }

		///<summary>
		/// Merge Topics
		/// <para>Name: PermissionsMergeTopics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsMergeTopics")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsMergeTopics { get; set; }

		///<summary>
		/// Subscribe to Reports
		/// <para>Name: PermissionsSubscribeToLightningReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSubscribeToLightningReports")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsSubscribeToLightningReports { get; set; }

		///<summary>
		/// Manage All Private Reports and Dashboards
		/// <para>Name: PermissionsManagePvtRptsAndDashbds</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManagePvtRptsAndDashbds")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManagePvtRptsAndDashbds { get; set; }

		///<summary>
		/// Lightning Login User
		/// <para>Name: PermissionsAllowLightningLogin</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAllowLightningLogin")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsAllowLightningLogin { get; set; }

		///<summary>
		/// Campaign Influence
		/// <para>Name: PermissionsCampaignInfluence2</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCampaignInfluence2")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsCampaignInfluence2 { get; set; }

		///<summary>
		/// Access to view Data Assessment
		/// <para>Name: PermissionsViewDataAssessment</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewDataAssessment")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsViewDataAssessment { get; set; }

		///<summary>
		/// Remove People from Direct Messages
		/// <para>Name: PermissionsRemoveDirectMessageMembers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsRemoveDirectMessageMembers")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsRemoveDirectMessageMembers { get; set; }

		///<summary>
		/// Can Approve Feed Post and Comment
		/// <para>Name: PermissionsCanApproveFeedPost</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCanApproveFeedPost")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsCanApproveFeedPost { get; set; }

		///<summary>
		/// Add People to Direct Messages
		/// <para>Name: PermissionsAddDirectMessageMembers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAddDirectMessageMembers")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsAddDirectMessageMembers { get; set; }

		///<summary>
		/// View and Edit Converted Leads
		/// <para>Name: PermissionsAllowViewEditConvertedLeads</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAllowViewEditConvertedLeads")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsAllowViewEditConvertedLeads { get; set; }

		///<summary>
		/// Show Company Name as Community Role
		/// <para>Name: PermissionsShowCompanyNameAsUserBadge</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsShowCompanyNameAsUserBadge")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsShowCompanyNameAsUserBadge { get; set; }

		///<summary>
		/// Access Community Management
		/// <para>Name: PermissionsAccessCMC</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAccessCMC")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsAccessCMC { get; set; }

		///<summary>
		/// View Health Check
		/// <para>Name: PermissionsViewHealthCheck</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewHealthCheck")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsViewHealthCheck { get; set; }

		///<summary>
		/// Manage Health Check
		/// <para>Name: PermissionsManageHealthCheck</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageHealthCheck")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageHealthCheck { get; set; }

		///<summary>
		/// Create and Update Second-Generation Packages
		/// <para>Name: PermissionsPackaging2</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsPackaging2")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsPackaging2 { get; set; }

		///<summary>
		/// Manage Certificates
		/// <para>Name: PermissionsManageCertificates</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageCertificates")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsManageCertificates { get; set; }

		///<summary>
		/// Report Builder (Lightning Experience)
		/// <para>Name: PermissionsCreateReportInLightning</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsCreateReportInLightning")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsCreateReportInLightning { get; set; }

		///<summary>
		/// Hide Option to Switch to Salesforce Classic
		/// <para>Name: PermissionsPreventClassicExperience</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsPreventClassicExperience")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsPreventClassicExperience { get; set; }

		///<summary>
		/// Hide the Seen By List
		/// <para>Name: PermissionsHideReadByList</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsHideReadByList")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsHideReadByList { get; set; }

		///<summary>
		/// Allow sending of List Emails
		/// <para>Name: PermissionsListEmailSend</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsListEmailSend")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsListEmailSend { get; set; }

		///<summary>
		/// Pin Posts in Feeds
		/// <para>Name: PermissionsFeedPinning</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsFeedPinning")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsFeedPinning { get; set; }

		///<summary>
		/// IoT User
		/// <para>Name: PermissionsIotUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsIotUser")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsIotUser { get; set; }

		///<summary>
		/// Allow WebLink access via the Tooling API
		/// <para>Name: PermissionsUseWebLink</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsUseWebLink")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsUseWebLink { get; set; }

		///<summary>
		/// View All Activities
		/// <para>Name: PermissionsViewAllActivities</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewAllActivities")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsViewAllActivities { get; set; }

		///<summary>
		/// Subscribe to Reports: Add Recipients
		/// <para>Name: PermissionsSubscribeReportToOtherUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSubscribeReportToOtherUsers")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsSubscribeReportToOtherUsers { get; set; }

		///<summary>
		/// Lightning Console User
		/// <para>Name: PermissionsLightningConsoleAllowedForUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsLightningConsoleAllowedForUser")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsLightningConsoleAllowedForUser { get; set; }

		///<summary>
		/// Subscribe to Reports: Set Running User
		/// <para>Name: PermissionsSubscribeReportsRunAsUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsSubscribeReportsRunAsUser")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsSubscribeReportsRunAsUser { get; set; }

		///<summary>
		/// Show App Launcher in Communities
		/// <para>Name: PermissionsEnableCommunityAppLauncher</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsEnableCommunityAppLauncher")]
		[Updateable(true), Creatable(false)]
		public bool? PermissionsEnableCommunityAppLauncher { get; set; }

		///<summary>
		/// User License ID
		/// <para>Name: UserLicenseId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userLicenseId")]
		[Updateable(false), Creatable(false)]
		public string UserLicenseId { get; set; }

		///<summary>
		/// ReferenceTo: UserLicense
		/// <para>RelationshipName: UserLicense</para>
		///</summary>
		[JsonProperty(PropertyName = "userLicense")]
		[Updateable(false), Creatable(false)]
		public SfUserLicense UserLicense { get; set; }

		///<summary>
		/// User Type
		/// <para>Name: UserType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "userType")]
		[Updateable(false), Creatable(false)]
		public string UserType { get; set; }

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
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		[Updateable(true), Creatable(false)]
		public string Description { get; set; }

		///<summary>
		/// Last Viewed Date
		/// <para>Name: LastViewedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastViewedDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? LastViewedDate { get; set; }

		///<summary>
		/// Last Referenced Date
		/// <para>Name: LastReferencedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastReferencedDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? LastReferencedDate { get; set; }

	}
}
