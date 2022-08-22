using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6._1新书入库
{/// <summary>
/// 新书入库委托
/// </summary>
    public class AddnewDelegate
    {/// <summary>
    /// 新书入库委托
    /// </summary>
    /// <param name="room">书库</param>
    /// <param name="book">新书</param>
        public delegate void AddbookDelegate(Stackroom room, EventArgs args);
    }
}
