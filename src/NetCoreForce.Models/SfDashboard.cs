// SF API version v57.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Dashboard
	///<para>SObject Name: Dashboard</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfDashboard : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "Dashboard"; }
		}

		///<summary>
		/// Dashboard ID
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
		/// Folder ID
		/// <para>Name: FolderId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "folderId")]
		[Updateable(false), Createable(false)]
		public string FolderId { get; set; }

		///<summary>
		/// Folder Name
		/// <para>Name: FolderName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "folderName")]
		[Updateable(false), Createable(false)]
		public string FolderName { get; set; }

		///<summary>
		/// Title
		/// <para>Name: Title</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "title")]
		[Updateable(false), Createable(false)]
		public string Title { get; set; }

		///<summary>
		/// Dashboard Unique Name
		/// <para>Name: DeveloperName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "developerName")]
		[Updateable(false), Createable(false)]
		public string DeveloperName { get; set; }

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
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		[Updateable(false), Createable(false)]
		public string Description { get; set; }

		///<summary>
		/// Left Size
		/// <para>Name: LeftSize</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "leftSize")]
		[Updateable(false), Createable(false)]
		public string LeftSize { get; set; }

		///<summary>
		/// Middle Size
		/// <para>Name: MiddleSize</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "middleSize")]
		[Updateable(false), Createable(false)]
		public string MiddleSize { get; set; }

		///<summary>
		/// Right Size
		/// <para>Name: RightSize</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "rightSize")]
		[Updateable(false), Createable(false)]
		public string RightSize { get; set; }

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
		/// Running User ID
		/// <para>Name: RunningUserId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "runningUserId")]
		[Updateable(false), Createable(false)]
		public string RunningUserId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: RunningUser</para>
		///</summary>
		[JsonProperty(PropertyName = "runningUser")]
		[Updateable(false), Createable(false)]
		public SfUser RunningUser { get; set; }

		///<summary>
		/// Title Color
		/// <para>Name: TitleColor</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "titleColor")]
		[Updateable(false), Createable(false)]
		public int? TitleColor { get; set; }

		///<summary>
		/// Title Size
		/// <para>Name: TitleSize</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "titleSize")]
		[Updateable(false), Createable(false)]
		public int? TitleSize { get; set; }

		///<summary>
		/// Text Color
		/// <para>Name: TextColor</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "textColor")]
		[Updateable(false), Createable(false)]
		public int? TextColor { get; set; }

		///<summary>
		/// Starting Color
		/// <para>Name: BackgroundStart</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "backgroundStart")]
		[Updateable(false), Createable(false)]
		public int? BackgroundStart { get; set; }

		///<summary>
		/// Ending Color
		/// <para>Name: BackgroundEnd</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "backgroundEnd")]
		[Updateable(false), Createable(false)]
		public int? BackgroundEnd { get; set; }

		///<summary>
		/// Background Fade Direction
		/// <para>Name: BackgroundDirection</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "backgroundDirection")]
		[Updateable(false), Createable(false)]
		public string BackgroundDirection { get; set; }

		///<summary>
		/// Dashboard Running User
		/// <para>Name: Type</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		[Updateable(false), Createable(false)]
		public string Type { get; set; }

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
		/// Last refreshed for this user
		/// <para>Name: DashboardResultRefreshedDate</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dashboardResultRefreshedDate")]
		[Updateable(false), Createable(false)]
		public string DashboardResultRefreshedDate { get; set; }

		///<summary>
		/// Running as
		/// <para>Name: DashboardResultRunningUser</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dashboardResultRunningUser")]
		[Updateable(false), Createable(false)]
		public string DashboardResultRunningUser { get; set; }

		///<summary>
		/// Color Palette
		/// <para>Name: ColorPalette</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "colorPalette")]
		[Updateable(false), Createable(false)]
		public string ColorPalette { get; set; }

		///<summary>
		/// Chart Background
		/// <para>Name: ChartTheme</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "chartTheme")]
		[Updateable(false), Createable(false)]
		public string ChartTheme { get; set; }

	}
}
