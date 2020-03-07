// SF API version v41.0
// Custom fields included: False
// Relationship objects included: True

using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// User Record Access
	///<para>SObject Name: UserRecordAccess</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfUserRecordAccess : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "UserRecordAccess"; }
		}

		///<summary>
		/// User Record Access ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: UserId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userId")]
		[Updateable(false), Creatable(false)]
		public string UserId { get; set; }

		///<summary>
		/// Record ID
		/// <para>Name: RecordId</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "recordId")]
		[Updateable(false), Creatable(false)]
		public string RecordId { get; set; }

		///<summary>
		/// Has Read Access
		/// <para>Name: HasReadAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasReadAccess")]
		[Updateable(false), Creatable(false)]
		public bool? HasReadAccess { get; set; }

		///<summary>
		/// Has Edit Access
		/// <para>Name: HasEditAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasEditAccess")]
		[Updateable(false), Creatable(false)]
		public bool? HasEditAccess { get; set; }

		///<summary>
		/// Has Delete Access
		/// <para>Name: HasDeleteAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasDeleteAccess")]
		[Updateable(false), Creatable(false)]
		public bool? HasDeleteAccess { get; set; }

		///<summary>
		/// Has Transfer Access
		/// <para>Name: HasTransferAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasTransferAccess")]
		[Updateable(false), Creatable(false)]
		public bool? HasTransferAccess { get; set; }

		///<summary>
		/// Has All Access
		/// <para>Name: HasAllAccess</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasAllAccess")]
		[Updateable(false), Creatable(false)]
		public bool? HasAllAccess { get; set; }

		///<summary>
		/// Maximum Access Level
		/// <para>Name: MaxAccessLevel</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "maxAccessLevel")]
		[Updateable(false), Creatable(false)]
		public string MaxAccessLevel { get; set; }

	}
}
