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
    public partial class formPhong : Form
    {
        public formPhong()
        {
            InitializeComponent();
            Connection a = new Connection();
            string connectString = a.getConnection();
            using (SqlConnection cnn = new SqlConnection(connectString))
            {
                cnn.Open();
                string cmd = "select *from tblPhong";
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd, cnn);
                adp.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                cnn.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = dr.Cells[0].Value.ToString();
            textBox2.Text = dr.Cells[1].Value.ToString();
            textBox3.Text = dr.Cells[4].Value.ToString();
            comboBox1.SelectedItem = dr.Cells[2].Value.ToString();
            comboBox2.SelectedItem = dr.Cells[3].Value.ToString();
        }
    }
}
