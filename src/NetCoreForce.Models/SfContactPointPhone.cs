// SF API version v50.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Contact Point Phone
	///<para>SObject Name: ContactPointPhone</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfContactPointPhone : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ContactPointPhone"; }
		}

		///<summary>
		/// Contact Point Phone ID
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
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
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
		/// Parent ID
		/// <para>Name: ParentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "parentId")]
		public string ParentId { get; set; }

		///<summary>
		/// Active from Date
		/// <para>Name: ActiveFromDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "activeFromDate")]
		public DateTime? ActiveFromDate { get; set; }

		///<summary>
		/// Active to Date
		/// <para>Name: ActiveToDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "activeToDate")]
		public DateTime? ActiveToDate { get; set; }

		///<summary>
		/// Best time to contact end time
		/// <para>Name: BestTimeToContactEndTime</para>
		/// <para>SF Type: time</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "bestTimeToContactEndTime")]
		public string BestTimeToContactEndTime { get; set; }

		///<summary>
		/// Best time to contact start time
		/// <para>Name: BestTimeToContactStartTime</para>
		/// <para>SF Type: time</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "bestTimeToContactStartTime")]
		public string BestTimeToContactStartTime { get; set; }

		///<summary>
		/// Best time to contact time zone
		/// <para>Name: BestTimeToContactTimezone</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "bestTimeToContactTimezone")]
		public string BestTimeToContactTimezone { get; set; }

		///<summary>
		/// Is Primary
		/// <para>Name: IsPrimary</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isPrimary")]
		public bool? IsPrimary { get; set; }

		///<summary>
		/// Area code
		/// <para>Name: AreaCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "areaCode")]
		public string AreaCode { get; set; }

		///<summary>
		/// Telephone number
		/// <para>Name: TelephoneNumber</para>
		/// <para>SF Type: phone</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "telephoneNumber")]
		public string TelephoneNumber { get; set; }

		///<summary>
		/// Extension number
		/// <para>Name: ExtensionNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "extensionNumber")]
		public string ExtensionNumber { get; set; }

		///<summary>
		/// Phone Type
		/// <para>Name: PhoneType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "phoneType")]
		public string PhoneType { get; set; }

		///<summary>
		/// Is SMS capable
		/// <para>Name: IsSmsCapable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isSmsCapable")]
		public bool? IsSmsCapable { get; set; }

		///<summary>
		/// Formatted international phone number
		/// <para>Name: FormattedInternationalPhoneNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "formattedInternationalPhoneNumber")]
		public string FormattedInternationalPhoneNumber { get; set; }

		///<summary>
		/// Formatted national phone number
		/// <para>Name: FormattedNationalPhoneNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "formattedNationalPhoneNumber")]
		public string FormattedNationalPhoneNumber { get; set; }

		///<summary>
		/// Is fax capable
		/// <para>Name: IsFaxCapable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFaxCapable")]
		public bool? IsFaxCapable { get; set; }

		///<summary>
		/// Is personal phone
		/// <para>Name: IsPersonalPhone</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isPersonalPhone")]
		public bool? IsPersonalPhone { get; set; }

		///<summary>
		/// Is business phone
		/// <para>Name: IsBusinessPhone</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isBusinessPhone")]
		public bool? IsBusinessPhone { get; set; }

	}
}
