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
	/// Recommendation Response
	///<para>SObject Name: RecommendationResponse</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfRecommendationResponse : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "RecommendationResponse"; }
		}

		///<summary>
		/// Recommendation Response ID
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
		/// On Behalf of ID
		/// <para>Name: OnBehalfOf</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "onBehalfOf")]
		[Updateable(false), Createable(true)]
		public string OnBehalfOf { get; set; }

		///<summary>
		/// On Behalf of Object
		/// <para>Name: OnBehalfOfType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "onBehalfOfType")]
		[Updateable(false), Createable(false)]
		public string OnBehalfOfType { get; set; }

		///<summary>
		/// On Behalf of Name at Time of Response
		/// <para>Name: OnBehalfOfName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "onBehalfOfName")]
		[Updateable(false), Createable(false)]
		public string OnBehalfOfName { get; set; }

		///<summary>
		/// Recommendation Key
		/// <para>Name: RecommendationKey</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "recommendationKey")]
		[Updateable(false), Createable(true)]
		public string RecommendationKey { get; set; }

		///<summary>
		/// Recommendation Object
		/// <para>Name: RecommendationType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recommendationType")]
		[Updateable(false), Createable(false)]
		public string RecommendationType { get; set; }

		///<summary>
		/// Recommendation Name at Time of Response
		/// <para>Name: RecommendationName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recommendationName")]
		[Updateable(false), Createable(true)]
		public string RecommendationName { get; set; }

		///<summary>
		/// Action Name at Time of Response
		/// <para>Name: ActionReference</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "actionReference")]
		[Updateable(false), Createable(true)]
		public string ActionReference { get; set; }

		///<summary>
		/// Response
		/// <para>Name: Response</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "response")]
		[Updateable(false), Createable(true)]
		public string Response { get; set; }

		///<summary>
		/// Strategy Name at Time of Response
		/// <para>Name: StrategyReference</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "strategyReference")]
		[Updateable(false), Createable(true)]
		public string StrategyReference { get; set; }

		///<summary>
		/// Strategy Version at Time of Response
		/// <para>Name: StrategyVersion</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "strategyVersion")]
		[Updateable(false), Createable(false)]
		public string StrategyVersion { get; set; }

		///<summary>
		/// Context Record ID
		/// <para>Name: ContextRecord</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contextRecord")]
		[Updateable(false), Createable(true)]
		public string ContextRecord { get; set; }

		///<summary>
		/// Context Object
		/// <para>Name: ContextRecordType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contextRecordType")]
		[Updateable(false), Createable(false)]
		public string ContextRecordType { get; set; }

		///<summary>
		/// Context Record Name at Time of Response
		/// <para>Name: ContextRecordName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contextRecordName")]
		[Updateable(false), Createable(false)]
		public string ContextRecordName { get; set; }

	}
}
