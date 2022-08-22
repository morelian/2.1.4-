using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4._2教师登分
{/// <summary>
/// 教学任务
/// </summary>
    public class Teachingtask:IComparable
    { 
    /// <summary>
    /// 学期
    /// </summary>
        public int Term { set; get; }

        public Studentachievement[] Mark { set; get; }

        public Course Course { set; get; }

        public Teachingtask()
        {
            this.Course = new Course();
            this.Mark = new Studentachievement[1];
            this.Mark[0] = new Studentachievement();
            this.Term = 0;
        }
        ///
        public Teachingtask(int term, Studentachievement[] Mark, Course Course)
        {
            this.Course = Course;
            this.Mark = Mark;
            this.Term = term;
        }
        public int CompareTo(object obj)
        {
            Teachingtask other = obj as Teachingtask;
            int result = this.Term.CompareTo(other.Term);
            if (result == 0)
                result = this.Course.Name.CompareTo(other.Course.Name);
            return result;
        }
    }
}
