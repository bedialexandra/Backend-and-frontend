using System;
using System.Collections.Generic;

#nullable disable

namespace ef05_library.Models
{
    public partial class Student
    {
        public Student()
        {
            Borrows = new HashSet<Borrow>();
        }

        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Gender { get; set; }
        public string Class { get; set; }
        public int? Point { get; set; }

        public virtual ICollection<Borrow> Borrows { get; set; }


        public string Fullname { get { return Name + " " + Surname; }  }
    }
}
