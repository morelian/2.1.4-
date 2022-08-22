using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4._2教师登分
{   /// <summary>
   /// 教师比较
  /// </summary>
    public class Teachercompare : IComparer<Teachingtask>
    {
        public enum CompareType
        {
            TERM,
            COURSE
        }
        /// <summary>
        /// 比较类型
        /// </summary>
        public CompareType Type { get; private set; }
        /// <summary>
        /// 比较
        /// </summary>
        /// <param name="one"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        public int Compare(Teachingtask one,Teachingtask other)
        {
           
            switch (this.Type)
            {
                case CompareType.TERM:
                    return one.Term.CompareTo(other.Term);
                case CompareType.COURSE:
                    return one.Course.Name.CompareTo(other.Course.Name);
                default:
                    return 0;
            }
        }
    }
}
