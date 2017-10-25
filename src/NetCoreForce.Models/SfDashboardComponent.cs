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
	/// Dashboard Component
	///<para>SObject Name: DashboardComponent</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfDashboardComponent : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "DashboardComponent"; }
		}

		///<summary>
		/// Dashboard Component ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Dashboard Component Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
		public string Name { get; set; }

		///<summary>
		/// Dashboard ID
		/// <para>Name: DashboardId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "dashboardId")]
		[Updateable(false), Createable(false)]
		public string DashboardId { get; set; }

		///<summary>
		/// ReferenceTo: Dashboard
		/// <para>RelationshipName: Dashboard</para>
		///</summary>
		[JsonProperty(PropertyName = "dashboard")]
		[Updateable(false), Createable(false)]
		public SfDashboard Dashboard { get; set; }

	}
}
