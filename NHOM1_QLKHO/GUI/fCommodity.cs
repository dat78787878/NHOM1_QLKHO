using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHOM1_QLKHO.DatAccessLayer;
using NHOM1_QLKHO.DAO;

namespace NHOM1_QLKHO.GUI
{
    public partial class fCommodity : Form
    {
        BindingSource CommodityList = new BindingSource();

        public fCommodity()
        {
            InitializeComponent();
            LoadFirstTime();
        }
        private void LoadFirstTime()
        {
            dgvCommodity.DataSource = CommodityList;
            LoadListCommodity();
            EditDataGridView();
            BindingDataToFrom();
        }
        private void LoadListCommodity()
        {
            CommodityList.DataSource = CommodityDAO.Instance.GetAll();
        }
        private void EditDataGridView()
        {
            dgvCommodity.Columns["commodityCode"].HeaderText = "ID Hàng Hóa";
            dgvCommodity.Columns["commodityname"].HeaderText = "Tên Hàng Hóa";
            dgvCommodity.Columns["dateOfManufacture"].HeaderText = "Ngày SX";
            dgvCommodity.Columns["expiryDate"].HeaderText = "Hạn SD";
            dgvCommodity.Columns["producerCode"].HeaderText = "Mã NSX";
            dgvCommodity.Columns["amount"].HeaderText = "Số Lượng";
        }
        private void BindingDataToFrom()
        {
            txtCommodityCode.DataBindings.Add(new Binding("Text", dgvCommodity.DataSource, "commodityCode", true, DataSourceUpdateMode.Never));
            txtProducerCode.DataBindings.Add(new Binding("Text", dgvCommodity.DataSource, "producerCode", true, DataSourceUpdateMode.Never));
            
            dtpNSX.DataBindings.Add(new Binding("Text", dgvCommodity.DataSource, "dateOfManufacture", true, DataSourceUpdateMode.Never));
            dtpHSD.DataBindings.Add(new Binding("Text", dgvCommodity.DataSource, "expiryDate", true, DataSourceUpdateMode.Never));
            txtCommodityName.DataBindings.Add(new Binding("Text", dgvCommodity.DataSource, "commodityName", true, DataSourceUpdateMode.Never));

        }
        private void MakeNull()
        {
            txtCommodityCode.Text = "";
            txtCommodityName.Text = "";
            txtProducerCode.Text = "";
            dtpHSD.Value = DateTime.Now;
            dtpNSX.Value = DateTime.Now;
            
            txtTimKiem.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string CommodityName = txtCommodityName.Text.Trim();
           
            DateTime DateOfManufacture;
            DateTime.TryParse(dtpNSX.Text, out DateOfManufacture);
            DateTime ExpiryDate;
            DateTime.TryParse(dtpHSD.Text, out ExpiryDate);
            int ProducerCode=-1;
            Int32.TryParse(txtProducerCode.Text, out ProducerCode);
        


            try
            {
                if (CommodityName == "" || DateOfManufacture == null || ExpiryDate == null || ProducerCode == -1 )
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    return;
                }
                CommodityDAO.Instance.Insert(CommodityName,DateOfManufacture, ExpiryDate, ProducerCode);
                MessageBox.Show("Thêm thành công");
                LoadListCommodity();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadListCommodity();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int CommodityCode = -1;
            Int32.TryParse(txtCommodityCode.Text.Trim(), out CommodityCode);

            string CommodityName = txtCommodityName.Text.Trim();
            DateTime DateOfManufacture;
            DateTime.TryParse(dtpNSX.Text, out DateOfManufacture);
            DateTime ExpiryDate;
            DateTime.TryParse(dtpHSD.Text, out ExpiryDate);
            int ProducerCode=-1;
            Int32.TryParse(txtProducerCode.Text.Trim(), out ProducerCode);
           
            try
            {
                if (CommodityName == "" || DateOfManufacture== null || ExpiryDate == null || ProducerCode == -1 || CommodityCode == -1  )
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    return;
                }
                CommodityDAO.Instance.Update(CommodityCode, CommodityName, DateOfManufacture, ExpiryDate, ProducerCode);
                MessageBox.Show("Sửa thành công");
                LoadListCommodity();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadListCommodity();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int CommmodityCode;
            Int32.TryParse(txtCommodityCode.Text.Trim(), out CommmodityCode);
            try
            {
                CommodityDAO.Instance.Delete(CommmodityCode);
                MessageBox.Show("Xóa thành công");
                LoadListCommodity();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadListCommodity();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadListCommodity();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string str = txtTimKiem.Text.Trim();
            if (str == "")
            {
                MessageBox.Show("Chưa nhập thông tin tìm kiếm");
                return;
            }
            CommodityList.DataSource = CommodityDAO.Instance.Search(str);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fMain fMain = new fMain();
            fMain.Show();
            this.Hide();
        }
    }
}
