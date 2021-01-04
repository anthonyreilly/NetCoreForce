// SF API version v50.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Platform Event Subscription
	///<para>SObject Name: EventBusSubscriber</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfEventBusSubscriber : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "EventBusSubscriber"; }
		}

		///<summary>
		/// Event ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// External ID
		/// <para>Name: ExternalId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "externalId")]
		[Updateable(false), Createable(false)]
		public string ExternalId { get; set; }

		///<summary>
		/// Subscriber Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
		public string Name { get; set; }

		///<summary>
		/// Type
		/// <para>Name: Type</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		[Updateable(false), Createable(false)]
		public string Type { get; set; }

		///<summary>
		/// Topic
		/// <para>Name: Topic</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "topic")]
		[Updateable(false), Createable(false)]
		public string Topic { get; set; }

		///<summary>
		/// Position
		/// <para>Name: Position</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "position")]
		[Updateable(false), Createable(false)]
		public int? Position { get; set; }

		///<summary>
		/// Tip
		/// <para>Name: Tip</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "tip")]
		[Updateable(false), Createable(false)]
		public int? Tip { get; set; }

		///<summary>
		/// Retry Attempts
		/// <para>Name: Retries</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "retries")]
		[Updateable(false), Createable(false)]
		public int? Retries { get; set; }

		///<summary>
		/// Last Error Message
		/// <para>Name: LastError</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastError")]
		[Updateable(false), Createable(false)]
		public string LastError { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		[Updateable(false), Createable(false)]
		public string Status { get; set; }

	}
}
