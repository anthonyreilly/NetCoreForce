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
	/// Flow Variable
	///<para>SObject Name: FlowVariableView</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfFlowVariableView : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "FlowVariableView"; }
		}

		///<summary>
		/// Flow Variable View ID
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
		/// Flow Version View ID
		/// <para>Name: FlowVersionViewId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "flowVersionViewId")]
		[Updateable(false), Createable(false)]
		public string FlowVersionViewId { get; set; }

		///<summary>
		/// Variable API Name
		/// <para>Name: ApiName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "apiName")]
		[Updateable(false), Createable(false)]
		public string ApiName { get; set; }

		///<summary>
		/// Variable Description
		/// <para>Name: Description</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		[Updateable(false), Createable(false)]
		public string Description { get; set; }

		///<summary>
		/// Variable Data Type
		/// <para>Name: DataType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dataType")]
		[Updateable(false), Createable(false)]
		public string DataType { get; set; }

		///<summary>
		/// Variable is available for input
		/// <para>Name: IsInput</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isInput")]
		[Updateable(false), Createable(false)]
		public bool? IsInput { get; set; }

		///<summary>
		/// Variable is available for output
		/// <para>Name: IsOutput</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isOutput")]
		[Updateable(false), Createable(false)]
		public bool? IsOutput { get; set; }

		///<summary>
		/// Variable allows multiple values (collection)
		/// <para>Name: IsCollection</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isCollection")]
		[Updateable(false), Createable(false)]
		public bool? IsCollection { get; set; }

		///<summary>
		/// Record Variable Object
		/// <para>Name: ObjectType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "objectType")]
		[Updateable(false), Createable(false)]
		public string ObjectType { get; set; }

	}
}
