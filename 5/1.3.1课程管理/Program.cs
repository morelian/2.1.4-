using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._1课程管理
{
    internal class Program
    {
        static void Main(string[] args)
        {
            inpersonclass inpersonclass1 = new inpersonclass("N2060349", "《面向对象程序设计》", "4.5学分", "林立", "上机考试");
            onlinecourse onlinecourse1 = new onlinecourse("N2010115", "《中医诊断学》", "5.5学分", "学银在线", "http://www.xueyinonline.com/detail/99409351");
            Mixedcourse mixedcourse1 = new Mixedcourse("F2060024", "《健康信息学》", "2学分", "学银在线", "http://www.xueyinonline.com/detail/201635746", "智慧教室1303");

            inpersonclass1.elective("官祥杰");
            onlinecourse1.elective("官祥杰");
            onlinecourse1.onlineinteraction();
            mixedcourse1.elective("官祥杰");
            mixedcourse1.offlinediscussion();
            mixedcourse1.onlineinteraction();
        }
    }
}

