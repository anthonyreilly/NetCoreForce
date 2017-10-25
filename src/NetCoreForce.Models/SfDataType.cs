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
	/// Data Type
	///<para>SObject Name: DataType</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfDataType : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "DataType"; }
		}

		///<summary>
		/// Data Type ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Data Type Durable ID
		/// <para>Name: DurableId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "durableId")]
		[Updateable(false), Createable(false)]
		public string DurableId { get; set; }

		///<summary>
		/// Data Type Name
		/// <para>Name: DeveloperName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "developerName")]
		[Updateable(false), Createable(false)]
		public string DeveloperName { get; set; }

		///<summary>
		/// Is this Data Type Complex?
		/// <para>Name: IsComplex</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isComplex")]
		[Updateable(false), Createable(false)]
		public bool? IsComplex { get; set; }

		///<summary>
		/// Service Data Type ID
		/// <para>Name: ContextServiceDataTypeId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contextServiceDataTypeId")]
		[Updateable(false), Createable(false)]
		public string ContextServiceDataTypeId { get; set; }

		///<summary>
		/// WSDL Data Type ID
		/// <para>Name: ContextWsdlDataTypeId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contextWsdlDataTypeId")]
		[Updateable(false), Createable(false)]
		public string ContextWsdlDataTypeId { get; set; }

	}
}
