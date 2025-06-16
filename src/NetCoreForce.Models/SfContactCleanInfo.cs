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
	/// Contact Clean Info
	///<para>SObject Name: ContactCleanInfo</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfContactCleanInfo : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ContactCleanInfo"; }
		}

		///<summary>
		/// Contact Clean Info ID
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
		/// Contact Clean Info Name
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
		/// Contact ID
		/// <para>Name: ContactId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "contactId")]
		[Updateable(false), Createable(false)]
		public string ContactId { get; set; }

		///<summary>
		/// ReferenceTo: Contact
		/// <para>RelationshipName: Contact</para>
		///</summary>
		[JsonProperty(PropertyName = "contact")]
		[Updateable(false), Createable(false)]
		public SfContact Contact { get; set; }

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
