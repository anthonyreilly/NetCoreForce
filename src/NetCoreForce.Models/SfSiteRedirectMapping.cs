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
	/// Site Redirect Mapping
	///<para>SObject Name: SiteRedirectMapping</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfSiteRedirectMapping : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "SiteRedirectMapping"; }
		}

		///<summary>
		/// Site Redirect Mapping ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Site ID
		/// <para>Name: SiteId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "siteId")]
		[Updateable(false), Createable(true)]
		public string SiteId { get; set; }

		///<summary>
		/// ReferenceTo: Site
		/// <para>RelationshipName: Site</para>
		///</summary>
		[JsonProperty(PropertyName = "site")]
		[Updateable(false), Createable(false)]
		public SfSite Site { get; set; }

		///<summary>
		/// Active
		/// <para>Name: IsActive</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isActive")]
		public bool? IsActive { get; set; }

		///<summary>
		/// Source URL
		/// <para>Name: Source</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "source")]
		[Updateable(false), Createable(true)]
		public string Source { get; set; }

		///<summary>
		/// Target URL
		/// <para>Name: Target</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "target")]
		[Updateable(false), Createable(true)]
		public string Target { get; set; }

		///<summary>
		/// Redirect Type
		/// <para>Name: Action</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "action")]
		[Updateable(false), Createable(true)]
		public string Action { get; set; }

		///<summary>
		/// Dynamic
		/// <para>Name: IsDynamic</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDynamic")]
		public bool? IsDynamic { get; set; }

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

	}
}
