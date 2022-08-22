using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7._1排序
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] student = { "苏汐", "沐兰", "李小明","张万森","云" };
            string[] array = { "g","b","c","a","d","adsfsdf","safds","safesdgsd"};
            string[] course = { "c#", "数据结构", "线性代数", "英语" };
            int[] num = { 1, 5, 7, 9, 13, 34, 656, 23 };
            Arraytool.PrintArr<string>(student.ArraySort());
            Arraytool.PrintArr(course.ArraySort());
            Arraytool.PrintArr(array.ArraySort());
            Arraytool.PrintArr(num.ArraySort());
        }
    }
}
