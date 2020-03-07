// SF API version v41.0
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
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// Durable ID
		/// <para>Name: DurableId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "durableId")]
		[Updateable(false), Creatable(false)]
		public string DurableId { get; set; }

		///<summary>
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: LastModifiedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedById")]
		[Updateable(false), Creatable(false)]
		public string LastModifiedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: LastModifiedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedBy")]
		[Updateable(false), Creatable(false)]
		public SfUser LastModifiedBy { get; set; }

		///<summary>
		/// Qualified API Name
		/// <para>Name: QualifiedApiName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "qualifiedApiName")]
		[Updateable(false), Creatable(false)]
		public string QualifiedApiName { get; set; }

		///<summary>
		/// Namespace Prefix
		/// <para>Name: NamespacePrefix</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "namespacePrefix")]
		[Updateable(false), Creatable(false)]
		public string NamespacePrefix { get; set; }

		///<summary>
		/// Developer Name
		/// <para>Name: DeveloperName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "developerName")]
		[Updateable(false), Creatable(false)]
		public string DeveloperName { get; set; }

		///<summary>
		/// Master Label
		/// <para>Name: MasterLabel</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "masterLabel")]
		[Updateable(false), Creatable(false)]
		public string MasterLabel { get; set; }

		///<summary>
		/// Label
		/// <para>Name: Label</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "label")]
		[Updateable(false), Creatable(false)]
		public string Label { get; set; }

		///<summary>
		/// Plural Label
		/// <para>Name: PluralLabel</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "pluralLabel")]
		[Updateable(false), Creatable(false)]
		public string PluralLabel { get; set; }

		///<summary>
		/// Compact Layout ID
		/// <para>Name: DefaultCompactLayoutId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "defaultCompactLayoutId")]
		[Updateable(false), Creatable(false)]
		public string DefaultCompactLayoutId { get; set; }

		///<summary>
		/// Is Customizable?
		/// <para>Name: IsCustomizable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isCustomizable")]
		[Updateable(false), Creatable(false)]
		public bool? IsCustomizable { get; set; }

		///<summary>
		/// Is Apex Triggerable?
		/// <para>Name: IsApexTriggerable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isApexTriggerable")]
		[Updateable(false), Creatable(false)]
		public bool? IsApexTriggerable { get; set; }

		///<summary>
		/// Is Workflow Enabled?
		/// <para>Name: IsWorkflowEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isWorkflowEnabled")]
		[Updateable(false), Creatable(false)]
		public bool? IsWorkflowEnabled { get; set; }

		///<summary>
		/// Is Approval Process Enabled?
		/// <para>Name: IsProcessEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isProcessEnabled")]
		[Updateable(false), Creatable(false)]
		public bool? IsProcessEnabled { get; set; }

		///<summary>
		/// Is Compact Layout Enabled?
		/// <para>Name: IsCompactLayoutable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isCompactLayoutable")]
		[Updateable(false), Creatable(false)]
		public bool? IsCompactLayoutable { get; set; }

		///<summary>
		/// Key Prefix
		/// <para>Name: KeyPrefix</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "keyPrefix")]
		[Updateable(false), Creatable(false)]
		public string KeyPrefix { get; set; }

		///<summary>
		/// Is Custom Setting?
		/// <para>Name: IsCustomSetting</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isCustomSetting")]
		[Updateable(false), Creatable(false)]
		public bool? IsCustomSetting { get; set; }

		///<summary>
		/// Is Deprecated And Hidden?
		/// <para>Name: IsDeprecatedAndHidden</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeprecatedAndHidden")]
		[Updateable(false), Creatable(false)]
		public bool? IsDeprecatedAndHidden { get; set; }

		///<summary>
		/// Is Replicateable?
		/// <para>Name: IsReplicateable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReplicateable")]
		[Updateable(false), Creatable(false)]
		public bool? IsReplicateable { get; set; }

		///<summary>
		/// Is Retrieveable?
		/// <para>Name: IsRetrieveable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isRetrieveable")]
		[Updateable(false), Creatable(false)]
		public bool? IsRetrieveable { get; set; }

		///<summary>
		/// Is Search Layoutable?
		/// <para>Name: IsSearchLayoutable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isSearchLayoutable")]
		[Updateable(false), Creatable(false)]
		public bool? IsSearchLayoutable { get; set; }

		///<summary>
		/// Is Searchable?
		/// <para>Name: IsSearchable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isSearchable")]
		[Updateable(false), Creatable(false)]
		public bool? IsSearchable { get; set; }

		///<summary>
		/// Is Triggerable?
		/// <para>Name: IsTriggerable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isTriggerable")]
		[Updateable(false), Creatable(false)]
		public bool? IsTriggerable { get; set; }

		///<summary>
		/// Is Id Enabled?
		/// <para>Name: IsIdEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isIdEnabled")]
		[Updateable(false), Creatable(false)]
		public bool? IsIdEnabled { get; set; }

		///<summary>
		/// Is Ever Creatable via API?
		/// <para>Name: IsEverCreatable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isEverCreatable")]
		[Updateable(false), Creatable(false)]
		public bool? IsEverCreatable { get; set; }

		///<summary>
		/// Is Ever Updatable via API?
		/// <para>Name: IsEverUpdatable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isEverUpdatable")]
		[Updateable(false), Creatable(false)]
		public bool? IsEverUpdatable { get; set; }

		///<summary>
		/// Is Ever Deletable via API?
		/// <para>Name: IsEverDeletable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isEverDeletable")]
		[Updateable(false), Creatable(false)]
		public bool? IsEverDeletable { get; set; }

		///<summary>
		/// Is Feed Enabled?
		/// <para>Name: IsFeedEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isFeedEnabled")]
		[Updateable(false), Creatable(false)]
		public bool? IsFeedEnabled { get; set; }

		///<summary>
		/// Queryable
		/// <para>Name: IsQueryable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isQueryable")]
		[Updateable(false), Creatable(false)]
		public bool? IsQueryable { get; set; }

		///<summary>
		/// Is MRU List Functionality Enabled for This Object?
		/// <para>Name: IsMruEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isMruEnabled")]
		[Updateable(false), Creatable(false)]
		public bool? IsMruEnabled { get; set; }

		///<summary>
		/// Detail URL
		/// <para>Name: DetailUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "detailUrl")]
		[Updateable(false), Creatable(false)]
		public string DetailUrl { get; set; }

		///<summary>
		/// Edit URL
		/// <para>Name: EditUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "editUrl")]
		[Updateable(false), Creatable(false)]
		public string EditUrl { get; set; }

		///<summary>
		/// New URL
		/// <para>Name: NewUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "newUrl")]
		[Updateable(false), Creatable(false)]
		public string NewUrl { get; set; }

		///<summary>
		/// Edit Definition URL
		/// <para>Name: EditDefinitionUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "editDefinitionUrl")]
		[Updateable(false), Creatable(false)]
		public string EditDefinitionUrl { get; set; }

		///<summary>
		/// Help Setting Page Name
		/// <para>Name: HelpSettingPageName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "helpSettingPageName")]
		[Updateable(false), Creatable(false)]
		public string HelpSettingPageName { get; set; }

		///<summary>
		/// Help Setting Page URL
		/// <para>Name: HelpSettingPageUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "helpSettingPageUrl")]
		[Updateable(false), Creatable(false)]
		public string HelpSettingPageUrl { get; set; }

		///<summary>
		/// User Entity Access ID
		/// <para>Name: RunningUserEntityAccessId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "runningUserEntityAccessId")]
		[Updateable(false), Creatable(false)]
		public string RunningUserEntityAccessId { get; set; }

		///<summary>
		/// Publisher ID
		/// <para>Name: PublisherId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "publisherId")]
		[Updateable(false), Creatable(false)]
		public string PublisherId { get; set; }

		///<summary>
		/// Is Layout Enabled?
		/// <para>Name: IsLayoutable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isLayoutable")]
		[Updateable(false), Creatable(false)]
		public bool? IsLayoutable { get; set; }

		///<summary>
		/// Record Types Supported
		/// <para>Name: RecordTypesSupported</para>
		/// <para>SF Type: complexvalue</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recordTypesSupported")]
		[Updateable(false), Creatable(false)]
		public string RecordTypesSupported { get; set; }

		///<summary>
		/// Internal Sharing Model
		/// <para>Name: InternalSharingModel</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "internalSharingModel")]
		[Updateable(false), Creatable(false)]
		public string InternalSharingModel { get; set; }

		///<summary>
		/// External sharing Model
		/// <para>Name: ExternalSharingModel</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "externalSharingModel")]
		[Updateable(false), Creatable(false)]
		public string ExternalSharingModel { get; set; }

		///<summary>
		/// Has Subtypes?
		/// <para>Name: HasSubtypes</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasSubtypes")]
		[Updateable(false), Creatable(false)]
		public bool? HasSubtypes { get; set; }

		///<summary>
		/// Is Subtype?
		/// <para>Name: IsSubtype</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isSubtype")]
		[Updateable(false), Creatable(false)]
		public bool? IsSubtype { get; set; }

		///<summary>
		/// Is Einstein Activity Capture Enabled?
		/// <para>Name: IsAutoActivityCaptureEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isAutoActivityCaptureEnabled")]
		[Updateable(false), Creatable(false)]
		public bool? IsAutoActivityCaptureEnabled { get; set; }

		///<summary>
		/// Data Steward ID
		/// <para>Name: DataStewardId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dataStewardId")]
		[Updateable(false), Creatable(false)]
		public string DataStewardId { get; set; }

	}
}
