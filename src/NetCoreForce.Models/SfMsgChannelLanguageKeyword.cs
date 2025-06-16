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
	/// Messaging Channel Language Keyword
	///<para>SObject Name: MsgChannelLanguageKeyword</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfMsgChannelLanguageKeyword : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "MsgChannelLanguageKeyword"; }
		}

		///<summary>
		/// Messaging Channel Language Keyword ID
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
		/// Modified On
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
		/// Language
		/// <para>Name: MasterLanguage</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "masterLanguage")]
		public string MasterLanguage { get; set; }

		///<summary>
		/// Opt-In Keywords
		/// <para>Name: OptInKeywords</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "optInKeywords")]
		public string OptInKeywords { get; set; }

		///<summary>
		/// Double Opt-In Keywords
		/// <para>Name: DoubleOptInKeywords</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "doubleOptInKeywords")]
		public string DoubleOptInKeywords { get; set; }

		///<summary>
		/// Opt-In Confirmation
		/// <para>Name: OptInConfirmation</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "optInConfirmation")]
		public string OptInConfirmation { get; set; }

		///<summary>
		/// Help Keywords
		/// <para>Name: HelpKeywords</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "helpKeywords")]
		public string HelpKeywords { get; set; }

		///<summary>
		/// Help Response
		/// <para>Name: HelpResponse</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "helpResponse")]
		public string HelpResponse { get; set; }

		///<summary>
		/// Opt-Out Keywords
		/// <para>Name: OptOutKeywords</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "optOutKeywords")]
		public string OptOutKeywords { get; set; }

		///<summary>
		/// Opt-Out Confirmation
		/// <para>Name: OptOutConfirmation</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "optOutConfirmation")]
		public string OptOutConfirmation { get; set; }

		///<summary>
		/// Messaging Channel ID
		/// <para>Name: MessagingChannelId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "messagingChannelId")]
		[Updateable(false), Createable(true)]
		public string MessagingChannelId { get; set; }

		///<summary>
		/// ReferenceTo: MessagingChannel
		/// <para>RelationshipName: MessagingChannel</para>
		///</summary>
		[JsonProperty(PropertyName = "messagingChannel")]
		[Updateable(false), Createable(false)]
		public SfMessagingChannel MessagingChannel { get; set; }

		///<summary>
		/// Custom Keywords
		/// <para>Name: CustomKeywords</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "customKeywords")]
		public string CustomKeywords { get; set; }

		///<summary>
		/// Custom Response
		/// <para>Name: CustomResponse</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "customResponse")]
		public string CustomResponse { get; set; }

		///<summary>
		/// Messaging Channel Usage ID
		/// <para>Name: MessagingChannelUsageId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "messagingChannelUsageId")]
		public string MessagingChannelUsageId { get; set; }

		///<summary>
		/// ReferenceTo: MessagingChannelUsage
		/// <para>RelationshipName: MessagingChannelUsage</para>
		///</summary>
		[JsonProperty(PropertyName = "messagingChannelUsage")]
		[Updateable(false), Createable(false)]
		public SfMessagingChannelUsage MessagingChannelUsage { get; set; }

	}
}
