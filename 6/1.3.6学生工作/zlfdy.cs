using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._3._6学生工作
{
    internal class zlfdy:graduatingundergraduate,studentstaff
    {/// <summary>
     /// 起聘时间
     /// </summary>
        public DateTime begin { set; get; }
        /// <summary>
        /// 工资
        /// </summary>
        public double pay { set; get; }
        public zlfdy(string num, string name, string sex,double pay,string[] manage)
             : base(num, name, sex)
        {
            this.pay = pay;
            this.manage = manage;
        }

        /// <summary>
        /// 班级奖惩记录
        /// </summary>
        public string[] manage { set; get; }

        public void appoint()
        {
            WriteLine($"助理辅导员{this.name},你好!你已被分配管理2021信息管理与信息系统班!");
        }

        public void examine()
        {
            int count = 0;
            for(int i = 0; i < manage.Length; i++)
            {
                if (manage[i] == "处分")
                {
                    this.pay = this.pay * 0.8;
                    break;
                    WriteLine($"辅导员助理{this.name}你好你的奖惩记录中有处分,已被减薪%20,目前薪资为{this.pay}元");
                }
                count++;
            }
            for (int i = 0; i < manage.Length; i++)
            {
                if (count == manage.Length&&manage[i]=="奖励")
                    this.pay = this.pay * 1.2;
                WriteLine($"辅导员助理{this.name}你好！你的奖惩记录中无处分并有奖励,已被涨薪%20,目前薪资为{this.pay}元");
                break;
            }
        }
    }
}
