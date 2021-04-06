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
        private int CommodityCode;
        private string CommodityName;
        private DateTime DateOfManufacture;
        private DateTime ExpiryDate;
        private int ProducerCode;
        private int Amount;

        public int commodityCode { get=>CommodityCode; set=>CommodityCode=value; }
        public string commodityName { get=>CommodityName; set=>CommodityName=value; }
        public DateTime dateOfManufacture { get=>DateOfManufacture; set=>DateOfManufacture=value; }
        public DateTime expiryDate { get=>ExpiryDate; set=>ExpiryDate=value; }
        public int producerCode { get=>ProducerCode; set=>ProducerCode=value; }
        public int amount { get=>Amount; set=>Amount=value; }

        public Commodity(int CommodityCode,string CommodityName,DateTime DateOfManufactory,DateTime ExpiryDate,int ProducerCode , int Amount)
        {
            this.CommodityCode = CommodityCode;
            this.CommodityName = CommodityName;
            this.DateOfManufacture = DateOfManufacture;
            this.ExpiryDate = ExpiryDate;
            this.ProducerCode = ProducerCode;
            this.Amount = Amount;

        }

        public Commodity(DataRow Row)
        {
            Int32.TryParse(Row["CommodityCode"].ToString(), out this.CommodityCode);
            
            this.CommodityName = Row["CommodityName"].ToString();
            this.DateOfManufacture = (DateTime)Row["DateOfManufacture"];
            this.ExpiryDate = (DateTime)Row["ExpiryDate"];
            Int32.TryParse(Row["ProducerCode"].ToString(), out this.ProducerCode);
            Int32.TryParse(Row["Amount"].ToString(),out this.Amount);
        }
    }
}
