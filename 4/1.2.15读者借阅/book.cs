using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2._15读者借阅
{
    internal class book
    {/// <summary>
    /// 书名
    /// </summary>
        public string name { set; get; }
        /// <summary>
        /// 出版时间
        /// </summary>
        public DateTime outtime { set; get; }
        /// <summary>
        /// 书号
        /// </summary>
        public string num { set; get; }
        /// <summary>
        /// 作者
        /// </summary>
        public string author { set; get; }
        /// <summary>
        /// 价格
        /// </summary>
        public float price { set; get; }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name">书名</param>
        /// <param name="num">书号</param>
        /// <param name="author">作者</param>
        /// <param name="price">价格</param>
        /// <param name="outtime">出版日期</param>
public  book(string name,string num,string author,float price,DateTime outtime)
        {
            this.author = author;
            this.name = name;
            this.num = num;
            this.outtime = outtime;
            this.price = price;
        }
        public book()
        {

        }

    }
}
