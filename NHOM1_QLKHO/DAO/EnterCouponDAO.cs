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
    class EnterCouponDAO
    {
        private static EnterCouponDAO instance;

        internal static EnterCouponDAO Instance
        {
            get { if (instance == null) instance = new EnterCouponDAO(); return instance; }
            private set { instance = value; }
        }

        public List<EnterCoupon> GetAll()
        {
            List<EnterCoupon> list = new List<EnterCoupon>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EnterCoupon_GetAll");
            foreach (DataRow item in data.Rows)
            {
                EnterCoupon entry = new EnterCoupon(item);
                list.Add(entry);
            }
            return list;
        }

        public bool Insert(int commodityCode, int employeeCode, string date, int numberOfImport)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EnterCoupon_Insert @CommodityCode , @EmployeeCode , @DateOfImport , @NumberOfImport", new object[] { commodityCode, employeeCode, date, numberOfImport });
            return result > 0;
        }

        public bool Update(int enterCouponCode, int commodityCode, int employeeCode, string date, int numberOfImport)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EnterCoupon_Update @EnterCouponCode ,  @CommodityCode , @EmployeeCode , @DateOfImport , @NumberOfImport", new object[] { enterCouponCode, commodityCode, employeeCode, date, numberOfImport });
            return result > 0;
        }

        public bool Delete(int enterCouponCode)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EnterCoupon_Delete @EnterCouponCode", new object[] { enterCouponCode });

            return result > 0;
        }

        public List<EnterCoupon> Search(string searchValue)
        {
            List<EnterCoupon> list = new List<EnterCoupon>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EnterCoupon_Search @searchValue", new object[] { searchValue });
            foreach (DataRow item in data.Rows)
            {
                EnterCoupon entry = new EnterCoupon(item);
                list.Add(entry);
            }
            return list;
        }
    }
}
