using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DB.Model
{
	/// <summary>
	/// T_ScheduleDetailテーブルのメンバーを保持するモデル。
	/// </summary>
	public class T_ScheduleDetail
	{
		public int? ScheduleDetailNo { get; set; }
		public int? ScheduleNo { get; set; }
		public int? OfficerNo { get; set; }
		public string ScheduleId { get; set; }
		public int? Amount { get; set; }
		public int? BusinessCodeNo { get; set; }
		public int? ModifiedFlag { get; set; }

		public int? CreateBy { get; set; }
		public DateTime? CreateDateTime { get; set; }
		public int? UpdateBy { get; set; }
		public DateTime? UpdateDateTime { get; set; }
	}
}
