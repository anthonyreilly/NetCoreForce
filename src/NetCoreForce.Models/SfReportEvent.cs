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
	/// Report Event
	///<para>SObject Name: ReportEvent</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfReportEvent : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ReportEvent"; }
		}

		///<summary>
		/// Report Event ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

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
		/// Event Identifier
		/// <para>Name: EventIdentifier</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "eventIdentifier")]
		[Updateable(false), Createable(false)]
		public string EventIdentifier { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: UserId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "userId")]
		[Updateable(false), Createable(false)]
		public string UserId { get; set; }

		///<summary>
		/// ReferenceTo: User
		/// <para>RelationshipName: User</para>
		///</summary>
		[JsonProperty(PropertyName = "user")]
		[Updateable(false), Createable(false)]
		public SfUser User { get; set; }

		///<summary>
		/// Username
		/// <para>Name: Username</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "username")]
		[Updateable(false), Createable(false)]
		public string Username { get; set; }

		///<summary>
		/// Event Date
		/// <para>Name: EventDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "eventDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? EventDate { get; set; }

		///<summary>
		/// Related Event Identifier
		/// <para>Name: RelatedEventIdentifier</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "relatedEventIdentifier")]
		[Updateable(false), Createable(false)]
		public string RelatedEventIdentifier { get; set; }

		///<summary>
		/// Login History ID
		/// <para>Name: LoginHistoryId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "loginHistoryId")]
		[Updateable(false), Createable(false)]
		public string LoginHistoryId { get; set; }

		///<summary>
		/// ReferenceTo: LoginHistory
		/// <para>RelationshipName: LoginHistory</para>
		///</summary>
		[JsonProperty(PropertyName = "loginHistory")]
		[Updateable(false), Createable(false)]
		public SfLoginHistory LoginHistory { get; set; }

		///<summary>
		/// Rows Processed
		/// <para>Name: RowsProcessed</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "rowsProcessed")]
		[Updateable(false), Createable(false)]
		public double? RowsProcessed { get; set; }

		///<summary>
		/// Operation
		/// <para>Name: Operation</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "operation")]
		[Updateable(false), Createable(false)]
		public string Operation { get; set; }

		///<summary>
		/// Queried Entities
		/// <para>Name: QueriedEntities</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "queriedEntities")]
		[Updateable(false), Createable(false)]
		public string QueriedEntities { get; set; }

		///<summary>
		/// Transaction Security Policy ID
		/// <para>Name: PolicyId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "policyId")]
		[Updateable(false), Createable(false)]
		public string PolicyId { get; set; }

		///<summary>
		/// ReferenceTo: TransactionSecurityPolicy
		/// <para>RelationshipName: Policy</para>
		///</summary>
		[JsonProperty(PropertyName = "policy")]
		[Updateable(false), Createable(false)]
		public SfTransactionSecurityPolicy Policy { get; set; }

		///<summary>
		/// Policy Outcome
		/// <para>Name: PolicyOutcome</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "policyOutcome")]
		[Updateable(false), Createable(false)]
		public string PolicyOutcome { get; set; }

		///<summary>
		/// Evaluation Time
		/// <para>Name: EvaluationTime</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "evaluationTime")]
		[Updateable(false), Createable(false)]
		public double? EvaluationTime { get; set; }

		///<summary>
		/// Session Key
		/// <para>Name: SessionKey</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sessionKey")]
		[Updateable(false), Createable(false)]
		public string SessionKey { get; set; }

		///<summary>
		/// Login Key
		/// <para>Name: LoginKey</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "loginKey")]
		[Updateable(false), Createable(false)]
		public string LoginKey { get; set; }

		///<summary>
		/// Session Level
		/// <para>Name: SessionLevel</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sessionLevel")]
		[Updateable(false), Createable(false)]
		public string SessionLevel { get; set; }

		///<summary>
		/// Source IP
		/// <para>Name: SourceIp</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sourceIp")]
		[Updateable(false), Createable(false)]
		public string SourceIp { get; set; }

		///<summary>
		/// Dashboard ID
		/// <para>Name: DashboardId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dashboardId")]
		[Updateable(false), Createable(false)]
		public string DashboardId { get; set; }

		///<summary>
		/// ReferenceTo: Dashboard
		/// <para>RelationshipName: Dashboard</para>
		///</summary>
		[JsonProperty(PropertyName = "dashboard")]
		[Updateable(false), Createable(false)]
		public SfDashboard Dashboard { get; set; }

		///<summary>
		/// Dashboard Name
		/// <para>Name: DashboardName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dashboardName")]
		[Updateable(false), Createable(false)]
		public string DashboardName { get; set; }

		///<summary>
		/// Event Source
		/// <para>Name: EventSource</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "eventSource")]
		[Updateable(false), Createable(false)]
		public string EventSource { get; set; }

		///<summary>
		/// Execution Identifier
		/// <para>Name: ExecutionIdentifier</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "executionIdentifier")]
		[Updateable(false), Createable(false)]
		public string ExecutionIdentifier { get; set; }

		///<summary>
		/// Export File Format
		/// <para>Name: ExportFileFormat</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "exportFileFormat")]
		[Updateable(false), Createable(false)]
		public string ExportFileFormat { get; set; }

		///<summary>
		/// Is Scheduled
		/// <para>Name: IsScheduled</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isScheduled")]
		[Updateable(false), Createable(false)]
		public bool? IsScheduled { get; set; }

		///<summary>
		/// Number of Columns
		/// <para>Name: NumberOfColumns</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "numberOfColumns")]
		[Updateable(false), Createable(false)]
		public int? NumberOfColumns { get; set; }

		///<summary>
		/// Name of Columns
		/// <para>Name: ColumnHeaders</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "columnHeaders")]
		[Updateable(false), Createable(false)]
		public string ColumnHeaders { get; set; }

		///<summary>
		/// Name of Grouped Columns
		/// <para>Name: GroupedColumnHeaders</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "groupedColumnHeaders")]
		[Updateable(false), Createable(false)]
		public string GroupedColumnHeaders { get; set; }

		///<summary>
		/// Description
		/// <para>Name: Description</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "description")]
		[Updateable(false), Createable(false)]
		public string Description { get; set; }

		///<summary>
		/// Format
		/// <para>Name: Format</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "format")]
		[Updateable(false), Createable(false)]
		public string Format { get; set; }

		///<summary>
		/// Report ID
		/// <para>Name: ReportId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "reportId")]
		[Updateable(false), Createable(false)]
		public string ReportId { get; set; }

		///<summary>
		/// ReferenceTo: Report
		/// <para>RelationshipName: Report</para>
		///</summary>
		[JsonProperty(PropertyName = "report")]
		[Updateable(false), Createable(false)]
		public SfReport Report { get; set; }

		///<summary>
		/// Records
		/// <para>Name: Records</para>
		/// <para>SF Type: json</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "records")]
		[Updateable(false), Createable(false)]
		public string Records { get; set; }

		///<summary>
		/// Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
		public string Name { get; set; }

		///<summary>
		/// Owner ID
		/// <para>Name: OwnerId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "ownerId")]
		[Updateable(false), Createable(false)]
		public string OwnerId { get; set; }

		///<summary>
		/// Scope
		/// <para>Name: Scope</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "scope")]
		[Updateable(false), Createable(false)]
		public string Scope { get; set; }

		///<summary>
		/// Sequence
		/// <para>Name: Sequence</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sequence")]
		[Updateable(false), Createable(false)]
		public int? Sequence { get; set; }

		///<summary>
		/// Displayed Field Entities
		/// <para>Name: DisplayedFieldEntities</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "displayedFieldEntities")]
		[Updateable(false), Createable(false)]
		public string DisplayedFieldEntities { get; set; }

	}
}
