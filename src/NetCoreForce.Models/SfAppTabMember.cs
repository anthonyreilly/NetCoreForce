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
	/// App Tab Member
	///<para>SObject Name: AppTabMember</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfAppTabMember : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "AppTabMember"; }
		}

		///<summary>
		/// App Tab Member ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Durable ID
		/// <para>Name: DurableId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "durableId")]
		[Updateable(false), Createable(false)]
		public string DurableId { get; set; }

		///<summary>
		/// App Definition ID
		/// <para>Name: AppDefinitionId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "appDefinitionId")]
		[Updateable(false), Createable(false)]
		public string AppDefinitionId { get; set; }

		///<summary>
		/// Tab Definition ID
		/// <para>Name: TabDefinitionId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "tabDefinitionId")]
		[Updateable(false), Createable(false)]
		public string TabDefinitionId { get; set; }

		///<summary>
		/// Sort Order
		/// <para>Name: SortOrder</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sortOrder")]
		[Updateable(false), Createable(false)]
		public int? SortOrder { get; set; }

		///<summary>
		/// Workspace Driver Field
		/// <para>Name: WorkspaceDriverField</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "workspaceDriverField")]
		[Updateable(false), Createable(false)]
		public string WorkspaceDriverField { get; set; }

	}
}
