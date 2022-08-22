using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._4._1教师登分
{/// <summary>
/// 教师
/// </summary>
    internal class Teacher
    {/// <summary>
    /// 工号
    /// </summary>
        public string Num { set; get; }
        /// <summary>
        /// 姓名
        /// </summary>

        public string Name { set; get; }
        /// <summary>
        /// 教学任务
        /// </summary>
        public Teachingtask[] Task { set; get; }
        /// <summary>
        /// 教师构造函数
        /// </summary>
        public Teacher(string num,string name)
        {
            this.Name = name;
            this.Num = num;
        }
        /// <summary>
        /// 添加教学任务
        /// </summary>
        public void addtask()
        {
            WriteLine("请输入要输入的任务数:");
            int n = int.Parse(ReadLine());

            if (this.Task != null)
            {
                Teachingtask[] task = new Teachingtask[n+this.Task.Length];
                int i = 0;
                for (i = 0; i < this.Task.Length; i++)
                    task[i] = this.Task[i];
                for (; i < this.Task.Length+n; i++)
                {
                    WriteLine($"请输入任务{i}学期：");
                    this.Task[i].Term = ReadLine();
                    WriteLine($"请输入任务{i}的课程名称：");
                    this.Task[i].Course.Name = ReadLine();
                    WriteLine($"请输入任务{i}的课程{this.Task[i].Course.Name}的课程号：");
                    this.Task[i].Course.Num = ReadLine();
                    WriteLine($"请输入任务{i}的课程{this.Task[i].Course.Name}的学分：");
                    this.Task[i].Course.Mark = float.Parse(ReadLine());
                }
            }
            else
            {
                Teachingtask[] task = new Teachingtask[n];
                this.Task = task;
                for (int i = 0; i < task.Length; i++)
                {
                    WriteLine($"请输入任务{i}学期：");
                    this.Task[i].Term = ReadLine();
                    WriteLine($"请输入任务{i}的课程名称：");
                    this.Task[i].Course.Name = ReadLine();
                    WriteLine($"请输入任务{i}的课程{this.Task[i].Course.Name}的课程号：");
                    this.Task[i].Course.Num = ReadLine();
                    WriteLine($"请输入任务{i}的课程{this.Task[i].Course.Name}的学分：");
                    this.Task[i].Course.Mark = float.Parse(ReadLine());


                }
            }
        }
        /// <summary>
        /// 输出教学任务
        /// </summary>
       public void puttask()
        {
            for (int i = 0; i < this.Task.Length&&this.Task[i]!=null; i++)
                WriteLine($"教学任务{i}:课程{this.Task[i].Course.Name}学期{this.Task[i].Term}");
        }
        /// <summary>
        /// 添加学生成绩
        /// </summary>
        public void addscore()
        {
            for(int i=0;i<this.Task.Length;i++)
            for (int j = 0; j < this.Task[i].Mark.Length&&this.Task[i].Mark[j]==null; j++)
            {
                WriteLine($"请输入任务{i}的课程{this.Task[i].Course.Name}的第一个学生的成绩：");
                WriteLine($"输入学生学号:");
                this.Task[i].Mark[j].Student.Num = ReadLine();
                WriteLine($"输入学生姓名:");
                this.Task[i].Mark[j].Student.Name = ReadLine();
                WriteLine($"输入学生班级:");
                this.Task[i].Mark[j].Student.Class = ReadLine();
                WriteLine($"输入学生考试状态:");
                this.Task[i].Mark[j].Behavior = ReadLine();
                WriteLine($"输入学生总评成绩:");
                this.Task[i].Mark[j].Score = float.Parse(ReadLine());
                WriteLine($"输入学生平时成绩:");
                this.Task[i].Mark[j].Dailygard = float.Parse(ReadLine());
                WriteLine($"输入学生期末成绩:");
                this.Task[i].Mark[j].Finalgard = float.Parse(ReadLine());
            }
        }
        /// <summary>
        /// 输出学生成绩
        /// </summary>
        public void putscore()
        {
            puttask();
            WriteLine("请选择第几个任务的学生成绩按1选1：");
            int a = int.Parse(ReadLine());
            for(int i =0; i < this.Task[a].Mark.Length; i++)
            {
                WriteLine($"学生学号:{this.Task[a].Mark[i].Student.Num} \n" +
                    $"学生姓名:{this.Task[a].Mark[i].Student.Name} \n" +
                    $"学生班级:{this.Task[a].Mark[i].Student.Class}\n" +
                    $" 学生考试状态:{this.Task[a].Mark[i].Behavior}\n" +
                    $"学生总评成绩:{this.Task[a].Mark[i].Score}\n 学生平时成绩:{this.Task[a].Mark[i].Dailygard} \n" +
                    $" 学生期末成绩:{this.Task[a].Mark[i].Finalgard}");
            }
        }
        /// <summary>
        /// 添加一个任务
        /// </summary>
        public void addone()
        {
            int n = 1;

            if (this.Task != null)
            {
                Teachingtask[] task = new Teachingtask[n + this.Task.Length];
                int i = 0;
                for (i = 0; i < this.Task.Length; i++)
                    task[i] = this.Task[i];
                for (; i < this.Task.Length + n; i++)
                {
                    WriteLine($"请输入任务{i}学期：");
                    this.Task[i].Term = ReadLine();
                    WriteLine($"请输入任务{i}的课程名称：");
                    this.Task[i].Course.Name = ReadLine();
                    WriteLine($"请输入任务{i}的课程{this.Task[i].Course.Name}的课程号：");
                    this.Task[i].Course.Num = ReadLine();
                    WriteLine($"请输入任务{i}的课程{this.Task[i].Course.Name}的学分：");
                    this.Task[i].Course.Mark = float.Parse(ReadLine());
                }
            }
            else
            {
                Teachingtask[] task = new Teachingtask[n];
                this.Task = task;
                for (int i = 0; i < task.Length; i++)
                {
                    WriteLine($"请输入任务{i}学期：");
                    this.Task[i].Term = ReadLine();
                    WriteLine($"请输入任务{i}的课程名称：");
                    this.Task[i].Course.Name = ReadLine();
                    WriteLine($"请输入任务{i}的课程{this.Task[i].Course.Name}的课程号：");
                    this.Task[i].Course.Num = ReadLine();
                    WriteLine($"请输入任务{i}的课程{this.Task[i].Course.Name}的学分：");
                    this.Task[i].Course.Mark = float.Parse(ReadLine());


                }
            }
        }
        /// <summary>
        /// 批量添加学生成绩
        /// </summary>
        public void addmorescor()
        {
            for(int a=0;a<this.Task.Length;a++)
            for (int i = 0; i < this.Task[a].Mark.Length&& this.Task[a].Mark[i]==null; i++)
            {
                WriteLine($"学生学号:{this.Task[a].Mark[i].Student.Num} \n" +
                    $"学生姓名:{this.Task[a].Mark[i].Student.Name} \n" +
                    $"学生班级:{this.Task[a].Mark[i].Student.Class}\n" +
                    $" 学生考试状态:{this.Task[a].Mark[i].Behavior}\n" +
                    $"学生总评成绩:{this.Task[a].Mark[i].Score}\n 学生平时成绩:{this.Task[a].Mark[i].Dailygard} \n" +
                    $" 学生期末成绩:{this.Task[a].Mark[i].Finalgard}");
            }
        }
    }
}
