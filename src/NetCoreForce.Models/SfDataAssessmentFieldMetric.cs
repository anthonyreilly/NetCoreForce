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
	/// Data Assessment Field Metric
	///<para>SObject Name: DataAssessmentFieldMetric</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfDataAssessmentFieldMetric : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "DataAssessmentFieldMetric"; }
		}

		///<summary>
		/// Data Assessment Field Metric ID
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
		/// Data Assessment Field Metric
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>AutoNumber field</para>
		/// <para>Nillable: False</para>
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
		/// Data Assessment Metric ID
		/// <para>Name: DataAssessmentMetricId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "dataAssessmentMetricId")]
		[Updateable(false), Createable(false)]
		public string DataAssessmentMetricId { get; set; }

		///<summary>
		/// ReferenceTo: DataAssessmentMetric
		/// <para>RelationshipName: DataAssessmentMetric</para>
		///</summary>
		[JsonProperty(PropertyName = "dataAssessmentMetric")]
		[Updateable(false), Createable(false)]
		public SfDataAssessmentMetric DataAssessmentMetric { get; set; }

		///<summary>
		/// Field Name
		/// <para>Name: FieldName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fieldName")]
		[Updateable(false), Createable(false)]
		public string FieldName { get; set; }

		///<summary>
		/// Number of Matched Records that have the same value for this field as Data.com
		/// <para>Name: NumMatchedInSync</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "numMatchedInSync")]
		[Updateable(false), Createable(false)]
		public int? NumMatchedInSync { get; set; }

		///<summary>
		/// Number of Matched Records that have different value for this field than Data.com
		/// <para>Name: NumMatchedDifferent</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "numMatchedDifferent")]
		[Updateable(false), Createable(false)]
		public int? NumMatchedDifferent { get; set; }

		///<summary>
		/// Number of Matched Records that have blanks for this field
		/// <para>Name: NumMatchedBlanks</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "numMatchedBlanks")]
		[Updateable(false), Createable(false)]
		public int? NumMatchedBlanks { get; set; }

		///<summary>
		/// Number of Unmatched Records that have blanks for this field
		/// <para>Name: NumUnmatchedBlanks</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "numUnmatchedBlanks")]
		[Updateable(false), Createable(false)]
		public int? NumUnmatchedBlanks { get; set; }

	}
}
