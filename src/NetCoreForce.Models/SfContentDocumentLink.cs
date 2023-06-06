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
	/// Content Document Link
	///<para>SObject Name: ContentDocumentLink</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfContentDocumentLink : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ContentDocumentLink"; }
		}

		///<summary>
		/// ContentDocumentLink ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Linked Entity ID
		/// <para>Name: LinkedEntityId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "linkedEntityId")]
		[Updateable(false), Createable(true)]
		public string LinkedEntityId { get; set; }

		///<summary>
		/// ContentDocument ID
		/// <para>Name: ContentDocumentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "contentDocumentId")]
		[Updateable(false), Createable(true)]
		public string ContentDocumentId { get; set; }

		///<summary>
		/// ReferenceTo: ContentDocument
		/// <para>RelationshipName: ContentDocument</para>
		///</summary>
		[JsonProperty(PropertyName = "contentDocument")]
		[Updateable(false), Createable(false)]
		public SfContentDocument ContentDocument { get; set; }

		///<summary>
		/// Is Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Createable(false)]
		public bool? IsDeleted { get; set; }

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
		/// Share Type
		/// <para>Name: ShareType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "shareType")]
		public string ShareType { get; set; }

		///<summary>
		/// Visibility
		/// <para>Name: Visibility</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "visibility")]
		public string Visibility { get; set; }

	}
}
