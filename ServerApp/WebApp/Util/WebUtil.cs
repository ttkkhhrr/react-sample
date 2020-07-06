using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace WebApp
{
    /// <summary>
    /// 汎用的な処理の内、Web側のみに存在するライブラリに関連したものを保持したクラス。
    /// </summary>
    public static class WebUtil
    {
        /// <summary>
        /// Json文字列の結果を返す。（SerializeにJson.NETを使用）
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static IActionResult JsonString(object data)
        {
            return new ContentResult
            {
                ContentType = "application/json",
                Content = JsonConvert.SerializeObject(data)
            };
        }

        /// <summary>
        /// Json文字列の結果を返す。（SerializeにJson.NETを使用）
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static ActionResult JsonContent(object data)
        {
            return new ContentResult
            {
                Content = JsonConvert.SerializeObject(data)
            };
        }


        ///// <summary>
        ///// CSRF対策用のトークンを作成する。
        ///// </summary>
        ///// <returns></returns>
        //public static string GetCsrfToken()
        //{
        //    string cookieToken, formToken;
        //    AntiForgery.GetTokens(null, out cookieToken, out formToken);
        //    return cookieToken + ":" + formToken;
        //}


    }
}
