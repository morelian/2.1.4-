using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._3._5机房设备维护
{/// <summary>
/// 主机
/// </summary>
    internal class engine:installation,wearablegoods
    {/// <summary>
    /// 配置
    /// </summary>
        public string deploy { set; get; }
        /// <summary>
        /// 采购
        /// </summary>
        public override void Purchase()
        {
            WriteLine($"已由网络中心统一采购!");
        }
        public void repair()
        {
            WriteLine("将练习网络中心统一报修!");
        }
        public engine(string brand, string model, string valu, string deploy)
        : base(brand, model, valu)
        {
            this.deploy= deploy;
        }
    }
}
