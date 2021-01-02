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
	/// Permission Set License
	///<para>SObject Name: PermissionSetLicense</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfPermissionSetLicense : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "PermissionSetLicense"; }
		}

		///<summary>
		/// Permission Set License ID
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
		/// Developer Name
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
		/// Permission Set License Label
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
		/// Permission Set License Key
		/// <para>Name: PermissionSetLicenseKey</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionSetLicenseKey")]
		[Updateable(false), Createable(false)]
		public string PermissionSetLicenseKey { get; set; }

		///<summary>
		/// Total Licenses
		/// <para>Name: TotalLicenses</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "totalLicenses")]
		[Updateable(false), Createable(false)]
		public int? TotalLicenses { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		[Updateable(false), Createable(false)]
		public string Status { get; set; }

		///<summary>
		/// Expiration Date
		/// <para>Name: ExpirationDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "expirationDate")]
		[Updateable(false), Createable(false)]
		public DateTime? ExpirationDate { get; set; }

		///<summary>
		/// Send Email
		/// <para>Name: MaximumPermissionsEmailSingle</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEmailSingle")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsEmailSingle { get; set; }

		///<summary>
		/// Mass Email
		/// <para>Name: MaximumPermissionsEmailMass</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEmailMass")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsEmailMass { get; set; }

		///<summary>
		/// Edit Tasks
		/// <para>Name: MaximumPermissionsEditTask</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditTask")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsEditTask { get; set; }

		///<summary>
		/// Edit Events
		/// <para>Name: MaximumPermissionsEditEvent</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditEvent")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsEditEvent { get; set; }

		///<summary>
		/// Export Reports
		/// <para>Name: MaximumPermissionsExportReport</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsExportReport")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsExportReport { get; set; }

		///<summary>
		/// Import Personal Contacts
		/// <para>Name: MaximumPermissionsImportPersonal</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsImportPersonal")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsImportPersonal { get; set; }

		///<summary>
		/// Weekly Data Export
		/// <para>Name: MaximumPermissionsDataExport</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsDataExport")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsDataExport { get; set; }

		///<summary>
		/// Manage Users
		/// <para>Name: MaximumPermissionsManageUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageUsers")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageUsers { get; set; }

		///<summary>
		/// Manage Public List Views
		/// <para>Name: MaximumPermissionsEditPublicFilters</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditPublicFilters")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsEditPublicFilters { get; set; }

		///<summary>
		/// Manage Public Classic Email Templates
		/// <para>Name: MaximumPermissionsEditPublicTemplates</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditPublicTemplates")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsEditPublicTemplates { get; set; }

		///<summary>
		/// Modify All Data
		/// <para>Name: MaximumPermissionsModifyAllData</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsModifyAllData")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsModifyAllData { get; set; }

		///<summary>
		/// Manage Cases
		/// <para>Name: MaximumPermissionsManageCases</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageCases")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageCases { get; set; }

		///<summary>
		/// Mass Edits from Lists
		/// <para>Name: MaximumPermissionsMassInlineEdit</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsMassInlineEdit")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsMassInlineEdit { get; set; }

		///<summary>
		/// Manage Articles
		/// <para>Name: MaximumPermissionsEditKnowledge</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditKnowledge")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsEditKnowledge { get; set; }

		///<summary>
		/// Manage Salesforce Knowledge
		/// <para>Name: MaximumPermissionsManageKnowledge</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageKnowledge")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageKnowledge { get; set; }

		///<summary>
		/// Manage Published Solutions
		/// <para>Name: MaximumPermissionsManageSolutions</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageSolutions")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageSolutions { get; set; }

		///<summary>
		/// Customize Application
		/// <para>Name: MaximumPermissionsCustomizeApplication</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCustomizeApplication")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsCustomizeApplication { get; set; }

		///<summary>
		/// Edit Read Only Fields
		/// <para>Name: MaximumPermissionsEditReadonlyFields</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditReadonlyFields")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsEditReadonlyFields { get; set; }

		///<summary>
		/// Run Reports
		/// <para>Name: MaximumPermissionsRunReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsRunReports")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsRunReports { get; set; }

		///<summary>
		/// View Setup and Configuration
		/// <para>Name: MaximumPermissionsViewSetup</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewSetup")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsViewSetup { get; set; }

		///<summary>
		/// Transfer Record
		/// <para>Name: MaximumPermissionsTransferAnyEntity</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsTransferAnyEntity")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsTransferAnyEntity { get; set; }

		///<summary>
		/// Report Builder
		/// <para>Name: MaximumPermissionsNewReportBuilder</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsNewReportBuilder")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsNewReportBuilder { get; set; }

		///<summary>
		/// Activate Contracts
		/// <para>Name: MaximumPermissionsActivateContract</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsActivateContract")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsActivateContract { get; set; }

		///<summary>
		/// Activate Orders
		/// <para>Name: MaximumPermissionsActivateOrder</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsActivateOrder")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsActivateOrder { get; set; }

		///<summary>
		/// Import Leads
		/// <para>Name: MaximumPermissionsImportLeads</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsImportLeads")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsImportLeads { get; set; }

		///<summary>
		/// Manage Leads
		/// <para>Name: MaximumPermissionsManageLeads</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageLeads")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageLeads { get; set; }

		///<summary>
		/// Transfer Leads
		/// <para>Name: MaximumPermissionsTransferAnyLead</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsTransferAnyLead")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsTransferAnyLead { get; set; }

		///<summary>
		/// View All Data
		/// <para>Name: MaximumPermissionsViewAllData</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewAllData")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsViewAllData { get; set; }

		///<summary>
		/// Manage Public Documents
		/// <para>Name: MaximumPermissionsEditPublicDocuments</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditPublicDocuments")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsEditPublicDocuments { get; set; }

		///<summary>
		/// Files Connect On-premises
		/// <para>Name: MaximumPermissionsContentHubOnPremiseUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsContentHubOnPremiseUser")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsContentHubOnPremiseUser { get; set; }

		///<summary>
		/// View Encrypted Data
		/// <para>Name: MaximumPermissionsViewEncryptedData</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewEncryptedData")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsViewEncryptedData { get; set; }

		///<summary>
		/// Manage Letterheads
		/// <para>Name: MaximumPermissionsEditBrandTemplates</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditBrandTemplates")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsEditBrandTemplates { get; set; }

		///<summary>
		/// Edit HTML Templates
		/// <para>Name: MaximumPermissionsEditHtmlTemplates</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditHtmlTemplates")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsEditHtmlTemplates { get; set; }

		///<summary>
		/// Chatter Internal User
		/// <para>Name: MaximumPermissionsChatterInternalUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsChatterInternalUser")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsChatterInternalUser { get; set; }

		///<summary>
		/// Manage Encryption Keys
		/// <para>Name: MaximumPermissionsManageEncryptionKeys</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageEncryptionKeys")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageEncryptionKeys { get; set; }

		///<summary>
		/// Delete Activated Contracts
		/// <para>Name: MaximumPermissionsDeleteActivatedContract</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsDeleteActivatedContract")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsDeleteActivatedContract { get; set; }

		///<summary>
		/// Invite Customers To Chatter
		/// <para>Name: MaximumPermissionsChatterInviteExternalUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsChatterInviteExternalUsers")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsChatterInviteExternalUsers { get; set; }

		///<summary>
		/// Send Stay-in-Touch Requests
		/// <para>Name: MaximumPermissionsSendSitRequests</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsSendSitRequests")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsSendSitRequests { get; set; }

		///<summary>
		/// Manage Connected Apps
		/// <para>Name: MaximumPermissionsManageRemoteAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageRemoteAccess")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageRemoteAccess { get; set; }

		///<summary>
		/// Drag-and-Drop Dashboard Builder
		/// <para>Name: MaximumPermissionsCanUseNewDashboardBuilder</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCanUseNewDashboardBuilder")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsCanUseNewDashboardBuilder { get; set; }

		///<summary>
		/// Manage Categories
		/// <para>Name: MaximumPermissionsManageCategories</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageCategories")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageCategories { get; set; }

		///<summary>
		/// Convert Leads
		/// <para>Name: MaximumPermissionsConvertLeads</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsConvertLeads")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsConvertLeads { get; set; }

		///<summary>
		/// Password Never Expires
		/// <para>Name: MaximumPermissionsPasswordNeverExpires</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsPasswordNeverExpires")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsPasswordNeverExpires { get; set; }

		///<summary>
		/// Use Team Reassignment Wizards
		/// <para>Name: MaximumPermissionsUseTeamReassignWizards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsUseTeamReassignWizards")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsUseTeamReassignWizards { get; set; }

		///<summary>
		/// Edit Activated Orders
		/// <para>Name: MaximumPermissionsEditActivatedOrders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditActivatedOrders")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsEditActivatedOrders { get; set; }

		///<summary>
		/// Download AppExchange Packages
		/// <para>Name: MaximumPermissionsInstallPackaging</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsInstallPackaging")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsInstallPackaging { get; set; }

		///<summary>
		/// Upload AppExchange Packages
		/// <para>Name: MaximumPermissionsPublishPackaging</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsPublishPackaging")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsPublishPackaging { get; set; }

		///<summary>
		/// Create and Own New Chatter Groups
		/// <para>Name: MaximumPermissionsChatterOwnGroups</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsChatterOwnGroups")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsChatterOwnGroups { get; set; }

		///<summary>
		/// Edit Opportunity Product Sales Price
		/// <para>Name: MaximumPermissionsEditOppLineItemUnitPrice</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditOppLineItemUnitPrice")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsEditOppLineItemUnitPrice { get; set; }

		///<summary>
		/// Create AppExchange Packages
		/// <para>Name: MaximumPermissionsCreatePackaging</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCreatePackaging")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsCreatePackaging { get; set; }

		///<summary>
		/// Bulk API Hard Delete
		/// <para>Name: MaximumPermissionsBulkApiHardDelete</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsBulkApiHardDelete")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsBulkApiHardDelete { get; set; }

		///<summary>
		/// Import Solutions
		/// <para>Name: MaximumPermissionsSolutionImport</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsSolutionImport")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsSolutionImport { get; set; }

		///<summary>
		/// Manage Call Centers
		/// <para>Name: MaximumPermissionsManageCallCenters</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageCallCenters")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageCallCenters { get; set; }

		///<summary>
		/// Manage Synonyms
		/// <para>Name: MaximumPermissionsManageSynonyms</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageSynonyms")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageSynonyms { get; set; }

		///<summary>
		/// View Content in Portals
		/// <para>Name: MaximumPermissionsViewContent</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewContent")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsViewContent { get; set; }

		///<summary>
		/// Manage Email Client Configurations
		/// <para>Name: MaximumPermissionsManageEmailClientConfig</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageEmailClientConfig")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageEmailClientConfig { get; set; }

		///<summary>
		/// Send Outbound Messages
		/// <para>Name: MaximumPermissionsEnableNotifications</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEnableNotifications")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsEnableNotifications { get; set; }

		///<summary>
		/// Manage Data Integrations
		/// <para>Name: MaximumPermissionsManageDataIntegrations</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageDataIntegrations")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageDataIntegrations { get; set; }

		///<summary>
		/// Create Content Deliveries
		/// <para>Name: MaximumPermissionsDistributeFromPersWksp</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsDistributeFromPersWksp")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsDistributeFromPersWksp { get; set; }

		///<summary>
		/// View Data Categories in Setup
		/// <para>Name: MaximumPermissionsViewDataCategories</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewDataCategories")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsViewDataCategories { get; set; }

		///<summary>
		/// Manage Data Categories
		/// <para>Name: MaximumPermissionsManageDataCategories</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageDataCategories")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageDataCategories { get; set; }

		///<summary>
		/// Author Apex
		/// <para>Name: MaximumPermissionsAuthorApex</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsAuthorApex")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsAuthorApex { get; set; }

		///<summary>
		/// Manage Mobile Configurations
		/// <para>Name: MaximumPermissionsManageMobile</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageMobile")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageMobile { get; set; }

		///<summary>
		/// API Enabled
		/// <para>Name: MaximumPermissionsApiEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsApiEnabled")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsApiEnabled { get; set; }

		///<summary>
		/// Manage Custom Report Types
		/// <para>Name: MaximumPermissionsManageCustomReportTypes</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageCustomReportTypes")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageCustomReportTypes { get; set; }

		///<summary>
		/// Edit Case Comments
		/// <para>Name: MaximumPermissionsEditCaseComments</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditCaseComments")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsEditCaseComments { get; set; }

		///<summary>
		/// Transfer Cases
		/// <para>Name: MaximumPermissionsTransferAnyCase</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsTransferAnyCase")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsTransferAnyCase { get; set; }

		///<summary>
		/// Manage Salesforce CRM Content
		/// <para>Name: MaximumPermissionsContentAdministrator</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsContentAdministrator")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsContentAdministrator { get; set; }

		///<summary>
		/// Create Libraries
		/// <para>Name: MaximumPermissionsCreateWorkspaces</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCreateWorkspaces")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsCreateWorkspaces { get; set; }

		///<summary>
		/// Manage Content Permissions
		/// <para>Name: MaximumPermissionsManageContentPermissions</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageContentPermissions")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageContentPermissions { get; set; }

		///<summary>
		/// Manage Content Properties
		/// <para>Name: MaximumPermissionsManageContentProperties</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageContentProperties")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageContentProperties { get; set; }

		///<summary>
		/// Manage record types and layouts for Files
		/// <para>Name: MaximumPermissionsManageContentTypes</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageContentTypes")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageContentTypes { get; set; }

		///<summary>
		/// Manage Lightning Sync
		/// <para>Name: MaximumPermissionsManageExchangeConfig</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageExchangeConfig")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageExchangeConfig { get; set; }

		///<summary>
		/// Manage Reporting Snapshots
		/// <para>Name: MaximumPermissionsManageAnalyticSnapshots</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageAnalyticSnapshots")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageAnalyticSnapshots { get; set; }

		///<summary>
		/// Schedule Reports
		/// <para>Name: MaximumPermissionsScheduleReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsScheduleReports")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsScheduleReports { get; set; }

		///<summary>
		/// Manage Business Hours Holidays
		/// <para>Name: MaximumPermissionsManageBusinessHourHolidays</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageBusinessHourHolidays")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageBusinessHourHolidays { get; set; }

		///<summary>
		/// Manage Dynamic Dashboards
		/// <para>Name: MaximumPermissionsManageDynamicDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageDynamicDashboards")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageDynamicDashboards { get; set; }

		///<summary>
		/// Show Custom Sidebar On All Pages
		/// <para>Name: MaximumPermissionsCustomSidebarOnAllPages</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCustomSidebarOnAllPages")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsCustomSidebarOnAllPages { get; set; }

		///<summary>
		/// Manage Flow
		/// <para>Name: MaximumPermissionsManageInteraction</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageInteraction")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageInteraction { get; set; }

		///<summary>
		/// View My Team&#39;s Dashboards
		/// <para>Name: MaximumPermissionsViewMyTeamsDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewMyTeamsDashboards")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsViewMyTeamsDashboards { get; set; }

		///<summary>
		/// Moderate Chatter
		/// <para>Name: MaximumPermissionsModerateChatter</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsModerateChatter")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsModerateChatter { get; set; }

		///<summary>
		/// Reset User Passwords and Unlock Users
		/// <para>Name: MaximumPermissionsResetPasswords</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsResetPasswords")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsResetPasswords { get; set; }

		///<summary>
		/// Require Flow User Feature License
		/// <para>Name: MaximumPermissionsFlowUFLRequired</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsFlowUFLRequired")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsFlowUFLRequired { get; set; }

		///<summary>
		/// Insert System Field Values for Chatter Feeds
		/// <para>Name: MaximumPermissionsCanInsertFeedSystemFields</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCanInsertFeedSystemFields")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsCanInsertFeedSystemFields { get; set; }

		///<summary>
		/// Access Activities
		/// <para>Name: MaximumPermissionsActivitiesAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsActivitiesAccess")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsActivitiesAccess { get; set; }

		///<summary>
		/// Manage Knowledge Article Import/Export
		/// <para>Name: MaximumPermissionsManageKnowledgeImportExport</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageKnowledgeImportExport")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageKnowledgeImportExport { get; set; }

		///<summary>
		/// Manage Email Templates
		/// <para>Name: MaximumPermissionsEmailTemplateManagement</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEmailTemplateManagement")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsEmailTemplateManagement { get; set; }

		///<summary>
		/// Email Administration
		/// <para>Name: MaximumPermissionsEmailAdministration</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEmailAdministration")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsEmailAdministration { get; set; }

		///<summary>
		/// Manage Chatter Messages and Direct Messages
		/// <para>Name: MaximumPermissionsManageChatterMessages</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageChatterMessages")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageChatterMessages { get; set; }

		///<summary>
		/// Email-Based Identity Verification Option
		/// <para>Name: MaximumPermissionsAllowEmailIC</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsAllowEmailIC")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsAllowEmailIC { get; set; }

		///<summary>
		/// Create Public Links
		/// <para>Name: MaximumPermissionsChatterFileLink</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsChatterFileLink")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsChatterFileLink { get; set; }

		///<summary>
		/// Multi-Factor Authentication for User Interface Logins
		/// <para>Name: MaximumPermissionsForceTwoFactor</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsForceTwoFactor")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsForceTwoFactor { get; set; }

		///<summary>
		/// View Event Log Files
		/// <para>Name: MaximumPermissionsViewEventLogFiles</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewEventLogFiles")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsViewEventLogFiles { get; set; }

		///<summary>
		/// Create and Set Up Communities
		/// <para>Name: MaximumPermissionsManageNetworks</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageNetworks")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageNetworks { get; set; }

		///<summary>
		/// Manage Auth. Providers
		/// <para>Name: MaximumPermissionsManageAuthProviders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageAuthProviders")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageAuthProviders { get; set; }

		///<summary>
		/// Run Flows
		/// <para>Name: MaximumPermissionsRunFlow</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsRunFlow")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsRunFlow { get; set; }

		///<summary>
		/// Create and Customize Dashboards
		/// <para>Name: MaximumPermissionsCreateCustomizeDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCreateCustomizeDashboards")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsCreateCustomizeDashboards { get; set; }

		///<summary>
		/// Create Dashboard Folders
		/// <para>Name: MaximumPermissionsCreateDashboardFolders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCreateDashboardFolders")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsCreateDashboardFolders { get; set; }

		///<summary>
		/// View Dashboards in Public Folders
		/// <para>Name: MaximumPermissionsViewPublicDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewPublicDashboards")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsViewPublicDashboards { get; set; }

		///<summary>
		/// Manage Dashboards in Public Folders
		/// <para>Name: MaximumPermissionsManageDashbdsInPubFolders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageDashbdsInPubFolders")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageDashbdsInPubFolders { get; set; }

		///<summary>
		/// Create and Customize Reports
		/// <para>Name: MaximumPermissionsCreateCustomizeReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCreateCustomizeReports")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsCreateCustomizeReports { get; set; }

		///<summary>
		/// Create Report Folders
		/// <para>Name: MaximumPermissionsCreateReportFolders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCreateReportFolders")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsCreateReportFolders { get; set; }

		///<summary>
		/// View Reports in Public Folders
		/// <para>Name: MaximumPermissionsViewPublicReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewPublicReports")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsViewPublicReports { get; set; }

		///<summary>
		/// Manage Reports in Public Folders
		/// <para>Name: MaximumPermissionsManageReportsInPubFolders</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageReportsInPubFolders")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageReportsInPubFolders { get; set; }

		///<summary>
		/// Edit My Dashboards
		/// <para>Name: MaximumPermissionsEditMyDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditMyDashboards")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsEditMyDashboards { get; set; }

		///<summary>
		/// Edit My Reports
		/// <para>Name: MaximumPermissionsEditMyReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditMyReports")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsEditMyReports { get; set; }

		///<summary>
		/// View All Users
		/// <para>Name: MaximumPermissionsViewAllUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewAllUsers")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsViewAllUsers { get; set; }

		///<summary>
		/// Knowledge One
		/// <para>Name: MaximumPermissionsAllowUniversalSearch</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsAllowUniversalSearch")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsAllowUniversalSearch { get; set; }

		///<summary>
		/// Connect Organization to Environment Hub
		/// <para>Name: MaximumPermissionsConnectOrgToEnvironmentHub</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsConnectOrgToEnvironmentHub")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsConnectOrgToEnvironmentHub { get; set; }

		///<summary>
		/// Enable WDC Calibration
		/// <para>Name: MaximumPermissionsWorkCalibrationUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsWorkCalibrationUser")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsWorkCalibrationUser { get; set; }

		///<summary>
		/// Create and Customize List Views
		/// <para>Name: MaximumPermissionsCreateCustomizeFilters</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCreateCustomizeFilters")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsCreateCustomizeFilters { get; set; }

		///<summary>
		/// Enable WDC
		/// <para>Name: MaximumPermissionsWorkDotComUserPerm</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsWorkDotComUserPerm")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsWorkDotComUserPerm { get; set; }

		///<summary>
		/// Files Connect Cloud
		/// <para>Name: MaximumPermissionsContentHubUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsContentHubUser")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsContentHubUser { get; set; }

		///<summary>
		/// Manage Communities
		/// <para>Name: MaximumPermissionsGovernNetworks</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsGovernNetworks")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsGovernNetworks { get; set; }

		///<summary>
		/// Sales Console
		/// <para>Name: MaximumPermissionsSalesConsole</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsSalesConsole")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsSalesConsole { get; set; }

		///<summary>
		/// Multi-Factor Authentication for API Logins
		/// <para>Name: MaximumPermissionsTwoFactorApi</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsTwoFactorApi")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsTwoFactorApi { get; set; }

		///<summary>
		/// Delete Topics
		/// <para>Name: MaximumPermissionsDeleteTopics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsDeleteTopics")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsDeleteTopics { get; set; }

		///<summary>
		/// Edit Topics
		/// <para>Name: MaximumPermissionsEditTopics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEditTopics")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsEditTopics { get; set; }

		///<summary>
		/// Create Topics
		/// <para>Name: MaximumPermissionsCreateTopics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCreateTopics")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsCreateTopics { get; set; }

		///<summary>
		/// Assign Topics
		/// <para>Name: MaximumPermissionsAssignTopics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsAssignTopics")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsAssignTopics { get; set; }

		///<summary>
		/// Use Identity Features
		/// <para>Name: MaximumPermissionsIdentityEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsIdentityEnabled")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsIdentityEnabled { get; set; }

		///<summary>
		/// Use Identity Connect
		/// <para>Name: MaximumPermissionsIdentityConnect</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsIdentityConnect")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsIdentityConnect { get; set; }

		///<summary>
		/// Allow View Knowledge
		/// <para>Name: MaximumPermissionsAllowViewKnowledge</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsAllowViewKnowledge")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsAllowViewKnowledge { get; set; }

		///<summary>
		/// Access Libraries
		/// <para>Name: MaximumPermissionsContentWorkspaces</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsContentWorkspaces")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsContentWorkspaces { get; set; }

		///<summary>
		/// Manage Promoted Search Terms
		/// <para>Name: MaximumPermissionsManageSearchPromotionRules</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageSearchPromotionRules")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageSearchPromotionRules { get; set; }

		///<summary>
		/// Access Custom Mobile Apps
		/// <para>Name: MaximumPermissionsCustomMobileAppsAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCustomMobileAppsAccess")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsCustomMobileAppsAccess { get; set; }

		///<summary>
		/// View Help Link
		/// <para>Name: MaximumPermissionsViewHelpLink</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewHelpLink")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsViewHelpLink { get; set; }

		///<summary>
		/// Manage Profiles and Permission Sets
		/// <para>Name: MaximumPermissionsManageProfilesPermissionsets</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageProfilesPermissionsets")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageProfilesPermissionsets { get; set; }

		///<summary>
		/// Assign Permission Sets
		/// <para>Name: MaximumPermissionsAssignPermissionSets</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsAssignPermissionSets")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsAssignPermissionSets { get; set; }

		///<summary>
		/// Manage Roles
		/// <para>Name: MaximumPermissionsManageRoles</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageRoles")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageRoles { get; set; }

		///<summary>
		/// Manage IP Addresses
		/// <para>Name: MaximumPermissionsManageIpAddresses</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageIpAddresses")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageIpAddresses { get; set; }

		///<summary>
		/// Manage Sharing
		/// <para>Name: MaximumPermissionsManageSharing</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageSharing")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageSharing { get; set; }

		///<summary>
		/// Manage Internal Users
		/// <para>Name: MaximumPermissionsManageInternalUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageInternalUsers")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageInternalUsers { get; set; }

		///<summary>
		/// Manage Password Policies
		/// <para>Name: MaximumPermissionsManagePasswordPolicies</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManagePasswordPolicies")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManagePasswordPolicies { get; set; }

		///<summary>
		/// Manage Login Access Policies
		/// <para>Name: MaximumPermissionsManageLoginAccessPolicies</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageLoginAccessPolicies")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageLoginAccessPolicies { get; set; }

		///<summary>
		/// View Login Forensics Events
		/// <para>Name: MaximumPermissionsViewPlatformEvents</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewPlatformEvents")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsViewPlatformEvents { get; set; }

		///<summary>
		/// Manage Custom Permissions
		/// <para>Name: MaximumPermissionsManageCustomPermissions</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageCustomPermissions")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageCustomPermissions { get; set; }

		///<summary>
		/// Verify Answers to Chatter Questions
		/// <para>Name: MaximumPermissionsCanVerifyComment</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCanVerifyComment")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsCanVerifyComment { get; set; }

		///<summary>
		/// Manage Unlisted Groups
		/// <para>Name: MaximumPermissionsManageUnlistedGroups</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageUnlistedGroups")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageUnlistedGroups { get; set; }

		///<summary>
		/// Use Einstein Activity Capture Standard
		/// <para>Name: MaximumPermissionsStdAutomaticActivityCapture</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsStdAutomaticActivityCapture")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsStdAutomaticActivityCapture { get; set; }

		///<summary>
		/// Modify Secure Agents
		/// <para>Name: MaximumPermissionsModifySecureAgents</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsModifySecureAgents")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsModifySecureAgents { get; set; }

		///<summary>
		/// Create and Edit Analytics Dashboards
		/// <para>Name: MaximumPermissionsInsightsAppDashboardEditor</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsInsightsAppDashboardEditor")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsInsightsAppDashboardEditor { get; set; }

		///<summary>
		/// Manage Multi-Factor Authentication in API
		/// <para>Name: MaximumPermissionsManageTwoFactor</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageTwoFactor")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageTwoFactor { get; set; }

		///<summary>
		/// Use Analytics
		/// <para>Name: MaximumPermissionsInsightsAppUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsInsightsAppUser")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsInsightsAppUser { get; set; }

		///<summary>
		/// Manage Analytics
		/// <para>Name: MaximumPermissionsInsightsAppAdmin</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsInsightsAppAdmin")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsInsightsAppAdmin { get; set; }

		///<summary>
		/// Edit Analytics Dataflows
		/// <para>Name: MaximumPermissionsInsightsAppEltEditor</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsInsightsAppEltEditor")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsInsightsAppEltEditor { get; set; }

		///<summary>
		/// Upload External Data to Analytics
		/// <para>Name: MaximumPermissionsInsightsAppUploadUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsInsightsAppUploadUser")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsInsightsAppUploadUser { get; set; }

		///<summary>
		/// Create Analytics Apps
		/// <para>Name: MaximumPermissionsInsightsCreateApplication</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsInsightsCreateApplication")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsInsightsCreateApplication { get; set; }

		///<summary>
		/// Lightning Experience User
		/// <para>Name: MaximumPermissionsLightningExperienceUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsLightningExperienceUser")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsLightningExperienceUser { get; set; }

		///<summary>
		/// View Real-Time Event Monitoring Data
		/// <para>Name: MaximumPermissionsViewDataLeakageEvents</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewDataLeakageEvents")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsViewDataLeakageEvents { get; set; }

		///<summary>
		/// Configure Custom Recommendations
		/// <para>Name: MaximumPermissionsConfigCustomRecs</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsConfigCustomRecs")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsConfigCustomRecs { get; set; }

		///<summary>
		/// Manage Macros Users Can&#39;t Undo
		/// <para>Name: MaximumPermissionsSubmitMacrosAllowed</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsSubmitMacrosAllowed")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsSubmitMacrosAllowed { get; set; }

		///<summary>
		/// Run Macros on Multiple Records
		/// <para>Name: MaximumPermissionsBulkMacrosAllowed</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsBulkMacrosAllowed")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsBulkMacrosAllowed { get; set; }

		///<summary>
		/// Share internal Knowledge articles externally
		/// <para>Name: MaximumPermissionsShareInternalArticles</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsShareInternalArticles")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsShareInternalArticles { get; set; }

		///<summary>
		/// Manage Session Permission Set Activations
		/// <para>Name: MaximumPermissionsManageSessionPermissionSets</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageSessionPermissionSets")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageSessionPermissionSets { get; set; }

		///<summary>
		/// Manage Analytics Templated Apps
		/// <para>Name: MaximumPermissionsManageTemplatedApp</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageTemplatedApp")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageTemplatedApp { get; set; }

		///<summary>
		/// Use Analytics Templated Apps
		/// <para>Name: MaximumPermissionsUseTemplatedApp</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsUseTemplatedApp")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsUseTemplatedApp { get; set; }

		///<summary>
		/// Send announcement emails
		/// <para>Name: MaximumPermissionsSendAnnouncementEmails</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsSendAnnouncementEmails")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsSendAnnouncementEmails { get; set; }

		///<summary>
		/// Edit My Own Posts
		/// <para>Name: MaximumPermissionsChatterEditOwnPost</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsChatterEditOwnPost")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsChatterEditOwnPost { get; set; }

		///<summary>
		/// Edit Posts on Records I Own
		/// <para>Name: MaximumPermissionsChatterEditOwnRecordPost</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsChatterEditOwnRecordPost")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsChatterEditOwnRecordPost { get; set; }

		///<summary>
		/// Download Analytics Data
		/// <para>Name: MaximumPermissionsWaveTabularDownload</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsWaveTabularDownload")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsWaveTabularDownload { get; set; }

		///<summary>
		/// Use Einstein Activity Capture
		/// <para>Name: MaximumPermissionsAutomaticActivityCapture</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsAutomaticActivityCapture")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsAutomaticActivityCapture { get; set; }

		///<summary>
		/// Import Custom Objects
		/// <para>Name: MaximumPermissionsImportCustomObjects</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsImportCustomObjects")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsImportCustomObjects { get; set; }

		///<summary>
		/// Manage Multi-Factor Authentication in User Interface
		/// <para>Name: MaximumPermissionsDelegatedTwoFactor</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsDelegatedTwoFactor")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsDelegatedTwoFactor { get; set; }

		///<summary>
		/// Allow Inclusion of Code Snippets from UI
		/// <para>Name: MaximumPermissionsChatterComposeUiCodesnippet</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsChatterComposeUiCodesnippet")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsChatterComposeUiCodesnippet { get; set; }

		///<summary>
		/// Select Files from Salesforce
		/// <para>Name: MaximumPermissionsSelectFilesFromSalesforce</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsSelectFilesFromSalesforce")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsSelectFilesFromSalesforce { get; set; }

		///<summary>
		/// Moderate Community Users
		/// <para>Name: MaximumPermissionsModerateNetworkUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsModerateNetworkUsers")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsModerateNetworkUsers { get; set; }

		///<summary>
		/// Merge Topics
		/// <para>Name: MaximumPermissionsMergeTopics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsMergeTopics")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsMergeTopics { get; set; }

		///<summary>
		/// Subscribe to Reports
		/// <para>Name: MaximumPermissionsSubscribeToLightningReports</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsSubscribeToLightningReports")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsSubscribeToLightningReports { get; set; }

		///<summary>
		/// Manage All Private Reports and Dashboards
		/// <para>Name: MaximumPermissionsManagePvtRptsAndDashbds</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManagePvtRptsAndDashbds")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManagePvtRptsAndDashbds { get; set; }

		///<summary>
		/// Lightning Login User
		/// <para>Name: MaximumPermissionsAllowLightningLogin</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsAllowLightningLogin")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsAllowLightningLogin { get; set; }

		///<summary>
		/// Campaign Influence
		/// <para>Name: MaximumPermissionsCampaignInfluence2</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCampaignInfluence2")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsCampaignInfluence2 { get; set; }

		///<summary>
		/// Access to view Data Assessment
		/// <para>Name: MaximumPermissionsViewDataAssessment</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewDataAssessment")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsViewDataAssessment { get; set; }

		///<summary>
		/// Remove People from Direct Messages
		/// <para>Name: MaximumPermissionsRemoveDirectMessageMembers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsRemoveDirectMessageMembers")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsRemoveDirectMessageMembers { get; set; }

		///<summary>
		/// Can Approve Feed Post and Comment
		/// <para>Name: MaximumPermissionsCanApproveFeedPost</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCanApproveFeedPost")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsCanApproveFeedPost { get; set; }

		///<summary>
		/// Add People to Direct Messages
		/// <para>Name: MaximumPermissionsAddDirectMessageMembers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsAddDirectMessageMembers")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsAddDirectMessageMembers { get; set; }

		///<summary>
		/// View and Edit Converted Leads
		/// <para>Name: MaximumPermissionsAllowViewEditConvertedLeads</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsAllowViewEditConvertedLeads")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsAllowViewEditConvertedLeads { get; set; }

		///<summary>
		/// Show Company Name as Community Role
		/// <para>Name: MaximumPermissionsShowCompanyNameAsUserBadge</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsShowCompanyNameAsUserBadge")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsShowCompanyNameAsUserBadge { get; set; }

		///<summary>
		/// Access Community Management
		/// <para>Name: MaximumPermissionsAccessCMC</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsAccessCMC")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsAccessCMC { get; set; }

		///<summary>
		/// View Health Check
		/// <para>Name: MaximumPermissionsViewHealthCheck</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewHealthCheck")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsViewHealthCheck { get; set; }

		///<summary>
		/// Manage Health Check
		/// <para>Name: MaximumPermissionsManageHealthCheck</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageHealthCheck")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageHealthCheck { get; set; }

		///<summary>
		/// Create and Update Second-Generation Packages
		/// <para>Name: MaximumPermissionsPackaging2</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsPackaging2")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsPackaging2 { get; set; }

		///<summary>
		/// Manage Certificates
		/// <para>Name: MaximumPermissionsManageCertificates</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageCertificates")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageCertificates { get; set; }

		///<summary>
		/// Report Builder (Lightning Experience)
		/// <para>Name: MaximumPermissionsCreateReportInLightning</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCreateReportInLightning")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsCreateReportInLightning { get; set; }

		///<summary>
		/// Hide Option to Switch to Salesforce Classic
		/// <para>Name: MaximumPermissionsPreventClassicExperience</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsPreventClassicExperience")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsPreventClassicExperience { get; set; }

		///<summary>
		/// Hide the Seen By List
		/// <para>Name: MaximumPermissionsHideReadByList</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsHideReadByList")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsHideReadByList { get; set; }

		///<summary>
		/// Allow sending of List Emails
		/// <para>Name: MaximumPermissionsListEmailSend</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsListEmailSend")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsListEmailSend { get; set; }

		///<summary>
		/// Pin Posts in Feeds
		/// <para>Name: MaximumPermissionsFeedPinning</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsFeedPinning")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsFeedPinning { get; set; }

		///<summary>
		/// Change Dashboard Colors
		/// <para>Name: MaximumPermissionsChangeDashboardColors</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsChangeDashboardColors")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsChangeDashboardColors { get; set; }

		///<summary>
		/// IoT User
		/// <para>Name: MaximumPermissionsIotUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsIotUser")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsIotUser { get; set; }

		///<summary>
		/// Manage Next Best Action Strategies
		/// <para>Name: MaximumPermissionsManageRecommendationStrategies</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageRecommendationStrategies")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageRecommendationStrategies { get; set; }

		///<summary>
		/// Manage Next Best Action Recommendations
		/// <para>Name: MaximumPermissionsManagePropositions</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManagePropositions")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManagePropositions { get; set; }

		///<summary>
		/// Close Conversation Threads
		/// <para>Name: MaximumPermissionsCloseConversations</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCloseConversations")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsCloseConversations { get; set; }

		///<summary>
		/// Subscribe to Reports: Send to Groups and Roles
		/// <para>Name: MaximumPermissionsSubscribeReportRolesGrps</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsSubscribeReportRolesGrps")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsSubscribeReportRolesGrps { get; set; }

		///<summary>
		/// Subscribe to Dashboards: Send to Groups and Roles
		/// <para>Name: MaximumPermissionsSubscribeDashboardRolesGrps</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsSubscribeDashboardRolesGrps")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsSubscribeDashboardRolesGrps { get; set; }

		///<summary>
		/// Allow Access to Customized Actions
		/// <para>Name: MaximumPermissionsUseWebLink</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsUseWebLink")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsUseWebLink { get; set; }

		///<summary>
		/// User Has Unlimited Next Best Action Strategy Executions
		/// <para>Name: MaximumPermissionsHasUnlimitedNBAExecutions</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsHasUnlimitedNBAExecutions")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsHasUnlimitedNBAExecutions { get; set; }

		///<summary>
		/// Access to View-Only Licensed Templates and Apps
		/// <para>Name: MaximumPermissionsViewOnlyEmbeddedAppUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewOnlyEmbeddedAppUser")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsViewOnlyEmbeddedAppUser { get; set; }

		///<summary>
		/// View All Activities
		/// <para>Name: MaximumPermissionsViewAllActivities</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewAllActivities")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsViewAllActivities { get; set; }

		///<summary>
		/// Subscribe to Reports: Add Recipients
		/// <para>Name: MaximumPermissionsSubscribeReportToOtherUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsSubscribeReportToOtherUsers")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsSubscribeReportToOtherUsers { get; set; }

		///<summary>
		/// Lightning Console User
		/// <para>Name: MaximumPermissionsLightningConsoleAllowedForUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsLightningConsoleAllowedForUser")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsLightningConsoleAllowedForUser { get; set; }

		///<summary>
		/// Subscribe to Reports: Set Running User
		/// <para>Name: MaximumPermissionsSubscribeReportsRunAsUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsSubscribeReportsRunAsUser")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsSubscribeReportsRunAsUser { get; set; }

		///<summary>
		/// Subscribe to Dashboards
		/// <para>Name: MaximumPermissionsSubscribeToLightningDashboards</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsSubscribeToLightningDashboards")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsSubscribeToLightningDashboards { get; set; }

		///<summary>
		/// Subscribe to Dashboards: Add Recipients
		/// <para>Name: MaximumPermissionsSubscribeDashboardToOtherUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsSubscribeDashboardToOtherUsers")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsSubscribeDashboardToOtherUsers { get; set; }

		///<summary>
		/// Manage Public Lightning Email Templates
		/// <para>Name: MaximumPermissionsCreateLtngTempInPub</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCreateLtngTempInPub")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsCreateLtngTempInPub { get; set; }

		///<summary>
		/// Send Non-Commercial Email
		/// <para>Name: MaximumPermissionsTransactionalEmailSend</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsTransactionalEmailSend")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsTransactionalEmailSend { get; set; }

		///<summary>
		/// View Private Static Resources
		/// <para>Name: MaximumPermissionsViewPrivateStaticResources</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewPrivateStaticResources")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsViewPrivateStaticResources { get; set; }

		///<summary>
		/// Create Folders for Lightning Email Templates
		/// <para>Name: MaximumPermissionsCreateLtngTempFolder</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCreateLtngTempFolder")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsCreateLtngTempFolder { get; set; }

		///<summary>
		/// Apex REST Services
		/// <para>Name: MaximumPermissionsApexRestServices</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsApexRestServices")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsApexRestServices { get; set; }

		///<summary>
		/// Show App Launcher in Communities
		/// <para>Name: MaximumPermissionsEnableCommunityAppLauncher</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsEnableCommunityAppLauncher")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsEnableCommunityAppLauncher { get; set; }

		///<summary>
		/// Give Recognition Badges in Lightning Communities
		/// <para>Name: MaximumPermissionsGiveRecognitionBadge</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsGiveRecognitionBadge")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsGiveRecognitionBadge { get; set; }

		///<summary>
		/// Remain in Salesforce Classic
		/// <para>Name: MaximumPermissionsLtngPromoReserved01UserPerm</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsLtngPromoReserved01UserPerm")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsLtngPromoReserved01UserPerm { get; set; }

		///<summary>
		/// Manage Analytics Subscriptions
		/// <para>Name: MaximumPermissionsManageSubscriptions</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageSubscriptions")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageSubscriptions { get; set; }

		///<summary>
		/// Manage Analytics Private Assets
		/// <para>Name: MaximumPermissionsWaveManagePrivateAssetsUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsWaveManagePrivateAssetsUser")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsWaveManagePrivateAssetsUser { get; set; }

		///<summary>
		/// Edit Dataset Recipes
		/// <para>Name: MaximumPermissionsCanEditDataPrepRecipe</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCanEditDataPrepRecipe")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsCanEditDataPrepRecipe { get; set; }

		///<summary>
		/// Add Analytics Remote Connections
		/// <para>Name: MaximumPermissionsAddAnalyticsRemoteConnections</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsAddAnalyticsRemoteConnections")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsAddAnalyticsRemoteConnections { get; set; }

		///<summary>
		/// Manage Surveys
		/// <para>Name: MaximumPermissionsManageSurveys</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageSurveys")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageSurveys { get; set; }

		///<summary>
		/// View Roles and Role Hierarchy
		/// <para>Name: MaximumPermissionsViewRoles</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewRoles")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsViewRoles { get; set; }

		///<summary>
		/// Manage Analytics Custom Maps
		/// <para>Name: MaximumPermissionsCanManageMaps</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCanManageMaps")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsCanManageMaps { get; set; }

		///<summary>
		/// New Salesforce Mobile App - Customizable Navigation (Winter &#39;20 Pilot Only)
		/// <para>Name: MaximumPermissionsCustomTabBarOnMobile</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCustomTabBarOnMobile")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsCustomTabBarOnMobile { get; set; }

		///<summary>
		/// Agent Initiated Outbound Messaging
		/// <para>Name: MaximumPermissionsLMOutboundMessagingUserPerm</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsLMOutboundMessagingUserPerm")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsLMOutboundMessagingUserPerm { get; set; }

		///<summary>
		/// Modify Data Classification
		/// <para>Name: MaximumPermissionsModifyDataClassification</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsModifyDataClassification")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsModifyDataClassification { get; set; }

		///<summary>
		/// Allow user to access privacy data
		/// <para>Name: MaximumPermissionsPrivacyDataAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsPrivacyDataAccess")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsPrivacyDataAccess { get; set; }

		///<summary>
		/// Query All Files
		/// <para>Name: MaximumPermissionsQueryAllFiles</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsQueryAllFiles")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsQueryAllFiles { get; set; }

		///<summary>
		/// Modify Metadata Through Metadata API Functions
		/// <para>Name: MaximumPermissionsModifyMetadata</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsModifyMetadata")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsModifyMetadata { get; set; }

		///<summary>
		/// Create CMS Workspaces and Channels
		/// <para>Name: MaximumPermissionsManageCMS</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageCMS")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageCMS { get; set; }

		///<summary>
		/// Enables testing a sandbox community in the Mobile Publisher for Community Cloud app.
		/// <para>Name: MaximumPermissionsSandboxTestingInCommunityApp</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsSandboxTestingInCommunityApp")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsSandboxTestingInCommunityApp { get; set; }

		///<summary>
		/// View Flow Usage and Flow Event Data
		/// <para>Name: MaximumPermissionsViewFlowUsageAndFlowEventData</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewFlowUsageAndFlowEventData")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsViewFlowUsageAndFlowEventData { get; set; }

		///<summary>
		/// Manage Prompts
		/// <para>Name: MaximumPermissionsCanEditPrompts</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsCanEditPrompts")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsCanEditPrompts { get; set; }

		///<summary>
		/// View User Records with PII
		/// <para>Name: MaximumPermissionsViewUserPII</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewUserPII")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsViewUserPII { get; set; }

		///<summary>
		/// Connect Org to Customer 360 Data Manager
		/// <para>Name: MaximumPermissionsManageHubConnections</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageHubConnections")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageHubConnections { get; set; }

		///<summary>
		/// Create B2B Marketing Analytics Apps
		/// <para>Name: MaximumPermissionsB2BMarketingAnalyticsUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsB2BMarketingAnalyticsUser")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsB2BMarketingAnalyticsUser { get; set; }

		///<summary>
		/// Access Tracer for External Data Sources
		/// <para>Name: MaximumPermissionsTraceXdsQueries</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsTraceXdsQueries")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsTraceXdsQueries { get; set; }

		///<summary>
		/// View Security Center pages
		/// <para>Name: MaximumPermissionsViewSecurityCommandCenter</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewSecurityCommandCenter")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsViewSecurityCommandCenter { get; set; }

		///<summary>
		/// Manage Security Center
		/// <para>Name: MaximumPermissionsManageSecurityCommandCenter</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageSecurityCommandCenter")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageSecurityCommandCenter { get; set; }

		///<summary>
		/// View All Custom Settings
		/// <para>Name: MaximumPermissionsViewAllCustomSettings</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewAllCustomSettings")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsViewAllCustomSettings { get; set; }

		///<summary>
		/// View All Lookup Record Names
		/// <para>Name: MaximumPermissionsViewAllForeignKeyNames</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewAllForeignKeyNames")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsViewAllForeignKeyNames { get; set; }

		///<summary>
		/// Notification Emails: Add Recipients
		/// <para>Name: MaximumPermissionsAddWaveNotificationRecipients</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsAddWaveNotificationRecipients")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsAddWaveNotificationRecipients { get; set; }

		///<summary>
		/// Enable Salesforce CMS Integration
		/// <para>Name: MaximumPermissionsHeadlessCMSAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsHeadlessCMSAccess")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsHeadlessCMSAccess { get; set; }

		///<summary>
		/// End Messaging Session
		/// <para>Name: MaximumPermissionsLMEndMessagingSessionUserPerm</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsLMEndMessagingSessionUserPerm")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsLMEndMessagingSessionUserPerm { get; set; }

		///<summary>
		/// Update Consent Preferences Using REST API
		/// <para>Name: MaximumPermissionsConsentApiUpdate</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsConsentApiUpdate")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsConsentApiUpdate { get; set; }

		///<summary>
		/// Access drag-and-drop content builder
		/// <para>Name: MaximumPermissionsAccessContentBuilder</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsAccessContentBuilder")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsAccessContentBuilder { get; set; }

		///<summary>
		/// Account Switcher User
		/// <para>Name: MaximumPermissionsAccountSwitcherUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsAccountSwitcherUser")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsAccountSwitcherUser { get; set; }

		///<summary>
		/// Manage your Clearbit Integration
		/// <para>Name: MaximumPermissionsManageClearbitIntegration</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageClearbitIntegration")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageClearbitIntegration { get; set; }

		///<summary>
		/// View Threat Detection Events
		/// <para>Name: MaximumPermissionsViewAnomalyEvents</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewAnomalyEvents")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsViewAnomalyEvents { get; set; }

		///<summary>
		/// Connect Org to Customer 360 Audiences
		/// <para>Name: MaximumPermissionsManageC360AConnections</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageC360AConnections")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageC360AConnections { get; set; }

		///<summary>
		/// Manage your Zapier Integration
		/// <para>Name: MaximumPermissionsManageZapierIntegration</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageZapierIntegration")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageZapierIntegration { get; set; }

		///<summary>
		/// Manage Release Updates
		/// <para>Name: MaximumPermissionsManageReleaseUpdates</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageReleaseUpdates")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageReleaseUpdates { get; set; }

		///<summary>
		/// View All Profiles
		/// <para>Name: MaximumPermissionsViewAllProfiles</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsViewAllProfiles")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsViewAllProfiles { get; set; }

		///<summary>
		/// Skip Identity Confirmation at Login
		/// <para>Name: MaximumPermissionsSkipIdentityConfirmation</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsSkipIdentityConfirmation")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsSkipIdentityConfirmation { get; set; }

		///<summary>
		/// Send Custom Notifications
		/// <para>Name: MaximumPermissionsSendCustomNotifications</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsSendCustomNotifications")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsSendCustomNotifications { get; set; }

		///<summary>
		/// Delete Second-Generation Packages
		/// <para>Name: MaximumPermissionsPackaging2Delete</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsPackaging2Delete")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsPackaging2Delete { get; set; }

		///<summary>
		/// User license to access Lightning components and features delivered in Financial Services Cloud.
		/// <para>Name: MaximumPermissionsFSCComprehensiveUserAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsFSCComprehensiveUserAccess")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsFSCComprehensiveUserAccess { get; set; }

		///<summary>
		/// Manage Bots
		/// <para>Name: MaximumPermissionsBotManageBots</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsBotManageBots")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsBotManageBots { get; set; }

		///<summary>
		/// Manage Bots Training Data
		/// <para>Name: MaximumPermissionsBotManageBotsTrainingData</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsBotManageBotsTrainingData")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsBotManageBotsTrainingData { get; set; }

		///<summary>
		/// Salesforce Anywhere Integration Access
		/// <para>Name: MaximumPermissionsIsotopeCToCUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsIsotopeCToCUser")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsIsotopeCToCUser { get; set; }

		///<summary>
		/// Salesforce Anywhere on Mobile
		/// <para>Name: MaximumPermissionsIsotopeAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsIsotopeAccess")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsIsotopeAccess { get; set; }

		///<summary>
		/// Salesforce Anywhere in Lightning Experience
		/// <para>Name: MaximumPermissionsIsotopeLEX</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsIsotopeLEX")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsIsotopeLEX { get; set; }

		///<summary>
		/// Quip Metrics
		/// <para>Name: MaximumPermissionsQuipMetricsAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsQuipMetricsAccess")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsQuipMetricsAccess { get; set; }

		///<summary>
		/// Quip User Engagement Metrics
		/// <para>Name: MaximumPermissionsQuipUserEngagementMetrics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsQuipUserEngagementMetrics")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsQuipUserEngagementMetrics { get; set; }

		///<summary>
		/// Allow user to modify Private Connections
		/// <para>Name: MaximumPermissionsManageExternalConnections</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsManageExternalConnections")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsManageExternalConnections { get; set; }

		///<summary>
		/// Use Subscription Emails
		/// <para>Name: MaximumPermissionsUseSubscriptionEmails</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsUseSubscriptionEmails")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsUseSubscriptionEmails { get; set; }

		///<summary>
		/// Salesforce Mobile App: Native scrolling on webviews
		/// <para>Name: MaximumPermissionsNativeWebviewScrolling</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "maximumPermissionsNativeWebviewScrolling")]
		[Updateable(false), Createable(false)]
		public bool? MaximumPermissionsNativeWebviewScrolling { get; set; }

		///<summary>
		/// Used Licenses
		/// <para>Name: UsedLicenses</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "usedLicenses")]
		[Updateable(false), Createable(false)]
		public int? UsedLicenses { get; set; }

	}
}
