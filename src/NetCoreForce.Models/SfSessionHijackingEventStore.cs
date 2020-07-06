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
	/// Session Hijacking Event Store
	///<para>SObject Name: SessionHijackingEventStore</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfSessionHijackingEventStore : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "SessionHijackingEventStore"; }
		}

		///<summary>
		/// Session Hijacking Event Store ID
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
		/// Source IP
		/// <para>Name: SourceIp</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sourceIp")]
		[Updateable(false), Createable(false)]
		public string SourceIp { get; set; }

		///<summary>
		/// Score
		/// <para>Name: Score</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "score")]
		[Updateable(false), Createable(false)]
		public double? Score { get; set; }

		///<summary>
		/// Current IpAddress
		/// <para>Name: CurrentIp</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "currentIp")]
		[Updateable(false), Createable(false)]
		public string CurrentIp { get; set; }

		///<summary>
		/// Previous IpAddress
		/// <para>Name: PreviousIp</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "previousIp")]
		[Updateable(false), Createable(false)]
		public string PreviousIp { get; set; }

		///<summary>
		/// Current Platform
		/// <para>Name: CurrentPlatform</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "currentPlatform")]
		[Updateable(false), Createable(false)]
		public string CurrentPlatform { get; set; }

		///<summary>
		/// Previous Platform
		/// <para>Name: PreviousPlatform</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "previousPlatform")]
		[Updateable(false), Createable(false)]
		public string PreviousPlatform { get; set; }

		///<summary>
		/// Current Screen
		/// <para>Name: CurrentScreen</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "currentScreen")]
		[Updateable(false), Createable(false)]
		public string CurrentScreen { get; set; }

		///<summary>
		/// Previous Screen
		/// <para>Name: PreviousScreen</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "previousScreen")]
		[Updateable(false), Createable(false)]
		public string PreviousScreen { get; set; }

		///<summary>
		/// Current Window
		/// <para>Name: CurrentWindow</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "currentWindow")]
		[Updateable(false), Createable(false)]
		public string CurrentWindow { get; set; }

		///<summary>
		/// Previous Window
		/// <para>Name: PreviousWindow</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "previousWindow")]
		[Updateable(false), Createable(false)]
		public string PreviousWindow { get; set; }

		///<summary>
		/// Current UserAgent
		/// <para>Name: CurrentUserAgent</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "currentUserAgent")]
		[Updateable(false), Createable(false)]
		public string CurrentUserAgent { get; set; }

		///<summary>
		/// Previous UserAgent
		/// <para>Name: PreviousUserAgent</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "previousUserAgent")]
		[Updateable(false), Createable(false)]
		public string PreviousUserAgent { get; set; }

	}
}
