using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4._2教师登分
{
/// <summary>
/// 课程
/// </summary>
   public  class Course
    { /// <summary>
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
        public float Score { set; get; }
        public Course()
        {
            this.Num = string.Empty;
            this.Name = string.Empty;
            this.Score = 0;
        }
        public Course(string num,string name,float score)
        {
            this.Num = num;
            this.Name = name;
            this.Score = score;
        }

    }
}
