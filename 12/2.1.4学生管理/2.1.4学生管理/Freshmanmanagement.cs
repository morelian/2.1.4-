using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._1._4学生管理
{
    public partial class Studentinformation : Form
    {
        Student student;
        public Studentinformation()
        {
            InitializeComponent();
        }

        private void Studentinformation_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Nan__CheckedChanged(object sender, EventArgs e)
        {

        }

        private void add__Click(object sender, EventArgs e)
        {
            student.Name = this.textstudentname.Text;
            student.Num = this.textstudentnum.Text;
            student.Birthday = this.textstudentbirthday.Text;
            student.Current = this.curr_.Checked;
            student.Obeyadjustment = this.Obey_.Checked;
            student.R_P_E = this.Pe_.Checked;
            if (this.Country_.Checked)
                student.Source = Source.Country;
            if (this.CIty_.Checked)
                student.Source = Source.City;
            if (this.Dan_.Checked)
                student.Political = Political.Dan;
            if (this.Tuan_.Checked)
                student.Political = Political.Tuan;
            if (this.Qun_.Checked)
                student.Political = Political.Qun;
            if (this.Wu_.Checked)
                student.Political = Political.Wu;
            if (this.Nan_.Checked)
                student.Sex = Sex.Nan;
            else student.Sex = Sex.Nv;
         
            MessageBox.Show("已保存！");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           student= StudentRepository.Students.Findbynum(this.textstudentnum.Text);
            if (student == null)
            {
                MessageBox.Show("未查找到此学生！");
                return;
            }
            this.textstudentname.Text = student.Name;
            this.textstudentbirthday.Text = student.Birthday;
            if (student.Current == true)
            {
                this.curr_.Checked = true;
            }
            if (student.Obeyadjustment)
            {
                this.Obey_.Checked = true;
            }
            if (student.R_P_E)
            {
                this.Pe_.Checked = true;
            }
            if (student.Political == Political.Dan)
                this.Dan_.Checked = true;
            if (student.Political == Political.Qun)
                this.Qun_.Checked = true;
            if (student.Political == Political.Tuan)
                this.Tuan_.Checked = true;
            if (student.Political == Political.Wu)
                this.Wu_.Checked = true;
            if (student.Sex == Sex.Nan)
                this.Nan_.Checked = true;
            else this.Nv_.Checked = true;
            if (student.Source == Source.City)
                this.CIty_.Checked = true;
            else this.Country_.Checked = true;

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
