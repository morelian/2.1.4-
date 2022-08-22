using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2._5上机预约
{
    internal class book
    {
        public student Student { get; set; }
        public project project { get; set; }
        public DateTime time { get; set; }
        public string timeto { get; set; }

        public book Creat(student Student,project Project ,DateTime time, string timeto)
        {
            float day;
            DateTime now = DateTime.Now;
            TimeSpan from = time - now;
            day = from.Days;
            if (day > 7)
            {
                WriteLine("起始时间必须在七天内!");
                return null;
            }
            else
            {
                book booking = new book();
                booking.time = time;
                booking.timeto = timeto;
                booking.project = Project;
                booking.Student = Student;
                return booking;
            }
        }
    }

}
