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
	/// Entity Definition
	///<para>SObject Name: EntityDefinition</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfEntityDefinition : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "EntityDefinition"; }
		}

		///<summary>
		/// Entity Definition ID
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
		/// Qualified API Name
		/// <para>Name: QualifiedApiName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "qualifiedApiName")]
		[Updateable(false), Createable(false)]
		public string QualifiedApiName { get; set; }

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
		/// Plural Label
		/// <para>Name: PluralLabel</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "pluralLabel")]
		[Updateable(false), Createable(false)]
		public string PluralLabel { get; set; }

		///<summary>
		/// Compact Layout ID
		/// <para>Name: DefaultCompactLayoutId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "defaultCompactLayoutId")]
		[Updateable(false), Createable(false)]
		public string DefaultCompactLayoutId { get; set; }

		///<summary>
		/// Is Customizable?
		/// <para>Name: IsCustomizable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isCustomizable")]
		[Updateable(false), Createable(false)]
		public bool? IsCustomizable { get; set; }

		///<summary>
		/// Is Apex Triggerable?
		/// <para>Name: IsApexTriggerable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isApexTriggerable")]
		[Updateable(false), Createable(false)]
		public bool? IsApexTriggerable { get; set; }

		///<summary>
		/// Is Workflow Enabled?
		/// <para>Name: IsWorkflowEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isWorkflowEnabled")]
		[Updateable(false), Createable(false)]
		public bool? IsWorkflowEnabled { get; set; }

		///<summary>
		/// Is Approval Process Enabled?
		/// <para>Name: IsProcessEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isProcessEnabled")]
		[Updateable(false), Createable(false)]
		public bool? IsProcessEnabled { get; set; }

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
		/// Deployment Status
		/// <para>Name: DeploymentStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "deploymentStatus")]
		[Updateable(false), Createable(false)]
		public string DeploymentStatus { get; set; }

		///<summary>
		/// Key Prefix
		/// <para>Name: KeyPrefix</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "keyPrefix")]
		[Updateable(false), Createable(false)]
		public string KeyPrefix { get; set; }

		///<summary>
		/// Is Custom Setting?
		/// <para>Name: IsCustomSetting</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isCustomSetting")]
		[Updateable(false), Createable(false)]
		public bool? IsCustomSetting { get; set; }

		///<summary>
		/// Is Deprecated And Hidden?
		/// <para>Name: IsDeprecatedAndHidden</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeprecatedAndHidden")]
		[Updateable(false), Createable(false)]
		public bool? IsDeprecatedAndHidden { get; set; }

		///<summary>
		/// Is Replicateable?
		/// <para>Name: IsReplicateable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReplicateable")]
		[Updateable(false), Createable(false)]
		public bool? IsReplicateable { get; set; }

		///<summary>
		/// Is Retrieveable?
		/// <para>Name: IsRetrieveable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isRetrieveable")]
		[Updateable(false), Createable(false)]
		public bool? IsRetrieveable { get; set; }

		///<summary>
		/// Is Search Layoutable?
		/// <para>Name: IsSearchLayoutable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isSearchLayoutable")]
		[Updateable(false), Createable(false)]
		public bool? IsSearchLayoutable { get; set; }

		///<summary>
		/// Is Searchable?
		/// <para>Name: IsSearchable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isSearchable")]
		[Updateable(false), Createable(false)]
		public bool? IsSearchable { get; set; }

		///<summary>
		/// Is Triggerable?
		/// <para>Name: IsTriggerable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isTriggerable")]
		[Updateable(false), Createable(false)]
		public bool? IsTriggerable { get; set; }

		///<summary>
		/// Is Id Enabled?
		/// <para>Name: IsIdEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isIdEnabled")]
		[Updateable(false), Createable(false)]
		public bool? IsIdEnabled { get; set; }

		///<summary>
		/// Is Ever Creatable via API?
		/// <para>Name: IsEverCreatable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isEverCreatable")]
		[Updateable(false), Createable(false)]
		public bool? IsEverCreatable { get; set; }

		///<summary>
		/// Is Ever Updatable via API?
		/// <para>Name: IsEverUpdatable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isEverUpdatable")]
		[Updateable(false), Createable(false)]
		public bool? IsEverUpdatable { get; set; }

		///<summary>
		/// Is Ever Deletable via API?
		/// <para>Name: IsEverDeletable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isEverDeletable")]
		[Updateable(false), Createable(false)]
		public bool? IsEverDeletable { get; set; }

		///<summary>
		/// Is Feed Enabled?
		/// <para>Name: IsFeedEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFeedEnabled")]
		[Updateable(false), Createable(false)]
		public bool? IsFeedEnabled { get; set; }

		///<summary>
		/// Queryable
		/// <para>Name: IsQueryable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isQueryable")]
		[Updateable(false), Createable(false)]
		public bool? IsQueryable { get; set; }

		///<summary>
		/// Is MRU List Functionality Enabled for This Object?
		/// <para>Name: IsMruEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isMruEnabled")]
		[Updateable(false), Createable(false)]
		public bool? IsMruEnabled { get; set; }

		///<summary>
		/// Detail URL
		/// <para>Name: DetailUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "detailUrl")]
		[Updateable(false), Createable(false)]
		public string DetailUrl { get; set; }

		///<summary>
		/// Edit URL
		/// <para>Name: EditUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "editUrl")]
		[Updateable(false), Createable(false)]
		public string EditUrl { get; set; }

		///<summary>
		/// New URL
		/// <para>Name: NewUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "newUrl")]
		[Updateable(false), Createable(false)]
		public string NewUrl { get; set; }

		///<summary>
		/// Edit Definition URL
		/// <para>Name: EditDefinitionUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "editDefinitionUrl")]
		[Updateable(false), Createable(false)]
		public string EditDefinitionUrl { get; set; }

		///<summary>
		/// Help Setting Page Name
		/// <para>Name: HelpSettingPageName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "helpSettingPageName")]
		[Updateable(false), Createable(false)]
		public string HelpSettingPageName { get; set; }

		///<summary>
		/// Help Setting Page URL
		/// <para>Name: HelpSettingPageUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "helpSettingPageUrl")]
		[Updateable(false), Createable(false)]
		public string HelpSettingPageUrl { get; set; }

		///<summary>
		/// User Entity Access ID
		/// <para>Name: RunningUserEntityAccessId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "runningUserEntityAccessId")]
		[Updateable(false), Createable(false)]
		public string RunningUserEntityAccessId { get; set; }

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
		/// Is Layout Enabled?
		/// <para>Name: IsLayoutable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isLayoutable")]
		[Updateable(false), Createable(false)]
		public bool? IsLayoutable { get; set; }

		///<summary>
		/// Record Types Supported
		/// <para>Name: RecordTypesSupported</para>
		/// <para>SF Type: complexvalue</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recordTypesSupported")]
		[Updateable(false), Createable(false)]
		public string RecordTypesSupported { get; set; }

		///<summary>
		/// Internal Sharing Model
		/// <para>Name: InternalSharingModel</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "internalSharingModel")]
		[Updateable(false), Createable(false)]
		public string InternalSharingModel { get; set; }

		///<summary>
		/// External sharing Model
		/// <para>Name: ExternalSharingModel</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "externalSharingModel")]
		[Updateable(false), Createable(false)]
		public string ExternalSharingModel { get; set; }

		///<summary>
		/// Has Subtypes?
		/// <para>Name: HasSubtypes</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasSubtypes")]
		[Updateable(false), Createable(false)]
		public bool? HasSubtypes { get; set; }

		///<summary>
		/// Is Subtype?
		/// <para>Name: IsSubtype</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isSubtype")]
		[Updateable(false), Createable(false)]
		public bool? IsSubtype { get; set; }

		///<summary>
		/// Is Einstein Activity Capture Enabled?
		/// <para>Name: IsAutoActivityCaptureEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isAutoActivityCaptureEnabled")]
		[Updateable(false), Createable(false)]
		public bool? IsAutoActivityCaptureEnabled { get; set; }

		///<summary>
		/// Is Interface?
		/// <para>Name: IsInterface</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isInterface")]
		[Updateable(false), Createable(false)]
		public bool? IsInterface { get; set; }

		///<summary>
		/// Interfaces Implemented
		/// <para>Name: ImplementsInterfaces</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "implementsInterfaces")]
		[Updateable(false), Createable(false)]
		public string ImplementsInterfaces { get; set; }

		///<summary>
		/// Implemented By
		/// <para>Name: ImplementedBy</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "implementedBy")]
		[Updateable(false), Createable(false)]
		public string ImplementedBy { get; set; }

		///<summary>
		/// Interfaces Extended
		/// <para>Name: ExtendsInterfaces</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "extendsInterfaces")]
		[Updateable(false), Createable(false)]
		public string ExtendsInterfaces { get; set; }

		///<summary>
		/// Extended By
		/// <para>Name: ExtendedBy</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "extendedBy")]
		[Updateable(false), Createable(false)]
		public string ExtendedBy { get; set; }

		///<summary>
		/// Default Implementation
		/// <para>Name: DefaultImplementation</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "defaultImplementation")]
		[Updateable(false), Createable(false)]
		public string DefaultImplementation { get; set; }

	}
}
