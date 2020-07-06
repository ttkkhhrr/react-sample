using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DB.Model
{
    public class T_EventActualDetail
    {
        /// <summary>
        /// 行事実績明細番号
        /// </summary>
        public int? EventActualDetailNo { get; set; }

        /// <summary>
        /// 行事実績番号
        /// </summary>
        public int? EventActualNo { get; set; }

        /// <summary>
        /// 役員番号
        /// </summary>
        public int? OfficerNo { get; set; }

        /// <summary>
        /// eValueのスケジュールテーブルのキー
        /// </summary>
        public string ScheduleId { get; set; }

        /// <summary>
        /// 金額
        /// </summary>
        public int? Amount { get; set; }

        /// <summary>
        /// 事業コード番号
        /// </summary>
        public int? BusinessCodeNo { get; set; }

        /// <summary>
        /// 旅費備考
        /// </summary>
        public string ExpenseRemarks { get; set; }

        /// <summary>
        /// 旅費確認フラグ
        /// </summary>
        public int ConfirmExpenseFlag { get; set; }

        /// <summary>
        /// 当月処理対象フラグ
        /// </summary>
        public int PaymentTargetFlag { get; set; }

        /// <summary>
        /// 締済フラグ
        /// </summary>
        public int ClosingFlag { get; set; }

        /// <summary>
        /// 締年月
        /// </summary>
        public DateTime? ClosingYearMonth { get; set; }

        /// <summary>
        /// 修正済みフラグ
        /// </summary>
        public int? ModifiedFlag { get; set; }

        /// <summary>
        /// 作成者のユーザー番号
        /// </summary>
        public int? CreateBy { get; set; }

        /// <summary>
        /// 作成日
        /// </summary>
        public DateTime CreateDateTime { get; set; }

        /// <summary>
        /// 更新者のユーザー番号
        /// </summary>
        public int? UpdateBy { get; set; }

        /// <summary>
        /// 更新日
        /// </summary>
        public DateTime UpdateDateTime { get; set; }

    }
}
