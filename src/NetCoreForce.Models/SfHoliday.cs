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
	/// Holiday
	///<para>SObject Name: Holiday</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfHoliday : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "Holiday"; }
		}

		///<summary>
		/// Holiday ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// Holiday Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		///<summary>
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

		///<summary>
		/// All Day
		/// <para>Name: IsAllDay</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isAllDay")]
		public bool? IsAllDay { get; set; }

		///<summary>
		/// Holiday Date
		/// <para>Name: ActivityDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "activityDate")]
		public DateTime? ActivityDate { get; set; }

		///<summary>
		/// Start Time In Minutes From Midnight
		/// <para>Name: StartTimeInMinutes</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "startTimeInMinutes")]
		public int? StartTimeInMinutes { get; set; }

		///<summary>
		/// End Time In Minutes From Midnight
		/// <para>Name: EndTimeInMinutes</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "endTimeInMinutes")]
		public int? EndTimeInMinutes { get; set; }

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
		/// Last Modified Date
		/// <para>Name: LastModifiedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "lastModifiedDate")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? LastModifiedDate { get; set; }

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
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Creatable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

		///<summary>
		/// Recurring Holiday
		/// <para>Name: IsRecurrence</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isRecurrence")]
		public bool? IsRecurrence { get; set; }

		///<summary>
		/// Recurrence Start
		/// <para>Name: RecurrenceStartDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recurrenceStartDate")]
		public DateTime? RecurrenceStartDate { get; set; }

		///<summary>
		/// Recurrence End
		/// <para>Name: RecurrenceEndDateOnly</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recurrenceEndDateOnly")]
		public DateTime? RecurrenceEndDateOnly { get; set; }

		///<summary>
		/// Recurrence Type
		/// <para>Name: RecurrenceType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recurrenceType")]
		public string RecurrenceType { get; set; }

		///<summary>
		/// Recurrence Interval
		/// <para>Name: RecurrenceInterval</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recurrenceInterval")]
		public int? RecurrenceInterval { get; set; }

		///<summary>
		/// Recurrence Day of Week Mask
		/// <para>Name: RecurrenceDayOfWeekMask</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recurrenceDayOfWeekMask")]
		public int? RecurrenceDayOfWeekMask { get; set; }

		///<summary>
		/// Recurrence Day of Month
		/// <para>Name: RecurrenceDayOfMonth</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recurrenceDayOfMonth")]
		public int? RecurrenceDayOfMonth { get; set; }

		///<summary>
		/// Recurrence Instance
		/// <para>Name: RecurrenceInstance</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recurrenceInstance")]
		public string RecurrenceInstance { get; set; }

		///<summary>
		/// Recurrence Month of Year
		/// <para>Name: RecurrenceMonthOfYear</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recurrenceMonthOfYear")]
		public string RecurrenceMonthOfYear { get; set; }

	}
}
