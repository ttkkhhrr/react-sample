using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Util
{
    /// <summary>
    /// シリアライズ・デシリアライズ時の定数を保持するクラス
    /// </summary>
    public class ConstString
    {
        // note・DESCRIPTIONの文頭　付与・除去用定数
        public const string googleCal = "Googleカレンダー　";

        // note・DESCRIPTIONの末尾　UID付与・除去用定数
        public const string uid = @"\[UID:(.*)\]";
    }

    /// <summary>
    /// 行事予定表および日誌の項目を、場所名でソートする際に使用
    /// </summary>
    public class ConstSpecificPlaces
    {
        public const string tokyoMedOrg = "都医";
        public const string japanMedOrg = "日医";
        public const string metropolitanCityHall = "都庁";
    }
}
