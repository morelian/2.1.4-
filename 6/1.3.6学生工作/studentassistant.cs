using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._3._6学生工作
{/// <summary>
/// 学生助理
/// </summary>
    internal class studentassistant:undergraduate,studentstaff
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
        /// 被投诉次数
        /// </summary>
        public int appeal { set; get; }
        /// <summary>
        /// 考核
        /// </summary>

        public void examine()
        {
            if (this.appeal > 3)
                WriteLine($"{this.name}同学你已经被投诉{this.appeal}次,你将被调换部门!");
            DateTime now = DateTime.Now;
            DateTime want = this.begin.AddMonths(1);
            if (now > want&&this.appeal==0)
            {
                this.pay = this.pay * 1.2;
                WriteLine($"{this.name}同学你好！你在入职的一个月内无投诉,已被提薪%20,目前薪资为{this.pay}元");
            }
        }
        public studentassistant(string num, string name, string sex, DateTime begin, double pay)
            : base(num, name, sex)
        {
            this.begin = begin;
            this.pay = pay;
        }
        /// <summary>
        /// 增加被投诉次数
        /// </summary>
        public void addappeal()
        {
            this.appeal = this.appeal + 1;
            WriteLine($"你以成功增加对{this.name}的投诉一次！");
        }
    }
}
