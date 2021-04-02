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
  
        public int BillCode { get; set ; }
        public int CommodityCode { get ; set ; }
        public int EmployeeCode { get ; set ; }
        public DateTime DateOfExport { get ; set ; }
        public int NumberOfExport { get ; set ; }

        public Bill()
        {

        }

        public Bill(DataRow dataRow)
        {
            this.BillCode = Int32.Parse(dataRow["BillCode"].ToString());
            this.CommodityCode = Int32.Parse(dataRow["CommodityCode"].ToString());
            this.EmployeeCode = Int32.Parse(dataRow["EmployeeCode"].ToString());
            this.DateOfExport = DateTime.Parse(dataRow["DateOfExport"].ToString());
            this.NumberOfExport = Int32.Parse(dataRow["NumberOfExport"].ToString());
        }
    }
}
