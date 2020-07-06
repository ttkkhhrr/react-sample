using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DB.Model
{
    public class M_Officer
    {
        public int? OfficerNo { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        //　敬称（汎用番号を持つ）
        public int? Honorific { get; set; }
        //　表示順
        public int? OrderNo { get; set; }
        public string OwnerId { get; set; }
        public string IcsFileName { get; set; }
        public int? InsideAmountFlag { get; set; }
        public int? CreateBy { get; set; }
        public DateTime CreateDatetime { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int? DeleteFlag { get; set; }
    }

    public class V_Officer : M_Officer
    {
        public string HonorificName { get; set; }
        public string FullName { get; set; }
        public string SearchName { get; set; }
        public string DisplayName { get; set; }
    }

    //参与・顧問を除く、在籍中の役員全員の情報を取得する。
    public class M_Officer_OfficerView : M_Officer
    {
        public string HonorificName { get; set; }
        public string OfficerName { get { return LastNameFormatting(LastName) + HonorificName; } }

        public string LastNameFormatting(string lastName)
        {
            if (lastName.Length == 1)
            {
                return $"{lastName}　";
            }
            return lastName;
        }
    }

    //出勤役員の情報を取得する。
    public class M_Officer_AttendanceView : V_Officer
    {
        public DateTime MeetingDate { get; set; }
        public int AttendeeFlag { get; set; }
    }
}