using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2._13宿舍门禁
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cardholder one = new cardholder("3210707015","官祥杰","13",0);
            while (true)
            {
                WriteLine("按(0)为进入自己的楼,按（1）为进入别的楼,按（2）为查询,按(3)为退出程序:");
                int a =int.Parse(ReadLine());
                if (a == 0)
                    one.into(one,"13");
                if(a==1)
                    one.into(one, "14");
                if (a == 2)
                    one.search(one);
                if (a == 3)
                    return ;
                
            }
        }
    }
}
