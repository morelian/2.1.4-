using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 导师分配
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student Student = new student();
            teacher teacher1 = new teacher();
            teacher teacher2 = new teacher();
            Student.nume = "3210707015";
            Student.name = "苏汐";
            teacher1.name = "沐兰";
            teacher2.name = "苏雯烟";
            teacher1.num = "319665159";
            teacher2.num = "256831520";
            teacher1.resrarch = "元宇宙";
            teacher2.resrarch = "云数据";
                WriteLine($"学生姓名:{Student.name,-5}学号:{Student.nume,-5}\n现有两名教师的研究方向是学生{Student.name},所感兴趣的，请为其分配导师:\n\n" +
                    $"导师姓名:{teacher1.name,-5}工号:{teacher1.num,-12}研究方向:{teacher1.resrarch}\n\n" +
                    $"导师姓名:{teacher2.name,-5}工号:{teacher2.num,-12}研究方向:{teacher2.resrarch}\n\n" +
                    $"输入1则为其分配导师为:{teacher1.name}教师\n" +
                    $"输入2则为其分配导师为:{teacher2.name}教师\n" +
                    $"请输入(1或2）:\n");
            int a = '3';
                while (a != 1 && a != 2)
                {
                    a= int.Parse(ReadLine());
                if (a == 1)
                        Student.Teacher = teacher1;
                    else if (a == 2)
                        Student.Teacher = teacher2;
                    else
                        WriteLine("输入错误请重新输入!");
                }
                WriteLine($"分配完成!\n学生姓名:{Student.name,-5}学号:{Student.nume,-12}\n学生导师:{Student.Teacher.name}\n");
            Student.Teacher = teacher2;
        }
    }
}
