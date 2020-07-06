using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DB.Model
{
    public class M_ResponsibleOfficer
    {
        public int DivisionNo { get; set; }
        public int OfficerNo { get; set; }
        public int? CreateBy { get; set; }
        public DateTime CreateDatetime { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime UpdateDateTime { get; set; }

    }

}
