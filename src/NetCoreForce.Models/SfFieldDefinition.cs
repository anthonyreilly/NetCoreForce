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
	/// Field Definition
	///<para>SObject Name: FieldDefinition</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfFieldDefinition : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "FieldDefinition"; }
		}

		///<summary>
		/// Field Definition ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Durable ID
		/// <para>Name: DurableId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "durableId")]
		[Updateable(false), Createable(false)]
		public string DurableId { get; set; }

		///<summary>
		/// Qualified API Name
		/// <para>Name: QualifiedApiName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "qualifiedApiName")]
		[Updateable(false), Createable(false)]
		public string QualifiedApiName { get; set; }

		///<summary>
		/// Entity Definition ID
		/// <para>Name: EntityDefinitionId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "entityDefinitionId")]
		[Updateable(false), Createable(false)]
		public string EntityDefinitionId { get; set; }

		///<summary>
		/// Namespace Prefix
		/// <para>Name: NamespacePrefix</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "namespacePrefix")]
		[Updateable(false), Createable(false)]
		public string NamespacePrefix { get; set; }

		///<summary>
		/// Developer Name
		/// <para>Name: DeveloperName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "developerName")]
		[Updateable(false), Createable(false)]
		public string DeveloperName { get; set; }

		///<summary>
		/// Master Label
		/// <para>Name: MasterLabel</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "masterLabel")]
		[Updateable(false), Createable(false)]
		public string MasterLabel { get; set; }

		///<summary>
		/// Label
		/// <para>Name: Label</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "label")]
		[Updateable(false), Createable(false)]
		public string Label { get; set; }

		///<summary>
		/// Length
		/// <para>Name: Length</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "length")]
		[Updateable(false), Createable(false)]
		public int? Length { get; set; }

		///<summary>
		/// Data Type
		/// <para>Name: DataType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dataType")]
		[Updateable(false), Createable(false)]
		public string DataType { get; set; }

		///<summary>
		/// Data Type ID
		/// <para>Name: ServiceDataTypeId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "serviceDataTypeId")]
		[Updateable(false), Createable(false)]
		public string ServiceDataTypeId { get; set; }

		///<summary>
		/// Data Type ID
		/// <para>Name: ValueTypeId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "valueTypeId")]
		[Updateable(false), Createable(false)]
		public string ValueTypeId { get; set; }

		///<summary>
		/// Extra Type Info
		/// <para>Name: ExtraTypeInfo</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "extraTypeInfo")]
		[Updateable(false), Createable(false)]
		public string ExtraTypeInfo { get; set; }

		///<summary>
		/// Is Field calculated?
		/// <para>Name: IsCalculated</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isCalculated")]
		[Updateable(false), Createable(false)]
		public bool? IsCalculated { get; set; }

		///<summary>
		/// Is Field a high scale number?
		/// <para>Name: IsHighScaleNumber</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isHighScaleNumber")]
		[Updateable(false), Createable(false)]
		public bool? IsHighScaleNumber { get; set; }

		///<summary>
		/// Is Field a HTML formatted?
		/// <para>Name: IsHtmlFormatted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isHtmlFormatted")]
		[Updateable(false), Createable(false)]
		public bool? IsHtmlFormatted { get; set; }

		///<summary>
		/// Is Field a Name field?
		/// <para>Name: IsNameField</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isNameField")]
		[Updateable(false), Createable(false)]
		public bool? IsNameField { get; set; }

		///<summary>
		/// Is Field a nillable?
		/// <para>Name: IsNillable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isNillable")]
		[Updateable(false), Createable(false)]
		public bool? IsNillable { get; set; }

		///<summary>
		/// Is Workflow Filterable?
		/// <para>Name: IsWorkflowFilterable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isWorkflowFilterable")]
		[Updateable(false), Createable(false)]
		public bool? IsWorkflowFilterable { get; set; }

		///<summary>
		/// Is Compact Layout Enabled?
		/// <para>Name: IsCompactLayoutable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isCompactLayoutable")]
		[Updateable(false), Createable(false)]
		public bool? IsCompactLayoutable { get; set; }

		///<summary>
		/// Precision
		/// <para>Name: Precision</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "precision")]
		[Updateable(false), Createable(false)]
		public int? Precision { get; set; }

		///<summary>
		/// Scale
		/// <para>Name: Scale</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "scale")]
		[Updateable(false), Createable(false)]
		public int? Scale { get; set; }

		///<summary>
		/// Is Field History Tracked
		/// <para>Name: IsFieldHistoryTracked</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFieldHistoryTracked")]
		[Updateable(false), Createable(false)]
		public bool? IsFieldHistoryTracked { get; set; }

		///<summary>
		/// Is Field indexed?
		/// <para>Name: IsIndexed</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isIndexed")]
		[Updateable(false), Createable(false)]
		public bool? IsIndexed { get; set; }

		///<summary>
		/// Is Field Filterable?
		/// <para>Name: IsApiFilterable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isApiFilterable")]
		[Updateable(false), Createable(false)]
		public bool? IsApiFilterable { get; set; }

		///<summary>
		/// Is Field Sortable?
		/// <para>Name: IsApiSortable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isApiSortable")]
		[Updateable(false), Createable(false)]
		public bool? IsApiSortable { get; set; }

		///<summary>
		/// Is Field Filterable in Lists?
		/// <para>Name: IsListFilterable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isListFilterable")]
		[Updateable(false), Createable(false)]
		public bool? IsListFilterable { get; set; }

		///<summary>
		/// Is Field Sortable in Lists?
		/// <para>Name: IsListSortable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isListSortable")]
		[Updateable(false), Createable(false)]
		public bool? IsListSortable { get; set; }

		///<summary>
		/// Is Field Groupable?
		/// <para>Name: IsApiGroupable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isApiGroupable")]
		[Updateable(false), Createable(false)]
		public bool? IsApiGroupable { get; set; }

		///<summary>
		/// Is Field visible in Lists?
		/// <para>Name: IsListVisible</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isListVisible")]
		[Updateable(false), Createable(false)]
		public bool? IsListVisible { get; set; }

		///<summary>
		/// Field Definition ID
		/// <para>Name: ControllingFieldDefinitionId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "controllingFieldDefinitionId")]
		[Updateable(false), Createable(false)]
		public string ControllingFieldDefinitionId { get; set; }

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
		/// User ID
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
		/// Publisher ID
		/// <para>Name: PublisherId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "publisherId")]
		[Updateable(false), Createable(false)]
		public string PublisherId { get; set; }

		///<summary>
		/// User Field Access ID
		/// <para>Name: RunningUserFieldAccessId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "runningUserFieldAccessId")]
		[Updateable(false), Createable(false)]
		public string RunningUserFieldAccessId { get; set; }

		///<summary>
		/// Relationship Name
		/// <para>Name: RelationshipName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relationshipName")]
		[Updateable(false), Createable(false)]
		public string RelationshipName { get; set; }

		///<summary>
		/// Entities Referenced by Relationship
		/// <para>Name: ReferenceTo</para>
		/// <para>SF Type: complexvalue</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "referenceTo")]
		[Updateable(false), Createable(false)]
		public string ReferenceTo { get; set; }

		///<summary>
		/// Target Field on Entities to Which the Foreign Key Points
		/// <para>Name: ReferenceTargetField</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "referenceTargetField")]
		[Updateable(false), Createable(false)]
		public string ReferenceTargetField { get; set; }

		///<summary>
		/// Is Field a compound field
		/// <para>Name: IsCompound</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isCompound")]
		[Updateable(false), Createable(false)]
		public bool? IsCompound { get; set; }

		///<summary>
		/// Is Field Search Prefilterable?
		/// <para>Name: IsSearchPrefilterable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isSearchPrefilterable")]
		[Updateable(false), Createable(false)]
		public bool? IsSearchPrefilterable { get; set; }

		///<summary>
		/// Is ForeignKey Polymorphic?
		/// <para>Name: IsPolymorphicForeignKey</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isPolymorphicForeignKey")]
		[Updateable(false), Createable(false)]
		public bool? IsPolymorphicForeignKey { get; set; }

		///<summary>
		/// Is Field AI Prediction Field?
		/// <para>Name: IsAiPredictionField</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isAiPredictionField")]
		[Updateable(false), Createable(false)]
		public bool? IsAiPredictionField { get; set; }

		///<summary>
		/// Business Owner ID
		/// <para>Name: BusinessOwnerId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "businessOwnerId")]
		[Updateable(false), Createable(false)]
		public string BusinessOwnerId { get; set; }

		///<summary>
		/// Field Usage
		/// <para>Name: BusinessStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "businessStatus")]
		[Updateable(false), Createable(false)]
		public string BusinessStatus { get; set; }

		///<summary>
		/// Data Sensitivity Level
		/// <para>Name: SecurityClassification</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "securityClassification")]
		[Updateable(false), Createable(false)]
		public string SecurityClassification { get; set; }

		///<summary>
		/// Compliance Categorization
		/// <para>Name: ComplianceGroup</para>
		/// <para>SF Type: multipicklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "complianceGroup")]
		[Updateable(false), Createable(false)]
		public string ComplianceGroup { get; set; }

		///<summary>
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		[Updateable(false), Createable(false)]
		public string Description { get; set; }

	}
}
