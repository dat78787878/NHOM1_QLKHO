using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHOM1_QLKHO.Models
{
    class EnterCoupon
    {
        public int EnterCouponCode { get; set; }
        public int CommodityCode { get; set; }
        public int EmployeeCode { get; set; }
        public DateTime DateOfImport { get; set; }
        public int NumberOfImport { get; set; }

        public EnterCoupon()
        {

        }

        public EnterCoupon(DataRow dataRow)
        {
            this.EnterCouponCode = Int32.Parse(dataRow["EnterCouponCode"].ToString());
            this.DateOfImport = DateTime.Parse(dataRow["DateOfImport"].ToString());
            this.CommodityCode = Int32.Parse(dataRow["CommodityCode"].ToString());
            this.EmployeeCode = Int32.Parse(dataRow["EmployeeCode"].ToString());
            this.NumberOfImport = Int32.Parse(dataRow["NumberOfImport"].ToString());
        }
    }
}
