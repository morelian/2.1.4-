using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._6._3图书检索
{/// <summary>
/// 图书显示
/// </summary>
    public static class BookUI
    {/// <summary>
    /// 显示一本书
    /// </summary>
    /// <param name="book">书</param>
        public static void Display(Book book)
        {
            WriteLine($"书名:{book.Name} 书号:{book.Num}作者:{book.Author}\n" +
                $"出版日期:{book.Publicationdate} 出版社:{book.Price} 价格:{book.Price}\n\n");
        }
        /// <summary>
        /// 显示多本书
        /// </summary>
        /// <param name="book">书</param>
        public static void Displays(Book[] book)
        {
            for (int i = 0; i < book?.Length; i++)
            {
                if(book[i]!=null)

                WriteLine($"书名:{book[i].Name} 书号:{book[i].Num}作者:{book[i].Author}\n" +
                    $"出版日期:{book[i].Publicationdate} 出版社:{book[i].Price} 价格:{book[i].Price}");
            }
        }
    }
}
