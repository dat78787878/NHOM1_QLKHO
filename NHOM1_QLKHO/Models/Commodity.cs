using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHOM1_QLKHO.Models
{
    class Commodity
    {
        public int CommodityCode { get; set; }
        public string CommodityName { get; set; }
        public DateTime DateOfManufacture { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string ProducerCode { get; set; }
        public int Amount { get; set; }

        public Commodity()
        {

        }

        public Commodity(DataRow dataRow)
        {
            this.CommodityCode = Int32.Parse(dataRow["EnterCouponCode"].ToString());
            this.DateOfManufacture = DateTime.Parse(dataRow["DateOfImport"].ToString());
            this.ExpiryDate = DateTime.Parse(dataRow["DateOfImport"].ToString());
            this.CommodityName = dataRow["CommodityCode"].ToString();
            this.ProducerCode = dataRow["EmployeeCode"].ToString();
            this.Amount = Int32.Parse(dataRow["NumberOfImport"].ToString());
        }
    }
}
