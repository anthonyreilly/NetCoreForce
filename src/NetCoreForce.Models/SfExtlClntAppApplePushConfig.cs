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
	/// External Client Application Apple Push Configuration
	///<para>SObject Name: ExtlClntAppApplePushConfig</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfExtlClntAppApplePushConfig : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ExtlClntAppApplePushConfig"; }
		}

		///<summary>
		/// External Client Application Apple Push Configurations ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Createable(false)]
		public bool? IsDeleted { get; set; }

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
		/// Created By ID
		/// <para>Name: CreatedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdById")]
		[Updateable(false), Createable(false)]
		public string CreatedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: CreatedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "createdBy")]
		[Updateable(false), Createable(false)]
		public SfUser CreatedBy { get; set; }

		///<summary>
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

		///<summary>
		/// Last Modified By ID
		/// <para>Name: LastModifiedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedById")]
		[Updateable(false), Createable(false)]
		public string LastModifiedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: LastModifiedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedBy")]
		[Updateable(false), Createable(false)]
		public SfUser LastModifiedBy { get; set; }

		///<summary>
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

		///<summary>
		/// External Client Application Push Settings ID
		/// <para>Name: ExtlClntAppPushSettingsId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "extlClntAppPushSettingsId")]
		[Updateable(false), Createable(false)]
		public string ExtlClntAppPushSettingsId { get; set; }

		///<summary>
		/// ReferenceTo: ExtlClntAppPushSettings
		/// <para>RelationshipName: ExtlClntAppPushSettings</para>
		///</summary>
		[JsonProperty(PropertyName = "extlClntAppPushSettings")]
		[Updateable(false), Createable(false)]
		public SfExtlClntAppPushSettings ExtlClntAppPushSettings { get; set; }

		///<summary>
		/// Environment
		/// <para>Name: Environment</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "environment")]
		[Updateable(false), Createable(false)]
		public string Environment { get; set; }

		///<summary>
		/// Push Certificate
		/// <para>Name: Certificate</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "certificate")]
		[Updateable(false), Createable(false)]
		public string Certificate { get; set; }

		///<summary>
		/// Certificate Password
		/// <para>Name: Password</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "password")]
		[Updateable(false), Createable(false)]
		public string Password { get; set; }

		///<summary>
		/// Key Identifier
		/// <para>Name: KeyIdentifier</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "keyIdentifier")]
		[Updateable(false), Createable(false)]
		public string KeyIdentifier { get; set; }

		///<summary>
		/// Team Identifier
		/// <para>Name: TeamIdentifier</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "teamIdentifier")]
		[Updateable(false), Createable(false)]
		public string TeamIdentifier { get; set; }

		///<summary>
		/// Signing Key
		/// <para>Name: SigningKey</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "signingKey")]
		[Updateable(false), Createable(false)]
		public string SigningKey { get; set; }

		///<summary>
		/// Application Bundle Id
		/// <para>Name: ApplicationBundle</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "applicationBundle")]
		[Updateable(false), Createable(false)]
		public string ApplicationBundle { get; set; }

		///<summary>
		/// Current Apple Push Configuration
		/// <para>Name: IsCurrent</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isCurrent")]
		[Updateable(false), Createable(false)]
		public bool? IsCurrent { get; set; }

	}
}
