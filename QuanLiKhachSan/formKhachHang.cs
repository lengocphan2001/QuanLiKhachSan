using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan
{
    public partial class formKhachHang : Form
    {
        public formKhachHang()
        {
            InitializeComponent();
            Connection a = new Connection();
            string connectionString = a.getConnection();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string command = "select *from tblKhachHang";
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(command, con);
                adp.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = dr.Cells[0].Value.ToString();
            textBox2.Text = dr.Cells[1].Value.ToString();
            textBox3.Text = dr.Cells[3].Value.ToString();
            comboBox1.SelectedItem = dr.Cells[2].Value.ToString();
            textBox4.Text = dr.Cells[4].Value.ToString();
            textBox5.Text = dr.Cells[5].Value.ToString();
        }
    }
}
