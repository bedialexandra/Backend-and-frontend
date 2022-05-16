using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;

namespace ef03_EgyATobbKapcsolat
{
    // egy oldal
    public class Osztaly
    {
        [Key]
        public int osztalyId { get; set; }
        
        [Required]
        [StringLength(10)]
        public string osztalyNev { get; set; }

        public string osztalyFonok { get; set; }

        // kapcsolat
        public ICollection<Tanulo> Tanulo { get; set; }
    }
}
