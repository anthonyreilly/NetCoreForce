// SF API version v48.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// List View Chart Instance
	///<para>SObject Name: ListViewChartInstance</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfListViewChartInstance : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "ListViewChartInstance"; }
		}

		///<summary>
		/// List View Chart Instance ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// ListView Chart Instance ID
		/// <para>Name: ExternalId</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "externalId")]
		[Updateable(false), Createable(false)]
		public string ExternalId { get; set; }

		///<summary>
		/// List View Chart ID
		/// <para>Name: ListViewChartId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "listViewChartId")]
		[Updateable(false), Createable(false)]
		public string ListViewChartId { get; set; }

		///<summary>
		/// ReferenceTo: ListViewChart
		/// <para>RelationshipName: ListViewChart</para>
		///</summary>
		[JsonProperty(PropertyName = "listViewChart")]
		[Updateable(false), Createable(false)]
		public SfListViewChart ListViewChart { get; set; }

		///<summary>
		/// Label
		/// <para>Name: Label</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "label")]
		[Updateable(false), Createable(false)]
		public string Label { get; set; }

		///<summary>
		/// API Name
		/// <para>Name: DeveloperName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "developerName")]
		[Updateable(false), Createable(false)]
		public string DeveloperName { get; set; }

		///<summary>
		/// Entity
		/// <para>Name: SourceEntity</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "sourceEntity")]
		[Updateable(false), Createable(false)]
		public string SourceEntity { get; set; }

		///<summary>
		/// List View ID
		/// <para>Name: ListViewContextId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "listViewContextId")]
		[Updateable(false), Createable(false)]
		public string ListViewContextId { get; set; }

		///<summary>
		/// ReferenceTo: ListView
		/// <para>RelationshipName: ListViewContext</para>
		///</summary>
		[JsonProperty(PropertyName = "listViewContext")]
		[Updateable(false), Createable(false)]
		public SfListView ListViewContext { get; set; }

		///<summary>
		/// TODO, use alias
		/// <para>Name: ChartType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "chartType")]
		[Updateable(false), Createable(false)]
		public string ChartType { get; set; }

		///<summary>
		/// Last Viewed
		/// <para>Name: IsLastViewed</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isLastViewed")]
		[Updateable(false), Createable(false)]
		public bool? IsLastViewed { get; set; }

		///<summary>
		/// SOQL Query for Chart Data
		/// <para>Name: DataQuery</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dataQuery")]
		[Updateable(false), Createable(false)]
		public string DataQuery { get; set; }

		///<summary>
		/// SOQL Query for Desktop Chart Data without S1 User Filters
		/// <para>Name: DataQueryWithoutUserFilters</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dataQueryWithoutUserFilters")]
		[Updateable(false), Createable(false)]
		public string DataQueryWithoutUserFilters { get; set; }

		///<summary>
		/// Editable
		/// <para>Name: IsEditable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isEditable")]
		[Updateable(false), Createable(false)]
		public bool? IsEditable { get; set; }

		///<summary>
		/// Deletable
		/// <para>Name: IsDeletable</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDeletable")]
		[Updateable(false), Createable(false)]
		public bool? IsDeletable { get; set; }

		///<summary>
		/// Grouping Field
		/// <para>Name: GroupingField</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "groupingField")]
		[Updateable(false), Createable(false)]
		public string GroupingField { get; set; }

		///<summary>
		/// Aggregate Field
		/// <para>Name: AggregateField</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "aggregateField")]
		[Updateable(false), Createable(false)]
		public string AggregateField { get; set; }

		///<summary>
		/// Aggregate Type
		/// <para>Name: AggregateType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "aggregateType")]
		[Updateable(false), Createable(false)]
		public string AggregateType { get; set; }

	}
}
