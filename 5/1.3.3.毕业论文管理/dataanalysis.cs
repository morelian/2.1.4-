using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._3._3.毕业论文管理
{/// <summary>
/// 数据分析方向毕业论文
/// </summary>
    internal class dataanalysis:dissertaion
    {/// <summary>
    /// 数据源
    /// </summary>
        public string data { set; get; }
        /// <summary>
        /// 脚本
        /// </summary>
        public string script { set; get; }
        /// <summary>
        /// 数据分析方向毕业论文
        /// </summary>
        /// <param name="student">学生</param>
        /// <param name="teacher">导师</param>
        /// <param name="subject">题目</param>
        /// <param name="data">数据源</param>
        /// <param name="scrip">脚本</param>
        public dataanalysis(string student, string teacher, string subject,string data,string scrip)
            : base(student, teacher, subject)
        {
            this.data = data;
            this.script = scrip;
        }
        /// <summary>
        /// 答辩
        /// </summary>
        public override void rply()
        {
            base.rply();
        }
        /// <summary>
        /// 存档
        /// </summary>
        public override void file()
        {
            WriteLine("已将论文、数据源和脚本等材料回收!");
        }
    }
}
