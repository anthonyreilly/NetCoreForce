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
	/// Active Permission Set License Metric
	///<para>SObject Name: ActivePermSetLicenseMetric</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfActivePermSetLicenseMetric : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ActivePermSetLicenseMetric"; }
		}

		///<summary>
		/// Active Permission Set License Metric ID
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
		/// Permission Set License ID
		/// <para>Name: PermissionSetLicenseId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionSetLicenseId")]
		[Updateable(false), Createable(false)]
		public string PermissionSetLicenseId { get; set; }

		///<summary>
		/// ReferenceTo: PermissionSetLicense
		/// <para>RelationshipName: PermissionSetLicense</para>
		///</summary>
		[JsonProperty(PropertyName = "permissionSetLicense")]
		[Updateable(false), Createable(false)]
		public SfPermissionSetLicense PermissionSetLicense { get; set; }

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

		///<summary>
		/// Permission Set License Developer Name
		/// <para>Name: DeveloperName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "developerName")]
		[Updateable(false), Createable(false)]
		public string DeveloperName { get; set; }

		///<summary>
		/// Permission Set License Master Label
		/// <para>Name: MasterLabel</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "masterLabel")]
		[Updateable(false), Createable(false)]
		public string MasterLabel { get; set; }

		///<summary>
		/// Total License Count
		/// <para>Name: TotalLicenses</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "totalLicenses")]
		[Updateable(false), Createable(false)]
		public int? TotalLicenses { get; set; }

	}
}
