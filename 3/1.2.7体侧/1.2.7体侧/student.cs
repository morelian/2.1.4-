using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2._7体侧
{
    internal class student
    {
        public string num { get; set; }
        public string name { get; set; }
        public string sex { get; set; }
        public DateTime birth { get; set; }
        public float high { get; set; }
        public float weight { get; set; }
        public string BMI
        {
            get
            {
                double b = (weight / (high * high));
                double a = Math.Round(b, 2);
                if (a < 18.5)
                    return this.name + "同学,你的的BMI为:" + a + ",你偏瘦了需要改善饮食，增加体重!";
                else if (a <= 23.9)
                    return this.name + "同学,你的的BMI为:" + a + ",你体重正常，继续保存!";
                else if (a < 30)
                    return this.name + "同学,你的的BMI为:" + a + ",你超重了注意饮食，增加运动!";
                else
                    return this.name + "同学,你的的BMI为:" + a + ",你已经非常肥胖了,需要改善饮食，减少进食，多运动，不然会影响健康!";

            }
        }
            
        public student(string num,string name)
        {
            this.name = name;
            this.num = num;
        }
        public student (string num, string name, string sex, DateTime birth)
        : this(num,  name)
        {
            this.sex = sex;
            this.birth = birth;
        }
        public string Creat(float high, float weight)
        {
            student student1 = new student(num,name,sex,birth);
            student1.high = high;
            student1.weight = weight;
            return student1.BMI;
        }
    }
    }

