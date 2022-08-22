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
        public Book()
        {
            this.author = String.Empty;
            this.Name = String.Empty;
            this.Num = String.Empty;
            this.price = float.Parse("0");
            this.Time = DateTime.Parse("0001-01-01");
        }

        public override bool Equals(object obj)                                         //重写基类object的Equals方法；
        {
            if (obj == null)                                                            //若比较对象为空值，则双方不等；
            {
                return false;
            }
            if (!(obj is Book))                                                      //若比较对象的类并非学生，则双方不等；
            {
                return false;
            }
           Book other = obj as Book;                                      //将比较对象显式转换为学生类；
            return this.Num == other.Num;                                  //比较两个学生对象的学号是否相等；
        }
        /// <summary>
        /// 获取散列值；
        /// </summary>
        /// <returns>散列值</returns>
        public override int GetHashCode()                                               //若对象将用作字典的键值，则在重写基类object的Equals方法后，还需重写基类object的GetHashCode方法；
        {
            return this.Num.GetHashCode();                                           //返回学号的散列值；即只要两个学生对象的学号的散列值相等，则双方的键值相等；
        }
        /// <summary>
        /// 判断相等；
        /// </summary>
        /// <param name="student">书</param>
        /// <param name="otherStudent">另一书</param>
        /// <returns>是否相等</returns>
        public static bool operator ==(Book one, Book other)           //重载比较运算符==；比较运算符应成对重载，故还需重载!=；另外还需重写Equals与GetHashCode方法；
        {
            if (ReferenceEquals(one, other))                                 //调用基类object的ReferenceEquals方法，判断双方的引用地址是否相等（包括双方均为空值的情况）；
            {
                return true;
            }
            if (one is null || other is null)                                //判断双方是否为空；若直接使用==运算符与null比较，将导致栈溢出；
            {
                return false;
            }
            return one.Num == other.Num;                               //比较两个学生对象的学号是否相等；
        }
        /// <summary>
        /// 判断不等；
        /// </summary>
        /// <param name="student">书</param>
        /// <param name="otherStudent">另一书</param>
        /// <returns>是否不等</returns>
        public static bool operator !=(Book one, Book other)           //重载比较运算符!=；比较运算符应成对重载；
        {
            return !(one == other);                                          //调用比较运算符==的重载；
        }
    }
}
