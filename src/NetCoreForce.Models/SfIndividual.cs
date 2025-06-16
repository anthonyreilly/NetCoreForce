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
	/// Individual
	///<para>SObject Name: Individual</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfIndividual : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "Individual"; }
		}

		///<summary>
		/// Individual ID
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
		/// ReferenceTo: User
		/// <para>RelationshipName: Owner</para>
		///</summary>
		[JsonProperty(PropertyName = "owner")]
		[Updateable(false), Createable(false)]
		public SfUser Owner { get; set; }

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
		/// Last Name
		/// <para>Name: LastName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastName")]
		public string LastName { get; set; }

		///<summary>
		/// First Name
		/// <para>Name: FirstName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "firstName")]
		public string FirstName { get; set; }

		///<summary>
		/// Salutation
		/// <para>Name: Salutation</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "salutation")]
		public string Salutation { get; set; }

		///<summary>
		/// Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
		public string Name { get; set; }

		///<summary>
		/// Don&#39;t Track
		/// <para>Name: HasOptedOutTracking</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasOptedOutTracking")]
		public bool? HasOptedOutTracking { get; set; }

		///<summary>
		/// Don&#39;t Profile
		/// <para>Name: HasOptedOutProfiling</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasOptedOutProfiling")]
		public bool? HasOptedOutProfiling { get; set; }

		///<summary>
		/// Don&#39;t Process
		/// <para>Name: HasOptedOutProcessing</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasOptedOutProcessing")]
		public bool? HasOptedOutProcessing { get; set; }

		///<summary>
		/// Don&#39;t Market
		/// <para>Name: HasOptedOutSolicit</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasOptedOutSolicit")]
		public bool? HasOptedOutSolicit { get; set; }

		///<summary>
		/// Forget this Individual
		/// <para>Name: ShouldForget</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "shouldForget")]
		public bool? ShouldForget { get; set; }

		///<summary>
		/// Export Individual&#39;s Data
		/// <para>Name: SendIndividualData</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "sendIndividualData")]
		public bool? SendIndividualData { get; set; }

		///<summary>
		/// OK to Store PII Data Elsewhere
		/// <para>Name: CanStorePiiElsewhere</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "canStorePiiElsewhere")]
		public bool? CanStorePiiElsewhere { get; set; }

		///<summary>
		/// Block Geolocation Tracking
		/// <para>Name: HasOptedOutGeoTracking</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasOptedOutGeoTracking")]
		public bool? HasOptedOutGeoTracking { get; set; }

		///<summary>
		/// Birth Date
		/// <para>Name: BirthDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "birthDate")]
		public DateTime? BirthDate { get; set; }

		///<summary>
		/// Death Date
		/// <para>Name: DeathDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "deathDate")]
		public DateTime? DeathDate { get; set; }

		///<summary>
		/// Conviction Count
		/// <para>Name: ConvictionsCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "convictionsCount")]
		public int? ConvictionsCount { get; set; }

		///<summary>
		/// Number of Children
		/// <para>Name: ChildrenCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "childrenCount")]
		public int? ChildrenCount { get; set; }

		///<summary>
		/// Military Service
		/// <para>Name: MilitaryService</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "militaryService")]
		public string MilitaryService { get; set; }

		///<summary>
		/// Is Homeowner
		/// <para>Name: IsHomeOwner</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isHomeOwner")]
		public bool? IsHomeOwner { get; set; }

		///<summary>
		/// Occupation
		/// <para>Name: Occupation</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "occupation")]
		public string Occupation { get; set; }

		///<summary>
		/// Website
		/// <para>Name: Website</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "website")]
		public string Website { get; set; }

		///<summary>
		/// Individual&#39;s Age
		/// <para>Name: IndividualsAge</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "individualsAge")]
		public string IndividualsAge { get; set; }

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
		/// Master Record ID
		/// <para>Name: MasterRecordId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "masterRecordId")]
		[Updateable(false), Createable(false)]
		public string MasterRecordId { get; set; }

		///<summary>
		/// ReferenceTo: Individual
		/// <para>RelationshipName: MasterRecord</para>
		///</summary>
		[JsonProperty(PropertyName = "masterRecord")]
		[Updateable(false), Createable(false)]
		public SfIndividual MasterRecord { get; set; }

		///<summary>
		/// Consumer Credit Score
		/// <para>Name: ConsumerCreditScore</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "consumerCreditScore")]
		public int? ConsumerCreditScore { get; set; }

		///<summary>
		/// Consumer Credit Score Provider Name
		/// <para>Name: ConsumerCreditScoreProviderName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "consumerCreditScoreProviderName")]
		public string ConsumerCreditScoreProviderName { get; set; }

		///<summary>
		/// Influencer Rating
		/// <para>Name: InfluencerRating</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "influencerRating")]
		public int? InfluencerRating { get; set; }

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
