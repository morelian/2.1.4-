using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._4学生管理
{/// <summary>
/// 学生仓储
/// </summary>
    public static class  StudentRepository
    {
        /// <summary>
        /// 学生列表
        /// </summary>
        public static List<Student>  Students;

        static StudentRepository()
        {
            Students = new List<Student>();
            Student[] students = new Student[4];
            students[0] = new Student("3210707001", "苏汐", Sex.Nv, "2003.6.6", Political.Qun, Source.City, true, false, true);
            students[1] = new Student("3210707002", "沐兰", Sex.Nan, "2002.11.29", Political.Dan, Source.Country, true, false, true);
            students[2] = new Student("3210707003", "苏雯烟", Sex.Nv, "2003.6.26", Political.Tuan, Source.City, true, false, true);
            students[3] = new Student("3210707004", "沐嫣然", Sex.Nv, "2002.9.16", Political.Wu, Source.City,false, false, true);
            Students.Add(students[0]);
            Students.Add(students[1]);
            Students.Add(students[2]);
            Students.Add(students[3]);
          
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="Students">学生列表</param>
        /// <param name="num">学号</param>
        /// <returns></returns>
        public static Student Findbynum(this List<Student> Students,string num)
        {

            Student Student = Students.Find(s => s.Num == num);
            return Student;
        }
    


    }


}
