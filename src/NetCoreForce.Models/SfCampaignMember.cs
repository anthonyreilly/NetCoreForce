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
	/// Campaign Member
	///<para>SObject Name: CampaignMember</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfCampaignMember : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "CampaignMember"; }
		}

		///<summary>
		/// Campaign Member ID
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
		/// Campaign ID
		/// <para>Name: CampaignId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "campaignId")]
		[Updateable(false), Createable(true)]
		public string CampaignId { get; set; }

		///<summary>
		/// ReferenceTo: Campaign
		/// <para>RelationshipName: Campaign</para>
		///</summary>
		[JsonProperty(PropertyName = "campaign")]
		[Updateable(false), Createable(false)]
		public SfCampaign Campaign { get; set; }

		///<summary>
		/// Lead ID
		/// <para>Name: LeadId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "leadId")]
		[Updateable(false), Createable(true)]
		public string LeadId { get; set; }

		///<summary>
		/// ReferenceTo: Lead
		/// <para>RelationshipName: Lead</para>
		///</summary>
		[JsonProperty(PropertyName = "lead")]
		[Updateable(false), Createable(false)]
		public SfLead Lead { get; set; }

		///<summary>
		/// Contact ID
		/// <para>Name: ContactId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contactId")]
		[Updateable(false), Createable(true)]
		public string ContactId { get; set; }

		///<summary>
		/// ReferenceTo: Contact
		/// <para>RelationshipName: Contact</para>
		///</summary>
		[JsonProperty(PropertyName = "contact")]
		[Updateable(false), Createable(false)]
		public SfContact Contact { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		public string Status { get; set; }

		///<summary>
		/// Responded
		/// <para>Name: HasResponded</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasResponded")]
		[Updateable(false), Createable(false)]
		public bool? HasResponded { get; set; }

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
		/// First Responded Date
		/// <para>Name: FirstRespondedDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "firstRespondedDate")]
		[Updateable(false), Createable(false)]
		public DateTime? FirstRespondedDate { get; set; }

		///<summary>
		/// Salutation
		/// <para>Name: Salutation</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "salutation")]
		[Updateable(false), Createable(false)]
		public string Salutation { get; set; }

		///<summary>
		/// Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
		public string Name { get; set; }

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
		/// Title
		/// <para>Name: Title</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "title")]
		[Updateable(false), Createable(false)]
		public string Title { get; set; }

		///<summary>
		/// Street
		/// <para>Name: Street</para>
		/// <para>SF Type: string</para>
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
		/// State/Province
		/// <para>Name: State</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "state")]
		[Updateable(false), Createable(false)]
		public string State { get; set; }

		///<summary>
		/// Zip/Postal Code
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
		/// Fax
		/// <para>Name: Fax</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fax")]
		[Updateable(false), Createable(false)]
		public string Fax { get; set; }

		///<summary>
		/// Mobile
		/// <para>Name: MobilePhone</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mobilePhone")]
		[Updateable(false), Createable(false)]
		public string MobilePhone { get; set; }

		///<summary>
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		[Updateable(false), Createable(false)]
		public string Description { get; set; }

		///<summary>
		/// Do Not Call
		/// <para>Name: DoNotCall</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "doNotCall")]
		[Updateable(false), Createable(false)]
		public bool? DoNotCall { get; set; }

		///<summary>
		/// Email Opt Out
		/// <para>Name: HasOptedOutOfEmail</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasOptedOutOfEmail")]
		[Updateable(false), Createable(false)]
		public bool? HasOptedOutOfEmail { get; set; }

		///<summary>
		/// Fax Opt Out
		/// <para>Name: HasOptedOutOfFax</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasOptedOutOfFax")]
		[Updateable(false), Createable(false)]
		public bool? HasOptedOutOfFax { get; set; }

		///<summary>
		/// Lead Source
		/// <para>Name: LeadSource</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "leadSource")]
		[Updateable(false), Createable(false)]
		public string LeadSource { get; set; }

		///<summary>
		/// Company (Account)
		/// <para>Name: CompanyOrAccount</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "companyOrAccount")]
		[Updateable(false), Createable(false)]
		public string CompanyOrAccount { get; set; }

		///<summary>
		/// Type
		/// <para>Name: Type</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		[Updateable(false), Createable(false)]
		public string Type { get; set; }

		///<summary>
		/// Lead/Contact ID
		/// <para>Name: LeadOrContactId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "leadOrContactId")]
		[Updateable(false), Createable(false)]
		public string LeadOrContactId { get; set; }

		///<summary>
		/// Lead/Contact Owner ID
		/// <para>Name: LeadOrContactOwnerId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "leadOrContactOwnerId")]
		[Updateable(false), Createable(false)]
		public string LeadOrContactOwnerId { get; set; }

	}
}
