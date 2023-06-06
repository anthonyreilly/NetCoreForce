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
	/// User Setup Entity Access
	///<para>SObject Name: UserSetupEntityAccess</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfUserSetupEntityAccess : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "UserSetupEntityAccess"; }
		}

		///<summary>
		/// UserSetupEntityAccess ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// User Setup Entity Access Key
		/// <para>Name: DurableId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "durableId")]
		[Updateable(false), Createable(false)]
		public string DurableId { get; set; }

		///<summary>
		/// Setup Entity Id
		/// <para>Name: SetupEntityId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "setupEntityId")]
		[Updateable(false), Createable(false)]
		public string SetupEntityId { get; set; }

		///<summary>
		/// Key Prefix
		/// <para>Name: KeyPrefix</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "keyPrefix")]
		[Updateable(false), Createable(false)]
		public string KeyPrefix { get; set; }

		///<summary>
		/// Developer Name
		/// <para>Name: DeveloperName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "developerName")]
		[Updateable(false), Createable(false)]
		public string DeveloperName { get; set; }

		///<summary>
		/// Namespace Prefix
		/// <para>Name: NamespacePrefix</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "namespacePrefix")]
		[Updateable(false), Createable(false)]
		public string NamespacePrefix { get; set; }

		///<summary>
		/// Last Cache Update
		/// <para>Name: LastCacheUpdate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastCacheUpdate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastCacheUpdate { get; set; }

	}
}
