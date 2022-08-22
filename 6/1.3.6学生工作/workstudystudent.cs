using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._3._6学生工作
{
    /// <summary>
    /// 考核状态
    /// </summary>
    public class Exam
    {
        public static readonly string YX = "优秀";
        public static readonly string HG = "合格";
        public static readonly string BJG = "不及格";
    }

    /// <summary>
    /// 勤工俭学学生
    /// </summary>
    internal class workstudystudent : undergraduate, studentstaff
    {
        /// <summary>
        /// 起聘时间
        /// </summary>
        public DateTime begin { set; get; }
        /// <summary>
        /// 工资
        /// </summary>
        public double pay { set; get; }
        /// <summary>
        /// 考核状态
        /// </summary>
        public string exam { set; get; }
        /// <summary>
        /// 考核
        /// </summary>

       public void examine()
        {
            WriteLine("请输入考核状态(1为优秀,2为合格,3为不及格):");
            string a = ReadLine();
            if (a == "1")
                this.exam = Exam.YX;
            if (a == "2")
                this.exam = Exam.HG;
            if (a == "3")
                this.exam = Exam.BJG;
            if (this.exam == "优秀")
            {
                this.pay = this.pay * 1.2;
                WriteLine($"{this.name}同学你好！你的考核状态为优秀,已被提薪%20,目前薪资为{this.pay}元");
            }
            if (this.exam == "不合格")
            {


                this.pay = this.pay * 0.8;
                WriteLine($"{this.name}同学你好！你的考核状态为不及格,已被减薪%20,目前薪资为{this.pay}元");
            }
        }
        public workstudystudent(string num, string name, string sex,DateTime begin ,double pay)
            :base(num,name,sex)
        {
            this.begin = begin;
            this.pay = pay;
        }
    } 
}
