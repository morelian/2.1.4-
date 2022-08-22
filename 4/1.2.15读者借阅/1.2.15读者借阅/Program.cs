using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2._15读者借阅
{
    internal class Program
    {
        static void Main(string[] args)
        {
            borrowingrecord[] a = new borrowingrecord[2];
            book[] book = new book[10];
            book[0] = new book("斗罗大陆", "123456", "ts", 66, DateTime.Parse("2022-3-16"));
            book[1] = new book("斗破苍穹", "123457", "vs", 66, DateTime.Parse("2022-3-15"));
            book[2]= new book("武动乾坤", "123458", "gt", 66, DateTime.Parse("2022-3-14"));
            a[0] = new borrowingrecord(0, book[0], 30);
            a[1] = new borrowingrecord(0, book[1], 30);
            reader one = new reader("3210707015", "官祥杰", 30, 1, 2, a);

            while (true)
            {
                WriteLine("按(1)为借阅，按(2)为续借,按(3)为归还:");
                int q= int.Parse(ReadLine());
                if (q == 1)
                {
                    WriteLine("以下是可借阅的书:");
                    for (int i = 0; i < book.Length && book[i] != null; i++)
                    {
                        WriteLine($"{book[i].name}");
                    }
                    WriteLine("按(0)选择第一本,按(1)选择第二本：");
                    int o = int.Parse(ReadLine());
                    one.borrow(book[o]);
                }
                if (q == 2)
                {
                    WriteLine("以下是你借的书:");
                    for (int i = 0; i < one.borrowingrecord.Length; i++)
                    {
                        WriteLine($"{one.borrowingrecord[i].book}");
                    }
                    WriteLine("按(0)选择第一本,按(1)选择第二本：");
                    int o = int.Parse(ReadLine());
                    one.borrowing(one.borrowingrecord[o].book);
                }
                if (q == 3)
                {
                    one.returnbook();
                }
            }

        }
    }
}
