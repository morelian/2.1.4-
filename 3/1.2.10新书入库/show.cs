using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2._9新书入库
{
    internal class show
    {
        public static void put(book books)
        {
            WriteLine($"书名:{books.name:-10}书号:{books.num:-10}\n" +
                          $"价格:{books.price:F2}  出版日期:{books.publicationtime}" +
                          $"是否借出{(books.lend==true?"是":"否")}");
            Write("作者: ");
            for (int i = 0; i < books.author.Length; i++)
            {
                Write($" {books.author[i]}");
            }
            WriteLine();
        }
    }
}
