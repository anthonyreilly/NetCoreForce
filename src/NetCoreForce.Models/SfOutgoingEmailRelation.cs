// SF API version v41.0
// Custom fields included: False
// Relationship objects included: True

using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Outgoing Email Relation
	///<para>SObject Name: OutgoingEmailRelation</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfOutgoingEmailRelation : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "OutgoingEmailRelation"; }
		}

		///<summary>
		/// Outgoing Email Relation ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// External ID
		/// <para>Name: ExternalId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "externalId")]
		[Updateable(false), Creatable(true)]
		public string ExternalId { get; set; }

		///<summary>
		/// Outgoing Email ID
		/// <para>Name: OutgoingEmailId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "outgoingEmailId")]
		[Updateable(false), Creatable(true)]
		public string OutgoingEmailId { get; set; }

		///<summary>
		/// Relation ID
		/// <para>Name: RelationId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relationId")]
		[Updateable(false), Creatable(true)]
		public string RelationId { get; set; }

		///<summary>
		/// Relation Address
		/// <para>Name: RelationAddress</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relationAddress")]
		[Updateable(false), Creatable(true)]
		public string RelationAddress { get; set; }

	}
}
