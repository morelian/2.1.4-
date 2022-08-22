using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2._11新生入学
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student student1 = new student("319665159", "苏汐")
            {
                political= political.TUAN                                              //调用类的静态字段；
            };
            student1.ShowInfo();
            WriteLine("欢迎新生入学!");
            if (student1.political == "团员")
            {
                WriteLine("请及时办理团员转入!");
            }
            else if (student1.political == "党员")
            {
                WriteLine("请及时办理党员组织关系转入!");
            }
            else if(student1.political != "群众"){
                WriteLine("录入错误!");
            }
        }
    }
}
