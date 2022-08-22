using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._16学生评教
{
    internal class courseMath
    {/// <summary>
    /// 课程
    /// </summary>
        public course course{ set; get; }
        /// <summary>
        /// 教师
        /// </summary>
        public teacher teacher { set; get; }
        /// <summary>
        /// 是否评教
        /// </summary>
        public bool whether { set; get; }
        /// <summary>
        /// 评教评分
        /// </summary>
        public float mark { get; set; }
        /// <summary>
        /// 评教评语
        /// </summary>
        public string commentteaching { set; get; }
        /// <summary>
        /// 成绩
        /// </summary>
        public float math { set; get; }
        public courseMath(course course1,teacher teacher,float math)
        {
            this.teacher = teacher;
            this.math = math;
            this.course = course1;
         

        }
        public courseMath(course course1, teacher teacher)
        {
            this.teacher = teacher;
            this.math = -1;
            this.course = course1;


        }

    }
}
