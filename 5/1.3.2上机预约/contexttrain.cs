using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._3._2上机预约
{/// <summary>
/// 竞赛训练预约
/// </summary>
    internal class contexttrainL:onlineappointment
    {/// <summary>
    /// 队员
    /// </summary>
        public string[] teammember { set; get; }
        public  override void Appointment(student student,DateTime begin,string length)
        {
            base.Appointment(student, begin, length);
            string[] teammember = new string[50];
            WriteLine("请输入队友总数:");
            int a = int.Parse(ReadLine());
            for (int i = 0; i < a; i++)
                teammember[i] = ReadLine();
            WriteLine("输入结束!");
        }
        
    }
}
