using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2._16学生评教
{
    internal class Program
    {
        static void Main(string[] args)
        {
            courseMath[] c = new courseMath[3];
            courseMath[] b = new courseMath[3];
            teacher teacher1 = new teacher("321","张翠萍", "12345678901", "34567.qq.com");
            teacher teacher2 = new teacher("322", "林立", "12345678901", "34568.qq.com");
            teacher teacher3 = new teacher("323", "张婷", "12345678901", "34569.qq.com");
            course course1 = new course("1","C语言",5);
            course course2 = new course("2", "C#面向对象程序设计", 5);
            course course3 = new course("3", "英语", 5);
            c[0] = new courseMath(course1,teacher1,90);
            c[1] = new courseMath(course2, teacher2,90);
            c[2] = new courseMath(course3, teacher3,90);
            b[0] = new courseMath(course1, teacher1, 90);
            b[1] = new courseMath(course2, teacher2, 90);
            b[2] = new courseMath(course3, teacher3);
            student student1 = new student("3210707015","官祥杰",c,DateTime.Parse("2022-4-10"));
            student student2 = new student("319665159", "沐兰", c, DateTime.Parse("2022-4-10"));
            while (true)
            {
                WriteLine("1评教2查询成绩3退出:");
                int a = int.Parse(ReadLine());
                if (a == 1)
                {
                    student1.elavluable();
                }
                if (a == 2)
                {
                    student1.search();
                    student2.search();
                }
                if (a == 3)
                    return;
            }
        }
    }
}
