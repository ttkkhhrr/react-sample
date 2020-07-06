using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DB.Model
{
    public class T_OfficerAttend
    {
        public int? OfficerAttendNo { get; set; }
        public DateTime? OfficerAttendDate { get; set; }
        public int? OfficerNo { get; set; }
        public int? AttendeeFlag { get; set; }
        public int? CreateBy { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime UpdateDateTime { get; set; }

    }
}
