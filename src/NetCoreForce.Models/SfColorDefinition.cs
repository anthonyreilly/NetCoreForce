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
	/// Color Definition
	///<para>SObject Name: ColorDefinition</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfColorDefinition : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ColorDefinition"; }
		}

		///<summary>
		/// Color Definition ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Color Definition Durable ID
		/// <para>Name: DurableId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "durableId")]
		[Updateable(false), Createable(false)]
		public string DurableId { get; set; }

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
		/// Color
		/// <para>Name: Color</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "color")]
		[Updateable(false), Createable(false)]
		public string Color { get; set; }

		///<summary>
		/// Theme
		/// <para>Name: Theme</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "theme")]
		[Updateable(false), Createable(false)]
		public string Theme { get; set; }

		///<summary>
		/// Context
		/// <para>Name: Context</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "context")]
		[Updateable(false), Createable(false)]
		public string Context { get; set; }

	}
}
