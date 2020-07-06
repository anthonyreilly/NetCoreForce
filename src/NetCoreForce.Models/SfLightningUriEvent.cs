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
	/// Lightning URI Event
	///<para>SObject Name: LightningUriEvent</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfLightningUriEvent : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "LightningUriEvent"; }
		}

		///<summary>
		/// Lightning URI Event ID
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
		/// Related Event Identifier
		/// <para>Name: RelatedEventIdentifier</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relatedEventIdentifier")]
		[Updateable(false), Createable(false)]
		public string RelatedEventIdentifier { get; set; }

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
		/// Operation
		/// <para>Name: Operation</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "operation")]
		[Updateable(false), Createable(false)]
		public string Operation { get; set; }

		///<summary>
		/// Queried Entities
		/// <para>Name: QueriedEntities</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "queriedEntities")]
		[Updateable(false), Createable(false)]
		public string QueriedEntities { get; set; }

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
		/// Connection Type
		/// <para>Name: ConnectionType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "connectionType")]
		[Updateable(false), Createable(false)]
		public string ConnectionType { get; set; }

		///<summary>
		/// Device ID
		/// <para>Name: DeviceId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "deviceId")]
		[Updateable(false), Createable(false)]
		public string DeviceId { get; set; }

		///<summary>
		/// Device Model
		/// <para>Name: DeviceModel</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "deviceModel")]
		[Updateable(false), Createable(false)]
		public string DeviceModel { get; set; }

		///<summary>
		/// Device Platform
		/// <para>Name: DevicePlatform</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "devicePlatform")]
		[Updateable(false), Createable(false)]
		public string DevicePlatform { get; set; }

		///<summary>
		/// Device Session ID
		/// <para>Name: DeviceSessionId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "deviceSessionId")]
		[Updateable(false), Createable(false)]
		public string DeviceSessionId { get; set; }

		///<summary>
		/// Duration
		/// <para>Name: Duration</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "duration")]
		[Updateable(false), Createable(false)]
		public double? Duration { get; set; }

		///<summary>
		/// Effective Page Time
		/// <para>Name: EffectivePageTime</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "effectivePageTime")]
		[Updateable(false), Createable(false)]
		public double? EffectivePageTime { get; set; }

		///<summary>
		/// OS Name
		/// <para>Name: OsName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "osName")]
		[Updateable(false), Createable(false)]
		public string OsName { get; set; }

		///<summary>
		/// OS Version
		/// <para>Name: OsVersion</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "osVersion")]
		[Updateable(false), Createable(false)]
		public string OsVersion { get; set; }

		///<summary>
		/// Page Start Time
		/// <para>Name: PageStartTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "pageStartTime")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? PageStartTime { get; set; }

		///<summary>
		/// Page URL
		/// <para>Name: PageUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "pageUrl")]
		[Updateable(false), Createable(false)]
		public string PageUrl { get; set; }

		///<summary>
		/// Previous Page App Name
		/// <para>Name: PreviousPageAppName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "previousPageAppName")]
		[Updateable(false), Createable(false)]
		public string PreviousPageAppName { get; set; }

		///<summary>
		/// Previous Page Entity ID
		/// <para>Name: PreviousPageEntityId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "previousPageEntityId")]
		[Updateable(false), Createable(false)]
		public string PreviousPageEntityId { get; set; }

		///<summary>
		/// Previous Page Entity Type
		/// <para>Name: PreviousPageEntityType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "previousPageEntityType")]
		[Updateable(false), Createable(false)]
		public string PreviousPageEntityType { get; set; }

		///<summary>
		/// Previous Page URL
		/// <para>Name: PreviousPageUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "previousPageUrl")]
		[Updateable(false), Createable(false)]
		public string PreviousPageUrl { get; set; }

		///<summary>
		/// SDK App Type
		/// <para>Name: SdkAppType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sdkAppType")]
		[Updateable(false), Createable(false)]
		public string SdkAppType { get; set; }

		///<summary>
		/// SDK App Version
		/// <para>Name: SdkAppVersion</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sdkAppVersion")]
		[Updateable(false), Createable(false)]
		public string SdkAppVersion { get; set; }

		///<summary>
		/// SDK Version
		/// <para>Name: SdkVersion</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sdkVersion")]
		[Updateable(false), Createable(false)]
		public string SdkVersion { get; set; }

		///<summary>
		/// Record ID
		/// <para>Name: RecordId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recordId")]
		[Updateable(false), Createable(false)]
		public string RecordId { get; set; }

		///<summary>
		/// User Type
		/// <para>Name: UserType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "userType")]
		[Updateable(false), Createable(false)]
		public string UserType { get; set; }

	}
}
