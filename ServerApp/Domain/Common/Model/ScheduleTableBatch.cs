using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Domain.Util;

namespace Domain.DB.Model
{
    /// <summary>
    /// eValueのテーブル（ScheduleTable）に対応するモデル
    /// </summary>
    public class ScheduleTableBatch : ScheduleTable
    {
        //Description出力用
        public string OutputNote { get { return Note.IsNullOrEmpty() ? "" : new Regex(ConstString.uid).Replace(Note.Replace("\r\n", " ").Replace("\n", " ").Replace(ConstString.googleCal, " "), " ") ; } }
    }
}
