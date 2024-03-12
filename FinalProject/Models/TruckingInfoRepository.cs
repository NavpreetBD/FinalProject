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
    }
}
