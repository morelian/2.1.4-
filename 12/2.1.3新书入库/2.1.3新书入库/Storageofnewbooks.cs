using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace _2._1._3新书入库
{
    public partial class Storageofnewbooks : Form
    {
        public Storageofnewbooks()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Storage_of_newbooks_Load(object sender, EventArgs e)
        {

        }

        private void Storage_of_newbooks(object sender, EventArgs e)
        {


            //this.text_Name.Text = "C++版算法1";
            //this.text_Num.Text = "3210707007";
            //this.text_Author.Text = "Mothsafo";
            //this.text_Price.Text = "68";
            //this.text_Publication.Text = "2022-1-1";
            //this.Vnum.Text = Book.Verifythenum(this.text_Num.Text);
            //this.Vname.Text = Book.Verifythetitle(this.text_Name.Text);
            //if (this.Vnum.Text == string.Empty && this.Vname.Text == string.Empty)
            //    if (BookRepository.Books.AddtoStack(this.text_Name.Text, this.text_Num.Text, this.text_Author.Text, float.Parse(this.text_Price.Text), DateTime.Parse(this.text_Publication.Text)) == 1)
            //        MessageBox.Show($"{this.text_Name.Text}已再库中请勿重新添加！");
            //    else MessageBox.Show($"已将{this.text_Name.Text}入库！\n" + "简介：\n" +
            //         $"{BookRepository.Books.Find(s => s.Name == this.text_Name.Text).Introduction}");

            //this.text_Name.Text = "C#程序设计";
            //this.text_Num.Text = "3210707001";
            //this.text_Author.Text = "沐兰";
            //this.text_Price.Text = "100";
            //this.text_Publication.Text = "2022-4-1";
            //this.Vnum.Text = Book.Verifythenum(this.text_Num.Text);
            //this.Vname.Text = Book.Verifythetitle(this.text_Name.Text);
            //if (this.Vnum.Text == string.Empty && this.Vname.Text == string.Empty)
            //    if (BookRepository.Books.AddtoStack(this.text_Name.Text, this.text_Num.Text, this.text_Author.Text, float.Parse(this.text_Price.Text), DateTime.Parse(this.text_Publication.Text)) == 1)
            //        MessageBox.Show($"{this.text_Name.Text}已再库中请勿重新添加！");
            //    else MessageBox.Show($"已将{this.text_Name.Text}入库！\n" + "简介：\n" +
            //          $"{BookRepository.Books.Find(s => s.Name == this.text_Name.Text).Introduction}");

            //this.text_Name.Text = "Jave面向对象程序设计";
            //this.text_Num.Text = "007";
            //this.text_Author.Text = "Jctmyp";
            //this.text_Price.Text = "68";
            //this.text_Publication.Text = "2022-1-1";
            //Book book = new Book(this.text_Name.Text, this.text_Num.Text, this.text_Author.Text, float.Parse(this.text_Price.Text), DateTime.Parse(this.text_Publication.Text));
            this.Vnum.Text = Book.Verifythenum(this.text_Num.Text);
            this.Vname.Text = Book.Verifythetitle(this.text_Name.Text);
            if (this.text_Name.Text.Length != 0 && this.text_Num.Text.Length != 0 && this.text_Author.Text.Length != 0 && this.text_Price.Text.Length != 0 && this.text_Publication.Text.Length != 0)
            {
                int a = BookRepository.Books.AddtoStack(this.text_Name.Text, this.text_Num.Text, this.text_Author.Text, float.Parse(this.text_Price.Text), DateTime.Parse(this.text_Publication.Text));
                if (a == 1)
                    MessageBox.Show($"{this.text_Name.Text}已再库中请勿重新添加！");
                else if (a == 2)
                    MessageBox.Show($"已将{this.text_Name.Text}入库！\n" + "简介：\n" +
                     $"{BookRepository.Books.Find(s => s.Name == this.text_Name.Text).Introduction}");
                else MessageBox.Show("请按格式输入!");
            }
            else MessageBox.Show($"请输入信息！");
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Date(object sender, EventArgs e)
        {

        }

        private void Price(object sender, EventArgs e)
        {

        }

        private void Author(object sender, EventArgs e)
        {

        }

        private void Num(object sender, EventArgs e)
        {

        }

        private void Name_(object sender, EventArgs e)
        {

        }

        private void name_(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void text_Num_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void text_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)46 )
            {
                e.Handled = true;
            }
        }

        private void text_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void zairu_Click(object sender, EventArgs e)
        {
            this.text_Name.Text = "C++版算法1";
            this.text_Num.Text = "3210707007";
            this.text_Author.Text = "Mothsafo";
            this.text_Price.Text = "68";
            this.text_Publication.Text = "2022-1-1";
            this.Vnum.Text = Book.Verifythenum(this.text_Num.Text);
            this.Vname.Text = Book.Verifythetitle(this.text_Name.Text);
            if (this.text_Name.Text.Length != 0 && this.text_Num.Text.Length != 0 && this.text_Author.Text.Length != 0 && this.text_Price.Text.Length != 0 && this.text_Publication.Text.Length != 0)
            {
                int a = BookRepository.Books.AddtoStack(this.text_Name.Text, this.text_Num.Text, this.text_Author.Text, float.Parse(this.text_Price.Text), DateTime.Parse(this.text_Publication.Text));
                if (a == 1)
                    MessageBox.Show($"{this.text_Name.Text}已再库中请勿重新添加！");
                else if (a == 2)
                    MessageBox.Show($"已将{this.text_Name.Text}入库！\n" + "简介：\n" +
                     $"{BookRepository.Books.Find(s => s.Name == this.text_Name.Text).Introduction}");
                else MessageBox.Show("请按格式输入!");
            }
            else MessageBox.Show($"请输入信息！");

            this.text_Name.Text = "C#程序设计";
            this.text_Num.Text = "3210707001";
            this.text_Author.Text = "沐兰";
            this.text_Price.Text = "100";
            this.text_Publication.Text = "2022-4-1";
            this.Vnum.Text = Book.Verifythenum(this.text_Num.Text);
            this.Vname.Text = Book.Verifythetitle(this.text_Name.Text);
            if (this.text_Name.Text.Length != 0 && this.text_Num.Text.Length != 0 && this.text_Author.Text.Length != 0 && this.text_Price.Text.Length != 0 && this.text_Publication.Text.Length != 0)
            {
                int a = BookRepository.Books.AddtoStack(this.text_Name.Text, this.text_Num.Text, this.text_Author.Text, float.Parse(this.text_Price.Text), DateTime.Parse(this.text_Publication.Text));
                if (a == 1)
                    MessageBox.Show($"{this.text_Name.Text}已再库中请勿重新添加！");
                else if (a == 2)
                    MessageBox.Show($"已将{this.text_Name.Text}入库！\n" + "简介：\n" +
                     $"{BookRepository.Books.Find(s => s.Name == this.text_Name.Text).Introduction}");
                else MessageBox.Show("请按格式输入!");
            }
            else MessageBox.Show($"请输入信息！");

            this.text_Name.Text = "Jave面向对象程序设计";
            this.text_Num.Text = "007";
            this.text_Author.Text = "Jctmyp";
            this.text_Price.Text = "68";
            this.text_Publication.Text = "2022-1-1";
            Book book = new Book(this.text_Name.Text, this.text_Num.Text, this.text_Author.Text, float.Parse(this.text_Price.Text), DateTime.Parse(this.text_Publication.Text));
            this.Vnum.Text = Book.Verifythenum(this.text_Num.Text);
            this.Vname.Text = Book.Verifythetitle(this.text_Name.Text);
            if (this.text_Name.Text.Length != 0 && this.text_Num.Text.Length != 0 && this.text_Author.Text.Length != 0 && this.text_Price.Text.Length != 0 && this.text_Publication.Text.Length != 0)
            {
                int a = BookRepository.Books.AddtoStack(this.text_Name.Text, this.text_Num.Text, this.text_Author.Text, float.Parse(this.text_Price.Text), DateTime.Parse(this.text_Publication.Text));
                if (a == 1)
                    MessageBox.Show($"{this.text_Name.Text}已再库中请勿重新添加！");
                else if (a == 2)
                    MessageBox.Show($"已将{this.text_Name.Text}入库！\n" + "简介：\n" +
                     $"{BookRepository.Books.Find(s => s.Name == this.text_Name.Text).Introduction}");
                else MessageBox.Show("请按格式输入!");
            }
            else MessageBox.Show($"请输入信息！");

        }
    }
}
