using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._3._5机房设备维护
{
    internal class Program
    {
        static void Main(string[] args)
        {
            peripheraldevice mouse = new peripheraldevice("ROG", "ROG 战刃3无线★26000DPI", "599元", "ROG战刃3无线版 无线游戏鼠标");
            engine engine = new engine("ROG", "ROG ACRFH-DCGSJCU-12SDJ", "12999元", "Intel I7-12700 16G 1TB+1TSSD RTX3070 8G独显");
            display display = new display("SAMSUNG", "玄龙骑士49英寸Mini", "16999", "京东三星自营");
            while (true)
            {
                WriteLine("按1采购外设，2补充外设，3采购主机，4补充主机，5报修显示器，6采购显示器:");
                int a = int.Parse(ReadLine());
                if(a==1)
                mouse.Purchase();
                if(a==2)
                mouse.add();
                if(a==3)
                engine.Purchase();
                if(a==4)
                engine.repair();
                if(a==5)
                display.repair();
                if(a==6)
                display.Purchase();
            }
        }
    }
}
