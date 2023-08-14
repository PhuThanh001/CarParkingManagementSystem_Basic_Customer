using System;
using System.Collections.Generic;

namespace DataObject.Models
{
    public partial class User
    {
        public User()
        {
            BookingMembers = new HashSet<Booking>();
            BookingStatusNavigations = new HashSet<Booking>();
        }

        public int UserId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public int? Role { get; set; }

        public virtual ICollection<Booking> BookingMembers { get; set; }
        public virtual ICollection<Booking> BookingStatusNavigations { get; set; }
    }
}
