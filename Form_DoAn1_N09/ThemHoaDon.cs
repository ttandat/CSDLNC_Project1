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
    public partial class ThemHoaDon : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        public ThemHoaDon()
        {
            InitializeComponent();
        }

        private void ThemHoaDon_Load(object sender, EventArgs e)
        {
            string connectString = ConnectionString.connectionString;
            con = new SqlConnection(connectString);
        }

        private void buttonAddDH_Click(object sender, EventArgs e)
        {
            try
            {
                string maHD = inputMaHD.Text;
                string maKH = inputMaKH.Text;
                string ngayLap = inputNgayLap.Text;

                string sql = "INSERT INTO HoaDon(MaHD, MaKH, NgayLap)";
                sql += "VALUES('" + maHD + "','" + maKH + "','" + ngayLap + "')";

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("HoaDon added successfully!", "Result");

                inputMaHD.Text = "";
                inputMaKH.Text = "";
                inputNgayLap.Value = DateTime.Now;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add HoaDon!\n\n" + ex.Message, "Result");
            }
        }

        private void buttonAddCTHoaDon_Click(object sender, EventArgs e)
        {
            var form = new ThemCT_HoaDon();
            form.Show();
        }
    }
}
