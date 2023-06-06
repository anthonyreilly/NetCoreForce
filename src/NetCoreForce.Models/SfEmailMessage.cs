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
	/// Email Message
	///<para>SObject Name: EmailMessage</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfEmailMessage : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "EmailMessage"; }
		}

		///<summary>
		/// Email Message ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Case ID
		/// <para>Name: ParentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "parentId")]
		[Updateable(false), Createable(true)]
		public string ParentId { get; set; }

		///<summary>
		/// ReferenceTo: Case
		/// <para>RelationshipName: Parent</para>
		///</summary>
		[JsonProperty(PropertyName = "parent")]
		[Updateable(false), Createable(false)]
		public SfCase Parent { get; set; }

		///<summary>
		/// Activity ID
		/// <para>Name: ActivityId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "activityId")]
		[Updateable(false), Createable(true)]
		public string ActivityId { get; set; }

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
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

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
		/// Text Body
		/// <para>Name: TextBody</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "textBody")]
		public string TextBody { get; set; }

		///<summary>
		/// HTML Body
		/// <para>Name: HtmlBody</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "htmlBody")]
		public string HtmlBody { get; set; }

		///<summary>
		/// Headers
		/// <para>Name: Headers</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "headers")]
		public string Headers { get; set; }

		///<summary>
		/// Subject
		/// <para>Name: Subject</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "subject")]
		public string Subject { get; set; }

		///<summary>
		/// Email Message Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
		public string Name { get; set; }

		///<summary>
		/// From Name
		/// <para>Name: FromName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fromName")]
		public string FromName { get; set; }

		///<summary>
		/// From Address
		/// <para>Name: FromAddress</para>
		/// <para>SF Type: email</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fromAddress")]
		public string FromAddress { get; set; }

		///<summary>
		/// From
		/// <para>Name: ValidatedFromAddress</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "validatedFromAddress")]
		public string ValidatedFromAddress { get; set; }

		///<summary>
		/// To Address
		/// <para>Name: ToAddress</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "toAddress")]
		public string ToAddress { get; set; }

		///<summary>
		/// CC Address
		/// <para>Name: CcAddress</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "ccAddress")]
		public string CcAddress { get; set; }

		///<summary>
		/// BCC Address
		/// <para>Name: BccAddress</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "bccAddress")]
		public string BccAddress { get; set; }

		///<summary>
		/// Is Incoming
		/// <para>Name: Incoming</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "incoming")]
		[Updateable(false), Createable(true)]
		public bool? Incoming { get; set; }

		///<summary>
		/// Has Attachment
		/// <para>Name: HasAttachment</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "hasAttachment")]
		[Updateable(false), Createable(false)]
		public bool? HasAttachment { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		public string Status { get; set; }

		///<summary>
		/// Message Date
		/// <para>Name: MessageDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "messageDate")]
		public DateTimeOffset? MessageDate { get; set; }

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
		/// Email Message ID
		/// <para>Name: ReplyToEmailMessageId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "replyToEmailMessageId")]
		[Updateable(false), Createable(true)]
		public string ReplyToEmailMessageId { get; set; }

		///<summary>
		/// ReferenceTo: EmailMessage
		/// <para>RelationshipName: ReplyToEmailMessage</para>
		///</summary>
		[JsonProperty(PropertyName = "replyToEmailMessage")]
		[Updateable(false), Createable(false)]
		public SfEmailMessage ReplyToEmailMessage { get; set; }

		///<summary>
		/// Is Externally Visible
		/// <para>Name: IsExternallyVisible</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isExternallyVisible")]
		[Updateable(false), Createable(false)]
		public bool? IsExternallyVisible { get; set; }

		///<summary>
		/// Message ID
		/// <para>Name: MessageIdentifier</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "messageIdentifier")]
		public string MessageIdentifier { get; set; }

		///<summary>
		/// Thread ID
		/// <para>Name: ThreadIdentifier</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "threadIdentifier")]
		public string ThreadIdentifier { get; set; }

		///<summary>
		/// Client Thread ID
		/// <para>Name: ClientThreadIdentifier</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "clientThreadIdentifier")]
		public string ClientThreadIdentifier { get; set; }

		///<summary>
		/// Is Client Managed
		/// <para>Name: IsClientManaged</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isClientManaged")]
		[Updateable(false), Createable(true)]
		public bool? IsClientManaged { get; set; }

		///<summary>
		/// Related To ID
		/// <para>Name: RelatedToId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relatedToId")]
		[Updateable(false), Createable(true)]
		public string RelatedToId { get; set; }

		///<summary>
		/// Is Tracked
		/// <para>Name: IsTracked</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isTracked")]
		public bool? IsTracked { get; set; }

		///<summary>
		/// Opened?
		/// <para>Name: IsOpened</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isOpened")]
		[Updateable(false), Createable(false)]
		public bool? IsOpened { get; set; }

		///<summary>
		/// First Opened
		/// <para>Name: FirstOpenedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "firstOpenedDate")]
		public DateTimeOffset? FirstOpenedDate { get; set; }

		///<summary>
		/// Last Opened
		/// <para>Name: LastOpenedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastOpenedDate")]
		public DateTimeOffset? LastOpenedDate { get; set; }

		///<summary>
		/// Bounced?
		/// <para>Name: IsBounced</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isBounced")]
		public bool? IsBounced { get; set; }

		///<summary>
		/// Email Template ID
		/// <para>Name: EmailTemplateId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "emailTemplateId")]
		public string EmailTemplateId { get; set; }

		///<summary>
		/// ReferenceTo: EmailTemplate
		/// <para>RelationshipName: EmailTemplate</para>
		///</summary>
		[JsonProperty(PropertyName = "emailTemplate")]
		[Updateable(false), Createable(false)]
		public SfEmailTemplate EmailTemplate { get; set; }

	}
}
