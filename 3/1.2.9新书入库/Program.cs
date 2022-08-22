using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] author=new string[3];
            author[0] = "Abraham Silberschatz";
            author[1] = "Henry F.Korth";
            author[2] = "S.Sudarshan";
            string[] author1=new string[1];
            author1[0] = "Christian";
            book book1 = new book("《C语言高级编程(第11版)》","9787302522560",
                author1,float.Parse("149.60"),DateTime.Parse("2019-3-1"),false);
            book book2 = new book("《数据库系统概念(原书第6版)》", "9797111375296", 
                author, float.Parse("95.00"), DateTime.Parse("2012-5-1"), false);
            book1.put(book1);
            book2.put(book2);
        }
    }
}
