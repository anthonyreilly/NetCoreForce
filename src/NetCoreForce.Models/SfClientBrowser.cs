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
	/// Client Browser
	///<para>SObject Name: ClientBrowser</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfClientBrowser : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ClientBrowser"; }
		}

		///<summary>
		/// Client Browser ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: UsersId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "usersId")]
		[Updateable(false), Createable(false)]
		public string UsersId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: Users</para>
		///</summary>
		[JsonProperty(PropertyName = "users")]
		[Updateable(false), Createable(false)]
		public SfUser Users { get; set; }

		///<summary>
		/// Full User Agent
		/// <para>Name: FullUserAgent</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fullUserAgent")]
		[Updateable(false), Createable(false)]
		public string FullUserAgent { get; set; }

		///<summary>
		/// Proxy Info
		/// <para>Name: ProxyInfo</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "proxyInfo")]
		[Updateable(false), Createable(false)]
		public string ProxyInfo { get; set; }

		///<summary>
		/// Last Update
		/// <para>Name: LastUpdate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastUpdate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastUpdate { get; set; }

		///<summary>
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

	}
}
