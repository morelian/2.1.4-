using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._6学生工作
{/// <summary>
/// 学生工作人员
/// </summary>
    internal interface studentstaff
    {/// <summary>
    /// 起聘时间
    /// </summary>
      DateTime begin { set; get; }
        /// <summary>
        /// 工资
        /// </summary>
        double pay { set; get; }
        /// <summary>
        /// 考核
        /// </summary>

        void examine();

    }
}
