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
        /// 新书入库时
        /// </summary>
        /// <param name="sender">书库</param>
        /// <param name="e">入库事件</param>
        public void Addnewbookevent(object room, NewbookEventArgs e)
        {   
            Stackroom Room = room as Stackroom;
            if (Room.Count >= Room.Book.Length)
            {
                Book[] book = new Book[Room.Count * 2 + 1];
                for(int i = 0; i < Room.Count * 2 + 1; i++)
                {
                    book[i] = new Book();
                }
                Room.Book.CopyTo(book, 0);
                Room.Book = book;
            }
            Room.Book[Room.Count++] =e.Newbook;
            WriteLine($"已将图书:{Room.Book[Room.Count - 1].Name}入库");
        }
        /// <summary>
        /// 入库
        /// </summary>
        /// <param name="n">入库事件</param>
        public void Addbook(NewbookEventArgs n)
        {

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
