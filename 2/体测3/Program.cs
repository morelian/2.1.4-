using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 体测3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student students = new student();
            tian ti = new tian();
                WriteLine("请输入学生姓名:");
                string name = ReadLine();
                WriteLine("请输入学生学号:");
                string num = ReadLine();
                WriteLine("请输入学生性别:");
                string sex = ReadLine();
                WriteLine("请输入学生生日:");
                DateTime birth = DateTime.Parse(ReadLine());
                WriteLine("请输入学生身高(m):");
                float high = float.Parse(ReadLine());
                WriteLine("请输入学生体重(kg):");
                float weight = float.Parse(ReadLine());

             students= ti.add(name, num, sex, birth, high, weight);
            WriteLine(students.BMI);
        }
    }
}
