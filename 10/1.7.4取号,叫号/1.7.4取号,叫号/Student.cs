using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7._4取号_叫号
{/// <summary>
/// 学生
/// </summary>
    public class Student
    {/// <summary>
    /// 姓名
    /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// 学号
        /// </summary>
        public string Num { set; get; }
        /// <summary>
        /// 班级
        /// </summary>
        public string Class { set; get; }
        public Student()
        {

        }
        /// <summary>
        /// 学生构造函数
        /// </summary>
        /// <param name="num"></param>
        /// <param name="name"></param>
        /// <param name="Class"></param>
        public Student(string num,string name,string Class)
        {
            this.Class = Class;
            this.Name = name;
            this.Num = num;
        }
    }
}
