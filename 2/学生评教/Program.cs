using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace 学生评教
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] course = { "《c语言程序设计》", "《计算机导论》", "《英语》", "《高数》" };
            float[] math = { 0, 0, 0, 0};
            int i = 0;
            while(i<4)
            {
                WriteLine($"请输入对{course[i]},的课程评价:\n");
            math[i]=int.Parse(ReadLine());
                if (math[i] < 0 || math[i] > 10)
                {
                    Console.WriteLine("输入错误请重新输入\n");
                    continue;
                }
                WriteLine($"你对{course[i]}的评分为:{math[i]}\n"); i++;
            }
        }
    }
}
