using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._4._2教师登分
{
    public class Program
    {
        static void Main(string[] args)
        {
            Course Course1 = new Course("1","面向对象程序设计",float.Parse("5"));
             Course Course2 = new Course("2","数据结构",float.Parse("5"));
             Course Course3 = new Course("3","计算机网络",float.Parse("5"));
            Student Student1 = new Student("3210707001", "沐兰", "21im");
            Student Student2 = new Student("3210707002", "苏汐", "21im");
            Student Student3 = new Student("3210707003", "苏雯烟", "21im");
            Student Student4 = new Student("3210707004", "苏韵", "21im");
            Student Student5 = new Student("3210707005", "苏嫣然", "21im");
            Studentachievement[] mark =
            {
                new Studentachievement("正常",float.Parse("90"),float.Parse("90"),float.Parse("90"),Student1),
             new Studentachievement("正常",float.Parse("90"),float.Parse("90"),float.Parse("90"),Student2),
            new Studentachievement("正常",float.Parse("90"),float.Parse("90"),float.Parse("90"),Student3),
            new Studentachievement("正常",float.Parse("90"),float.Parse("90"),float.Parse("90"),Student4),
            new Studentachievement("正常",float.Parse("90"),float.Parse("90"),float.Parse("90"),Student5)
            };
            Teachingtask[] task =
            {
                new Teachingtask(int.Parse("2022"),mark,Course1),
                new Teachingtask(int.Parse("2021"),mark,Course2),
                new Teachingtask(int.Parse("2020"),mark,Course3),
                new Teachingtask(int.Parse("2023"),mark,Course1),
                new Teachingtask(int.Parse("2025"),mark,Course2),
                new Teachingtask(int.Parse("2024"),mark,Course3),
            };
            Teacher Teacher=new Teacher("林立","321001",task);
              Array.Sort(Teacher.Task);                                           
          
            for(int i = 0; i <Teacher.Task.Length; i++)
            {
              
                WriteLine($"学期:{ Teacher.Task[i].Term} 课程:{ Teacher.Task[i].Course.Name}");
            }
        }
    }
}
