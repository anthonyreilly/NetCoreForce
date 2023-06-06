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
	/// ML Model Factor Component
	///<para>SObject Name: MLModelFactorComponent</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfMLModelFactorComponent : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "MLModelFactorComponent"; }
		}

		///<summary>
		/// ML Model Factor Components ID
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
		/// ML Model Factor ID
		/// <para>Name: ModelFactorId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "modelFactorId")]
		[Updateable(false), Createable(false)]
		public string ModelFactorId { get; set; }

		///<summary>
		/// ReferenceTo: MLModelFactor
		/// <para>RelationshipName: ModelFactor</para>
		///</summary>
		[JsonProperty(PropertyName = "modelFactor")]
		[Updateable(false), Createable(false)]
		public SfMLModelFactor ModelFactor { get; set; }

		///<summary>
		/// ML Model ID
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
		/// Left Hand Derived Field
		/// <para>Name: LeftHandDerivedField</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "leftHandDerivedField")]
		[Updateable(false), Createable(false)]
		public string LeftHandDerivedField { get; set; }

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
		/// Right Hand Derived Field
		/// <para>Name: RightHandDerivedField</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "rightHandDerivedField")]
		[Updateable(false), Createable(false)]
		public string RightHandDerivedField { get; set; }

		///<summary>
		/// Value
		/// <para>Name: Value</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "value")]
		[Updateable(false), Createable(false)]
		public string Value { get; set; }

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
		/// Feature Type
		/// <para>Name: FeatureType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "featureType")]
		[Updateable(false), Createable(false)]
		public string FeatureType { get; set; }

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
		/// Factor Label Key
		/// <para>Name: FactorLabelKey</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "factorLabelKey")]
		[Updateable(false), Createable(false)]
		public string FactorLabelKey { get; set; }

	}
}
