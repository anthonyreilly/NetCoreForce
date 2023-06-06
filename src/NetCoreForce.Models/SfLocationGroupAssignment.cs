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
	/// Location Group Assignment
	///<para>SObject Name: LocationGroupAssignment</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfLocationGroupAssignment : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "LocationGroupAssignment"; }
		}

		///<summary>
		/// Location Group Assignment ID
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
		/// Location Group Assignment Name
		/// <para>Name: LocationGroupAssignment</para>
		/// <para>SF Type: string</para>
		/// <para>AutoNumber field</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "locationGroupAssignment")]
		[Updateable(false), Createable(false)]
		public string LocationGroupAssignment { get; set; }

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

		///<summary>
		/// Last Viewed Date
		/// <para>Name: LastViewedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastViewedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastViewedDate { get; set; }

		///<summary>
		/// Last Referenced Date
		/// <para>Name: LastReferencedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastReferencedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastReferencedDate { get; set; }

		///<summary>
		/// Location ID
		/// <para>Name: LocationId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "locationId")]
		[Updateable(false), Createable(true)]
		public string LocationId { get; set; }

		///<summary>
		/// ReferenceTo: Location
		/// <para>RelationshipName: Location</para>
		///</summary>
		[JsonProperty(PropertyName = "location")]
		[Updateable(false), Createable(false)]
		public SfLocation Location { get; set; }

		///<summary>
		/// Location Group ID
		/// <para>Name: LocationGroupId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "locationGroupId")]
		[Updateable(false), Createable(true)]
		public string LocationGroupId { get; set; }

		///<summary>
		/// ReferenceTo: LocationGroup
		/// <para>RelationshipName: LocationGroup</para>
		///</summary>
		[JsonProperty(PropertyName = "locationGroup")]
		[Updateable(false), Createable(false)]
		public SfLocationGroup LocationGroup { get; set; }

		///<summary>
		/// External Reference
		/// <para>Name: LocationExternalReference</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "locationExternalReference")]
		[Updateable(false), Createable(false)]
		public string LocationExternalReference { get; set; }

		///<summary>
		/// External Reference
		/// <para>Name: LocationGroupExternalReference</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "locationGroupExternalReference")]
		[Updateable(false), Createable(false)]
		public string LocationGroupExternalReference { get; set; }

		///<summary>
		/// Location Name
		/// <para>Name: LocationName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "locationName")]
		[Updateable(false), Createable(false)]
		public string LocationName { get; set; }

		///<summary>
		/// Location Group Number
		/// <para>Name: LocationGroupName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "locationGroupName")]
		[Updateable(false), Createable(false)]
		public string LocationGroupName { get; set; }

	}
}
