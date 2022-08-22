using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2._16学生评教
{
    internal class student
    {/// <summary>
     /// 学号
     /// </summary>
        public string num { set; get; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string name { set; get; }
        /// <summary>
        /// 课程成绩
        /// </summary>
        public courseMath[] courseMath { set; get; }
        /// <summary>
        /// 评教时限
        /// </summary>
        public DateTime time { set; get; }
        public student(string num, string name,courseMath[] c, DateTime t){
            this.name = name;
            this.num = num;
            this.courseMath = c;
            this.time = t;
            }
        /// <summary>
        /// 评教
        /// </summary>
        public void elavluable()
        {
            for (int i = 0; i < this.courseMath.Length; i++)
            {
                WriteLine($"课程名称:{this.courseMath[i].course.name} 课程成绩:{this.courseMath[i].math}");
            }
            DateTime now = DateTime.Now;
            if (now < this.time)
            {
                for (int i = 0; i < this.courseMath.Length; i++)
                {
                    WriteLine($"请输入对{this.courseMath[i].course.name}的评分:");
                    this.courseMath[i].mark = float.Parse(ReadLine());
                    while (this.courseMath[i].mark < 0 || this.courseMath[i].mark > 10)
                    {
                        WriteLine("评教分数应在0~10分之内,请重新输入:");
                        this.courseMath[i].mark = float.Parse(ReadLine());
                    }

                    WriteLine($"请输入对{this.courseMath[i].course.name}的评语:");
                    this.courseMath[i].commentteaching = ReadLine();
                    WriteLine($"已将评教结果发送到{ this.courseMath[i].teacher.name}的电子邮箱,邮箱号为:{ this.courseMath[i].teacher.email}\n" +
                        $"教师电话号码:{ this.courseMath[i].teacher.telephone,-12}\n");
                    this.courseMath[i].whether = true;
                }
            }
            else
            {
                WriteLine("以超出评教时限，请联系老师！");
            }

        }
        /// <summary>
        /// 查询成绩
        /// </summary>
        public void search()
        {


            for (int i = 0; i < this.courseMath.Length; i++)
            {
                WriteLine($"按{i}选选择查询{this.courseMath[i].course.name}");
            }
            int j = int.Parse(ReadLine());
            if (this.courseMath[j].commentteaching != null && this.courseMath[j].math != -1)
            {
                WriteLine($"{this.courseMath[j].course.name}\n成绩:{this.courseMath[j].math}分\n" +
                    $"学分:{this.courseMath[j].course.credit}");
            }
            else {
                WriteLine($"{this.name}同学你未评教或者此课成绩未出!");
            }

        }


    }
}
