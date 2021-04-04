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
    class CommodityDAO
    {
        private static CommodityDAO instance;
        
        internal static CommodityDAO Instance
        {
            get { if (instance == null) instance = new CommodityDAO(); return instance; }
            private set { instance = value; }
        }

        public List<Commodity> GetAll()
        {
            List<Commodity> list = new List<Commodity>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_Commodity_GetAll");
            foreach (DataRow item in data.Rows)
            {
                Commodity entry = new Commodity(item);
                list.Add(entry);
            }
            return list;
        }
    }
}
