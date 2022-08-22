using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._6._3图书检索
{/// <summary>
/// 书库
/// </summary>
    public class Stackroom
    {/// <summary>
    /// 图书
    /// </summary>
       public Book[] Book { set; get; }
        public Stackroom(Book[] book)
        {
            this.Book = book;
        }

    }
    /// <summary>
    /// 图书检索委托
    /// </summary>
    /// <param name="book"></param>
    /// <returns></returns>
    public delegate bool Retrieval(Book book);
}
