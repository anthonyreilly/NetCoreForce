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
	/// External Encryption Root Key
	///<para>SObject Name: ExternalEncryptionRootKey</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfExternalEncryptionRootKey : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ExternalEncryptionRootKey"; }
		}

		///<summary>
		/// External Root Key Id
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Root Key Identifier
		/// <para>Name: RootKeyIdentifier</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "rootKeyIdentifier")]
		[Updateable(true), Createable(false)]
		public string RootKeyIdentifier { get; set; }

		///<summary>
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(true), Createable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

		///<summary>
		/// Created By
		/// <para>Name: CreatedBy</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "createdBy")]
		[Updateable(true), Createable(false)]
		public string CreatedBy { get; set; }

		///<summary>
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(true), Createable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

		///<summary>
		/// Last Modified By
		/// <para>Name: LastModifiedBy</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedBy")]
		[Updateable(true), Createable(false)]
		public string LastModifiedBy { get; set; }

		///<summary>
		/// Root Key Service
		/// <para>Name: RootKeyService</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "rootKeyService")]
		[Updateable(true), Createable(false)]
		public string RootKeyService { get; set; }

		///<summary>
		/// Region
		/// <para>Name: Region</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "region")]
		[Updateable(true), Createable(false)]
		public string Region { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		[Updateable(true), Createable(false)]
		public string Status { get; set; }

		///<summary>
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		[Updateable(true), Createable(false)]
		public string Description { get; set; }

		///<summary>
		/// Activated Date
		/// <para>Name: ActivatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "activatedDate")]
		[Updateable(true), Createable(false)]
		public DateTimeOffset? ActivatedDate { get; set; }

	}
}
