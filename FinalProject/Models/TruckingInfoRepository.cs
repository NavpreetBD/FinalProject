using Dapper;
using System;
using System.Data;
namespace FinalProject.Models
{
    public class TruckingInfoRepository : ITruckingInfoRepository
    {
        private readonly IDbConnection _conn;

        public TruckingInfoRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<TruckingInfo> GetAllInfo()
        {
            return _conn.Query<TruckingInfo>("SELECT * FROM TruckingInfo;");
        }

        public TruckingInfo GetInfo(int id)
        {
            return _conn.QuerySingle<TruckingInfo>("SELECT * FROM TRUCKINGINFO WHERE truckID = @id", new { id = id });
        }

        public void UpdateTruckingInfo(TruckingInfo info)
        {
            _conn.Execute("UPDATE truckinginfo SET  DriverID = @driverID, DriverName = @driverName WHERE TruckID = @truckID",
             new {  driverID = info.DriverID, driverName = info.DriverName, truckID = info.TruckID });
        }

        public void InsertTruckingInfo(TruckingInfo infoToInsert)
        {
            _conn.Execute("INSERT INTO truckingInfo (TRUCKID, DRIVERID, DRIVERNAME, MILEAGE) VALUES ( @truckID , @driverID, @driverName, @mileage);",
                new { truckId = infoToInsert.TruckID , driverID = infoToInsert.DriverID, driverName = infoToInsert.DriverName, mileage = infoToInsert.Mileage });
        }

        public IEnumerable<Category> GetCategories()
        {
            return _conn.Query<Category>("SELECT * FROM categories;");
        }

        public TruckingInfo AssignCategory()
        {
            var categoryList = GetCategories();
            var info = new TruckingInfo();
            info.Categories = categoryList;
            return info;
        }

        public void DeleteTruckingInfo(TruckingInfo info)
        {
            _conn.Execute("DELETE FROM TRUCKINGINFO WHERE TruckID = @id;", new { id = info.TruckID });
        
        }


    }
}
