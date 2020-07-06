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
    public class ScheduleTable
    {
        public Guid ScheduleId { get; set; }
        public string Subject { get; set; }
        public string Location { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Allday { get; set; }
        public int Freebusy { get; set; }
        public int Private { get; set; }
        public int Priority { get; set; }
        public int DoubleBooking { get; set; }
        public int Category { get; set; }
        public string OwnerguId { get; set; }
        public string OwnerName { get; set; }
        public string CreatorGuid { get; set; }
        public string CreatorName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastModifierGuid { get; set; }
        public string LastModifierName { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string Option5 { get; set; }
        public string Option6 { get; set; }
        public string Option7 { get; set; }
        public string Option8 { get; set; }
        public string Option9 { get; set; }
        public string Option10 { get; set; }
        public string Note { get; set; }
        public Guid Mid { get; set; }
        public int? Tmp { get; set; }
        public int? EntryConfirm { get; set; }
        public string MultiCastmeMbers { get; set; }
        public int? SecretaryInvisible { get; set; }
    }
}
