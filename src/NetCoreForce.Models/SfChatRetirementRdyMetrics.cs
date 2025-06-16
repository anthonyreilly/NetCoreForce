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
	/// Chat Retirement Readiness Metrics
	///<para>SObject Name: ChatRetirementRdyMetrics</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfChatRetirementRdyMetrics : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ChatRetirementRdyMetrics"; }
		}

		///<summary>
		/// ChatRetirementReadinessMetrics ID
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
		/// System Modstamp
		/// <para>Name: SystemModstamp</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "systemModstamp")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? SystemModstamp { get; set; }

		///<summary>
		/// Active Chat Deployments
		/// <para>Name: ActiveChatDeployments</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "activeChatDeployments")]
		[Updateable(false), Createable(false)]
		public int? ActiveChatDeployments { get; set; }

		///<summary>
		/// Active Embedded Service Deployments
		/// <para>Name: EmbeddedServiceDeployments</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "embeddedServiceDeployments")]
		[Updateable(false), Createable(false)]
		public int? EmbeddedServiceDeployments { get; set; }

		///<summary>
		/// Active Visualforce Chat Deployments
		/// <para>Name: ActiveVfDeployments</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "activeVfDeployments")]
		[Updateable(false), Createable(false)]
		public int? ActiveVfDeployments { get; set; }

		///<summary>
		/// Active Chat Buttons
		/// <para>Name: ActiveChatButtons</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "activeChatButtons")]
		[Updateable(false), Createable(false)]
		public int? ActiveChatButtons { get; set; }

		///<summary>
		/// Active Chat Invitations
		/// <para>Name: ActiveChatInvitations</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "activeChatInvitations")]
		[Updateable(false), Createable(false)]
		public int? ActiveChatInvitations { get; set; }

		///<summary>
		/// Active Skills-Based Routing Buttons
		/// <para>Name: ActiveSbrButtons</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "activeSbrButtons")]
		[Updateable(false), Createable(false)]
		public int? ActiveSbrButtons { get; set; }

		///<summary>
		/// Active Queue-Based Routing Buttons
		/// <para>Name: ActiveQbrButtons</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "activeQbrButtons")]
		[Updateable(false), Createable(false)]
		public int? ActiveQbrButtons { get; set; }

		///<summary>
		/// Queues
		/// <para>Name: Queues</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "queues")]
		[Updateable(false), Createable(false)]
		public int? Queues { get; set; }

		///<summary>
		/// Skills
		/// <para>Name: Skills</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "skills")]
		[Updateable(false), Createable(false)]
		public int? Skills { get; set; }

		///<summary>
		/// Skill Based Routing Rules
		/// <para>Name: SkillBasedRoutingRules</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "skillBasedRoutingRules")]
		[Updateable(false), Createable(false)]
		public int? SkillBasedRoutingRules { get; set; }

		///<summary>
		/// Custom Labels
		/// <para>Name: CustomLabels</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "customLabels")]
		[Updateable(false), Createable(false)]
		public int? CustomLabels { get; set; }

		///<summary>
		/// Custom Embedded Service Web Components
		/// <para>Name: CustomWebComponents</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "customWebComponents")]
		[Updateable(false), Createable(false)]
		public int? CustomWebComponents { get; set; }

		///<summary>
		/// Active Chatbots
		/// <para>Name: ChatBots</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "chatBots")]
		[Updateable(false), Createable(false)]
		public int? ChatBots { get; set; }

		///<summary>
		/// IP Blocking Rules
		/// <para>Name: IpBlockingRules</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "ipBlockingRules")]
		[Updateable(false), Createable(false)]
		public int? IpBlockingRules { get; set; }

		///<summary>
		/// Number of Chat Apex Classes
		/// <para>Name: ChatApexClasses</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "chatApexClasses")]
		[Updateable(false), Createable(false)]
		public int? ChatApexClasses { get; set; }

		///<summary>
		/// Chat Apex Classes
		/// <para>Name: ChatApexClassList</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "chatApexClassList")]
		[Updateable(false), Createable(false)]
		public string ChatApexClassList { get; set; }

		///<summary>
		/// Chat Objects in Apex Classes
		/// <para>Name: ChatObjectsInApexList</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "chatObjectsInApexList")]
		[Updateable(false), Createable(false)]
		public string ChatObjectsInApexList { get; set; }

		///<summary>
		/// Number of Chat Flows
		/// <para>Name: ChatFlowCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "chatFlowCount")]
		[Updateable(false), Createable(false)]
		public int? ChatFlowCount { get; set; }

		///<summary>
		/// Chat Flows
		/// <para>Name: ChatFlowList</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "chatFlowList")]
		[Updateable(false), Createable(false)]
		public string ChatFlowList { get; set; }

		///<summary>
		/// Chat Objects in Flows
		/// <para>Name: ChatObjectsInFlowList</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "chatObjectsInFlowList")]
		[Updateable(false), Createable(false)]
		public string ChatObjectsInFlowList { get; set; }

		///<summary>
		/// Number of Report Types with Primary Chat Objects
		/// <para>Name: PrimaryChatReportTypes</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "primaryChatReportTypes")]
		[Updateable(false), Createable(false)]
		public int? PrimaryChatReportTypes { get; set; }

		///<summary>
		/// Report Types with Primary Chat Objects
		/// <para>Name: PrimaryChatReportTypeList</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "primaryChatReportTypeList")]
		[Updateable(false), Createable(false)]
		public string PrimaryChatReportTypeList { get; set; }

		///<summary>
		/// Reports with Primary Chat Objects
		/// <para>Name: PrimaryChatReportList</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "primaryChatReportList")]
		[Updateable(false), Createable(false)]
		public string PrimaryChatReportList { get; set; }

		///<summary>
		/// Number of Report Types with Secondary Chat Objects
		/// <para>Name: SecondaryChatReportTypes</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "secondaryChatReportTypes")]
		[Updateable(false), Createable(false)]
		public int? SecondaryChatReportTypes { get; set; }

		///<summary>
		/// Report Types with Secondary Chat Objects
		/// <para>Name: SecondaryChatReportTypeList</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "secondaryChatReportTypeList")]
		[Updateable(false), Createable(false)]
		public string SecondaryChatReportTypeList { get; set; }

		///<summary>
		/// Reports with Secondary Chat Objects
		/// <para>Name: SecondaryChatReportList</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "secondaryChatReportList")]
		[Updateable(false), Createable(false)]
		public string SecondaryChatReportList { get; set; }

		///<summary>
		/// Unique Chat Objects in Reports
		/// <para>Name: UniqueChatObjectsInReport</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "uniqueChatObjectsInReport")]
		[Updateable(false), Createable(false)]
		public string UniqueChatObjectsInReport { get; set; }

	}
}
