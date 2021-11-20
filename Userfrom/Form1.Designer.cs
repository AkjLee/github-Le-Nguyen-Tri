
namespace Userfrom
{
    partial class Userfrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Avartar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbKhac = new System.Windows.Forms.CheckBox();
            this.cbNu = new System.Windows.Forms.CheckBox();
            this.cbNam = new System.Windows.Forms.CheckBox();
            this.ttHoten = new System.Windows.Forms.TextBox();
            this.ttQuequan = new System.Windows.Forms.TextBox();
            this.ttNoisinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Avartar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Avartar
            // 
            this.Avartar.Image = global::Userfrom.Properties.Resources.Windows_10___4_;
            this.Avartar.Location = new System.Drawing.Point(27, 37);
            this.Avartar.Name = "Avartar";
            this.Avartar.Size = new System.Drawing.Size(133, 131);
            this.Avartar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avartar.TabIndex = 0;
            this.Avartar.TabStop = false;
            this.Avartar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin cá nhân";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.cbKhac);
            this.groupBox1.Controls.Add(this.cbNu);
            this.groupBox1.Controls.Add(this.cbNam);
            this.groupBox1.Controls.Add(this.ttHoten);
            this.groupBox1.Controls.Add(this.ttQuequan);
            this.groupBox1.Controls.Add(this.ttNoisinh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(166, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 246);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lý lịch";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(117, 63);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 23);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // cbKhac
            // 
            this.cbKhac.AutoSize = true;
            this.cbKhac.Location = new System.Drawing.Point(244, 130);
            this.cbKhac.Name = "cbKhac";
            this.cbKhac.Size = new System.Drawing.Size(56, 20);
            this.cbKhac.TabIndex = 2;
            this.cbKhac.Text = "Khác";
            this.cbKhac.UseVisualStyleBackColor = true;
            // 
            // cbNu
            // 
            this.cbNu.AutoSize = true;
            this.cbNu.Location = new System.Drawing.Point(178, 130);
            this.cbNu.Name = "cbNu";
            this.cbNu.Size = new System.Drawing.Size(45, 20);
            this.cbNu.TabIndex = 2;
            this.cbNu.Text = "Nữ";
            this.cbNu.UseVisualStyleBackColor = true;
            // 
            // cbNam
            // 
            this.cbNam.AutoSize = true;
            this.cbNam.Checked = true;
            this.cbNam.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNam.Location = new System.Drawing.Point(118, 130);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(54, 20);
            this.cbNam.TabIndex = 2;
            this.cbNam.Text = "Nam";
            this.cbNam.UseVisualStyleBackColor = true;
            // 
            // ttHoten
            // 
            this.ttHoten.Location = new System.Drawing.Point(118, 31);
            this.ttHoten.Name = "ttHoten";
            this.ttHoten.Size = new System.Drawing.Size(199, 23);
            this.ttHoten.TabIndex = 1;
            this.ttHoten.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ttQuequan
            // 
            this.ttQuequan.Location = new System.Drawing.Point(118, 156);
            this.ttQuequan.Multiline = true;
            this.ttQuequan.Name = "ttQuequan";
            this.ttQuequan.Size = new System.Drawing.Size(199, 67);
            this.ttQuequan.TabIndex = 1;
            this.ttQuequan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ttNoisinh
            // 
            this.ttNoisinh.Location = new System.Drawing.Point(118, 97);
            this.ttNoisinh.Name = "ttNoisinh";
            this.ttNoisinh.Size = new System.Drawing.Size(199, 23);
            this.ttNoisinh.TabIndex = 1;
            this.ttNoisinh.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ tên:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quê quán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới tính:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nơi sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày tháng năm:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // Userfrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 457);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Avartar);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Userfrom";
            this.Text = "Thông tin cá nhân";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Avartar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Avartar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttHoten;
        private System.Windows.Forms.CheckBox cbKhac;
        private System.Windows.Forms.CheckBox cbNu;
        private System.Windows.Forms.CheckBox cbNam;
        private System.Windows.Forms.TextBox ttQuequan;
        private System.Windows.Forms.TextBox ttNoisinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

