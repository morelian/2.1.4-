using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._6学生工作
{/// <summary>
/// 毕业班本科生
/// </summary>
    internal class graduatingundergraduate:undergraduate
    {/// <summary>
    /// 实习单位
    /// </summary>
        public string internshipunit { set; get; }
        /// <summary>
        /// 毕业论文导师
        /// </summary>
        public string thesistutor { set; get; }
        public graduatingundergraduate(string num, string name, string sex)
            :base(num,name,sex)
        {
            
        }
        public graduatingundergraduate(string num,string name,string sex,string internshipunit,string thesistor)
            :base(num,name,sex)
        {
            this.internshipunit = internshipunit;
            this.thesistutor = thesistutor;
        }
    }
}
