using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._4._2教师登分
{/// <summary>
/// 教师
/// </summary>
    public class Teacher
    {

        private int count { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
     public string Num { set; get; }
        /// <summary>
        /// 教学任务
        /// </summary>
        public Teachingtask[] Task { set; get; }
            /// <summary>
            /// 名字
            /// </summary>
        public string Name { set; get; }
        ///构造函数
        public Teacher()
        {
            this.Name = string.Empty;
            this.Num = string.Empty;
            this.Task = new Teachingtask[1];
            this.Task[0] = new Teachingtask();
            this.count = 0;
        }
        ///构造函数
        public Teacher(string name,string num,Teachingtask[] task)
        {
            this.Name = name;
            this.Num = num;
            this.Task = task;
            this.count = 0;
        }
     public void Addtask()
        {
            if (this.count >= this.Task.Length)
            {
                Teachingtask[] task = new Teachingtask[this.count*2];
                this.Task.CopyTo(task,0);
                this.Task=Task;
            }
            WriteLine("请输入任务的学期(如2020）:");
            this.Task[++count].Term=int.Parse(ReadLine());
            WriteLine("请输入课程号：");
            this.Task[count].Course.Num=ReadLine(); 
            WriteLine("请输入课程名称:");
                this.Task[count].Course.Name=ReadLine();
            WriteLine("请输入课程学分:");
            this.Task[count].Course.Score=float.Parse(ReadLine());
            WriteLine("请输入学生人数：");
            int n=int.Parse(ReadLine());
            this.Task[count].Mark=new Studentachievement[n];
            for(int i=0;i<n;i++)
                this.Task[count].Mark[i]=new Studentachievement();
            for (int i = 0; i < n; i++)
            {
                WriteLine($"输入第{i}个学生的学号:");
                this.Task[count].Mark[i].Student.Num = ReadLine();
                WriteLine($"输入第{i}个学生的姓名:");
                this.Task[count].Mark[i].Student.Name = ReadLine();
                WriteLine($"输入第{i}个学生的班级:");
                this.Task[count].Mark[i].Student.Class = ReadLine();
                WriteLine($"输入第{i}个学生的考试状态:");
                this.Task[count].Mark[i].Behavior = ReadLine();
                WriteLine($"输入第{i}个学生的平时成绩:");
                this.Task[count].Mark[i].Usualgrade = float.Parse(ReadLine());
                 WriteLine($"输入第{i}个学生的期末成绩:");
                this.Task[count].Mark[i].Finalgrade= float.Parse(ReadLine());
                WriteLine($"输入第{i}个学生的总评成绩:");
                this.Task[count].Mark[i].overevaluationresult= float.Parse(ReadLine());

            }
            WriteLine("输入完成!");
        }
         public void Addtasks()
        {WriteLine("请输入要添加的任务的数量：");
            int num=int.Parse(ReadLine());
            if (this.count+num >= this.Task.Length&&(this.count>num))
            {
                Teachingtask[] task = new Teachingtask[this.count*2];
                this.Task.CopyTo(task,0);
                this.Task=Task;
            }
             else  if (this.count+num >= this.Task.Length&&(this.count<=num))
            {
                Teachingtask[] task = new Teachingtask[num*2];
                this.Task.CopyTo(task,0);
                this.Task=Task;
            }for(int j = count; j < count + num; j++) { 
            WriteLine("请输入任务的学期(如2020）:");
            this.Task[++count].Term=int.Parse(ReadLine());
            WriteLine("请输入课程号：");
            this.Task[count].Course.Num=ReadLine(); 
            WriteLine("请输入课程名称:");
                this.Task[count].Course.Name=ReadLine();
            WriteLine("请输入课程学分:");
            this.Task[count].Course.Score=float.Parse(ReadLine());
            WriteLine("请输入学生人数：");
            int n=int.Parse(ReadLine());
            this.Task[count].Mark=new Studentachievement[n];
            for(int i=0;i<n;i++)
                this.Task[count].Mark[i]=new Studentachievement();
            for(int i=0;i<n; i++)
            {
                WriteLine($"输入第{i}个学生的学号:");
                this.Task[count].Mark[i].Student.Num=ReadLine();
                WriteLine($"输入第{i}个学生的姓名:");
                this.Task[count].Mark[i].Student.Name=ReadLine();
                 WriteLine($"输入第{i}个学生的班级:");
                 this.Task[count].Mark[i].Student.Class=ReadLine();
                 WriteLine($"输入第{i}个学生的考试状态:");
                this.Task[count].Mark[i].Behavior=ReadLine();
                 WriteLine($"输入第{i}个学生的平时成绩:");
                this.Task[count].Mark[i].Usualgrade= float.Parse(ReadLine());
                    WriteLine($"输入第{i}个学生的期末成绩:");
                this.Task[count].Mark[i].Finalgrade= float.Parse(ReadLine());
                    WriteLine($"输入第{i}个学生的总评成绩:");
                this.Task[count].Mark[i].overevaluationresult= float.Parse(ReadLine());

                }
            }
            WriteLine("输入完成!");
        }
        ///
        public void Puttask()
        {
            for(int i=0;i<this.count;i++)
            {
                WriteLine($"学期{this.Task[i].Term}学科号:{this.Task[i].Course.Num}学科名称:{this.Task[i].Course.Name}");
            }
            }

        public void Putscore()
        {
             for(int i=0;i<this.count;i++)
            {
                WriteLine($"学期{this.Task[i].Term}学科号:{this.Task[i].Course.Num}学科名称:{this.Task[i].Course.Name}");
                WriteLine($"学生成绩:");
                for(int j = 0; j < this.Task[i].Mark.Length; j++){
                WriteLine($"学生学号:{this.Task[i].Mark[j].Student.Num}");
                WriteLine($"学生姓名:{this.Task[i].Mark[j].Student.Name}");
                WriteLine($"学生班级:{this.Task[i].Mark[j].Student.Class}");
                WriteLine($"平时成绩:{this.Task[i].Mark[j].Usualgrade}");
                 WriteLine($"期末成绩:{this.Task[i].Mark[j].Finalgrade}");
                 WriteLine($"总评成绩:{this.Task[i].Mark[j].overevaluationresult}");
            }
        }
        }

    } 
}
