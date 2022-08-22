using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._7毕业论文指导
{/// <summary>
/// 教职工
/// </summary>
    internal class teachstaff
    {/// <summary>
    /// 工号
    /// </summary>
        public string num { set; get; }
        /// <summary>
        /// 名字
        /// </summary>

        public string name { set; get; }
        /// <summary>
        /// 部门
        /// </summary>

        public string department { set; get; }
        /// <summary>
        /// 教职工构造函数
        /// </summary>
        /// <param name="num">工号</param>
        /// <param name="name">姓名</param>
        /// <param name="department">部门</param>
        public teachstaff(string num,string name,string department)
        {
            this.department = department;
            this.num = num;
            this.name = name;
        }
    }
}
