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
        public string EnterCouponCode { get; set; }
        public string CommodityCode { get; set; }
        public string EmployeeCode { get; set; }
        public DateTime DateOfImport { get; set; }
        public int NumberOfImport { get; set; }

        public EnterCoupon()
        {

        }

        public EnterCoupon(DataRow dataRow)
        {
            this.EnterCouponCode = dataRow["EnterCouponCode"].ToString();
            this.DateOfImport = DateTime.Parse(dataRow["DateOfImport"].ToString());
            this.CommodityCode = dataRow["CommodityCode"].ToString();
            this.EmployeeCode = dataRow["EmployeeCode"].ToString();
            this.NumberOfImport = Int32.Parse(dataRow["NumberOfImport"].ToString());
        }
    }
}
