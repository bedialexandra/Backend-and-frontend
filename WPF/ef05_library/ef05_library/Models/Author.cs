using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace ef05_library.Models
{
    public partial class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual ICollection<Book> Books { get; set; }


        // nem vesz részt az adatbázis kezelésben
        [NotMapped]
        public string FullName { get {
                return string.Format("{0} {1}", Name, Surname);    
            }  
        }
    }
}
