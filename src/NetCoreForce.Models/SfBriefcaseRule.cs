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
	/// Briefcase Rule
	///<para>SObject Name: BriefcaseRule</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfBriefcaseRule : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "BriefcaseRule"; }
		}

		///<summary>
		/// Briefcase Rule ID
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
		/// Briefcase Definition ID
		/// <para>Name: BriefcaseId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "briefcaseId")]
		[Updateable(false), Createable(false)]
		public string BriefcaseId { get; set; }

		///<summary>
		/// ReferenceTo: BriefcaseDefinition
		/// <para>RelationshipName: Briefcase</para>
		///</summary>
		[JsonProperty(PropertyName = "briefcase")]
		[Updateable(false), Createable(false)]
		public SfBriefcaseDefinition Briefcase { get; set; }

		///<summary>
		/// Target Object
		/// <para>Name: TargetEntity</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "targetEntity")]
		[Updateable(false), Createable(false)]
		public string TargetEntity { get; set; }

		///<summary>
		/// Briefcase Rule ID
		/// <para>Name: ParentRuleId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "parentRuleId")]
		[Updateable(false), Createable(false)]
		public string ParentRuleId { get; set; }

		///<summary>
		/// ReferenceTo: BriefcaseRule
		/// <para>RelationshipName: ParentRule</para>
		///</summary>
		[JsonProperty(PropertyName = "parentRule")]
		[Updateable(false), Createable(false)]
		public SfBriefcaseRule ParentRule { get; set; }

		///<summary>
		/// Filter Logic
		/// <para>Name: FilterLogic</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "filterLogic")]
		[Updateable(false), Createable(false)]
		public string FilterLogic { get; set; }

		///<summary>
		/// Scope
		/// <para>Name: QueryScope</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "queryScope")]
		[Updateable(false), Createable(false)]
		public string QueryScope { get; set; }

		///<summary>
		/// Limit
		/// <para>Name: RecordLimit</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recordLimit")]
		[Updateable(false), Createable(false)]
		public int? RecordLimit { get; set; }

		///<summary>
		/// Order By
		/// <para>Name: OrderBy</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "orderBy")]
		[Updateable(false), Createable(false)]
		public string OrderBy { get; set; }

		///<summary>
		/// Ascending
		/// <para>Name: IsAscendingOrder</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isAscendingOrder")]
		[Updateable(false), Createable(false)]
		public bool? IsAscendingOrder { get; set; }

		///<summary>
		/// Custom Field Definition ID
		/// <para>Name: RelationshipField</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relationshipField")]
		[Updateable(false), Createable(false)]
		public string RelationshipField { get; set; }

		///<summary>
		/// Relationship Type
		/// <para>Name: RelationshipType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relationshipType")]
		[Updateable(false), Createable(false)]
		public string RelationshipType { get; set; }

		///<summary>
		/// IsRelatedFilesRule
		/// <para>Name: OptionsIsRelatedFilesRule</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsIsRelatedFilesRule")]
		[Updateable(false), Createable(false)]
		public bool? OptionsIsRelatedFilesRule { get; set; }

	}
}
