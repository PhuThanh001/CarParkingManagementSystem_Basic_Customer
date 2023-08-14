using System;
using System.Collections.Generic;

namespace DataObject.Models
{
    public partial class Booking
    {
        public int BookingId { get; set; }
        public string? CarId { get; set; }
        public DateTime? EntryTime { get; set; }
        public DateTime? ExitTime { get; set; }
        public int? MemberId { get; set; }
        public int Status { get; set; }

        public virtual Car? Car { get; set; }
        public virtual User? Member { get; set; }
        public virtual User StatusNavigation { get; set; } = null!;
    }
}
