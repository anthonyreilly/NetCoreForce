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
	/// AI Insight Reason
	///<para>SObject Name: AIInsightReason</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfAIInsightReason : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "AIInsightReason"; }
		}

		///<summary>
		/// AI Insight Reason ID
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
		/// Name
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
		/// AI Insight Value ID
		/// <para>Name: AiInsightValueId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "aiInsightValueId")]
		[Updateable(false), Createable(false)]
		public string AiInsightValueId { get; set; }

		///<summary>
		/// ReferenceTo: AIInsightValue
		/// <para>RelationshipName: AiInsightValue</para>
		///</summary>
		[JsonProperty(PropertyName = "aiInsightValue")]
		[Updateable(false), Createable(false)]
		public SfAIInsightValue AiInsightValue { get; set; }

		///<summary>
		/// Intensity
		/// <para>Name: Intensity</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "intensity")]
		[Updateable(false), Createable(false)]
		public double? Intensity { get; set; }

		///<summary>
		/// Contribution
		/// <para>Name: Contribution</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contribution")]
		[Updateable(false), Createable(false)]
		public double? Contribution { get; set; }

		///<summary>
		/// Variance
		/// <para>Name: Variance</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "variance")]
		[Updateable(false), Createable(false)]
		public double? Variance { get; set; }

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
		/// Operator
		/// <para>Name: Operator</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "operator")]
		[Updateable(false), Createable(false)]
		public string Operator { get; set; }

		///<summary>
		/// Field Value
		/// <para>Name: FieldValue</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fieldValue")]
		[Updateable(false), Createable(false)]
		public string FieldValue { get; set; }

		///<summary>
		/// Feature Value
		/// <para>Name: FeatureValue</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "featureValue")]
		[Updateable(false), Createable(false)]
		public string FeatureValue { get; set; }

		///<summary>
		/// Feature Type
		/// <para>Name: FeatureType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "featureType")]
		[Updateable(false), Createable(false)]
		public string FeatureType { get; set; }

		///<summary>
		/// AI Insight Reason ID
		/// <para>Name: RelatedInsightReasonId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relatedInsightReasonId")]
		[Updateable(false), Createable(false)]
		public string RelatedInsightReasonId { get; set; }

		///<summary>
		/// ReferenceTo: AIInsightReason
		/// <para>RelationshipName: RelatedInsightReason</para>
		///</summary>
		[JsonProperty(PropertyName = "relatedInsightReason")]
		[Updateable(false), Createable(false)]
		public SfAIInsightReason RelatedInsightReason { get; set; }

		///<summary>
		/// Sort Order
		/// <para>Name: SortOrder</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sortOrder")]
		[Updateable(false), Createable(false)]
		public int? SortOrder { get; set; }

		///<summary>
		/// Reason Label Key
		/// <para>Name: ReasonLabelKey</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "reasonLabelKey")]
		[Updateable(false), Createable(false)]
		public string ReasonLabelKey { get; set; }

	}
}
