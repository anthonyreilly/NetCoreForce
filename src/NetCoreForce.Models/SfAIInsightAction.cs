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
	/// AI Insight Action
	///<para>SObject Name: AIInsightAction</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfAIInsightAction : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "AIInsightAction"; }
		}

		///<summary>
		/// AI Insight Action ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Createable(false)]
		public bool? IsDeleted { get; set; }

		///<summary>
		/// Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>AutoNumber field</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
		public string Name { get; set; }

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
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

		///<summary>
		/// Last Modified By ID
		/// <para>Name: LastModifiedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedById")]
		[Updateable(false), Createable(false)]
		public string LastModifiedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: LastModifiedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedBy")]
		[Updateable(false), Createable(false)]
		public SfUser LastModifiedBy { get; set; }

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
		/// AI Record Insight ID
		/// <para>Name: AiRecordInsightId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "aiRecordInsightId")]
		[Updateable(false), Createable(false)]
		public string AiRecordInsightId { get; set; }

		///<summary>
		/// ReferenceTo: AIRecordInsight
		/// <para>RelationshipName: AiRecordInsight</para>
		///</summary>
		[JsonProperty(PropertyName = "aiRecordInsight")]
		[Updateable(false), Createable(false)]
		public SfAIRecordInsight AiRecordInsight { get; set; }

		///<summary>
		/// Action Type
		/// <para>Name: Type</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		[Updateable(false), Createable(false)]
		public string Type { get; set; }

		///<summary>
		/// Confidence
		/// <para>Name: Confidence</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "confidence")]
		[Updateable(false), Createable(false)]
		public double? Confidence { get; set; }

		///<summary>
		/// Action Name
		/// <para>Name: ActionName</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "actionName")]
		[Updateable(false), Createable(false)]
		public string ActionName { get; set; }

		///<summary>
		/// Action ID
		/// <para>Name: ActionId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "actionId")]
		[Updateable(false), Createable(false)]
		public string ActionId { get; set; }

	}
}
