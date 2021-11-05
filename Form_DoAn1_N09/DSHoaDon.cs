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
    public partial class DSHoaDon : Form
    {
        private SqlConnection con;
        private SqlDataAdapter dap;
        public DSHoaDon()
        {
            InitializeComponent();
        }

        private void DSHoaDon_Load(object sender, EventArgs e)
        {
            string connectString = ConnectionString.connectionString;
            con = new SqlConnection(connectString);

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            dap = new SqlDataAdapter("SELECT * FROM HoaDon", con);
            var table = new DataTable();
            dap.Fill(table);
            ds_HoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ds_HoaDon.DataSource = table;

            con.Close();
        }

        private void btXemCT_Click(object sender, EventArgs e)
        {
            var form = new DSCT_HoaDon();
            form.Show();
        }
    }
}
