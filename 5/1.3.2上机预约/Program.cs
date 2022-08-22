using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._2上机预约
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student student = new student("3210707015", "沐兰");
            onlineappointment onlineappointment = new onlineappointment();
            onlineappointment.Appointment(student, DateTime.Parse("2022-4-9"), "105天");
            virthalexam virthalexam = new virthalexam();
            virthalexam.Appointment(student, DateTime.Parse("2022-4-1"), "110天");
            contexttrainL contexttrain = new contexttrainL();
            contexttrain.Appointment(student, DateTime.Parse("2022-4-12"), "100天");
        }
    }
}
