// SF API version v50.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Entity Particle
	///<para>SObject Name: EntityParticle</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfEntityParticle : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "EntityParticle"; }
		}

		///<summary>
		/// Entity Particle ID
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
		/// Field Definition ID
		/// <para>Name: FieldDefinitionId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fieldDefinitionId")]
		[Updateable(false), Createable(false)]
		public string FieldDefinitionId { get; set; }

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
		/// Is Field an Autonumber?
		/// <para>Name: IsAutonumber</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isAutonumber")]
		[Updateable(false), Createable(false)]
		public bool? IsAutonumber { get; set; }

		///<summary>
		/// Byte Length
		/// <para>Name: ByteLength</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "byteLength")]
		[Updateable(false), Createable(false)]
		public int? ByteLength { get; set; }

		///<summary>
		/// Is Field Case Sensitive?
		/// <para>Name: IsCaseSensitive</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isCaseSensitive")]
		[Updateable(false), Createable(false)]
		public bool? IsCaseSensitive { get; set; }

		///<summary>
		/// Is Field Unique?
		/// <para>Name: IsUnique</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isUnique")]
		[Updateable(false), Createable(false)]
		public bool? IsUnique { get; set; }

		///<summary>
		/// Is Field Creatable?
		/// <para>Name: IsCreatable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isCreatable")]
		[Updateable(false), Createable(false)]
		public bool? IsCreatable { get; set; }

		///<summary>
		/// Is Field Updatable?
		/// <para>Name: IsUpdatable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isUpdatable")]
		[Updateable(false), Createable(false)]
		public bool? IsUpdatable { get; set; }

		///<summary>
		/// Is Field Defaulted On Create?
		/// <para>Name: IsDefaultedOnCreate</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDefaultedOnCreate")]
		[Updateable(false), Createable(false)]
		public bool? IsDefaultedOnCreate { get; set; }

		///<summary>
		/// Does Write Require Master Read?
		/// <para>Name: IsWriteRequiresMasterRead</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isWriteRequiresMasterRead")]
		[Updateable(false), Createable(false)]
		public bool? IsWriteRequiresMasterRead { get; set; }

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
		/// Is Field Permissionable?
		/// <para>Name: IsPermissionable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isPermissionable")]
		[Updateable(false), Createable(false)]
		public bool? IsPermissionable { get; set; }

		///<summary>
		/// Is Field Encrypted?
		/// <para>Name: IsEncrypted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isEncrypted")]
		[Updateable(false), Createable(false)]
		public bool? IsEncrypted { get; set; }

		///<summary>
		/// Digits
		/// <para>Name: Digits</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "digits")]
		[Updateable(false), Createable(false)]
		public int? Digits { get; set; }

		///<summary>
		/// Inline Help Text
		/// <para>Name: InlineHelpText</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "inlineHelpText")]
		[Updateable(false), Createable(false)]
		public string InlineHelpText { get; set; }

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
		/// Reference Target Field
		/// <para>Name: ReferenceTargetField</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "referenceTargetField")]
		[Updateable(false), Createable(false)]
		public string ReferenceTargetField { get; set; }

		///<summary>
		/// Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
		public string Name { get; set; }

		///<summary>
		/// Mask
		/// <para>Name: Mask</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mask")]
		[Updateable(false), Createable(false)]
		public string Mask { get; set; }

		///<summary>
		/// Mask Type
		/// <para>Name: MaskType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "maskType")]
		[Updateable(false), Createable(false)]
		public string MaskType { get; set; }

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
		/// Is Layout Enabled?
		/// <para>Name: IsLayoutable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isLayoutable")]
		[Updateable(false), Createable(false)]
		public bool? IsLayoutable { get; set; }

		///<summary>
		/// Is Field a Dependent Picklist?
		/// <para>Name: IsDependentPicklist</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDependentPicklist")]
		[Updateable(false), Createable(false)]
		public bool? IsDependentPicklist { get; set; }

		///<summary>
		/// Is Field a Deprecated and Hidden?
		/// <para>Name: IsDeprecatedAndHidden</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeprecatedAndHidden")]
		[Updateable(false), Createable(false)]
		public bool? IsDeprecatedAndHidden { get; set; }

		///<summary>
		/// Is Field Displays Location in Decimals?
		/// <para>Name: IsDisplayLocationInDecimal</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDisplayLocationInDecimal")]
		[Updateable(false), Createable(false)]
		public bool? IsDisplayLocationInDecimal { get; set; }

		///<summary>
		/// Default Value if Formula is Not Used
		/// <para>Name: DefaultValueFormula</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "defaultValueFormula")]
		[Updateable(false), Createable(false)]
		public string DefaultValueFormula { get; set; }

		///<summary>
		/// Can this Field be Used to Specify a Record in Upsert?
		/// <para>Name: IsIdLookup</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isIdLookup")]
		[Updateable(false), Createable(false)]
		public bool? IsIdLookup { get; set; }

		///<summary>
		/// Does this Field Contain the Name of the Parent?
		/// <para>Name: IsNamePointing</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isNamePointing")]
		[Updateable(false), Createable(false)]
		public bool? IsNamePointing { get; set; }

		///<summary>
		/// Type of Relationship for a Master-Detail Relationship
		/// <para>Name: RelationshipOrder</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relationshipOrder")]
		[Updateable(false), Createable(false)]
		public int? RelationshipOrder { get; set; }

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
		/// Is Field a component of a compound field
		/// <para>Name: IsComponent</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isComponent")]
		[Updateable(false), Createable(false)]
		public bool? IsComponent { get; set; }

		///<summary>
		/// Is Field a compound field
		/// <para>Name: IsCompound</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isCompound")]
		[Updateable(false), Createable(false)]
		public bool? IsCompound { get; set; }

	}
}
