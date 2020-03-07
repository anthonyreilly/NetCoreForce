// SF API version v41.0
// Custom fields included: False
// Relationship objects included: True

using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Outgoing Email
	///<para>SObject Name: OutgoingEmail</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfOutgoingEmail : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "OutgoingEmail"; }
		}

		///<summary>
		/// Outgoing Email ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// External ID
		/// <para>Name: ExternalId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "externalId")]
		[Updateable(false), Creatable(true)]
		public string ExternalId { get; set; }

		///<summary>
		/// From
		/// <para>Name: ValidatedFromAddress</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "validatedFromAddress")]
		[Updateable(false), Creatable(true)]
		public string ValidatedFromAddress { get; set; }

		///<summary>
		/// To
		/// <para>Name: ToAddress</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "toAddress")]
		[Updateable(false), Creatable(true)]
		public string ToAddress { get; set; }

		///<summary>
		/// CC
		/// <para>Name: CcAddress</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "ccAddress")]
		[Updateable(false), Creatable(true)]
		public string CcAddress { get; set; }

		///<summary>
		/// BCC
		/// <para>Name: BccAddress</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "bccAddress")]
		[Updateable(false), Creatable(true)]
		public string BccAddress { get; set; }

		///<summary>
		/// Subject
		/// <para>Name: Subject</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "subject")]
		[Updateable(false), Creatable(true)]
		public string Subject { get; set; }

		///<summary>
		/// Text Body
		/// <para>Name: TextBody</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "textBody")]
		[Updateable(false), Creatable(true)]
		public string TextBody { get; set; }

		///<summary>
		/// HTML Body
		/// <para>Name: HtmlBody</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "htmlBody")]
		[Updateable(false), Creatable(true)]
		public string HtmlBody { get; set; }

		///<summary>
		/// Related To ID
		/// <para>Name: RelatedToId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relatedToId")]
		[Updateable(false), Creatable(true)]
		public string RelatedToId { get; set; }

		///<summary>
		/// Name ID
		/// <para>Name: WhoId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "whoId")]
		[Updateable(false), Creatable(true)]
		public string WhoId { get; set; }

		///<summary>
		/// Email Template ID
		/// <para>Name: EmailTemplateId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "emailTemplateId")]
		[Updateable(false), Creatable(true)]
		public string EmailTemplateId { get; set; }

		///<summary>
		/// ReferenceTo: EmailTemplate
		/// <para>RelationshipName: EmailTemplate</para>
		///</summary>
		[JsonProperty(PropertyName = "emailTemplate")]
		[Updateable(false), Creatable(false)]
		public SfEmailTemplate EmailTemplate { get; set; }

	}
}
