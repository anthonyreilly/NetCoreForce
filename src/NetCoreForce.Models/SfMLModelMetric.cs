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
	/// ML Model Metric
	///<para>SObject Name: MLModelMetric</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfMLModelMetric : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "MLModelMetric"; }
		}

		///<summary>
		/// ML Model Metric ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

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
		/// Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>AutoNumber field</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		[Updateable(false), Createable(false)]
		public string Name { get; set; }

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
		/// ML Model ID
		/// <para>Name: ModelId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "modelId")]
		[Updateable(false), Createable(false)]
		public string ModelId { get; set; }

		///<summary>
		/// ReferenceTo: MLModel
		/// <para>RelationshipName: Model</para>
		///</summary>
		[JsonProperty(PropertyName = "model")]
		[Updateable(false), Createable(false)]
		public SfMLModel Model { get; set; }

		///<summary>
		/// Metric Type
		/// <para>Name: MetricType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "metricType")]
		[Updateable(false), Createable(false)]
		public string MetricType { get; set; }

		///<summary>
		/// Basic Metric Value
		/// <para>Name: BasicMetricValue</para>
		/// <para>SF Type: double</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "basicMetricValue")]
		[Updateable(false), Createable(false)]
		public double? BasicMetricValue { get; set; }

		///<summary>
		/// Row Count
		/// <para>Name: RowCount</para>
		/// <para>SF Type: int</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "rowCount")]
		[Updateable(false), Createable(false)]
		public int? RowCount { get; set; }

		///<summary>
		/// Start Time
		/// <para>Name: StartTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "startTime")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? StartTime { get; set; }

		///<summary>
		/// End Time
		/// <para>Name: EndTime</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "endTime")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? EndTime { get; set; }

		///<summary>
		/// Metric Span
		/// <para>Name: Span</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "span")]
		[Updateable(false), Createable(false)]
		public string Span { get; set; }

		///<summary>
		/// Graph Type
		/// <para>Name: GraphType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "graphType")]
		[Updateable(false), Createable(false)]
		public string GraphType { get; set; }

		///<summary>
		/// Dataset Type
		/// <para>Name: DataSetType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "dataSetType")]
		[Updateable(false), Createable(false)]
		public string DataSetType { get; set; }

		///<summary>
		/// Complex Metric Value
		/// <para>Name: ComplexMetricValue</para>
		/// <para>SF Type: textarea</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "complexMetricValue")]
		[Updateable(false), Createable(false)]
		public string ComplexMetricValue { get; set; }

	}
}
