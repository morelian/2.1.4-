using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._6._2机房临时关闭
{/// <summary>
/// 上机预约服务
/// </summary>
    public class Bookingsuriver
    {/// <summary>
     /// 上机预约记录数
     /// </summary>
        private int Count { set; get; }
        /// <summary>
        /// 上机预约记录
        /// </summary>
        public Booking[] Times { set; get; }
        /// <summary>
        /// 通知
        /// </summary>
        /// <param name="sendor">发送方</param>
        /// <param name="e">接收方</param>
        public void Inform(object sendor, ComputershutdownEventArgs e)
        {
            Stackroom Room = sendor as Stackroom;
            if (this.Times != null)
                WriteLine($"机房{Room.Num}已经发短信通知所以有预约的学生了,名单如下:");
            for (int i = 0; i < this.Times?.Length; i++)
            {
                if (this.Times[i] != null)
                    WriteLine($"学生姓名{this.Times[i].Student} 起始时间:{this.Times[i].Time}");
            }
            WriteLine($"机房开关起止时间为：{e.Time:f}");
        }
        /// <summary>
        /// 上机预约构造函数
        /// </summary>
        public Bookingsuriver()
        {
            this.Count = 0;
        }
        /// <summary>
        /// 上机预约构造函数
        /// </summary>
        /// <param name="book">预约记录</param>
        public Bookingsuriver(Booking[] book)
        {
            this.Times = book;
            this.Count = book.Length;
        }
        /// <summary>
        /// 添加新记录
        /// </summary>
        public void Add()
        {
            WriteLine("输入要添加的记录数:");
            int a = int.Parse(ReadLine());
            if (this.Count + a >= this.Times.Length)
            {
                Booking[] booking = new Booking[this.Count * 2 + a];
                this.Times.CopyTo(booking, 0);

            }
            for (int i = this.Count; i < this.Count + a; i++)
            {
                WriteLine("输入学生名字:");
                string name = ReadLine();
                WriteLine("输入时间:");
                string time = ReadLine();
                WriteLine("输入时长:");
                float time1 = float.Parse(ReadLine());
                this.Times[i] = new Booking(name,time,time1);
            }
        }
    }
}

