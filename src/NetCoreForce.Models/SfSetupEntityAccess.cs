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
	/// Setup Entity Access
	///<para>SObject Name: SetupEntityAccess</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfSetupEntityAccess : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "SetupEntityAccess"; }
		}

		///<summary>
		/// SetupEntityAccess ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Parent ID
		/// <para>Name: ParentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "parentId")]
		[Updateable(false), Createable(true)]
		public string ParentId { get; set; }

		///<summary>
		/// ReferenceTo: PermissionSet
		/// <para>RelationshipName: Parent</para>
		///</summary>
		[JsonProperty(PropertyName = "parent")]
		[Updateable(false), Createable(false)]
		public SfPermissionSet Parent { get; set; }

		///<summary>
		/// Setup Entity ID
		/// <para>Name: SetupEntityId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "setupEntityId")]
		[Updateable(false), Createable(true)]
		public string SetupEntityId { get; set; }

		///<summary>
		/// Setup Entity Type
		/// <para>Name: SetupEntityType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "setupEntityType")]
		[Updateable(false), Createable(false)]
		public string SetupEntityType { get; set; }

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
