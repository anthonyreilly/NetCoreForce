// SF API version v50.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Content Delivery View
	///<para>SObject Name: ContentDistributionView</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfContentDistributionView : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ContentDistributionView"; }
		}

		///<summary>
		/// Content Delivery View ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Content Delivery ID
		/// <para>Name: DistributionId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "distributionId")]
		[Updateable(false), Createable(false)]
		public string DistributionId { get; set; }

		///<summary>
		/// ReferenceTo: ContentDistribution
		/// <para>RelationshipName: Distribution</para>
		///</summary>
		[JsonProperty(PropertyName = "distribution")]
		[Updateable(false), Createable(false)]
		public SfContentDistribution Distribution { get; set; }

		///<summary>
		/// Content Delivery View ID
		/// <para>Name: ParentViewId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "parentViewId")]
		[Updateable(false), Createable(false)]
		public string ParentViewId { get; set; }

		///<summary>
		/// View Date
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

		///<summary>
		/// Internal View
		/// <para>Name: IsInternal</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isInternal")]
		[Updateable(false), Createable(false)]
		public bool? IsInternal { get; set; }

		///<summary>
		/// File Downloaded
		/// <para>Name: IsDownload</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDownload")]
		[Updateable(false), Createable(false)]
		public bool? IsDownload { get; set; }

	}
}
