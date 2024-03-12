using System;
using System.Collections.Generic;
namespace FinalProject.Models
{
    public interface ITruckingInfoRepository
    {
        public IEnumerable<TruckingInfo> GetAllInfo();
        public  TruckingInfo GetInfo(int id);

    }
}
