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
    public partial class fBill : Form
    {
        BindingSource BillList = new BindingSource();
        public fBill()
        {
            InitializeComponent();
            LoadData();
            BindingDataToForm();
        }

        private void BindingDataToForm()
        {
            cbCommodityCode.DataBindings.Add(new Binding("Text", dgvBill.DataSource, "CommodityCode", true, DataSourceUpdateMode.Never));
            cbEmployeeCode.DataBindings.Add(new Binding("Text", dgvBill.DataSource, "EmployeeCode", true, DataSourceUpdateMode.Never));
            datetimeDateOfExport.DataBindings.Add(new Binding("Text", dgvBill.DataSource, "DateOfExport", true, DataSourceUpdateMode.Never));
            txtNumberOfExport.DataBindings.Add(new Binding("Text", dgvBill.DataSource, "NumberOfExport", true, DataSourceUpdateMode.Never));
        }

        private void LoadData()
        {
            dgvBill.DataSource = BillList;
            LoadListBill();
            EditDataGridViewHeader();
            LoadComboboxCommodityCode();
            LoadComboboxEmployeeCode();
        }

        private void LoadComboboxCommodityCode()
        { 
            cbCommodityCode.DataSource = CommodityDAO.Instance.GetAll();
            cbCommodityCode.DisplayMember = "CommodityCode";
        }

        private void LoadComboboxEmployeeCode()
        { 
            cbEmployeeCode.DataSource = EmployeeDAO.Instance.GetAll();
            cbEmployeeCode.DisplayMember = "EmployeeCode";
        }

        private void EditDataGridViewHeader()
        {
            dgvBill.Columns["BillCode"].HeaderText = "Mã phiếu xuất";
            dgvBill.Columns["CommodityCode"].HeaderText = "Mã hàng hóa";
            dgvBill.Columns["EmployeeCode"].HeaderText = "Mã nhân viên";
            dgvBill.Columns["DateOfExport"].HeaderText = "Ngày xuất phiếu";
            dgvBill.Columns["NumberOfExport"].HeaderText = "Số lượng phiếu xuất";
        }

        private void LoadListBill()
        {
            BillList.DataSource = BillDAO.Instance.GetAll();
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            LoadComboboxCommodityCode();
            LoadComboboxEmployeeCode();
            datetimeDateOfExport.Value = DateTime.Now;
            txtNumberOfExport.Text = "";
            txtSearch.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int CommodityCode = -1;
            Int32.TryParse(cbCommodityCode.Text, out CommodityCode);
            int EmployeeCode = -1;
            Int32.TryParse(cbEmployeeCode.Text, out EmployeeCode);
            DateTime DateOfExport;
            DateTime.TryParse(datetimeDateOfExport.Text, out DateOfExport);
            int NumberOfExprt = -1;
            Int32.TryParse(txtNumberOfExport.Text, out NumberOfExprt);


            try
            {
                if (CommodityCode == -1 || EmployeeCode == -1 || DateOfExport == null || NumberOfExprt == -1)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    return;
                }
                else
                {
                    BillDAO.Instance.Insert(CommodityCode, EmployeeCode, DateOfExport, NumberOfExprt);
                    MessageBox.Show("Thêm thành công");
                    LoadData();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int row = dgvBill.CurrentCell.RowIndex;
            int BillCode;
            Int32.TryParse(dgvBill.Rows[row].Cells[0].Value.ToString().Trim(), out BillCode);

            int CommodityCode = -1;
            Int32.TryParse(cbCommodityCode.Text, out CommodityCode);
            int EmployeeCode = -1;
            Int32.TryParse(cbEmployeeCode.Text, out EmployeeCode);
            DateTime DateOfExport;
            DateTime.TryParse(datetimeDateOfExport.Text, out DateOfExport);
            int NumberOfExprt = -1;
            Int32.TryParse(txtNumberOfExport.Text, out NumberOfExprt);

            try
            {
                if (CommodityCode == -1 || EmployeeCode == -1 || DateOfExport == null || NumberOfExprt == -1)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    return;
                }
                else if (MessageBox.Show("Bạn có thật sự muốn sửa phiếu xuất này!", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.Update(BillCode, CommodityCode, EmployeeCode, DateOfExport, NumberOfExprt);
                    MessageBox.Show("Cập nhật thành công");
                    LoadData();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int row = dgvBill.CurrentCell.RowIndex;
            int BillCode;
            Int32.TryParse(dgvBill.Rows[row].Cells[0].Value.ToString().Trim(), out BillCode);
            try
            {
                if (MessageBox.Show("Bạn có thật sự muốn xoá phiếu xuất này!", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.Delete(BillCode);
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadData();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BillList.DataSource = BillDAO.Instance.GetAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            if (search.Equals(""))
            {
                MessageBox.Show("Mời bạn nhập thông tin tìm kiếm!");
                return;
            }
            else
            {
                BillList.DataSource = BillDAO.Instance.Search(search);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fMain fMain = new fMain();
            fMain.Show();
            this.Hide();
        }
    }


}
