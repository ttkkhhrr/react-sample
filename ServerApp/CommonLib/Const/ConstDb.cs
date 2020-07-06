using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Util
{
	/// <summary>
	/// DBの定数値を保持する。
	/// </summary>
	public class ConstDb
	{
		/// <summary>新DBへの接続文字列 </summary>
		public const string ConnectionStringName_NewDB = "NewDB";

		/// <summary>既存システムのDBへの接続文字列 </summary>
		public const string ConnectionStringName_KizonDB = "KizonDB";

        /// <summary>役員なしのOfficerNo</summary>
        public const int ExceptNoneOfficerNo = 0;

    }

    public class ConstAccountingcodeNo
    {
        /// <summary>公益目的事業の分類番号 </summary>
        public const int KouekiNo = 7;
        /// <summary>収益事業等の分類番号 </summary>
        public const int ShuekiNo = 8;
        /// <summary>法人会計の分類番号 </summary>
        public const int HoujinNo = 9;
    }

    public class ConstHonorificsNo
    {
        /// <summary>会長 </summary>
        public const int Chairman = 1;
        /// <summary>副議長 </summary>
        public const int VicePresident = 2;
        /// <summary>理事 </summary>
        public const int Director = 3;
        /// <summary>監事 </summary>
        public const int Auditor = 4;
        /// <summary>議長 </summary>
        public const int Chair = 5;
        /// <summary>副議長 </summary>
        public const int ViceChair = 6;
        /// <summary>参与 </summary>
        public const int Participation = 28;
        /// <summary>顧問 </summary>
        public const int Advisor = 29;
    }

    /// <summary>
	/// ヒストリーの区分を取得する。
	/// </summary>
	public class ConstHisKbn
    {
        /// <summary>削除</summary>
        public const string Delete = "D";

        /// <summary>新規</summary>
        public const string Insert = "I";

        /// <summary>更新</summary>
        public const string Update = "U";
    }

    //DivisionCodeに移動。

    ///// <summary>
    ///// 課コードの定数
    ///// </summary>
    //public class ConstDivision
    //   {
    //	 /// <summary>総務課の課コード </summary>
    //       public const int SoumuDivisionNo = 1000;

    //	 /// <summary>経理課の課コード </summary>
    //       public const int AccountingDivisionNo = 1002;
    //   }

}
