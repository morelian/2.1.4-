using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2._12考务管理
{
    internal class teacher
    { 
      /// <summary>
      /// 工号
      /// </summary>
        public string num { set; get; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }
        public teacher(string name,string num)
        {
            this.name = name;
            this.num = num;
        }
        /// <summary>
        /// 登分
        /// </summary>
        /// <param name="student">学生</param>
        /// <param name="math">成绩</param>
        public void Math(student student,string math)
        {
            WriteLine($"学生姓名:{student.name}  学生学号:{student.num}  成绩:{math}分");
            DateTime time = DateTime.Now.Date;
            logservice.Add(operate.math, this, student,math,time);
        }
    }
}
