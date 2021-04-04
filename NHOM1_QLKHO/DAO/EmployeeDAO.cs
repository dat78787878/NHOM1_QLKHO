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
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_Employee_GetAll");
            foreach (DataRow item in data.Rows)
            {
                Employee entry = new Employee(item);
                list.Add(entry);
            }
            return list;
        }
    }
}
