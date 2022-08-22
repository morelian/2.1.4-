using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace _1._3._3.毕业论文管理
{/// <summary>
/// 物联网方向毕业论文
/// </summary>
    internal class wlw:dissertaion
    {
        /// <summary>
        /// 实习参与项目
        /// </summary>
        public string opject { set; get; }
        /// <summary>
        /// 硬件平台
        /// </summary>
        public string hardware { set; get; }
        public wlw(string student, string teacher, string subject, string opject, string hardware)
            : base(student, teacher, subject)
        {
            this.opject = opject ;
            this.hardware = hardware;
        }
        /// <summary>
        /// 答辩
        /// </summary>
        public override void rply()
        {
            WriteLine($"{this.student}同学演示硬件平台操作中.....\n演示信息系统操作中");
            base.rply();
        }
        /// <summary>
        /// 存档
        /// </summary>
        public override void file()
        {
            WriteLine("已经回收论文以及代码、开发文档、演示视频等材料!");
        }
    
}
}
