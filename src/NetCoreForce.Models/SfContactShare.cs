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
	/// Contact Share
	///<para>SObject Name: ContactShare</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfContactShare : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ContactShare"; }
		}

		///<summary>
		/// Contact Share ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Contact ID
		/// <para>Name: ContactId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "contactId")]
		[Updateable(false), Createable(false)]
		public string ContactId { get; set; }

		///<summary>
		/// ReferenceTo: Contact
		/// <para>RelationshipName: Contact</para>
		///</summary>
		[JsonProperty(PropertyName = "contact")]
		[Updateable(false), Createable(false)]
		public SfContact Contact { get; set; }

		///<summary>
		/// User/Group ID
		/// <para>Name: UserOrGroupId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userOrGroupId")]
		[Updateable(false), Createable(false)]
		public string UserOrGroupId { get; set; }

		///<summary>
		/// Contact Access
		/// <para>Name: ContactAccessLevel</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "contactAccessLevel")]
		[Updateable(false), Createable(false)]
		public string ContactAccessLevel { get; set; }

		///<summary>
		/// Row Cause
		/// <para>Name: RowCause</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "rowCause")]
		[Updateable(false), Createable(false)]
		public string RowCause { get; set; }

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
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Createable(false)]
		public bool? IsDeleted { get; set; }

	}
}
