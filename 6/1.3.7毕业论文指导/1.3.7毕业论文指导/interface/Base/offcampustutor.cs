using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._3._7毕业论文指导
{/// <summary>
/// 校外导师
/// </summary>
    internal class offcampustutor:externalstaff,undergraduatethesistutor
    {/// <summary>
    /// 特长
    /// </summary>
        public string good { set; get; }
        /// <summary>
        /// 校外导师构造函数
        /// </summary>
        /// <param name="num">工号</param>
        /// <param name="name">姓名</param>
        /// <param name="department">工作单位</param>
        /// <param name="good">特长</param>
        public offcampustutor(string num, string name, string department, string good)
           : base(num, name, department)
        {
            this.good = good;
        }
        public void guide()
        {
            WriteLine($"校外导师{this.name}对论文的技术路线、技术方案、应用框架等方面如何设计，给出建议");
        }

        public void reply()
        {
            WriteLine($"老师对论文的技术路线、技术方案、应用框架等方面存在不足，提出质询......\n" +
                $"校外导师{this.name}正在和他们答辩......");
        }
    }
}
