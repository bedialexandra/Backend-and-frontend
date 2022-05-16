using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;

namespace ef04_TobbATobbKapcsolat
{
    public class Teszt
    {
        [Key]
        public int tesztId { get; set; }

        [Required]
        [StringLength(100)]
        public string tesztMegnevezes { get; set; }


        public ICollection<TesztEredmenyek> Teszteredmenyek { get; set; }

    }
}
