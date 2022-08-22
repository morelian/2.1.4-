using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _2._1._3新书入库
{/// <summary>
/// 图书服务
/// </summary>
    internal static class Bookserve
    {
        /// <summary>
        /// 入库
        /// </summary>
        /// <param name="books"></param>
        /// <param name="name">书名</param>
        /// <param name="num">书号</param>
        /// <param name="author">作者</param>
        /// <param name="price">价格</param>
        /// <param name="time">出版日期</param>
        public static int AddtoStack(this List<Book> books, string name, string num, string author, float price, DateTime time)
        {
            Book book1 = new Book(name,  num, author,price,time);
           Book book2= books.Find(s => s.Name == name && s.Num == num && s.Publication__Date == time&&s.Author==author&&s.Price==price);
            if (!(book2 is null))
            {
                return 1;
            }
            else
            {
                if (book1.Name.Length >10 || !(book1.Num.Length == 10 || book1.Num.Length == 13))
                    return 3;
                else
                {
                    books.Add(book1);
                    return 2;
                }
            }
        }
    }
}
