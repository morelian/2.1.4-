﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6._1新书入库
{/// <summary>
/// 新书入库事件参数
/// </summary>
    public class NewbookEventArgs:EventArgs
    {/// <summary>
    /// 新书
    /// </summary>
        public Book Newbook { set; get; }
        /// <summary>
        /// 新书入库事件参数
        /// </summary>
        /// <param name="book">新书</param>
        public NewbookEventArgs(Book book)
        {
            this.Newbook = book;
        }
    }
    /// <summary>
    /// 新书入库委托
    /// </summary>
    /// <param name="sender">事件</param>
    /// <param name="book">新书</param>
    public delegate void NewbookEventHandler(object room, NewbookEventArgs e);
}
