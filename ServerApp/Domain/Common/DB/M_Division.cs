using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DB.Model
{
    public class M_Division
    {
        public int? DivisionNo { get; set; }
        public string DivisionName { get; set; }
        public string Remarks { get; set; }

        public int? OrderNo { get; set; }

        public DateTime? CreateDatetime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public int DeleteFlag { get; set; }
    }
}
