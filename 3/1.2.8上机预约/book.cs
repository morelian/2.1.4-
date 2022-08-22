using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2._8上机预约
{
    internal class book
    {
        public student student { set; get; }
        public project project { set; get; }
        public DateTime begin { set; get; }
        public string time { get; set; }
        public book(student student)
        {
            this.student = student;
            DateTime dStart = DateTime.Now.Date;
            this.begin = DateTime.Parse(dStart.ToString("yyyy-MM-dd 20:00:00"));//转成字符串
            this.time = "1小时";
        }
        public book(student student, project project, DateTime begin, string time)
        {
            this.student = student;
            this.project = project;
            this.begin = begin;
            this.time = time;
        }
        public void Out()
        {
            WriteLine($"学生姓名:{this.student.name,-16}学生学号:{this.student.num}\n" +
                $"课程名称:{this.project.course,-16}实验项目:{this.project.text}\n" +
                $"起始时间:{this.begin,-16}  时长:{this.time}");
        }
    }
    
}
