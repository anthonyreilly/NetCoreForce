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
	/// Case Team Member
	///<para>SObject Name: CaseTeamMember</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfCaseTeamMember : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "CaseTeamMember"; }
		}

		///<summary>
		/// Team Member Id
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Case ID
		/// <para>Name: ParentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "parentId")]
		[Updateable(false), Createable(true)]
		public string ParentId { get; set; }

		///<summary>
		/// ReferenceTo: Case
		/// <para>RelationshipName: Parent</para>
		///</summary>
		[JsonProperty(PropertyName = "parent")]
		[Updateable(false), Createable(false)]
		public SfCase Parent { get; set; }

		///<summary>
		/// Member ID
		/// <para>Name: MemberId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "memberId")]
		[Updateable(false), Createable(true)]
		public string MemberId { get; set; }

		///<summary>
		/// Team Template Member ID
		/// <para>Name: TeamTemplateMemberId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "teamTemplateMemberId")]
		[Updateable(false), Createable(false)]
		public string TeamTemplateMemberId { get; set; }

		///<summary>
		/// ReferenceTo: CaseTeamTemplateMember
		/// <para>RelationshipName: TeamTemplateMember</para>
		///</summary>
		[JsonProperty(PropertyName = "teamTemplateMember")]
		[Updateable(false), Createable(false)]
		public SfCaseTeamTemplateMember TeamTemplateMember { get; set; }

		///<summary>
		/// Team Role ID
		/// <para>Name: TeamRoleId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "teamRoleId")]
		public string TeamRoleId { get; set; }

		///<summary>
		/// ReferenceTo: CaseTeamRole
		/// <para>RelationshipName: TeamRole</para>
		///</summary>
		[JsonProperty(PropertyName = "teamRole")]
		[Updateable(false), Createable(false)]
		public SfCaseTeamRole TeamRole { get; set; }

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
