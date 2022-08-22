using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._7._3课程管理
{/// <summary>
/// 教学计划
/// </summary>
    public class Teachingprogram
    {
        /// <summary>
        /// 学期
        /// </summary>
        public string Term { set; get; }
        /// <summary>
        /// 课程数目
        /// </summary>
        public int Coursenum
            => this.Courses.Count;
        /// <summary>
        /// 课程
        /// </summary>
       public List<Course> Courses = new List<Course>();
        /// <summary>
        /// 输出所有课程
        /// </summary>
        public void Display()
        {
            if (this.Courses != null)
            {
            foreach(Course Courses in this.Courses)
                {
                    if(!(Courses is null))
                    WriteLine($"名称：{Courses.Name} 课程号：{Courses.Num} 任课教师：{Courses.Teacher} 学分：{Courses.Score} 课时：{Courses.Time} 类别：{Courses.Type}");   
                }
            }
        }
        /// <summary>
        /// 添加课程
        /// </summary>
        public void Addcourse(Course course)
        {
            if (!this.Courses.Contains(course))
            {
                this.Courses.Add(course);
                WriteLine($"已添加课程：{course.Name}");
            }
            else WriteLine($"已有课程：{course.Name}请勿重新添加");
        }
        /// <summary>
        /// 添加多门课程
        /// </summary>
        /// <param name="courses"></param>
        public void Addcourses(List<Course> courses)
        {
            int num = 0;
                foreach(Course course in courses)
                {
                if (!this.Courses.Contains(course))
                {
                    this.Courses.Add(course); num++;
                }
            }
            WriteLine($"添加结束！已添加了{num}门课程！");
        }
        /// <summary>
        /// 删除指定课程
        /// </summary>
        /// <param name="num">课程号</param>
        public void Delect(string num)
        {

            if (this.Courses.Remove(new Course(num)))
            {
                WriteLine("删除成功余下所有课程如下！");
            }
            else WriteLine("未查找到！所有课程如下！");
            
            this.Display();
        }
       /// <summary>
       /// 删除符合指定条件的所有课程
       /// </summary>
        public void Delects()
        {
         
            WriteLine("选择你所需要的条件:\n" +
                "1.课程名称2.课程关键字3.课程号4.学分等于5.学分小于6.学分大于7.类别8.任课教师9.课时:");
            int choose = int.Parse(ReadLine());
            if (choose == 1)
            {
                WriteLine("课程名称：");
                string name = ReadLine();
                this.Courses.RemoveAll(s => s.Name == name);
            }
            else if (choose == 2)
            {
                WriteLine("课程名称关键字：");
                string name = ReadLine();
                this.Courses.RemoveAll(s => s.Name.Contains(name));
            }
           else if (choose == 3)
            {
                WriteLine("课程号：");
                string num = ReadLine();
                this.Courses.RemoveAll(s => s.Num == num);
            }
          else  if (choose == 4)
            {
                WriteLine("学分等于：");
                float score1 = float.Parse(ReadLine());
                this.Courses.RemoveAll(s => s.Score == score1);
            }
          else  if (choose == 5)
            {
                WriteLine("学分小于：");
                float score2 = float.Parse(ReadLine());
                this.Courses.RemoveAll(s => s.Score <= score2);
            }
          else  if (choose == 6)
            {
                WriteLine("学分大于：");
                float score3 = float.Parse(ReadLine());
                this.Courses.RemoveAll(s => s.Score >= score3);
            }
           else if (choose == 7)
            {
                WriteLine("类别：");
                string type = ReadLine();
                this.Courses.RemoveAll(s => s.Type == type);
            }
            else if (choose == 8)
            {
                WriteLine("任课教师：");
                string teacher = ReadLine();
                this.Courses.RemoveAll(s => s.Teacher == teacher);
            }
            else if (choose == 9)
            {
                WriteLine("课时：");
                int time = int.Parse(ReadLine());
                this.Courses.RemoveAll(s => s.Time == time);
            }
            else
            {
                WriteLine("输入错误!");
                return;
            }
            WriteLine("删除完成!余下课程如下:");
            this.Display();
        }
        /// <summary>
        /// 查找指定课程号的课程
        /// </summary>
        public void Find(string num)
        {
            Course Course= this.Courses.Find(s=>s.Num==num);
            if (!(Course is null))
                WriteLine($"名称：{Course.Name} 课程号：{Course.Num} 任课教师：{Course.Teacher} 学分：{Course.Score} 课时：{Course.Time} 类别：{Course.Type}");
            else WriteLine("未查找到！");
        }
        /// <summary>
        /// 查找符合条件的所有课程
        /// </summary>
        public void Findall()
        {
            WriteLine("选择你所需要的条件:\n" +
                "1.课程名称2.课程名称的关键字3.课程号4.学分等于5.学分小于6.学分大于7.类别8.任课老师9.课时：");
            int choose = int.Parse(ReadLine());
            if (choose == 1)
            {
                WriteLine("课程名称：");
                string name = ReadLine();
                this.Courses.FindAll(s => s.Name == name).ForEach(s => WriteLine($"" +
                    $"课程号：{s.Num} 名称：{s.Name} 任课教师：{s.Teacher} 学分：{s.Score} 类别：{s.Type}"));
            }
            else if (choose == 2)
            {
                WriteLine("名称：");
                string name = ReadLine();
                this.Courses.FindAll(s => s.Name.Contains(name)).ForEach(s => WriteLine($"" +
                    $"课程号：{s.Num} 名称：{s.Name} 任课教师：{s.Teacher} 学分：{s.Score} 类别：{s.Type}"));
            }
            else if (choose == 3)
            {
                WriteLine("课程号：");
                string num = ReadLine();
                this.Courses.FindAll(s => s.Num == num).ForEach(s => WriteLine($"" +
                    $"课程号：{s.Num} 名称：{s.Name} 任课教师：{s.Teacher} 学分：{s.Score} 课时：{s.Time} 类别：{s.Type}"));
            }
            else if (choose == 4)
            {
                WriteLine("学分等于：");
                float score1 = float.Parse(ReadLine());
                this.Courses.FindAll(s => s.Score == score1).ForEach(s => WriteLine($"" +
                    $"课程号：{s.Num} 名称：{s.Name} 任课教师：{s.Teacher} 学分：{s.Score} 课时：{s.Time} 类别：{s.Type}"));
            }
            else if (choose == 5)
            {
                WriteLine("学分小于：");
                float score2 = float.Parse(ReadLine());
                this.Courses.FindAll(s => s.Score <= score2).ForEach(s => WriteLine($"" +
                    $"课程号：{s.Num} 名称：{s.Name} 任课教师：{s.Teacher} 学分：{s.Score} 课时：{s.Time} 类别：{s.Type}"));
            }
            else if (choose == 6)
            {
                WriteLine("学分大于：");
                float score3 = float.Parse(ReadLine());
                this.Courses.FindAll(s => s.Score >= score3).ForEach(s => WriteLine($"" +
                    $"课程号：{s.Num} 名称：{s.Name} 任课教师：{s.Teacher} 学分：{s.Score} 课时：{s.Time} 类别：{s.Type}"));
            }
            else if (choose == 7)
            {
                WriteLine("类别：");
                string type = ReadLine();
                this.Courses.FindAll(s => s.Type == type).ForEach(s => WriteLine($"" +
                    $"课程号：{s.Num} 名称：{s.Name} 任课教师：{s.Teacher} 学分：{s.Score} 课时：{s.Time} 类别：{s.Type}"));
            }
            else if (choose == 8)
            {
                WriteLine("任课教师：");
                string teacher = ReadLine();
                this.Courses.FindAll(s => s.Teacher == teacher).ForEach(s => WriteLine($"" +
                    $"课程号：{s.Num} 名称：{s.Name} 任课教师：{s.Teacher} 学分：{s.Score} 课时：{s.Time} 类别：{s.Type}"));
            }
            else if (choose == 9)
            {
                WriteLine("课时：");
                int time = int.Parse(ReadLine());
                this.Courses.FindAll(s => s.Time == time).ForEach(s => WriteLine($"" +
                    $"课程号：{s.Num} 名称：{s.Name} 任课教师：{s.Teacher} 学分：{s.Score} 课时：{s.Time} 类别：{s.Type}"));
            }
            else
            {
                WriteLine("输入错误!");
                return;
            }
        }
        /// <summary>
        /// 排序
        /// </summary>
        public void Sortall()
        {
            WriteLine("选择你所需要的条件：\n" +
                "1.按学分从大到小排序2.按学分从小到大排序3.按课程名称排序4.按课程号排序5.按类别排序6.按任课教师7.课时:");
            int choose = int.Parse(ReadLine());
            if (choose == 1)
            {
                this.Courses.Sort((s, s2) => s.Score.CompareTo(s2.Score));
                this.Display();
            }
            if (choose == 2)
            {
                this.Courses.Sort((s, s2) => s.Score.CompareTo(s2.Score));
                this.Courses.Reverse();
                this.Display();
            }
            if (choose == 3)
            {
                this.Courses.Sort((s, s2) => s.Name.CompareTo(s2.Name));
                this.Display();
            }
            if (choose == 4)
            {
                this.Courses.Sort((s, s2) => s.Num.CompareTo(s2.Num));
                this.Display();
            }
            if (choose == 5)
            {
                this.Courses.Sort((s, s2) => s.Type.CompareTo(s2.Type));
                this.Display();
            }
            else if (choose == 6)
            {
                this.Courses.Sort((s, s2) => s.Teacher.CompareTo(s2.Teacher));
                this.Display();
            }
            else if (choose == 7)
            {
                this.Courses.Sort((s, s2) => s.Time.CompareTo(s2.Time));
                this.Display();
            }
            else
            {
                WriteLine("输入错误!");
                return;
            }

        }
        /// <summary>
        /// 教学任务构造函数
        /// </summary>
        public Teachingprogram()
        {

        }
        /// <summary>
        /// 课程任务构造函数
        /// </summary>
        /// <param name="term">学期</param>
        /// <param name="courses">课程</param>
        public Teachingprogram(string term,List<Course> courses)
        {
            this.Courses = courses;
            this.Term = term;
        }

    }
}
