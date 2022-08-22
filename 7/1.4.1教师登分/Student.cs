using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4._1教师登分
{/// <summary>
/// 学生
/// </summary>
    internal class Student:IComparable
    {/// <summary>
    /// 学号
    /// </summary>
        public string Num { set; get; }
        /// <summary>
        /// 姓名
        /// </summary>

        public string Name { set; get; }
        /// <summary>
        /// 班级
        /// </summary>

        public string Class { set; get; }
        /// <summary>
        /// 学生构造函数
        /// </summary>
        /// <param name="num">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="Class">班级</param>
        public Student(string num,string name,string Class)
        {
            this.Class = Class;
            this.Name = name;
            this.Num = num;
        }
        public Student(string num, string name)
        {
            this.Num = num;
            this.Name = name;
        }
        /// <summary>
		/// 比较；
		/// </summary>
		/// <param name="obj">对象</param>
		/// <returns>大小</returns>
		public int CompareTo(object obj)                                    //实现IComparable接口的CompareTo方法，用于排序；
        {
            Student otherStudent = obj as Student;                          //使用as实现显式类型转换；
            int result = this.Num.CompareTo(otherStudent.Num);        //字符串类型已实现IComparable接口，可进行比较；
            if (result == 0)
            {
                result = this.Name.CompareTo(otherStudent.Name);
            }
            return result;
        }
    }
}
