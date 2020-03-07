// SF API version v41.0
// Custom fields included: False
// Relationship objects included: True

using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Change Owner Option Info
	///<para>SObject Name: OwnerChangeOptionInfo</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfOwnerChangeOptionInfo : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "OwnerChangeOptionInfo"; }
		}

		///<summary>
		/// Change Owner Option ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// Durable ID
		/// <para>Name: DurableId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "durableId")]
		[Updateable(false), Creatable(false)]
		public string DurableId { get; set; }

		///<summary>
		/// Entity Definition ID
		/// <para>Name: EntityDefinitionId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "entityDefinitionId")]
		[Updateable(false), Creatable(false)]
		public string EntityDefinitionId { get; set; }

		///<summary>
		/// Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Creatable(false)]
		public string Name { get; set; }

		///<summary>
		/// Label
		/// <para>Name: Label</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "label")]
		[Updateable(false), Creatable(false)]
		public string Label { get; set; }

		///<summary>
		/// Is Editable
		/// <para>Name: IsEditable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isEditable")]
		[Updateable(false), Creatable(false)]
		public bool? IsEditable { get; set; }

		///<summary>
		/// Default Value
		/// <para>Name: DefaultValue</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "defaultValue")]
		[Updateable(false), Creatable(false)]
		public bool? DefaultValue { get; set; }

	}
}
