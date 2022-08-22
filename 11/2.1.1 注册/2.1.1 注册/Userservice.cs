using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _2._1._1_注册
{
    /// <summary>
    /// 用户服务
    /// </summary>
    public static class Userservice
    {
        public static bool Enrol(this List<User> Users,string num, string code, string address)
        {

            User user1 = Users.Find(s => s.Num == num);
            if (user1 != null)
            {
                User user = new User(num, code, address);
                Users.Add(user);
                return false;
            }
            else return true;
        }
    }
}
