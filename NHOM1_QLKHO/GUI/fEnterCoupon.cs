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
    public partial class fEnterCoupon : Form
    {
        BindingSource enterCouponList = new BindingSource();
        public fEnterCoupon()
        {
            InitializeComponent();
            LoadData();
            BindingDataToForm();
        }

        private void BindingDataToForm()
        {
            cbbMMH.DataBindings.Add(new Binding("Text", dgvEnterCoupon.DataSource, "CommodityCode", true, DataSourceUpdateMode.Never));
            cbbMNV.DataBindings.Add(new Binding("Text", dgvEnterCoupon.DataSource, "EmployeeCode", true, DataSourceUpdateMode.Never));
            dtNN.DataBindings.Add(new Binding("Text", dgvEnterCoupon.DataSource, "DateOfImport", true, DataSourceUpdateMode.Never));
            txtSLN.DataBindings.Add(new Binding("Text", dgvEnterCoupon.DataSource, "NumberOfImport", true, DataSourceUpdateMode.Never));
        }

        private void LoadData()
        {
            dgvEnterCoupon.DataSource = enterCouponList;
            LoadBookList();
            EditDataGridViewHeader();
            LoadDataCombobox();
        }

        private void LoadDataCombobox()
        {
            cbbMMH.DataSource = CommodityDAO.Instance.GetAll();
            cbbMMH.DisplayMember = "CommodityCode";
            cbbMNV.DataSource = EmployeeDAO.Instance.GetAll();
            cbbMNV.DisplayMember = "EmployeeCode";
        }

        private void EditDataGridViewHeader()
        {
            dgvEnterCoupon.Columns["EnterCouponCode"].HeaderText = "Mã Phiếu Nhập";
            dgvEnterCoupon.Columns["EmployeeCode"].HeaderText = "Mã Nhân Viên";
            dgvEnterCoupon.Columns["EmployeeCode"].Width = 200;
            dgvEnterCoupon.Columns["CommodityCode"].HeaderText = "Mã Mặt Hàng";
            dgvEnterCoupon.Columns["CommodityCode"].Width = 200;
            dgvEnterCoupon.Columns["DateOfImport"].HeaderText = "Ngày Nhập";
            dgvEnterCoupon.Columns["NumberOfImport"].HeaderText = "Số Lượng";

        }

        private void LoadBookList()
        {
            enterCouponList.DataSource = EnterCouponDAO.Instance.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int conmodityCode = -1;
            Int32.TryParse(cbbMMH.Text, out conmodityCode);
            int employeeCode = -1;
            Int32.TryParse(cbbMNV.Text, out employeeCode);
            int numOfImport = -1;
            Int32.TryParse(txtSLN.Text, out numOfImport);
            string dt = dtNN.Value.Date.ToString("MM-dd-yyyy");

            try
            {
                if (conmodityCode == -1 || employeeCode == -1 || numOfImport == -1)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    return;
                }
                else
                {
                    EnterCouponDAO.Instance.Insert(conmodityCode, employeeCode, dt, numOfImport);
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
            int row = dgvEnterCoupon.CurrentCell.RowIndex;
            int enterCouponCode;
            Int32.TryParse(dgvEnterCoupon.Rows[row].Cells[0].Value.ToString().Trim(), out enterCouponCode);

            int conmodityCode = -1;
            Int32.TryParse(cbbMMH.Text, out conmodityCode);
            int employeeCode = -1;
            Int32.TryParse(cbbMNV.Text, out employeeCode);
            int numOfImport = -1;
            Int32.TryParse(txtSLN.Text, out numOfImport);
            string dt = dtNN.Value.Date.ToString("MM-dd-yyyy");

            try
            {
                if (conmodityCode == -1 || employeeCode == -1 || numOfImport == -1)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    return;
                }
                else if (MessageBox.Show("Bạn có thật sự muốn sửa phiếu nhập này!", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    EnterCouponDAO.Instance.Update(enterCouponCode,conmodityCode, employeeCode, dt, numOfImport);
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
            int row = dgvEnterCoupon.CurrentCell.RowIndex;
            int enterCouponCode;
            Int32.TryParse(dgvEnterCoupon.Rows[row].Cells[0].Value.ToString().Trim(), out enterCouponCode);
            try
            {
                if (MessageBox.Show("Bạn có thật sự muốn xoá phiếu nhập này!", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    EnterCouponDAO.Instance.Delete(enterCouponCode);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtTimKiem.Text.Trim();
            enterCouponList.DataSource = EnterCouponDAO.Instance.Search(search);
        }
    }
}
