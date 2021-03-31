using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHOM1_QLKHO.Models
{
    class Bill
    {
        public string BillCode { get; set; }
        public string CommodityCode { get; set; }
        public string EmployeeCode { get; set; }
        public DateTime DateOfExport { get; set; }
        public int NumberOfExport { get; set; }

        public Bill()
        {

        }

        public Bill(DataRow dataRow)
        {
            this.BillCode = dataRow["BillCode"].ToString();
            this.DateOfExport = DateTime.Parse(dataRow["DateOfExport"].ToString());
            this.CommodityCode = dataRow["CommodityCode"].ToString();
            this.EmployeeCode = dataRow["EmployeeCode"].ToString();
            this.NumberOfExport = Int32.Parse(dataRow["NumberOfExport"].ToString());
        }
    }
}
