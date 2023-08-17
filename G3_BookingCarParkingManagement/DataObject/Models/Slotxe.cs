using System;
using System.Collections.Generic;

namespace DataObject.Models
{
    public partial class Slotxe
    {
        public Slotxe()
        {
            Books = new HashSet<Book>();
        }

        public int SlotxeId { get; set; }
        public int? BaixeId { get; set; }
        public int? Status { get; set; }

        public virtual Baixe? Baixe { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
