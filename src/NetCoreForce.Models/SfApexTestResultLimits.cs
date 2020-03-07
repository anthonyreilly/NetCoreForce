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
	/// Apex Test Result Limit
	///<para>SObject Name: ApexTestResultLimits</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfApexTestResultLimits : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ApexTestResultLimits"; }
		}

		///<summary>
		/// ApexTestResultLimits ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Creatable(false)]
		public string Id { get; set; }

		///<summary>
		/// Deleted
		/// <para>Name: IsDeleted</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeleted")]
		[Updateable(false), Creatable(false)]
		public bool? IsDeleted { get; set; }

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
		/// Apex Test Result ID
		/// <para>Name: ApexTestResultId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "apexTestResultId")]
		[Updateable(false), Creatable(true)]
		public string ApexTestResultId { get; set; }

		///<summary>
		/// ReferenceTo: ApexTestResult
		/// <para>RelationshipName: ApexTestResult</para>
		///</summary>
		[JsonProperty(PropertyName = "apexTestResult")]
		[Updateable(false), Creatable(false)]
		public SfApexTestResult ApexTestResult { get; set; }

		///<summary>
		/// Total number of SOQL queries issued
		/// <para>Name: Soql</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "soql")]
		public int? Soql { get; set; }

		///<summary>
		/// Total number of records retrieved by SOQL queries
		/// <para>Name: QueryRows</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "queryRows")]
		public int? QueryRows { get; set; }

		///<summary>
		/// Total number of SOSL queries issued
		/// <para>Name: Sosl</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "sosl")]
		public int? Sosl { get; set; }

		///<summary>
		/// Total number of DML statements issued
		/// <para>Name: Dml</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "dml")]
		public int? Dml { get; set; }

		///<summary>
		/// Total number of records processed as a result of DML statements
		/// <para>Name: DmlRows</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "dmlRows")]
		public int? DmlRows { get; set; }

		///<summary>
		/// Maximum CPU time on the Salesforce servers
		/// <para>Name: Cpu</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "cpu")]
		public int? Cpu { get; set; }

		///<summary>
		/// Total number of callouts
		/// <para>Name: Callouts</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "callouts")]
		public int? Callouts { get; set; }

		///<summary>
		/// Total number of sendEmail methods allowed
		/// <para>Name: Email</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "email")]
		public int? Email { get; set; }

		///<summary>
		/// Total number of async calls
		/// <para>Name: AsyncCalls</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "asyncCalls")]
		public int? AsyncCalls { get; set; }

		///<summary>
		/// Maximum number of push notification method calls allowed per Apex transaction
		/// <para>Name: MobilePush</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "mobilePush")]
		public int? MobilePush { get; set; }

		///<summary>
		/// LimitContext
		/// <para>Name: LimitContext</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "limitContext")]
		public string LimitContext { get; set; }

		///<summary>
		/// LimitExceptions
		/// <para>Name: LimitExceptions</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "limitExceptions")]
		public string LimitExceptions { get; set; }

	}
}
