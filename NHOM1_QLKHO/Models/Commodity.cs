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
            this.CommodityCode = Int32.Parse(dataRow["CommodityCode"].ToString());
            this.CommodityName = dataRow["CommodityName"].ToString();
            this.DateOfManufacture = DateTime.Parse(dataRow["DateOfManufacture"].ToString());
            this.ExpiryDate = DateTime.Parse(dataRow["ExpiryDate"].ToString());
            this.ProducerCode = dataRow["ProducerCode"].ToString();
            this.Amount = Int32.Parse(dataRow["Amount"].ToString());
        }
    }
}
