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
	/// Action Link Template
	///<para>SObject Name: ActionLinkTemplate</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfActionLinkTemplate : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ActionLinkTemplate"; }
		}

		///<summary>
		/// Action Link Template ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Creatable(false)]
		public bool? IsDeleted { get; set; }

		///<summary>
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

		///<summary>
		/// Created By ID
		/// <para>Name: CreatedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdById")]
		[Updateable(false), Creatable(false)]
		public string CreatedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: CreatedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "createdBy")]
		[Updateable(false), Creatable(false)]
		public SfUser CreatedBy { get; set; }

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
		/// Last Modified By ID
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
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

		///<summary>
		/// Action Link Group Template ID
		/// <para>Name: ActionLinkGroupTemplateId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "actionLinkGroupTemplateId")]
		[Updateable(false), Creatable(true)]
		public string ActionLinkGroupTemplateId { get; set; }

		///<summary>
		/// ReferenceTo: ActionLinkGroupTemplate
		/// <para>RelationshipName: ActionLinkGroupTemplate</para>
		///</summary>
		[JsonProperty(PropertyName = "actionLinkGroupTemplate")]
		[Updateable(false), Creatable(false)]
		public SfActionLinkGroupTemplate ActionLinkGroupTemplate { get; set; }

		///<summary>
		/// Label Key
		/// <para>Name: LabelKey</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "labelKey")]
		public string LabelKey { get; set; }

		///<summary>
		/// HTTP Method
		/// <para>Name: Method</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "method")]
		public string Method { get; set; }

		///<summary>
		/// Action Type
		/// <para>Name: LinkType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "linkType")]
		public string LinkType { get; set; }

		///<summary>
		/// Position
		/// <para>Name: Position</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "position")]
		public int? Position { get; set; }

		///<summary>
		/// Confirmation Required
		/// <para>Name: IsConfirmationRequired</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isConfirmationRequired")]
		public bool? IsConfirmationRequired { get; set; }

		///<summary>
		/// Default Link in Group
		/// <para>Name: IsGroupDefault</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isGroupDefault")]
		public bool? IsGroupDefault { get; set; }

		///<summary>
		/// User Visibility
		/// <para>Name: UserVisibility</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userVisibility")]
		public string UserVisibility { get; set; }

		///<summary>
		/// Custom User Alias
		/// <para>Name: UserAlias</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "userAlias")]
		public string UserAlias { get; set; }

		///<summary>
		/// Label
		/// <para>Name: Label</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "label")]
		public string Label { get; set; }

		///<summary>
		/// Action URL
		/// <para>Name: ActionUrl</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "actionUrl")]
		public string ActionUrl { get; set; }

		///<summary>
		/// HTTP Request Body
		/// <para>Name: RequestBody</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "requestBody")]
		public string RequestBody { get; set; }

		///<summary>
		/// HTTP Headers
		/// <para>Name: Headers</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "headers")]
		public string Headers { get; set; }

	}
}
