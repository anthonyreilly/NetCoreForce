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
	/// Prompt Version
	///<para>SObject Name: PromptVersion</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfPromptVersion : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "PromptVersion"; }
		}

		///<summary>
		/// Prompt Version ID
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
		/// Prompt ID
		/// <para>Name: ParentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "parentId")]
		[Updateable(false), Createable(true)]
		public string ParentId { get; set; }

		///<summary>
		/// ReferenceTo: Prompt
		/// <para>RelationshipName: Parent</para>
		///</summary>
		[JsonProperty(PropertyName = "parent")]
		[Updateable(false), Createable(false)]
		public SfPrompt Parent { get; set; }

		///<summary>
		/// Master Label
		/// <para>Name: MasterLabel</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "masterLabel")]
		public string MasterLabel { get; set; }

		///<summary>
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

		///<summary>
		/// Type
		/// <para>Name: DisplayType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "displayType")]
		public string DisplayType { get; set; }

		///<summary>
		/// Position
		/// <para>Name: DisplayPosition</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "displayPosition")]
		public string DisplayPosition { get; set; }

		///<summary>
		/// Number Of Times To Repeat
		/// <para>Name: TimesToDisplay</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "timesToDisplay")]
		public int? TimesToDisplay { get; set; }

		///<summary>
		/// Days In Between Displays
		/// <para>Name: DelayDays</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "delayDays")]
		public int? DelayDays { get; set; }

		///<summary>
		/// Start Date
		/// <para>Name: StartDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "startDate")]
		public DateTime? StartDate { get; set; }

		///<summary>
		/// End Date
		/// <para>Name: EndDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "endDate")]
		public DateTime? EndDate { get; set; }

		///<summary>
		/// Access Permissions
		/// <para>Name: UserAccess</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "userAccess")]
		public string UserAccess { get; set; }

		///<summary>
		/// Is Active
		/// <para>Name: IsPublished</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isPublished")]
		public bool? IsPublished { get; set; }

		///<summary>
		/// Active Date
		/// <para>Name: PublishedDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "publishedDate")]
		public DateTime? PublishedDate { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: PublishedByUserId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "publishedByUserId")]
		public string PublishedByUserId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: PublishedByUser</para>
		///</summary>
		[JsonProperty(PropertyName = "publishedByUser")]
		[Updateable(false), Createable(false)]
		public SfUser PublishedByUser { get; set; }

		///<summary>
		/// Header
		/// <para>Name: Header</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "header")]
		public string Header { get; set; }

		///<summary>
		/// Dismiss Button Label
		/// <para>Name: DismissButtonLabel</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dismissButtonLabel")]
		public string DismissButtonLabel { get; set; }

		///<summary>
		/// Display Action Button
		/// <para>Name: ShouldDisplayActionButton</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "shouldDisplayActionButton")]
		public bool? ShouldDisplayActionButton { get; set; }

		///<summary>
		/// Action Button Label
		/// <para>Name: ActionButtonLabel</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "actionButtonLabel")]
		public string ActionButtonLabel { get; set; }

		///<summary>
		/// Action Button URL
		/// <para>Name: ActionButtonLink</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "actionButtonLink")]
		public string ActionButtonLink { get; set; }

		///<summary>
		/// Title Label
		/// <para>Name: Title</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "title")]
		public string Title { get; set; }

		///<summary>
		/// Version Number
		/// <para>Name: VersionNumber</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "versionNumber")]
		public int? VersionNumber { get; set; }

		///<summary>
		/// Target Page Type
		/// <para>Name: TargetPageType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "targetPageType")]
		public string TargetPageType { get; set; }

		///<summary>
		/// Target Page Key 1
		/// <para>Name: TargetPageKey1</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "targetPageKey1")]
		public string TargetPageKey1 { get; set; }

		///<summary>
		/// Target Page Key 2
		/// <para>Name: TargetPageKey2</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "targetPageKey2")]
		public string TargetPageKey2 { get; set; }

		///<summary>
		/// Target Application Namespace Prefix
		/// <para>Name: TargetAppNamespacePrefix</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "targetAppNamespacePrefix")]
		public string TargetAppNamespacePrefix { get; set; }

		///<summary>
		/// Target Application Developer Name
		/// <para>Name: TargetAppDeveloperName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "targetAppDeveloperName")]
		public string TargetAppDeveloperName { get; set; }

		///<summary>
		/// Body
		/// <para>Name: Body</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "body")]
		public string Body { get; set; }

		///<summary>
		/// Ignore Global Delay
		/// <para>Name: ShouldIgnoreGlobalDelay</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "shouldIgnoreGlobalDelay")]
		public bool? ShouldIgnoreGlobalDelay { get; set; }

		///<summary>
		/// Access Profiles
		/// <para>Name: UserProfileAccess</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "userProfileAccess")]
		public string UserProfileAccess { get; set; }

		///<summary>
		/// Video URL
		/// <para>Name: VideoLink</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "videoLink")]
		public string VideoLink { get; set; }

		///<summary>
		/// Step Number
		/// <para>Name: StepNumber</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "stepNumber")]
		public int? StepNumber { get; set; }

		///<summary>
		/// Theme Color
		/// <para>Name: ThemeColor</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "themeColor")]
		public string ThemeColor { get; set; }

		///<summary>
		/// Theme Saturation
		/// <para>Name: ThemeSaturation</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "themeSaturation")]
		public string ThemeSaturation { get; set; }

		///<summary>
		/// Index Formula Field With Is Published Data
		/// <para>Name: IndexWithIsPublished</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "indexWithIsPublished")]
		[Updateable(false), Createable(false)]
		public string IndexWithIsPublished { get; set; }

		///<summary>
		/// Index Formula Field Without Is Published Data
		/// <para>Name: IndexWithoutIsPublished</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "indexWithoutIsPublished")]
		[Updateable(false), Createable(false)]
		public string IndexWithoutIsPublished { get; set; }

	}
}
