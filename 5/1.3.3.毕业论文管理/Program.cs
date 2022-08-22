using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace _1._3._3.毕业论文管理
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dissertaion dissertaion1 = new dissertaion("官祥杰","林立","毕业论文管理系统");
            dataanalysis dataanalysis1 = new dataanalysis("官祥杰", "林立", "数据的回溯保存记位", "请查看https://www.csdn.net/", "请查看https://www.csdn.net/");
            wlw wlw = new wlw("官祥杰", "林立", "物理信号的查看", "校园物体识别二维码", "请查看https://www.csdn.net/");
            xxgl xxgl = new xxgl("官祥杰", "林立","学生信息管理系统", "王老师", "请查看https://www.csdn.net/", "请查看https://www.csdn.net/");
            while (true)
            {
                WriteLine("输入1为信息系统方向,输入2为物联网方向,输入3为数据分析方向,输入4退出:");
                int a = int.Parse(ReadLine());
                if (a == 1)
                {
                    WriteLine($"导师{xxgl.teacher}提问中......");
                    WriteLine($"导师{xxgl.teacher1}提问中......");
                    xxgl.rply();
                    xxgl.file();
                }
                if (a == 2)
                {
                    WriteLine($"导师{wlw.teacher}提问中......");
                    wlw.rply();
                   wlw.file();
                }
                if (a == 3)
                {
                    WriteLine($"导师{dataanalysis1.teacher}提问中......");
                    dataanalysis1.rply();
                   dataanalysis1.file();
                }
                if (a == 4)
                {
                    return;
                }
            }
        }
    }
}
