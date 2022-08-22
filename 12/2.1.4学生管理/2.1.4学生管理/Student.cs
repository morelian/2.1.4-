using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._4学生管理
{
    /// <summary>
    /// 来源
    /// </summary>
    public class Source
    {
        public const string City = "城市";
        public const string Country = "农村";
    }
    /// <summary>
    /// 政治面貌
    /// </summary>
    public class Political
    {
        public const string Tuan = "团员";
        public const string Dan = "党员";
        public const string Qun = "群众";
        public const string Wu = "无党派人士";
    }


    /// <summary>
    /// 性别
    /// </summary>

     public class Sex
    {
        public const string Nan = "男";
        public const string Nv = "女";

    }
    /// <summary>
    /// 学生
    /// </summary>
    public class Student
    {/// <summary>
    /// 学号
    /// </summary>
        public string Num { set; get; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// 生日
        /// </summary>
        public string Birthday { set; get; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { set; get; }
        /// <summary>
        /// 政治面貌
        /// </summary>
        public string Political { set; get; }
        /// <summary>
        /// 来源
        /// </summary>
        public string Source { set; get; }
        /// <summary>
        ///是否为应届生
        /// </summary>
        public bool Current { set; get; }
        /// <summary>
        /// 是否体受限
        /// </summary>
        public bool R_P_E { set; get; }
        /// <summary>
        /// 是否服从调剂
        /// </summary>
        public bool Obeyadjustment { set; get; }
        public Student()
        {

        }
        public Student(string num,string name,string sex,string birthday,string political,string source,bool current,bool rpe,bool obey)
        {
            this.Current = current;
            this.Name = name;
            this.Num = num;
            this.Obeyadjustment = obey;
            this.Political = political;
            this.R_P_E = rpe;
            this.Sex = sex;
            this.Source = source;
            this.Birthday = birthday;
        }
        public Student(string num, string name, string birthday)
        {
            this.Birthday = birthday;
            this.Name = name;
            this.Num = num;
            this.R_P_E = false;
            this.Sex = String.Empty;
            this.Source = String.Empty;
            this.Political= String.Empty;
            this.Obeyadjustment = false;
            this.Current = false;
        }
    }
}
