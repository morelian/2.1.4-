using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _2._1._1_注册
{
    public partial class nrol : Form
    {


        
     
        public nrol()
        {
            InitializeComponent();

        }

        private void Enrol_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            this.textBox1.Text = "123123";
            this.textBox2.Text = "123123";
            this.textBox3.Text = "123123@qq .com";

            if (UserRepository.Users.Enrol(this.textBox1.Text, this.textBox2.Text, this.textBox3.Text))
                    MessageBox.Show("已注册");
               else MessageBox.Show("用户已存在");
            this.textBox1.Text = "123124";
            this.textBox2.Text = "123123";
            this.textBox3.Text = "123123@qq .com";
            if (UserRepository.Users.Enrol(this.textBox1.Text, this.textBox2.Text, this.textBox3.Text))
                MessageBox.Show("已注册");
            else MessageBox.Show("用户已存在");

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon5_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
