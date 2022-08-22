using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._3._4考试系统
{
    internal class Program
    {
        static void Main(string[] args)
        {
            multiple multiple1 = new multiple("x^2+1+2x=0,x=?", "A", "6","A-1 B2 C3 D4");
            multiple multiple2 = new multiple("y=sin x,则y的15阶导为:,", "C", "6","Asinx B-sinx C-cosx Dcosx");
            multiple multiple3 = new multiple("设平面1 : 2x+y+z -4=0和平面2:x-y+2z-3=0, 则平面1与平面2 的夹角为:", "B", "6", "A30° B60° C90° D45°");
            Nouninterpretation n1 = new Nouninterpretation("解释心驰神往:", "向往的地方", "20");
            Nouninterpretation n2 = new Nouninterpretation("解释恬静:", "安静、宁静、环境幽雅。", "20");
            multiple1.puttitle();
            multiple1.reply();
            multiple1.marking();
            multiple2.puttitle();
            multiple2.reply();
            multiple2.marking();
            multiple3.puttitle();
            multiple3.reply();
            multiple3.marking();
            n1.puttitle();
            n1.reply();
            n1.marking();
            n2.puttitle();
            n2.reply();
            n2.marking();

            WriteLine("得分情况:");
            WriteLine("客观题:");
            multiple1.puttitle();
            WriteLine($"学生答案:{ multiple1.studentanswer}\n得分:{ multiple1.points}分");
            multiple2.puttitle();
            WriteLine($"学生答案:{ multiple2.studentanswer}\n得分:{ multiple2.points}分");
            multiple3.puttitle();
            WriteLine($"学生答案:{ multiple3.studentanswer}\n得分:{ multiple3.points}分");
            WriteLine("主观题:");
            n1.puttitle();
            WriteLine($"学生答案:{n1.studentanswer}\n得分:{n1.points}分");
           n2.puttitle();
            WriteLine($"学生答案:{n2.studentanswer}\n得分:{n2.points}分");

        }
    }
}
