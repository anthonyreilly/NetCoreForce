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
	/// Content Delivery
	///<para>SObject Name: ContentDistribution</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfContentDistribution : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ContentDistribution"; }
		}

		///<summary>
		/// Content Delivery ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

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
		/// Owner ID
		/// <para>Name: OwnerId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "ownerId")]
		public string OwnerId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: Owner</para>
		///</summary>
		[JsonProperty(PropertyName = "owner")]
		[Updateable(false), Creatable(false)]
		public SfUser Owner { get; set; }

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
		/// Content Delivery Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

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
		/// ContentVersion ID
		/// <para>Name: ContentVersionId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "contentVersionId")]
		[Updateable(false), Creatable(true)]
		public string ContentVersionId { get; set; }

		///<summary>
		/// ReferenceTo: ContentVersion
		/// <para>RelationshipName: ContentVersion</para>
		///</summary>
		[JsonProperty(PropertyName = "contentVersion")]
		[Updateable(false), Creatable(false)]
		public SfContentVersion ContentVersion { get; set; }

		///<summary>
		/// ContentDocument ID
		/// <para>Name: ContentDocumentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contentDocumentId")]
		[Updateable(false), Creatable(false)]
		public string ContentDocumentId { get; set; }

		///<summary>
		/// Related Record ID
		/// <para>Name: RelatedRecordId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relatedRecordId")]
		public string RelatedRecordId { get; set; }

		///<summary>
		/// Allow Download as PDF
		/// <para>Name: PreferencesAllowPDFDownload</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "preferencesAllowPDFDownload")]
		public bool? PreferencesAllowPDFDownload { get; set; }

		///<summary>
		/// Allow Download in Original Format
		/// <para>Name: PreferencesAllowOriginalDownload</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "preferencesAllowOriginalDownload")]
		public bool? PreferencesAllowOriginalDownload { get; set; }

		///<summary>
		/// Require Password to Access Content
		/// <para>Name: PreferencesPasswordRequired</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "preferencesPasswordRequired")]
		public bool? PreferencesPasswordRequired { get; set; }

		///<summary>
		/// Notify Me of First View or Download
		/// <para>Name: PreferencesNotifyOnVisit</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "preferencesNotifyOnVisit")]
		public bool? PreferencesNotifyOnVisit { get; set; }

		///<summary>
		/// Content Delivery Opens Latest Version
		/// <para>Name: PreferencesLinkLatestVersion</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "preferencesLinkLatestVersion")]
		public bool? PreferencesLinkLatestVersion { get; set; }

		///<summary>
		/// Allow View in the Browser
		/// <para>Name: PreferencesAllowViewInBrowser</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "preferencesAllowViewInBrowser")]
		public bool? PreferencesAllowViewInBrowser { get; set; }

		///<summary>
		/// Content Delivery Expires
		/// <para>Name: PreferencesExpires</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "preferencesExpires")]
		public bool? PreferencesExpires { get; set; }

		///<summary>
		/// Email when Preview Images are Ready
		/// <para>Name: PreferencesNotifyRndtnComplete</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "preferencesNotifyRndtnComplete")]
		public bool? PreferencesNotifyRndtnComplete { get; set; }

		///<summary>
		/// Expiration Date
		/// <para>Name: ExpiryDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "expiryDate")]
		public DateTimeOffset? ExpiryDate { get; set; }

		///<summary>
		/// Password
		/// <para>Name: Password</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "password")]
		[Updateable(false), Creatable(false)]
		public string Password { get; set; }

		///<summary>
		/// View Count
		/// <para>Name: ViewCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "viewCount")]
		[Updateable(false), Creatable(false)]
		public int? ViewCount { get; set; }

		///<summary>
		/// First Viewed
		/// <para>Name: FirstViewDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "firstViewDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? FirstViewDate { get; set; }

		///<summary>
		/// Last Viewed
		/// <para>Name: LastViewDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastViewDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? LastViewDate { get; set; }

		///<summary>
		/// External Link
		/// <para>Name: DistributionPublicUrl</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "distributionPublicUrl")]
		[Updateable(false), Creatable(false)]
		public string DistributionPublicUrl { get; set; }

		///<summary>
		/// File Download Link
		/// <para>Name: ContentDownloadUrl</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contentDownloadUrl")]
		[Updateable(false), Creatable(false)]
		public string ContentDownloadUrl { get; set; }

		///<summary>
		/// PDF Download Link
		/// <para>Name: PdfDownloadUrl</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "pdfDownloadUrl")]
		[Updateable(false), Creatable(false)]
		public string PdfDownloadUrl { get; set; }

	}
}
