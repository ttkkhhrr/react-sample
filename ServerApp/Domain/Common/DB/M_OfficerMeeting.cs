using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DB.Model
{
    public class M_OfficerMeeting
    {
        public int? OfficerMeetingNo { get; set; }
        public string ScheduleId { get; set; }
        public DateTime? OfficerMeetingDate { get; set; }
        public DateTime? TargetStartDate { get; set; }
        public DateTime? TargetEndDate { get; set; }
        public DateTime? CreateDateTime { get; set; }
    }

}