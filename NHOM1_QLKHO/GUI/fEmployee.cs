using NHOM1_QLKHO.DAO;
using NHOM1_QLKHO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHOM1_QLKHO.GUI
{
    public partial class fEmployee : Form
    {
        BindingSource employeeList = new BindingSource();
        public fEmployee()
        {
            InitializeComponent();
            LoadFirstTime();
            EditDataGridView();
            BindingDataToFrom();
        }
        private void EditDataGridView()
        {
            dgvEmployee.Columns["EmployeeCode"].HeaderText = "Mã nhân viên";
            dgvEmployee.Columns["EmployeeName"].HeaderText = "Họ và Tên";
            dgvEmployee.Columns["DateOfBirth"].HeaderText = "Ngày sinh";
            dgvEmployee.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
        }
        private void BindingDataToFrom()
        {
            lbEmployeeCode.DataBindings.Add(new Binding("Text", dgvEmployee.DataSource, "EmployeeCode", true, DataSourceUpdateMode.Never));
            txtEmployeeName.DataBindings.Add(new Binding("Text", dgvEmployee.DataSource, "EmployeeName", true, DataSourceUpdateMode.Never));
            txtPhoneNumber.DataBindings.Add(new Binding("Text", dgvEmployee.DataSource, "PhoneNumber", true, DataSourceUpdateMode.Never));
            dateTimeDOB.DataBindings.Add(new Binding("Text", dgvEmployee.DataSource, "DateOfBirth", true, DataSourceUpdateMode.Never));
        }

        /// <summary>
        /// kiểm tra định dạng regex họ và tên 
        /// created by : NVH
        /// </summary>
        /// <param name="name"> input : 1 chuỗi</param>
        /// <returns>true or false</returns>
        private bool CheckFullName(string name)
        {
            //regex họ và tên :Bắt ít nhất 1 kí tự và nhiều nhất 20 kí tự
            string re = "^\\D{1,20}$";
            //string re = "^[A-Z][a-z]*(\\s[A-Z][a-z]*)+$";
            Regex regex = new Regex(re);
            Match match = regex.Match(name);
            //trả về true : đúng định dạng ,false : sai định dạng 
            return match.Success;
        }
        private bool CheckPhoneNumber(string phoneNumber)
        {
            //regex địa chỉ :  tên gồm các chữ cái ,Các kí tự đầu của  của tên or họ phải bắt đầu bằng chữ hoa
            //Và có ít nhất 2 thành phần trở lên 
            string re = "^[0-9]{1,15}$";
            Regex regex = new Regex(re);
            Match match = regex.Match(phoneNumber);
            //trả về true : đúng định dạng ,false : sai định dạng 
            return match.Success;
        }

        public bool Check()
        {
            if (!CheckFullName(txtEmployeeName.Text.Trim()) | !CheckPhoneNumber(txtPhoneNumber.Text.Trim()))
            {
                return false;
            }
            return true;
        }

        private void LoadFirstTime()
        {
            dgvEmployee.DataSource = employeeList;
            LoadListEmployee();
        }


        private void LoadListEmployee()
        {
            employeeList.DataSource = EmployeeDAO.Instance.GetAll();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            /// check valid 
            if (!Check())
            {
                MessageBox.Show("Dữ liệu Nhập đang lỗi hệ thống báo dưới đây , Vui lòng kiểm tra lại\n" +
                    "Họ Và Tên(bao gồm các kí tự) :" + CheckFullName(txtEmployeeName.Text)
                    + "\nSố điện thoại(bao gồm các số) : " + CheckPhoneNumber(txtPhoneNumber.Text.Trim())
                    + "\nNgày sinh : " + true
                    );
            }
            // Khi dữ liệu hợp lệ 
            else
            {
                // Lấy dữ liệu nhập : khi đã nhập đủ 
                Employee employee = new Employee();
                employee.EmployeeName = txtEmployeeName.Text;
                employee.PhoneNumber = txtPhoneNumber.Text;
                employee.DateOfBirth = dateTimeDOB.Value;

                if (EmployeeDAO.Instance.Insert(employee))
                {
                    MessageBox.Show("Thêm Thành Công " + txtEmployeeName.Text);
                    txtEmployeeName.Text = "";
                    txtPhoneNumber.Text = "";
                    LoadListEmployee();
                }
                else
                {
                    MessageBox.Show("Lỗi Trong quá trình thêm");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string EmployeeName = txtEmployeeName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            DateTime dateOfBirth = dateTimeDOB.Value;
            int EmployeeCode = 0;
            Int32.TryParse(lbEmployeeCode.Text, out EmployeeCode);
            try
            {
                if (EmployeeCode == -1 || EmployeeName == "" || phoneNumber == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    return;
                }
                Employee employee = new Employee();
                employee.EmployeeName = txtEmployeeName.Text;
                employee.PhoneNumber = txtPhoneNumber.Text;
                employee.DateOfBirth = dateTimeDOB.Value;
                EmployeeDAO.Instance.Update(employee);
                MessageBox.Show("Sửa thành công");
                LoadListEmployee();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadListEmployee();
            }
        }


    }
}
