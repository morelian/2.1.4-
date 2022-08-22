using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._5._1读者借阅_续借_归还图书
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("数据结构与算法", "137598701","苏汐", float.Parse("68"), DateTime.Parse("2020-05-06"));
            Book book1 = new Book("C#面向对象程序设计", "137598702", "苏汐", float.Parse("79"), DateTime.Parse("2022-05-06"));
            rent[] rent = {
                new rent(book, DateTime.Parse("2022-04-16"), int.Parse("0"))
        };

            Reader one = new Reader("3210707015", "沐兰", rent);
            one += book1;
            WriteLine($"编号:{one.num}名字:{one.name}");
            for (int i = 0; i < one.rent.Length; i++)
            {  if(one.rent[i].book.author!=String.Empty)
                WriteLine($"书名:{one.rent[i].book.Name} 书号:{one.rent[i].book.Num}  作者:{one.rent[i].book.author}\n" +
                    $"出版时间:{one.rent[i].book.Time:f} 借阅时间:{one.rent[i].time} 续借次数:{one.rent[i].times}\n");
            }
            WriteLine($"书名:{one["137598701"]?.book.Name} 书号:{one["137598701"]?.book.Num} 作者:{one["137598701"]?.book.author}\n" +
                $"出版时间:{one["137598701"]?.book.Time:f} 借阅时间:{one["137598701"]?.time} 续借次数:{one["137598701"]?.times}\n");
            while (true)
            {
                WriteLine("输入1显示借阅记录,输入2添加借阅记录，输入3判断两本书是否相等,输入4查询以借阅的图书,输入5退出程序:");
                int a = int.Parse(ReadLine());
                if (a == 1)
                {
                    WriteLine($"编号:{one.num} 名字:{one.name}");
                    for (int i = 0; i < one.rent.Length; i++)
                    {
                        if (one.rent[i].book.author != String.Empty)
                            WriteLine($"书名:{one.rent[i].book.Name} 书号:{one.rent[i].book.Num} 作者:{one.rent[i].book.author}\n" +
                            $"出版时间:{one.rent[i].book.Time:f} 借阅时间:{one.rent[i].time} 续借次数:{one.rent[i].times}");
                    }
                }
                if (a == 2)
                { 
                    Book book2 = new Book();

                    WriteLine("输入书名:");
                    book2.Name = ReadLine();
                    WriteLine("作者:");
                    book2.author = ReadLine();
                    WriteLine("输入书号:");
                    book2.Num = ReadLine();
                    WriteLine("输入价格:");
                    book2.price = float.Parse(ReadLine());
                    WriteLine("输入出版时间:");
                    book2.Time = DateTime.Parse(ReadLine());
                    one += book2;
                }
                if (a == 3)
                {
                    Book book2 = new Book();

                    WriteLine("输入书名:");
                    book2.Name = ReadLine();
                    WriteLine("作者:");
                    book2.author = ReadLine();
                    WriteLine("输入书号:");
                    book2.Num = ReadLine();
                    WriteLine("输入价格:");
                    book2.price = float.Parse(ReadLine());
                    WriteLine("输入出版时间:");
                    book2.Time = DateTime.Parse(ReadLine());
                    Book book3 = new Book();

                    WriteLine("输入书名:");
                    book3.Name = ReadLine();
                    WriteLine("作者:");
                    book3.author = ReadLine();
                    WriteLine("输入书号:");
                    book3.Num = ReadLine();
                    WriteLine("输入价格:");
                    book3.price = float.Parse(ReadLine());
                    WriteLine("输入出版时间:");
                    book3.Time = DateTime.Parse(ReadLine());
                    WriteLine($"{(book2 == book3 ? "" : "不")}是同一本书。");
                }
                {

                }
                if (a == 4)
                {
                    WriteLine("输入书号:");
                    string b = ReadLine();
                    rent rent1 = one[b];
                    if (rent1 != null)
                    {
                        WriteLine($"书名:{rent1.book.Name} 书号:{rent1.book.Num}\n" +
                            $"作者:{rent1.book.author} 价格:{rent1.book.price} 出版日期:{rent1.book.Time:f}");
                    }
                    else WriteLine("查无此书");
                }
                if (a == 5)
                    return;
            }
        }
        
    }
}
