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
	/// Active Profile Metric
	///<para>SObject Name: ActiveProfileMetric</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfActiveProfileMetric : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ActiveProfileMetric"; }
		}

		///<summary>
		/// Active Profile Metric ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Metrics Date
		/// <para>Name: MetricsDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "metricsDate")]
		[Updateable(false), Createable(false)]
		public DateTime? MetricsDate { get; set; }

		///<summary>
		/// User License ID
		/// <para>Name: UserLicenseId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userLicenseId")]
		[Updateable(false), Createable(false)]
		public string UserLicenseId { get; set; }

		///<summary>
		/// ReferenceTo: UserLicense
		/// <para>RelationshipName: UserLicense</para>
		///</summary>
		[JsonProperty(PropertyName = "userLicense")]
		[Updateable(false), Createable(false)]
		public SfUserLicense UserLicense { get; set; }

		///<summary>
		/// Profile ID
		/// <para>Name: ProfileId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "profileId")]
		[Updateable(false), Createable(false)]
		public string ProfileId { get; set; }

		///<summary>
		/// ReferenceTo: Profile
		/// <para>RelationshipName: Profile</para>
		///</summary>
		[JsonProperty(PropertyName = "profile")]
		[Updateable(false), Createable(false)]
		public SfProfile Profile { get; set; }

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
		/// Assigned User Count
		/// <para>Name: AssignedUserCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "assignedUserCount")]
		[Updateable(false), Createable(false)]
		public int? AssignedUserCount { get; set; }

		///<summary>
		/// Active User Count
		/// <para>Name: ActiveUserCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "activeUserCount")]
		[Updateable(false), Createable(false)]
		public int? ActiveUserCount { get; set; }

	}
}
