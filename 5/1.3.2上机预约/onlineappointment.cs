using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._2上机预约
{/// <summary>
/// 上机练习预约
/// </summary>
    internal class onlineappointment
    {/// <summary>
    /// 学生
    /// </summary>
        student student { set; get; }
        
        /// <summary>
     /// 起始时间
     /// </summary>
        public DateTime begin { set; get; }
        /// <summary>
        /// 时长
        /// </summary>
        public string longth { set; get; }
        /// <summary>
        /// 预约
        /// </summary>
        /// <param name="students">学生</param>
        /// <param name="begin">起始时间</param>
        /// <param name="length">时长</param>
        public virtual void Appointment(student students, DateTime begin, string length)
        {
            this.begin = begin;
            this.longth = length;
            this.student = student;
        }
    }
}
