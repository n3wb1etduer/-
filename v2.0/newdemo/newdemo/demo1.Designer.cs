namespace newdemo
{
    partial class demo1
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
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.server = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.addmas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.database = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tablename = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.granularity = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.ROW = new System.Windows.Forms.Label();
            this.COL = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.jiamilie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(732, 145);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "版权所有";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(807, 145);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 15);
            this.label10.TabIndex = 30;
            this.label10.Text = "Version 2.0";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(82, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "服务器：";
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(177, 47);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(100, 25);
            this.server.TabIndex = 32;
            this.server.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(648, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "密码：";
            // 
            // passwd
            // 
            this.passwd.Location = new System.Drawing.Point(760, 47);
            this.passwd.Name = "passwd";
            this.passwd.Size = new System.Drawing.Size(100, 25);
            this.passwd.TabIndex = 34;
            this.passwd.Text = "123456";
            this.passwd.UseSystemPasswordChar = true;
            this.passwd.TextChanged += new System.EventHandler(this.passwd_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(359, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "用户名：";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(454, 47);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 25);
            this.username.TabIndex = 36;
            this.username.Text = "root";
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // addmas
            // 
            this.addmas.Location = new System.Drawing.Point(933, 77);
            this.addmas.Margin = new System.Windows.Forms.Padding(4);
            this.addmas.Name = "addmas";
            this.addmas.Size = new System.Drawing.Size(100, 29);
            this.addmas.TabIndex = 37;
            this.addmas.Text = "添加水印";
            this.addmas.UseVisualStyleBackColor = true;
            this.addmas.Click += new System.EventHandler(this.addmas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(82, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "数据库：";
            // 
            // database
            // 
            this.database.Location = new System.Drawing.Point(177, 97);
            this.database.Margin = new System.Windows.Forms.Padding(4);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(132, 25);
            this.database.TabIndex = 39;
            this.database.Text = "demo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(361, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "表名：";
            // 
            // tablename
            // 
            this.tablename.Location = new System.Drawing.Point(454, 97);
            this.tablename.Margin = new System.Windows.Forms.Padding(4);
            this.tablename.Name = "tablename";
            this.tablename.Size = new System.Drawing.Size(132, 25);
            this.tablename.TabIndex = 41;
            this.tablename.Text = "weather";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(648, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 19);
            this.label7.TabIndex = 42;
            this.label7.Text = "水印粒度：";
            // 
            // granularity
            // 
            this.granularity.Location = new System.Drawing.Point(761, 97);
            this.granularity.Margin = new System.Windows.Forms.Padding(4);
            this.granularity.Name = "granularity";
            this.granularity.Size = new System.Drawing.Size(100, 25);
            this.granularity.TabIndex = 43;
            this.granularity.Text = "3";
            this.granularity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(933, 112);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 44;
            this.button2.Text = "检查水印";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(933, 40);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(100, 30);
            this.connect.TabIndex = 45;
            this.connect.Text = "连接";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(361, 145);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 19);
            this.label9.TabIndex = 46;
            this.label9.Text = "行数：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(82, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 47;
            this.label6.Text = "列数：";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(933, 149);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 29);
            this.button3.TabIndex = 48;
            this.button3.Text = "攻击水印";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(947, 312);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(177, 185);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(642, 29);
            this.progressBar1.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(82, 195);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 19);
            this.label12.TabIndex = 51;
            this.label12.Text = "进度：";
            // 
            // ROW
            // 
            this.ROW.AutoSize = true;
            this.ROW.Location = new System.Drawing.Point(451, 145);
            this.ROW.Name = "ROW";
            this.ROW.Size = new System.Drawing.Size(15, 15);
            this.ROW.TabIndex = 52;
            this.ROW.Text = "0";
            // 
            // COL
            // 
            this.COL.AutoSize = true;
            this.COL.Location = new System.Drawing.Point(174, 149);
            this.COL.Name = "COL";
            this.COL.Size = new System.Drawing.Size(15, 15);
            this.COL.TabIndex = 53;
            this.COL.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(869, 100);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 15);
            this.label11.TabIndex = 55;
            this.label11.Text = "%";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(841, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 20);
            this.label13.TabIndex = 56;
            this.label13.Text = "加密列：";
            // 
            // jiamilie
            // 
            this.jiamilie.Location = new System.Drawing.Point(933, 189);
            this.jiamilie.Name = "jiamilie";
            this.jiamilie.Size = new System.Drawing.Size(100, 25);
            this.jiamilie.TabIndex = 57;
            this.jiamilie.Text = "11";
            this.jiamilie.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // demo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 593);
            this.Controls.Add(this.jiamilie);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.COL);
            this.Controls.Add(this.ROW);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.granularity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tablename);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.database);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addmas);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.server);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Name = "demo1";
            this.Text = "demo1";
            this.Load += new System.EventHandler(this.demo1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button addmas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox database;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tablename;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox granularity;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label ROW;
        private System.Windows.Forms.Label COL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox jiamilie;
    }
}

