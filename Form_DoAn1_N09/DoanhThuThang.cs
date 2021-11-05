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
    public partial class DoanhThuThang : Form
    {
        private SqlConnection connection;
        private string connectionString = ConnectionString.connectionString;

        public DoanhThuThang()
        {
            InitializeComponent();
        }

        private void DoanhThuThang_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            this.AcceptButton = btXem;
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            try
            {
                string thang = tThang.Text;
                string nam = tNam.Text;
                string query = "select sum(TongTien) from HoaDon where Month(NgayLap) = @thang and Year(Ngaylap) = @nam";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@thang", thang);
                command.Parameters.AddWithValue("@nam", nam);
                //
                object KQ = command.ExecuteScalar();
                if (KQ.ToString() == "")
                    tDoanhThu.Text = "0";
                else
                    tDoanhThu.Text = KQ.ToString();
            }
            catch(Exception exception)
            {
                MessageBox.Show("Error!!!\n" + exception.Message);
            }
        }
    }
}
