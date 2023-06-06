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
	/// AI Record Insight
	///<para>SObject Name: AIRecordInsight</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfAIRecordInsight : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "AIRecordInsight"; }
		}

		///<summary>
		/// AI Record Insight ID
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
		/// AI Application ID
		/// <para>Name: AiApplicationId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "aiApplicationId")]
		[Updateable(false), Createable(false)]
		public string AiApplicationId { get; set; }

		///<summary>
		/// ReferenceTo: AIApplication
		/// <para>RelationshipName: AiApplication</para>
		///</summary>
		[JsonProperty(PropertyName = "aiApplication")]
		[Updateable(false), Createable(false)]
		public SfAIApplication AiApplication { get; set; }

		///<summary>
		/// Target ID
		/// <para>Name: TargetId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "targetId")]
		[Updateable(false), Createable(false)]
		public string TargetId { get; set; }

		///<summary>
		/// Target sObject Type
		/// <para>Name: TargetSobjectType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "targetSobjectType")]
		[Updateable(false), Createable(false)]
		public string TargetSobjectType { get; set; }

		///<summary>
		/// Type
		/// <para>Name: Type</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		[Updateable(false), Createable(false)]
		public string Type { get; set; }

		///<summary>
		/// Run GUID
		/// <para>Name: RunGuid</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "runGuid")]
		[Updateable(false), Createable(false)]
		public string RunGuid { get; set; }

		///<summary>
		/// Run Start Time
		/// <para>Name: RunStartTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "runStartTime")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? RunStartTime { get; set; }

		///<summary>
		/// Valid Until
		/// <para>Name: ValidUntil</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "validUntil")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? ValidUntil { get; set; }

		///<summary>
		/// Confidence
		/// <para>Name: Confidence</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "confidence")]
		[Updateable(false), Createable(false)]
		public double? Confidence { get; set; }

		///<summary>
		/// Target Field
		/// <para>Name: TargetField</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "targetField")]
		[Updateable(false), Createable(false)]
		public string TargetField { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		[Updateable(false), Createable(false)]
		public string Status { get; set; }

		///<summary>
		/// AI Model ID
		/// <para>Name: ModelId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "modelId")]
		[Updateable(false), Createable(false)]
		public string ModelId { get; set; }

		///<summary>
		/// ReferenceTo: MLModel
		/// <para>RelationshipName: Model</para>
		///</summary>
		[JsonProperty(PropertyName = "model")]
		[Updateable(false), Createable(false)]
		public SfMLModel Model { get; set; }

		///<summary>
		/// ML Prediction Definition ID
		/// <para>Name: MlPredictionDefinitionId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mlPredictionDefinitionId")]
		[Updateable(false), Createable(false)]
		public string MlPredictionDefinitionId { get; set; }

		///<summary>
		/// ReferenceTo: MLPredictionDefinition
		/// <para>RelationshipName: MlPredictionDefinition</para>
		///</summary>
		[JsonProperty(PropertyName = "mlPredictionDefinition")]
		[Updateable(false), Createable(false)]
		public SfMLPredictionDefinition MlPredictionDefinition { get; set; }

		///<summary>
		/// Prediction Field
		/// <para>Name: PredictionField</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "predictionField")]
		[Updateable(false), Createable(false)]
		public string PredictionField { get; set; }

	}
}
