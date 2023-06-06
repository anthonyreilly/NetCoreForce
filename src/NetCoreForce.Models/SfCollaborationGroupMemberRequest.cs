// SF API version v57.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Group Member Request
	///<para>SObject Name: CollaborationGroupMemberRequest</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfCollaborationGroupMemberRequest : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "CollaborationGroupMemberRequest"; }
		}

		///<summary>
		/// Group Member Request Id
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// CollaborationGroup ID
		/// <para>Name: CollaborationGroupId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "collaborationGroupId")]
		[Updateable(false), Createable(true)]
		public string CollaborationGroupId { get; set; }

		///<summary>
		/// ReferenceTo: CollaborationGroup
		/// <para>RelationshipName: CollaborationGroup</para>
		///</summary>
		[JsonProperty(PropertyName = "collaborationGroup")]
		[Updateable(false), Createable(false)]
		public SfCollaborationGroup CollaborationGroup { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: RequesterId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "requesterId")]
		[Updateable(false), Createable(true)]
		public string RequesterId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: Requester</para>
		///</summary>
		[JsonProperty(PropertyName = "requester")]
		[Updateable(false), Createable(false)]
		public SfUser Requester { get; set; }

		///<summary>
		/// Response Message
		/// <para>Name: ResponseMessage</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "responseMessage")]
		[Updateable(true), Createable(false)]
		public string ResponseMessage { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		[Updateable(true), Createable(false)]
		public string Status { get; set; }

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
