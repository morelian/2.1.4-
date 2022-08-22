using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 导师分配
{
    internal class student
    {
        public string name { set; get; }
        public string nume { set; get; }
        private teacher _Teacher;
        public teacher Teacher
        {
            set {
                if (Teacher != null)
                {
                    WriteLine("已有导师，请勿随意更换导师!");
                }
                else { this._Teacher = value; }
            }
            get
            {   if (_Teacher == null)
                    WriteLine($"{name}同学还没有分配导师!");
                return this._Teacher;
            }

        }

    }
}
