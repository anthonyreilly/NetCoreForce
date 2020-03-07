// SF API version v41.0
// Custom fields included: False
// Relationship objects included: True

using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Picklist Value Info
	///<para>SObject Name: PicklistValueInfo</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfPicklistValueInfo : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "PicklistValueInfo"; }
		}

		///<summary>
		/// Picklist Value Info ID
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
		/// Value
		/// <para>Name: Value</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "value")]
		[Updateable(false), Creatable(false)]
		public string Value { get; set; }

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
		/// Is Default Value
		/// <para>Name: IsDefaultValue</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDefaultValue")]
		[Updateable(false), Creatable(false)]
		public bool? IsDefaultValue { get; set; }

		///<summary>
		/// Is Active
		/// <para>Name: IsActive</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isActive")]
		[Updateable(false), Creatable(false)]
		public bool? IsActive { get; set; }

		///<summary>
		/// Valid For
		/// <para>Name: ValidFor</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "validFor")]
		[Updateable(false), Creatable(false)]
		public string ValidFor { get; set; }

		///<summary>
		/// Entity Particle ID
		/// <para>Name: EntityParticleId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "entityParticleId")]
		[Updateable(false), Creatable(false)]
		public string EntityParticleId { get; set; }

	}
}
