using System.Numerics;

namespace FinalProject.Models
{
    public class TruckingInfo
    {
        public int TruckID { get; set; }
        public int DriverID { get; set; }
        public string DriverName { get; set; }
        public long Mileage { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public TruckingInfo() 
        {
        }
    }
}
