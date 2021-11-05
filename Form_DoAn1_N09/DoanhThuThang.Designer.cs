
namespace Form_DoAn1_N09
{
    partial class DoanhThuThang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tNam = new System.Windows.Forms.TextBox();
            this.tThang = new System.Windows.Forms.TextBox();
            this.lbNam = new System.Windows.Forms.Label();
            this.lbThang = new System.Windows.Forms.Label();
            this.tDoanhThu = new System.Windows.Forms.TextBox();
            this.lbDoanhThu = new System.Windows.Forms.Label();
            this.btXem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tNam);
            this.groupBox1.Controls.Add(this.tThang);
            this.groupBox1.Controls.Add(this.lbNam);
            this.groupBox1.Controls.Add(this.lbThang);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(76, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 148);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // tNam
            // 
            this.tNam.Location = new System.Drawing.Point(139, 83);
            this.tNam.Name = "tNam";
            this.tNam.Size = new System.Drawing.Size(129, 22);
            this.tNam.TabIndex = 11;
            // 
            // tThang
            // 
            this.tThang.Location = new System.Drawing.Point(139, 31);
            this.tThang.Name = "tThang";
            this.tThang.Size = new System.Drawing.Size(129, 22);
            this.tThang.TabIndex = 10;
            // 
            // lbNam
            // 
            this.lbNam.AutoSize = true;
            this.lbNam.Location = new System.Drawing.Point(65, 86);
            this.lbNam.Name = "lbNam";
            this.lbNam.Size = new System.Drawing.Size(41, 17);
            this.lbNam.TabIndex = 12;
            this.lbNam.Text = "Năm:";
            // 
            // lbThang
            // 
            this.lbThang.AutoSize = true;
            this.lbThang.Location = new System.Drawing.Point(65, 36);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(57, 17);
            this.lbThang.TabIndex = 13;
            this.lbThang.Text = "Tháng: ";
            // 
            // tDoanhThu
            // 
            this.tDoanhThu.Enabled = false;
            this.tDoanhThu.Location = new System.Drawing.Point(192, 328);
            this.tDoanhThu.Name = "tDoanhThu";
            this.tDoanhThu.Size = new System.Drawing.Size(216, 22);
            this.tDoanhThu.TabIndex = 15;
            // 
            // lbDoanhThu
            // 
            this.lbDoanhThu.AutoSize = true;
            this.lbDoanhThu.Location = new System.Drawing.Point(73, 333);
            this.lbDoanhThu.Name = "lbDoanhThu";
            this.lbDoanhThu.Size = new System.Drawing.Size(78, 17);
            this.lbDoanhThu.TabIndex = 14;
            this.lbDoanhThu.Text = "Doanh thu:";
            // 
            // btXem
            // 
            this.btXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btXem.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btXem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btXem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXem.Location = new System.Drawing.Point(166, 238);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(152, 41);
            this.btXem.TabIndex = 13;
            this.btXem.Text = "Xem doanh thu";
            this.btXem.UseVisualStyleBackColor = false;
            this.btXem.Click += new System.EventHandler(this.btXem_Click);
            // 
            // DoanhThuThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 437);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tDoanhThu);
            this.Controls.Add(this.lbDoanhThu);
            this.Controls.Add(this.btXem);
            this.Name = "DoanhThuThang";
            this.Text = "Doanh thu tháng";
            this.Load += new System.EventHandler(this.DoanhThuThang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tNam;
        private System.Windows.Forms.TextBox tThang;
        private System.Windows.Forms.Label lbNam;
        private System.Windows.Forms.Label lbThang;
        private System.Windows.Forms.TextBox tDoanhThu;
        private System.Windows.Forms.Label lbDoanhThu;
        private System.Windows.Forms.Button btXem;
    }
}