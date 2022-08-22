using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._3._1课程管理
{/// <summary>
/// 线上线下混合式课程
/// </summary>
    public class Mixedcourse:onlinecourse
    {/// <summary>
    /// 班级
    /// </summary>
        public string Class{ set;get;}
        /// <summary>
        /// 线上线下混合课程
        /// </summary>
        /// <param name="num">课程</param>
        /// <param name="name">编号</param>
        /// <param name="score">学分</param>
        /// <param name="Class">班级</param>
        public Mixedcourse(string num,string name,string score,string pla,string web,string Class)
            :base(num,name,score,pla,web)
        {
            this.Class = Class;
        }
        /// <summary>
        /// 线下讨论
        /// </summary>
        public void offlinediscussion()
        {
            WriteLine($"请同学们准时到{this.Class}参与线下讨论。");
        }
    }
}
