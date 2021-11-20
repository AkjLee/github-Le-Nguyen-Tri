
namespace BasicContronl
{
    partial class FrmMathBasic
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.KetQua = new System.Windows.Forms.Label();
            this.txtSoThuNhat = new System.Windows.Forms.TextBox();
            this.txtSoThuHai = new System.Windows.Forms.TextBox();
            this.btCong = new System.Windows.Forms.Button();
            this.btTru = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.btChia = new System.Windows.Forms.Button();
            this.O = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình toán học  cơ bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ nhất:";
         //   this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(33, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số thứ hai:";
           // this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // KetQua
            // 
            this.KetQua.AutoSize = true;
            this.KetQua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KetQua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KetQua.Location = new System.Drawing.Point(33, 183);
            this.KetQua.Name = "KetQua";
            this.KetQua.Size = new System.Drawing.Size(52, 15);
            this.KetQua.TabIndex = 2;
            this.KetQua.Text = "Kết quả:";
            //this.KetQua.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSoThuNhat
            // 
            this.txtSoThuNhat.Location = new System.Drawing.Point(129, 73);
            this.txtSoThuNhat.Name = "txtSoThuNhat";
            this.txtSoThuNhat.Size = new System.Drawing.Size(318, 20);
            this.txtSoThuNhat.TabIndex = 4;
            // 
            // txtSoThuHai
            // 
            this.txtSoThuHai.Location = new System.Drawing.Point(129, 114);
            this.txtSoThuHai.Name = "txtSoThuHai";
            this.txtSoThuHai.Size = new System.Drawing.Size(318, 20);
            this.txtSoThuHai.TabIndex = 4;
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(129, 152);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(75, 23);
            this.btCong.TabIndex = 5;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // btTru
            // 
            this.btTru.Location = new System.Drawing.Point(210, 152);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(75, 23);
            this.btTru.TabIndex = 5;
            this.btTru.Text = "-";
            this.btTru.UseVisualStyleBackColor = true;
            this.btTru.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btTru_MouseClick);
            // 
            // btNhan
            // 
            this.btNhan.Location = new System.Drawing.Point(291, 152);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(75, 23);
            this.btNhan.TabIndex = 5;
            this.btNhan.Text = "*";
            this.btNhan.UseVisualStyleBackColor = true;
            this.btNhan.Click += new System.EventHandler(this.btNhan_Click);
            // 
            // btChia
            // 
            this.btChia.Location = new System.Drawing.Point(372, 152);
            this.btChia.Name = "btChia";
            this.btChia.Size = new System.Drawing.Size(75, 23);
            this.btChia.TabIndex = 5;
            this.btChia.Text = "/";
            this.btChia.UseVisualStyleBackColor = true;
            this.btChia.Click += new System.EventHandler(this.btChia_Click);
            // 
            // O
            // 
            this.O.AutoSize = true;
            this.O.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.O.Location = new System.Drawing.Point(126, 185);
            this.O.Name = "O";
            this.O.Size = new System.Drawing.Size(15, 16);
            this.O.TabIndex = 6;
            this.O.Text = "0";
         //   this.O.Click += new System.EventHandler(this.label4_Click);
            // 
            // FrmMathBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 243);
            this.Controls.Add(this.O);
            this.Controls.Add(this.btChia);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.txtSoThuHai);
            this.Controls.Add(this.txtSoThuNhat);
            this.Controls.Add(this.KetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmMathBasic";
            this.Text = "Chương trình tính toán cơ bản";
           // this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label KetQua;
        private System.Windows.Forms.TextBox txtSoThuNhat;
        private System.Windows.Forms.TextBox txtSoThuHai;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btTru;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Button btChia;
        private System.Windows.Forms.Label O;
    }
}

