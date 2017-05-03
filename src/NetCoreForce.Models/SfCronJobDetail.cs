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
	/// Cron Job
	///<para>SObject Name: CronJobDetail</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfCronJobDetail : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "CronJobDetail"; }
		}

		///<summary>
		/// Job ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Job Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
		public string Name { get; set; }

		///<summary>
		/// Type
		/// <para>Name: JobType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "jobType")]
		[Updateable(false), Createable(false)]
		public string JobType { get; set; }

	}
}
