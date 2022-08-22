using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._3._7毕业论文指导
{/// <summary>
/// 校内导师
/// </summary>
    internal class oncampustutor:teachstaff,undergraduatethesistutor
    {/// <summary>
    /// 研究方向
    /// </summary>
        public string search { set; get; }
        public void guide()
        {
            WriteLine($"导师{this.name}对论文的理论依据、研究方法、研究内容等方面如何编写，给出建议");
        }
        
        public void reply()
        {
            WriteLine($"批评老师正在对论文的理论依据、研究方法、研究内容等方面存在不足，提出质询......" +
                $"\n导师{this.name}正在和他们辩答......");
        }
        /// <summary>
        /// 校内导师构造函数
        /// </summary>
        /// <param name="num">工号</param>
        /// <param name="name">姓名</param>
        /// <param name="department">工作单位</param>
        /// <param name="search">研究方向</param>
        public oncampustutor(string num, string name, string department,string search)
            :base(num,name,department)
        {
            this.search = search;
        }
    }
}
