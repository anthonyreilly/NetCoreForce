// SF API version v48.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Secure Agent Plug-in
	///<para>SObject Name: SecureAgentPlugin</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfSecureAgentPlugin : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "SecureAgentPlugin"; }
		}

		///<summary>
		/// Secure Agent Plug-in ID
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
		/// Secure Agent ID
		/// <para>Name: SecureAgentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "secureAgentId")]
		[Updateable(false), Createable(false)]
		public string SecureAgentId { get; set; }

		///<summary>
		/// ReferenceTo: SecureAgent
		/// <para>RelationshipName: SecureAgent</para>
		///</summary>
		[JsonProperty(PropertyName = "secureAgent")]
		[Updateable(false), Createable(false)]
		public SfSecureAgent SecureAgent { get; set; }

		///<summary>
		/// Name
		/// <para>Name: PluginName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "pluginName")]
		[Updateable(false), Createable(false)]
		public string PluginName { get; set; }

		///<summary>
		/// Type
		/// <para>Name: PluginType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "pluginType")]
		[Updateable(false), Createable(false)]
		public string PluginType { get; set; }

		///<summary>
		/// Requested Version
		/// <para>Name: RequestedVersion</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "requestedVersion")]
		[Updateable(false), Createable(false)]
		public string RequestedVersion { get; set; }

		///<summary>
		/// Update Window Start
		/// <para>Name: UpdateWindowStart</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "updateWindowStart")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? UpdateWindowStart { get; set; }

		///<summary>
		/// Update Window End
		/// <para>Name: UpdateWindowEnd</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "updateWindowEnd")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? UpdateWindowEnd { get; set; }

	}
}
