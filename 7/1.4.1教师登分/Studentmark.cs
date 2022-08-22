using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4._1教师登分
{/// <summary>
/// 学生成绩
/// </summary>
    internal class Studentmark
    {
      public   Student Student { set; get; }

        /// <summary>
        /// 考试状态
        /// </summary>
        public string Behavior { set; get; }
        /// <summary>
        /// 平时成绩
        /// </summary>

        public float Dailygard { set; get; }
        /// <summary>
        /// 期末成绩
        /// </summary>
        public float Finalgard { set; get; }
        /// <summary>
        /// 总评成绩
        /// </summary>

        public float Score { set; get; }
        /// <summary>
        /// 学生成绩构造函数
        /// </summary>
        /// <param name="Student">学生</param>
        /// <param name="behavior">考试状态</param>
        /// <param name="dailygard">平常成绩</param>
        /// <param name="finalgard">总评成绩</param>
        public Studentmark( string behavior, float dailygard, float finalgard,float Score, Student Student)
        {
            this.Student = Student;
            this.Behavior= behavior;
            this.Dailygard = dailygard;
            this.Finalgard = finalgard;
            this.Score = Score;
        }

    }
}




