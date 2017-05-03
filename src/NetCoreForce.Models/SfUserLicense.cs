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
	/// User License
	///<para>SObject Name: UserLicense</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfUserLicense : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "UserLicense"; }
		}

		///<summary>
		/// User License ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// License Def. ID
		/// <para>Name: LicenseDefinitionKey</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "licenseDefinitionKey")]
		[Updateable(false), Createable(false)]
		public string LicenseDefinitionKey { get; set; }

		///<summary>
		/// Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
		public string Name { get; set; }

		///<summary>
		/// Monthly Logins Used
		/// <para>Name: MonthlyLoginsUsed</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "monthlyLoginsUsed")]
		[Updateable(false), Createable(false)]
		public int? MonthlyLoginsUsed { get; set; }

		///<summary>
		/// Monthly Logins Allotted
		/// <para>Name: MonthlyLoginsEntitlement</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "monthlyLoginsEntitlement")]
		[Updateable(false), Createable(false)]
		public int? MonthlyLoginsEntitlement { get; set; }

		///<summary>
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

	}
}
