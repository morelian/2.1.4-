using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._8上机预约
{
    internal class project
    {
        public string course { set; get; }
        public string text { set; get; }
        public project(string course,string text)
        {
            this.text = text;
            this.course = course;
        }
    }
}
