using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2_用户登入
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

        /// <summary>
        /// 登入失败次数
        /// </summary>
       public int Loginfailures;
        /// <summary>
        /// 是否登入成功
        /// </summary>
        public bool Loginbehavior;
        /// <summary>
        /// 是否冻结
        /// </summary>
        public bool Freeze;

        public User(string num, string code, string address)
        {
            this.Code = code;
            this.E_mailaddress = address;
            this.Num = num;
            this.Loginfailures = 0;
            this.Freeze = false;
            this.Loginbehavior = false;
        }

    }
}
