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
	/// Platform Action
	///<para>SObject Name: PlatformAction</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfPlatformAction : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "PlatformAction"; }
		}

		///<summary>
		/// Not used ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// Platform Action ID
		/// <para>Name: ExternalId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "externalId")]
		[Updateable(false), Creatable(false)]
		public string ExternalId { get; set; }

		///<summary>
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

		///<summary>
		/// Label
		/// <para>Name: Label</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "label")]
		[Updateable(false), Creatable(false)]
		public string Label { get; set; }

		///<summary>
		/// Type
		/// <para>Name: Type</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		[Updateable(false), Creatable(false)]
		public string Type { get; set; }

		///<summary>
		/// Subtype
		/// <para>Name: Subtype</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "subtype")]
		[Updateable(false), Creatable(false)]
		public string Subtype { get; set; }

		///<summary>
		/// API Name
		/// <para>Name: ApiName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "apiName")]
		[Updateable(false), Creatable(false)]
		public string ApiName { get; set; }

		///<summary>
		/// Action Target
		/// <para>Name: ActionTarget</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "actionTarget")]
		[Updateable(false), Creatable(false)]
		public string ActionTarget { get; set; }

		///<summary>
		/// Action Target Type
		/// <para>Name: ActionTargetType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "actionTargetType")]
		[Updateable(false), Creatable(false)]
		public string ActionTargetType { get; set; }

		///<summary>
		/// Confirmation Message
		/// <para>Name: ConfirmationMessage</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "confirmationMessage")]
		[Updateable(false), Creatable(false)]
		public string ConfirmationMessage { get; set; }

		///<summary>
		/// Group ID
		/// <para>Name: GroupId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "groupId")]
		[Updateable(false), Creatable(false)]
		public string GroupId { get; set; }

		///<summary>
		/// Is Group Default
		/// <para>Name: IsGroupDefault</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isGroupDefault")]
		[Updateable(false), Creatable(false)]
		public bool? IsGroupDefault { get; set; }

		///<summary>
		/// Category
		/// <para>Name: Category</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "category")]
		[Updateable(false), Creatable(false)]
		public string Category { get; set; }

		///<summary>
		/// Invocation Status
		/// <para>Name: InvocationStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "invocationStatus")]
		[Updateable(false), Creatable(false)]
		public string InvocationStatus { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: InvokedByUserId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "invokedByUserId")]
		[Updateable(false), Creatable(false)]
		public string InvokedByUserId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: InvokedByUser</para>
		///</summary>
		[JsonProperty(PropertyName = "invokedByUser")]
		[Updateable(false), Creatable(false)]
		public SfUser InvokedByUser { get; set; }

		///<summary>
		/// Source Entity
		/// <para>Name: SourceEntity</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "sourceEntity")]
		[Updateable(false), Creatable(false)]
		public string SourceEntity { get; set; }

		///<summary>
		/// Action List Context
		/// <para>Name: ActionListContext</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "actionListContext")]
		[Updateable(false), Creatable(false)]
		public string ActionListContext { get; set; }

		///<summary>
		/// Device Format
		/// <para>Name: DeviceFormat</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "deviceFormat")]
		[Updateable(false), Creatable(false)]
		public string DeviceFormat { get; set; }

		///<summary>
		/// Icon Content Type
		/// <para>Name: IconContentType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "iconContentType")]
		[Updateable(false), Creatable(false)]
		public string IconContentType { get; set; }

		///<summary>
		/// Icon Height
		/// <para>Name: IconHeight</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "iconHeight")]
		[Updateable(false), Creatable(false)]
		public int? IconHeight { get; set; }

		///<summary>
		/// Icon Width
		/// <para>Name: IconWidth</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "iconWidth")]
		[Updateable(false), Creatable(false)]
		public int? IconWidth { get; set; }

		///<summary>
		/// Icon URL
		/// <para>Name: IconUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "iconUrl")]
		[Updateable(false), Creatable(false)]
		public string IconUrl { get; set; }

		///<summary>
		/// Is Mass Action
		/// <para>Name: IsMassAction</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isMassAction")]
		[Updateable(false), Creatable(false)]
		public bool? IsMassAction { get; set; }

		///<summary>
		/// Primary Color
		/// <para>Name: PrimaryColor</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "primaryColor")]
		[Updateable(false), Creatable(false)]
		public string PrimaryColor { get; set; }

		///<summary>
		/// Related Source Entity
		/// <para>Name: RelatedSourceEntity</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relatedSourceEntity")]
		[Updateable(false), Creatable(false)]
		public string RelatedSourceEntity { get; set; }

		///<summary>
		/// Section
		/// <para>Name: Section</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "section")]
		[Updateable(false), Creatable(false)]
		public string Section { get; set; }

		///<summary>
		/// Related List Record ID
		/// <para>Name: RelatedListRecordId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relatedListRecordId")]
		[Updateable(false), Creatable(false)]
		public string RelatedListRecordId { get; set; }

		///<summary>
		/// Target URL
		/// <para>Name: TargetUrl</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "targetUrl")]
		[Updateable(false), Creatable(false)]
		public string TargetUrl { get; set; }

		///<summary>
		/// Target Object
		/// <para>Name: TargetObject</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "targetObject")]
		[Updateable(false), Creatable(false)]
		public string TargetObject { get; set; }

	}
}
