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
	/// Flex Queue Item
	///<para>SObject Name: FlexQueueItem</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfFlexQueueItem : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "FlexQueueItem"; }
		}

		///<summary>
		/// Flex Queue Item Id
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Flex Queue Item Id
		/// <para>Name: FlexQueueItemId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "flexQueueItemId")]
		[Updateable(false), Createable(false)]
		public string FlexQueueItemId { get; set; }

		///<summary>
		/// Job Type
		/// <para>Name: JobType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "jobType")]
		[Updateable(false), Createable(false)]
		public string JobType { get; set; }

		///<summary>
		/// Apex Job ID
		/// <para>Name: AsyncApexJobId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "asyncApexJobId")]
		[Updateable(false), Createable(false)]
		public string AsyncApexJobId { get; set; }

		///<summary>
		/// ReferenceTo: AsyncApexJob
		/// <para>RelationshipName: AsyncApexJob</para>
		///</summary>
		[JsonProperty(PropertyName = "asyncApexJob")]
		[Updateable(false), Createable(false)]
		public SfAsyncApexJob AsyncApexJob { get; set; }

		///<summary>
		/// Job Position
		/// <para>Name: JobPosition</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "jobPosition")]
		[Updateable(false), Createable(false)]
		public int? JobPosition { get; set; }

	}
}
