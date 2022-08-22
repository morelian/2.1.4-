using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 体测3
{
    internal class student
    {
        public string num { get; set; }
        public string name { get; set; }
        public string sex { get; set; }
        public DateTime birth { get; set; }
        public float high { get; set; }
        public float weight { get; set; }
        public string BMI
        {
            get
            {
                double a = (weight/(high*high));
                if (a < 16)
                    WriteLine($"你的MBI为:{a:f2},你太瘦了，需要增加营养摄入!");
                if (a < 18.5)
                    WriteLine($"你的BMI为:{a:f2},你偏瘦了需要改善饮食，增加体重!");
                else if (a <= 23.9)
                    WriteLine($"你的的BMI为:{a:f2},你体重正常，继续保存!");
                else if (a < 24)
                    WriteLine($"你BMI为:{a:f2},你有点超重了注意饮食，增加运动!");
                else if (a < 28)
                    WriteLine($"你BMI为:{a:f2},你已经属于肥胖了，需要改善饮食，多运动，健康生活!");
                else if (a < 32)
                    WriteLine($"你BMI为:{a:f2},你已经高度肥胖了，需要改善饮食，不挑食，多运动，不然会影响健康!");
                else WriteLine($"你BMI为:{a:f2},你已经非常肥胖了,需要改善饮食，减少进食，多运动，不然会影响健康!");
                return null;
            }

        }
    }
}