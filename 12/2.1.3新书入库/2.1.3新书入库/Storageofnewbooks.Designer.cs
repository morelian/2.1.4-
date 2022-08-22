namespace _2._1._3新书入库
{
    partial class Storageofnewbooks
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Addbooks = new System.Windows.Forms.Button();
            this.text_Num = new System.Windows.Forms.TextBox();
            this.text_Author = new System.Windows.Forms.TextBox();
            this.text_Name = new System.Windows.Forms.TextBox();
            this.text_Price = new System.Windows.Forms.TextBox();
            this.text_Publication = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Vname = new System.Windows.Forms.Label();
            this.Vnum = new System.Windows.Forms.Label();
            this.zairu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Addbooks
            // 
            this.Addbooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Addbooks.BackgroundImage = global::_2._1._3新书入库.Properties.Resources.QQ图片20220529133523;
            this.Addbooks.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Addbooks.ForeColor = System.Drawing.Color.Black;
            this.Addbooks.Location = new System.Drawing.Point(414, 288);
            this.Addbooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Addbooks.Name = "Addbooks";
            this.Addbooks.Size = new System.Drawing.Size(112, 53);
            this.Addbooks.TabIndex = 1;
            this.Addbooks.Text = "入库";
            this.Addbooks.UseVisualStyleBackColor = false;
            this.Addbooks.Click += new System.EventHandler(this.Storage_of_newbooks);
            // 
            // text_Num
            // 
            this.text_Num.BackColor = System.Drawing.SystemColors.HighlightText;
            this.text_Num.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_Num.Location = new System.Drawing.Point(277, 98);
            this.text_Num.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_Num.Name = "text_Num";
            this.text_Num.Size = new System.Drawing.Size(101, 23);
            this.text_Num.TabIndex = 2;
            this.text_Num.Click += new System.EventHandler(this.Num);
            this.text_Num.TextChanged += new System.EventHandler(this.text_Num_TextChanged);
            this.text_Num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_Num_KeyPress);
            // 
            // text_Author
            // 
            this.text_Author.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_Author.Location = new System.Drawing.Point(277, 138);
            this.text_Author.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_Author.Name = "text_Author";
            this.text_Author.Size = new System.Drawing.Size(101, 23);
            this.text_Author.TabIndex = 3;
            this.text_Author.Click += new System.EventHandler(this.Author);
            // 
            // text_Name
            // 
            this.text_Name.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_Name.Location = new System.Drawing.Point(277, 59);
            this.text_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_Name.Name = "text_Name";
            this.text_Name.Size = new System.Drawing.Size(101, 23);
            this.text_Name.TabIndex = 4;
            this.text_Name.Click += new System.EventHandler(this.Name_);
            // 
            // text_Price
            // 
            this.text_Price.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_Price.Location = new System.Drawing.Point(277, 178);
            this.text_Price.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_Price.Name = "text_Price";
            this.text_Price.Size = new System.Drawing.Size(101, 23);
            this.text_Price.TabIndex = 5;
            this.text_Price.Click += new System.EventHandler(this.Price);
            this.text_Price.TextChanged += new System.EventHandler(this.text_Price_TextChanged);
            this.text_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_Price_KeyPress);
            // 
            // text_Publication
            // 
            this.text_Publication.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_Publication.Location = new System.Drawing.Point(277, 217);
            this.text_Publication.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_Publication.Name = "text_Publication";
            this.text_Publication.Size = new System.Drawing.Size(101, 23);
            this.text_Publication.TabIndex = 6;
            this.text_Publication.TextChanged += new System.EventHandler(this.Date);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(123, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "书名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(123, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "书号";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(123, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "作者";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(123, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "价格";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(123, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "出版日期";
            // 
            // Vname
            // 
            this.Vname.AutoSize = true;
            this.Vname.BackColor = System.Drawing.Color.White;
            this.Vname.ForeColor = System.Drawing.Color.Red;
            this.Vname.Location = new System.Drawing.Point(282, 84);
            this.Vname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Vname.Name = "Vname";
            this.Vname.Size = new System.Drawing.Size(0, 10);
            this.Vname.TabIndex = 12;
            this.Vname.Click += new System.EventHandler(this.name_);
            // 
            // Vnum
            // 
            this.Vnum.AutoSize = true;
            this.Vnum.ForeColor = System.Drawing.Color.Red;
            this.Vnum.Location = new System.Drawing.Point(275, 124);
            this.Vnum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Vnum.Name = "Vnum";
            this.Vnum.Size = new System.Drawing.Size(0, 10);
            this.Vnum.TabIndex = 13;
            // 
            // zairu
            // 
            this.zairu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.zairu.BackgroundImage = global::_2._1._3新书入库.Properties.Resources.QQ图片20220529133523;
            this.zairu.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zairu.ForeColor = System.Drawing.Color.Black;
            this.zairu.Location = new System.Drawing.Point(102, 288);
            this.zairu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zairu.Name = "zairu";
            this.zairu.Size = new System.Drawing.Size(110, 53);
            this.zairu.TabIndex = 14;
            this.zairu.Text = "载入&入库";
            this.zairu.UseVisualStyleBackColor = true;
            this.zairu.Click += new System.EventHandler(this.zairu_Click);
            // 
            // Storageofnewbooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 10F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_2._1._3新书入库.Properties.Resources.QQ图片20220528162251;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(667, 376);
            this.Controls.Add(this.zairu);
            this.Controls.Add(this.Vnum);
            this.Controls.Add(this.Vname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_Publication);
            this.Controls.Add(this.text_Price);
            this.Controls.Add(this.text_Name);
            this.Controls.Add(this.text_Author);
            this.Controls.Add(this.text_Num);
            this.Controls.Add(this.Addbooks);
            this.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Storageofnewbooks";
            this.Text = "新书&入库";
            this.Load += new System.EventHandler(this.Storage_of_newbooks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Addbooks;
        private System.Windows.Forms.TextBox text_Num;
        private System.Windows.Forms.TextBox text_Author;
        private System.Windows.Forms.TextBox text_Name;
        private System.Windows.Forms.TextBox text_Price;
        private System.Windows.Forms.TextBox text_Publication;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Vname;
        private System.Windows.Forms.Label Vnum;
        private System.Windows.Forms.Button zairu;
    }
}

