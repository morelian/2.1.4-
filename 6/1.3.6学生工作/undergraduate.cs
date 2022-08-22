using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._6学生工作
{/// <summary>
/// 本科生
/// </summary>
    internal class undergraduate
    {/// <summary>
    /// 学号
    /// </summary>
        public string num { set; get; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string name { set; get; }
        /// <summary>
        /// 性别
        /// </summary>
        public string sex { set; get; }

        public undergraduate(string num,string name,string sex)
        {
            this.num = num;
            this.name = name;
            this.sex = sex;
        }
    }
    public class sex
    {
        public static  readonly string Nan="男";
        public static readonly string Nv = "女";
    }
   
}
