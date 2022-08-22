using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._16学生评教
{
    internal class teacher
    {/// <summary>
     /// 工号
     /// </summary>
        public string num { set; get; }
        /// <summary>
        /// 名字
        /// </summary>
        public string name { set; get; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string telephone { set; get; }
        /// <summary>
        /// 电子邮箱地址
        /// </summary>
        public string email { set; get; }
        public teacher(string num, string name, string telephon, string email)
        {
            this.email = email;
            this.name = name;
            this.num = num;
            this.telephone = telephon;

        }

    }
}
