using Domain.DB.Model;
using Domain.Model;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Domain.Service
{
    /// <summary>
    /// 区分値取得用のサービス。
    /// </summary>
    public class KubunService
    {
         [Dependency]
        public KubunRepository repository { get; set; }

        /// <summary>
        /// 区分値取得処理を行う。
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public async Task<List<KubunSearchResult>> GetKubunList(string categoryId)
        {
            var result = await repository.GetKubunList(categoryId);
            return result;
        }

        /// <summary>
        /// 課の一覧取得処理を行う。
        /// </summary>
        /// <returns></returns>
        public async Task<List<KubunSearchResult>> GetDivisionList()
        {
            var result = await repository.GetDivisionList();
            return result;
        }


        /// <summary>
        /// 事業コードの一覧取得処理を行う。
        /// </summary>
        /// <returns></returns>
        public async Task<List<KubunSearchResult>> GetBusinessCodeList()
        {
            var result = await repository.GetBusinessCodeList();
            return result;
        }


        /// <summary>
        /// 理事会番号の一覧取得処理を行う。
        /// </summary>
        /// <returns></returns>
        public async Task<List<KubunSearchResult>> GetMeetingNoList(DateTime? baseDate = null)
        {
            DateTime today = baseDate == null ? DateTime.Today : baseDate.Value;
            DateTime from = today.AddMonths(-1).BeginOfMonth();
            DateTime to = today.AddMonths(3).EndOfMonth();

            var list = await repository.GetMeetingNoList(from, to);

            var result = list.Select(m => new KubunSearchResult()
            {
                Value = m.OfficerMeetingNo.ToString(),
                Text = $"{m.OfficerMeetingDate.ToDefaultYYYYMMDD()} (行事予定期間：{m.TargetStartDate.ToDefaultYYYYMMDD()}～{m.TargetEndDate.ToDefaultYYYYMMDD()})" 
            }).ToList();

            return result;
        }


        /// <summary>
        /// 理事会番号の一覧取得処理を行う。
        /// </summary>
        /// <returns></returns>
        public async Task<int?> GetCurrentMeetingNo(DateTime? baseDate = null)
        {
            var meetingNo = await repository.GetCurrentMeetingNo(baseDate ?? DateTime.Today);
            return meetingNo;
        }

    }

}
