using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4._2教师登分
{/// <summary>
/// 学生成绩比较器
/// </summary>
    public class StudentCompare : IComparer<Studentachievement>
    {
        /// <summary>
        /// 比较枚举
        /// </summary>
        public enum CompareType                                                
        {
            NUM,
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
        /// <param name="one"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        public int Compare(Studentachievement one, Studentachievement other)             
        {

            switch (this.Type)
            {
                case CompareType.NUM:
                    return one.Student.Num.CompareTo(other.Student.Num);
                case CompareType.NAME:
                    return one.Student.Name.CompareTo(one.Student.Name);
                case CompareType.USUAL:
                    return one.Usualgrade.CompareTo(other.Usualgrade);
                case CompareType.FINAL:
                    return one.Finalgrade.CompareTo(other.Finalgrade);
                case CompareType.OVER:
                    return one.overevaluationresult.CompareTo(other.overevaluationresult);
                default:
                    return 0;
            }
        }
        /// <summary>
        /// 学生比较器构造函数
        /// </summary>
        /// <param name="type">比较类型</param>
        public StudentCompare(CompareType type)
        {
            this.Type = type;
        }
    }
}
