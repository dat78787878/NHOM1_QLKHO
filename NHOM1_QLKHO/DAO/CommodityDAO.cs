using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHOM1_QLKHO.DatAccessLayer;
using NHOM1_QLKHO.Models;


namespace NHOM1_QLKHO.DAO
{
    class CommodityDAO { 

     private static CommodityDAO instance;

    internal static CommodityDAO Instance
    {
        get { if (instance == null) instance = new CommodityDAO(); return instance; }
        private set { instance = value; }
    }
    public List<Commodity> GetAll()
    {
        List<Commodity> list = new List<Commodity>();
        DataTable data = DataProvider.Instance.ExecuteQuery("SP_HangHoa_GetAll");
        foreach (DataRow item in data.Rows)
        {
            Commodity entry = new Commodity(item);
            list.Add(entry);
        }
        return list;
    }

    public bool Insert(string CommodityName, DateTime DateOfManufacture, DateTime ExpiryDate,int  ProducerCode )
    {
        int result = DataProvider.Instance.ExecuteNonQuery("SP_HangHoa_Insert @CommodityName , @DateOfManufacture , @ExpiryDate , @ProducerCode", new object[] { CommodityName, DateOfManufacture, ExpiryDate, ProducerCode });
        return result > 0;
    }

    public bool Update(int CommodityCode, string CommodityName, DateTime DateOfManufacture, DateTime ExpiryDate, int ProducerCode)
    {
        int result = DataProvider.Instance.ExecuteNonQuery("SP_HangHoa_Update @CommodityCode , @CommodityName , @DateOfManufacture , @ExpiryDate , @ProducerCode", new object[] {CommodityCode, CommodityName, DateOfManufacture, ExpiryDate, ProducerCode });

        return result > 0;
    }
    public bool Delete(int CommodityCode)
    {
        int result = DataProvider.Instance.ExecuteNonQuery("SP_HangHoa_Delete @CommodityCode", new object[] { CommodityCode });

        return result > 0;
    }
    public List<Commodity> Search(string searchValue)
    {
        List<Commodity> list = new List<Commodity>();
        DataTable data = DataProvider.Instance.ExecuteQuery("SP_HangHoa_Search @searchValue", new object[] { searchValue });
        foreach (DataRow item in data.Rows)
        {
            Commodity entry = new Commodity(item);
            list.Add(entry);
        }
        return list;
    }
  }
}
