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
	/// User
	///<para>SObject Name: User</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfUser : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "User"; }
		}

		///<summary>
		/// User ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Username
		/// <para>Name: Username</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "username")]
		public string Username { get; set; }

		///<summary>
		/// Last Name
		/// <para>Name: LastName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastName")]
		public string LastName { get; set; }

		///<summary>
		/// First Name
		/// <para>Name: FirstName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "firstName")]
		public string FirstName { get; set; }

		///<summary>
		/// Full Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
		public string Name { get; set; }

		///<summary>
		/// Company Name
		/// <para>Name: CompanyName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "companyName")]
		public string CompanyName { get; set; }

		///<summary>
		/// Division
		/// <para>Name: Division</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "division")]
		public string Division { get; set; }

		///<summary>
		/// Department
		/// <para>Name: Department</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "department")]
		public string Department { get; set; }

		///<summary>
		/// Title
		/// <para>Name: Title</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "title")]
		public string Title { get; set; }

		///<summary>
		/// Street
		/// <para>Name: Street</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "street")]
		public string Street { get; set; }

		///<summary>
		/// City
		/// <para>Name: City</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "city")]
		public string City { get; set; }

		///<summary>
		/// State/Province
		/// <para>Name: State</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "state")]
		public string State { get; set; }

		///<summary>
		/// Zip/Postal Code
		/// <para>Name: PostalCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "postalCode")]
		public string PostalCode { get; set; }

		///<summary>
		/// Country
		/// <para>Name: Country</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "country")]
		public string Country { get; set; }

		///<summary>
		/// Latitude
		/// <para>Name: Latitude</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "latitude")]
		public double? Latitude { get; set; }

		///<summary>
		/// Longitude
		/// <para>Name: Longitude</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "longitude")]
		public double? Longitude { get; set; }

		///<summary>
		/// Geocode Accuracy
		/// <para>Name: GeocodeAccuracy</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "geocodeAccuracy")]
		public string GeocodeAccuracy { get; set; }

		///<summary>
		/// Address
		/// <para>Name: Address</para>
		/// <para>SF Type: address</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "address")]
		[Updateable(false), Createable(false)]
		public Address Address { get; set; }

		///<summary>
		/// Email
		/// <para>Name: Email</para>
		/// <para>SF Type: email</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "email")]
		public string Email { get; set; }

		///<summary>
		/// AutoBcc
		/// <para>Name: EmailPreferencesAutoBcc</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "emailPreferencesAutoBcc")]
		public bool? EmailPreferencesAutoBcc { get; set; }

		///<summary>
		/// AutoBccStayInTouch
		/// <para>Name: EmailPreferencesAutoBccStayInTouch</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "emailPreferencesAutoBccStayInTouch")]
		public bool? EmailPreferencesAutoBccStayInTouch { get; set; }

		///<summary>
		/// StayInTouchReminder
		/// <para>Name: EmailPreferencesStayInTouchReminder</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "emailPreferencesStayInTouchReminder")]
		public bool? EmailPreferencesStayInTouchReminder { get; set; }

		///<summary>
		/// Email Sender Address
		/// <para>Name: SenderEmail</para>
		/// <para>SF Type: email</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "senderEmail")]
		public string SenderEmail { get; set; }

		///<summary>
		/// Email Sender Name
		/// <para>Name: SenderName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "senderName")]
		public string SenderName { get; set; }

		///<summary>
		/// Email Signature
		/// <para>Name: Signature</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "signature")]
		public string Signature { get; set; }

		///<summary>
		/// Stay-in-Touch Email Subject
		/// <para>Name: StayInTouchSubject</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "stayInTouchSubject")]
		public string StayInTouchSubject { get; set; }

		///<summary>
		/// Stay-in-Touch Email Signature
		/// <para>Name: StayInTouchSignature</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "stayInTouchSignature")]
		public string StayInTouchSignature { get; set; }

		///<summary>
		/// Stay-in-Touch Email Note
		/// <para>Name: StayInTouchNote</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "stayInTouchNote")]
		public string StayInTouchNote { get; set; }

		///<summary>
		/// Phone
		/// <para>Name: Phone</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "phone")]
		public string Phone { get; set; }

		///<summary>
		/// Fax
		/// <para>Name: Fax</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fax")]
		public string Fax { get; set; }

		///<summary>
		/// Cell
		/// <para>Name: MobilePhone</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mobilePhone")]
		public string MobilePhone { get; set; }

		///<summary>
		/// Alias
		/// <para>Name: Alias</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "alias")]
		public string Alias { get; set; }

		///<summary>
		/// Nickname
		/// <para>Name: CommunityNickname</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "communityNickname")]
		public string CommunityNickname { get; set; }

		///<summary>
		/// User Photo badge text overlay
		/// <para>Name: BadgeText</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "badgeText")]
		[Updateable(false), Createable(false)]
		public string BadgeText { get; set; }

		///<summary>
		/// Active
		/// <para>Name: IsActive</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isActive")]
		public bool? IsActive { get; set; }

		///<summary>
		/// Time Zone
		/// <para>Name: TimeZoneSidKey</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "timeZoneSidKey")]
		public string TimeZoneSidKey { get; set; }

		///<summary>
		/// Role ID
		/// <para>Name: UserRoleId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "userRoleId")]
		public string UserRoleId { get; set; }

		///<summary>
		/// ReferenceTo: UserRole
		/// <para>RelationshipName: UserRole</para>
		///</summary>
		[JsonProperty(PropertyName = "userRole")]
		[Updateable(false), Createable(false)]
		public SfUserRole UserRole { get; set; }

		///<summary>
		/// Locale
		/// <para>Name: LocaleSidKey</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "localeSidKey")]
		public string LocaleSidKey { get; set; }

		///<summary>
		/// Info Emails
		/// <para>Name: ReceivesInfoEmails</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "receivesInfoEmails")]
		public bool? ReceivesInfoEmails { get; set; }

		///<summary>
		/// Admin Info Emails
		/// <para>Name: ReceivesAdminInfoEmails</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "receivesAdminInfoEmails")]
		public bool? ReceivesAdminInfoEmails { get; set; }

		///<summary>
		/// Email Encoding
		/// <para>Name: EmailEncodingKey</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "emailEncodingKey")]
		public string EmailEncodingKey { get; set; }

		///<summary>
		/// Profile ID
		/// <para>Name: ProfileId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "profileId")]
		public string ProfileId { get; set; }

		///<summary>
		/// ReferenceTo: Profile
		/// <para>RelationshipName: Profile</para>
		///</summary>
		[JsonProperty(PropertyName = "profile")]
		[Updateable(false), Createable(false)]
		public SfProfile Profile { get; set; }

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
		/// Language
		/// <para>Name: LanguageLocaleKey</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "languageLocaleKey")]
		public string LanguageLocaleKey { get; set; }

		///<summary>
		/// Employee Number
		/// <para>Name: EmployeeNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "employeeNumber")]
		public string EmployeeNumber { get; set; }

		///<summary>
		/// Delegated Approver ID
		/// <para>Name: DelegatedApproverId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "delegatedApproverId")]
		public string DelegatedApproverId { get; set; }

		///<summary>
		/// Manager ID
		/// <para>Name: ManagerId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "managerId")]
		public string ManagerId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: Manager</para>
		///</summary>
		[JsonProperty(PropertyName = "manager")]
		[Updateable(false), Createable(false)]
		public SfUser Manager { get; set; }

		///<summary>
		/// Last Login
		/// <para>Name: LastLoginDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastLoginDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastLoginDate { get; set; }

		///<summary>
		/// Last Password Change or Reset
		/// <para>Name: LastPasswordChangeDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastPasswordChangeDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastPasswordChangeDate { get; set; }

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
		/// Offline Edition Trial Expiration Date
		/// <para>Name: OfflineTrialExpirationDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "offlineTrialExpirationDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? OfflineTrialExpirationDate { get; set; }

		///<summary>
		/// Sales Anywhere Trial Expiration Date
		/// <para>Name: OfflinePdaTrialExpirationDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "offlinePdaTrialExpirationDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? OfflinePdaTrialExpirationDate { get; set; }

		///<summary>
		/// Marketing User
		/// <para>Name: UserPermissionsMarketingUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPermissionsMarketingUser")]
		public bool? UserPermissionsMarketingUser { get; set; }

		///<summary>
		/// Offline User
		/// <para>Name: UserPermissionsOfflineUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPermissionsOfflineUser")]
		public bool? UserPermissionsOfflineUser { get; set; }

		///<summary>
		/// Auto-login To Call Center
		/// <para>Name: UserPermissionsCallCenterAutoLogin</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPermissionsCallCenterAutoLogin")]
		public bool? UserPermissionsCallCenterAutoLogin { get; set; }

		///<summary>
		/// Apex Mobile User
		/// <para>Name: UserPermissionsMobileUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPermissionsMobileUser")]
		public bool? UserPermissionsMobileUser { get; set; }

		///<summary>
		/// Salesforce CRM Content User
		/// <para>Name: UserPermissionsSFContentUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPermissionsSFContentUser")]
		public bool? UserPermissionsSFContentUser { get; set; }

		///<summary>
		/// Knowledge User
		/// <para>Name: UserPermissionsKnowledgeUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPermissionsKnowledgeUser")]
		public bool? UserPermissionsKnowledgeUser { get; set; }

		///<summary>
		/// Force.com Flow User
		/// <para>Name: UserPermissionsInteractionUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPermissionsInteractionUser")]
		public bool? UserPermissionsInteractionUser { get; set; }

		///<summary>
		/// Service Cloud User
		/// <para>Name: UserPermissionsSupportUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPermissionsSupportUser")]
		public bool? UserPermissionsSupportUser { get; set; }

		///<summary>
		/// Site.com Contributor User
		/// <para>Name: UserPermissionsSiteforceContributorUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPermissionsSiteforceContributorUser")]
		public bool? UserPermissionsSiteforceContributorUser { get; set; }

		///<summary>
		/// Site.com Publisher User
		/// <para>Name: UserPermissionsSiteforcePublisherUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPermissionsSiteforcePublisherUser")]
		public bool? UserPermissionsSiteforcePublisherUser { get; set; }

		///<summary>
		/// Chatter Answers User
		/// <para>Name: UserPermissionsChatterAnswersUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPermissionsChatterAnswersUser")]
		public bool? UserPermissionsChatterAnswersUser { get; set; }

		///<summary>
		/// Allow Forecasting
		/// <para>Name: ForecastEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "forecastEnabled")]
		public bool? ForecastEnabled { get; set; }

		///<summary>
		/// ActivityRemindersPopup
		/// <para>Name: UserPreferencesActivityRemindersPopup</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesActivityRemindersPopup")]
		public bool? UserPreferencesActivityRemindersPopup { get; set; }

		///<summary>
		/// EventRemindersCheckboxDefault
		/// <para>Name: UserPreferencesEventRemindersCheckboxDefault</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesEventRemindersCheckboxDefault")]
		public bool? UserPreferencesEventRemindersCheckboxDefault { get; set; }

		///<summary>
		/// TaskRemindersCheckboxDefault
		/// <para>Name: UserPreferencesTaskRemindersCheckboxDefault</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesTaskRemindersCheckboxDefault")]
		public bool? UserPreferencesTaskRemindersCheckboxDefault { get; set; }

		///<summary>
		/// ReminderSoundOff
		/// <para>Name: UserPreferencesReminderSoundOff</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesReminderSoundOff")]
		public bool? UserPreferencesReminderSoundOff { get; set; }

		///<summary>
		/// DisableAllFeedsEmail
		/// <para>Name: UserPreferencesDisableAllFeedsEmail</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesDisableAllFeedsEmail")]
		public bool? UserPreferencesDisableAllFeedsEmail { get; set; }

		///<summary>
		/// DisableFollowersEmail
		/// <para>Name: UserPreferencesDisableFollowersEmail</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesDisableFollowersEmail")]
		public bool? UserPreferencesDisableFollowersEmail { get; set; }

		///<summary>
		/// DisableProfilePostEmail
		/// <para>Name: UserPreferencesDisableProfilePostEmail</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesDisableProfilePostEmail")]
		public bool? UserPreferencesDisableProfilePostEmail { get; set; }

		///<summary>
		/// DisableChangeCommentEmail
		/// <para>Name: UserPreferencesDisableChangeCommentEmail</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesDisableChangeCommentEmail")]
		public bool? UserPreferencesDisableChangeCommentEmail { get; set; }

		///<summary>
		/// DisableLaterCommentEmail
		/// <para>Name: UserPreferencesDisableLaterCommentEmail</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesDisableLaterCommentEmail")]
		public bool? UserPreferencesDisableLaterCommentEmail { get; set; }

		///<summary>
		/// DisProfPostCommentEmail
		/// <para>Name: UserPreferencesDisProfPostCommentEmail</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesDisProfPostCommentEmail")]
		public bool? UserPreferencesDisProfPostCommentEmail { get; set; }

		///<summary>
		/// ContentNoEmail
		/// <para>Name: UserPreferencesContentNoEmail</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesContentNoEmail")]
		public bool? UserPreferencesContentNoEmail { get; set; }

		///<summary>
		/// ContentEmailAsAndWhen
		/// <para>Name: UserPreferencesContentEmailAsAndWhen</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesContentEmailAsAndWhen")]
		public bool? UserPreferencesContentEmailAsAndWhen { get; set; }

		///<summary>
		/// ApexPagesDeveloperMode
		/// <para>Name: UserPreferencesApexPagesDeveloperMode</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesApexPagesDeveloperMode")]
		public bool? UserPreferencesApexPagesDeveloperMode { get; set; }

		///<summary>
		/// HideCSNGetChatterMobileTask
		/// <para>Name: UserPreferencesHideCSNGetChatterMobileTask</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesHideCSNGetChatterMobileTask")]
		public bool? UserPreferencesHideCSNGetChatterMobileTask { get; set; }

		///<summary>
		/// DisableMentionsPostEmail
		/// <para>Name: UserPreferencesDisableMentionsPostEmail</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesDisableMentionsPostEmail")]
		public bool? UserPreferencesDisableMentionsPostEmail { get; set; }

		///<summary>
		/// DisMentionsCommentEmail
		/// <para>Name: UserPreferencesDisMentionsCommentEmail</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesDisMentionsCommentEmail")]
		public bool? UserPreferencesDisMentionsCommentEmail { get; set; }

		///<summary>
		/// HideCSNDesktopTask
		/// <para>Name: UserPreferencesHideCSNDesktopTask</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesHideCSNDesktopTask")]
		public bool? UserPreferencesHideCSNDesktopTask { get; set; }

		///<summary>
		/// HideChatterOnboardingSplash
		/// <para>Name: UserPreferencesHideChatterOnboardingSplash</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesHideChatterOnboardingSplash")]
		public bool? UserPreferencesHideChatterOnboardingSplash { get; set; }

		///<summary>
		/// HideSecondChatterOnboardingSplash
		/// <para>Name: UserPreferencesHideSecondChatterOnboardingSplash</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesHideSecondChatterOnboardingSplash")]
		public bool? UserPreferencesHideSecondChatterOnboardingSplash { get; set; }

		///<summary>
		/// DisCommentAfterLikeEmail
		/// <para>Name: UserPreferencesDisCommentAfterLikeEmail</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesDisCommentAfterLikeEmail")]
		public bool? UserPreferencesDisCommentAfterLikeEmail { get; set; }

		///<summary>
		/// DisableLikeEmail
		/// <para>Name: UserPreferencesDisableLikeEmail</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesDisableLikeEmail")]
		public bool? UserPreferencesDisableLikeEmail { get; set; }

		///<summary>
		/// SortFeedByComment
		/// <para>Name: UserPreferencesSortFeedByComment</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesSortFeedByComment")]
		public bool? UserPreferencesSortFeedByComment { get; set; }

		///<summary>
		/// DisableMessageEmail
		/// <para>Name: UserPreferencesDisableMessageEmail</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesDisableMessageEmail")]
		public bool? UserPreferencesDisableMessageEmail { get; set; }

		///<summary>
		/// DisableBookmarkEmail
		/// <para>Name: UserPreferencesDisableBookmarkEmail</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesDisableBookmarkEmail")]
		public bool? UserPreferencesDisableBookmarkEmail { get; set; }

		///<summary>
		/// DisableSharePostEmail
		/// <para>Name: UserPreferencesDisableSharePostEmail</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesDisableSharePostEmail")]
		public bool? UserPreferencesDisableSharePostEmail { get; set; }

		///<summary>
		/// EnableAutoSubForFeeds
		/// <para>Name: UserPreferencesEnableAutoSubForFeeds</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesEnableAutoSubForFeeds")]
		public bool? UserPreferencesEnableAutoSubForFeeds { get; set; }

		///<summary>
		/// DisableFileShareNotificationsForApi
		/// <para>Name: UserPreferencesDisableFileShareNotificationsForApi</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesDisableFileShareNotificationsForApi")]
		public bool? UserPreferencesDisableFileShareNotificationsForApi { get; set; }

		///<summary>
		/// ShowTitleToExternalUsers
		/// <para>Name: UserPreferencesShowTitleToExternalUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesShowTitleToExternalUsers")]
		public bool? UserPreferencesShowTitleToExternalUsers { get; set; }

		///<summary>
		/// ShowManagerToExternalUsers
		/// <para>Name: UserPreferencesShowManagerToExternalUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesShowManagerToExternalUsers")]
		public bool? UserPreferencesShowManagerToExternalUsers { get; set; }

		///<summary>
		/// ShowEmailToExternalUsers
		/// <para>Name: UserPreferencesShowEmailToExternalUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesShowEmailToExternalUsers")]
		public bool? UserPreferencesShowEmailToExternalUsers { get; set; }

		///<summary>
		/// ShowWorkPhoneToExternalUsers
		/// <para>Name: UserPreferencesShowWorkPhoneToExternalUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesShowWorkPhoneToExternalUsers")]
		public bool? UserPreferencesShowWorkPhoneToExternalUsers { get; set; }

		///<summary>
		/// ShowMobilePhoneToExternalUsers
		/// <para>Name: UserPreferencesShowMobilePhoneToExternalUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesShowMobilePhoneToExternalUsers")]
		public bool? UserPreferencesShowMobilePhoneToExternalUsers { get; set; }

		///<summary>
		/// ShowFaxToExternalUsers
		/// <para>Name: UserPreferencesShowFaxToExternalUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesShowFaxToExternalUsers")]
		public bool? UserPreferencesShowFaxToExternalUsers { get; set; }

		///<summary>
		/// ShowStreetAddressToExternalUsers
		/// <para>Name: UserPreferencesShowStreetAddressToExternalUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesShowStreetAddressToExternalUsers")]
		public bool? UserPreferencesShowStreetAddressToExternalUsers { get; set; }

		///<summary>
		/// ShowCityToExternalUsers
		/// <para>Name: UserPreferencesShowCityToExternalUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesShowCityToExternalUsers")]
		public bool? UserPreferencesShowCityToExternalUsers { get; set; }

		///<summary>
		/// ShowStateToExternalUsers
		/// <para>Name: UserPreferencesShowStateToExternalUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesShowStateToExternalUsers")]
		public bool? UserPreferencesShowStateToExternalUsers { get; set; }

		///<summary>
		/// ShowPostalCodeToExternalUsers
		/// <para>Name: UserPreferencesShowPostalCodeToExternalUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesShowPostalCodeToExternalUsers")]
		public bool? UserPreferencesShowPostalCodeToExternalUsers { get; set; }

		///<summary>
		/// ShowCountryToExternalUsers
		/// <para>Name: UserPreferencesShowCountryToExternalUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesShowCountryToExternalUsers")]
		public bool? UserPreferencesShowCountryToExternalUsers { get; set; }

		///<summary>
		/// ShowProfilePicToGuestUsers
		/// <para>Name: UserPreferencesShowProfilePicToGuestUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesShowProfilePicToGuestUsers")]
		public bool? UserPreferencesShowProfilePicToGuestUsers { get; set; }

		///<summary>
		/// ShowTitleToGuestUsers
		/// <para>Name: UserPreferencesShowTitleToGuestUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesShowTitleToGuestUsers")]
		public bool? UserPreferencesShowTitleToGuestUsers { get; set; }

		///<summary>
		/// ShowCityToGuestUsers
		/// <para>Name: UserPreferencesShowCityToGuestUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesShowCityToGuestUsers")]
		public bool? UserPreferencesShowCityToGuestUsers { get; set; }

		///<summary>
		/// ShowStateToGuestUsers
		/// <para>Name: UserPreferencesShowStateToGuestUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesShowStateToGuestUsers")]
		public bool? UserPreferencesShowStateToGuestUsers { get; set; }

		///<summary>
		/// ShowPostalCodeToGuestUsers
		/// <para>Name: UserPreferencesShowPostalCodeToGuestUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesShowPostalCodeToGuestUsers")]
		public bool? UserPreferencesShowPostalCodeToGuestUsers { get; set; }

		///<summary>
		/// ShowCountryToGuestUsers
		/// <para>Name: UserPreferencesShowCountryToGuestUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesShowCountryToGuestUsers")]
		public bool? UserPreferencesShowCountryToGuestUsers { get; set; }

		///<summary>
		/// HideS1BrowserUI
		/// <para>Name: UserPreferencesHideS1BrowserUI</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesHideS1BrowserUI")]
		public bool? UserPreferencesHideS1BrowserUI { get; set; }

		///<summary>
		/// DisableEndorsementEmail
		/// <para>Name: UserPreferencesDisableEndorsementEmail</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesDisableEndorsementEmail")]
		public bool? UserPreferencesDisableEndorsementEmail { get; set; }

		///<summary>
		/// PathAssistantCollapsed
		/// <para>Name: UserPreferencesPathAssistantCollapsed</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesPathAssistantCollapsed")]
		public bool? UserPreferencesPathAssistantCollapsed { get; set; }

		///<summary>
		/// CacheDiagnostics
		/// <para>Name: UserPreferencesCacheDiagnostics</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesCacheDiagnostics")]
		public bool? UserPreferencesCacheDiagnostics { get; set; }

		///<summary>
		/// ShowEmailToGuestUsers
		/// <para>Name: UserPreferencesShowEmailToGuestUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesShowEmailToGuestUsers")]
		public bool? UserPreferencesShowEmailToGuestUsers { get; set; }

		///<summary>
		/// ShowManagerToGuestUsers
		/// <para>Name: UserPreferencesShowManagerToGuestUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesShowManagerToGuestUsers")]
		public bool? UserPreferencesShowManagerToGuestUsers { get; set; }

		///<summary>
		/// ShowWorkPhoneToGuestUsers
		/// <para>Name: UserPreferencesShowWorkPhoneToGuestUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesShowWorkPhoneToGuestUsers")]
		public bool? UserPreferencesShowWorkPhoneToGuestUsers { get; set; }

		///<summary>
		/// ShowMobilePhoneToGuestUsers
		/// <para>Name: UserPreferencesShowMobilePhoneToGuestUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesShowMobilePhoneToGuestUsers")]
		public bool? UserPreferencesShowMobilePhoneToGuestUsers { get; set; }

		///<summary>
		/// ShowFaxToGuestUsers
		/// <para>Name: UserPreferencesShowFaxToGuestUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesShowFaxToGuestUsers")]
		public bool? UserPreferencesShowFaxToGuestUsers { get; set; }

		///<summary>
		/// ShowStreetAddressToGuestUsers
		/// <para>Name: UserPreferencesShowStreetAddressToGuestUsers</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesShowStreetAddressToGuestUsers")]
		public bool? UserPreferencesShowStreetAddressToGuestUsers { get; set; }

		///<summary>
		/// LightningExperiencePreferred
		/// <para>Name: UserPreferencesLightningExperiencePreferred</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesLightningExperiencePreferred")]
		public bool? UserPreferencesLightningExperiencePreferred { get; set; }

		///<summary>
		/// PreviewLightning
		/// <para>Name: UserPreferencesPreviewLightning</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesPreviewLightning")]
		public bool? UserPreferencesPreviewLightning { get; set; }

		///<summary>
		/// HideEndUserOnboardingAssistantModal
		/// <para>Name: UserPreferencesHideEndUserOnboardingAssistantModal</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesHideEndUserOnboardingAssistantModal")]
		public bool? UserPreferencesHideEndUserOnboardingAssistantModal { get; set; }

		///<summary>
		/// HideLightningMigrationModal
		/// <para>Name: UserPreferencesHideLightningMigrationModal</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesHideLightningMigrationModal")]
		public bool? UserPreferencesHideLightningMigrationModal { get; set; }

		///<summary>
		/// HideSfxWelcomeMat
		/// <para>Name: UserPreferencesHideSfxWelcomeMat</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesHideSfxWelcomeMat")]
		public bool? UserPreferencesHideSfxWelcomeMat { get; set; }

		///<summary>
		/// HideBiggerPhotoCallout
		/// <para>Name: UserPreferencesHideBiggerPhotoCallout</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesHideBiggerPhotoCallout")]
		public bool? UserPreferencesHideBiggerPhotoCallout { get; set; }

		///<summary>
		/// GlobalNavBarWTShown
		/// <para>Name: UserPreferencesGlobalNavBarWTShown</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesGlobalNavBarWTShown")]
		public bool? UserPreferencesGlobalNavBarWTShown { get; set; }

		///<summary>
		/// GlobalNavGridMenuWTShown
		/// <para>Name: UserPreferencesGlobalNavGridMenuWTShown</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesGlobalNavGridMenuWTShown")]
		public bool? UserPreferencesGlobalNavGridMenuWTShown { get; set; }

		///<summary>
		/// CreateLEXAppsWTShown
		/// <para>Name: UserPreferencesCreateLEXAppsWTShown</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesCreateLEXAppsWTShown")]
		public bool? UserPreferencesCreateLEXAppsWTShown { get; set; }

		///<summary>
		/// FavoritesWTShown
		/// <para>Name: UserPreferencesFavoritesWTShown</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesFavoritesWTShown")]
		public bool? UserPreferencesFavoritesWTShown { get; set; }

		///<summary>
		/// RecordHomeSectionCollapseWTShown
		/// <para>Name: UserPreferencesRecordHomeSectionCollapseWTShown</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesRecordHomeSectionCollapseWTShown")]
		public bool? UserPreferencesRecordHomeSectionCollapseWTShown { get; set; }

		///<summary>
		/// RecordHomeReservedWTShown
		/// <para>Name: UserPreferencesRecordHomeReservedWTShown</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesRecordHomeReservedWTShown")]
		public bool? UserPreferencesRecordHomeReservedWTShown { get; set; }

		///<summary>
		/// FavoritesShowTopFavorites
		/// <para>Name: UserPreferencesFavoritesShowTopFavorites</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesFavoritesShowTopFavorites")]
		public bool? UserPreferencesFavoritesShowTopFavorites { get; set; }

		///<summary>
		/// ExcludeMailAppAttachments
		/// <para>Name: UserPreferencesExcludeMailAppAttachments</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userPreferencesExcludeMailAppAttachments")]
		public bool? UserPreferencesExcludeMailAppAttachments { get; set; }

		///<summary>
		/// Contact ID
		/// <para>Name: ContactId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contactId")]
		[Updateable(false), Createable(true)]
		public string ContactId { get; set; }

		///<summary>
		/// ReferenceTo: Contact
		/// <para>RelationshipName: Contact</para>
		///</summary>
		[JsonProperty(PropertyName = "contact")]
		[Updateable(false), Createable(false)]
		public SfContact Contact { get; set; }

		///<summary>
		/// Account ID
		/// <para>Name: AccountId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "accountId")]
		[Updateable(false), Createable(false)]
		public string AccountId { get; set; }

		///<summary>
		/// ReferenceTo: Account
		/// <para>RelationshipName: Account</para>
		///</summary>
		[JsonProperty(PropertyName = "account")]
		[Updateable(false), Createable(false)]
		public SfAccount Account { get; set; }

		///<summary>
		/// Call Center ID
		/// <para>Name: CallCenterId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "callCenterId")]
		public string CallCenterId { get; set; }

		///<summary>
		/// Extension
		/// <para>Name: Extension</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "extension")]
		public string Extension { get; set; }

		///<summary>
		/// SAML Federation ID
		/// <para>Name: FederationIdentifier</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "federationIdentifier")]
		public string FederationIdentifier { get; set; }

		///<summary>
		/// About Me
		/// <para>Name: AboutMe</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "aboutMe")]
		public string AboutMe { get; set; }

		///<summary>
		/// Url for full-sized Photo
		/// <para>Name: FullPhotoUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fullPhotoUrl")]
		[Updateable(false), Createable(false)]
		public string FullPhotoUrl { get; set; }

		///<summary>
		/// Photo
		/// <para>Name: SmallPhotoUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "smallPhotoUrl")]
		[Updateable(false), Createable(false)]
		public string SmallPhotoUrl { get; set; }

		///<summary>
		/// Show external indicator
		/// <para>Name: IsExtIndicatorVisible</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isExtIndicatorVisible")]
		[Updateable(false), Createable(false)]
		public bool? IsExtIndicatorVisible { get; set; }

		///<summary>
		/// Out of office message
		/// <para>Name: OutOfOfficeMessage</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "outOfOfficeMessage")]
		[Updateable(false), Createable(false)]
		public string OutOfOfficeMessage { get; set; }

		///<summary>
		/// Url for medium profile photo
		/// <para>Name: MediumPhotoUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mediumPhotoUrl")]
		[Updateable(false), Createable(false)]
		public string MediumPhotoUrl { get; set; }

		///<summary>
		/// Chatter Email Highlights Frequency
		/// <para>Name: DigestFrequency</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "digestFrequency")]
		public string DigestFrequency { get; set; }

		///<summary>
		/// Default Notification Frequency when Joining Groups
		/// <para>Name: DefaultGroupNotificationFrequency</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "defaultGroupNotificationFrequency")]
		public string DefaultGroupNotificationFrequency { get; set; }

		///<summary>
		/// Last Viewed Date
		/// <para>Name: LastViewedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastViewedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastViewedDate { get; set; }

		///<summary>
		/// Last Referenced Date
		/// <para>Name: LastReferencedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastReferencedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastReferencedDate { get; set; }

		///<summary>
		/// Url for banner photo
		/// <para>Name: BannerPhotoUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "bannerPhotoUrl")]
		[Updateable(false), Createable(false)]
		public string BannerPhotoUrl { get; set; }

		///<summary>
		/// Url for IOS banner photo
		/// <para>Name: SmallBannerPhotoUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "smallBannerPhotoUrl")]
		[Updateable(false), Createable(false)]
		public string SmallBannerPhotoUrl { get; set; }

		///<summary>
		/// Url for Android banner photo
		/// <para>Name: MediumBannerPhotoUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mediumBannerPhotoUrl")]
		[Updateable(false), Createable(false)]
		public string MediumBannerPhotoUrl { get; set; }

		///<summary>
		/// Has Profile Photo
		/// <para>Name: IsProfilePhotoActive</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isProfilePhotoActive")]
		[Updateable(false), Createable(false)]
		public bool? IsProfilePhotoActive { get; set; }

	}
}
