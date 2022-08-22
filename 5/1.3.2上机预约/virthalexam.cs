using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._3._2上机预约
{/// <summary>
/// 模拟考试预约
/// </summary>
    internal class virthalexam:onlineappointment
    {/// <summary>
    /// 课程
    /// </summary>
        public string course { set; get; }
        /// <summary>
        /// 预约
        /// </summary>
        /// <param name="students">学生</param>
        /// <param name="begin">起始时间</param>
        /// <param name="length">时长</param>
        /// <param name="course">课程</param>
        public  override void Appointment(student students, DateTime begin, string length)
        {
             base.Appointment(students, begin, length);
            WriteLine("请输入课程名称:");
            this.course = ReadLine();
        }
    }
}
