using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._4._1教师登分
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("001", "沐兰");
            Course[] course =
            {
                new Course("001","面向对象程序设计",float.Parse("5")),
                new Course("002","数据结构",float.Parse("5")),
                new Course("003","计算机网络",float.Parse("5"))
             };
            Student Student1 = new Student("3210707005", "沐兰", "21im");
            Student Student2 = new Student("3210707004", "苏汐", "21im");
            Student Student3 = new Student("3210707003", "苏雯烟", "21im");
            Student Student4 = new Student("3210707002", "苏韵", "21im");
            Student Student5 = new Student("3210707001", "苏嫣然", "21im");
            Studentmark[] mark =
            {
                new Studentmark("正常",float.Parse("90"),float.Parse("90"),float.Parse("90"),Student1),
             new Studentmark("正常",float.Parse("90"),float.Parse("90"),float.Parse("90"),Student2),
            new Studentmark("正常",float.Parse("90"),float.Parse("90"),float.Parse("90"),Student3),
            new Studentmark("正常",float.Parse("90"),float.Parse("90"),float.Parse("90"),Student4),
            new Studentmark("正常",float.Parse("90"),float.Parse("90"),float.Parse("90"),Student5)
            };
            Teachingtask[] task =
{
                new Teachingtask("2022-2023学年",course[0],mark),
                new Teachingtask("2021-2022学年",course[1],mark),
                new Teachingtask("2020-2021学年",course[2],mark)

            };
            teacher.Task = task;
            Array.Sort(teacher.Task);
            for (int i = 0; i < teacher.Task.Length; i++)
            {
                if(teacher.Task[i]!=null)
                WriteLine($"{teacher.Task[i].Term}{teacher.Task[i].Course.Name}");
            }
            Array.Sort(teacher.Task, new TeachingtaskCompare(TeachingtaskCompare.CompareType.COURSE));
            for (int i = 0; i < teacher.Task.Length; i++)
            {
                if (teacher.Task[i] != null)
                    WriteLine($"{teacher.Task[i].Term}{teacher.Task[i].Course.Name}");
            }
        }
    }
}
