using NHOM1_QLKHO.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHOM1_QLKHO.GUI
{
    public partial class fCommodityStatistics : Form
    {
        public fCommodityStatistics()
        {
            InitializeComponent();
            LoadCommodityList();
        }

        public void LoadCommodityList()
        {
            dtgvCommodity.DataSource = CommodityDAO.Instance.GetCommodityList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCommodityList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string commodityname = txtCommodityName.Text;
            dtgvCommodity.DataSource = CommodityDAO.Instance.GetCommodityListByName(commodityname);
        }
    }
}
