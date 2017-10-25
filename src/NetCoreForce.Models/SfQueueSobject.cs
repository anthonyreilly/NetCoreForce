// SF API version v41.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Queue Sobject
	///<para>SObject Name: QueueSobject</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfQueueSobject : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "QueueSobject"; }
		}

		///<summary>
		/// Queue Sobject ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Group ID
		/// <para>Name: QueueId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "queueId")]
		[Updateable(false), Createable(true)]
		public string QueueId { get; set; }

		///<summary>
		/// ReferenceTo: Group
		/// <para>RelationshipName: Queue</para>
		///</summary>
		[JsonProperty(PropertyName = "queue")]
		[Updateable(false), Createable(false)]
		public SfGroup Queue { get; set; }

		///<summary>
		/// Sobject Type
		/// <para>Name: SobjectType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "sobjectType")]
		[Updateable(false), Createable(true)]
		public string SobjectType { get; set; }

		///<summary>
		/// Created By ID
		/// <para>Name: CreatedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdById")]
		[Updateable(false), Createable(false)]
		public string CreatedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: CreatedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "createdBy")]
		[Updateable(false), Createable(false)]
		public SfUser CreatedBy { get; set; }

		///<summary>
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

	}
}
