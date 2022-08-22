using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2._11新生入学
{
    public class political
    {
        public static readonly string QUN = "群众";                                         //定义静态只读字段并初始化；
        public static readonly string TUAN = "团员";
        public static readonly string DAN = "党员";
    }
    internal class student
    {
        public string name { set; get; }
        public string num { set; get; }
        public string political { set; get; }
        public void ShowInfo()
        {
            var info =
                $"新生信息：\n" +
                $"学号：{this.num,-15}姓名：{this.name}\n" +
                $"民族：{this.political}\n";
            WriteLine(info);
        }
        public student(string number, string name)
        {
            this.num = number;
            this.name= name;
        }
    }

}
