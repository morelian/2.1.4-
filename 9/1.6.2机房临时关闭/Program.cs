using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6._2机房临时关闭
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stackroom Room = new Stackroom("001");
            Booking[] booking =
            {
                new Booking("沐兰","2022-4-20 9:00:00到2022-4-20 10:00:00",float.Parse("1")),
                 new Booking("苏汐","2022-4-20 10:00:00到2022-4-20 11:00:00",float.Parse("1"))
            };
            Bookingsuriver Sur = new Bookingsuriver(booking);
            Room.Computershutdown += Sur.Inform;
            Room.Maintain();

        }
    }
}
