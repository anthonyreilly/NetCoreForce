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
	/// Data Encryption Key
	///<para>SObject Name: DataEncryptionKey</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfDataEncryptionKey : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "DataEncryptionKey"; }
		}

		///<summary>
		/// Data Encryption Key Id
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Data Encryption Key Certificate Name
		/// <para>Name: DataEncryptionKeyCertName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dataEncryptionKeyCertName")]
		public string DataEncryptionKeyCertName { get; set; }

		///<summary>
		/// Version
		/// <para>Name: Version</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "version")]
		public int? Version { get; set; }

		///<summary>
		/// Root Key Identifier
		/// <para>Name: RootKeyIdentifier</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "rootKeyIdentifier")]
		public string RootKeyIdentifier { get; set; }

		///<summary>
		/// Root Key KMS Identifier
		/// <para>Name: RootKeyKmsIdentifier</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "rootKeyKmsIdentifier")]
		public string RootKeyKmsIdentifier { get; set; }

		///<summary>
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		public DateTimeOffset? CreatedDate { get; set; }

		///<summary>
		/// Created By
		/// <para>Name: CreatedBy</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "createdBy")]
		public string CreatedBy { get; set; }

		///<summary>
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		public DateTimeOffset? LastModifiedDate { get; set; }

		///<summary>
		/// Last Modified By
		/// <para>Name: LastModifiedBy</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedBy")]
		public string LastModifiedBy { get; set; }

		///<summary>
		/// Key Derivation
		/// <para>Name: DoesUseKeyDerivation</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "doesUseKeyDerivation")]
		public bool? DoesUseKeyDerivation { get; set; }

		///<summary>
		/// Source
		/// <para>Name: Source</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "source")]
		public string Source { get; set; }

		///<summary>
		/// Type
		/// <para>Name: Type</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		public string Type { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		public string Status { get; set; }

		///<summary>
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

		///<summary>
		/// Session Token
		/// <para>Name: SessionToken</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sessionToken")]
		public string SessionToken { get; set; }

		///<summary>
		/// Secret Value
		/// <para>Name: SecretValue</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "secretValue")]
		public string SecretValue { get; set; }

	}
}
