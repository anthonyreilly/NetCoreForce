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
	/// Campaign
	///<para>SObject Name: Campaign</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfCampaign : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "Campaign"; }
		}

		///<summary>
		/// Campaign ID
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
		/// Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		///<summary>
		/// Parent Campaign ID
		/// <para>Name: ParentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "parentId")]
		public string ParentId { get; set; }

		///<summary>
		/// ReferenceTo: Campaign
		/// <para>RelationshipName: Parent</para>
		///</summary>
		[JsonProperty(PropertyName = "parent")]
		[Updateable(false), Createable(false)]
		public SfCampaign Parent { get; set; }

		///<summary>
		/// Type
		/// <para>Name: Type</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		public string Type { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		public string Status { get; set; }

		///<summary>
		/// Start Date
		/// <para>Name: StartDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "startDate")]
		public string StartDate { get; set; }

		///<summary>
		/// End Date
		/// <para>Name: EndDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "endDate")]
		public string EndDate { get; set; }

		///<summary>
		/// Expected Revenue in Campaign
		/// <para>Name: ExpectedRevenue</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "expectedRevenue")]
		public decimal? ExpectedRevenue { get; set; }

		///<summary>
		/// Budgeted Cost in Campaign
		/// <para>Name: BudgetedCost</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "budgetedCost")]
		public decimal? BudgetedCost { get; set; }

		///<summary>
		/// Actual Cost in Campaign
		/// <para>Name: ActualCost</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "actualCost")]
		public decimal? ActualCost { get; set; }

		///<summary>
		/// Expected Response (%)
		/// <para>Name: ExpectedResponse</para>
		/// <para>SF Type: percent</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "expectedResponse")]
		public double? ExpectedResponse { get; set; }

		///<summary>
		/// Num Sent in Campaign
		/// <para>Name: NumberSent</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "numberSent")]
		public double? NumberSent { get; set; }

		///<summary>
		/// Active
		/// <para>Name: IsActive</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isActive")]
		public bool? IsActive { get; set; }

		///<summary>
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

		///<summary>
		/// Leads in Campaign
		/// <para>Name: NumberOfLeads</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "numberOfLeads")]
		[Updateable(false), Createable(false)]
		public int? NumberOfLeads { get; set; }

		///<summary>
		/// Converted Leads in Campaign
		/// <para>Name: NumberOfConvertedLeads</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "numberOfConvertedLeads")]
		[Updateable(false), Createable(false)]
		public int? NumberOfConvertedLeads { get; set; }

		///<summary>
		/// Contacts in Campaign
		/// <para>Name: NumberOfContacts</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "numberOfContacts")]
		[Updateable(false), Createable(false)]
		public int? NumberOfContacts { get; set; }

		///<summary>
		/// Responses in Campaign
		/// <para>Name: NumberOfResponses</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "numberOfResponses")]
		[Updateable(false), Createable(false)]
		public int? NumberOfResponses { get; set; }

		///<summary>
		/// Opportunities in Campaign
		/// <para>Name: NumberOfOpportunities</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "numberOfOpportunities")]
		[Updateable(false), Createable(false)]
		public int? NumberOfOpportunities { get; set; }

		///<summary>
		/// Won Opportunities in Campaign
		/// <para>Name: NumberOfWonOpportunities</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "numberOfWonOpportunities")]
		[Updateable(false), Createable(false)]
		public int? NumberOfWonOpportunities { get; set; }

		///<summary>
		/// Value Opportunities in Campaign
		/// <para>Name: AmountAllOpportunities</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "amountAllOpportunities")]
		[Updateable(false), Createable(false)]
		public decimal? AmountAllOpportunities { get; set; }

		///<summary>
		/// Value Won Opportunities in Campaign
		/// <para>Name: AmountWonOpportunities</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "amountWonOpportunities")]
		[Updateable(false), Createable(false)]
		public decimal? AmountWonOpportunities { get; set; }

		///<summary>
		/// Owner ID
		/// <para>Name: OwnerId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "ownerId")]
		public string OwnerId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: Owner</para>
		///</summary>
		[JsonProperty(PropertyName = "owner")]
		[Updateable(false), Createable(false)]
		public SfUser Owner { get; set; }

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
		/// Last Activity
		/// <para>Name: LastActivityDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastActivityDate")]
		[Updateable(false), Createable(false)]
		public string LastActivityDate { get; set; }

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
		/// Record Type ID
		/// <para>Name: CampaignMemberRecordTypeId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "campaignMemberRecordTypeId")]
		public string CampaignMemberRecordTypeId { get; set; }

		///<summary>
		/// ReferenceTo: RecordType
		/// <para>RelationshipName: CampaignMemberRecordType</para>
		///</summary>
		[JsonProperty(PropertyName = "campaignMemberRecordType")]
		[Updateable(false), Createable(false)]
		public SfRecordType CampaignMemberRecordType { get; set; }

	}
}
