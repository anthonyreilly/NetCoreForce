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
	/// Party Consent
	///<para>SObject Name: PartyConsent</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfPartyConsent : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "PartyConsent"; }
		}

		///<summary>
		/// PartyConsent ID
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
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
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
		/// Individual ID
		/// <para>Name: PartyId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "partyId")]
		public string PartyId { get; set; }

		///<summary>
		/// ReferenceTo: Individual
		/// <para>RelationshipName: Party</para>
		///</summary>
		[JsonProperty(PropertyName = "party")]
		[Updateable(false), Createable(false)]
		public SfIndividual Party { get; set; }

		///<summary>
		/// Action
		/// <para>Name: Action</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "action")]
		public string Action { get; set; }

		///<summary>
		/// Privacy Consent Status
		/// <para>Name: PrivacyConsentStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "privacyConsentStatus")]
		public string PrivacyConsentStatus { get; set; }

		///<summary>
		/// Consent Captured Date Time
		/// <para>Name: CaptureDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "captureDate")]
		public DateTimeOffset? CaptureDate { get; set; }

		///<summary>
		/// Consent Captured Contact Point Type
		/// <para>Name: CaptureContactPointType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "captureContactPointType")]
		public string CaptureContactPointType { get; set; }

		///<summary>
		/// Consent Captured Source
		/// <para>Name: CaptureSource</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "captureSource")]
		public string CaptureSource { get; set; }

		///<summary>
		/// Party Role ID
		/// <para>Name: PartyRoleId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "partyRoleId")]
		public string PartyRoleId { get; set; }

		///<summary>
		/// Business Brand ID
		/// <para>Name: BusinessBrandId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "businessBrandId")]
		public string BusinessBrandId { get; set; }

		///<summary>
		/// ReferenceTo: BusinessBrand
		/// <para>RelationshipName: BusinessBrand</para>
		///</summary>
		[JsonProperty(PropertyName = "businessBrand")]
		[Updateable(false), Createable(false)]
		public SfBusinessBrand BusinessBrand { get; set; }

		///<summary>
		/// Data Use Purpose ID
		/// <para>Name: DataUsePurposeId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dataUsePurposeId")]
		public string DataUsePurposeId { get; set; }

		///<summary>
		/// ReferenceTo: DataUsePurpose
		/// <para>RelationshipName: DataUsePurpose</para>
		///</summary>
		[JsonProperty(PropertyName = "dataUsePurpose")]
		[Updateable(false), Createable(false)]
		public SfDataUsePurpose DataUsePurpose { get; set; }

	}
}
