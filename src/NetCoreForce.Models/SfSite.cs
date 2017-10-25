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
	/// Site
	///<para>SObject Name: Site</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfSite : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "Site"; }
		}

		///<summary>
		/// Site ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Site Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
		public string Name { get; set; }

		///<summary>
		/// Site Subdomain Prefix
		/// <para>Name: Subdomain</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "subdomain")]
		[Updateable(false), Createable(false)]
		public string Subdomain { get; set; }

		///<summary>
		/// Default Web Address
		/// <para>Name: UrlPathPrefix</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "urlPathPrefix")]
		[Updateable(false), Createable(false)]
		public string UrlPathPrefix { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: GuestUserId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "guestUserId")]
		[Updateable(false), Createable(false)]
		public string GuestUserId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: GuestUser</para>
		///</summary>
		[JsonProperty(PropertyName = "guestUser")]
		[Updateable(false), Createable(false)]
		public SfUser GuestUser { get; set; }

		///<summary>
		/// Site Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		[Updateable(false), Createable(false)]
		public string Status { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: AdminId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "adminId")]
		[Updateable(false), Createable(false)]
		public string AdminId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: Admin</para>
		///</summary>
		[JsonProperty(PropertyName = "admin")]
		[Updateable(false), Createable(false)]
		public SfUser Admin { get; set; }

		///<summary>
		/// Enable Feeds
		/// <para>Name: OptionsEnableFeeds</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsEnableFeeds")]
		[Updateable(false), Createable(false)]
		public bool? OptionsEnableFeeds { get; set; }

		///<summary>
		/// Require Secure Connections (HTTPS)
		/// <para>Name: OptionsRequireHttps</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsRequireHttps")]
		[Updateable(false), Createable(false)]
		public bool? OptionsRequireHttps { get; set; }

		///<summary>
		/// Enable Standard Home Page
		/// <para>Name: OptionsAllowHomePage</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsAllowHomePage")]
		[Updateable(false), Createable(false)]
		public bool? OptionsAllowHomePage { get; set; }

		///<summary>
		/// Enable Standard Ideas Pages
		/// <para>Name: OptionsAllowStandardIdeasPages</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsAllowStandardIdeasPages")]
		[Updateable(false), Createable(false)]
		public bool? OptionsAllowStandardIdeasPages { get; set; }

		///<summary>
		/// Enable Standard Lookup Pages
		/// <para>Name: OptionsAllowStandardSearch</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsAllowStandardSearch")]
		[Updateable(false), Createable(false)]
		public bool? OptionsAllowStandardSearch { get; set; }

		///<summary>
		/// Enable Standard Search Pages
		/// <para>Name: OptionsAllowStandardLookups</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsAllowStandardLookups")]
		[Updateable(false), Createable(false)]
		public bool? OptionsAllowStandardLookups { get; set; }

		///<summary>
		/// Enable Standard Answers Pages
		/// <para>Name: OptionsAllowStandardAnswersPages</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsAllowStandardAnswersPages")]
		[Updateable(false), Createable(false)]
		public bool? OptionsAllowStandardAnswersPages { get; set; }

		///<summary>
		/// Guest Access to the Support API
		/// <para>Name: OptionsAllowGuestSupportApi</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsAllowGuestSupportApi")]
		[Updateable(false), Createable(false)]
		public bool? OptionsAllowGuestSupportApi { get; set; }

		///<summary>
		/// Allow Access to Standard Salesforce Pages
		/// <para>Name: OptionsAllowStandardPortalPages</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsAllowStandardPortalPages")]
		[Updateable(false), Createable(false)]
		public bool? OptionsAllowStandardPortalPages { get; set; }

		///<summary>
		/// Upgrade all requests to HTTPS
		/// <para>Name: OptionsCspUpgradeInsecureRequests</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsCspUpgradeInsecureRequests")]
		[Updateable(false), Createable(false)]
		public bool? OptionsCspUpgradeInsecureRequests { get; set; }

		///<summary>
		/// Enable Content Sniffing Protection
		/// <para>Name: OptionsContentSniffingProtection</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsContentSniffingProtection")]
		[Updateable(false), Createable(false)]
		public bool? OptionsContentSniffingProtection { get; set; }

		///<summary>
		/// Enable Browser Cross Site Scripting Protection
		/// <para>Name: OptionsBrowserXssProtection</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsBrowserXssProtection")]
		[Updateable(false), Createable(false)]
		public bool? OptionsBrowserXssProtection { get; set; }

		///<summary>
		/// Referrer URL Protection
		/// <para>Name: OptionsReferrerPolicyOriginWhenCrossOrigin</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsReferrerPolicyOriginWhenCrossOrigin")]
		[Updateable(false), Createable(false)]
		public bool? OptionsReferrerPolicyOriginWhenCrossOrigin { get; set; }

		///<summary>
		/// Site Description
		/// <para>Name: Description</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		[Updateable(false), Createable(false)]
		public string Description { get; set; }

		///<summary>
		/// Site Label
		/// <para>Name: MasterLabel</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "masterLabel")]
		[Updateable(false), Createable(false)]
		public string MasterLabel { get; set; }

		///<summary>
		/// Analytics Tracking Code
		/// <para>Name: AnalyticsTrackingCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "analyticsTrackingCode")]
		[Updateable(false), Createable(false)]
		public string AnalyticsTrackingCode { get; set; }

		///<summary>
		/// Site Type
		/// <para>Name: SiteType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "siteType")]
		[Updateable(false), Createable(false)]
		public string SiteType { get; set; }

		///<summary>
		/// Clickjack Protection Level
		/// <para>Name: ClickjackProtectionLevel</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "clickjackProtectionLevel")]
		[Updateable(false), Createable(false)]
		public string ClickjackProtectionLevel { get; set; }

		///<summary>
		/// Daily Bandwidth Limit (MB)
		/// <para>Name: DailyBandwidthLimit</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dailyBandwidthLimit")]
		[Updateable(false), Createable(false)]
		public int? DailyBandwidthLimit { get; set; }

		///<summary>
		/// Daily Bandwidth Used
		/// <para>Name: DailyBandwidthUsed</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dailyBandwidthUsed")]
		[Updateable(false), Createable(false)]
		public int? DailyBandwidthUsed { get; set; }

		///<summary>
		/// Daily Request Time Limit (min)
		/// <para>Name: DailyRequestTimeLimit</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dailyRequestTimeLimit")]
		[Updateable(false), Createable(false)]
		public int? DailyRequestTimeLimit { get; set; }

		///<summary>
		/// Daily Request Time Used
		/// <para>Name: DailyRequestTimeUsed</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dailyRequestTimeUsed")]
		[Updateable(false), Createable(false)]
		public int? DailyRequestTimeUsed { get; set; }

		///<summary>
		/// Monthly Page Views Allowed
		/// <para>Name: MonthlyPageViewsEntitlement</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "monthlyPageViewsEntitlement")]
		[Updateable(false), Createable(false)]
		public int? MonthlyPageViewsEntitlement { get; set; }

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

	}
}
