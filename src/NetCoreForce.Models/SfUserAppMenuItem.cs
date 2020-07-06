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
	/// Application
	///<para>SObject Name: UserAppMenuItem</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfUserAppMenuItem : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "UserAppMenuItem"; }
		}

		///<summary>
		/// Application ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// AppMenuItem ID
		/// <para>Name: AppMenuItemId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "appMenuItemId")]
		[Updateable(false), Createable(false)]
		public string AppMenuItemId { get; set; }

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
		/// Name
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
		/// Developer Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
		public string Name { get; set; }

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
		/// Sort Order
		/// <para>Name: SortOrder</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sortOrder")]
		[Updateable(false), Createable(false)]
		public int? SortOrder { get; set; }

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
		/// Is Visible
		/// <para>Name: IsVisible</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isVisible")]
		[Updateable(false), Createable(false)]
		public bool? IsVisible { get; set; }

		///<summary>
		/// IsUsingAdminAuthorization
		/// <para>Name: IsUsingAdminAuthorization</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isUsingAdminAuthorization")]
		[Updateable(false), Createable(false)]
		public bool? IsUsingAdminAuthorization { get; set; }

	}
}
