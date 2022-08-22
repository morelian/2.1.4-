using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._3._7毕业论文指导
{
  
    public class paperdirection
    {/// <summary>
    /// 信息系统
    /// </summary>
        public static  readonly string xxxt="信息系统";
        /// <summary>
        /// 物联网
        /// </summary>
        public static readonly string wlw = "物联网";
        /// <summary>
        /// 数据分析
        /// </summary>
        public static readonly string sjfx = "数据分析";
    }


/// <summary>
/// 毕业班本科生
/// </summary>
    internal class graduatingundergraduate
    {/// <summary>
    /// 毕业论文方向
    /// </summary>
        public string paperdirection { set; get; }
        /// <summary>
        /// 导师
        /// </summary>
        public undergraduatethesistutor advisor { set; get; }
        /// <summary>
        /// 安排导师
        /// </summary>
        public void arrangetutor(oncampustutor one,offcampustutor two)
        {
            if(this.paperdirection== "信息系统" || this.paperdirection== "数据分析")
            {
                this.advisor = one;
               
                WriteLine($"已为其分配导师");
            }
           else if (this.paperdirection == "物联网")
            {
                this.advisor = two;
                WriteLine($"已为其分配导师");
            }
            else
            {
                WriteLine("无此方向!");
            }
        }
      public graduatingundergraduate(string paperdirction)
        {
            this.paperdirection = paperdirction;
        }
    }
}
