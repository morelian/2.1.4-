using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4._1教师登分
{
    internal class TeachingtaskCompare : IComparer<Teachingtask>
    {
        /// <summary>
        /// 比较类型枚举；
        /// </summary>
        public enum CompareType                                                 //使用枚举表达不同的排序选项；
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
        /// <param name="student">学生</param>
        /// <param name="otherStudent">另一学生</param>
        /// <returns>大小</returns>
        public int Compare(Teachingtask one, Teachingtask other)               //实现IComparer<>接口的方法Compare，用于实现更多排序选项；
        {

            switch (this.Type)
            {
                case CompareType.TERM:
                    return one.Term.CompareTo(other.Term);
                case CompareType.COURSE:
                    return other.Course.Name.CompareTo(other.Course.Name);
                default:
                    return 0;
            }
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="type">比较类型</param>
        public TeachingtaskCompare(CompareType type)
        {
            this.Type = type;
        }
    }
}
