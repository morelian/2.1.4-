using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2._9新书入库
{
    internal class book
    {
        public string name { set; get; }
        public string num { set; get; }
        public string[] author { set; get; }
        public float price { set; get; }
        public DateTime publicationtime { get; set; }
       public bool lend { set; get; }
        private book(string name, string num, float price,DateTime time,string[] author,bool was)
        {
            this.name = name;
            this.num = num;
            this.price = price;
            this.publicationtime = time;
            this.author = author;
            this.lend = was;
        }
        public static book Creat(string name, string num, float price,DateTime time,string[]author,bool was)
        {
            if (num.Length != 13)
            {
                WriteLine("书号长度应为13位！");
                return null;
            }
            book books = new book(name, num, price, time,author,was);
            return books;
        } 
    }
    }

