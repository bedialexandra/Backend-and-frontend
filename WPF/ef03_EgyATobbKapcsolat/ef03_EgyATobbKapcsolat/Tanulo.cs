using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;

namespace ef03_EgyATobbKapcsolat
{
    // több oldal
    public class Tanulo
    {
        [Key]
        public int tanuloId { get; set; }

        [Required]
        [StringLength(50)]
        public string tanuloNev { get; set; }

        public DateTime szuletesiDatum { get; set; }

        // kapcsolat létrehozásához
        public Osztaly Osztaly { get; set; }
        public int osztalyId { get; set; }
    }
}
