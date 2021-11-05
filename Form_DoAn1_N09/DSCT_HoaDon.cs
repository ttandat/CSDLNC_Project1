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
    public partial class DSCT_HoaDon : Form
    {
        private SqlConnection con;
        private SqlDataAdapter dap;
        public DSCT_HoaDon()
        {
            InitializeComponent();
        }

        private void DSCT_HoaDon_Load(object sender, EventArgs e)
        { 
            con = new SqlConnection(ConnectionString.connectionString);

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            dap = new SqlDataAdapter("SELECT * FROM CT_HoaDon", con);
            var table = new DataTable();
            dap.Fill(table);
            dsCTHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dsCTHoaDon.DataSource = table;

            con.Close();
        }
    }
}
