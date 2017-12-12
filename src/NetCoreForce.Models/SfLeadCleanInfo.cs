// SF API version v41.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Lead Clean Info
	///<para>SObject Name: LeadCleanInfo</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfLeadCleanInfo : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "LeadCleanInfo"; }
		}

		///<summary>
		/// Lead Clean Info ID
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
		/// Lead Clean Info Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(true), Createable(false)]
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
		/// Lead ID
		/// <para>Name: LeadId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "leadId")]
		[Updateable(false), Createable(false)]
		public string LeadId { get; set; }

		///<summary>
		/// ReferenceTo: Lead
		/// <para>RelationshipName: Lead</para>
		///</summary>
		[JsonProperty(PropertyName = "lead")]
		[Updateable(false), Createable(false)]
		public SfLead Lead { get; set; }

		///<summary>
		/// Last Matched Date
		/// <para>Name: LastMatchedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastMatchedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastMatchedDate { get; set; }

		///<summary>
		/// Last Status Changed Date
		/// <para>Name: LastStatusChangedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastStatusChangedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastStatusChangedDate { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: LastStatusChangedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastStatusChangedById")]
		[Updateable(false), Createable(false)]
		public string LastStatusChangedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: LastStatusChangedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "lastStatusChangedBy")]
		[Updateable(false), Createable(false)]
		public SfUser LastStatusChangedBy { get; set; }

		///<summary>
		/// Contact Status in Salesforce
		/// <para>Name: IsInactive</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isInactive")]
		[Updateable(true), Createable(false)]
		public bool? IsInactive { get; set; }

		///<summary>
		/// First Name
		/// <para>Name: FirstName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "firstName")]
		[Updateable(false), Createable(false)]
		public string FirstName { get; set; }

		///<summary>
		/// Last Name
		/// <para>Name: LastName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastName")]
		[Updateable(false), Createable(false)]
		public string LastName { get; set; }

		///<summary>
		/// Email
		/// <para>Name: Email</para>
		/// <para>SF Type: email</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "email")]
		[Updateable(false), Createable(false)]
		public string Email { get; set; }

		///<summary>
		/// Phone
		/// <para>Name: Phone</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "phone")]
		[Updateable(false), Createable(false)]
		public string Phone { get; set; }

		///<summary>
		/// Street
		/// <para>Name: Street</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "street")]
		[Updateable(false), Createable(false)]
		public string Street { get; set; }

		///<summary>
		/// City
		/// <para>Name: City</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "city")]
		[Updateable(false), Createable(false)]
		public string City { get; set; }

		///<summary>
		/// State
		/// <para>Name: State</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "state")]
		[Updateable(false), Createable(false)]
		public string State { get; set; }

		///<summary>
		/// Zip
		/// <para>Name: PostalCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "postalCode")]
		[Updateable(false), Createable(false)]
		public string PostalCode { get; set; }

		///<summary>
		/// Country
		/// <para>Name: Country</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "country")]
		[Updateable(false), Createable(false)]
		public string Country { get; set; }

		///<summary>
		/// Latitude
		/// <para>Name: Latitude</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "latitude")]
		[Updateable(false), Createable(false)]
		public double? Latitude { get; set; }

		///<summary>
		/// Longitude
		/// <para>Name: Longitude</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "longitude")]
		[Updateable(false), Createable(false)]
		public double? Longitude { get; set; }

		///<summary>
		/// Geocode Accuracy
		/// <para>Name: GeocodeAccuracy</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "geocodeAccuracy")]
		[Updateable(false), Createable(false)]
		public string GeocodeAccuracy { get; set; }

		///<summary>
		/// Address
		/// <para>Name: Address</para>
		/// <para>SF Type: address</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "address")]
		[Updateable(false), Createable(false)]
		public Address Address { get; set; }

		///<summary>
		/// Title
		/// <para>Name: Title</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "title")]
		[Updateable(false), Createable(false)]
		public string Title { get; set; }

		///<summary>
		/// Annual Revenue
		/// <para>Name: AnnualRevenue</para>
		/// <para>SF Type: currency</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "annualRevenue")]
		[Updateable(false), Createable(false)]
		public decimal? AnnualRevenue { get; set; }

		///<summary>
		/// Number of Employees
		/// <para>Name: NumberOfEmployees</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "numberOfEmployees")]
		[Updateable(false), Createable(false)]
		public int? NumberOfEmployees { get; set; }

		///<summary>
		/// Industry
		/// <para>Name: Industry</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "industry")]
		[Updateable(false), Createable(false)]
		public string Industry { get; set; }

		///<summary>
		/// Company Name
		/// <para>Name: CompanyName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "companyName")]
		[Updateable(false), Createable(false)]
		public string CompanyName { get; set; }

		///<summary>
		/// Company D-U-N-S Number
		/// <para>Name: CompanyDunsNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "companyDunsNumber")]
		[Updateable(false), Createable(false)]
		public string CompanyDunsNumber { get; set; }

		///<summary>
		/// Contact Status per Data.com
		/// <para>Name: ContactStatusDataDotCom</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contactStatusDataDotCom")]
		[Updateable(false), Createable(false)]
		public string ContactStatusDataDotCom { get; set; }

		///<summary>
		/// Name is Reviewed
		/// <para>Name: IsReviewedName</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedName")]
		[Updateable(true), Createable(false)]
		public bool? IsReviewedName { get; set; }

		///<summary>
		/// Email is Reviewed
		/// <para>Name: IsReviewedEmail</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedEmail")]
		[Updateable(true), Createable(false)]
		public bool? IsReviewedEmail { get; set; }

		///<summary>
		/// Phone is Reviewed
		/// <para>Name: IsReviewedPhone</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedPhone")]
		[Updateable(true), Createable(false)]
		public bool? IsReviewedPhone { get; set; }

		///<summary>
		/// Address is Reviewed
		/// <para>Name: IsReviewedAddress</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedAddress")]
		[Updateable(true), Createable(false)]
		public bool? IsReviewedAddress { get; set; }

		///<summary>
		/// Title is Reviewed
		/// <para>Name: IsReviewedTitle</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedTitle")]
		[Updateable(true), Createable(false)]
		public bool? IsReviewedTitle { get; set; }

		///<summary>
		/// Annual Revenue is Reviewed
		/// <para>Name: IsReviewedAnnualRevenue</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedAnnualRevenue")]
		[Updateable(true), Createable(false)]
		public bool? IsReviewedAnnualRevenue { get; set; }

		///<summary>
		/// Number of Employees is Reviewed
		/// <para>Name: IsReviewedNumberOfEmployees</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedNumberOfEmployees")]
		[Updateable(true), Createable(false)]
		public bool? IsReviewedNumberOfEmployees { get; set; }

		///<summary>
		/// Industry is Reviewed
		/// <para>Name: IsReviewedIndustry</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedIndustry")]
		[Updateable(true), Createable(false)]
		public bool? IsReviewedIndustry { get; set; }

		///<summary>
		/// Company Name is Reviewed
		/// <para>Name: IsReviewedCompanyName</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedCompanyName")]
		[Updateable(true), Createable(false)]
		public bool? IsReviewedCompanyName { get; set; }

		///<summary>
		/// Company D-U-N-S Number is Reviewed
		/// <para>Name: IsReviewedCompanyDunsNumber</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedCompanyDunsNumber")]
		[Updateable(true), Createable(false)]
		public bool? IsReviewedCompanyDunsNumber { get; set; }

		///<summary>
		/// D&amp;B Company D-U-N-S Number is Reviewed
		/// <para>Name: IsReviewedDandBCompanyDunsNumber</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReviewedDandBCompanyDunsNumber")]
		[Updateable(true), Createable(false)]
		public bool? IsReviewedDandBCompanyDunsNumber { get; set; }

		///<summary>
		/// First Name is Different
		/// <para>Name: IsDifferentFirstName</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentFirstName")]
		[Updateable(false), Createable(false)]
		public bool? IsDifferentFirstName { get; set; }

		///<summary>
		/// Last Name is Different
		/// <para>Name: IsDifferentLastName</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentLastName")]
		[Updateable(false), Createable(false)]
		public bool? IsDifferentLastName { get; set; }

		///<summary>
		/// Email is Different
		/// <para>Name: IsDifferentEmail</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentEmail")]
		[Updateable(false), Createable(false)]
		public bool? IsDifferentEmail { get; set; }

		///<summary>
		/// Phone is Different
		/// <para>Name: IsDifferentPhone</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentPhone")]
		[Updateable(false), Createable(false)]
		public bool? IsDifferentPhone { get; set; }

		///<summary>
		/// Street is Different
		/// <para>Name: IsDifferentStreet</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentStreet")]
		[Updateable(false), Createable(false)]
		public bool? IsDifferentStreet { get; set; }

		///<summary>
		/// City is Different
		/// <para>Name: IsDifferentCity</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentCity")]
		[Updateable(false), Createable(false)]
		public bool? IsDifferentCity { get; set; }

		///<summary>
		/// State is Different
		/// <para>Name: IsDifferentState</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentState")]
		[Updateable(false), Createable(false)]
		public bool? IsDifferentState { get; set; }

		///<summary>
		/// ZIP is Different
		/// <para>Name: IsDifferentPostalCode</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentPostalCode")]
		[Updateable(false), Createable(false)]
		public bool? IsDifferentPostalCode { get; set; }

		///<summary>
		/// Country is Different
		/// <para>Name: IsDifferentCountry</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentCountry")]
		[Updateable(false), Createable(false)]
		public bool? IsDifferentCountry { get; set; }

		///<summary>
		/// Title is Different
		/// <para>Name: IsDifferentTitle</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentTitle")]
		[Updateable(false), Createable(false)]
		public bool? IsDifferentTitle { get; set; }

		///<summary>
		/// Annual Revenue is Different
		/// <para>Name: IsDifferentAnnualRevenue</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentAnnualRevenue")]
		[Updateable(false), Createable(false)]
		public bool? IsDifferentAnnualRevenue { get; set; }

		///<summary>
		/// Number of Employees is Different
		/// <para>Name: IsDifferentNumberOfEmployees</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentNumberOfEmployees")]
		[Updateable(false), Createable(false)]
		public bool? IsDifferentNumberOfEmployees { get; set; }

		///<summary>
		/// Industry is Different
		/// <para>Name: IsDifferentIndustry</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentIndustry")]
		[Updateable(false), Createable(false)]
		public bool? IsDifferentIndustry { get; set; }

		///<summary>
		/// Company Name is Different
		/// <para>Name: IsDifferentCompanyName</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentCompanyName")]
		[Updateable(false), Createable(false)]
		public bool? IsDifferentCompanyName { get; set; }

		///<summary>
		/// Company D-U-N-S Number is Different
		/// <para>Name: IsDifferentCompanyDunsNumber</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentCompanyDunsNumber")]
		[Updateable(false), Createable(false)]
		public bool? IsDifferentCompanyDunsNumber { get; set; }

		///<summary>
		/// D&amp;B Company D-U-N-S Number is Different
		/// <para>Name: IsDifferentDandBCompanyDunsNumber</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentDandBCompanyDunsNumber")]
		[Updateable(false), Createable(false)]
		public bool? IsDifferentDandBCompanyDunsNumber { get; set; }

		///<summary>
		/// State Code is Different
		/// <para>Name: IsDifferentStateCode</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentStateCode")]
		[Updateable(false), Createable(false)]
		public bool? IsDifferentStateCode { get; set; }

		///<summary>
		/// Country Code is Different
		/// <para>Name: IsDifferentCountryCode</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDifferentCountryCode")]
		[Updateable(false), Createable(false)]
		public bool? IsDifferentCountryCode { get; set; }

		///<summary>
		/// Cleaned by Job
		/// <para>Name: CleanedByJob</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "cleanedByJob")]
		[Updateable(false), Createable(false)]
		public bool? CleanedByJob { get; set; }

		///<summary>
		/// Cleaned by User
		/// <para>Name: CleanedByUser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "cleanedByUser")]
		[Updateable(false), Createable(false)]
		public bool? CleanedByUser { get; set; }

		///<summary>
		/// D&amp;B Company D-U-N-S Number
		/// <para>Name: DandBCompanyDunsNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dandBCompanyDunsNumber")]
		[Updateable(false), Createable(false)]
		public string DandBCompanyDunsNumber { get; set; }

		///<summary>
		/// Data.com Company ID
		/// <para>Name: DataDotComCompanyId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dataDotComCompanyId")]
		[Updateable(false), Createable(false)]
		public string DataDotComCompanyId { get; set; }

		///<summary>
		/// Name is Flagged Wrong
		/// <para>Name: IsFlaggedWrongName</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongName")]
		[Updateable(true), Createable(false)]
		public bool? IsFlaggedWrongName { get; set; }

		///<summary>
		/// Email is Flagged Wrong
		/// <para>Name: IsFlaggedWrongEmail</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongEmail")]
		[Updateable(true), Createable(false)]
		public bool? IsFlaggedWrongEmail { get; set; }

		///<summary>
		/// Phone is Flagged Wrong
		/// <para>Name: IsFlaggedWrongPhone</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongPhone")]
		[Updateable(true), Createable(false)]
		public bool? IsFlaggedWrongPhone { get; set; }

		///<summary>
		/// Address is Flagged Wrong
		/// <para>Name: IsFlaggedWrongAddress</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongAddress")]
		[Updateable(true), Createable(false)]
		public bool? IsFlaggedWrongAddress { get; set; }

		///<summary>
		/// Title is Flagged Wrong
		/// <para>Name: IsFlaggedWrongTitle</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongTitle")]
		[Updateable(true), Createable(false)]
		public bool? IsFlaggedWrongTitle { get; set; }

		///<summary>
		/// Annual Revenue is Flagged Wrong
		/// <para>Name: IsFlaggedWrongAnnualRevenue</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongAnnualRevenue")]
		[Updateable(true), Createable(false)]
		public bool? IsFlaggedWrongAnnualRevenue { get; set; }

		///<summary>
		/// Number of Employees is Flagged Wrong
		/// <para>Name: IsFlaggedWrongNumberOfEmployees</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongNumberOfEmployees")]
		[Updateable(true), Createable(false)]
		public bool? IsFlaggedWrongNumberOfEmployees { get; set; }

		///<summary>
		/// Industry is Flagged Wrong
		/// <para>Name: IsFlaggedWrongIndustry</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongIndustry")]
		[Updateable(true), Createable(false)]
		public bool? IsFlaggedWrongIndustry { get; set; }

		///<summary>
		/// Company Name is Flagged Wrong
		/// <para>Name: IsFlaggedWrongCompanyName</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongCompanyName")]
		[Updateable(true), Createable(false)]
		public bool? IsFlaggedWrongCompanyName { get; set; }

		///<summary>
		/// Company D-U-N-S Number is Flagged Wrong
		/// <para>Name: IsFlaggedWrongCompanyDunsNumber</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFlaggedWrongCompanyDunsNumber")]
		[Updateable(true), Createable(false)]
		public bool? IsFlaggedWrongCompanyDunsNumber { get; set; }

		///<summary>
		/// Data.com ID
		/// <para>Name: DataDotComId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dataDotComId")]
		[Updateable(false), Createable(false)]
		public string DataDotComId { get; set; }

	}
}
