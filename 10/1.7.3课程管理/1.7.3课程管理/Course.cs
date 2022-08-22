using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7._3课程管理
{
    public class Course:IComparable
    {/// <summary>
    /// 名称
    /// </summary>
        public string Name{ set;get;}
        /// <summary>
        /// 课程号
        /// </summary>
        public string Num { set; get; }
        /// <summary>
        /// 学分
        /// </summary>
        public float Score { set; get; }
        /// <summary>
        /// 类别
        /// </summary>
        public string Type { set; get; }
        /// <summary>
        /// 教师
        /// </summary>
        public string Teacher { set; get; }
        /// <summary>
        /// 课时
        /// </summary>
        public int Time { set; get; }

        /// <summary>
        /// 是否与目标对象相等；
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns>是否相等</returns>
        public override bool Equals(object obj)							//重写基类object的Equals方法；
        {
            if (obj == null)											//若比较对象为空值，则双方不等；若直接使用==运算符与null比较，将导致栈溢出，而object类的==运算符中已使用is来进行比较，不会溢出；
            {
                return false;
            }
            if (!(obj is Course))										//若比较对象的类并非课程，则双方不等；
            {
                return false;
            }
            Course otherCourse = obj as Course;						//将比较对象显式转换为课程类；
            return this.Num == otherCourse.Num;					//比较两个课程对象的课程号是否相等；
        }
        /// <summary>
        /// 获取散列值；
        /// </summary>
        /// <returns>散列值</returns>
        public override int GetHashCode()                               //若对象将用作字典的键值，则在重写基类object的Equals方法后，还需重写基类object的GetHashCode方法；
        {
            return this.Num.GetHashCode();                           //返回学号的散列值；即只要两个学生对象的学号的散列值相等，则双方的键值相等；
        }
        /// <summary>
        /// 比较；
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns>大小</returns>
        public int CompareTo(object obj)
        {
            Course otherCourse = obj as Course;
            int result = this.Num.CompareTo(otherCourse.Num);
            if (result == 0)
            {
                result = this.Name.CompareTo(otherCourse.Name);
            }
            return result;
        }
        /// <summary>
        /// 课程构造函数
        /// </summary>
        public Course()
        {

        }
        /// <summary>
        /// 课程构造函数
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="num">课程号</param>
        /// <param name="score">学分</param>
        /// <param name="type">类别</param>
        public Course(string name,string num,float score,string teacher,int time,string type)
        {
            this.Name = name;
            this.Num = num;
            this.Score = score;
            this.Type = type;
            this.Teacher = teacher;
            this.Time = time;
        }
        public Course(string num)
        {
            this.Name = null;
            this.Num = num;
            this.Score = 0;
            this.Type = null;
            this.Time = 0;

        }
    }
}
