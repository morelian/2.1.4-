using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 上机预约
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student Student = new student();
            book booking = new book();
            WriteLine("请输入学生名字:");
            Student.name = ReadLine();
            WriteLine("请输入实验名称:");
            booking.Project.explment = ReadLine();
            WriteLine("请输入实验课程名称:");
            booking.Project.course = ReadLine();
            WriteLine("请输入起始时间:");
            booking.begine = DateTime.Parse(ReadLine());
            WriteLine("请输入实验时长:");
            booking.time = ReadLine();
            WriteLine($"预约详情为:\n学生名字:{Student.name}\n实验名称:{booking.Project.explment}\n" +
                $"实验课程名称:{booking.Project.course}\n起始时间:{booking.begine:d}\n实验时长:{booking.time}\n");



        }
    }
}
