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
	/// Auth Session
	///<para>SObject Name: AuthSession</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfAuthSession : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "AuthSession"; }
		}

		///<summary>
		/// Auth Session ID
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
		/// <para>Nillable: True</para>
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
		/// Created
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

		///<summary>
		/// Updated
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

		///<summary>
		/// Valid For
		/// <para>Name: NumSecondsValid</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "numSecondsValid")]
		[Updateable(false), Createable(false)]
		public int? NumSecondsValid { get; set; }

		///<summary>
		/// User Type
		/// <para>Name: UserType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userType")]
		[Updateable(false), Createable(false)]
		public string UserType { get; set; }

		///<summary>
		/// Source IP
		/// <para>Name: SourceIp</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "sourceIp")]
		[Updateable(false), Createable(false)]
		public string SourceIp { get; set; }

		///<summary>
		/// Login
		/// <para>Name: LoginType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "loginType")]
		[Updateable(false), Createable(false)]
		public string LoginType { get; set; }

		///<summary>
		/// Session Type
		/// <para>Name: SessionType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sessionType")]
		[Updateable(false), Createable(false)]
		public string SessionType { get; set; }

		///<summary>
		/// Session Security Level
		/// <para>Name: SessionSecurityLevel</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sessionSecurityLevel")]
		[Updateable(false), Createable(false)]
		public string SessionSecurityLevel { get; set; }

		///<summary>
		/// Logout URL
		/// <para>Name: LogoutUrl</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "logoutUrl")]
		[Updateable(false), Createable(false)]
		public string LogoutUrl { get; set; }

		///<summary>
		/// Auth Session ID
		/// <para>Name: ParentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "parentId")]
		[Updateable(false), Createable(false)]
		public string ParentId { get; set; }

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
		/// ReferenceTo: LoginHistory
		/// <para>RelationshipName: LoginHistory</para>
		///</summary>
		[JsonProperty(PropertyName = "loginHistory")]
		[Updateable(false), Createable(false)]
		public SfLoginHistory LoginHistory { get; set; }

		///<summary>
		/// Login Geo Data ID
		/// <para>Name: LoginGeoId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "loginGeoId")]
		[Updateable(false), Createable(false)]
		public string LoginGeoId { get; set; }

		///<summary>
		/// ReferenceTo: LoginGeo
		/// <para>RelationshipName: LoginGeo</para>
		///</summary>
		[JsonProperty(PropertyName = "loginGeo")]
		[Updateable(false), Createable(false)]
		public SfLoginGeo LoginGeo { get; set; }

		///<summary>
		/// Current Session
		/// <para>Name: IsCurrent</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isCurrent")]
		[Updateable(false), Createable(false)]
		public bool? IsCurrent { get; set; }

	}
}
