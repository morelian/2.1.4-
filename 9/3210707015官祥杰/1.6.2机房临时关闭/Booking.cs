using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6._2机房临时关闭
{/// <summary>
/// 上机预约
/// </summary>
    public class Booking
    {
        public string Student { set; get; }
        /// <summary>
        /// 起始时间
        /// </summary>
        public string Time { set; get; }
        /// <summary>
        /// 时长
        /// </summary>
        public float Longtime { set; get; }
        /// <summary>
        /// 上机预约构造函数
        /// </summary>
        /// <param name="student"></param>
        /// <param name="time">起始时间</param>
        /// <param name="leng">时长</param>
        public Booking(string student,string time,float leng)
        {
            this.Time = time;
            this.Student = student;
            this.Longtime = leng;
        }
    }
}
