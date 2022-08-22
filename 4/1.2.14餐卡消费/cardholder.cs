using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2._14餐卡消费
{
    public partial class cardholder
    {
        /// <summary>
        /// 学号
        /// </summary>
        public string num { set; get; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string name { set; get; }
        /// <summary>
        /// 密码
        /// </summary>
        public string codon { set; get; }
            /// <summary>
            /// 余额
            /// </summary>
        public float balance { set; get; }

        /// <summary>
        /// 补贴余额
        /// </summary>
        public float subsidybalance { set; get; }
        /// <summary>
        /// 充值
        /// </summary>
        /// <param name="money">充值金额</param>
        public void investmoney(float money)
        {
            this.balance = this.balance + money;
            WriteLine($"{this.name}同学的余额为:{this.balance}元");
        }
        /// <summary>
        /// 补贴
        /// </summary>
        /// <param name="money">补贴金额</param>
        public void subsize(float money)
        {
            this.subsidybalance = this.subsidybalance + money;
            if (this.subsidybalance > 100)
                this.subsidybalance = 100;
            WriteLine($"{this.name}同学的补贴余额为:{this.subsidybalance}元");
        }
        /// <summary>
        /// 持卡人构造函数
        /// </summary>
        /// <param name="num">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="codan">密码</param>
        /// <param name="balance">余额</param>
        /// <param name="subsibalance">补贴余额</param>
        public cardholder(string num,string name,string codon,float balance,float subsibalance)
        {
            this.balance = balance;
            this.num = num;
            this.codon = codon;
            this.name = name;
            this.subsidybalance = subsibalance;
        }
    }
}
