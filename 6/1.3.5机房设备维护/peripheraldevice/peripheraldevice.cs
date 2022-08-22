using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._3._5机房设备维护
{/// <summary>
/// 外设
/// </summary>
    internal class peripheraldevice:installation,easyconsumedproducts
    {
        /// <summary>
        /// 鼠标
        /// </summary>
        public string mouse { set; get; }

        public override void Purchase()
        {
            WriteLine("已经上报将从政府采购网上超市采购");
        }
        public void add()
        {
            WriteLine("将从政府采购网上超市补充");
        }
        /// <summary>
        /// 外设的构造函数
        /// </summary>
        /// <param name="brand">品牌</param>
        /// <param name="model">型号</param>
        /// <param name="valu">价值</param>
        /// <param name="keybaord">键盘</param>
        /// <param name="mouse">鼠标</param>
        public peripheraldevice(string brand, string model, string valu,string mouse)
            :base(brand,model,valu)
        {
            this.mouse = mouse;
        }
    }
}
