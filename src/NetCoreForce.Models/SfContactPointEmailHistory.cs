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
	/// Contact Point Email History
	///<para>SObject Name: ContactPointEmailHistory</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfContactPointEmailHistory : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ContactPointEmailHistory"; }
		}

		///<summary>
		/// Contact Point Email History ID
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
		/// Contact Point Email ID
		/// <para>Name: ContactPointEmailId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "contactPointEmailId")]
		[Updateable(false), Createable(false)]
		public string ContactPointEmailId { get; set; }

		///<summary>
		/// ReferenceTo: ContactPointEmail
		/// <para>RelationshipName: ContactPointEmail</para>
		///</summary>
		[JsonProperty(PropertyName = "contactPointEmail")]
		[Updateable(false), Createable(false)]
		public SfContactPointEmail ContactPointEmail { get; set; }

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
		/// Changed Field
		/// <para>Name: Field</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "field")]
		[Updateable(false), Createable(false)]
		public string Field { get; set; }

		///<summary>
		/// Datatype
		/// <para>Name: DataType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dataType")]
		[Updateable(false), Createable(false)]
		public string DataType { get; set; }

		///<summary>
		/// Old Value
		/// <para>Name: OldValue</para>
		/// <para>SF Type: anyType</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "oldValue")]
		[Updateable(false), Createable(false)]
		public string OldValue { get; set; }

		///<summary>
		/// New Value
		/// <para>Name: NewValue</para>
		/// <para>SF Type: anyType</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "newValue")]
		[Updateable(false), Createable(false)]
		public string NewValue { get; set; }

	}
}
