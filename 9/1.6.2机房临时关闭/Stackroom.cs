using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._6._2机房临时关闭
{/// <summary>
/// 机房
/// </summary>
    public class Stackroom
    {/// <summary>
    /// 机房号
    /// </summary>
        public string Num { set; get; }
        /// <summary>
        /// 机房关闭事件
        /// </summary>
        public event ComputershutdownEventhalder Computershutdown;
/// <summary>
/// 机房关闭时
/// </summary>
/// <param name="time">起止时间</param>
        public void Shouttime(string time)
        {

            ComputershutdownEventArgs e = new ComputershutdownEventArgs(time);
            WriteLine($"已向机房:{this.Num}发送开关起始时间：{e.Time:f}");
            Computershutdown?.Invoke(this, e);
        }
        /// <summary>
        /// 维护
        /// </summary>
        public void Maintain()
        {
            WriteLine("输入起止时间:");
            string time = ReadLine();
            Shouttime(time);

        }
        /// <summary>
        /// 机房构造函数
        /// </summary>
        /// <param name="Num">机房号</param>
        public Stackroom(string Num)
        {
            this.Num = Num;
        }

    }
}
