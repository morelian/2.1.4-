using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._6._1新书入库
{/// <summary>
/// 书库
/// </summary>
    public class Stackroom
    {/// <summary>
    /// 记录图书数
    /// </summary>
        public int Count { private set; get; }
        /// <summary>
        /// 图书
        /// </summary>
        public Book[] Book { set; get; }
        /// <summary>
        /// 新书入库事件
        /// </summary>
        public event NewbookEventHandler NewbookEvent;
  /// <summary>
  /// 入库
  /// </summary>
  /// <param name="book1">新书</param>
        public void Addnewbookevent(Book book1)
        {   
            if (this.Count >= this.Book.Length)
            {
                Book[] book = new Book[this.Count * 2 + 1];
                for(int i = 0; i < this.Count * 2 + 1; i++)
                {
                    book[i] = new Book();
                }
               this.Book.CopyTo(book, 0);
              this.Book = book;
            }
            this.Book[this.Count++] =book1;
            WriteLine($"已将图书:{this.Book[this.Count - 1].Name}入库");
            Addbook(book1);
        }
        /// <summary>
        /// 新书入库时
        /// </summary>
        /// <param name="book">新书</param>
        public void Addbook(Book book)
        {
            NewbookEventArgs n = new NewbookEventArgs(book);
            this.NewbookEvent?.Invoke(this, n);
        }
        /// <summary>
        /// 新书入库构造函数
        /// </summary>
        /// <param name="book">图书</param>
        public Stackroom(Book[] book)
        {
            this.Book = book;
            this.Count = 1;
        }
        /// <summary>
        /// 新书入库构造函数
        /// </summary>
        public Stackroom()
        {
            this.Book = new Book[1];
            this.Book[0] = new Book();
            this.Count = 0;
        }
    }
}
