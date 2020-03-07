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
	/// Data.com Contact
	///<para>SObject Name: DatacloudContact</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfDatacloudContact : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "DatacloudContact"; }
		}

		///<summary>
		/// System ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// Data.com Contact ID
		/// <para>Name: ExternalId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "externalId")]
		[Updateable(false), Creatable(false)]
		public string ExternalId { get; set; }

		///<summary>
		/// Company Id
		/// <para>Name: CompanyId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "companyId")]
		[Updateable(false), Creatable(false)]
		public string CompanyId { get; set; }

		///<summary>
		/// Data.com Contact ID
		/// <para>Name: ContactId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contactId")]
		[Updateable(false), Creatable(false)]
		public string ContactId { get; set; }

		///<summary>
		/// Company
		/// <para>Name: CompanyName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "companyName")]
		[Updateable(false), Creatable(false)]
		public string CompanyName { get; set; }

		///<summary>
		/// Title
		/// <para>Name: Title</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "title")]
		[Updateable(false), Creatable(false)]
		public string Title { get; set; }

		///<summary>
		/// Inactive Status
		/// <para>Name: IsInactive</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isInactive")]
		[Updateable(false), Creatable(false)]
		public bool? IsInactive { get; set; }

		///<summary>
		/// First name
		/// <para>Name: FirstName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "firstName")]
		[Updateable(false), Creatable(false)]
		public string FirstName { get; set; }

		///<summary>
		/// Last name
		/// <para>Name: LastName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastName")]
		[Updateable(false), Creatable(false)]
		public string LastName { get; set; }

		///<summary>
		/// Phone
		/// <para>Name: Phone</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "phone")]
		[Updateable(false), Creatable(false)]
		public string Phone { get; set; }

		///<summary>
		/// Email
		/// <para>Name: Email</para>
		/// <para>SF Type: email</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "email")]
		[Updateable(false), Creatable(false)]
		public string Email { get; set; }

		///<summary>
		/// Street Address
		/// <para>Name: Street</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "street")]
		[Updateable(false), Creatable(false)]
		public string Street { get; set; }

		///<summary>
		/// City
		/// <para>Name: City</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "city")]
		[Updateable(false), Creatable(false)]
		public string City { get; set; }

		///<summary>
		/// State
		/// <para>Name: State</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "state")]
		[Updateable(false), Creatable(false)]
		public string State { get; set; }

		///<summary>
		/// Country/Territory
		/// <para>Name: Country</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "country")]
		[Updateable(false), Creatable(false)]
		public string Country { get; set; }

		///<summary>
		/// ZIP code
		/// <para>Name: Zip</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "zip")]
		[Updateable(false), Creatable(false)]
		public string Zip { get; set; }

		///<summary>
		/// Department
		/// <para>Name: Department</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "department")]
		[Updateable(false), Creatable(false)]
		public string Department { get; set; }

		///<summary>
		/// Level
		/// <para>Name: Level</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "level")]
		[Updateable(false), Creatable(false)]
		public string Level { get; set; }

		///<summary>
		/// Owned
		/// <para>Name: IsOwned</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isOwned")]
		[Updateable(false), Creatable(false)]
		public bool? IsOwned { get; set; }

		///<summary>
		/// Updated Date
		/// <para>Name: UpdatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "updatedDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? UpdatedDate { get; set; }

		///<summary>
		/// In CRM
		/// <para>Name: IsInCrm</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isInCrm")]
		[Updateable(false), Creatable(false)]
		public bool? IsInCrm { get; set; }

	}
}
