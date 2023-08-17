using System;
using System.Collections.Generic;

namespace DataObject.Models
{
    public partial class Baixe
    {
        public Baixe()
        {
            Slotxes = new HashSet<Slotxe>();
        }

        public int BaixeId { get; set; }
        public int? TotalSlot { get; set; }
        public int? AvailableSlot { get; set; }

        public virtual ICollection<Slotxe> Slotxes { get; set; }
    }
}
