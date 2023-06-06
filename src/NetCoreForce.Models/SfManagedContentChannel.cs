// SF API version v57.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Managed Content Channel
	///<para>SObject Name: ManagedContentChannel</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfManagedContentChannel : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ManagedContentChannel"; }
		}

		///<summary>
		/// Managed Content Channel ID
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
		/// Managed Content Channel Name
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
		/// Managed Content Channel Type
		/// <para>Name: Type</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		[Updateable(false), Createable(false)]
		public string Type { get; set; }

		///<summary>
		/// Content Is Searchable in this Channel
		/// <para>Name: OptionsIsSearchable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsIsSearchable")]
		[Updateable(false), Createable(false)]
		public bool? OptionsIsSearchable { get; set; }

		///<summary>
		/// CacheControl header for this Channel should be set to Public
		/// <para>Name: OptionsIsCacheControlPublic</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsIsCacheControlPublic")]
		[Updateable(false), Createable(false)]
		public bool? OptionsIsCacheControlPublic { get; set; }

		///<summary>
		/// The Domain field is editable or read only for this Channel
		/// <para>Name: OptionsIsDomainLocked</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsIsDomainLocked")]
		[Updateable(false), Createable(false)]
		public bool? OptionsIsDomainLocked { get; set; }

		///<summary>
		/// Domain ID
		/// <para>Name: Domain</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "domain")]
		[Updateable(false), Createable(false)]
		public string Domain { get; set; }

		///<summary>
		/// Host name of the Domain
		/// <para>Name: DomainHostName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "domainHostName")]
		[Updateable(false), Createable(false)]
		public string DomainHostName { get; set; }

		///<summary>
		/// Cache Control Max Age
		/// <para>Name: CacheControlMaxAge</para>
		/// <para>SF Type: long</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "cacheControlMaxAge")]
		[Updateable(false), Createable(false)]
		public string CacheControlMaxAge { get; set; }

		///<summary>
		/// Media Cache Control Max Age
		/// <para>Name: MediaCacheControlMaxAge</para>
		/// <para>SF Type: long</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mediaCacheControlMaxAge")]
		[Updateable(false), Createable(false)]
		public string MediaCacheControlMaxAge { get; set; }

	}
}
