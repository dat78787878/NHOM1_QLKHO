using NHOM1_QLKHO.DatAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHOM1_QLKHO.DAO
{
    class AccoutDAO
    {
        
        private static AccoutDAO instance;

        internal static AccoutDAO Instance
        {
            get { if (instance == null) instance = new AccoutDAO(); return instance; }
            private set { instance = value; }
        }
        public AccoutDAO() { }

        public bool KiemTraDN(string UserName, string Pass)
        {
            int result = (int)DataProvider.Instance.ExecuteScalar("SP_DangNHap @UserName , @Pass", new object[] { UserName, Pass });
            return result > 0;
        }

        
    }
}
