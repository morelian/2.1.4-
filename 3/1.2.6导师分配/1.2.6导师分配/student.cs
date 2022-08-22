using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2._6导师分配
{
    internal class student
    {
        public string num{ get; set; }
        public string name{ get; set; }
        public teacher _teacher{ get; private set; }
        public teacher Get()
        {
            {
                if (_teacher == null)
                {
                    WriteLine("该生无导师,请为其");
                }
                 return _teacher;

            }
        }
        public void setteacher(teacher teachers)
        {
            if (_teacher != null)
            {
                WriteLine("该生已有导师，无法更换导师!");
                return;
            }
            else _teacher = teachers;
        }
    }
}
