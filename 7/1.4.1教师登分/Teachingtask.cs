using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4._1教师登分
{/// <summary>
/// 教学任务
/// </summary>
    internal class Teachingtask:IComparable
    {/// <summary>
    /// 学期
    /// </summary>
        public string Term { set; get; }
        /// <summary>
        /// 课程
        /// </summary>
        public Course Course { set; get; }
        /// <summary>
        /// 学生成绩
        /// </summary>
        public Studentmark[] Mark { set; get; }
        public Teachingtask(string term,Course course,Studentmark[] mark)
        {
            this.Course = course;
            this.Term = term;
            this.Mark = mark;
        }
        public int CompareTo(object obj)                                    //实现IComparable接口的CompareTo方法，用于排序；
        {
            Teachingtask one = obj as Teachingtask;
            int result = this.Term.CompareTo(one.Term);
            if (result == 0)
                result = this.Course.Name.CompareTo(one.Course.Name);
            return result;
        }
    }
}
