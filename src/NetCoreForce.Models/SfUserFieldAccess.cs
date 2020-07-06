// SF API version v48.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// User Field Access
	///<para>SObject Name: UserFieldAccess</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfUserFieldAccess : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "UserFieldAccess"; }
		}

		///<summary>
		/// User Field Access ID
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
		/// Is Updatable
		/// <para>Name: IsUpdatable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isUpdatable")]
		[Updateable(false), Createable(false)]
		public bool? IsUpdatable { get; set; }

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
		/// Is Accessible
		/// <para>Name: IsAccessible</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isAccessible")]
		[Updateable(false), Createable(false)]
		public bool? IsAccessible { get; set; }

		///<summary>
		/// Entity Definition ID
		/// <para>Name: EntityDefinitionId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "entityDefinitionId")]
		[Updateable(false), Createable(false)]
		public string EntityDefinitionId { get; set; }

		///<summary>
		/// Field Definition ID
		/// <para>Name: FieldDefinitionId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fieldDefinitionId")]
		[Updateable(false), Createable(false)]
		public string FieldDefinitionId { get; set; }

	}
}
