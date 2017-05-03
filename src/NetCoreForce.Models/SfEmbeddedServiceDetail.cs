// SF API version v39.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Snap-in Detail
	///<para>SObject Name: EmbeddedServiceDetail</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfEmbeddedServiceDetail : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "EmbeddedServiceDetail"; }
		}

		///<summary>
		/// Snap-in Detail ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Snap-in Detail Durable ID
		/// <para>Name: DurableId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "durableId")]
		[Updateable(false), Createable(false)]
		public string DurableId { get; set; }

		///<summary>
		/// Site
		/// <para>Name: Site</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "site")]
		[Updateable(false), Createable(false)]
		public string Site { get; set; }

		///<summary>
		/// Pre-Chat Enabled
		/// <para>Name: IsPrechatEnabled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isPrechatEnabled")]
		[Updateable(false), Createable(false)]
		public bool? IsPrechatEnabled { get; set; }

		///<summary>
		/// Primary Color
		/// <para>Name: PrimaryColor</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "primaryColor")]
		[Updateable(false), Createable(false)]
		public string PrimaryColor { get; set; }

		///<summary>
		/// Secondary Color
		/// <para>Name: SecondaryColor</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "secondaryColor")]
		[Updateable(false), Createable(false)]
		public string SecondaryColor { get; set; }

		///<summary>
		/// Contrast Primary Color
		/// <para>Name: ContrastPrimaryColor</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contrastPrimaryColor")]
		[Updateable(false), Createable(false)]
		public string ContrastPrimaryColor { get; set; }

		///<summary>
		/// NavBar Color
		/// <para>Name: NavBarColor</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "navBarColor")]
		[Updateable(false), Createable(false)]
		public string NavBarColor { get; set; }

		///<summary>
		/// Font
		/// <para>Name: Font</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "font")]
		[Updateable(false), Createable(false)]
		public string Font { get; set; }

	}
}
