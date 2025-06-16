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
	/// Recently Viewed
	///<para>SObject Name: RecentlyViewed</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfRecentlyViewed : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "RecentlyViewed"; }
		}

		///<summary>
		/// Recently Viewed ID
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
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
		public string Name { get; set; }

		///<summary>
		/// Last Name
		/// <para>Name: LastName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastName")]
		[Updateable(false), Createable(false)]
		public string LastName { get; set; }

		///<summary>
		/// First Name
		/// <para>Name: FirstName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "firstName")]
		[Updateable(false), Createable(false)]
		public string FirstName { get; set; }

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
		/// Alias
		/// <para>Name: Alias</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "alias")]
		[Updateable(false), Createable(false)]
		public string Alias { get; set; }

		///<summary>
		/// Role ID
		/// <para>Name: UserRoleId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "userRoleId")]
		[Updateable(false), Createable(false)]
		public string UserRoleId { get; set; }

		///<summary>
		/// ReferenceTo: UserRole
		/// <para>RelationshipName: UserRole</para>
		///</summary>
		[JsonProperty(PropertyName = "userRole")]
		[Updateable(false), Createable(false)]
		public SfUserRole UserRole { get; set; }

		///<summary>
		/// Record Type ID
		/// <para>Name: RecordTypeId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recordTypeId")]
		[Updateable(false), Createable(false)]
		public string RecordTypeId { get; set; }

		///<summary>
		/// ReferenceTo: RecordType
		/// <para>RelationshipName: RecordType</para>
		///</summary>
		[JsonProperty(PropertyName = "recordType")]
		[Updateable(false), Createable(false)]
		public SfRecordType RecordType { get; set; }

		///<summary>
		/// Active
		/// <para>Name: IsActive</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isActive")]
		[Updateable(false), Createable(false)]
		public bool? IsActive { get; set; }

		///<summary>
		/// Profile ID
		/// <para>Name: ProfileId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "profileId")]
		[Updateable(false), Createable(false)]
		public string ProfileId { get; set; }

		///<summary>
		/// ReferenceTo: Profile
		/// <para>RelationshipName: Profile</para>
		///</summary>
		[JsonProperty(PropertyName = "profile")]
		[Updateable(false), Createable(false)]
		public SfProfile Profile { get; set; }

		///<summary>
		/// Title
		/// <para>Name: Title</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "title")]
		[Updateable(false), Createable(false)]
		public string Title { get; set; }

		///<summary>
		/// Email
		/// <para>Name: Email</para>
		/// <para>SF Type: email</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "email")]
		[Updateable(false), Createable(false)]
		public string Email { get; set; }

		///<summary>
		/// Phone
		/// <para>Name: Phone</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "phone")]
		[Updateable(false), Createable(false)]
		public string Phone { get; set; }

		///<summary>
		/// Name or Alias
		/// <para>Name: NameOrAlias</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "nameOrAlias")]
		[Updateable(false), Createable(false)]
		public string NameOrAlias { get; set; }

		///<summary>
		/// Last Viewed Date
		/// <para>Name: LastViewedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastViewedDate")]
		[Updateable(true), Createable(false)]
		public DateTimeOffset? LastViewedDate { get; set; }

		///<summary>
		/// Last Referenced Date
		/// <para>Name: LastReferencedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastReferencedDate")]
		[Updateable(true), Createable(false)]
		public DateTimeOffset? LastReferencedDate { get; set; }

		///<summary>
		/// Language
		/// <para>Name: Language</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "language")]
		[Updateable(false), Createable(false)]
		public string Language { get; set; }

	}
}
