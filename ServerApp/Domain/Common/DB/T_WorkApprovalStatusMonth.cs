using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DB.Model
{
	/// <summary>
	/// T_WorkApprovalStatusMonthテーブルのメンバーを保持するモデル。
	/// </summary>
	public class T_WorkApprovalStatusMonth
	{
		public int? WorkApprovalStatusMonthNo { get; set; }
		public DateTime? TargetYearMonth { get; set; }
		public int? WorkApprovalDivisionNo { get; set; }
		public int? InputEventActualStatus { get; set; }
		public int? ConfirmExpenseStatus { get; set; }

		public int? CreateBy { get; set; }
		public DateTime? CreateDateTime { get; set; }
		public int? UpdateBy { get; set; }
		public DateTime? UpdateDateTime { get; set; }
		public int? DeleteFlag { get; set; }
	}
}
