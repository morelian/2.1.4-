using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6._3图书检索
{
    public static partial  class BookSerive
    {
        public static Book[] Judge(this Book[] book, Retrieval match)
        {
            int count = 0;
            for (int i = 0; i < book?.Length; i++)
            {
                if (match(book[i]))
                    count++;
            }
            Book[] books = new Book[count];
            count = 0;
            for (int i = 0; i < book?.Length; i++)
            {
                if (match(book[i]))
                    books[count] = book[i];
            }
            return books;
        }
    }
}
