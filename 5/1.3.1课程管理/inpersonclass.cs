using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._1课程管理
{/// <summary>
/// 面授课程
/// </summary>
    public class inpersonclass : course
    {/// <summary>
    /// 教师姓名
    /// </summary>
        public string namer { set; get; }
        /// <summary>
        /// 考核方式
        /// </summary>
        public string examinationmode { set; get; }
        /// <summary>
        /// 教师构造函数
        /// </summary>
        /// <param name="num">课程编号</param>
        /// <param name="name">课程名称</param>
        /// <param name="score">学分</param>
        /// <param name="namer">教师姓名</param>
        /// <param name="examinationmode">考核方式</param>
        public inpersonclass(string num,string name,string score,string namer,string examinationmode)
            :base(num,name,score)
        {
            this.namer = namer;
            this.examinationmode = examinationmode;
        }

    }
}
