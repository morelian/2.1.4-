using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._6._1新书入库
{/// <summary>
/// 读者
/// </summary>
    public class Reader
    {/// <summary>
    /// 编号
    /// </summary>
        public string Num { set; get; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// 兴趣类别
        /// </summary>
        public string[] Category { set; get; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { set; get; }
    /// <summary>
    /// 新书推荐
    /// </summary>
    /// <param name="room">发送方</param>
    /// <param name="e">接收方</param>
        public void Recommend(object room, NewbookEventArgs e)
        {for (int i = 0; i < this.Category.Length; i++)
                if (e.Newbook.Category == this.Category[i])
                    WriteLine($"匹对发现{this.Name}的兴趣中包括{e.Newbook.Name}的类型:{e.Newbook.Category}已经向其的邮箱:{this.Email}发送邮件");
        }
        /// <summary>
        /// 读者构造函数
        /// </summary>
        /// <param name="num">编号</param>
        /// <param name="name">姓名</param>
        /// <param name="C">兴趣种类</param>
        /// <param name="E">邮箱</param>
        public Reader(string num,string name,string[] C,string E)
        {
            this.Email = E;
            this.Name = name;
            this.Num = num;
            this.Category = C;

        }
    }
}
