using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4._2教师登分
{/// <summary>
/// 学生
/// </summary>
    public class Student
    {
        /// <summary>
        /// 学号
        /// </summary>
        public string Num { set; get; }
        /// <summary>
        /// 名字
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// 班级
        /// </summary>
        public string Class { set; get; }
        public Student(string num,string name,string Class)
        {
            this.Class = Class;
            this.Num = num;
            this.Name = name;
        }
        public Student()
        {
            this.Name = string.Empty;
            this.Class = string.Empty;
            this.Num = string.Empty;
        }
    }
}
