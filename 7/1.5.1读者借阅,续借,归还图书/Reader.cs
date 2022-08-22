using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5._1读者借阅_续借_归还图书
{/// <summary>
/// 读者
/// </summary>
    internal class Reader
    {/// <summary>
    /// 编号
    /// </summary>
        public string num { set; get; }
        /// <summary>
        /// 当前借阅书数
        /// </summary>
        public int count;
        /// <summary>
        /// 名字
        /// </summary>
        public string name { set; get; }
        /// <summary>
        /// 借阅记录
        /// </summary>
        public rent[] rent { set; get; }
        /// <summary>
        /// 是否与目标对象相等；
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns>是否相等</returns>
        public override bool Equals(object obj)							
        {
            if (obj == null)											
                return false;
            
            if (!(obj is rent))										
            {
                return false;
            }
            Reader one = obj as Reader;						
            return this.num == one.num;					
        }
        /// <summary>
        /// 获取散列值；
        /// </summary>
        /// <returns>散列值</returns>
        public override int GetHashCode()                               //若对象将用作字典的键值，则在重写基类object的Equals方法后，还需重写基类object的GetHashCode方法；
        {
            return this.num.GetHashCode();                           //返回学号的散列值；即只要两个学生对象的学号的散列值相等，则双方的键值相等；
        }
        /// <summary>
        /// 读者构造函数
        /// </summary>
        /// <param name="num">编号</param>
        /// <param name="name">姓名</param>
        /// <param name="r">借阅记录</param>
        public Reader(string num,string name,rent[] r)
        {
            this.name = name;
            this.num = num;
            this.rent = r;
            this.count = r.Length;
        }
        /// <summary>
        /// 读者构造函数
        /// </summary>
        public Reader()
        {
            this.name = String.Empty;
            this.num = String.Empty;
            this.rent = new rent[1];
            rent[0] = new rent();
            this.count = 0;
        }
        /// <summary>
        /// 借阅
        /// </summary>
        /// <param name="one">借阅记录</param>
        /// <param name="book">要接的书</param>
        /// <returns></returns>
        public static Reader operator +(Reader one,Book book)
        {
            int count = 0;
            for(int i = 0; i < one.rent.Length; i++)
            {
               if(one.rent[i].book==book)
                {
                    count = 1;
                    one.rent[i].times++;
                }
            }
            if (count == 0)
            {
                if (one.count >= one.rent.Length)
                {
                    rent[] newrent = new rent[2 * one.count];
                    one.rent.CopyTo(newrent, 0);
                    one.rent = newrent;
                    one.rent[one.count++].book = book;
                    one.rent[one.count].time = DateTime.Now;
                    one.rent[one.count].times = int.Parse("0");
                }
            }
            return one;
        }

    }
}
