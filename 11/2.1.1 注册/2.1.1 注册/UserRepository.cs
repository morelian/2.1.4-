using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._1_注册
{
    /// <summary>
    /// 用户仓储
    /// </summary>
    public class UserRepository
    {/// <summary>
     ///用户列表
     /// </summary>
        public static List<User> Users;
       
  
       static UserRepository()
        {
           Users = new List<User>();
            User[] user =
            {
              new User("123456","123456","123456@qq.com"),
              new User("111111","111111","111111@qq.com"),
              new User("123123","123123","123123@qq.com"),
            };
           Users.Add(user[0]);
          Users.Add(user[1]);
           Users.Add(user[2]);

        }


    }
}
