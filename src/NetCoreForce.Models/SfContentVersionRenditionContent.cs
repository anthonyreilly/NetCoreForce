// SF API version v67.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Content Rendition
	///<para>SObject Name: ContentVersionRenditionContent</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfContentVersionRenditionContent : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ContentVersionRenditionContent"; }
		}

		///<summary>
		/// Content Rendition ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Parent Content ID
		/// <para>Name: ParentContentId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "parentContentId")]
		[Updateable(false), Createable(false)]
		public string ParentContentId { get; set; }

		///<summary>
		/// Version Data
		/// <para>Name: VersionData</para>
		/// <para>SF Type: base64</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "versionData")]
		[Updateable(false), Createable(false)]
		public string VersionData { get; set; }

		///<summary>
		/// File Type
		/// <para>Name: FileType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fileType")]
		[Updateable(false), Createable(false)]
		public string FileType { get; set; }

		///<summary>
		/// Rendition URL
		/// <para>Name: DownloadUrl</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "downloadUrl")]
		[Updateable(false), Createable(false)]
		public string DownloadUrl { get; set; }

		///<summary>
		/// Standard Rendition Type
		/// <para>Name: StdRenditionType</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "stdRenditionType")]
		[Updateable(false), Createable(false)]
		public string StdRenditionType { get; set; }

	}
}
