using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DB.Model
{
    public class T_EventActual
    {
        public int? EventActualNo { get; set; }
        public int? ScheduleEventNo { get; set; }
        public DateTime? MeetingDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? DivisionNo { get; set; }
        public string MeetingName { get; set; }
        public string MeetingPlace { get; set; }
        public string Attendee { get; set; }
        /// <summary>修正済みフラグ。親子それぞれで持つ。</summary>
        public int? ModifiedFlag { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDateTime { get; set; }
    }
}
