using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._3._4考试系统
{/// <summary>
/// 名词解释
/// </summary>
    public  class Nouninterpretation:subjective
    {/// <summary>
    /// 显示
    /// </summary>
        public override void puttitle()
        {
            WriteLine("本题类型为:名词解释");
            base.puttitle();
        }
        /// <summary>
        /// 评分
        /// </summary>
        public override void marking()
        {
            WriteLine($"参考答案:{this.answer}");
            base.marking();
        }/// <summary>
        /// 名词解释的构造函数
        /// </summary>
        /// <param name="title">题干</param>
        /// <param name="answer">参考答案</param>
        /// <param name="score">分值</param>
        public Nouninterpretation(string title, string answer, string score)
           : base(title, answer, score)
        {

        }
    }
}
