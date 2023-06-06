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
	/// Content Folder Item
	///<para>SObject Name: ContentFolderItem</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfContentFolderItem : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ContentFolderItem"; }
		}

		///<summary>
		/// Content Folder Item ID
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
		/// Is Folder
		/// <para>Name: IsFolder</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFolder")]
		[Updateable(false), Createable(false)]
		public bool? IsFolder { get; set; }

		///<summary>
		/// Parent Content Folder ID
		/// <para>Name: ParentContentFolderId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "parentContentFolderId")]
		[Updateable(false), Createable(false)]
		public string ParentContentFolderId { get; set; }

		///<summary>
		/// ReferenceTo: ContentFolder
		/// <para>RelationshipName: ParentContentFolder</para>
		///</summary>
		[JsonProperty(PropertyName = "parentContentFolder")]
		[Updateable(false), Createable(false)]
		public SfContentFolder ParentContentFolder { get; set; }

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
		/// File Type
		/// <para>Name: FileType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fileType")]
		[Updateable(false), Createable(false)]
		public string FileType { get; set; }

		///<summary>
		/// Size
		/// <para>Name: ContentSize</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contentSize")]
		[Updateable(false), Createable(false)]
		public int? ContentSize { get; set; }

		///<summary>
		/// File Extension
		/// <para>Name: FileExtension</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fileExtension")]
		[Updateable(false), Createable(false)]
		public string FileExtension { get; set; }

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
