using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2._14餐卡消费
{
    public partial class cardholder
    {/// <summary>
    /// 大额上限
    /// </summary>
        public int mainunm
            => 50;
        /// <summary>
        /// 每日消费上限
        /// </summary>
        public int spendmax
            => 100;
        /// <summary>
        /// 今日已消费金额
        /// </summary>
        public float coasted { set; get; }
        /// <summary>
        /// 消费
        /// </summary>
        /// <param name="money">本次消费的金额</param>
        public void spend(float money)
        {
            if (money > 50)
            {
                WriteLine("你本次消费大于50元需要输入密码:");
                string a = ReadLine();
                int times = 1;
                while (a!=this.codon&&times<6) {
                    if (times < 5)
                    {
                        WriteLine($"密码输入错误请重新输入!" +
                            $"你还有{(5 - times)}次的输入机会，若全错你的卡将会被锁定，需要到教务处开卡!");
                        times = times + 1;
                    }
                    else
                    {
                        WriteLine("你已经连续输入输入错误5次,卡已经被锁定不能消费,请到教务处开卡!");
                        times = times + 1;
                    }
                    a = ReadLine();
                }
                if (a == this.codon) { 
                this.coasted = this.coasted + money;
                if (this.coasted > spendmax)
                {
                    WriteLine($"你今天已经消费{(this.coasted - money)}元，加上这次的{money}元，你将超额!所以本次消费失败!");
                    this.coasted = this.coasted - money;
                }
                    if (this.subsidybalance >= money)
                    {
                        this.subsidybalance = this.subsidybalance - money;
                        WriteLine($"消费成功!,你的余额现在为:{this.balance}元,补贴余额为:{this.subsidybalance}元\n");
                        this.coasted = this.coasted + money;
                    }
                    else
                    {
                        if (this.balance + this.subsidybalance < money)
                            WriteLine("余额不足!");
                        else
                        {
                            money = money - this.subsidybalance;
                            this.balance = this.balance - money;
                            this.subsidybalance = 0;
                            WriteLine($"消费成功!,你的余额现在为:{this.balance}元,补贴余额为:{this.subsidybalance}元\n");
                            this.coasted = this.coasted + money;
                        }
                    }
                }
            }
            else
            {
                this.coasted = this.coasted + money;
                if (this.coasted > spendmax)
                {
                    WriteLine($"你今天已经消费{(this.coasted - money)}元，加上这次的{money}元，你将超额!所以本次消费失败!");
                    this.coasted = this.coasted - money;
                }
                if (this.subsidybalance >= money)
                {
                    this.subsidybalance = this.subsidybalance - money;
                    WriteLine($"消费成功!,你的余额现在为:{this.balance}元,补贴余额为:{this.subsidybalance}元\n");
                    this.coasted = this.coasted + money;
                }
                else
                {
                    if (this.balance + this.subsidybalance < money)
                        WriteLine("余额不足!");
                    else
                    {
                        money = money - this.subsidybalance;
                        this.balance = this.balance - money;
                        this.subsidybalance = 0;
                        WriteLine($"消费成功!,你的余额现在为:{this.balance}元,补贴余额为:{this.subsidybalance}元\n");
                        this.coasted = this.coasted + money;
                    }
                }
            }
        }
        /// <summary>
        /// 修改密码
        /// </summary>
public void changecodon()
        {
            WriteLine("请输入原密码:");
            string a = ReadLine();
            if (a == this.codon)
            {
                WriteLine("请输入新密码:");
                WriteLine("请再次输入新密码:");
                string b = ReadLine();
                while (b != a)
                {
                    WriteLine("两次输入不一样请重新输入!");
                    b = ReadLine();
                }
                if (a == b)
                {
                    WriteLine("密码修改成功!");
                    this.codon = a;
                }
            }
            if (a != this.codon)
            {
                WriteLine("密码输入错误,请重新输入!");
                while (a != this.codon)
                {
                    a = ReadLine();
                    if (a != this.codon)
                        WriteLine("密码输入错误,请重新输入!");
                    else
                    {
                        WriteLine("请输入新密码:");
                        WriteLine("请再次输入新密码:");
                        string b = ReadLine();
                        while (b != a)
                        {
                            WriteLine("两次输入不一样请重新输入!");
                            b = ReadLine();
                        }
                        if (a == b)
                        {
                            WriteLine("密码修改成功!");
                            this.codon = a;
                        }
                    }
                }
            }
        }
    }
}
