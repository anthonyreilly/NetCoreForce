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
	/// User Provisioning Request
	///<para>SObject Name: UserProvisioningRequest</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfUserProvisioningRequest : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "UserProvisioningRequest"; }
		}

		///<summary>
		/// UserProvisioningRequest ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
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
		[Updateable(false), Creatable(false)]
		public bool? IsDeleted { get; set; }

		///<summary>
		/// Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>AutoNumber field</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Creatable(false)]
		public string Name { get; set; }

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
		/// User ID
		/// <para>Name: SalesforceUserId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "salesforceUserId")]
		public string SalesforceUserId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: SalesforceUser</para>
		///</summary>
		[JsonProperty(PropertyName = "salesforceUser")]
		[Updateable(false), Creatable(false)]
		public SfUser SalesforceUser { get; set; }

		///<summary>
		/// External User Id
		/// <para>Name: ExternalUserId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "externalUserId")]
		public string ExternalUserId { get; set; }

		///<summary>
		/// App Name
		/// <para>Name: AppName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "appName")]
		public string AppName { get; set; }

		///<summary>
		/// State
		/// <para>Name: State</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "state")]
		public string State { get; set; }

		///<summary>
		/// Operation
		/// <para>Name: Operation</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "operation")]
		public string Operation { get; set; }

		///<summary>
		/// Scheduled Provisioning Time
		/// <para>Name: ScheduleDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "scheduleDate")]
		public DateTimeOffset? ScheduleDate { get; set; }

		///<summary>
		/// Connected App ID
		/// <para>Name: ConnectedAppId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "connectedAppId")]
		public string ConnectedAppId { get; set; }

		///<summary>
		/// ReferenceTo: ConnectedApplication
		/// <para>RelationshipName: ConnectedApp</para>
		///</summary>
		[JsonProperty(PropertyName = "connectedApp")]
		[Updateable(false), Creatable(false)]
		public SfConnectedApplication ConnectedApp { get; set; }

		///<summary>
		/// UserProvisioningConfig ID
		/// <para>Name: UserProvConfigId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "userProvConfigId")]
		public string UserProvConfigId { get; set; }

		///<summary>
		/// ReferenceTo: UserProvisioningConfig
		/// <para>RelationshipName: UserProvConfig</para>
		///</summary>
		[JsonProperty(PropertyName = "userProvConfig")]
		[Updateable(false), Creatable(false)]
		public SfUserProvisioningConfig UserProvConfig { get; set; }

		///<summary>
		/// User Provisioning Account ID
		/// <para>Name: UserProvAccountId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "userProvAccountId")]
		public string UserProvAccountId { get; set; }

		///<summary>
		/// ReferenceTo: UserProvAccount
		/// <para>RelationshipName: UserProvAccount</para>
		///</summary>
		[JsonProperty(PropertyName = "userProvAccount")]
		[Updateable(false), Creatable(false)]
		public SfUserProvAccount UserProvAccount { get; set; }

		///<summary>
		/// Approval Status
		/// <para>Name: ApprovalStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "approvalStatus")]
		public string ApprovalStatus { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: ManagerId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "managerId")]
		public string ManagerId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: Manager</para>
		///</summary>
		[JsonProperty(PropertyName = "manager")]
		[Updateable(false), Creatable(false)]
		public SfUser Manager { get; set; }

		///<summary>
		/// Retry Count
		/// <para>Name: RetryCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "retryCount")]
		public int? RetryCount { get; set; }

		///<summary>
		/// UserProvisioningRequest ID
		/// <para>Name: ParentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "parentId")]
		public string ParentId { get; set; }

		///<summary>
		/// ReferenceTo: UserProvisioningRequest
		/// <para>RelationshipName: Parent</para>
		///</summary>
		[JsonProperty(PropertyName = "parent")]
		[Updateable(false), Creatable(false)]
		public SfUserProvisioningRequest Parent { get; set; }

	}
}
