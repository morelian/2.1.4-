using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2._12考务管理
{
    public class operate
    {
        public static readonly string math = "评分";                                         //定义静态只读字段并初始化；
        public static readonly string Evaulate = "评教";
    }
    internal static class logservice
    {/// <summary>
    /// 操作类型
    /// </summary>
        public static string operate { get; set; }
        /// <summary>
        /// 记录
        /// </summary>
        /// <param name="math">操作类型</param>
        /// <param name="teacher"> 操作人</param>
        /// <param name="student">操作对象</param>
        /// <param name="data">数据</param>
        /// <param name="time">时间</param>
        public static void Add(string math,teacher teacher,student student, string data,DateTime time)
        {
            logservice.operate = math;
            if (math == "Math")
                WriteLine($"已记录日志：\n操作类型:{logservice.operate}  操作人:{teacher.name}\n" +
                    $"操作对象:{student.name}  成绩:{data}分  时间:{time:f}\n");
            else
                WriteLine($"已记录日志：\n操作类型:{logservice.operate}  操作人:{student.name}\n" +
                      $"操作对象:{teacher.name}  评分:{data}分(满分十分)  时间:{time:f}\n");
        }
    }
}
