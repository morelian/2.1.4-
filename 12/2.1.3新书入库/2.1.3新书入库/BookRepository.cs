using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._3新书入库
{
    internal class BookRepository
    {/// <summary>
    /// 图书列表
    /// </summary>
        public static List<Book> Books;

         static BookRepository()
        {
            Books = new List<Book>();
            Book[] books = new Book[3];
            books[0] = new Book("C#程序设计", "3210707001","沐兰",100,DateTime.Parse("2022-4-1"));
            books[1] = new Book("C语言程序1", "3210707002", "苏汐", 100, DateTime.Parse("2022-5-1"));
            books[2] = new Book("数据结构13", "3210707003", "苏雯烟", 99, DateTime.Parse("2022-3-13"));
            Books.Add(books[0]);
            Books.Add(books[1]);
            Books.Add(books[2]);
        }
    }
}
