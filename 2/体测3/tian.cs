using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 体测3
{
    internal class tian
    {
        student students = new student();
        public  student add(string name, string num, string sex, DateTime birth, float high, float weight)
        {
            this.students.name = name;
            this.students.num = num;
            this.students.sex = sex;
            this.students.birth = birth;
            this.students.high = high;
            this.students.weight = weight;
            return students;
        }
     
}
}
