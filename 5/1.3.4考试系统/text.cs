using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._3._4考试系统
{/// <summary>
/// 试题
/// </summary>
   public abstract class text
    {/// <summary>
    /// 题干
    /// </summary>
        public string title { set; get; }
        /// <summary>
        /// 参考答案 
        /// </summary>

        public string answer { set; get; }
        /// <summary>
        /// 分值
        /// </summary>
        public float score { set; get; }
        /// <summary>
        /// 得分
        /// </summary>
        public float points { set; get; }
        /// <summary>
        /// 学生答案
        /// </summary>
        public string studentanswer { set; get; }
        /// <summary>
        /// 显示题干
        /// </summary>
        public virtual void puttitle()
        {
            WriteLine($"题干为:{this.title}");
        }       
        /// <summary>
        /// 回答
        /// </summary>
        public virtual void reply()
        {
            WriteLine("请输入你的答案:");
            this.studentanswer = ReadLine();
        }
        /// <summary>
        /// 评分
        /// </summary>
        public abstract void marking();
        /// <summary>
        /// 试题构造函数
        /// </summary>
        /// <param name="title">题干</param>
        /// <param name="answer">参考答案</param>
        /// <param name="score">分值</param>
        public text(string title,string answer,string score)
        {
            this.title = title;
            this.score = float.Parse(score);
            this.answer = answer;

        }
        

    }
}
