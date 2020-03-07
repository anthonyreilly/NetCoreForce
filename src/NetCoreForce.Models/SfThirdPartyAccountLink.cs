// SF API version v41.0
// Custom fields included: False
// Relationship objects included: True

using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Third Party Account Link
	///<para>SObject Name: ThirdPartyAccountLink</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfThirdPartyAccountLink : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ThirdPartyAccountLink"; }
		}

		///<summary>
		/// Third Party Account Link ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// Third Party Account Link Unique Key
		/// <para>Name: ThirdPartyAccountLinkKey</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "thirdPartyAccountLinkKey")]
		[Updateable(false), Creatable(false)]
		public string ThirdPartyAccountLinkKey { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: UserId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "userId")]
		[Updateable(false), Creatable(false)]
		public string UserId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: User</para>
		///</summary>
		[JsonProperty(PropertyName = "user")]
		[Updateable(false), Creatable(false)]
		public SfUser User { get; set; }

		///<summary>
		/// Auth. Provider ID
		/// <para>Name: SsoProviderId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "ssoProviderId")]
		[Updateable(false), Creatable(false)]
		public string SsoProviderId { get; set; }

		///<summary>
		/// ReferenceTo: AuthProvider
		/// <para>RelationshipName: SsoProvider</para>
		///</summary>
		[JsonProperty(PropertyName = "ssoProvider")]
		[Updateable(false), Creatable(false)]
		public SfAuthProvider SsoProvider { get; set; }

		///<summary>
		/// External User Handle
		/// <para>Name: Handle</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "handle")]
		[Updateable(false), Creatable(false)]
		public string Handle { get; set; }

		///<summary>
		/// External User Id
		/// <para>Name: RemoteIdentifier</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "remoteIdentifier")]
		[Updateable(false), Creatable(false)]
		public string RemoteIdentifier { get; set; }

		///<summary>
		/// Provider
		/// <para>Name: Provider</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "provider")]
		[Updateable(false), Creatable(false)]
		public string Provider { get; set; }

		///<summary>
		/// Single Sign-On Provider Name
		/// <para>Name: SsoProviderName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "ssoProviderName")]
		[Updateable(false), Creatable(false)]
		public string SsoProviderName { get; set; }

		///<summary>
		/// Is Not SSO Usable
		/// <para>Name: IsNotSsoUsable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isNotSsoUsable")]
		[Updateable(false), Creatable(false)]
		public bool? IsNotSsoUsable { get; set; }

	}
}
