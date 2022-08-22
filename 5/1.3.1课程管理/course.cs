using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._3._1课程管理
{/// <summary>
/// 课程
/// </summary>
    public class course
    {/// <summary>
    /// 编号
    /// </summary>
        public string num { set; get; }
        /// <summary>
        /// 名称
        /// </summary>
        public string name { set; get; }
        /// <summary>
        /// 学分
        /// </summary>
        public string score { set; get; }
        /// <summary>
        /// 选修
        /// </summary>
        /// <param name="name">学生名字</param>
        public void elective(string name)
        {
            WriteLine($"{name}同学选修{this.name}课成功!");


        }
        /// <summary>
        /// 课程构造函数
        /// </summary>
        /// <param name="num">编号</param>
        /// <param name="name">名称</param>
        /// <param name="score">学分</param>
        public course(string num,string name,string score)
        {
            this.num = num;
            this.name = name;
            this.score = score;
        }


    }
}
