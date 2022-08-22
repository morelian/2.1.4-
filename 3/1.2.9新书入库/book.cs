using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2._10
{
    internal class book
    {
        public string name { set; get; }
        public string num { set; get; }
        public string[] author { set; get; }
        public float price { set; get; }
        public DateTime publictiontime { set; get; }
       public bool lend { get; set; }
        public void put(book books)
        {
            WriteLine($"书名:{books.name} 价格:{books.price}\n" +
                $"出版日期:{books.publictiontime} 是否借出:{(books.lend==true?"是":"否")}");
            Write("作者: ");
            for(int i = 0; i < books.author.Length; i++)
            {
                Write($"{books.author[i]} ");
            }
        }
        public book(string name,string num,string[] author,float price,DateTime time,bool lend)
        {
            this.author = author;
            this.lend = lend;
            this.num = num;
            this.name = name;
            this.price = price;
            this.publictiontime = time;
        }

    }
}
