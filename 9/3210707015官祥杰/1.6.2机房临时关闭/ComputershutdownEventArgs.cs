using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6._2机房临时关闭
{/// <summary>
/// 电脑关闭事件参数
/// </summary>
    public class ComputershutdownEventArgs:EventArgs
    {/// <summary>
    /// 起止时间
    /// </summary>
        public string Time { set; get; }
        /// <summary>
        /// 电脑关闭事件参数构造函数
        /// </summary>
        /// <param name="time"></param>
        public ComputershutdownEventArgs(string time)
        {
            this.Time = time;
        }

    }
}
