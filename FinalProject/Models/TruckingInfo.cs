using System.Numerics;

namespace FinalProject.Models
{
    public class TruckingInfo
    {
        public int TruckID { get; set; }
        public int DriverID { get; set; }
        public string DriverName { get; set; }
        public BigInteger Mileage { get; set; }

        public TruckingInfo() 
        {
        }
    }
}
