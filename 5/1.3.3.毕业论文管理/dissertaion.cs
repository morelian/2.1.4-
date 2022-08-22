using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._3._3.毕业论文管理
{/// <summary>
/// 毕业论文
/// </summary>
    internal class dissertaion
    {/// <summary>
    /// 学生
    /// </summary>
        public string student { set; get; }
        /// <summary>
        /// 导师
        /// </summary>
        public string teacher { set; get; }
        /// <summary>
        /// 题目
        /// </summary>
        public string subject { set; get; }
        public dissertaion(string student,string teacher,string subject)
        {
            this.student = student;
            this.subject = subject;
            this.teacher = teacher;
        }
        /// <summary>
        /// 答辩
        /// </summary>
        public virtual void rply()
        {
            WriteLine($"{this.student}同学回答导师问题中......");
        }
        /// <summary>
        /// 存档
        /// </summary>
        public virtual void file()
        {
            WriteLine("已将论文材料回收存档!");
        }
    }
}
