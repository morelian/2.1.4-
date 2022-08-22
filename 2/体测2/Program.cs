using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 体测2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student Student = new student();
            WriteLine("请输入学生学号:");
            Student.num = ReadLine();
            WriteLine("请输入学生姓名:");
            Student.name = ReadLine();
            WriteLine("请输入学生出生日期:");
            Student.birth = DateTime.Parse(ReadLine());
            WriteLine("请输入学生身高(m):");
            Student.high = float.Parse(ReadLine());
            WriteLine("请输入学生体重(kg):");
            Student.weight = float.Parse(ReadLine());
            WriteLine(Student.bmi);

        }
    }
}
