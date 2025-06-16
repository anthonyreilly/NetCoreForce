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
	/// App Definition
	///<para>SObject Name: AppDefinition</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfAppDefinition : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "AppDefinition"; }
		}

		///<summary>
		/// App Definition ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Durable ID
		/// <para>Name: DurableId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "durableId")]
		[Updateable(false), Createable(false)]
		public string DurableId { get; set; }

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
		/// Master Label
		/// <para>Name: MasterLabel</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
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
		/// Developer Name
		/// <para>Name: DeveloperName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "developerName")]
		[Updateable(false), Createable(false)]
		public string DeveloperName { get; set; }

		///<summary>
		/// Logo URL
		/// <para>Name: LogoUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "logoUrl")]
		[Updateable(false), Createable(false)]
		public string LogoUrl { get; set; }

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
		/// UI Type
		/// <para>Name: UiType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "uiType")]
		[Updateable(false), Createable(false)]
		public string UiType { get; set; }

		///<summary>
		/// Navigation Type
		/// <para>Name: NavType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "navType")]
		[Updateable(false), Createable(false)]
		public string NavType { get; set; }

		///<summary>
		/// Utility Bar Name
		/// <para>Name: UtilityBar</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "utilityBar")]
		[Updateable(false), Createable(false)]
		public string UtilityBar { get; set; }

		///<summary>
		/// Header Color
		/// <para>Name: HeaderColor</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "headerColor")]
		[Updateable(false), Createable(false)]
		public string HeaderColor { get; set; }

		///<summary>
		/// Is Org Theme Overridden
		/// <para>Name: IsOverrideOrgTheme</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isOverrideOrgTheme")]
		[Updateable(false), Createable(false)]
		public bool? IsOverrideOrgTheme { get; set; }

		///<summary>
		/// Is Small Form Factor Supported
		/// <para>Name: IsSmallFormFactorSupported</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isSmallFormFactorSupported")]
		[Updateable(false), Createable(false)]
		public bool? IsSmallFormFactorSupported { get; set; }

		///<summary>
		/// Is Medium Form Factor Supported
		/// <para>Name: IsMediumFormFactorSupported</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isMediumFormFactorSupported")]
		[Updateable(false), Createable(false)]
		public bool? IsMediumFormFactorSupported { get; set; }

		///<summary>
		/// Is Large Form Factor Supported
		/// <para>Name: IsLargeFormFactorSupported</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isLargeFormFactorSupported")]
		[Updateable(false), Createable(false)]
		public bool? IsLargeFormFactorSupported { get; set; }

		///<summary>
		/// Is Navigation Menu Personalization Disabled
		/// <para>Name: IsNavPersonalizationDisabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isNavPersonalizationDisabled")]
		[Updateable(false), Createable(false)]
		public bool? IsNavPersonalizationDisabled { get; set; }

		///<summary>
		/// Is Navigation Menu Automatically Create Temporary Tabs Disabled
		/// <para>Name: IsNavAutoTempTabsDisabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isNavAutoTempTabsDisabled")]
		[Updateable(false), Createable(false)]
		public bool? IsNavAutoTempTabsDisabled { get; set; }

		///<summary>
		/// Is Clearing Workspace Tabs Enabled
		/// <para>Name: IsNavTabPersistenceDisabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isNavTabPersistenceDisabled")]
		[Updateable(false), Createable(false)]
		public bool? IsNavTabPersistenceDisabled { get; set; }

		///<summary>
		/// Is Omni-Channel Sidebar Enabled
		/// <para>Name: IsOmniPinnedViewEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isOmniPinnedViewEnabled")]
		[Updateable(false), Createable(false)]
		public bool? IsOmniPinnedViewEnabled { get; set; }

	}
}
