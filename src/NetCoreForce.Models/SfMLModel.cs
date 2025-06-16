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
	/// ML Model
	///<para>SObject Name: MLModel</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfMLModel : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "MLModel"; }
		}

		///<summary>
		/// ML Model ID
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
		/// ML Prediction Definition ID
		/// <para>Name: PredictionDefinitionId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "predictionDefinitionId")]
		[Updateable(false), Createable(false)]
		public string PredictionDefinitionId { get; set; }

		///<summary>
		/// ReferenceTo: MLPredictionDefinition
		/// <para>RelationshipName: PredictionDefinition</para>
		///</summary>
		[JsonProperty(PropertyName = "predictionDefinition")]
		[Updateable(false), Createable(false)]
		public SfMLPredictionDefinition PredictionDefinition { get; set; }

		///<summary>
		/// Approval Status
		/// <para>Name: ApprovalStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "approvalStatus")]
		[Updateable(false), Createable(false)]
		public string ApprovalStatus { get; set; }

		///<summary>
		/// Scoring Status
		/// <para>Name: ScoringStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "scoringStatus")]
		[Updateable(false), Createable(false)]
		public string ScoringStatus { get; set; }

		///<summary>
		/// Model Type
		/// <para>Name: ModelType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "modelType")]
		[Updateable(false), Createable(false)]
		public string ModelType { get; set; }

		///<summary>
		/// Training Start Time
		/// <para>Name: TrainingStartTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "trainingStartTime")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? TrainingStartTime { get; set; }

		///<summary>
		/// Training End Time
		/// <para>Name: TrainingEndTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "trainingEndTime")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? TrainingEndTime { get; set; }

		///<summary>
		/// Dataset Id
		/// <para>Name: Dataset</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dataset")]
		[Updateable(false), Createable(false)]
		public string Dataset { get; set; }

		///<summary>
		/// ML Recommendation Definition ID
		/// <para>Name: RecommendationDefinitionId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recommendationDefinitionId")]
		[Updateable(false), Createable(false)]
		public string RecommendationDefinitionId { get; set; }

		///<summary>
		/// ReferenceTo: MLRecommendationDefinition
		/// <para>RelationshipName: RecommendationDefinition</para>
		///</summary>
		[JsonProperty(PropertyName = "recommendationDefinition")]
		[Updateable(false), Createable(false)]
		public SfMLRecommendationDefinition RecommendationDefinition { get; set; }

	}
}
