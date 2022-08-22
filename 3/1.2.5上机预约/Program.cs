using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2._5上机预约
{
    internal class Program
    {
        static void Main(string[] args)
        {
            book booking = new book();
            WriteLine("请输入起始时间:");
            DateTime time = DateTime.Parse(ReadLine());
            WriteLine("请输入持续时间:");
            string timeto = ReadLine();
            student student1 = new student();
            student1.name = "沐兰";
            student1.num = "3210707015";
            project Project = new project();
            Project.name = "云计算";
            Project.explment = "数据回溯寻找";
            booking = booking.Creat(student1, Project, time, timeto);
            if (booking != null)
            {
                WriteLine($"预约成功!" +
                    $"预约学生{booking.Student.name} 学号:{booking.Student.num}" +
                    $"课程名称:{booking.project.name} 实验名称:{booking.project.explment}");
            }
            else
            {
                while (booking == null)
                {
                    WriteLine("请输入起始时间:");
                    time = DateTime.Parse(ReadLine());
                    WriteLine("请输入持续时间:");
                    timeto = ReadLine();
                    booking = new book();
                    booking = booking.Creat(student1, Project, time, timeto);
                    if (booking != null)
                    {
                        WriteLine("预约成功!");
                    }
                }
            }
        }
    }
}
