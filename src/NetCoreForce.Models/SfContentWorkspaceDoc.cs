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
	/// Library Document
	///<para>SObject Name: ContentWorkspaceDoc</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfContentWorkspaceDoc : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ContentWorkspaceDoc"; }
		}

		///<summary>
		/// Library Document ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Library ID
		/// <para>Name: ContentWorkspaceId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "contentWorkspaceId")]
		[Updateable(false), Createable(true)]
		public string ContentWorkspaceId { get; set; }

		///<summary>
		/// ReferenceTo: ContentWorkspace
		/// <para>RelationshipName: ContentWorkspace</para>
		///</summary>
		[JsonProperty(PropertyName = "contentWorkspace")]
		[Updateable(false), Createable(false)]
		public SfContentWorkspace ContentWorkspace { get; set; }

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
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

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
		/// Is Owning Library
		/// <para>Name: IsOwner</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isOwner")]
		[Updateable(false), Createable(false)]
		public bool? IsOwner { get; set; }

		///<summary>
		/// Is Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Createable(false)]
		public bool? IsDeleted { get; set; }

	}
}
