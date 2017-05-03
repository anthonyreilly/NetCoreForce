// SF API version v39.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Tenant Usage Entitlement
	///<para>SObject Name: TenantUsageEntitlement</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfTenantUsageEntitlement : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "TenantUsageEntitlement"; }
		}

		///<summary>
		/// Tenant Usage Entitlement ID
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
		/// Resource Group Key
		/// <para>Name: ResourceGroupKey</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "resourceGroupKey")]
		[Updateable(false), Createable(false)]
		public string ResourceGroupKey { get; set; }

		///<summary>
		/// Setting
		/// <para>Name: Setting</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "setting")]
		[Updateable(false), Createable(false)]
		public string Setting { get; set; }

		///<summary>
		/// Start Date
		/// <para>Name: StartDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "startDate")]
		[Updateable(false), Createable(false)]
		public string StartDate { get; set; }

		///<summary>
		/// End Date
		/// <para>Name: EndDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "endDate")]
		[Updateable(false), Createable(false)]
		public string EndDate { get; set; }

		///<summary>
		/// Current Amount Allowed
		/// <para>Name: CurrentAmountAllowed</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "currentAmountAllowed")]
		[Updateable(false), Createable(false)]
		public double? CurrentAmountAllowed { get; set; }

		///<summary>
		/// Frequency
		/// <para>Name: Frequency</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "frequency")]
		[Updateable(false), Createable(false)]
		public string Frequency { get; set; }

		///<summary>
		/// Is Persistent Resource
		/// <para>Name: IsPersistentResource</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isPersistentResource")]
		[Updateable(false), Createable(false)]
		public bool? IsPersistentResource { get; set; }

		///<summary>
		/// Has Rollover
		/// <para>Name: HasRollover</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasRollover")]
		[Updateable(false), Createable(false)]
		public bool? HasRollover { get; set; }

		///<summary>
		/// Overage Grace
		/// <para>Name: OverageGrace</para>
		/// <para>SF Type: percent</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "overageGrace")]
		[Updateable(false), Createable(false)]
		public double? OverageGrace { get; set; }

		///<summary>
		/// Amount Used
		/// <para>Name: AmountUsed</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "amountUsed")]
		[Updateable(false), Createable(false)]
		public double? AmountUsed { get; set; }

		///<summary>
		/// Usage Date
		/// <para>Name: UsageDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "usageDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? UsageDate { get; set; }

		///<summary>
		/// Setting Label
		/// <para>Name: MasterLabel</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "masterLabel")]
		[Updateable(false), Createable(false)]
		public string MasterLabel { get; set; }

	}
}
