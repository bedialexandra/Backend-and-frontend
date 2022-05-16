using System;
using System.Collections.Generic;

#nullable disable

namespace ef05_library.Models
{
    public partial class Book
    {
        public Book()
        {
            Borrows = new HashSet<Borrow>();
        }

        public int BookId { get; set; }
        public string Name { get; set; }
        public int? Pagecount { get; set; }
        public int? Point { get; set; }
        public int? AuthorId { get; set; }
        public int? TypeId { get; set; }

        public virtual Author Author { get; set; }
        public virtual Type Type { get; set; }
        public virtual ICollection<Borrow> Borrows { get; set; }
    }
}
