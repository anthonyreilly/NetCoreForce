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
	/// AppMenuItem
	///<para>SObject Name: AppMenuItem</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfAppMenuItem : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "AppMenuItem"; }
		}

		///<summary>
		/// AppMenuItem ID
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
		/// Sort Order
		/// <para>Name: SortOrder</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "sortOrder")]
		[Updateable(false), Createable(false)]
		public int? SortOrder { get; set; }

		///<summary>
		/// Developer Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
		public string Name { get; set; }

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
		/// Label
		/// <para>Name: Label</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "label")]
		[Updateable(false), Createable(false)]
		public string Label { get; set; }

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
		/// Start Url
		/// <para>Name: StartUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "startUrl")]
		[Updateable(false), Createable(false)]
		public string StartUrl { get; set; }

		///<summary>
		/// Mobile Start Url
		/// <para>Name: MobileStartUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mobileStartUrl")]
		[Updateable(false), Createable(false)]
		public string MobileStartUrl { get; set; }

		///<summary>
		/// Logo Image URL
		/// <para>Name: LogoUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "logoUrl")]
		[Updateable(false), Createable(false)]
		public string LogoUrl { get; set; }

		///<summary>
		/// Icon Url
		/// <para>Name: IconUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "iconUrl")]
		[Updateable(false), Createable(false)]
		public string IconUrl { get; set; }

		///<summary>
		/// Info URL
		/// <para>Name: InfoUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "infoUrl")]
		[Updateable(false), Createable(false)]
		public string InfoUrl { get; set; }

		///<summary>
		/// IsUsingAdminAuthorization
		/// <para>Name: IsUsingAdminAuthorization</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isUsingAdminAuthorization")]
		[Updateable(false), Createable(false)]
		public bool? IsUsingAdminAuthorization { get; set; }

		///<summary>
		/// Mobile device OS platform
		/// <para>Name: MobilePlatform</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mobilePlatform")]
		[Updateable(false), Createable(false)]
		public string MobilePlatform { get; set; }

		///<summary>
		/// Minimum required mobile device OS version
		/// <para>Name: MobileMinOsVer</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mobileMinOsVer")]
		[Updateable(false), Createable(false)]
		public string MobileMinOsVer { get; set; }

		///<summary>
		/// Type of mobile device
		/// <para>Name: MobileDeviceType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mobileDeviceType")]
		[Updateable(false), Createable(false)]
		public string MobileDeviceType { get; set; }

		///<summary>
		/// App requires a registered mobile device
		/// <para>Name: IsRegisteredDeviceOnly</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isRegisteredDeviceOnly")]
		[Updateable(false), Createable(false)]
		public bool? IsRegisteredDeviceOnly { get; set; }

		///<summary>
		/// Version of the mobile app
		/// <para>Name: MobileAppVer</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mobileAppVer")]
		[Updateable(false), Createable(false)]
		public string MobileAppVer { get; set; }

		///<summary>
		/// Date the mobile app was most recently installed
		/// <para>Name: MobileAppInstalledDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mobileAppInstalledDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? MobileAppInstalledDate { get; set; }

		///<summary>
		/// Most recently installed version of the mobile app
		/// <para>Name: MobileAppInstalledVersion</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mobileAppInstalledVersion")]
		[Updateable(false), Createable(false)]
		public string MobileAppInstalledVersion { get; set; }

		///<summary>
		/// ID for the related mobile app binary
		/// <para>Name: MobileAppBinaryId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mobileAppBinaryId")]
		[Updateable(false), Createable(false)]
		public string MobileAppBinaryId { get; set; }

		///<summary>
		/// URL to install the mobile app
		/// <para>Name: MobileAppInstallUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mobileAppInstallUrl")]
		[Updateable(false), Createable(false)]
		public string MobileAppInstallUrl { get; set; }

		///<summary>
		/// Is this a canvas-enabled application
		/// <para>Name: CanvasEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "canvasEnabled")]
		[Updateable(false), Createable(false)]
		public bool? CanvasEnabled { get; set; }

		///<summary>
		/// The identifier used to render the canvas application.
		/// <para>Name: CanvasReferenceId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "canvasReferenceId")]
		[Updateable(false), Createable(false)]
		public string CanvasReferenceId { get; set; }

		///<summary>
		/// The canvas url for the canvas application
		/// <para>Name: CanvasUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "canvasUrl")]
		[Updateable(false), Createable(false)]
		public string CanvasUrl { get; set; }

		///<summary>
		/// The configured access method for the canvas application
		/// <para>Name: CanvasAccessMethod</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "canvasAccessMethod")]
		[Updateable(false), Createable(false)]
		public string CanvasAccessMethod { get; set; }

		///<summary>
		/// The selected/supported locations of the canvas application
		/// <para>Name: CanvasSelectedLocations</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "canvasSelectedLocations")]
		[Updateable(false), Createable(false)]
		public string CanvasSelectedLocations { get; set; }

		///<summary>
		/// The options to hide publisher header or publisher share button
		/// <para>Name: CanvasOptions</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "canvasOptions")]
		[Updateable(false), Createable(false)]
		public string CanvasOptions { get; set; }

		///<summary>
		/// App Type
		/// <para>Name: Type</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		[Updateable(false), Createable(false)]
		public string Type { get; set; }

		///<summary>
		/// Application ID
		/// <para>Name: ApplicationId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "applicationId")]
		[Updateable(false), Createable(false)]
		public string ApplicationId { get; set; }

		///<summary>
		/// User Sort Order
		/// <para>Name: UserSortOrder</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "userSortOrder")]
		[Updateable(false), Createable(false)]
		public int? UserSortOrder { get; set; }

		///<summary>
		/// Is Visible
		/// <para>Name: IsVisible</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isVisible")]
		[Updateable(true), Createable(false)]
		public bool? IsVisible { get; set; }

		///<summary>
		/// Is Accessible
		/// <para>Name: IsAccessible</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isAccessible")]
		[Updateable(false), Createable(false)]
		public bool? IsAccessible { get; set; }

	}
}
