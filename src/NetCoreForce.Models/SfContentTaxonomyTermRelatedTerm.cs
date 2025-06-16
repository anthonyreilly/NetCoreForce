// SF API version v64.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Content Taxonomy Term Related Term
	///<para>SObject Name: ContentTaxonomyTermRelatedTerm</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfContentTaxonomyTermRelatedTerm : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ContentTaxonomyTermRelatedTerm"; }
		}

		///<summary>
		/// Content Taxonomy Term Related Term ID
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
		/// Content Taxonomy ID
		/// <para>Name: ContentTaxonomyId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "contentTaxonomyId")]
		[Updateable(false), Createable(true)]
		public string ContentTaxonomyId { get; set; }

		///<summary>
		/// ReferenceTo: ContentTaxonomy
		/// <para>RelationshipName: ContentTaxonomy</para>
		///</summary>
		[JsonProperty(PropertyName = "contentTaxonomy")]
		[Updateable(false), Createable(false)]
		public SfContentTaxonomy ContentTaxonomy { get; set; }

		///<summary>
		/// Content Taxonomy Term ID
		/// <para>Name: ContentTaxonomyTermId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "contentTaxonomyTermId")]
		[Updateable(false), Createable(true)]
		public string ContentTaxonomyTermId { get; set; }

		///<summary>
		/// ReferenceTo: ContentTaxonomyTerm
		/// <para>RelationshipName: ContentTaxonomyTerm</para>
		///</summary>
		[JsonProperty(PropertyName = "contentTaxonomyTerm")]
		[Updateable(false), Createable(false)]
		public SfContentTaxonomyTerm ContentTaxonomyTerm { get; set; }

		///<summary>
		/// Content Taxonomy Term ID
		/// <para>Name: RelatedContentTaxonomyTermId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "relatedContentTaxonomyTermId")]
		[Updateable(false), Createable(true)]
		public string RelatedContentTaxonomyTermId { get; set; }

		///<summary>
		/// ReferenceTo: ContentTaxonomyTerm
		/// <para>RelationshipName: RelatedContentTaxonomyTerm</para>
		///</summary>
		[JsonProperty(PropertyName = "relatedContentTaxonomyTerm")]
		[Updateable(false), Createable(false)]
		public SfContentTaxonomyTerm RelatedContentTaxonomyTerm { get; set; }

		///<summary>
		/// Content Taxonomy Term Relationship Type ID
		/// <para>Name: ContentTaxonomyTrmRelaTypeId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "contentTaxonomyTrmRelaTypeId")]
		[Updateable(false), Createable(true)]
		public string ContentTaxonomyTrmRelaTypeId { get; set; }

		///<summary>
		/// ReferenceTo: ContentTaxonomyTermRelationshipType
		/// <para>RelationshipName: ContentTaxonomyTrmRelaType</para>
		///</summary>
		[JsonProperty(PropertyName = "contentTaxonomyTrmRelaType")]
		[Updateable(false), Createable(false)]
		public SfContentTaxonomyTermRelationshipType ContentTaxonomyTrmRelaType { get; set; }

	}
}
