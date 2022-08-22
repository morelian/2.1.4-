using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6._1新书入库
{/// <summary>
 /// 图书
 /// </summary>
    public class Book
    {/// <summary>
    /// 书名
    /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// 书号
        /// </summary>
        public string Num { set; get; }
        /// <summary>
        /// 作者
        /// </summary>
        public string Author { set; get; }
        /// <summary>
        /// 价格
        /// </summary>
        public float Price { set; get; }
        /// <summary>
        /// 出版日期
        /// </summary>
        public DateTime Publicationdate { set; get; }
        /// <summary>
        /// 类别
        /// </summary>
        public string Category { set; get; }
        /// <summary>
        /// 图书构造函数
        /// </summary>
        /// <param name="name">书名</param>
        /// <param name="num">书号</param>
        /// <param name="author">作者</param>
        /// <param name="price">价格</param>
        /// <param name="date">出版日期</param>
        /// <param name="category">类别</param>
        public Book(string name,string num,string author,float price,DateTime date,string category)
        {
            this.Author = author;
            this.Category = category;
            this.Name = name;
            this.Num = num;
            this.Price = price;
            this.Publicationdate = date;
        }
        /// <summary>
        /// 图书构造函数
        /// </summary>
        public Book()
        {
            this.Author = String.Empty;
            this.Category = String.Empty;
            this.Name = String.Empty;
            this.Num = String.Empty;
            this.Price = float.Parse("0");
            this.Publicationdate = DateTime.Now;
        }
    }
}
