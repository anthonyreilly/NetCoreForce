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
	/// LoginAs Event
	///<para>SObject Name: LoginAsEvent</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfLoginAsEvent : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "LoginAsEvent"; }
		}

		///<summary>
		/// LoginAs Event ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

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
		/// Event Identifier
		/// <para>Name: EventIdentifier</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "eventIdentifier")]
		[Updateable(false), Createable(false)]
		public string EventIdentifier { get; set; }

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
		/// Username
		/// <para>Name: Username</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "username")]
		[Updateable(false), Createable(false)]
		public string Username { get; set; }

		///<summary>
		/// Event Date
		/// <para>Name: EventDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "eventDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? EventDate { get; set; }

		///<summary>
		/// Session Key
		/// <para>Name: SessionKey</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sessionKey")]
		[Updateable(false), Createable(false)]
		public string SessionKey { get; set; }

		///<summary>
		/// Login Key
		/// <para>Name: LoginKey</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "loginKey")]
		[Updateable(false), Createable(false)]
		public string LoginKey { get; set; }

		///<summary>
		/// Session Level
		/// <para>Name: SessionLevel</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sessionLevel")]
		[Updateable(false), Createable(false)]
		public string SessionLevel { get; set; }

		///<summary>
		/// Source IP
		/// <para>Name: SourceIp</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sourceIp")]
		[Updateable(false), Createable(false)]
		public string SourceIp { get; set; }

		///<summary>
		/// User Type
		/// <para>Name: UserType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "userType")]
		[Updateable(false), Createable(false)]
		public string UserType { get; set; }

		///<summary>
		/// Login History ID
		/// <para>Name: LoginHistoryId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "loginHistoryId")]
		[Updateable(false), Createable(false)]
		public string LoginHistoryId { get; set; }

		///<summary>
		/// Application
		/// <para>Name: Application</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "application")]
		[Updateable(false), Createable(false)]
		public string Application { get; set; }

		///<summary>
		/// Browser
		/// <para>Name: Browser</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "browser")]
		[Updateable(false), Createable(false)]
		public string Browser { get; set; }

		///<summary>
		/// Login Type
		/// <para>Name: LoginType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "loginType")]
		[Updateable(false), Createable(false)]
		public string LoginType { get; set; }

		///<summary>
		/// Platform
		/// <para>Name: Platform</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "platform")]
		[Updateable(false), Createable(false)]
		public string Platform { get; set; }

		///<summary>
		/// Delegated Username
		/// <para>Name: DelegatedUsername</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "delegatedUsername")]
		[Updateable(false), Createable(false)]
		public string DelegatedUsername { get; set; }

		///<summary>
		/// Delegated Organization Id
		/// <para>Name: DelegatedOrganizationId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "delegatedOrganizationId")]
		[Updateable(false), Createable(false)]
		public string DelegatedOrganizationId { get; set; }

		///<summary>
		/// Target URL
		/// <para>Name: TargetUrl</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "targetUrl")]
		[Updateable(false), Createable(false)]
		public string TargetUrl { get; set; }

		///<summary>
		/// LoginAs Category
		/// <para>Name: LoginAsCategory</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "loginAsCategory")]
		[Updateable(false), Createable(false)]
		public string LoginAsCategory { get; set; }

	}
}
