using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 电子阅览室计费
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("输入s开机（开始计时）:");
            char begin=char.Parse(ReadLine());
            char b = 's';
            if (begin ==b)
            {
                DateTime dateTime = DateTime.Now;
                WriteLine("当前时间为:{0}", dateTime);
                WriteLine("输入f关机（停止计时):");
                char end=char.Parse(ReadLine());
                char a = 'f';
                if (end == a)
                {
                    DateTime last=DateTime.Now;
                    TimeSpan usedtime = last - dateTime;
                    string spend = usedtime.Minutes.ToString();
                    float coat = int.Parse(spend);
                    double money;
                    if(coat <= 60)
                    {
                        money = coat*0.02;
                    }
                    else if (coat <= 120)
                    {
                        money = (coat * 0.03) - 0.6;
                    }
                    else if(coat > 120 && coat<=295)
                    {
                        money = (coat * 0.04) - 1.8;
                    }
                    else
                    {
                         money = 10;
                    }
                    WriteLine("现在时间为:{0}\n您总计用时为:{1}分钟\n需交费用为:{2}元",last,coat,money);
                }
            }
            else
            {
                WriteLine("输入错误,请重新输入!");
            }
        }
    }
}
