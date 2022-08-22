using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7._1排序
{
    public static class  Arraytool {
    public static T[] ArraySort<T>(this T[] array) where T : IComparable<T>
    {
        //首先初始化一个变量用来记录索引
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            index = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[index].CompareTo(array[j])>0)
                {
                    index = j;
                }
            }
            T temp = array[index];
            array[index] = array[i];
            array[i] = temp;
        }
            return array;
    }

        /// <summary>
        /// 打印数组的所有元素
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        public static void PrintArr<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
    public delegate int DelCompare<T>(T t1, T t2);
}
