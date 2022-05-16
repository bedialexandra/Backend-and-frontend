using System;
using System.Collections.Generic;
using System.Text;

namespace Kutyak
{
    class KutyaNevek
    {

        public int id { get; set; }
        public string kutyanev { get; set; }

        public KutyaNevek()
        {

        }

        public KutyaNevek(string sor)
        {
            string[] adatok = sor.Split(';');
            id = int.Parse(adatok[0]);
            kutyanev = adatok[1];  
        }

    }
}
