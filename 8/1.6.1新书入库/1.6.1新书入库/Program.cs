using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._6._1新书入库
{
    public class Program
    {
        static void Main()
        {
            Book[] Book1 = {
                new Book("数据结构与算法", "001", "Eaddaj", float.Parse("68"),DateTime.Parse("2021-1-6"), "程序设计")
            };
            Book Book2 = new Book("数据结构与算法", "001", "Eaddaj", float.Parse("68"), DateTime.Parse("2021-1-6"), "程序设计");
            string[] e = new string[1];
            NewbookEventArgs newbook = new NewbookEventArgs(Book2);
            e[0] = "程序设计";
            Stackroom Stack = new Stackroom(Book1);
            Reader one = new Reader("321007","沐兰",e, "319665159@qq.com");
            Stack.NewbookEvent += Stack.Addnewbookevent;
            Stack.NewbookEvent += one.Recommend;
            Stack.Addbook(newbook);
        
        }
    }
}
