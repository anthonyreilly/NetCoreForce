// SF API version v64.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Task
	///<para>SObject Name: Task</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfTask : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "Task"; }
		}

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
		/// Due Date Only
		/// <para>Name: ActivityDate</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "activityDate")]
		public DateTime? ActivityDate { get; set; }

		///<summary>
		/// Status
		/// <para>Name: Status</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "status")]
		public string Status { get; set; }

		///<summary>
		/// Priority
		/// <para>Name: Priority</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "priority")]
		public string Priority { get; set; }

		///<summary>
		/// High Priority
		/// <para>Name: IsHighPriority</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isHighPriority")]
		[Updateable(false), Createable(false)]
		public bool? IsHighPriority { get; set; }

		///<summary>
		/// Assigned To ID
		/// <para>Name: OwnerId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "ownerId")]
		public string OwnerId { get; set; }

		///<summary>
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

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
		/// Closed
		/// <para>Name: IsClosed</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isClosed")]
		[Updateable(false), Createable(false)]
		public bool? IsClosed { get; set; }

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
		/// Call Duration
		/// <para>Name: CallDurationInSeconds</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "callDurationInSeconds")]
		public int? CallDurationInSeconds { get; set; }

		///<summary>
		/// Call Type
		/// <para>Name: CallType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "callType")]
		public string CallType { get; set; }

		///<summary>
		/// Call Result
		/// <para>Name: CallDisposition</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "callDisposition")]
		public string CallDisposition { get; set; }

		///<summary>
		/// Call Object Identifier
		/// <para>Name: CallObject</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "callObject")]
		public string CallObject { get; set; }

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
		/// Recurrence Activity ID
		/// <para>Name: RecurrenceActivityId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recurrenceActivityId")]
		[Updateable(false), Createable(false)]
		public string RecurrenceActivityId { get; set; }

		///<summary>
		/// Create Recurring Series of Tasks
		/// <para>Name: IsRecurrence</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isRecurrence")]
		[Updateable(false), Createable(true)]
		public bool? IsRecurrence { get; set; }

		///<summary>
		/// Recurrence Start
		/// <para>Name: RecurrenceStartDateOnly</para>
		/// <para>SF Type: date</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recurrenceStartDateOnly")]
		public DateTime? RecurrenceStartDateOnly { get; set; }

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
		/// Repeat This Task
		/// <para>Name: RecurrenceRegeneratedType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "recurrenceRegeneratedType")]
		public string RecurrenceRegeneratedType { get; set; }

		///<summary>
		/// Task Subtype
		/// <para>Name: TaskSubtype</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "taskSubtype")]
		[Updateable(false), Createable(true)]
		public string TaskSubtype { get; set; }

		///<summary>
		/// Completed Date/Time
		/// <para>Name: CompletedDateTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "completedDateTime")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? CompletedDateTime { get; set; }

	}
}
