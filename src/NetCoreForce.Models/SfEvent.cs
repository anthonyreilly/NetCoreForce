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
	/// Event
	///<para>SObject Name: Event</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfEvent : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "Event"; }
		}

		///<summary>
		/// Activity Extension ID
		/// <para>Name: ActivityExtensionId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "activityExtensionId")]
		[Updateable(false), Createable(false)]
		public string ActivityExtensionId { get; set; }

		///<summary>
		/// ReferenceTo: ActivityExtension
		/// <para>RelationshipName: ActivityExtension</para>
		///</summary>
		[JsonProperty(PropertyName = "activityExtension")]
		[Updateable(false), Createable(false)]
		public SfActivityExtension ActivityExtension { get; set; }

		///<summary>
		/// Activity ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Name ID
		/// <para>Name: WhoId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "whoId")]
		public string WhoId { get; set; }

		///<summary>
		/// Related To ID
		/// <para>Name: WhatId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "whatId")]
		public string WhatId { get; set; }

		///<summary>
		/// Subject
		/// <para>Name: Subject</para>
		/// <para>SF Type: combobox</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "subject")]
		public string Subject { get; set; }

		///<summary>
		/// Location
		/// <para>Name: Location</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "location")]
		public string Location { get; set; }

		///<summary>
		/// All-Day Event
		/// <para>Name: IsAllDayEvent</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isAllDayEvent")]
		public bool? IsAllDayEvent { get; set; }

		///<summary>
		/// Due Date Time
		/// <para>Name: ActivityDateTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "activityDateTime")]
		public DateTimeOffset? ActivityDateTime { get; set; }

		///<summary>
		/// Due Date Only
		/// <para>Name: ActivityDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "activityDate")]
		public DateTime? ActivityDate { get; set; }

		///<summary>
		/// Duration
		/// <para>Name: DurationInMinutes</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "durationInMinutes")]
		public int? DurationInMinutes { get; set; }

		///<summary>
		/// Start Date Time
		/// <para>Name: StartDateTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "startDateTime")]
		public DateTimeOffset? StartDateTime { get; set; }

		///<summary>
		/// End Date Time
		/// <para>Name: EndDateTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "endDateTime")]
		public DateTimeOffset? EndDateTime { get; set; }

		///<summary>
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

		///<summary>
		/// Account ID
		/// <para>Name: AccountId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "accountId")]
		[Updateable(false), Createable(false)]
		public string AccountId { get; set; }

		///<summary>
		/// ReferenceTo: Account
		/// <para>RelationshipName: Account</para>
		///</summary>
		[JsonProperty(PropertyName = "account")]
		[Updateable(false), Createable(false)]
		public SfAccount Account { get; set; }

		///<summary>
		/// Assigned To ID
		/// <para>Name: OwnerId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "ownerId")]
		public string OwnerId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: Owner</para>
		///</summary>
		[JsonProperty(PropertyName = "owner")]
		[Updateable(false), Createable(false)]
		public SfUser Owner { get; set; }

		///<summary>
		/// Private
		/// <para>Name: IsPrivate</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isPrivate")]
		public bool? IsPrivate { get; set; }

		///<summary>
		/// Show Time As
		/// <para>Name: ShowAs</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "showAs")]
		public string ShowAs { get; set; }

		///<summary>
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Createable(false)]
		public bool? IsDeleted { get; set; }

		///<summary>
		/// Is Child
		/// <para>Name: IsChild</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isChild")]
		[Updateable(false), Createable(false)]
		public bool? IsChild { get; set; }

		///<summary>
		/// Is Group Event
		/// <para>Name: IsGroupEvent</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isGroupEvent")]
		[Updateable(false), Createable(false)]
		public bool? IsGroupEvent { get; set; }

		///<summary>
		/// Group Event Type
		/// <para>Name: GroupEventType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "groupEventType")]
		[Updateable(false), Createable(false)]
		public string GroupEventType { get; set; }

		///<summary>
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

		///<summary>
		/// Created By ID
		/// <para>Name: CreatedById</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdById")]
		[Updateable(false), Createable(false)]
		public string CreatedById { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: CreatedBy</para>
		///</summary>
		[JsonProperty(PropertyName = "createdBy")]
		[Updateable(false), Createable(false)]
		public SfUser CreatedBy { get; set; }

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
		/// Archived
		/// <para>Name: IsArchived</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isArchived")]
		[Updateable(false), Createable(false)]
		public bool? IsArchived { get; set; }

		///<summary>
		/// Recurrence Activity ID
		/// <para>Name: RecurrenceActivityId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recurrenceActivityId")]
		[Updateable(false), Createable(false)]
		public string RecurrenceActivityId { get; set; }

		///<summary>
		/// Create Recurring Series of Events
		/// <para>Name: IsRecurrence</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isRecurrence")]
		[Updateable(false), Createable(true)]
		public bool? IsRecurrence { get; set; }

		///<summary>
		/// Recurrence Start
		/// <para>Name: RecurrenceStartDateTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recurrenceStartDateTime")]
		public DateTimeOffset? RecurrenceStartDateTime { get; set; }

		///<summary>
		/// Recurrence End
		/// <para>Name: RecurrenceEndDateOnly</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recurrenceEndDateOnly")]
		public DateTime? RecurrenceEndDateOnly { get; set; }

		///<summary>
		/// Recurrence Time Zone
		/// <para>Name: RecurrenceTimeZoneSidKey</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recurrenceTimeZoneSidKey")]
		public string RecurrenceTimeZoneSidKey { get; set; }

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

		///<summary>
		/// Reminder Date/Time
		/// <para>Name: ReminderDateTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "reminderDateTime")]
		public DateTimeOffset? ReminderDateTime { get; set; }

		///<summary>
		/// Reminder Set
		/// <para>Name: IsReminderSet</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isReminderSet")]
		public bool? IsReminderSet { get; set; }

		///<summary>
		/// Event Subtype
		/// <para>Name: EventSubtype</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "eventSubtype")]
		[Updateable(false), Createable(true)]
		public string EventSubtype { get; set; }

	}
}
