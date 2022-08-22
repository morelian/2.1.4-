using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._12考务管理
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student student1 = new student("官祥杰", "3210707015");
            teacher teacher1 = new teacher("沐兰", "3196651591");
            teacher1.Math(student1,"90");
            student1.Evaulate(teacher1, "10");
        }
    }
}
