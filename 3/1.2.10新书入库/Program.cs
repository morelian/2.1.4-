using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._9新书入库
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] author = new string[3];
            author[0] = "Abraham Silberschatz";
            author[1] = "Henry F.Korth";
            author[2] = "S.Sudarshan";
            string[] author1 = new string[1];
            author1[0] = "Christian";
            book book1 = book.Creat("《C语言高级编程(第11版)》", "9787302522560",
               float.Parse("149.60"), DateTime.Parse("2019-3-1"), author1, false);
            book book2 = book.Creat("《数据库系统概念(原书第6版)》", "9797111375296",
               float.Parse("95.00"), DateTime.Parse("2012-5-1"), author, false);
            show.put(book1);
            show.put(book2);
        }
    }
}
