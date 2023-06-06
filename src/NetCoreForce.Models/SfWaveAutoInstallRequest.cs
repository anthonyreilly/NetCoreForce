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
	/// Wave Auto Install Request
	///<para>SObject Name: WaveAutoInstallRequest</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfWaveAutoInstallRequest : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "WaveAutoInstallRequest"; }
		}

		///<summary>
		/// Request Id
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
		/// Request Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

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
		/// Wave Template Api Name
		/// <para>Name: TemplateApiName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "templateApiName")]
		[Updateable(false), Createable(true)]
		public string TemplateApiName { get; set; }

		///<summary>
		/// Wave Template Version
		/// <para>Name: TemplateVersion</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "templateVersion")]
		[Updateable(false), Createable(true)]
		public string TemplateVersion { get; set; }

		///<summary>
		/// Folder ID
		/// <para>Name: FolderId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "folderId")]
		[Updateable(false), Createable(true)]
		public string FolderId { get; set; }

		///<summary>
		/// ReferenceTo: Folder
		/// <para>RelationshipName: Folder</para>
		///</summary>
		[JsonProperty(PropertyName = "folder")]
		[Updateable(false), Createable(false)]
		public SfFolder Folder { get; set; }

		///<summary>
		/// Request Type
		/// <para>Name: RequestType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "requestType")]
		[Updateable(false), Createable(true)]
		public string RequestType { get; set; }

		///<summary>
		/// Request Status
		/// <para>Name: RequestStatus</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "requestStatus")]
		public string RequestStatus { get; set; }

		///<summary>
		/// Failed Reason
		/// <para>Name: FailedReason</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "failedReason")]
		[Updateable(false), Createable(false)]
		public string FailedReason { get; set; }

		///<summary>
		/// Configuration
		/// <para>Name: Configuration</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "configuration")]
		[Updateable(false), Createable(true)]
		public string Configuration { get; set; }

		///<summary>
		/// Request Log
		/// <para>Name: RequestLog</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "requestLog")]
		public string RequestLog { get; set; }

	}
}
