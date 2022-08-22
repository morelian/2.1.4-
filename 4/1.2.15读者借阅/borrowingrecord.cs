using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._15读者借阅
{
    internal class borrowingrecord
    {/// <summary>
    /// 借阅时间
    /// </summary>
        public DateTime time { set; get; }
        /// <summary>
        /// 续借次数
        /// </summary>
        public int Renewaltimes { set; get; }
        /// <summary>
        /// 图书
        /// </summary>
        public book book { set; get; }
        /// <summary>
        /// 应还时间
        /// </summary>
        public DateTime returntime { set; get; }
        /// <summary>
        /// 借阅记录构造函数
        /// </summary>
        /// <param name="time">借阅时间</param>
        /// <param name="R">续借次数</param>
        /// <param name="b">图书</param>
        /// <param name="r">应还时间</param>
        public borrowingrecord(int R,book b,int r)
        {
            this.book = b;
            this.Renewaltimes = R;
            this.time = DateTime.Now;
            this.returntime = DateTime.Now.AddDays(r);
        }
    }
}
