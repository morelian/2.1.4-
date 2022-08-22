using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2._13宿舍门禁
{
    public partial class cardholder
    {
        public void into(cardholder one,string buildnum)
        {
            if (one.buidingnum != buildnum)
                WriteLine("未识别成功,你不是这栋楼的!\n");
            else
            {
                WriteLine("欢迎回家!\n");
                int now = DateTime.Now.Hour;
                if (now > one.closetime)
                    one.latetimes = one.latetimes + 1;
                if(one.opentime<now)
                    one.latetimes = one.latetimes + 1;

            }
        }
        
        public void search(cardholder one)
        {
            if (one.latetimes >= 3)
            {
                WriteLine($"你已经晚归了{one.latetimes}次，将被扣除{(one.latetimes * 1.0 / 10)}学分");
                if (one.latetimes >= 10)
                    WriteLine("你将被通报批评并扣除奖学金评选，班委评选等机会!,请注意宿舍关闭时间!\n");
                else WriteLine("如果你晚归达到十次你将被通报批评并扣除奖学金评选，班委评选等机会!请注意宿舍关闭时间!\n");
            }
            else WriteLine($"你已经晚归了{one.latetimes}次,你最多还可以迟到到{(3 - one.latetimes)}次!\n");
        }
    }
}
