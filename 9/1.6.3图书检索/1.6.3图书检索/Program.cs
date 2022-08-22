using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6._3图书检索
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book[] book =
            {
                new Book("001","C#面向对象程序设计","Jmahjsutcsh",DateTime.Parse("2021-11-21"),float.Parse("68"),"清华大学出版社"),
                new Book("002","C语言程序设计","Jmahjsutcsh",DateTime.Parse("2022-12-21"),float.Parse("78"),"清华大学出版社"),
                new Book("003","C语言版数据结构","Paterm",DateTime.Parse("2020-1-21"),float.Parse("88"),"电子科技大学出版社"),
                new Book("004","数据结构与算法","Jaky",DateTime.Parse("2021-2-21"),float.Parse("98"),"北京大学出版社"),
                new Book("005","算法图解","Stabndfjs",DateTime.Parse("2021-3-21"),float.Parse("108"),"北京大学出版社"),
                new Book("006","C++程序设计","Trqmjo",DateTime.Parse("2021-4-21"),float.Parse("118"),"电子科技大学出版社"),
                new Book("007","C#面向对象程序设计","Paterm",DateTime.Parse("2020-11-21"),float.Parse("128"),"电子科技大学出版社"),
            };
            Stackroom stack = new Stackroom(book);
            BookUI.Displays(stack.Book.Judge(s=> "C#面向对象程序设计"==s.Name));
            BookUI.Displays(stack.Book.Judge(s => "002" == s.Num));
            BookUI.Displays(stack.Book.Judge(s => "Jmahjsutcsh" == s.Author));
            BookUI.Displays(stack.Book.Judge(s => float.Parse("128") == s.Price));
            BookUI.Displays(stack.Book.Judge(s => DateTime.Parse("2021-4-21") == s.Publicationdate));
            BookUI.Displays(stack.Book.Judge(s => "电子科技大学出版社" == s.Press));
        }
    }
}
