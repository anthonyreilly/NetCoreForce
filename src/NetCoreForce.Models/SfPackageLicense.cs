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
	/// Package License
	///<para>SObject Name: PackageLicense</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfPackageLicense : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "PackageLicense"; }
		}

		///<summary>
		/// Package License ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		[Updateable(false), Creatable(false)]
		public string Status { get; set; }

		///<summary>
		/// Is Provisioned
		/// <para>Name: IsProvisioned</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isProvisioned")]
		[Updateable(false), Creatable(false)]
		public bool? IsProvisioned { get; set; }

		///<summary>
		/// Allowed Licenses
		/// <para>Name: AllowedLicenses</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "allowedLicenses")]
		[Updateable(false), Creatable(false)]
		public int? AllowedLicenses { get; set; }

		///<summary>
		/// Used Licenses
		/// <para>Name: UsedLicenses</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "usedLicenses")]
		[Updateable(false), Creatable(false)]
		public int? UsedLicenses { get; set; }

		///<summary>
		/// Expiration Date
		/// <para>Name: ExpirationDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "expirationDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? ExpirationDate { get; set; }

		///<summary>
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

		///<summary>
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

		///<summary>
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

		///<summary>
		/// Namespace Prefix
		/// <para>Name: NamespacePrefix</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "namespacePrefix")]
		[Updateable(false), Creatable(false)]
		public string NamespacePrefix { get; set; }

	}
}
