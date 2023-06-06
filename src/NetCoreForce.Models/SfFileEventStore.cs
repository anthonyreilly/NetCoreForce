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
	/// File Event Store
	///<para>SObject Name: FileEventStore</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfFileEventStore : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "FileEventStore"; }
		}

		///<summary>
		/// File Event Store ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

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
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

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
		/// Event Identifier
		/// <para>Name: EventIdentifier</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "eventIdentifier")]
		[Updateable(false), Createable(false)]
		public string EventIdentifier { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: UserId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "userId")]
		[Updateable(false), Createable(false)]
		public string UserId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: User</para>
		///</summary>
		[JsonProperty(PropertyName = "user")]
		[Updateable(false), Createable(false)]
		public SfUser User { get; set; }

		///<summary>
		/// Username
		/// <para>Name: Username</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "username")]
		[Updateable(false), Createable(false)]
		public string Username { get; set; }

		///<summary>
		/// Event Date
		/// <para>Name: EventDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "eventDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? EventDate { get; set; }

		///<summary>
		/// Related Event Identifier
		/// <para>Name: RelatedEventIdentifier</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relatedEventIdentifier")]
		[Updateable(false), Createable(false)]
		public string RelatedEventIdentifier { get; set; }

		///<summary>
		/// Transaction Security Policy ID
		/// <para>Name: PolicyId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "policyId")]
		[Updateable(false), Createable(false)]
		public string PolicyId { get; set; }

		///<summary>
		/// ReferenceTo: TransactionSecurityPolicy
		/// <para>RelationshipName: Policy</para>
		///</summary>
		[JsonProperty(PropertyName = "policy")]
		[Updateable(false), Createable(false)]
		public SfTransactionSecurityPolicy Policy { get; set; }

		///<summary>
		/// Policy Outcome
		/// <para>Name: PolicyOutcome</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "policyOutcome")]
		[Updateable(false), Createable(false)]
		public string PolicyOutcome { get; set; }

		///<summary>
		/// Evaluation Time
		/// <para>Name: EvaluationTime</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "evaluationTime")]
		[Updateable(false), Createable(false)]
		public double? EvaluationTime { get; set; }

		///<summary>
		/// Session Key
		/// <para>Name: SessionKey</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sessionKey")]
		[Updateable(false), Createable(false)]
		public string SessionKey { get; set; }

		///<summary>
		/// Login Key
		/// <para>Name: LoginKey</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "loginKey")]
		[Updateable(false), Createable(false)]
		public string LoginKey { get; set; }

		///<summary>
		/// Session Level
		/// <para>Name: SessionLevel</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sessionLevel")]
		[Updateable(false), Createable(false)]
		public string SessionLevel { get; set; }

		///<summary>
		/// Source IP
		/// <para>Name: SourceIp</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sourceIp")]
		[Updateable(false), Createable(false)]
		public string SourceIp { get; set; }

		///<summary>
		/// ContentDocument ID
		/// <para>Name: DocumentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "documentId")]
		[Updateable(false), Createable(false)]
		public string DocumentId { get; set; }

		///<summary>
		/// ReferenceTo: ContentDocument
		/// <para>RelationshipName: Document</para>
		///</summary>
		[JsonProperty(PropertyName = "document")]
		[Updateable(false), Createable(false)]
		public SfContentDocument Document { get; set; }

		///<summary>
		/// ContentVersion ID
		/// <para>Name: VersionId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "versionId")]
		[Updateable(false), Createable(false)]
		public string VersionId { get; set; }

		///<summary>
		/// ReferenceTo: ContentVersion
		/// <para>RelationshipName: Version</para>
		///</summary>
		[JsonProperty(PropertyName = "version")]
		[Updateable(false), Createable(false)]
		public SfContentVersion Version { get; set; }

		///<summary>
		/// File Name
		/// <para>Name: FileName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fileName")]
		[Updateable(false), Createable(false)]
		public string FileName { get; set; }

		///<summary>
		/// File Type
		/// <para>Name: FileType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fileType")]
		[Updateable(false), Createable(false)]
		public string FileType { get; set; }

		///<summary>
		/// Content Size
		/// <para>Name: ContentSize</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contentSize")]
		[Updateable(false), Createable(false)]
		public int? ContentSize { get; set; }

		///<summary>
		/// Can Download PDF
		/// <para>Name: CanDownloadPdf</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "canDownloadPdf")]
		[Updateable(false), Createable(false)]
		public bool? CanDownloadPdf { get; set; }

		///<summary>
		/// Version Number
		/// <para>Name: VersionNumber</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "versionNumber")]
		[Updateable(false), Createable(false)]
		public string VersionNumber { get; set; }

		///<summary>
		/// Process Duration
		/// <para>Name: ProcessDuration</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "processDuration")]
		[Updateable(false), Createable(false)]
		public double? ProcessDuration { get; set; }

		///<summary>
		/// Is Latest Version
		/// <para>Name: IsLatestVersion</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isLatestVersion")]
		[Updateable(false), Createable(false)]
		public bool? IsLatestVersion { get; set; }

		///<summary>
		/// File Source
		/// <para>Name: FileSource</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fileSource")]
		[Updateable(false), Createable(false)]
		public string FileSource { get; set; }

	}
}
