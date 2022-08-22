using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._2上机预约
{/// <summary>
/// 学生
/// </summary>
    internal class student
    {/// <summary>
    /// 姓名
    /// </summary>
        public string name { set; get; }
        /// <summary>
        /// 学号
        /// </summary>
        public string num { set; get; }
       /// <summary>
       /// 学生
       /// </summary>
       /// <param name="num">学号</param>
       /// <param name="name">姓名</param>
        public student(string num, string name)
        {
            this.name = name;
            this.num = num;
        }
    }
}
