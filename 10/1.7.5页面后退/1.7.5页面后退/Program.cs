using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._7._5页面后退
{
    public class Program
    {
        static void Main(string[] args)
        {
            Page[] pages =
           {
                new Page("福建中医药大学","https://www.fjtcm.edu.cn/"),
                new Page("福建中医药大学人文与管理学院","https://gl.fjtcm.edu.cn/"),
                new Page("学院新闻","https://gl.fjtcm.edu.cn/glxy/m_index_1/"),
                new Page("学院党委书记讲授“合力抗疫情，青春话担当”主题思政课","https://gl.fjtcm.edu.cn/glxy/m_index_1/20220505/3072875.html"),
                new Page("福建中医药大学人文与管理学院信息管理与信息系统专业介绍","https://gl.fjtcm.edu.cn/glxy/gjys20140402180855/20190917/43068.html"),


            };
            Pagemanager Pagemanager = new Pagemanager();
            Pagemanager.Open(pages[0]);
            Pagemanager.Open(pages[1]);
            Pagemanager.Open(pages[4]);
            Pagemanager.Back();
            Pagemanager.Open(pages[2]);
            Pagemanager.Open(pages[3]);
            Pagemanager.Back();
            Pagemanager.Back();
            Pagemanager.Advance();

        }
    }
}
