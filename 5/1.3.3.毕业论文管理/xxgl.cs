using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._3._3.毕业论文管理
{
    internal class xxgl:dissertaion
    { /// <summary>
      /// 校外导师
      /// </summary>
        public string teacher1 { set; get; }
        /// <summary>
        /// 代码
        /// </summary>
        public string code { set; get; }
        /// <summary>
        /// 开发文档
        /// </summary>

        public string document { set; get; }
        /// <summary>
        /// 信息系统方向毕业论文构造函数
        /// </summary>
        /// <param name="teacher">校外导师</param>
        /// <param name="code">代码</param>
        /// <param name="document">开发文档</param>
        public xxgl(string student, string teacher, string subject, string teacher1, string code,string document)
              : base(student, teacher, subject)
        {
            this.teacher1 =teacher1;
            this.document = document;
            this.code = code;
        }
        /// <summary>
        /// 答辩
        /// </summary>
        public override void rply()
        {
            WriteLine($"{this.student}同学演示信息系统操作中......");
            base.rply();
        }
        /// <summary>
        /// 存档
        /// </summary>
        public override void file()
        {
            WriteLine("已经回收论文以及代码、开发文档等材料!");
        }
    }
}
