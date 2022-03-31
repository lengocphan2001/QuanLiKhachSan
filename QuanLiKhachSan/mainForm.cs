using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            
        }

        private void qlKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formKhachHang form = new formKhachHang();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.AutoScroll = true;
            form.AutoSize = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }

        private void qlPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPhong form = new formPhong();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.AutoScroll = true;
            form.AutoSize = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }
    }
}
