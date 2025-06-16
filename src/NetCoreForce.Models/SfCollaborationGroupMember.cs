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
	/// Group Member
	///<para>SObject Name: CollaborationGroupMember</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfCollaborationGroupMember : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "CollaborationGroupMember"; }
		}

		///<summary>
		/// Group Member Id
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
		/// Member ID
		/// <para>Name: MemberId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "memberId")]
		[Updateable(false), Createable(true)]
		public string MemberId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: Member</para>
		///</summary>
		[JsonProperty(PropertyName = "member")]
		[Updateable(false), Createable(false)]
		public SfUser Member { get; set; }

		///<summary>
		/// Group Member Role
		/// <para>Name: CollaborationRole</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "collaborationRole")]
		public string CollaborationRole { get; set; }

		///<summary>
		/// Notification Frequency
		/// <para>Name: NotificationFrequency</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "notificationFrequency")]
		public string NotificationFrequency { get; set; }

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
		/// Last Feed Access Date
		/// <para>Name: LastFeedAccessDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastFeedAccessDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastFeedAccessDate { get; set; }

	}
}
