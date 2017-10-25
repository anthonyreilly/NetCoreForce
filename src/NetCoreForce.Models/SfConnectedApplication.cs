// SF API version v41.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Connected App
	///<para>SObject Name: ConnectedApplication</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfConnectedApplication : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ConnectedApplication"; }
		}

		///<summary>
		/// Connected App ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Connected App Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
		public string Name { get; set; }

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
		/// AllowAdminApprovedUsersOnly
		/// <para>Name: OptionsAllowAdminApprovedUsersOnly</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsAllowAdminApprovedUsersOnly")]
		[Updateable(false), Createable(false)]
		public bool? OptionsAllowAdminApprovedUsersOnly { get; set; }

		///<summary>
		/// RefreshTokenValidityMetric
		/// <para>Name: OptionsRefreshTokenValidityMetric</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsRefreshTokenValidityMetric")]
		[Updateable(false), Createable(false)]
		public bool? OptionsRefreshTokenValidityMetric { get; set; }

		///<summary>
		/// HasSessionLevelPolicy
		/// <para>Name: OptionsHasSessionLevelPolicy</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsHasSessionLevelPolicy")]
		[Updateable(false), Createable(false)]
		public bool? OptionsHasSessionLevelPolicy { get; set; }

		///<summary>
		/// isInternal
		/// <para>Name: OptionsIsInternal</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsIsInternal")]
		[Updateable(false), Createable(false)]
		public bool? OptionsIsInternal { get; set; }

		///<summary>
		/// Require PIN after:
		/// <para>Name: MobileSessionTimeout</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mobileSessionTimeout")]
		[Updateable(false), Createable(false)]
		public string MobileSessionTimeout { get; set; }

		///<summary>
		/// Pin Length
		/// <para>Name: PinLength</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "pinLength")]
		[Updateable(false), Createable(false)]
		public string PinLength { get; set; }

		///<summary>
		/// Start URL
		/// <para>Name: StartUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "startUrl")]
		[Updateable(false), Createable(false)]
		public string StartUrl { get; set; }

		///<summary>
		/// Mobile Start URL
		/// <para>Name: MobileStartUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mobileStartUrl")]
		[Updateable(false), Createable(false)]
		public string MobileStartUrl { get; set; }

		///<summary>
		/// Refresh Token Policy:
		/// <para>Name: RefreshTokenValidityPeriod</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "refreshTokenValidityPeriod")]
		[Updateable(false), Createable(false)]
		public int? RefreshTokenValidityPeriod { get; set; }

	}
}
