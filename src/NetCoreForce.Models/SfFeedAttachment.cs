// SF API version v41.0
// Custom fields included: False
// Relationship objects included: True

using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Feed Attachment
	///<para>SObject Name: FeedAttachment</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfFeedAttachment : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "FeedAttachment"; }
		}

		///<summary>
		/// Feed Attachment ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// Feed Entity ID
		/// <para>Name: FeedEntityId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "feedEntityId")]
		[Updateable(false), Creatable(true)]
		public string FeedEntityId { get; set; }

		///<summary>
		/// Feed Attachment Type
		/// <para>Name: Type</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "type")]
		[Updateable(false), Creatable(true)]
		public string Type { get; set; }

		///<summary>
		/// Attachment Record ID
		/// <para>Name: RecordId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recordId")]
		[Updateable(false), Creatable(true)]
		public string RecordId { get; set; }

		///<summary>
		/// Feed Attachment Title
		/// <para>Name: Title</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "title")]
		public string Title { get; set; }

		///<summary>
		/// Feed Attachment Value
		/// <para>Name: Value</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "value")]
		public string Value { get; set; }

		///<summary>
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Creatable(false)]
		public bool? IsDeleted { get; set; }

	}
}
