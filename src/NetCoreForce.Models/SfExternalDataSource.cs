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
	/// External Data Source
	///<para>SObject Name: ExternalDataSource</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfExternalDataSource : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ExternalDataSource"; }
		}

		///<summary>
		/// External Data Source ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Creatable(false)]
		public bool? IsDeleted { get; set; }

		///<summary>
		/// Name
		/// <para>Name: DeveloperName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "developerName")]
		[Updateable(false), Creatable(false)]
		public string DeveloperName { get; set; }

		///<summary>
		/// Master Language
		/// <para>Name: Language</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "language")]
		[Updateable(false), Creatable(false)]
		public string Language { get; set; }

		///<summary>
		/// External Data Source
		/// <para>Name: MasterLabel</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "masterLabel")]
		[Updateable(false), Creatable(false)]
		public string MasterLabel { get; set; }

		///<summary>
		/// Namespace Prefix
		/// <para>Name: NamespacePrefix</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "namespacePrefix")]
		[Updateable(false), Creatable(false)]
		public string NamespacePrefix { get; set; }

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
		/// Created By ID
		/// <para>Name: CreatedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdById")]
		[Updateable(false), Creatable(false)]
		public string CreatedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: CreatedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "createdBy")]
		[Updateable(false), Creatable(false)]
		public SfUser CreatedBy { get; set; }

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
		/// Last Modified By ID
		/// <para>Name: LastModifiedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedById")]
		[Updateable(false), Creatable(false)]
		public string LastModifiedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: LastModifiedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedBy")]
		[Updateable(false), Creatable(false)]
		public SfUser LastModifiedBy { get; set; }

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
		/// Class ID
		/// <para>Name: Type</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		[Updateable(false), Creatable(false)]
		public string Type { get; set; }

		///<summary>
		/// URL
		/// <para>Name: Endpoint</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "endpoint")]
		[Updateable(false), Creatable(false)]
		public string Endpoint { get; set; }

		///<summary>
		/// Default External Repository
		/// <para>Name: Repository</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "repository")]
		[Updateable(false), Creatable(false)]
		public string Repository { get; set; }

		///<summary>
		/// Writable External Objects
		/// <para>Name: IsWritable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isWritable")]
		[Updateable(false), Creatable(false)]
		public bool? IsWritable { get; set; }

		///<summary>
		/// Identity Type
		/// <para>Name: PrincipalType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "principalType")]
		[Updateable(false), Creatable(false)]
		public string PrincipalType { get; set; }

		///<summary>
		/// Authentication Protocol
		/// <para>Name: Protocol</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "protocol")]
		[Updateable(false), Creatable(false)]
		public string Protocol { get; set; }

		///<summary>
		/// Auth. Provider ID
		/// <para>Name: AuthProviderId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "authProviderId")]
		[Updateable(false), Creatable(false)]
		public string AuthProviderId { get; set; }

		///<summary>
		/// ReferenceTo: AuthProvider
		/// <para>RelationshipName: AuthProvider</para>
		///</summary>
		[JsonProperty(PropertyName = "authProvider")]
		[Updateable(false), Creatable(false)]
		public SfAuthProvider AuthProvider { get; set; }

		///<summary>
		/// Static Resource ID
		/// <para>Name: LargeIconId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "largeIconId")]
		[Updateable(false), Creatable(false)]
		public string LargeIconId { get; set; }

		///<summary>
		/// ReferenceTo: StaticResource
		/// <para>RelationshipName: LargeIcon</para>
		///</summary>
		[JsonProperty(PropertyName = "largeIcon")]
		[Updateable(false), Creatable(false)]
		public SfStaticResource LargeIcon { get; set; }

		///<summary>
		/// Static Resource ID
		/// <para>Name: SmallIconId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "smallIconId")]
		[Updateable(false), Creatable(false)]
		public string SmallIconId { get; set; }

		///<summary>
		/// ReferenceTo: StaticResource
		/// <para>RelationshipName: SmallIcon</para>
		///</summary>
		[JsonProperty(PropertyName = "smallIcon")]
		[Updateable(false), Creatable(false)]
		public SfStaticResource SmallIcon { get; set; }

		///<summary>
		/// Custom Configuration
		/// <para>Name: CustomConfiguration</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "customConfiguration")]
		[Updateable(false), Creatable(false)]
		public string CustomConfiguration { get; set; }

	}
}
