using System;
using System.Collections.Generic;

namespace DataObject.Models
{
    public partial class Car
    {
        public Car()
        {
            Bookings = new HashSet<Booking>();
        }

        public string CarId { get; set; } = null!;
        public int? CarTypeId { get; set; }
        public DateTime? EntryTime { get; set; }
        public DateTime? ExitTime { get; set; }
        public decimal? ParkingFee { get; set; }

        public virtual ParkingRate? CarType { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
