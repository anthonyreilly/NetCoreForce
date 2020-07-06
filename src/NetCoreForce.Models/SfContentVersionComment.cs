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
	/// Content Version Comment
	///<para>SObject Name: ContentVersionComment</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfContentVersionComment : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ContentVersionComment"; }
		}

		///<summary>
		/// ContentVersionComment ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// ContentDocument ID
		/// <para>Name: ContentDocumentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "contentDocumentId")]
		[Updateable(false), Createable(false)]
		public string ContentDocumentId { get; set; }

		///<summary>
		/// ReferenceTo: ContentDocument
		/// <para>RelationshipName: ContentDocument</para>
		///</summary>
		[JsonProperty(PropertyName = "contentDocument")]
		[Updateable(false), Createable(false)]
		public SfContentDocument ContentDocument { get; set; }

		///<summary>
		/// ContentVersion ID
		/// <para>Name: ContentVersionId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "contentVersionId")]
		[Updateable(false), Createable(false)]
		public string ContentVersionId { get; set; }

		///<summary>
		/// ReferenceTo: ContentVersion
		/// <para>RelationshipName: ContentVersion</para>
		///</summary>
		[JsonProperty(PropertyName = "contentVersion")]
		[Updateable(false), Createable(false)]
		public SfContentVersion ContentVersion { get; set; }

		///<summary>
		/// Version Comment
		/// <para>Name: UserComment</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "userComment")]
		[Updateable(false), Createable(false)]
		public string UserComment { get; set; }

		///<summary>
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

	}
}
