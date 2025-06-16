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
	/// Recycle Bin Item
	///<para>SObject Name: DeleteEvent</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfDeleteEvent : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "DeleteEvent"; }
		}

		///<summary>
		/// Delete Event ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Record ID
		/// <para>Name: Record</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "record")]
		[Updateable(false), Createable(false)]
		public string Record { get; set; }

		///<summary>
		/// Record Name
		/// <para>Name: RecordName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recordName")]
		[Updateable(false), Createable(false)]
		public string RecordName { get; set; }

		///<summary>
		/// Owner ID
		/// <para>Name: DeletedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "deletedById")]
		[Updateable(false), Createable(false)]
		public string DeletedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: DeletedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "deletedBy")]
		[Updateable(false), Createable(false)]
		public SfUser DeletedBy { get; set; }

		///<summary>
		/// Deleted Date
		/// <para>Name: DeletedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "deletedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? DeletedDate { get; set; }

		///<summary>
		/// Type
		/// <para>Name: SobjectName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sobjectName")]
		[Updateable(false), Createable(false)]
		public string SobjectName { get; set; }

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
