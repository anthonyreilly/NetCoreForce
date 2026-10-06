// SF API version v67.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Environment
	///<para>SObject Name: DevopsEnvironment</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfDevopsEnvironment : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "DevopsEnvironment"; }
		}

		///<summary>
		/// DevOps Environment ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Owner ID
		/// <para>Name: OwnerId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "ownerId")]
		public string OwnerId { get; set; }

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
		/// Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
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
		/// Last Viewed Date
		/// <para>Name: LastViewedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastViewedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastViewedDate { get; set; }

		///<summary>
		/// Last Referenced Date
		/// <para>Name: LastReferencedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastReferencedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastReferencedDate { get; set; }

		///<summary>
		/// Can Track Changes
		/// <para>Name: CanTrackChanges</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "canTrackChanges")]
		public bool? CanTrackChanges { get; set; }

		///<summary>
		/// Is Expired
		/// <para>Name: IsExpired</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isExpired")]
		public bool? IsExpired { get; set; }

		///<summary>
		/// Last Revision Counter
		/// <para>Name: LastRevisionCounter</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastRevisionCounter")]
		public int? LastRevisionCounter { get; set; }

		///<summary>
		/// Named Credential
		/// <para>Name: NamedCredential</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "namedCredential")]
		public string NamedCredential { get; set; }

		///<summary>
		/// Org ID
		/// <para>Name: OrgIdentifier</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "orgIdentifier")]
		public string OrgIdentifier { get; set; }

		///<summary>
		/// Refresh Date
		/// <para>Name: RefreshDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "refreshDate")]
		public DateTimeOffset? RefreshDate { get; set; }

		///<summary>
		/// RefreshSource ID
		/// <para>Name: RefreshSourceId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "refreshSourceId")]
		public string RefreshSourceId { get; set; }

		///<summary>
		/// ReferenceTo: DevopsEnvironment
		/// <para>RelationshipName: RefreshSource</para>
		///</summary>
		[JsonProperty(PropertyName = "refreshSource")]
		[Updateable(false), Createable(false)]
		public SfDevopsEnvironment RefreshSource { get; set; }

		///<summary>
		/// Is Test Environment
		/// <para>Name: IsTestEnvironment</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isTestEnvironment")]
		public bool? IsTestEnvironment { get; set; }

		///<summary>
		/// Is Dev Environment
		/// <para>Name: IsDevEnvironment</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDevEnvironment")]
		public bool? IsDevEnvironment { get; set; }

		///<summary>
		/// Org Type
		/// <para>Name: OrgType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "orgType")]
		public string OrgType { get; set; }

		///<summary>
		/// Org URL
		/// <para>Name: OrgUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "orgUrl")]
		public string OrgUrl { get; set; }

		///<summary>
		/// DevOps Environment ID
		/// <para>Name: ReplacesId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "replacesId")]
		public string ReplacesId { get; set; }

		///<summary>
		/// ReferenceTo: DevopsEnvironment
		/// <para>RelationshipName: Replaces</para>
		///</summary>
		[JsonProperty(PropertyName = "replaces")]
		[Updateable(false), Createable(false)]
		public SfDevopsEnvironment Replaces { get; set; }

		///<summary>
		/// Doce Hub Type
		/// <para>Name: DoceHubType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "doceHubType")]
		[Updateable(false), Createable(false)]
		public string DoceHubType { get; set; }

		///<summary>
		/// Is Vibe Environment
		/// <para>Name: IsVibeEnvironment</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isVibeEnvironment")]
		public bool? IsVibeEnvironment { get; set; }

		///<summary>
		/// External Id
		/// <para>Name: ExternalId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "externalId")]
		public string ExternalId { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		public string Status { get; set; }

	}
}
