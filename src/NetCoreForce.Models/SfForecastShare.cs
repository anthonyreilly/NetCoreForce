// SF API version v39.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Forecast Share
	///<para>SObject Name: ForecastShare</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfForecastShare : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ForecastShare"; }
		}

		///<summary>
		/// Forecast Share ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// User Role ID
		/// <para>Name: UserRoleId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userRoleId")]
		[Updateable(false), Createable(false)]
		public string UserRoleId { get; set; }

		///<summary>
		/// User/Group ID
		/// <para>Name: UserOrGroupId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "userOrGroupId")]
		[Updateable(false), Createable(false)]
		public string UserOrGroupId { get; set; }

		///<summary>
		/// Forecast Access
		/// <para>Name: AccessLevel</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "accessLevel")]
		[Updateable(false), Createable(false)]
		public string AccessLevel { get; set; }

		///<summary>
		/// Submit Allowed
		/// <para>Name: CanSubmit</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "canSubmit")]
		[Updateable(false), Createable(false)]
		public bool? CanSubmit { get; set; }

		///<summary>
		/// Row Cause
		/// <para>Name: RowCause</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "rowCause")]
		[Updateable(false), Createable(false)]
		public string RowCause { get; set; }

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

	}
}
