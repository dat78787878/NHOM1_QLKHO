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
            cbCommodityCode.DataSource = BillDAO.Instance.GetAll();
            cbCommodityCode.DisplayMember = "CommodityCode";
        }

        private void LoadComboboxEmployeeCode()
        {
            cbEmployeeCode.DataSource = BillDAO.Instance.GetAll();
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
    }
}
