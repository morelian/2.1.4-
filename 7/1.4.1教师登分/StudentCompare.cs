using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4._1教师登分
{
    internal class StudentCompare:IComparer<Studentmark>
    {
        /// <summary>
        /// 比较类型枚举；
        /// </summary>
        public enum CompareType                                                 //使用枚举表达不同的排序选项；
        {
            NUMBER,
            NAME,
            USUAL,
            FINAL,
            OVER

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
        public int Compare(Studentmark one, Studentmark other)               //实现IComparer<>接口的方法Compare，用于实现更多排序选项；
        {

            switch (this.Type)
            {
                case CompareType.NUMBER:
                    return one.Student.Num.CompareTo(other.Student.Num);
                case CompareType.NAME:
                    return one.Student.Name.CompareTo(other.Student.Name);
                case CompareType.USUAL:
                    return one.Dailygard.CompareTo(other.Dailygard);
                case CompareType.FINAL:
                    return one.Finalgard.CompareTo(other.Finalgard);
                case CompareType.OVER:
                    return one.Score.CompareTo(other.Score);
                default:
                    return 0;
            }
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="type">比较类型</param>
        public StudentCompare(CompareType type)
        {
            this.Type = type;
        }
    }
}
