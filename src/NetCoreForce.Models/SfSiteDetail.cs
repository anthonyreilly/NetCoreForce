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
	/// Site Detail
	///<para>SObject Name: SiteDetail</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfSiteDetail : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "SiteDetail"; }
		}

		///<summary>
		/// Site Detail ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Site ID
		/// <para>Name: DurableId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "durableId")]
		[Updateable(false), Createable(false)]
		public string DurableId { get; set; }

		///<summary>
		/// Self-Registration Enabled
		/// <para>Name: IsRegistrationEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isRegistrationEnabled")]
		[Updateable(false), Createable(false)]
		public bool? IsRegistrationEnabled { get; set; }

		///<summary>
		/// Secure Url
		/// <para>Name: SecureUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "secureUrl")]
		[Updateable(false), Createable(false)]
		public string SecureUrl { get; set; }

	}
}
