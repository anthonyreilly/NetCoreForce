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
	/// Party Consent  History
	///<para>SObject Name: PartyConsentHistory</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfPartyConsentHistory : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "PartyConsentHistory"; }
		}

		///<summary>
		/// Party Consent  History ID
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
		/// PartyConsent ID
		/// <para>Name: PartyConsentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "partyConsentId")]
		[Updateable(false), Createable(false)]
		public string PartyConsentId { get; set; }

		///<summary>
		/// ReferenceTo: PartyConsent
		/// <para>RelationshipName: PartyConsent</para>
		///</summary>
		[JsonProperty(PropertyName = "partyConsent")]
		[Updateable(false), Createable(false)]
		public SfPartyConsent PartyConsent { get; set; }

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
		/// Changed Field
		/// <para>Name: Field</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "field")]
		[Updateable(false), Createable(false)]
		public string Field { get; set; }

		///<summary>
		/// Old Value
		/// <para>Name: OldValue</para>
		/// <para>SF Type: anyType</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "oldValue")]
		[Updateable(false), Createable(false)]
		public string OldValue { get; set; }

		///<summary>
		/// New Value
		/// <para>Name: NewValue</para>
		/// <para>SF Type: anyType</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "newValue")]
		[Updateable(false), Createable(false)]
		public string NewValue { get; set; }

	}
}
