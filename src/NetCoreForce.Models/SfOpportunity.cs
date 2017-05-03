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
	/// Opportunity
	///<para>SObject Name: Opportunity</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfOpportunity : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "Opportunity"; }
		}

		///<summary>
		/// Opportunity ID
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
		/// Account ID
		/// <para>Name: AccountId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "accountId")]
		public string AccountId { get; set; }

		///<summary>
		/// ReferenceTo: Account
		/// <para>RelationshipName: Account</para>
		///</summary>
		[JsonProperty(PropertyName = "account")]
		[Updateable(false), Createable(false)]
		public SfAccount Account { get; set; }

		///<summary>
		/// Private
		/// <para>Name: IsPrivate</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isPrivate")]
		public bool? IsPrivate { get; set; }

		///<summary>
		/// Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		///<summary>
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

		///<summary>
		/// Stage
		/// <para>Name: StageName</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "stageName")]
		public string StageName { get; set; }

		///<summary>
		/// Amount
		/// <para>Name: Amount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "amount")]
		public decimal? Amount { get; set; }

		///<summary>
		/// Probability (%)
		/// <para>Name: Probability</para>
		/// <para>SF Type: percent</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "probability")]
		public double? Probability { get; set; }

		///<summary>
		/// Expected Amount
		/// <para>Name: ExpectedRevenue</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "expectedRevenue")]
		[Updateable(false), Createable(false)]
		public decimal? ExpectedRevenue { get; set; }

		///<summary>
		/// Quantity
		/// <para>Name: TotalOpportunityQuantity</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalOpportunityQuantity")]
		public double? TotalOpportunityQuantity { get; set; }

		///<summary>
		/// Close Date
		/// <para>Name: CloseDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "closeDate")]
		public string CloseDate { get; set; }

		///<summary>
		/// Opportunity Type
		/// <para>Name: Type</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		public string Type { get; set; }

		///<summary>
		/// Next Step
		/// <para>Name: NextStep</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "nextStep")]
		public string NextStep { get; set; }

		///<summary>
		/// Lead Source
		/// <para>Name: LeadSource</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "leadSource")]
		public string LeadSource { get; set; }

		///<summary>
		/// Closed
		/// <para>Name: IsClosed</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isClosed")]
		[Updateable(false), Createable(false)]
		public bool? IsClosed { get; set; }

		///<summary>
		/// Won
		/// <para>Name: IsWon</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isWon")]
		[Updateable(false), Createable(false)]
		public bool? IsWon { get; set; }

		///<summary>
		/// Forecast Category
		/// <para>Name: ForecastCategory</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "forecastCategory")]
		[Updateable(false), Createable(false)]
		public string ForecastCategory { get; set; }

		///<summary>
		/// Forecast Category
		/// <para>Name: ForecastCategoryName</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "forecastCategoryName")]
		public string ForecastCategoryName { get; set; }

		///<summary>
		/// Campaign ID
		/// <para>Name: CampaignId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "campaignId")]
		public string CampaignId { get; set; }

		///<summary>
		/// ReferenceTo: Campaign
		/// <para>RelationshipName: Campaign</para>
		///</summary>
		[JsonProperty(PropertyName = "campaign")]
		[Updateable(false), Createable(false)]
		public SfCampaign Campaign { get; set; }

		///<summary>
		/// Has Line Item
		/// <para>Name: HasOpportunityLineItem</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasOpportunityLineItem")]
		[Updateable(false), Createable(false)]
		public bool? HasOpportunityLineItem { get; set; }

		///<summary>
		/// Price Book ID
		/// <para>Name: Pricebook2Id</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "pricebook2Id")]
		public string Pricebook2Id { get; set; }

		///<summary>
		/// ReferenceTo: Pricebook2
		/// <para>RelationshipName: Pricebook2</para>
		///</summary>
		[JsonProperty(PropertyName = "pricebook2")]
		[Updateable(false), Createable(false)]
		public SfPricebook2 Pricebook2 { get; set; }

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
		/// Fiscal Quarter
		/// <para>Name: FiscalQuarter</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fiscalQuarter")]
		[Updateable(false), Createable(false)]
		public int? FiscalQuarter { get; set; }

		///<summary>
		/// Fiscal Year
		/// <para>Name: FiscalYear</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fiscalYear")]
		[Updateable(false), Createable(false)]
		public int? FiscalYear { get; set; }

		///<summary>
		/// Fiscal Period
		/// <para>Name: Fiscal</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fiscal")]
		[Updateable(false), Createable(false)]
		public string Fiscal { get; set; }

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
		/// Has Open Activity
		/// <para>Name: HasOpenActivity</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasOpenActivity")]
		[Updateable(false), Createable(false)]
		public bool? HasOpenActivity { get; set; }

		///<summary>
		/// Has Overdue Task
		/// <para>Name: HasOverdueTask</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasOverdueTask")]
		[Updateable(false), Createable(false)]
		public bool? HasOverdueTask { get; set; }

	}
}
