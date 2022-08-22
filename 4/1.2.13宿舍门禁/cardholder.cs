using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2._13宿舍门禁
{
    public partial class cardholder
    {/// <summary>
    /// 学号
    /// </summary>
        public string num { set; get; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string name { set; get; }
        /// <summary>
        /// 楼号
        /// </summary>
        public string buidingnum { set; get; }
        /// <summary>
        /// 宿舍关闭时间
        /// </summary>
        public int closetime
            => 23;
        /// <summary>
        /// 宿舍开放时间
        /// </summary>
        public int opentime
            => 6;
        /// <summary>
        /// 晚归次数
        /// </summary>
        public int latetimes { set; get; }
        /// <summary>
        /// 持卡人构造函数
        /// </summary>
        /// <param name="num">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="buidnum">楼号</param>
        /// <param name="latetime">晚归次数</param>
        public cardholder(string num,string name,string buidnum,int latetime)
        {
            this.num = num;
            this.name = name;
            this.buidingnum = buidnum;
            this.latetimes = latetime;
        }

    }
}
