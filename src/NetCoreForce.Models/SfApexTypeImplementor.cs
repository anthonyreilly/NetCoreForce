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
	/// Apex Type Implementor
	///<para>SObject Name: ApexTypeImplementor</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfApexTypeImplementor : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ApexTypeImplementor"; }
		}

		///<summary>
		/// Apex Type Implementor ID
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
		/// Class ID
		/// <para>Name: ApexClassId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "apexClassId")]
		[Updateable(false), Createable(false)]
		public string ApexClassId { get; set; }

		///<summary>
		/// ReferenceTo: ApexClass
		/// <para>RelationshipName: ApexClass</para>
		///</summary>
		[JsonProperty(PropertyName = "apexClass")]
		[Updateable(false), Createable(false)]
		public SfApexClass ApexClass { get; set; }

		///<summary>
		/// Class Name
		/// <para>Name: ClassName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "className")]
		[Updateable(false), Createable(false)]
		public string ClassName { get; set; }

		///<summary>
		/// Class Namespace Prefix
		/// <para>Name: ClassNamespacePrefix</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "classNamespacePrefix")]
		[Updateable(false), Createable(false)]
		public string ClassNamespacePrefix { get; set; }

		///<summary>
		/// Is Concrete
		/// <para>Name: IsConcrete</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isConcrete")]
		[Updateable(false), Createable(false)]
		public bool? IsConcrete { get; set; }

		///<summary>
		/// Class ID
		/// <para>Name: InterfaceApexClassId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "interfaceApexClassId")]
		[Updateable(false), Createable(false)]
		public string InterfaceApexClassId { get; set; }

		///<summary>
		/// ReferenceTo: ApexClass
		/// <para>RelationshipName: InterfaceApexClass</para>
		///</summary>
		[JsonProperty(PropertyName = "interfaceApexClass")]
		[Updateable(false), Createable(false)]
		public SfApexClass InterfaceApexClass { get; set; }

		///<summary>
		/// Interface Name
		/// <para>Name: InterfaceName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "interfaceName")]
		[Updateable(false), Createable(false)]
		public string InterfaceName { get; set; }

		///<summary>
		/// Interface Namespace Prefix
		/// <para>Name: InterfaceNamespacePrefix</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "interfaceNamespacePrefix")]
		[Updateable(false), Createable(false)]
		public string InterfaceNamespacePrefix { get; set; }

	}
}
