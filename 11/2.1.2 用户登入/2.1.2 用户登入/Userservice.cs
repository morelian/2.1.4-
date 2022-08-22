using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _2._1._2_用户登入
{
    /// <summary>
    /// 用户服务
    /// </summary>
    public static class Userservice
    {
        /// <summary>
        /// 登入
        /// </summary>
        /// <param name="Users"></param>
        /// <param name="num"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public static int Login(this List<User> Users, string num, string code)
        {
            User user1 = Users.Find(s => s.Num == num&& s.Code == code);
            User user2= Users.Find(s => s.Num == num );
            if (user1!=null)
            {
                if (user1.Loginfailures >= 3)
                {
                    user1.Freeze = true;
                    return 2;
                }
                else return 1;
            }
            else if (user2 != null)
            {
                if(user2.Loginfailures <3)
                user2.Loginfailures++;
                return 3;
            }
            else return 4;
        }
    }
}
