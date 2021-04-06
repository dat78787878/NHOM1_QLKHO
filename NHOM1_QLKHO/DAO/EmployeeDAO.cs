using NHOM1_QLKHO.DatAccessLayer;
using NHOM1_QLKHO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHOM1_QLKHO.DAO
{
    class EmployeeDAO
    {
        private static EmployeeDAO instance;

        internal static EmployeeDAO Instance
        {
            get { if (instance == null) instance = new EmployeeDAO(); return instance; }
            private set { instance = value; }
        }
        public List<Employee> GetAll()
        {
            List<Employee> list = new List<Employee>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Employee_GetAll");
            foreach (DataRow item in data.Rows)
            {
                Employee entry = new Employee(item);
                list.Add(entry);
            }
            return list;
        }
        public bool Insert(Employee employee)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("Employee_Insert @fullName , @dateOfBirth , @phoneNumber", new object[] { employee.EmployeeName, employee.DateOfBirth, employee.PhoneNumber });
            return result > 0;
        }
        /// <summary>
        /// Cập nhật bản ghi
        /// </summary>
        /// <param name="employee">Đối tượng thêm vào bản ghi</param>
        /// <returns>Số bản gi cập nhật</returns>
        public bool Update(Employee employee)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("Employee_Update @employeeCode , @fullName , @dateOfBirth , @phoneNumber", new object[] { employee.EmployeeCode, employee.EmployeeName, employee.DateOfBirth, employee.PhoneNumber });
            return result > 0;
        }

        /// <summary>
        /// XÓa bản ghi
        /// </summary>
        /// <param name="employeeCode">Mã nhân viên</param>
        /// <returns>số bản ghi xóa</returns>
        public bool Delete(int employeeCode)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("Employee_Delete @employeeCode", new object[] { employeeCode });

            return result > 0;
        }
        public List<Employee> Search(string searchValue)
        {
            List<Employee> list = new List<Employee>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Employees_Search @searchValue", new object[] { searchValue });
            foreach (DataRow item in data.Rows)
            {
                Employee entry = new Employee(item);
                list.Add(entry);
            }
            return list;
        }
    }
}
