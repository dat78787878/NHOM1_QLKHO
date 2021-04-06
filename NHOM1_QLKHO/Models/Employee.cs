using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHOM1_QLKHO.Models
{
    class Employee
    {

        public int EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }

        public Employee()
        {

        }

        public Employee(DataRow dataRow)
        {
            this.EmployeeCode = Int32.Parse(dataRow["EmployeeCode"].ToString());
            this.DateOfBirth = DateTime.Parse(dataRow["DateOfBirth"].ToString());
            this.EmployeeName = dataRow["EmployeeName"].ToString();
            this.PhoneNumber = dataRow["PhoneNumber"].ToString();
        }
    }
}
