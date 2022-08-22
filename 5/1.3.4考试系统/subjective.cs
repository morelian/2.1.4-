using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._3._4考试系统
{/// <summary>
/// 主观题
/// </summary>
    public abstract class subjective : text
    {
        /// <summary>
        /// 人工评分
        /// </summary>
        public override void marking()
        {
            WriteLine($"请输入评分(0~{this.score}):");
            this.points = float.Parse(ReadLine());
        }/// <summary>
        /// 主观题构造函数
        /// </summary>
        /// <param name="title">题干</param>
        /// <param name="answer">标准答案</param>
        /// <param name="score">分值</param>
        public subjective(string title, string answer, string score)
            :base(title,answer,score)
        {

        }
    }
}
