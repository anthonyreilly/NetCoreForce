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
	/// Case Solution
	///<para>SObject Name: CaseSolution</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfCaseSolution : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "CaseSolution"; }
		}

		///<summary>
		/// Case Solution ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Case ID
		/// <para>Name: CaseId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "caseId")]
		[Updateable(false), Createable(true)]
		public string CaseId { get; set; }

		///<summary>
		/// ReferenceTo: Case
		/// <para>RelationshipName: Case</para>
		///</summary>
		[JsonProperty(PropertyName = "case")]
		[Updateable(false), Createable(false)]
		public SfCase Case { get; set; }

		///<summary>
		/// Solution ID
		/// <para>Name: SolutionId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "solutionId")]
		[Updateable(false), Createable(true)]
		public string SolutionId { get; set; }

		///<summary>
		/// ReferenceTo: Solution
		/// <para>RelationshipName: Solution</para>
		///</summary>
		[JsonProperty(PropertyName = "solution")]
		[Updateable(false), Createable(false)]
		public SfSolution Solution { get; set; }

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
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

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
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Createable(false)]
		public bool? IsDeleted { get; set; }

	}
}
