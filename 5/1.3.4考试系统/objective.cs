using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._4考试系统
{/// <summary>
/// 客观题
/// </summary>
    public abstract class objective:text
    {/// <summary>
    /// 客观题构造函数
    /// </summary>
    /// <param name="title">题干</param>
    /// <param name="answer">参考答案</param>
    /// <param name="score">分值</param>
        public objective(string title, string answer, string score)
           : base(title, answer, score)
        {

        }/// <summary>
        /// 自动评分
        /// </summary>
        public override void marking()
        {
            if (this.studentanswer == this.answer)
            {
                this.points=this.points + this.score;
            }
        }

    }
}
