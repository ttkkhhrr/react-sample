using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;
using Domain.Util;

namespace Domain.Model
{
    /// <summary>
    /// ログインユーザに関する情報を保持する。
    /// </summary>
    [Serializable]
    public class ApplicationContext
    {
        public const string InSessionKey = "APPLICATION_INFO_IN_SESSION";

        public ApplicationContext(ApplicationInfo applicationInfo)
        {
            this.applicationInfo = applicationInfo;
        }

        [JsonIgnore]
        public ApplicationInfo applicationInfo { get; set; }

        /// <summary>金額0円対象の会議名 </summary>
        public List<string> MeetingPlaceListForAmountZero
        {
            get
            {
                return applicationInfo.GeneralList.Where(p => p.CategoryId == ConstKubun.AmountOccurred).Select(p => p.GeneralName).ToList();
            }
        }

        /// <summary>参与と顧問のGeneralNo </summary>
        public List<int?> ParticipationOrAdvisor
        {
            get
            {
                return applicationInfo.GeneralList.Where(p => p.GeneralNo == ConstHonorificsNo.Participation || p.GeneralNo == ConstHonorificsNo.Advisor).Select(p => p.GeneralNo).ToList();
            }
        }

    }

}