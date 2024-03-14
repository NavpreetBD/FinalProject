using System;
using System.Collections.Generic;
namespace FinalProject.Models
{
    public interface ITruckingInfoRepository
    {
        public IEnumerable<TruckingInfo> GetAllInfo();
        public  TruckingInfo GetInfo(int id);
        void UpdateTruckingInfo(TruckingInfo info);
        public void InsertTruckingInfo(TruckingInfo infoToInsert);
        public IEnumerable<Category> GetCategories();
        public TruckingInfo AssignCategory();
        public void DeleteTruckingInfo(TruckingInfo info);

    }
}
