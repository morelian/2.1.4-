using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._7._3课程管理
{
    public static class PlanUI
    {
        public static void UI()
        {
            List<Course> Courses = new List<Course>
            {
                new Course("面向对象程序设计","001",float.Parse("5"),"林立",48,"程序设计"),
                new Course("数据结构","002",float.Parse("5"),"张翠萍",48,"程序设计"),
                new Course("数据库原理","006",float.Parse("5"),"陈林",38,"程序设计"),
                new Course("线性代数","003",float.Parse("5"),"洪全兴",38,"公选课"),
                new Course("英语","004",float.Parse("5"),"张婷",40,"公选课"),
                new Course("中医学","005",float.Parse("5"),"温正恩",48,"公选课"),
                new Course("C程序设计","021",float.Parse("5"),"张翠萍",48,"程序设计"),
                new Course("高数","009",float.Parse("5"),"陈炜炜",40,"公选课"),
                new Course("计算机导论","010",float.Parse("5"),"刘闽碧",38,"公选课"),
                new Course("职业生涯与规划","017",float.Parse("3"),"柯龙山",24,"公选课"),
                new Course("军事理论","018",float.Parse("3"),"张艺腾",24,"公选课"),
                new Course("思想道德与政治","019",float.Parse("5"),"王凯旋",36,"公选课"),
                new Course("大学生心理健康","077",float.Parse("5"),"张研铭",30,"公选课"),
                new Course("中国近代史纲要","097",float.Parse("5"),"刘晶晶",30,"公选课"),
                new Course("计算机网络","063",float.Parse("5"),"陈林",48,"公选课"),

            };
            List<Course> Courses1 = new List<Course>
            {
                new Course("Java程序设计","079",float.Parse("5"),"沐兰",48,"程序设计"),
                new Course("C++程序设计","022",float.Parse("4.5"),"苏汐",48,"程序设计"),
                new Course("离散型数学","044",float.Parse("6"),"苏雯烟",40,"公选课"),
                new Course("英语六级通过指导","065",float.Parse("2.5"),"沐兰",38,"选修课"),
                 new Course("人体解剖","068",float.Parse("3.5"),"苏汐",26,"选修课")
            };
            Teachingprogram Plan = new Teachingprogram("2021-2022学年", Courses);
            Plan.Display();
            Plan.Courses.FindAll(s => s.Name.Contains("课程设计")).ForEach(s => WriteLine($"" +
                    $"课程号：{s.Num} 名称：{s.Name} 任课教师：{s.Teacher} 学分：{s.Score} 课时：{s.Time} 类别：{s.Type}"));
            Plan.Courses.FindAll(s => s.Score>=4).ForEach(s => WriteLine($"" +
                   $"课程号：{s.Num} 名称：{s.Name} 任课教师：{s.Teacher} 学分：{s.Score} 课时：{s.Time} 类别：{s.Type}"));
            Plan.Courses.FindAll(s => s.Teacher == "林立").ForEach(s => WriteLine($"" +
                   $"课程号：{s.Num} 名称：{s.Name} 任课教师：{s.Teacher} 学分：{s.Score} 课时：{s.Time} 类别：{s.Type}"));
            Plan.Courses.Sort((s, s2) => s.Num.CompareTo(s2.Num));
                Plan.Display();
            while (true)
            {
                WriteLine($"请选择功能：\n" +
                    $"1.显示所有课程2.添加一门课程3.添加多门课程4.删除一门课程\n" +
                    $"5.删除多门课程6.查找指定课程号的课程7.查找符合条件的所有课程8.排序");
                int a = int.Parse(ReadLine());
                if (a == 1)
                    Plan.Display();
                if (a == 2)
                {
                    Course course = new Course();
                    WriteLine($"输入课程号：");
                    course.Num = ReadLine();
                    WriteLine("输入课程名称：");
                    course.Name = ReadLine();
                    WriteLine("输入学分：");
                    course.Score = float.Parse(ReadLine());
                    WriteLine("输入类别：");
                    course.Type = ReadLine();
                    WriteLine("输入课时:");
                    course.Time = int.Parse(ReadLine());
                    Plan.Addcourse(course);
                }
                if (a == 3)
                {
                    Plan.Addcourses(Courses1);
                }
                if (a == 4)
                {
                    WriteLine("输入课程号");
                    string num = ReadLine();
                    Plan.Delect(num);
                }
                if (a == 5)
                {
                    Plan.Delects();
                }
                if (a == 6)
                {
                    WriteLine("输入课程号");
                    string num = ReadLine();
                    Plan.Find(num);
                }
                if (a == 7)
                {
                    Plan.Findall();
                }
                if (a == 8)
                {
                    Plan.Sortall();
                }


            }
        }
    }
}
