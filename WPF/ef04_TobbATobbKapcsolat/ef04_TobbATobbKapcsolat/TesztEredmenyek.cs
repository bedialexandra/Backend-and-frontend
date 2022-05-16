using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;

namespace ef04_TobbATobbKapcsolat
{
    public class TesztEredmenyek
    {
        public int tanuloId { get; set; }
        public Tanulo Tanulo { get; set; }

        public int tesztId { get; set; }
        public Teszt Teszt { get; set; }

        // egyéb mezők
        public int eredmeny { get; set; }
        public DateTime datum { get; set; }
    }
}
