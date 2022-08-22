using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6._3图书检索
{
    public class Book
    {
        public string Name { set; get; }
        public string Num { set; get; }
        public string Author { set; get; }
        public float Price { set; get; }

        public DateTime Publicationdate { set; get; }
        public string Press { set; get; }
        /// <summary>
        /// 图书构造函数
        /// </summary>
        /// <param name="num"></param>
        /// <param name="name"></param>
        /// <param name="Author"></param>
        /// <param name="time"></param>
        /// <param name="price"></param>
        /// <param name="press"></param>
        public Book(string num,string name,string Author,DateTime time,float price,string press)
        {
            this.Author = Author;
            this.Name = name;
            this.Num = num;
            this.Press = press;
            this.Price = price;
            this.Publicationdate = time;
        }
    }
}
