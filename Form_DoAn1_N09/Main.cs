using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Form_DoAn1_N09
{
    public partial class Main : Form
    {
        private SqlConnection connection;
        private string connectionString = ConnectionString.connectionString;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            this.AcceptButton = btXem;
        } 

        private void btThem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["ThemHoaDon"];
            if (fc != null)
                fc.Close();
            ThemHoaDon frm = new ThemHoaDon();
            frm.Show();

        }

        private void btXemDoanhThu_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["DoanhThuThang"];
            if (fc != null)
                fc.Close();
            DoanhThuThang frm = new DoanhThuThang();
            frm.Show();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["DSHoaDon"];
            if (fc != null)
                fc.Close();
            DSHoaDon frm = new DSHoaDon();
            frm.Show();
        }
    }
}
