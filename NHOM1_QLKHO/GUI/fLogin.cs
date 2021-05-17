using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHOM1_QLKHO.DAO;
namespace NHOM1_QLKHO.GUI
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tk = txttk.Text;

            string mk = txtmk.Text;
            if (tk != "")
            {
                if (AccoutDAO.Instance.KiemTraDN(tk, mk))
                {
                    fMain fMain = new fMain();
                    fMain.Show();

                    this.Hide();
                }
            }
        }
    }
}
