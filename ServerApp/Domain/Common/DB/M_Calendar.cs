using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DB.Model
{
    /// <summary>
    /// M_Calendarテーブルのメンバーを保持するモデル。
    /// </summary>
    public class M_Calendar
    {
        /// <summary>
        /// カレンダー日付
        /// </summary>
        public DateTime HolidayDate { get; set; }

        /// <summary>
        /// 祝日名
        /// </summary>
        public string HolidayName { get; set; }

        /// <summary>
        /// 作成者（ユーザー番号）
        /// </summary>
        public int CreateBy { get; set; }

        /// <summary>
        /// 作成日
        /// </summary>
        public DateTime CreateDateTime { get; set; }

    }
}
