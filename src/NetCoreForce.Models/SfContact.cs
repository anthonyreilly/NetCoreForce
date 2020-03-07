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
	/// Contact
	///<para>SObject Name: Contact</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfContact : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "Contact"; }
		}

		///<summary>
		/// Contact ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Creatable(false)]
		public bool? IsDeleted { get; set; }

		///<summary>
		/// Master Record ID
		/// <para>Name: MasterRecordId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "masterRecordId")]
		[Updateable(false), Creatable(false)]
		public string MasterRecordId { get; set; }

		///<summary>
		/// ReferenceTo: Contact
		/// <para>RelationshipName: MasterRecord</para>
		///</summary>
		[JsonProperty(PropertyName = "masterRecord")]
		[Updateable(false), Creatable(false)]
		public SfContact MasterRecord { get; set; }

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
		[Updateable(false), Creatable(false)]
		public SfAccount Account { get; set; }

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
		/// Full Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Creatable(false)]
		public string Name { get; set; }

		///<summary>
		/// Other Street
		/// <para>Name: OtherStreet</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "otherStreet")]
		public string OtherStreet { get; set; }

		///<summary>
		/// Other City
		/// <para>Name: OtherCity</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "otherCity")]
		public string OtherCity { get; set; }

		///<summary>
		/// Other State/Province
		/// <para>Name: OtherState</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "otherState")]
		public string OtherState { get; set; }

		///<summary>
		/// Other Zip/Postal Code
		/// <para>Name: OtherPostalCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "otherPostalCode")]
		public string OtherPostalCode { get; set; }

		///<summary>
		/// Other Country
		/// <para>Name: OtherCountry</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "otherCountry")]
		public string OtherCountry { get; set; }

		///<summary>
		/// Other Latitude
		/// <para>Name: OtherLatitude</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "otherLatitude")]
		public double? OtherLatitude { get; set; }

		///<summary>
		/// Other Longitude
		/// <para>Name: OtherLongitude</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "otherLongitude")]
		public double? OtherLongitude { get; set; }

		///<summary>
		/// Other Geocode Accuracy
		/// <para>Name: OtherGeocodeAccuracy</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "otherGeocodeAccuracy")]
		public string OtherGeocodeAccuracy { get; set; }

		///<summary>
		/// Other Address
		/// <para>Name: OtherAddress</para>
		/// <para>SF Type: address</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "otherAddress")]
		[Updateable(false), Creatable(false)]
		public Address OtherAddress { get; set; }

		///<summary>
		/// Mailing Street
		/// <para>Name: MailingStreet</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mailingStreet")]
		public string MailingStreet { get; set; }

		///<summary>
		/// Mailing City
		/// <para>Name: MailingCity</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mailingCity")]
		public string MailingCity { get; set; }

		///<summary>
		/// Mailing State/Province
		/// <para>Name: MailingState</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mailingState")]
		public string MailingState { get; set; }

		///<summary>
		/// Mailing Zip/Postal Code
		/// <para>Name: MailingPostalCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mailingPostalCode")]
		public string MailingPostalCode { get; set; }

		///<summary>
		/// Mailing Country
		/// <para>Name: MailingCountry</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mailingCountry")]
		public string MailingCountry { get; set; }

		///<summary>
		/// Mailing Latitude
		/// <para>Name: MailingLatitude</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mailingLatitude")]
		public double? MailingLatitude { get; set; }

		///<summary>
		/// Mailing Longitude
		/// <para>Name: MailingLongitude</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mailingLongitude")]
		public double? MailingLongitude { get; set; }

		///<summary>
		/// Mailing Geocode Accuracy
		/// <para>Name: MailingGeocodeAccuracy</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mailingGeocodeAccuracy")]
		public string MailingGeocodeAccuracy { get; set; }

		///<summary>
		/// Mailing Address
		/// <para>Name: MailingAddress</para>
		/// <para>SF Type: address</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mailingAddress")]
		[Updateable(false), Creatable(false)]
		public Address MailingAddress { get; set; }

		///<summary>
		/// Business Phone
		/// <para>Name: Phone</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "phone")]
		public string Phone { get; set; }

		///<summary>
		/// Business Fax
		/// <para>Name: Fax</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fax")]
		public string Fax { get; set; }

		///<summary>
		/// Mobile Phone
		/// <para>Name: MobilePhone</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mobilePhone")]
		public string MobilePhone { get; set; }

		///<summary>
		/// Home Phone
		/// <para>Name: HomePhone</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "homePhone")]
		public string HomePhone { get; set; }

		///<summary>
		/// Other Phone
		/// <para>Name: OtherPhone</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "otherPhone")]
		public string OtherPhone { get; set; }

		///<summary>
		/// Asst. Phone
		/// <para>Name: AssistantPhone</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "assistantPhone")]
		public string AssistantPhone { get; set; }

		///<summary>
		/// Reports To ID
		/// <para>Name: ReportsToId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "reportsToId")]
		public string ReportsToId { get; set; }

		///<summary>
		/// ReferenceTo: Contact
		/// <para>RelationshipName: ReportsTo</para>
		///</summary>
		[JsonProperty(PropertyName = "reportsTo")]
		[Updateable(false), Creatable(false)]
		public SfContact ReportsTo { get; set; }

		///<summary>
		/// Email
		/// <para>Name: Email</para>
		/// <para>SF Type: email</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "email")]
		public string Email { get; set; }

		///<summary>
		/// Title
		/// <para>Name: Title</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "title")]
		public string Title { get; set; }

		///<summary>
		/// Department
		/// <para>Name: Department</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "department")]
		public string Department { get; set; }

		///<summary>
		/// Assistant&#39;s Name
		/// <para>Name: AssistantName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "assistantName")]
		public string AssistantName { get; set; }

		///<summary>
		/// Lead Source
		/// <para>Name: LeadSource</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "leadSource")]
		public string LeadSource { get; set; }

		///<summary>
		/// Birthdate
		/// <para>Name: Birthdate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "birthdate")]
		public DateTime? Birthdate { get; set; }

		///<summary>
		/// Contact Description
		/// <para>Name: Description</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

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
		[Updateable(false), Creatable(false)]
		public SfUser Owner { get; set; }

		///<summary>
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

		///<summary>
		/// Created By ID
		/// <para>Name: CreatedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdById")]
		[Updateable(false), Creatable(false)]
		public string CreatedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: CreatedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "createdBy")]
		[Updateable(false), Creatable(false)]
		public SfUser CreatedBy { get; set; }

		///<summary>
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

		///<summary>
		/// Last Modified By ID
		/// <para>Name: LastModifiedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedById")]
		[Updateable(false), Creatable(false)]
		public string LastModifiedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: LastModifiedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedBy")]
		[Updateable(false), Creatable(false)]
		public SfUser LastModifiedBy { get; set; }

		///<summary>
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

		///<summary>
		/// Last Activity
		/// <para>Name: LastActivityDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastActivityDate")]
		[Updateable(false), Creatable(false)]
		public DateTime? LastActivityDate { get; set; }

		///<summary>
		/// Last Stay-in-Touch Request Date
		/// <para>Name: LastCURequestDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastCURequestDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? LastCURequestDate { get; set; }

		///<summary>
		/// Last Stay-in-Touch Save Date
		/// <para>Name: LastCUUpdateDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastCUUpdateDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? LastCUUpdateDate { get; set; }

		///<summary>
		/// Last Viewed Date
		/// <para>Name: LastViewedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastViewedDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? LastViewedDate { get; set; }

		///<summary>
		/// Last Referenced Date
		/// <para>Name: LastReferencedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastReferencedDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? LastReferencedDate { get; set; }

		///<summary>
		/// Email Bounced Reason
		/// <para>Name: EmailBouncedReason</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "emailBouncedReason")]
		public string EmailBouncedReason { get; set; }

		///<summary>
		/// Email Bounced Date
		/// <para>Name: EmailBouncedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "emailBouncedDate")]
		public DateTimeOffset? EmailBouncedDate { get; set; }

		///<summary>
		/// Is Email Bounced
		/// <para>Name: IsEmailBounced</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isEmailBounced")]
		[Updateable(false), Creatable(false)]
		public bool? IsEmailBounced { get; set; }

		///<summary>
		/// Photo URL
		/// <para>Name: PhotoUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "photoUrl")]
		[Updateable(false), Creatable(false)]
		public string PhotoUrl { get; set; }

		///<summary>
		/// Data.com Key
		/// <para>Name: Jigsaw</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "jigsaw")]
		public string Jigsaw { get; set; }

		///<summary>
		/// Jigsaw Contact ID
		/// <para>Name: JigsawContactId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "jigsawContactId")]
		[Updateable(false), Creatable(false)]
		public string JigsawContactId { get; set; }

		///<summary>
		/// Clean Status
		/// <para>Name: CleanStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "cleanStatus")]
		public string CleanStatus { get; set; }

	}
}
