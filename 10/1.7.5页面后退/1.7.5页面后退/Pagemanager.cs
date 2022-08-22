using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7._5页面后退
{
    public class Pagemanager
    {/// <summary>
    /// 当前页面
    /// </summary>
        public Page Page { set; get; }

        /// <summary>
        /// 页面栈
        /// </summary>
        public Stack<Page> Pagenow { private set; get; }
        /// <summary>
        /// 页面前进栈
        /// </summary>
        public Stack<Page> Pagein { private set; get; }

        /// <summary>
        /// 打开页面
        /// </summary>
        public void Open(Page page)
        {
            this.Page = page;
            this.Pagenow.Push(page);
            this.Page.Display();
        }
        /// <summary>
        /// 后退
        /// </summary>
        public void Back()
        {
            this.Pagein.Push(this.Page);
            this.Page = this.Pagenow.Pop();
            this.Page.Display();
        }
        /// <summary>
        /// 前进
        /// </summary>
        public void Advance()
        {
            this.Pagenow.Push(this.Page);
          this.Page=  this.Pagein.Pop();
            this.Page.Display();
        }
        /// <summary>
        /// 页面管理器构造函数
        /// </summary>
        public Pagemanager()
        {
            this.Pagein = new Stack<Page>();
            this.Pagenow = new Stack<Page>();
        }
    }
}
