using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._5机房设备维护
{/// <summary>
/// 机房构造函数
/// </summary>
    internal abstract class installation
    {/// <summary>
    /// 品牌
    /// </summary>
        public string brand { set; get; }
        /// <summary>
        /// 型号
        /// </summary>
               public string model { set; get; }
        /// <summary>
        /// 价值
        /// </summary>

        public string valu { set; get; }
        /// <summary>
        /// 采购
        /// </summary>
        public abstract void Purchase();/// <summary>
        /// 机房设备维修构造函数
        /// </summary>
        /// <param name="brand">品牌</param>
        /// <param name="model">型号</param>
        /// <param name="valu">价值</param>
        public installation(string brand,string model,string valu)
        {
            this.brand = brand;
            this.model = model;
            this.valu = valu;
        }
    }
}
