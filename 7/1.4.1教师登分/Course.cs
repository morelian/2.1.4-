using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4._1教师登分
{/// <summary>
/// 课程
/// </summary>
    internal class Course
    {/// <summary>
    /// 课程号
    /// </summary>
        public string Num { set; get; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// 学分
        /// </summary>

        public float Mark { set; get; }
        /// <summary>
        /// 课程构造函数
        /// </summary>
        /// <param name="num">课程号</param>
        /// <param name="name">名称</param>
        /// <param name="mark">学分</param>
        public Course(string num,string name,float mark)
        {
            this.Num = num;
            this.Name = name;
            this.Mark = mark;
        }
    }
}
