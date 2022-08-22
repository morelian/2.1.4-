using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._16学生评教
{
    internal class course
    {/// <summary>
    /// 课程号
    /// </summary>
        public string lesson { set; get; }
        /// <summary>
        /// 名称
        /// </summary>
        public string name { set; get; }
        /// <summary>
        /// 学分
        /// </summary>
        public float credit { set; get; }
        public course(string lesson,string name,float credit)
        {
            this.credit = credit;
            this.name = name;
            this.lesson = lesson;
        }
    }
}
