// SF API version v41.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Login IP
	///<para>SObject Name: LoginIp</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfLoginIp : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "LoginIp"; }
		}

		///<summary>
		/// Login IP ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: UsersId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "usersId")]
		[Updateable(false), Creatable(false)]
		public string UsersId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: Users</para>
		///</summary>
		[JsonProperty(PropertyName = "users")]
		[Updateable(false), Creatable(false)]
		public SfUser Users { get; set; }

		///<summary>
		/// Source IP
		/// <para>Name: SourceIp</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sourceIp")]
		[Updateable(false), Creatable(false)]
		public string SourceIp { get; set; }

		///<summary>
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

		///<summary>
		/// IsAuthenticated
		/// <para>Name: IsAuthenticated</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isAuthenticated")]
		[Updateable(false), Creatable(false)]
		public bool? IsAuthenticated { get; set; }

		///<summary>
		/// Challenge SentDate
		/// <para>Name: ChallengeSentDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "challengeSentDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? ChallengeSentDate { get; set; }

		///<summary>
		/// Challenge Method
		/// <para>Name: ChallengeMethod</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "challengeMethod")]
		[Updateable(false), Creatable(false)]
		public string ChallengeMethod { get; set; }

	}
}
