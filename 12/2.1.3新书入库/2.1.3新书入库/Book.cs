using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._3新书入库
{
    internal class Book
    {
        /// <summary>
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
        public DateTime Publication__Date { set; get; }
        /// <summary>
        /// 图书构造函数
        /// </summary>
        /// <param name="name">书名</param>
        /// <param name="num">书号</param>
        /// <param name="author">作者</param>
        /// <param name="price">价格</param>
        /// <param name="time">出版日期</param>
        public Book(string name, string num, string author, float price, DateTime time)
        {
            this.Author = author;
            this.Name = name;
            this.Num = num;
            this.Price = price;
            this.Publication__Date = time;
        }
        public Book()
        {

        }
        /// <summary>
        /// 验证书名
        /// </summary>
        /// <param name="name"></param>
        public static string Verifythetitle(string name)
        {
            if (name.Length >= 10)
                return "书名不能超过10个字符，请重新输入！";
            else return string.Empty;
        }

        /// <summary>
        /// 验证书号
        /// </summary>
        /// <param name="name"></param>
        public static string Verifythenum(string name)
        {
            if (!(name.Length == 10 || name.Length == 13))
                return "书号应为10位数或者为13位数，请重新输入！";
            else return string.Empty;
        }
        /// <summary>
        /// 简介
        /// </summary>
        public string Introduction
            => $"书名：" + this.Name + " 书号：" + this.Num + " 作者：" + this.Author + "" +
            "\n价格：" + this.Price + "  出版日期：" +this.Publication__Date;
    }
}
