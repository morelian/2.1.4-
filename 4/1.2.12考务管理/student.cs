using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2._12考务管理
{
    internal class student
    {/// <summary>
    /// 学号
    /// </summary>
        public string num { set; get; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string name { set; get; }
        public student(string name,string num)
        {
            this.name = name;
            this.num = num;
        }
        /// <summary>
        /// 评教
        /// </summary>
        /// <param name="teacher">教师</param>
        /// <param name="math">评分</param>
        public void Evaulate(teacher teacher,string math)
        {
                WriteLine($"教师姓名:{teacher.name}  教师学号:{teacher.num}  评分:{math}分(满分十分)");
                DateTime time = DateTime.Now.Date;
                logservice.Add(operate.Evaulate, teacher,this, math, time);
            
        }
    }
}
