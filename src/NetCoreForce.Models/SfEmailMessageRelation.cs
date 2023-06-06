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
	/// Email Message Relation
	///<para>SObject Name: EmailMessageRelation</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfEmailMessageRelation : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "EmailMessageRelation"; }
		}

		///<summary>
		/// Email Message Relation ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Email Message ID
		/// <para>Name: EmailMessageId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "emailMessageId")]
		[Updateable(false), Createable(true)]
		public string EmailMessageId { get; set; }

		///<summary>
		/// ReferenceTo: EmailMessage
		/// <para>RelationshipName: EmailMessage</para>
		///</summary>
		[JsonProperty(PropertyName = "emailMessage")]
		[Updateable(false), Createable(false)]
		public SfEmailMessage EmailMessage { get; set; }

		///<summary>
		/// Relation ID
		/// <para>Name: RelationId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relationId")]
		public string RelationId { get; set; }

		///<summary>
		/// Relation Type
		/// <para>Name: RelationType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "relationType")]
		[Updateable(false), Createable(true)]
		public string RelationType { get; set; }

		///<summary>
		/// Relation Address
		/// <para>Name: RelationAddress</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relationAddress")]
		[Updateable(false), Createable(true)]
		public string RelationAddress { get; set; }

		///<summary>
		/// Relation Object Type
		/// <para>Name: RelationObjectType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relationObjectType")]
		[Updateable(false), Createable(false)]
		public string RelationObjectType { get; set; }

		///<summary>
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

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

		///<summary>
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Createable(false)]
		public bool? IsDeleted { get; set; }

	}
}
