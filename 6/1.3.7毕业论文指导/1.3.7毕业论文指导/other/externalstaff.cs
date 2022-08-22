using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._7毕业论文指导
{/// <summary>
/// 外聘人员
/// </summary>
    internal class externalstaff
    {/// <summary>
    /// 身份证号码
    /// </summary>
        public string idk { set; get; }
        /// <summary>
        /// 名字
        /// </summary>

        public string name { set; get; }
        /// <summary>
        /// 工作单位
        /// </summary>

        public string placeofwork { set; get; }
        public externalstaff(string idk,string name,string placeofwork)
        {
            this.name = name;
            this.idk = idk;
            this.placeofwork = placeofwork;
        }
    }
}
