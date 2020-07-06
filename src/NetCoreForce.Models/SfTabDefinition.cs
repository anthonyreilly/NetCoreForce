// SF API version v48.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Tab Definition
	///<para>SObject Name: TabDefinition</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfTabDefinition : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "TabDefinition"; }
		}

		///<summary>
		/// Tab Definition ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Tab Definition Durable ID
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
		/// Label
		/// <para>Name: Label</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "label")]
		[Updateable(false), Createable(false)]
		public string Label { get; set; }

		///<summary>
		/// Is Custom
		/// <para>Name: IsCustom</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isCustom")]
		[Updateable(false), Createable(false)]
		public bool? IsCustom { get; set; }

		///<summary>
		/// sObject Name
		/// <para>Name: SobjectName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sobjectName")]
		[Updateable(false), Createable(false)]
		public string SobjectName { get; set; }

		///<summary>
		/// URL
		/// <para>Name: Url</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "url")]
		[Updateable(false), Createable(false)]
		public string Url { get; set; }

		///<summary>
		/// Is Available In Aloha
		/// <para>Name: IsAvailableInAloha</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isAvailableInAloha")]
		[Updateable(false), Createable(false)]
		public bool? IsAvailableInAloha { get; set; }

		///<summary>
		/// Is Available In Lightning
		/// <para>Name: IsAvailableInLightning</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isAvailableInLightning")]
		[Updateable(false), Createable(false)]
		public bool? IsAvailableInLightning { get; set; }

		///<summary>
		/// Is Available In Mobile
		/// <para>Name: IsAvailableInMobile</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isAvailableInMobile")]
		[Updateable(false), Createable(false)]
		public bool? IsAvailableInMobile { get; set; }

		///<summary>
		/// Is Available In Desktop
		/// <para>Name: IsAvailableInDesktop</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isAvailableInDesktop")]
		[Updateable(false), Createable(false)]
		public bool? IsAvailableInDesktop { get; set; }

		///<summary>
		/// Mobile URL
		/// <para>Name: MobileUrl</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mobileUrl")]
		[Updateable(false), Createable(false)]
		public string MobileUrl { get; set; }

	}
}
