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
	/// User Entity Access
	///<para>SObject Name: UserEntityAccess</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfUserEntityAccess : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "UserEntityAccess"; }
		}

		///<summary>
		/// User Entity Access ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Durable ID
		/// <para>Name: DurableId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "durableId")]
		[Updateable(false), Createable(false)]
		public string DurableId { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: UserId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "userId")]
		[Updateable(false), Createable(false)]
		public string UserId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: User</para>
		///</summary>
		[JsonProperty(PropertyName = "user")]
		[Updateable(false), Createable(false)]
		public SfUser User { get; set; }

		///<summary>
		/// Is Mergeable
		/// <para>Name: IsMergeable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isMergeable")]
		[Updateable(false), Createable(false)]
		public bool? IsMergeable { get; set; }

		///<summary>
		/// Is Updatable
		/// <para>Name: IsUpdatable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isUpdatable")]
		[Updateable(false), Createable(false)]
		public bool? IsUpdatable { get; set; }

		///<summary>
		/// Is Activateable
		/// <para>Name: IsActivateable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isActivateable")]
		[Updateable(false), Createable(false)]
		public bool? IsActivateable { get; set; }

		///<summary>
		/// Is Readable
		/// <para>Name: IsReadable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReadable")]
		[Updateable(false), Createable(false)]
		public bool? IsReadable { get; set; }

		///<summary>
		/// Is Creatable
		/// <para>Name: IsCreatable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isCreatable")]
		[Updateable(false), Createable(false)]
		public bool? IsCreatable { get; set; }

		///<summary>
		/// Is Editable
		/// <para>Name: IsEditable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isEditable")]
		[Updateable(false), Createable(false)]
		public bool? IsEditable { get; set; }

		///<summary>
		/// Is Deletable
		/// <para>Name: IsDeletable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeletable")]
		[Updateable(false), Createable(false)]
		public bool? IsDeletable { get; set; }

		///<summary>
		/// Is Undeletable
		/// <para>Name: IsUndeletable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isUndeletable")]
		[Updateable(false), Createable(false)]
		public bool? IsUndeletable { get; set; }

		///<summary>
		/// Is Field-level Security Updatable?
		/// <para>Name: IsFlsUpdatable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlsUpdatable")]
		[Updateable(false), Createable(false)]
		public bool? IsFlsUpdatable { get; set; }

		///<summary>
		/// Entity Definition ID
		/// <para>Name: EntityDefinitionId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "entityDefinitionId")]
		[Updateable(false), Createable(false)]
		public string EntityDefinitionId { get; set; }

	}
}
