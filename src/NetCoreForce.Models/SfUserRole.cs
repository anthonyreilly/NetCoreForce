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
	/// Role
	///<para>SObject Name: UserRole</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfUserRole : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "UserRole"; }
		}

		///<summary>
		/// Role ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		///<summary>
		/// Parent Role ID
		/// <para>Name: ParentRoleId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "parentRoleId")]
		public string ParentRoleId { get; set; }

		///<summary>
		/// Description
		/// <para>Name: RollupDescription</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "rollupDescription")]
		public string RollupDescription { get; set; }

		///<summary>
		/// Opportunity Access Level for Account Owner
		/// <para>Name: OpportunityAccessForAccountOwner</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "opportunityAccessForAccountOwner")]
		public string OpportunityAccessForAccountOwner { get; set; }

		///<summary>
		/// Case Access Level for Account Owner
		/// <para>Name: CaseAccessForAccountOwner</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "caseAccessForAccountOwner")]
		public string CaseAccessForAccountOwner { get; set; }

		///<summary>
		/// Contact Access Level for Account Owner
		/// <para>Name: ContactAccessForAccountOwner</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contactAccessForAccountOwner")]
		[Updateable(false), Createable(false)]
		public string ContactAccessForAccountOwner { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: ForecastUserId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "forecastUserId")]
		public string ForecastUserId { get; set; }

		///<summary>
		/// May Forecast Manager Share
		/// <para>Name: MayForecastManagerShare</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "mayForecastManagerShare")]
		[Updateable(false), Createable(false)]
		public bool? MayForecastManagerShare { get; set; }

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
		/// Developer Name
		/// <para>Name: DeveloperName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "developerName")]
		public string DeveloperName { get; set; }

		///<summary>
		/// Account ID
		/// <para>Name: PortalAccountId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "portalAccountId")]
		[Updateable(false), Createable(true)]
		public string PortalAccountId { get; set; }

		///<summary>
		/// Portal Type
		/// <para>Name: PortalType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "portalType")]
		[Updateable(false), Createable(true)]
		public string PortalType { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: PortalAccountOwnerId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "portalAccountOwnerId")]
		[Updateable(false), Createable(false)]
		public string PortalAccountOwnerId { get; set; }

	}
}
