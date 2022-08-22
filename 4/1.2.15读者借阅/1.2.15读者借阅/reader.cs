using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2._15读者借阅
{
    internal class reader
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string num { set; get; }
        /// <summary>
        /// 名字
        /// </summary>
        public string name { set; get; }
        /// <summary>
        /// 借阅读时长限制
        /// </summary>
        public int length { set; get; }
        /// <summary>
        /// 续借次数限制
        /// </summary>
        public int times { set; get; }
        /// <summary>
        /// 可借书本数限制
        /// </summary>

        public int maxbook { set; get; }
        /// <summary>
        /// 借阅记录
        /// </summary>

        public borrowingrecord[] borrowingrecord { set; get; }

        /// <summary>
        /// 读者的构造函数
        /// </summary>
        /// <param name="num">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="length">借阅读时长限制</param>
        /// <param name="times">续借次数限制</param>
        /// <param name="maxbook">最多可借书本数</param>
        /// <param name="b">借阅记录</param>
        public reader(string num, string name, int length, int times, int maxbook,borrowingrecord[] a)
        {
            this.num = num;
            this.name = name;
            this.length = length;
            this.times = times;
            this.maxbook = maxbook;
            this.borrowingrecord = a;
        }
        /// <summary>
        /// 借阅
        /// </summary>
        /// <param name="books">要借阅的书</param>
        public void borrow(book books)
        {
            int leng = 0;
            for (int i = 0; i < this.borrowingrecord.Length; i++)
            {
                if (this.borrowingrecord[i].book != null)
                    leng = leng + 1;
            }
            if (this.maxbook ==leng)
            {
                WriteLine("你借书数已经达到最大，不可借书!");
                WriteLine("已经是已借书本");
                int i;
                for (i = 0; i < leng; i++)
                {
                    WriteLine($"书名:{this.borrowingrecord[i].book.name}\n" +
                        $"借阅时间:{this.borrowingrecord[i].time}\n" +
                        $"应还时间:{this.borrowingrecord[i].returntime}\n" +
                        $"续借次数:{this.borrowingrecord[i].Renewaltimes}\n");
                }
            }
            else
            {
                WriteLine($"还可借书本:{(this.maxbook - this.borrowingrecord.Length)}本");

                WriteLine("已经是已借书本");
                int i = this.borrowingrecord.Length + 1;
                this.borrowingrecord[i].book = books;
                this.borrowingrecord[i].returntime = DateTime.Now;
                this.borrowingrecord[i].returntime = this.borrowingrecord[i].returntime.AddDays(30);
                this.borrowingrecord[i].time = DateTime.Now;
                for (i = 0; i < this.borrowingrecord.Length; i++)
                {
                    WriteLine($"书名:{this.borrowingrecord[i].book.name}\n" +
                        $"借阅时间:{this.borrowingrecord[i].time}\n" +
                        $"应还时间:{this.borrowingrecord[i].returntime}\n" +
                        $"续借次数:{this.borrowingrecord[i].Renewaltimes}\n");
                }
            }
        }/// <summary>
         /// 续借
         /// </summary>
         /// <param name="books">要续借的书</param>
        public void borrowing(book books)
        {
            for (int i = 0; i < this.borrowingrecord.Length; i++)
            {
                if (books.name == this.borrowingrecord[i].book.name)
                {
                    if (this.borrowingrecord[i].Renewaltimes <= this.maxbook)
                    {
                        WriteLine($"续借成功!剩余续借次数为:{(this.maxbook - this.borrowingrecord[i].Renewaltimes)}");
                        this.borrowingrecord[i].Renewaltimes = 1;
                        break;
                    }
                    else if (this.borrowingrecord[i].Renewaltimes == this.maxbook)
                    {
                        WriteLine("你已经续借过了,无法续借!");
                        break;
                    }
                }
                int leng = 0;
                for(int j=0;j < this.borrowingrecord.Length; j++)
                {
                    if (this.borrowingrecord[j].book != null)
                        leng = leng + 1;
                }
                if (this.maxbook>=leng)
                {
                    WriteLine("没找到你有借阅这本书,已经帮你登记借阅了!");
                    borrow(books);
                }
                else
                {
                    WriteLine("没找到你有借阅这本书,并且你的借阅数已经达到最大不可借阅了!");
                }
            }
        }/// <summary>
         /// 还书
         /// </summary>
         /// <param name="books">要还书</param>
        public void returnbook()
        {
            int i;
            WriteLine("以下是你借阅的书:");
            for ( i = 0; i < this.borrowingrecord.Length; i++)
            { WriteLine($"{this.borrowingrecord[i].book.name}");
            }
            WriteLine("按(0)选择第一本,按（1）选择第二本,后面以此类推:");
            i =int.Parse( ReadLine());
            DateTime now = DateTime.Now;
            if (this.borrowingrecord[i].returntime < now)
            {
                WriteLine("还书成功!");
                this.borrowingrecord[i] = null;
            }
            else
            {
                string b = (now - this.borrowingrecord[i].returntime).ToString("yyyy-MM-dd");
                float a = float.Parse(b);
                WriteLine($"还书成功!你已经超时:{(now - this.borrowingrecord[i].returntime)}天!\n" +
                    $"应罚款:{(this.borrowingrecord[i].book.price * 0.001 * a)}");
                this.borrowingrecord[i] = null;
            }


        }
        }

    }

