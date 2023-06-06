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
	/// Expression Set View
	///<para>SObject Name: ExpressionSetView</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfExpressionSetView : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ExpressionSetView"; }
		}

		///<summary>
		/// Expression Set View ID
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
		/// Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
		public string Name { get; set; }

		///<summary>
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		[Updateable(false), Createable(false)]
		public string Description { get; set; }

		///<summary>
		/// NamespacePrefix
		/// <para>Name: NamespacePrefix</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "namespacePrefix")]
		[Updateable(false), Createable(false)]
		public string NamespacePrefix { get; set; }

		///<summary>
		/// IsTemplate
		/// <para>Name: IsTemplate</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isTemplate")]
		[Updateable(false), Createable(false)]
		public bool? IsTemplate { get; set; }

		///<summary>
		/// Last Modified By
		/// <para>Name: LastModifiedBy</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedBy")]
		[Updateable(false), Createable(false)]
		public string LastModifiedBy { get; set; }

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
		/// Expression Set Details
		/// <para>Name: ExpressionSetDetails</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "expressionSetDetails")]
		[Updateable(false), Createable(false)]
		public string ExpressionSetDetails { get; set; }

	}
}
