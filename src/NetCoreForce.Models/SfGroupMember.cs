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
	/// Group Member
	///<para>SObject Name: GroupMember</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfGroupMember : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "GroupMember"; }
		}

		///<summary>
		/// Group Member ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Group ID
		/// <para>Name: GroupId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "groupId")]
		[Updateable(false), Createable(true)]
		public string GroupId { get; set; }

		///<summary>
		/// ReferenceTo: Group
		/// <para>RelationshipName: Group</para>
		///</summary>
		[JsonProperty(PropertyName = "group")]
		[Updateable(false), Createable(false)]
		public SfGroup Group { get; set; }

		///<summary>
		/// User/Group ID
		/// <para>Name: UserOrGroupId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userOrGroupId")]
		[Updateable(false), Createable(true)]
		public string UserOrGroupId { get; set; }

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
