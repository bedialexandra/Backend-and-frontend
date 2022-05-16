using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Kektura
{
    class Utvonalak
    {
        public string kiinduloPont { get; set; }
        public string vegPont { get; set; }
        public double hossz { get; set; }
        public int emelkedes { get; set; }
        public int lejtes { get; set; }
        public string pecsetelohely { get; set; }

        public Utvonalak()
        {

        }

        public Utvonalak(string sor)
        {
            string[] adatok = sor.Split(';');
            kiinduloPont = adatok[0];
            vegPont = adatok[1];
            hossz = double.Parse(adatok[2]);
            emelkedes = int.Parse(adatok[3]);
            lejtes = int.Parse(adatok[4]);
            pecsetelohely = adatok[5];

            
           
        }

    }
}
