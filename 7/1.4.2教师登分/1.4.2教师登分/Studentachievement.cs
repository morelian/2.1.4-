using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4._2教师登分
{/// <summary>
/// 学生成绩
/// </summary>
    public class Studentachievement:IComparable
    {
        public Student Student { set; get; }
        /// <summary>
        /// 考试状态
        /// </summary>
        public string Behavior { set; get; }
        /// <summary>
        /// 平时成绩
        /// </summary>
        public float Usualgrade { set; get; }
        /// <summary>
        /// 期末成绩
        /// </summary>
        public float Finalgrade { set; get; }
        /// <summary>
        /// 总评成绩
        /// </summary>
        public float overevaluationresult{set;get; }
        public Studentachievement()
        {
            this.Behavior = string.Empty;
            this.Finalgrade = 0;
            this.overevaluationresult = 0;
            this.Student = new Student();
            this.Usualgrade = 0;

        }

        public Studentachievement(string behavior,float final,float usual,float over,Student one)
        {
            this.Behavior = behavior;
            this.Finalgrade = final;
            this.overevaluationresult = over;
            this.Student = one;
            this.Usualgrade = usual;

        }


        public int CompareTo(object obj)
        {
            Studentachievement other = obj as Studentachievement;
            int result = this.Student.Num.CompareTo(other.Student.Num);
            if (result == 0) 
                result= this.Student.Name.CompareTo(other.Student.Name);
            if(result==0)
                this.Usualgrade.CompareTo(other.Usualgrade);
            if(result==0)
                this.Finalgrade.CompareTo(other.Finalgrade);
            if(result==0)
                this.overevaluationresult.CompareTo(other.overevaluationresult);
            return result;
        }
    }
}
