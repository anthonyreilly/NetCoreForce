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
	/// Scheduled Jobs
	///<para>SObject Name: CronTrigger</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfCronTrigger : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "CronTrigger"; }
		}

		///<summary>
		/// Scheduled Job ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// Job ID
		/// <para>Name: CronJobDetailId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "cronJobDetailId")]
		[Updateable(false), Creatable(false)]
		public string CronJobDetailId { get; set; }

		///<summary>
		/// ReferenceTo: CronJobDetail
		/// <para>RelationshipName: CronJobDetail</para>
		///</summary>
		[JsonProperty(PropertyName = "cronJobDetail")]
		[Updateable(false), Creatable(false)]
		public SfCronJobDetail CronJobDetail { get; set; }

		///<summary>
		/// Next Run Time
		/// <para>Name: NextFireTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "nextFireTime")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? NextFireTime { get; set; }

		///<summary>
		/// Previous Run Time
		/// <para>Name: PreviousFireTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "previousFireTime")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? PreviousFireTime { get; set; }

		///<summary>
		/// Job State
		/// <para>Name: State</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "state")]
		[Updateable(false), Creatable(false)]
		public string State { get; set; }

		///<summary>
		/// Start Time
		/// <para>Name: StartTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "startTime")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? StartTime { get; set; }

		///<summary>
		/// End Time
		/// <para>Name: EndTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "endTime")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? EndTime { get; set; }

		///<summary>
		/// Cron Expression
		/// <para>Name: CronExpression</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "cronExpression")]
		[Updateable(false), Creatable(false)]
		public string CronExpression { get; set; }

		///<summary>
		/// Java Time Zone Id
		/// <para>Name: TimeZoneSidKey</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "timeZoneSidKey")]
		[Updateable(false), Creatable(false)]
		public string TimeZoneSidKey { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: OwnerId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "ownerId")]
		[Updateable(false), Creatable(false)]
		public string OwnerId { get; set; }

		///<summary>
		/// Last Modified By ID
		/// <para>Name: LastModifiedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedById")]
		[Updateable(false), Creatable(false)]
		public string LastModifiedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: LastModifiedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedBy")]
		[Updateable(false), Creatable(false)]
		public SfUser LastModifiedBy { get; set; }

		///<summary>
		/// Created By ID
		/// <para>Name: CreatedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdById")]
		[Updateable(false), Creatable(false)]
		public string CreatedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: CreatedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "createdBy")]
		[Updateable(false), Creatable(false)]
		public SfUser CreatedBy { get; set; }

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
		/// Job Fired Count
		/// <para>Name: TimesTriggered</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "timesTriggered")]
		[Updateable(false), Creatable(false)]
		public int? TimesTriggered { get; set; }

	}
}
