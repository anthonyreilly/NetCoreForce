// SF API version v64.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Organization Email Address Security
	///<para>SObject Name: OrgEmailAddressSecurity</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfOrgEmailAddressSecurity : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "OrgEmailAddressSecurity"; }
		}

		///<summary>
		/// Organization Email Address Security ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Profile ID
		/// <para>Name: ParentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "parentId")]
		[Updateable(false), Createable(true)]
		public string ParentId { get; set; }

		///<summary>
		/// ReferenceTo: Profile
		/// <para>RelationshipName: Parent</para>
		///</summary>
		[JsonProperty(PropertyName = "parent")]
		[Updateable(false), Createable(false)]
		public SfProfile Parent { get; set; }

		///<summary>
		/// Organization-wide From Email Address ID
		/// <para>Name: OrgWideEmailAddressId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "orgWideEmailAddressId")]
		[Updateable(false), Createable(true)]
		public string OrgWideEmailAddressId { get; set; }

		///<summary>
		/// ReferenceTo: OrgWideEmailAddress
		/// <para>RelationshipName: OrgWideEmailAddress</para>
		///</summary>
		[JsonProperty(PropertyName = "orgWideEmailAddress")]
		[Updateable(false), Createable(false)]
		public SfOrgWideEmailAddress OrgWideEmailAddress { get; set; }

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
