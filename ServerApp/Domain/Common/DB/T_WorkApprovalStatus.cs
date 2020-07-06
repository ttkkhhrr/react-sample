using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DB.Model
{
	/// <summary>
	/// T_WorkApprovalStatusテーブルのメンバーを保持するモデル。
	/// </summary>
	public class T_WorkApprovalStatus
	{
		public int? WorkApprovalStatusNo { get; set; }
		public int? OfficerMeetingNo { get; set; }
		public int? WorkApprovalDivisionNo { get; set; }

		public int? CreateScheduledEventStatus { get; set; }
		public int? ApproveScheduledEventStatus { get; set; }

		public int? CreateBy { get; set; }
		public DateTime? CreateDateTime { get; set; }
		public int? UpdateBy { get; set; }
		public DateTime? UpdateDateTime { get; set; }
		public int? DeleteFlag { get; set; }
	}
}
