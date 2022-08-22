using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace _1._7._4取号_叫号
{
    public class Reservationmanager
    {/// <summary>
    /// 学生队列
    /// </summary>
        public Queue<Student> Students {private set; get; }
        /// <summary>
        /// 取号
        /// </summary>
        public void Takenumber()
        {
           Student  student = new Student();
            WriteLine("输入学生名字：");
            student.Name = ReadLine();
            WriteLine("输入学生学号：");
            student.Num = ReadLine();
            WriteLine("输入学生班级：");
            student.Class = ReadLine();
            WriteLine($"已为学生：{student.Name}取号！");
            this.Students.Enqueue(student);

        }
        /// <summary>
        /// 叫号
        /// </summary>
        public void Callnumber()
        {
            Student student = this.Students.Dequeue();
            WriteLine($"请来自{student.Class}班的{student.Name}同学来前台3号台办理业务");
        }
        /// <summary>
        /// 预约管理器构造函数
        /// </summary>
        public Reservationmanager()
        {
            this.Students = new Queue<Student>();

        }
    }
}
