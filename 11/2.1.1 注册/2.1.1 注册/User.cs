using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._1_注册
{
    /// <summary>
    /// 用户
    /// </summary>
    public class User
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string Num { set; get; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Code { set; get; }
        /// <summary>
        /// 电子邮箱地址
        /// </summary>
        public string E_mailaddress { set; get; }

        public User(string num, string code, string address)
        {
            this.Code = code;
            this.E_mailaddress = address;
            this.Num = num;
        }

    }
}
