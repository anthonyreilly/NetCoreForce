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
	/// Lead Share
	///<para>SObject Name: LeadShare</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfLeadShare : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "LeadShare"; }
		}

		///<summary>
		/// Lead Share ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// Lead ID
		/// <para>Name: LeadId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "leadId")]
		[Updateable(false), Creatable(false)]
		public string LeadId { get; set; }

		///<summary>
		/// ReferenceTo: Lead
		/// <para>RelationshipName: Lead</para>
		///</summary>
		[JsonProperty(PropertyName = "lead")]
		[Updateable(false), Creatable(false)]
		public SfLead Lead { get; set; }

		///<summary>
		/// User/Group ID
		/// <para>Name: UserOrGroupId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userOrGroupId")]
		[Updateable(false), Creatable(false)]
		public string UserOrGroupId { get; set; }

		///<summary>
		/// Lead Access
		/// <para>Name: LeadAccessLevel</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "leadAccessLevel")]
		[Updateable(false), Creatable(false)]
		public string LeadAccessLevel { get; set; }

		///<summary>
		/// Row Cause
		/// <para>Name: RowCause</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "rowCause")]
		[Updateable(false), Creatable(false)]
		public string RowCause { get; set; }

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
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Creatable(false)]
		public bool? IsDeleted { get; set; }

	}
}
