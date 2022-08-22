using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._7毕业论文指导
{
    internal class Program
    {
        static void Main(string[] args)
        {
            graduatingundergraduate student1 = new graduatingundergraduate(paperdirection.xxxt);
            graduatingundergraduate student2 = new graduatingundergraduate(paperdirection.sjfx);
            graduatingundergraduate student3 = new graduatingundergraduate(paperdirection.wlw);
            oncampustutor one = new oncampustutor("001", "沐兰", "福建中医药大学", "数据挖掘");
            offcampustutor two = new offcampustutor("101", "苏汐", "福建医科大学", "算法优化");
            student1.arrangetutor(one,two);
            student1.advisor.guide();
            student1.advisor.reply();
            student2.arrangetutor(one, two);
            student2.advisor.guide();
            student2.advisor.reply();
            student3.arrangetutor(one, two);
            student3.advisor.guide();
            student3.advisor.reply();
        }
    }
}
