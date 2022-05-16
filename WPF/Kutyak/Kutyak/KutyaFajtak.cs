using System;
using System.Collections.Generic;
using System.Text;

namespace Kutyak
{
    class KutyaFajtak
    {

        public int id { get; set; }

        public string nev { get; set; }
        public string eredetiNev { get; set; }

        public KutyaFajtak()
        {

        }

        public KutyaFajtak(string sor)
        {
            string[] adatok = sor.Split(';');
            id = int.Parse(adatok[0]);
            nev = adatok[1];
            eredetiNev = adatok[2];
        }

    }
}
