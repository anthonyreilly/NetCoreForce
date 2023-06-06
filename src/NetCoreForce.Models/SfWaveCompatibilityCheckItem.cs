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
	/// Wave Compatibility Check Item
	///<para>SObject Name: WaveCompatibilityCheckItem</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfWaveCompatibilityCheckItem : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "WaveCompatibilityCheckItem"; }
		}

		///<summary>
		/// Checklist Item Id
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
		/// Checklist Item Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
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
		/// Checklist Item Task Name
		/// <para>Name: TaskName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "taskName")]
		[Updateable(false), Createable(false)]
		public string TaskName { get; set; }

		///<summary>
		/// Checklist Item Result
		/// <para>Name: TaskResult</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "taskResult")]
		[Updateable(false), Createable(false)]
		public string TaskResult { get; set; }

		///<summary>
		/// Wave Template Api Name
		/// <para>Name: TemplateApiName</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "templateApiName")]
		[Updateable(false), Createable(false)]
		public string TemplateApiName { get; set; }

		///<summary>
		/// Wave Template Version
		/// <para>Name: TemplateVersion</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "templateVersion")]
		[Updateable(false), Createable(false)]
		public string TemplateVersion { get; set; }

		///<summary>
		/// Checklist Task Payload
		/// <para>Name: Payload</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "payload")]
		[Updateable(false), Createable(false)]
		public string Payload { get; set; }

		///<summary>
		/// Auto Install Request ID
		/// <para>Name: WaveAutoInstallRequestId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "waveAutoInstallRequestId")]
		[Updateable(false), Createable(false)]
		public string WaveAutoInstallRequestId { get; set; }

		///<summary>
		/// ReferenceTo: WaveAutoInstallRequest
		/// <para>RelationshipName: WaveAutoInstallRequest</para>
		///</summary>
		[JsonProperty(PropertyName = "waveAutoInstallRequest")]
		[Updateable(false), Createable(false)]
		public SfWaveAutoInstallRequest WaveAutoInstallRequest { get; set; }

	}
}
