// SF API version v39.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Content Folder Link
	///<para>SObject Name: ContentFolderLink</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfContentFolderLink : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ContentFolderLink"; }
		}

		///<summary>
		/// Content Folder Link ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Parent Entity ID
		/// <para>Name: ParentEntityId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "parentEntityId")]
		[Updateable(false), Createable(false)]
		public string ParentEntityId { get; set; }

		///<summary>
		/// Content Folder ID
		/// <para>Name: ContentFolderId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "contentFolderId")]
		[Updateable(false), Createable(false)]
		public string ContentFolderId { get; set; }

		///<summary>
		/// ReferenceTo: ContentFolder
		/// <para>RelationshipName: ContentFolder</para>
		///</summary>
		[JsonProperty(PropertyName = "contentFolder")]
		[Updateable(false), Createable(false)]
		public SfContentFolder ContentFolder { get; set; }

		///<summary>
		/// Is Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Createable(false)]
		public bool? IsDeleted { get; set; }

		///<summary>
		/// Enable Folder Status
		/// <para>Name: EnableFolderStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "enableFolderStatus")]
		[Updateable(false), Createable(false)]
		public string EnableFolderStatus { get; set; }

	}
}
