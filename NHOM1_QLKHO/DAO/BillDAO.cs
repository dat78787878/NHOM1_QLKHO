using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using NHOM1_QLKHO.DatAccessLayer;
using NHOM1_QLKHO.Models;

namespace NHOM1_QLKHO.DAO
{
    class BillDAO
    {
        private static BillDAO instance;

        internal static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set { instance = value; }
        }
        public List<Bill> GetAll()
        {
            List<Bill> list = new List<Bill>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_Bill_GetAll");
            foreach (DataRow item in data.Rows)
            {
                Bill entry = new Bill(item);
                list.Add(entry);
            }
            return list;
        }
        public bool CheckInsert(int CommodityCode, int EmployeeCode, DateTime DateOfExport, int NumberOfExport)
        {
            List<Bill> list = new List<Bill>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_Bill_Insert @CommodityCode , @EmployeeCode , @DateOfExport , @NumberOfExport", new object[] { CommodityCode, EmployeeCode, DateOfExport, NumberOfExport });
            foreach (DataRow item in data.Rows)
            {
                Bill entry = new Bill (item);
                list.Add(entry);
            }
            return list.Count == 0;
        }

        public bool Insert(int CommodityCode, int EmployeeCode, DateTime DateOfExport, int NumberOfExport)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SP_Bill_Insert @CommodityCode , @EmployeeCode , @DateOfExport , @NumberOfExport", new object[] { CommodityCode, EmployeeCode, DateOfExport, NumberOfExport });
            return result > 0;
        }

        public bool Update(int BillCode, int CommodityCode, int EmployeeCode, DateTime DateOfExport, int NumberOfExport)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SP_Bill_Update @BillCode , @CommodityCode , @EmployeeCode , @DateOfExport , @NumberOfExport", new object[] { BillCode, CommodityCode, EmployeeCode, DateOfExport, NumberOfExport });

            return result > 0;
        }
        public bool Delete(int BillCode)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SP_Bill_Delete @BillCode", new object[] { BillCode });

            return result > 0;
        }
        public List<Bill> Search(string searchValue)
        {
            List<Bill> list = new List<Bill>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_Bill_Search @searchValue", new object[] { searchValue });
            foreach (DataRow item in data.Rows)
            {
                Bill entry = new Bill(item);
                list.Add(entry);
            }
            return list;
        }
    }
}
