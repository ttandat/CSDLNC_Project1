
namespace Form_DoAn1_N09
{
    partial class ThemHoaDon
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
            this.layoutAddHoaDon = new System.Windows.Forms.TableLayoutPanel();
            this.labelMaDH = new System.Windows.Forms.Label();
            this.inputMaHD = new System.Windows.Forms.TextBox();
            this.labelMaKH = new System.Windows.Forms.Label();
            this.inputNgayLap = new System.Windows.Forms.DateTimePicker();
            this.inputMaKH = new System.Windows.Forms.TextBox();
            this.labelNgayLap = new System.Windows.Forms.Label();
            this.buttonAddDH = new System.Windows.Forms.Button();
            this.buttonAddCTHoaDon = new System.Windows.Forms.Button();
            this.layoutAddHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutAddHoaDon
            // 
            this.layoutAddHoaDon.ColumnCount = 2;
            this.layoutAddHoaDon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutAddHoaDon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.layoutAddHoaDon.Controls.Add(this.labelMaDH, 0, 0);
            this.layoutAddHoaDon.Controls.Add(this.inputMaHD, 1, 0);
            this.layoutAddHoaDon.Controls.Add(this.labelMaKH, 0, 1);
            this.layoutAddHoaDon.Controls.Add(this.inputNgayLap, 1, 2);
            this.layoutAddHoaDon.Controls.Add(this.inputMaKH, 1, 1);
            this.layoutAddHoaDon.Controls.Add(this.labelNgayLap, 0, 2);
            this.layoutAddHoaDon.Controls.Add(this.buttonAddDH, 1, 3);
            this.layoutAddHoaDon.Controls.Add(this.buttonAddCTHoaDon, 1, 4);
            this.layoutAddHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutAddHoaDon.Location = new System.Drawing.Point(0, 0);
            this.layoutAddHoaDon.Margin = new System.Windows.Forms.Padding(0);
            this.layoutAddHoaDon.Name = "layoutAddHoaDon";
            this.layoutAddHoaDon.RowCount = 5;
            this.layoutAddHoaDon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layoutAddHoaDon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layoutAddHoaDon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layoutAddHoaDon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.10169F));
            this.layoutAddHoaDon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.94915F));
            this.layoutAddHoaDon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layoutAddHoaDon.Size = new System.Drawing.Size(399, 236);
            this.layoutAddHoaDon.TabIndex = 12;
            // 
            // labelMaDH
            // 
            this.labelMaDH.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelMaDH.AutoSize = true;
            this.labelMaDH.Location = new System.Drawing.Point(2, 15);
            this.labelMaDH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaDH.Name = "labelMaDH";
            this.labelMaDH.Size = new System.Drawing.Size(47, 17);
            this.labelMaDH.TabIndex = 2;
            this.labelMaDH.Text = "MaHD";
            // 
            // inputMaHD
            // 
            this.inputMaHD.AccessibleName = "";
            this.inputMaHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputMaHD.Location = new System.Drawing.Point(101, 12);
            this.inputMaHD.Margin = new System.Windows.Forms.Padding(2);
            this.inputMaHD.Name = "inputMaHD";
            this.inputMaHD.Size = new System.Drawing.Size(296, 22);
            this.inputMaHD.TabIndex = 1;
            // 
            // labelMaKH
            // 
            this.labelMaKH.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelMaKH.AutoSize = true;
            this.labelMaKH.Location = new System.Drawing.Point(2, 62);
            this.labelMaKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaKH.Name = "labelMaKH";
            this.labelMaKH.Size = new System.Drawing.Size(46, 17);
            this.labelMaKH.TabIndex = 5;
            this.labelMaKH.Text = "MaKH";
            // 
            // inputNgayLap
            // 
            this.inputNgayLap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNgayLap.Checked = false;
            this.inputNgayLap.CustomFormat = "";
            this.inputNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inputNgayLap.Location = new System.Drawing.Point(101, 106);
            this.inputNgayLap.Margin = new System.Windows.Forms.Padding(2);
            this.inputNgayLap.Name = "inputNgayLap";
            this.inputNgayLap.Size = new System.Drawing.Size(296, 22);
            this.inputNgayLap.TabIndex = 7;
            // 
            // inputMaKH
            // 
            this.inputMaKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputMaKH.Location = new System.Drawing.Point(101, 59);
            this.inputMaKH.Margin = new System.Windows.Forms.Padding(2);
            this.inputMaKH.Name = "inputMaKH";
            this.inputMaKH.Size = new System.Drawing.Size(296, 22);
            this.inputMaKH.TabIndex = 4;
            // 
            // labelNgayLap
            // 
            this.labelNgayLap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNgayLap.AutoSize = true;
            this.labelNgayLap.Location = new System.Drawing.Point(2, 109);
            this.labelNgayLap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNgayLap.Name = "labelNgayLap";
            this.labelNgayLap.Size = new System.Drawing.Size(65, 17);
            this.labelNgayLap.TabIndex = 6;
            this.labelNgayLap.Text = "NgayLap";
            // 
            // buttonAddDH
            // 
            this.buttonAddDH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddDH.Location = new System.Drawing.Point(101, 150);
            this.buttonAddDH.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddDH.Name = "buttonAddDH";
            this.buttonAddDH.Size = new System.Drawing.Size(296, 26);
            this.buttonAddDH.TabIndex = 3;
            this.buttonAddDH.Text = "Add HoaDon";
            this.buttonAddDH.UseVisualStyleBackColor = true;
            this.buttonAddDH.Click += new System.EventHandler(this.buttonAddDH_Click);
            // 
            // buttonAddCTHoaDon
            // 
            this.buttonAddCTHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddCTHoaDon.Location = new System.Drawing.Point(101, 198);
            this.buttonAddCTHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddCTHoaDon.Name = "buttonAddCTHoaDon";
            this.buttonAddCTHoaDon.Size = new System.Drawing.Size(296, 26);
            this.buttonAddCTHoaDon.TabIndex = 11;
            this.buttonAddCTHoaDon.Text = "Add CT_HoaDon";
            this.buttonAddCTHoaDon.UseVisualStyleBackColor = true;
            this.buttonAddCTHoaDon.Click += new System.EventHandler(this.buttonAddCTHoaDon_Click);
            // 
            // ThemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 272);
            this.Controls.Add(this.layoutAddHoaDon);
            this.MaximizeBox = false;
            this.Name = "ThemHoaDon";
            this.Text = "Thêm hóa đơn";
            this.Load += new System.EventHandler(this.ThemHoaDon_Load);
            this.layoutAddHoaDon.ResumeLayout(false);
            this.layoutAddHoaDon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutAddHoaDon;
        private System.Windows.Forms.Label labelMaDH;
        private System.Windows.Forms.TextBox inputMaHD;
        private System.Windows.Forms.Label labelMaKH;
        private System.Windows.Forms.DateTimePicker inputNgayLap;
        private System.Windows.Forms.TextBox inputMaKH;
        private System.Windows.Forms.Label labelNgayLap;
        private System.Windows.Forms.Button buttonAddDH;
        private System.Windows.Forms.Button buttonAddCTHoaDon;
    }
}