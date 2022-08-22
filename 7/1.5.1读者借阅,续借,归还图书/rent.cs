using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5._1读者借阅_续借_归还图书
{/// <summary>
/// 借阅记录
/// </summary>
    internal class rent
    {/// <summary>
    /// 图书
    /// </summary>
       public Book book { set; get; }
        /// <summary>
        /// 借阅时间
        /// </summary>
       public DateTime time { set; get; }
        /// <summary>
        /// 续借次数
        /// </summary>
        public int times { set; get; }
       /// <summary>
       /// 借阅记录构造函数
       /// </summary>
       /// <param name="book">图书</param>
       /// <param name="time">借阅时间</param>
       /// <param name="times">续借次数</param>
        public rent(Book book,DateTime time,int times)
        {
            this.time = time;
            this.times = times;
            this.book = book;
        }
        public rent()
        {
            this.time = DateTime.Parse("0001-01-01");
            this.times = int.Parse("0");
            this.book = new Book();
        }
    }
}
