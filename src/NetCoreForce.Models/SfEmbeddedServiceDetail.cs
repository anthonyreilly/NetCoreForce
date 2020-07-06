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
	/// Embedded Service
	///<para>SObject Name: EmbeddedServiceDetail</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfEmbeddedServiceDetail : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "EmbeddedServiceDetail"; }
		}

		///<summary>
		/// Embedded Service ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Embedded Service Durable ID
		/// <para>Name: DurableId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "durableId")]
		[Updateable(false), Createable(false)]
		public string DurableId { get; set; }

		///<summary>
		/// Site
		/// <para>Name: Site</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "site")]
		[Updateable(false), Createable(false)]
		public string Site { get; set; }

		///<summary>
		/// Primary Color
		/// <para>Name: PrimaryColor</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "primaryColor")]
		[Updateable(false), Createable(false)]
		public string PrimaryColor { get; set; }

		///<summary>
		/// Secondary Color
		/// <para>Name: SecondaryColor</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "secondaryColor")]
		[Updateable(false), Createable(false)]
		public string SecondaryColor { get; set; }

		///<summary>
		/// Contrast Primary Color
		/// <para>Name: ContrastPrimaryColor</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contrastPrimaryColor")]
		[Updateable(false), Createable(false)]
		public string ContrastPrimaryColor { get; set; }

		///<summary>
		/// Contrast Inverted Color
		/// <para>Name: ContrastInvertedColor</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contrastInvertedColor")]
		[Updateable(false), Createable(false)]
		public string ContrastInvertedColor { get; set; }

		///<summary>
		/// NavBar Color
		/// <para>Name: NavBarColor</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "navBarColor")]
		[Updateable(false), Createable(false)]
		public string NavBarColor { get; set; }

		///<summary>
		/// Font
		/// <para>Name: Font</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "font")]
		[Updateable(false), Createable(false)]
		public string Font { get; set; }

		///<summary>
		/// Enabled
		/// <para>Name: IsLiveAgentEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isLiveAgentEnabled")]
		[Updateable(false), Createable(false)]
		public bool? IsLiveAgentEnabled { get; set; }

		///<summary>
		/// Enabled
		/// <para>Name: IsFieldServiceEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFieldServiceEnabled")]
		[Updateable(false), Createable(false)]
		public bool? IsFieldServiceEnabled { get; set; }

		///<summary>
		/// Width
		/// <para>Name: Width</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "width")]
		[Updateable(false), Createable(false)]
		public int? Width { get; set; }

		///<summary>
		/// Height
		/// <para>Name: Height</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "height")]
		[Updateable(false), Createable(false)]
		public int? Height { get; set; }

		///<summary>
		/// Pre-Chat Enabled
		/// <para>Name: IsPrechatEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isPrechatEnabled")]
		[Updateable(false), Createable(false)]
		public bool? IsPrechatEnabled { get; set; }

		///<summary>
		/// Custom Prechat Component Developer Name
		/// <para>Name: CustomPrechatComponent</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "customPrechatComponent")]
		[Updateable(false), Createable(false)]
		public string CustomPrechatComponent { get; set; }

		///<summary>
		/// Avatar Image URL
		/// <para>Name: AvatarImg</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "avatarImg")]
		[Updateable(false), Createable(false)]
		public string AvatarImg { get; set; }

		///<summary>
		/// Small Company Logo Image URL
		/// <para>Name: SmallCompanyLogoImg</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "smallCompanyLogoImg")]
		[Updateable(false), Createable(false)]
		public string SmallCompanyLogoImg { get; set; }

		///<summary>
		/// Prechat Background Image URL
		/// <para>Name: PrechatBackgroundImg</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "prechatBackgroundImg")]
		[Updateable(false), Createable(false)]
		public string PrechatBackgroundImg { get; set; }

		///<summary>
		/// Waiting State Background Image URL
		/// <para>Name: WaitingStateBackgroundImg</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "waitingStateBackgroundImg")]
		[Updateable(false), Createable(false)]
		public string WaitingStateBackgroundImg { get; set; }

		///<summary>
		/// Header Background Image URL
		/// <para>Name: HeaderBackgroundImg</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "headerBackgroundImg")]
		[Updateable(false), Createable(false)]
		public string HeaderBackgroundImg { get; set; }

		///<summary>
		/// Font Size
		/// <para>Name: FontSize</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fontSize")]
		[Updateable(false), Createable(false)]
		public string FontSize { get; set; }

		///<summary>
		/// Offline Case Background Image URL
		/// <para>Name: OfflineCaseBackgroundImg</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "offlineCaseBackgroundImg")]
		[Updateable(false), Createable(false)]
		public string OfflineCaseBackgroundImg { get; set; }

		///<summary>
		/// Offline Case Enabled
		/// <para>Name: IsOfflineCaseEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isOfflineCaseEnabled")]
		[Updateable(false), Createable(false)]
		public bool? IsOfflineCaseEnabled { get; set; }

		///<summary>
		/// Queue Position Enabled
		/// <para>Name: IsQueuePositionEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isQueuePositionEnabled")]
		[Updateable(false), Createable(false)]
		public bool? IsQueuePositionEnabled { get; set; }

		///<summary>
		/// Show New Appointment
		/// <para>Name: ShouldShowNewAppointment</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "shouldShowNewAppointment")]
		[Updateable(false), Createable(false)]
		public bool? ShouldShowNewAppointment { get; set; }

		///<summary>
		/// Show Existing Appointment
		/// <para>Name: ShouldShowExistingAppointment</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "shouldShowExistingAppointment")]
		[Updateable(false), Createable(false)]
		public bool? ShouldShowExistingAppointment { get; set; }

		///<summary>
		/// Appointment Booking Flow Name Flow Definition
		/// <para>Name: FlowDeveloperName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "flowDeveloperName")]
		[Updateable(false), Createable(false)]
		public string FlowDeveloperName { get; set; }

		///<summary>
		/// Modify Appointment Booking Flow Name Flow Definition
		/// <para>Name: ModifyApptBookingFlowName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "modifyApptBookingFlowName")]
		[Updateable(false), Createable(false)]
		public string ModifyApptBookingFlowName { get; set; }

		///<summary>
		/// Cancel Appointment Booking Flow Name Flow Definition
		/// <para>Name: CancelApptBookingFlowName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "cancelApptBookingFlowName")]
		[Updateable(false), Createable(false)]
		public string CancelApptBookingFlowName { get; set; }

		///<summary>
		/// Field Service Home Image URL
		/// <para>Name: FieldServiceHomeImg</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fieldServiceHomeImg")]
		[Updateable(false), Createable(false)]
		public string FieldServiceHomeImg { get; set; }

		///<summary>
		/// Field Service Logo Image URL
		/// <para>Name: FieldServiceLogoImg</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fieldServiceLogoImg")]
		[Updateable(false), Createable(false)]
		public string FieldServiceLogoImg { get; set; }

		///<summary>
		/// Field Service Confirmation Card Image URL
		/// <para>Name: FieldServiceConfirmCardImg</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fieldServiceConfirmCardImg")]
		[Updateable(false), Createable(false)]
		public string FieldServiceConfirmCardImg { get; set; }

		///<summary>
		/// Hide Authentication Dialog
		/// <para>Name: ShouldHideAuthDialog</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "shouldHideAuthDialog")]
		[Updateable(false), Createable(false)]
		public bool? ShouldHideAuthDialog { get; set; }

		///<summary>
		/// Custom Minimized Component Developer Name
		/// <para>Name: CustomMinimizedComponent</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "customMinimizedComponent")]
		[Updateable(false), Createable(false)]
		public string CustomMinimizedComponent { get; set; }

	}
}
