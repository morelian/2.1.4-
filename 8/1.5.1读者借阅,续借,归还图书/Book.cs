using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5._1读者借阅_续借_归还图书
{/// <summary>
/// 图书
/// </summary>
    internal class Book
    {/// <summary>
    /// 作者
    /// </summary>
      public string author { set; get; }  
        
      /// <summary>
    /// 书名
    /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// 书号
        /// </summary>
        public string Num { set; get; }
        /// <summary>
        /// 价格
        /// </summary>
        public float price { set; get; }
        /// <summary>
        /// 出版日期
        /// </summary>
        public DateTime Time { set; get; }
        /// <summary>
        /// 图书构造函数
        /// </summary>
        /// <param name="name">书名</param>
        /// <param name="num">书号</param>
        /// <param name="price">价格</param>
        /// <param name="time">出版日期</param>
        public Book(string name,string num,string author,float price,DateTime time)
        {
            this.Name = name;
            this.Num = num;
            this.price = price;
            this.Time = time;
            this.author = author;
        }
        /// <summary>
        /// 图书构造函数
        /// </summary>
        public Book()
        {
            this.author = String.Empty;
            this.Name = String.Empty;
            this.Num = String.Empty;
            this.price = float.Parse("0");
            this.Time = DateTime.Parse("0001-01-01");
        }
        /// <summary>
        /// 重写基类object的Equals方法；
        /// </summary>
        /// <param name="obj">比较对象</param>
        /// <returns></returns>
        public override bool Equals(object obj)                                       
        {
            if (obj == null)                                                           
            {
                return false;
            }
            if (!(obj is Book))                                                      
            {
                return false;
            }
           Book other = obj as Book;                                      
            return this.Num == other.Num;                               
        }
        /// <summary>
        /// 获取散列值；
        /// </summary>
        /// <returns>散列值</returns>
        public override int GetHashCode()                                              
        {
            return this.Num.GetHashCode();                                           
        }
        /// <summary>
        /// 判断相等；
        /// </summary>
        /// <param name="student">书</param>
        /// <param name="otherStudent">另一书</param>
        /// <returns>是否相等</returns>
        public static bool operator ==(Book one, Book other)          
        {
            if (ReferenceEquals(one, other))                                
            {
                return true;
            }
            if (one is null || other is null)                              
            {
                return false;
            }
            return one.Num == other.Num;                              
        }
        /// <summary>
        /// 判断不等；
        /// </summary>
        /// <param name="student">书</param>
        /// <param name="otherStudent">另一书</param>
        /// <returns>是否不等</returns>
        public static bool operator !=(Book one, Book other)          
        {
            return !(one == other);                                         
        }
    }
}
