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
	/// Partner
	///<para>SObject Name: Partner</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfPartner : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "Partner"; }
		}

		///<summary>
		/// Partner ID
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
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "opportunityId")]
		[Updateable(false), Createable(true)]
		public string OpportunityId { get; set; }

		///<summary>
		/// ReferenceTo: Opportunity
		/// <para>RelationshipName: Opportunity</para>
		///</summary>
		[JsonProperty(PropertyName = "opportunity")]
		[Updateable(false), Createable(false)]
		public SfOpportunity Opportunity { get; set; }

		///<summary>
		/// Account From ID
		/// <para>Name: AccountFromId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "accountFromId")]
		[Updateable(false), Createable(true)]
		public string AccountFromId { get; set; }

		///<summary>
		/// ReferenceTo: Account
		/// <para>RelationshipName: AccountFrom</para>
		///</summary>
		[JsonProperty(PropertyName = "accountFrom")]
		[Updateable(false), Createable(false)]
		public SfAccount AccountFrom { get; set; }

		///<summary>
		/// Account To ID
		/// <para>Name: AccountToId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "accountToId")]
		[Updateable(false), Createable(true)]
		public string AccountToId { get; set; }

		///<summary>
		/// ReferenceTo: Account
		/// <para>RelationshipName: AccountTo</para>
		///</summary>
		[JsonProperty(PropertyName = "accountTo")]
		[Updateable(false), Createable(false)]
		public SfAccount AccountTo { get; set; }

		///<summary>
		/// Role
		/// <para>Name: Role</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "role")]
		[Updateable(false), Createable(true)]
		public string Role { get; set; }

		///<summary>
		/// Primary
		/// <para>Name: IsPrimary</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isPrimary")]
		[Updateable(false), Createable(true)]
		public bool? IsPrimary { get; set; }

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
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Createable(false)]
		public bool? IsDeleted { get; set; }

		///<summary>
		/// Reverse Partner ID
		/// <para>Name: ReversePartnerId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "reversePartnerId")]
		[Updateable(false), Createable(false)]
		public string ReversePartnerId { get; set; }

	}
}
