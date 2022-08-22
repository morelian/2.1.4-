using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._3._6学生工作
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] manage = new string[5];
            manage[0] = "奖励";
            manage[1] = "奖励";
            manage[2] = "奖励";
            manage[3] = "奖励";
            manage[4] = "奖励";
            string[] manage2 = new string[2];
            manage2[0] = "奖励";
            manage2[1] = "处分";
            graduatingundergraduate student1 = new graduatingundergraduate("001", "沐兰", "男", "中国移动", "李老师");
            workstudystudent student2 = new workstudystudent("002", "苏韵", "女", DateTime.Parse("2022-4-1"), 3000);
            studentassistant studentassistant = new studentassistant("321001", "苏雯烟", "女", DateTime.Parse("2022-4-1"), 8000);
            zlfdy one = new zlfdy("321002", "苏汐", "女",10000, manage);
            while (true)
            {
                WriteLine("输入1为对勤工俭学学生的考核,2为对学生助理的投诉，3为对学生助理的考核,4为对助理辅导员的任命,5为对助理辅导员的考核,0退出：");
                int a = int.Parse(ReadLine());
                if (a == 0)
                    return;
                if (a == 1)
                    student2.examine();
                if (a == 2)
                    studentassistant.addappeal();
                if (a == 3)
                    studentassistant.examine();
                if (a == 4)
                    one.appoint();
                if (a == 5)
                {
                    WriteLine("选择是否有处分的考核1有2没有:");
                    int b = int.Parse(ReadLine());
                    if (b == 1)
                        one.manage = manage2;
                    else one.manage = manage;
                    one.examine();
                }

            }
        }
    }
}
