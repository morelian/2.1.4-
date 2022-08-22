using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2._7体侧
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student student1 = new student("3210707015","官祥杰","男",DateTime.Parse("2002-11-29"));
            WriteLine( student1.Creat(float.Parse("1.76"), float.Parse("72")));
            student student2 = new student("319665159", "沐兰", "男", DateTime.Parse("2003-06-06"));
            WriteLine(student2.Creat(float.Parse("1.80"), float.Parse("70")));
        }
    }
}
