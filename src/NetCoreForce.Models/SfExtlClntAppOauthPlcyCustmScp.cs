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
	/// External Client App OAuth Policies Custom Scope
	///<para>SObject Name: ExtlClntAppOauthPlcyCustmScp</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfExtlClntAppOauthPlcyCustmScp : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ExtlClntAppOauthPlcyCustmScp"; }
		}

		///<summary>
		/// External Client App OAuth Policies Custom Scope ID
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
		/// External Client App OAuth Policy Config ID
		/// <para>Name: ExtlClntAppOauthPlcyCnfgId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "extlClntAppOauthPlcyCnfgId")]
		[Updateable(false), Createable(false)]
		public string ExtlClntAppOauthPlcyCnfgId { get; set; }

		///<summary>
		/// ReferenceTo: ExtlClntAppOauthPlcyCnfg
		/// <para>RelationshipName: ExtlClntAppOauthPlcyCnfg</para>
		///</summary>
		[JsonProperty(PropertyName = "extlClntAppOauthPlcyCnfg")]
		[Updateable(false), Createable(false)]
		public SfExtlClntAppOauthPlcyCnfg ExtlClntAppOauthPlcyCnfg { get; set; }

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
		/// OAuth Custom Scope ID
		/// <para>Name: OauthCustomScopeId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthCustomScopeId")]
		[Updateable(false), Createable(false)]
		public string OauthCustomScopeId { get; set; }

		///<summary>
		/// ReferenceTo: OauthCustomScope
		/// <para>RelationshipName: OauthCustomScope</para>
		///</summary>
		[JsonProperty(PropertyName = "oauthCustomScope")]
		[Updateable(false), Createable(false)]
		public SfOauthCustomScope OauthCustomScope { get; set; }

	}
}
