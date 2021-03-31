using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHOM1_QLKHO.Models
{
    class Producer
    {
        public string ProducerCode { get; set; }
        public string ProducerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Producer()
        {

        }

        public Producer(DataRow dataRow)
        {
            this.ProducerCode = dataRow["ProducerCode"].ToString();
            this.ProducerName = dataRow["ProducerName"].ToString();
            this.Address = dataRow["Address"].ToString();
            this.PhoneNumber = dataRow["PhoneNumber"].ToString();
        }
    }
}
