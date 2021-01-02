// SF API version v50.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Setup Audit Trail Entry
	///<para>SObject Name: SetupAuditTrail</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfSetupAuditTrail : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "SetupAuditTrail"; }
		}

		///<summary>
		/// Setup Audit Trail ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Action
		/// <para>Name: Action</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "action")]
		[Updateable(false), Createable(false)]
		public string Action { get; set; }

		///<summary>
		/// Section
		/// <para>Name: Section</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "section")]
		[Updateable(false), Createable(false)]
		public string Section { get; set; }

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
		/// Display
		/// <para>Name: Display</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "display")]
		[Updateable(false), Createable(false)]
		public string Display { get; set; }

		///<summary>
		/// Delegate User
		/// <para>Name: DelegateUser</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "delegateUser")]
		[Updateable(false), Createable(false)]
		public string DelegateUser { get; set; }

		///<summary>
		/// Source Namespace Prefix
		/// <para>Name: ResponsibleNamespacePrefix</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "responsibleNamespacePrefix")]
		[Updateable(false), Createable(false)]
		public string ResponsibleNamespacePrefix { get; set; }

	}
}
