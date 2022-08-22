using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _2._1._2_用户登入
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
       
            UserRepository.Users.Login(this.textBox1.Text, this.textBox2.Text);
             void To() {
                if (UserRepository.Users.Login(this.textBox1.Text, this.textBox2.Text)==1)
                    MessageBox.Show("登入成功！");
                else if (UserRepository.Users.Login(this.textBox1.Text, this.textBox2.Text) == 2)
                    MessageBox.Show("账号已冻结，请验证解除！");
                else if (UserRepository.Users.Login(this.textBox1.Text, this.textBox2.Text) == 3)
                    MessageBox.Show("密码错误！");
                else if (UserRepository.Users.Login(this.textBox1.Text, this.textBox2.Text) == 4)
                    MessageBox.Show("未查找到此账号！");
            }
            this.textBox1.Text = "123123";
            this.textBox2.Text = "123123";
            To();
            this.textBox1.Text = "123124";
            this.textBox2.Text = "123123";
            To();
            this.textBox1.Text = "111111";
            this.textBox2.Text = "123125";
            To();
            this.textBox2.Text = "123126";
            To();
            this.textBox2.Text = "123127";
            To();
            this.textBox2.Text = "111111";
            To();



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
