
namespace Form_DoAn1_N09
{
    partial class Main
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
            this.btThem = new System.Windows.Forms.Button();
            this.btXem = new System.Windows.Forms.Button();
            this.btXemDoanhThu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(77, 181);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(141, 76);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm hóa đơn";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXem
            // 
            this.btXem.Location = new System.Drawing.Point(257, 181);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(141, 76);
            this.btXem.TabIndex = 1;
            this.btXem.Text = "Xem danh sách hóa đơn";
            this.btXem.UseVisualStyleBackColor = true;
            this.btXem.Click += new System.EventHandler(this.btXem_Click);
            // 
            // btXemDoanhThu
            // 
            this.btXemDoanhThu.Location = new System.Drawing.Point(437, 181);
            this.btXemDoanhThu.Name = "btXemDoanhThu";
            this.btXemDoanhThu.Size = new System.Drawing.Size(141, 76);
            this.btXemDoanhThu.TabIndex = 2;
            this.btXemDoanhThu.Text = "Xem doanh thu";
            this.btXemDoanhThu.UseVisualStyleBackColor = true;
            this.btXemDoanhThu.Click += new System.EventHandler(this.btXemDoanhThu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "ĐỒ ÁN 1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btXemDoanhThu);
            this.Controls.Add(this.btXem);
            this.Controls.Add(this.btThem);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "N09";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXem;
        private System.Windows.Forms.Button btXemDoanhThu;
        private System.Windows.Forms.Label label1;
    }
}

