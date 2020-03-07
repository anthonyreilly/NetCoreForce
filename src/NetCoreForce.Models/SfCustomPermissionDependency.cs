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
	/// Custom Permission Dependency
	///<para>SObject Name: CustomPermissionDependency</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfCustomPermissionDependency : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "CustomPermissionDependency"; }
		}

		///<summary>
		/// Custom Permission Dependency ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Creatable(false)]
		public bool? IsDeleted { get; set; }

		///<summary>
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

		///<summary>
		/// Created By ID
		/// <para>Name: CreatedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdById")]
		[Updateable(false), Creatable(false)]
		public string CreatedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: CreatedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "createdBy")]
		[Updateable(false), Creatable(false)]
		public SfUser CreatedBy { get; set; }

		///<summary>
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

		///<summary>
		/// Last Modified By ID
		/// <para>Name: LastModifiedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedById")]
		[Updateable(false), Creatable(false)]
		public string LastModifiedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: LastModifiedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedBy")]
		[Updateable(false), Creatable(false)]
		public SfUser LastModifiedBy { get; set; }

		///<summary>
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

		///<summary>
		/// Custom Permission ID
		/// <para>Name: CustomPermissionId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "customPermissionId")]
		[Updateable(false), Creatable(false)]
		public string CustomPermissionId { get; set; }

		///<summary>
		/// ReferenceTo: CustomPermission
		/// <para>RelationshipName: CustomPermission</para>
		///</summary>
		[JsonProperty(PropertyName = "customPermission")]
		[Updateable(false), Creatable(false)]
		public SfCustomPermission CustomPermission { get; set; }

		///<summary>
		/// Custom Permission ID
		/// <para>Name: RequiredCustomPermissionId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "requiredCustomPermissionId")]
		[Updateable(false), Creatable(false)]
		public string RequiredCustomPermissionId { get; set; }

		///<summary>
		/// ReferenceTo: CustomPermission
		/// <para>RelationshipName: RequiredCustomPermission</para>
		///</summary>
		[JsonProperty(PropertyName = "requiredCustomPermission")]
		[Updateable(false), Creatable(false)]
		public SfCustomPermission RequiredCustomPermission { get; set; }

	}
}
