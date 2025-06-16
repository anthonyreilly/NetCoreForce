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
	/// Oauth Token
	///<para>SObject Name: OauthToken</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfOauthToken : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "OauthToken"; }
		}

		///<summary>
		/// Oauth Token ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Access Token
		/// <para>Name: AccessToken</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "accessToken")]
		[Updateable(false), Createable(false)]
		public string AccessToken { get; set; }

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
		/// Request Token
		/// <para>Name: RequestToken</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "requestToken")]
		[Updateable(false), Createable(false)]
		public string RequestToken { get; set; }

		///<summary>
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

		///<summary>
		/// Application Name
		/// <para>Name: AppName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "appName")]
		[Updateable(false), Createable(false)]
		public string AppName { get; set; }

		///<summary>
		/// Last Used Date
		/// <para>Name: LastUsedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastUsedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastUsedDate { get; set; }

		///<summary>
		/// Use Count
		/// <para>Name: UseCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "useCount")]
		[Updateable(false), Createable(false)]
		public int? UseCount { get; set; }

		///<summary>
		/// Delete Token
		/// <para>Name: DeleteToken</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "deleteToken")]
		[Updateable(false), Createable(false)]
		public string DeleteToken { get; set; }

		///<summary>
		/// AppMenuItem ID
		/// <para>Name: AppMenuItemId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "appMenuItemId")]
		[Updateable(false), Createable(false)]
		public string AppMenuItemId { get; set; }

		///<summary>
		/// ReferenceTo: AppMenuItem
		/// <para>RelationshipName: AppMenuItem</para>
		///</summary>
		[JsonProperty(PropertyName = "appMenuItem")]
		[Updateable(false), Createable(false)]
		public SfAppMenuItem AppMenuItem { get; set; }

	}
}
