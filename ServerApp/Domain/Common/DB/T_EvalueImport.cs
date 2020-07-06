using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DB.Model
{
	/// <summary>
	/// T_EvalueImportテーブルのメンバーを保持するモデル。
	/// </summary>
	public class T_EvalueImport
	{
		public string ScheduleId { get; set; }
		public DateTime? MeetingDate { get; set; }
		public DateTime? StartTime { get; set; }
		public DateTime? EndTime { get; set; }


		public string MeetingName { get; set; }
		public string MeetingPlace { get; set; }


		public int? OfficerNo { get; set; }
		public string OwnerId { get; set; }

		public string OfficerName { get; set; }
		public int? ScheduleNo { get; set; }

		public string EvalueLastUpdateUserName { get; set; }
		public DateTime? EvalueLastUpdateDateTime { get; set; }
		public int? Amount { get; set; }


		public int? CreateBy { get; set; }
		public DateTime? CreateDateTime { get; set; }
		public int? UpdateBy { get; set; }
		public DateTime? UpdateDateTime { get; set; }
		public int? DeleteFlag { get; set; }
	}
}
