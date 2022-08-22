using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._3._5机房设备维护
{/// <summary>
/// 显示屏
/// </summary>
    internal class display:installation ,wearablegoods
    {/// <summary>
    /// 供应商
    /// </summary>
        public string suplier { set; get; }
        /// <summary>
        /// 显示屏构造函数
        /// <param name="model">型号</param>
        /// <param name="valu">价值</param>
        /// <param name="suplier">供应商</param>
        public display(string brand,string model,string valu,string suplier)
            :base(brand,model,valu)
        {
            this.suplier = suplier;
        }
  
        public override void Purchase()
        {
            WriteLine($"正在和供应商{this.suplier}商讨采购价格!");
        }
  
        public void repair()
        {
            WriteLine($"正在联系供应商{this.suplier}!");
        }
    }
}
