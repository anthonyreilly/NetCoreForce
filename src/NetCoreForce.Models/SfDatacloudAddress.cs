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
	/// Data.com Address
	///<para>SObject Name: DatacloudAddress</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfDatacloudAddress : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "DatacloudAddress"; }
		}

		///<summary>
		/// Data.com System ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Data.com Address ID
		/// <para>Name: ExternalId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "externalId")]
		[Updateable(false), Createable(false)]
		public string ExternalId { get; set; }

		///<summary>
		///  Address Line 1 
		/// <para>Name: AddressLine1</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "addressLine1")]
		[Updateable(false), Createable(false)]
		public string AddressLine1 { get; set; }

		///<summary>
		///  Address Line 2 
		/// <para>Name: AddressLine2</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "addressLine2")]
		[Updateable(false), Createable(false)]
		public string AddressLine2 { get; set; }

		///<summary>
		/// City
		/// <para>Name: City</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "city")]
		[Updateable(false), Createable(false)]
		public string City { get; set; }

		///<summary>
		/// State
		/// <para>Name: State</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "state")]
		[Updateable(false), Createable(false)]
		public string State { get; set; }

		///<summary>
		/// Country/Territory
		/// <para>Name: Country</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "country")]
		[Updateable(false), Createable(false)]
		public string Country { get; set; }

		///<summary>
		/// PostalCode
		/// <para>Name: PostalCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "postalCode")]
		[Updateable(false), Createable(false)]
		public string PostalCode { get; set; }

		///<summary>
		///  Latitude 
		/// <para>Name: Latitude</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "latitude")]
		[Updateable(false), Createable(false)]
		public string Latitude { get; set; }

		///<summary>
		/// Longitude 
		/// <para>Name: Longitude</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "longitude")]
		[Updateable(false), Createable(false)]
		public string Longitude { get; set; }

		///<summary>
		///  GeoAccuracy Code
		/// <para>Name: GeoAccuracyCode</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "geoAccuracyCode")]
		[Updateable(false), Createable(false)]
		public string GeoAccuracyCode { get; set; }

		///<summary>
		///  GeoAccuracy Num
		/// <para>Name: GeoAccuracyNum</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "geoAccuracyNum")]
		[Updateable(false), Createable(false)]
		public string GeoAccuracyNum { get; set; }

	}
}
