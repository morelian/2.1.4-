using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2._14餐卡消费
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cardholder one = new cardholder("3210707015", "官祥杰", "8888",100,100);
            while (true)
            {
                int time = DateTime.Now.Hour;
                if (time == 6)
                {
                    one.coasted = 0;
                }
                WriteLine("按(1)为充值，按(2)为消费,按(3)为补贴,按(4)为修改密码,按(5)为退出:");
                int a =int.Parse( ReadLine());
                if (a == 1)
                {
                    WriteLine("请输入你要充值的金额:");
                    float m = float.Parse(ReadLine());
                    one.investmoney(m);
                }
                if (a == 2)
                {
                    WriteLine("请输入消费的金额:");
                    float m = float.Parse(ReadLine());
                    one.spend(m);
                }
                if (a == 3)
                {
                    WriteLine("请输入补贴的金额:");
                    float m = float.Parse(ReadLine());
                    one.subsize(m);
                }
                if (a == 4)
                {
                    one.changecodon();
                }
                if (a == 5)
                    return;
            }
        }
    }
}
