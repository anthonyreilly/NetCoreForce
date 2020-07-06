// SF API version v48.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Opportunity History
	///<para>SObject Name: OpportunityHistory</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfOpportunityHistory : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "OpportunityHistory"; }
		}

		///<summary>
		/// Opportunity History ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Opportunity ID
		/// <para>Name: OpportunityId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "opportunityId")]
		[Updateable(false), Createable(false)]
		public string OpportunityId { get; set; }

		///<summary>
		/// ReferenceTo: Opportunity
		/// <para>RelationshipName: Opportunity</para>
		///</summary>
		[JsonProperty(PropertyName = "opportunity")]
		[Updateable(false), Createable(false)]
		public SfOpportunity Opportunity { get; set; }

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
		/// Stage Name
		/// <para>Name: StageName</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "stageName")]
		[Updateable(false), Createable(false)]
		public string StageName { get; set; }

		///<summary>
		/// Amount
		/// <para>Name: Amount</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "amount")]
		[Updateable(false), Createable(false)]
		public decimal? Amount { get; set; }

		///<summary>
		/// Expected Revenue
		/// <para>Name: ExpectedRevenue</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "expectedRevenue")]
		[Updateable(false), Createable(false)]
		public decimal? ExpectedRevenue { get; set; }

		///<summary>
		/// Close Date
		/// <para>Name: CloseDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "closeDate")]
		[Updateable(false), Createable(false)]
		public DateTime? CloseDate { get; set; }

		///<summary>
		/// Probability
		/// <para>Name: Probability</para>
		/// <para>SF Type: percent</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "probability")]
		[Updateable(false), Createable(false)]
		public double? Probability { get; set; }

		///<summary>
		/// To ForecastCategory
		/// <para>Name: ForecastCategory</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "forecastCategory")]
		[Updateable(false), Createable(false)]
		public string ForecastCategory { get; set; }

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
