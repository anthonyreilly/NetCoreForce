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
	/// Mail Merge Template
	///<para>SObject Name: MailmergeTemplate</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfMailmergeTemplate : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "MailmergeTemplate"; }
		}

		///<summary>
		/// Mail Merge Template ID
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
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		///<summary>
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

		///<summary>
		/// File
		/// <para>Name: Filename</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "filename")]
		[Updateable(false), Createable(true)]
		public string Filename { get; set; }

		///<summary>
		/// Body Length
		/// <para>Name: BodyLength</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "bodyLength")]
		[Updateable(false), Createable(false)]
		public int? BodyLength { get; set; }

		///<summary>
		/// Body
		/// <para>Name: Body</para>
		/// <para>SF Type: base64</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "body")]
		[Updateable(false), Createable(true)]
		public string Body { get; set; }

		///<summary>
		/// Last Used Date
		/// <para>Name: LastUsedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastUsedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastUsedDate { get; set; }

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
		/// Attachment has been scanned for XSS
		/// <para>Name: SecurityOptionsAttachmentScannedForXSS</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "securityOptionsAttachmentScannedForXSS")]
		public bool? SecurityOptionsAttachmentScannedForXSS { get; set; }

		///<summary>
		/// XSS threat was detected in the attachment
		/// <para>Name: SecurityOptionsAttachmentHasXSSThreat</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "securityOptionsAttachmentHasXSSThreat")]
		public bool? SecurityOptionsAttachmentHasXSSThreat { get; set; }

		///<summary>
		/// Attachment has been scanned for Flash Injection
		/// <para>Name: SecurityOptionsAttachmentScannedforFlash</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "securityOptionsAttachmentScannedforFlash")]
		public bool? SecurityOptionsAttachmentScannedforFlash { get; set; }

		///<summary>
		/// Flash Injection was detected in the attachment
		/// <para>Name: SecurityOptionsAttachmentHasFlash</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "securityOptionsAttachmentHasFlash")]
		public bool? SecurityOptionsAttachmentHasFlash { get; set; }

	}
}
