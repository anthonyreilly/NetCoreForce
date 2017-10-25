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
	/// Library Permission
	///<para>SObject Name: ContentWorkspacePermission</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfContentWorkspacePermission : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ContentWorkspacePermission"; }
		}

		///<summary>
		/// Library Permission ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		///<summary>
		/// Type
		/// <para>Name: Type</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		[Updateable(false), Createable(false)]
		public string Type { get; set; }

		///<summary>
		/// Manage Library
		/// <para>Name: PermissionsManageWorkspace</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsManageWorkspace")]
		public bool? PermissionsManageWorkspace { get; set; }

		///<summary>
		/// Add Content
		/// <para>Name: PermissionsAddContent</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAddContent")]
		public bool? PermissionsAddContent { get; set; }

		///<summary>
		/// Add Content on Behalf of Others
		/// <para>Name: PermissionsAddContentOBO</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAddContentOBO")]
		public bool? PermissionsAddContentOBO { get; set; }

		///<summary>
		/// Archive Content
		/// <para>Name: PermissionsArchiveContent</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsArchiveContent")]
		public bool? PermissionsArchiveContent { get; set; }

		///<summary>
		/// Delete Content
		/// <para>Name: PermissionsDeleteContent</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsDeleteContent")]
		public bool? PermissionsDeleteContent { get; set; }

		///<summary>
		/// Feature Content
		/// <para>Name: PermissionsFeatureContent</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsFeatureContent")]
		public bool? PermissionsFeatureContent { get; set; }

		///<summary>
		/// View Comment
		/// <para>Name: PermissionsViewComments</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsViewComments")]
		public bool? PermissionsViewComments { get; set; }

		///<summary>
		/// Add Comment
		/// <para>Name: PermissionsAddComment</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsAddComment")]
		public bool? PermissionsAddComment { get; set; }

		///<summary>
		/// Modify Comments
		/// <para>Name: PermissionsModifyComments</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsModifyComments")]
		public bool? PermissionsModifyComments { get; set; }

		///<summary>
		/// Tag Content
		/// <para>Name: PermissionsTagContent</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsTagContent")]
		public bool? PermissionsTagContent { get; set; }

		///<summary>
		/// Deliver Content
		/// <para>Name: PermissionsDeliverContent</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsDeliverContent")]
		public bool? PermissionsDeliverContent { get; set; }

		///<summary>
		/// Attach or Share Content
		/// <para>Name: PermissionsChatterSharing</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsChatterSharing")]
		public bool? PermissionsChatterSharing { get; set; }

		///<summary>
		/// Organize File and Content Folder
		/// <para>Name: PermissionsOrganizeFileAndFolder</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionsOrganizeFileAndFolder")]
		public bool? PermissionsOrganizeFileAndFolder { get; set; }

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
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

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
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

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
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

	}
}
