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
	/// Record
	///<para>SObject Name: TopicAssignment</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfTopicAssignment : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "TopicAssignment"; }
		}

		///<summary>
		/// Topic Assignment Id
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// Topic ID
		/// <para>Name: TopicId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "topicId")]
		[Updateable(false), Creatable(true)]
		public string TopicId { get; set; }

		///<summary>
		/// ReferenceTo: Topic
		/// <para>RelationshipName: Topic</para>
		///</summary>
		[JsonProperty(PropertyName = "topic")]
		[Updateable(false), Creatable(false)]
		public SfTopic Topic { get; set; }

		///<summary>
		/// Entity ID
		/// <para>Name: EntityId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "entityId")]
		[Updateable(false), Creatable(true)]
		public string EntityId { get; set; }

		///<summary>
		/// Record Key Prefix
		/// <para>Name: EntityKeyPrefix</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "entityKeyPrefix")]
		[Updateable(false), Creatable(false)]
		public string EntityKeyPrefix { get; set; }

		///<summary>
		/// Object Type
		/// <para>Name: EntityType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "entityType")]
		[Updateable(false), Creatable(false)]
		public string EntityType { get; set; }

		///<summary>
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

		///<summary>
		/// Created By ID
		/// <para>Name: CreatedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdById")]
		[Updateable(false), Creatable(false)]
		public string CreatedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: CreatedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "createdBy")]
		[Updateable(false), Creatable(false)]
		public SfUser CreatedBy { get; set; }

		///<summary>
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Creatable(false)]
		public bool? IsDeleted { get; set; }

		///<summary>
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

	}
}
