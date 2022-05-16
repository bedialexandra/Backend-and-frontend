using System;
using System.Collections.Generic;

#nullable disable

namespace ef05_library.Models
{
    public partial class Type
    {
        public Type()
        {
            Books = new HashSet<Book>();
        }

        public int TypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
