using System;
using System.Collections.Generic;

namespace DataObject.Models
{
    public partial class ParkingRate
    {
        public ParkingRate()
        {
            Cars = new HashSet<Car>();
        }

        public int CarTypeId { get; set; }
        public string? VehicleType { get; set; }
        public decimal? RatePerHour { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
