// SF API version v41.0
// Custom fields included: False
// Relationship objects included: True

using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Apex Page Info
	///<para>SObject Name: ApexPageInfo</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfApexPageInfo : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ApexPageInfo"; }
		}

		///<summary>
		/// Entity Id
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
		/// Apex Page ID
		/// <para>Name: ApexPageId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "apexPageId")]
		[Updateable(false), Creatable(false)]
		public string ApexPageId { get; set; }

		///<summary>
		/// Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Creatable(false)]
		public string Name { get; set; }

		///<summary>
		/// Name Space Prefix
		/// <para>Name: NameSpacePrefix</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "nameSpacePrefix")]
		[Updateable(false), Creatable(false)]
		public string NameSpacePrefix { get; set; }

		///<summary>
		/// API Version
		/// <para>Name: ApiVersion</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "apiVersion")]
		[Updateable(false), Creatable(false)]
		public double? ApiVersion { get; set; }

		///<summary>
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		[Updateable(false), Creatable(false)]
		public string Description { get; set; }

		///<summary>
		/// Is Available In Touch
		/// <para>Name: IsAvailableInTouch</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isAvailableInTouch")]
		[Updateable(false), Creatable(false)]
		public bool? IsAvailableInTouch { get; set; }

		///<summary>
		/// Master Label
		/// <para>Name: MasterLabel</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "masterLabel")]
		[Updateable(false), Creatable(false)]
		public string MasterLabel { get; set; }

		///<summary>
		/// Show Header
		/// <para>Name: IsShowHeader</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "isShowHeader")]
		[Updateable(false), Creatable(false)]
		public string IsShowHeader { get; set; }

	}
}
