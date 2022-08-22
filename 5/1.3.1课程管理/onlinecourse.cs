using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._3._1课程管理
{/// <summary>
/// 线上课程
/// </summary>
    public class onlinecourse:course
    {/// <summary>
    /// 平台名称
    /// </summary>
        public string platformname { set; get; }
        /// <summary>
        /// 网址
        /// </summary>
        public string webaddress { set; get; }
        /// <summary>
        /// 线上课程构造函数
        /// </summary>
        /// <param name="num">课程编号</param>
        /// <param name="name">课程名称</param>
        /// <param name="score">学分</param>
        /// <param name="plat">平台名称</param>
        /// <param name="web">网址</param>
        public onlinecourse(string num,string name,string score,string plat,string web)
            :base(num,name,score)
        {
            this.platformname = plat;
            this.webaddress = web;
        }
        /// <summary>
        /// 线上互动
        /// </summary>
        public void onlineinteraction()
        {
            WriteLine($"请同学们登录网址:{this.webaddress}参与线上互动。");
        }

    }
}
