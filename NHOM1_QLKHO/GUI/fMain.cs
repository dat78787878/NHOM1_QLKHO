using NHOM1_QLKHO.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHOM1_QLKHO
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void qUẢNLÝNHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fEmployee().Show();
            this.Hide();
        }

        private void qUẢNLÝPHIẾUXUẤTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBill frm = new fBill();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
        private void qUẢNLÝHÀNGTRONGKHOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fCommodity().Show();
            this.Hide();

        }
    }
}
