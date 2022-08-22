using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._3._4考试系统
{/// <summary>
/// 单选题
/// </summary>
    public class multiple : objective
    {/// <summary>
     /// 单选题构造函数
     /// </summary>
     /// <param name="title">题干</param>
     /// <param name="answer">答案</param>
     /// <param name="score">分值</param>
      /// <param name="bar">备选条</param>
        public multiple(string title, string answer, string score,string bar)
          : base(title, answer, score)
        {
            this.bar = bar;
        }
        /// <summary>
        /// 备选条
        /// </summary>
        public string bar { set; get; }
        /// <summary>
        /// 显示
        /// </summary>
        public override void puttitle()
        {
           
            base.puttitle();
            WriteLine($"备选条:{this.bar}");
        }
        /// <summary>
        /// 评分
        /// </summary>
        public override void marking()
        {
            if (this.studentanswer == this.answer)
            {
                this.points = this.points + this.score;
            }
        }


    }
}
