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
	/// Document
	///<para>SObject Name: Document</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfDocument : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "Document"; }
		}

		///<summary>
		/// Document ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Folder ID
		/// <para>Name: FolderId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "folderId")]
		public string FolderId { get; set; }

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
		/// Document Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		///<summary>
		/// Document Unique Name
		/// <para>Name: DeveloperName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "developerName")]
		public string DeveloperName { get; set; }

		///<summary>
		/// Namespace Prefix
		/// <para>Name: NamespacePrefix</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "namespacePrefix")]
		[Updateable(false), Createable(false)]
		public string NamespacePrefix { get; set; }

		///<summary>
		/// MIME Type
		/// <para>Name: ContentType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "contentType")]
		public string ContentType { get; set; }

		///<summary>
		/// File Extension
		/// <para>Name: Type</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		public string Type { get; set; }

		///<summary>
		/// Externally Available
		/// <para>Name: IsPublic</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isPublic")]
		public bool? IsPublic { get; set; }

		///<summary>
		/// Body Length
		/// <para>Name: BodyLength</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "bodyLength")]
		[Updateable(false), Createable(false)]
		public int? BodyLength { get; set; }

		///<summary>
		/// Body
		/// <para>Name: Body</para>
		/// <para>SF Type: base64</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "body")]
		public string Body { get; set; }

		///<summary>
		/// Url
		/// <para>Name: Url</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "url")]
		public string Url { get; set; }

		///<summary>
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

		///<summary>
		/// Keywords
		/// <para>Name: Keywords</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "keywords")]
		public string Keywords { get; set; }

		///<summary>
		/// Internal Use Only
		/// <para>Name: IsInternalUseOnly</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isInternalUseOnly")]
		public bool? IsInternalUseOnly { get; set; }

		///<summary>
		/// Author ID
		/// <para>Name: AuthorId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "authorId")]
		public string AuthorId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: Author</para>
		///</summary>
		[JsonProperty(PropertyName = "author")]
		[Updateable(false), Createable(false)]
		public SfUser Author { get; set; }

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
		/// Document Content Searchable
		/// <para>Name: IsBodySearchable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isBodySearchable")]
		[Updateable(false), Createable(false)]
		public bool? IsBodySearchable { get; set; }

		///<summary>
		/// Last Viewed Date
		/// <para>Name: LastViewedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastViewedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastViewedDate { get; set; }

		///<summary>
		/// Last Referenced Date
		/// <para>Name: LastReferencedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastReferencedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastReferencedDate { get; set; }

	}
}
