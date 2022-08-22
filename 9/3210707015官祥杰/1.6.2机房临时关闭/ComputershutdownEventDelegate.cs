using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6._2机房临时关闭
{/// <summary>
/// 机房关闭事件委托
/// </summary>
    public class ComputershutdownEventDelegate
    {
    }
    /// <summary>
    /// 机房关闭事件委托
    /// </summary>
    /// <param name="sendor">发送方</param>
    /// <param name="e">机房关闭事件参数</param>
    public delegate void ComputershutdownEventhalder(object sendor, ComputershutdownEventArgs e);
}
 