
namespace Form_DoAn1_N09
{
    partial class DSHoaDon
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
            this.ds_HoaDon = new System.Windows.Forms.DataGridView();
            this.btXemCT = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_HoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ds_HoaDon);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn";
            // 
            // ds_HoaDon
            // 
            this.ds_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ds_HoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ds_HoaDon.Location = new System.Drawing.Point(3, 18);
            this.ds_HoaDon.Name = "ds_HoaDon";
            this.ds_HoaDon.RowHeadersWidth = 51;
            this.ds_HoaDon.RowTemplate.Height = 24;
            this.ds_HoaDon.Size = new System.Drawing.Size(521, 300);
            this.ds_HoaDon.TabIndex = 0;
            // 
            // btXemCT
            // 
            this.btXemCT.Location = new System.Drawing.Point(370, 350);
            this.btXemCT.Name = "btXemCT";
            this.btXemCT.Size = new System.Drawing.Size(169, 43);
            this.btXemCT.TabIndex = 1;
            this.btXemCT.Text = "Xem DS chi tiết hóa đơn";
            this.btXemCT.UseVisualStyleBackColor = true;
            this.btXemCT.Click += new System.EventHandler(this.btXemCT_Click);
            // 
            // DSHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 414);
            this.Controls.Add(this.btXemCT);
            this.Controls.Add(this.groupBox1);
            this.Name = "DSHoaDon";
            this.Text = "Danh sách hóa đơn";
            this.Load += new System.EventHandler(this.DSHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ds_HoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ds_HoaDon;
        private System.Windows.Forms.Button btXemCT;
    }
}