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
	/// Library Member
	///<para>SObject Name: ContentWorkspaceMember</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfContentWorkspaceMember : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ContentWorkspaceMember"; }
		}

		///<summary>
		/// Library Member ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Library ID
		/// <para>Name: ContentWorkspaceId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "contentWorkspaceId")]
		[Updateable(false), Createable(true)]
		public string ContentWorkspaceId { get; set; }

		///<summary>
		/// ReferenceTo: ContentWorkspace
		/// <para>RelationshipName: ContentWorkspace</para>
		///</summary>
		[JsonProperty(PropertyName = "contentWorkspace")]
		[Updateable(false), Createable(false)]
		public SfContentWorkspace ContentWorkspace { get; set; }

		///<summary>
		/// Library Permission ID
		/// <para>Name: ContentWorkspacePermissionId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contentWorkspacePermissionId")]
		public string ContentWorkspacePermissionId { get; set; }

		///<summary>
		/// ReferenceTo: ContentWorkspacePermission
		/// <para>RelationshipName: ContentWorkspacePermission</para>
		///</summary>
		[JsonProperty(PropertyName = "contentWorkspacePermission")]
		[Updateable(false), Createable(false)]
		public SfContentWorkspacePermission ContentWorkspacePermission { get; set; }

		///<summary>
		/// Member ID
		/// <para>Name: MemberId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "memberId")]
		[Updateable(false), Createable(true)]
		public string MemberId { get; set; }

		///<summary>
		/// Member Type
		/// <para>Name: MemberType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "memberType")]
		[Updateable(false), Createable(false)]
		public string MemberType { get; set; }

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

	}
}
