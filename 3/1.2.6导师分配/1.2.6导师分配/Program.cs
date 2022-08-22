using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2._6导师分配
{
    internal class Program
    {
        static void Main(string[] args)
        {    
            student student1 = new student();
            teacher teacher1 = new teacher();
            teacher teacher2 = new teacher();
            student1.name = "沐兰";
            student1.num = "3210707015";
            teacher1.name = "苏雯烟";
            teacher1.num = "3196651599";
            teacher1.reacher = "元宇宙";
            teacher2.reacher = "云数据";
            teacher2.num = "2568731520";
            teacher2.name = "苏汐";
            student1.Get();
            WriteLine($"现有两名导师可为{student1.name}同学分配,请你为其选择导师:\n按(1)选择{teacher1.name}老师,按(2)选择{teacher2.name}老师:");
            int choose=int.Parse(Console.ReadLine());
            if (choose == 1)
            {
                student1.setteacher(teacher1);  
            }
            else student1.setteacher(teacher2);
            WriteLine($"已为其分配导师{student1._teacher.name}");
            student1.setteacher(teacher1);
        }
      
    }
}
