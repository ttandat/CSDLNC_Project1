
namespace Form_DoAn1_N09
{
    partial class DSCT_HoaDon
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
            this.dsCTHoaDon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dsCTHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dsCTHoaDon
            // 
            this.dsCTHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsCTHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsCTHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dsCTHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.dsCTHoaDon.Name = "dsCTHoaDon";
            this.dsCTHoaDon.RowHeadersWidth = 82;
            this.dsCTHoaDon.RowTemplate.Height = 33;
            this.dsCTHoaDon.Size = new System.Drawing.Size(800, 450);
            this.dsCTHoaDon.TabIndex = 1;
            // 
            // DSCT_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dsCTHoaDon);
            this.Name = "DSCT_HoaDon";
            this.Text = "DSCT_HoaDon";
            this.Load += new System.EventHandler(this.DSCT_HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCTHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dsCTHoaDon;
    }
}