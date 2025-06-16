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
	/// Activity Field History
	///<para>SObject Name: ActivityFieldHistory</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfActivityFieldHistory : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ActivityFieldHistory"; }
		}

		///<summary>
		/// Entity History ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

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
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

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
		/// Task or Event ID
		/// <para>Name: ActivityId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "activityId")]
		[Updateable(false), Createable(false)]
		public string ActivityId { get; set; }

		///<summary>
		/// Changed Date
		/// <para>Name: ChangedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "changedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? ChangedDate { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: ChangedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "changedById")]
		[Updateable(false), Createable(false)]
		public string ChangedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: ChangedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "changedBy")]
		[Updateable(false), Createable(false)]
		public SfUser ChangedBy { get; set; }

		///<summary>
		/// Field
		/// <para>Name: FieldName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "fieldName")]
		[Updateable(false), Createable(false)]
		public string FieldName { get; set; }

		///<summary>
		/// Data Type
		/// <para>Name: DataType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "dataType")]
		[Updateable(false), Createable(false)]
		public string DataType { get; set; }

		///<summary>
		/// Change Operation
		/// <para>Name: Operation</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "operation")]
		[Updateable(false), Createable(false)]
		public string Operation { get; set; }

		///<summary>
		/// Data Available
		/// <para>Name: IsDataAvailable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDataAvailable")]
		[Updateable(false), Createable(false)]
		public bool? IsDataAvailable { get; set; }

		///<summary>
		/// Old Date
		/// <para>Name: OldValueDateTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "oldValueDateTime")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? OldValueDateTime { get; set; }

		///<summary>
		/// New Date
		/// <para>Name: NewValueDateTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "newValueDateTime")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? NewValueDateTime { get; set; }

		///<summary>
		/// Old Number Val
		/// <para>Name: OldValueNumber</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "oldValueNumber")]
		[Updateable(false), Createable(false)]
		public double? OldValueNumber { get; set; }

		///<summary>
		/// New Number Val
		/// <para>Name: NewValueNumber</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "newValueNumber")]
		[Updateable(false), Createable(false)]
		public double? NewValueNumber { get; set; }

		///<summary>
		/// Old String Val
		/// <para>Name: OldValueText</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "oldValueText")]
		[Updateable(false), Createable(false)]
		public string OldValueText { get; set; }

		///<summary>
		/// New String Val
		/// <para>Name: NewValueText</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "newValueText")]
		[Updateable(false), Createable(false)]
		public string NewValueText { get; set; }

	}
}
