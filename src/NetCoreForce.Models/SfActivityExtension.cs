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
	/// ActivityExtension
	///<para>SObject Name: ActivityExtension</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfActivityExtension : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ActivityExtension"; }
		}

		///<summary>
		/// Activity Extension ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Parent ID
		/// <para>Name: BaseId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "baseId")]
		[Updateable(false), Createable(true)]
		public string BaseId { get; set; }

		///<summary>
		/// ReferenceTo: Event
		/// <para>RelationshipName: Base</para>
		///</summary>
		[JsonProperty(PropertyName = "base")]
		[Updateable(false), Createable(false)]
		public SfEvent Base { get; set; }

		///<summary>
		/// Base Type
		/// <para>Name: BaseType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "baseType")]
		[Updateable(false), Createable(false)]
		public string BaseType { get; set; }

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
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

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
		/// Is Exception
		/// <para>Name: IsException</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isException")]
		public string IsException { get; set; }

		///<summary>
		/// Recurrence ID
		/// <para>Name: RecurrenceId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recurrenceId")]
		public string RecurrenceId { get; set; }

	}
}
