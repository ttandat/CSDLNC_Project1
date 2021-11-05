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
    public partial class ThemCT_HoaDon : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        public ThemCT_HoaDon()
        {
            InitializeComponent();
        }

        private void ThemCT_HoaDon_Load(object sender, EventArgs e)
        {
            string connectString = ConnectionString.connectionString;
            con = new SqlConnection(connectString);
        }

        private void buttonAddCTHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                string maHD = inputMaHD.Text;
                string maSP = inputMaSP.Text;
                string soLuong = inputSoLuong.Text;
                string giaBan = inputGiaBan.Text;
                string giaGiam = inputGiaGiam.Text;

                string sql = "INSERT INTO CT_HoaDon(MaHD, MaSP, SoLuong, GiaBan, GiaGiam)";
                sql += "VALUES('" + maHD + "','" + maSP + "','" + soLuong + "','" + giaBan + "','" + giaGiam + "')";

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("CT_HoaDon added successfully!", "Result");

                inputMaHD.Text = "";
                inputMaSP.Text = "";
                inputSoLuong.Value = 1;
                inputGiaBan.Text = "";
                inputGiaGiam.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add CT_HoaDon!\n\n" + ex.Message, "Result");
            }
        }
    }
}
