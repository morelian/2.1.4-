using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._7._5页面后退
{/// <summary>
/// 页面
/// </summary>
    public class Page
    {/// <summary>
    /// 地址
    /// </summary>
      public string Address { set; get; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { set; get; }
        /// <summary>
        /// 显示
        /// </summary>
        public void Display()
        {
            WriteLine($"标题:{this.Title}\n" +
                $"地址：{this.Address}");
        }
        /// <summary>
        /// 页面构造函数
        /// </summary>
        public Page()
        {

        }
        /// <summary>
        /// 页面构造函数
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="address">地址</param>
        public Page(string title,string address)
        {
            this.Title = title;
            this.Address = address;
        }
    }
}
