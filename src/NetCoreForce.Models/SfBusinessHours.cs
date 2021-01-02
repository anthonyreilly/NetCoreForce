// SF API version v50.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Business Hours
	///<para>SObject Name: BusinessHours</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfBusinessHours : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "BusinessHours"; }
		}

		///<summary>
		/// Business Hours ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Business Hours Name
		/// <para>Name: Name</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		///<summary>
		/// Active
		/// <para>Name: IsActive</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isActive")]
		public bool? IsActive { get; set; }

		///<summary>
		/// Default Business Hours
		/// <para>Name: IsDefault</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "isDefault")]
		public bool? IsDefault { get; set; }

		///<summary>
		/// Sunday Start
		/// <para>Name: SundayStartTime</para>
		/// <para>SF Type: time</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sundayStartTime")]
		public string SundayStartTime { get; set; }

		///<summary>
		/// Sunday End
		/// <para>Name: SundayEndTime</para>
		/// <para>SF Type: time</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "sundayEndTime")]
		public string SundayEndTime { get; set; }

		///<summary>
		/// Monday Start
		/// <para>Name: MondayStartTime</para>
		/// <para>SF Type: time</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mondayStartTime")]
		public string MondayStartTime { get; set; }

		///<summary>
		/// Monday End
		/// <para>Name: MondayEndTime</para>
		/// <para>SF Type: time</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "mondayEndTime")]
		public string MondayEndTime { get; set; }

		///<summary>
		/// Tuesday Start
		/// <para>Name: TuesdayStartTime</para>
		/// <para>SF Type: time</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "tuesdayStartTime")]
		public string TuesdayStartTime { get; set; }

		///<summary>
		/// Tuesday End
		/// <para>Name: TuesdayEndTime</para>
		/// <para>SF Type: time</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "tuesdayEndTime")]
		public string TuesdayEndTime { get; set; }

		///<summary>
		/// Wednesday Start
		/// <para>Name: WednesdayStartTime</para>
		/// <para>SF Type: time</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "wednesdayStartTime")]
		public string WednesdayStartTime { get; set; }

		///<summary>
		/// Wednesday End
		/// <para>Name: WednesdayEndTime</para>
		/// <para>SF Type: time</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "wednesdayEndTime")]
		public string WednesdayEndTime { get; set; }

		///<summary>
		/// Thursday Start
		/// <para>Name: ThursdayStartTime</para>
		/// <para>SF Type: time</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "thursdayStartTime")]
		public string ThursdayStartTime { get; set; }

		///<summary>
		/// Thursday End
		/// <para>Name: ThursdayEndTime</para>
		/// <para>SF Type: time</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "thursdayEndTime")]
		public string ThursdayEndTime { get; set; }

		///<summary>
		/// Friday Start
		/// <para>Name: FridayStartTime</para>
		/// <para>SF Type: time</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fridayStartTime")]
		public string FridayStartTime { get; set; }

		///<summary>
		/// Friday End
		/// <para>Name: FridayEndTime</para>
		/// <para>SF Type: time</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "fridayEndTime")]
		public string FridayEndTime { get; set; }

		///<summary>
		/// Saturday Start
		/// <para>Name: SaturdayStartTime</para>
		/// <para>SF Type: time</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "saturdayStartTime")]
		public string SaturdayStartTime { get; set; }

		///<summary>
		/// Saturday End
		/// <para>Name: SaturdayEndTime</para>
		/// <para>SF Type: time</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "saturdayEndTime")]
		public string SaturdayEndTime { get; set; }

		///<summary>
		/// Time Zone
		/// <para>Name: TimeZoneSidKey</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "timeZoneSidKey")]
		public string TimeZoneSidKey { get; set; }

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
		/// Last Viewed Date
		/// <para>Name: LastViewedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "lastViewedDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? LastViewedDate { get; set; }

	}
}
