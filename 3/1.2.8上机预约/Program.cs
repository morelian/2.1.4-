using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._8上机预约
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student student1 = new student("3210707015","官祥杰");
            project project1 = new project("云数据","数据的传输");
            project project2 = new project("无","无");
            book booking = new book(student1,project1,DateTime.Parse("2022-3-20"),"5天");
            booking.Out();
            student student2 = new student("319665159", "沐兰");
            book booking1 = new book(student2);
            booking1.project = project2;
            booking1.Out();
        }
    }
}
