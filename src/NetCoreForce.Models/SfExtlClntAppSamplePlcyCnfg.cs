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
	/// External Client Application Sample Policy Configuration
	///<para>SObject Name: ExtlClntAppSamplePlcyCnfg</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfExtlClntAppSamplePlcyCnfg : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ExtlClntAppSamplePlcyCnfg"; }
		}

		///<summary>
		/// External Client Application Sample Policy Configuration ID
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
		/// <para>Name: DeveloperName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "developerName")]
		[Updateable(false), Createable(false)]
		public string DeveloperName { get; set; }

		///<summary>
		/// Master Language
		/// <para>Name: Language</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "language")]
		[Updateable(false), Createable(false)]
		public string Language { get; set; }

		///<summary>
		/// Label
		/// <para>Name: MasterLabel</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "masterLabel")]
		[Updateable(false), Createable(false)]
		public string MasterLabel { get; set; }

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
		/// External App ID
		/// <para>Name: ExternalClientApplicationId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "externalClientApplicationId")]
		[Updateable(false), Createable(false)]
		public string ExternalClientApplicationId { get; set; }

		///<summary>
		/// ReferenceTo: ExternalClientApplication
		/// <para>RelationshipName: ExternalClientApplication</para>
		///</summary>
		[JsonProperty(PropertyName = "externalClientApplication")]
		[Updateable(false), Createable(false)]
		public SfExternalClientApplication ExternalClientApplication { get; set; }

		///<summary>
		/// Admin Only Policy
		/// <para>Name: AdminOnlyPolicy</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "adminOnlyPolicy")]
		[Updateable(false), Createable(false)]
		public string AdminOnlyPolicy { get; set; }

		///<summary>
		/// Policy One
		/// <para>Name: Policy1</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "policy1")]
		[Updateable(false), Createable(false)]
		public string Policy1 { get; set; }

		///<summary>
		/// Policy Two
		/// <para>Name: Policy2</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "policy2")]
		[Updateable(false), Createable(false)]
		public string Policy2 { get; set; }

		///<summary>
		/// External Client Application Sample Settings ID
		/// <para>Name: ExtlClntAppSampleSettingsId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "extlClntAppSampleSettingsId")]
		[Updateable(false), Createable(false)]
		public string ExtlClntAppSampleSettingsId { get; set; }

		///<summary>
		/// ReferenceTo: ExtlClntAppSampleSettings
		/// <para>RelationshipName: ExtlClntAppSampleSettings</para>
		///</summary>
		[JsonProperty(PropertyName = "extlClntAppSampleSettings")]
		[Updateable(false), Createable(false)]
		public SfExtlClntAppSampleSettings ExtlClntAppSampleSettings { get; set; }

	}
}
