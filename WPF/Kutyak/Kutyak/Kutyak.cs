using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Kutyak
{
    class Kutyak
    {
        //id;fajta_id;név_id;életkor;utolsó orvosi ellenőrzés
        public int id { get; set; }

        public int fajta_id { get; set; }
        public int nev_id { get; set; }
        public int eletkor { get; set; }
        public DateTime orvosiEllenorzes { get; set; }

        public KutyaFajtak kutyafajtak { get; set; }
        public KutyaNevek kutyanevek { get; set; }

        public Kutyak()
        {

        }
        public Kutyak(string sor)
        {
            string[] adatok = sor.Split(';');
            id = int.Parse(adatok[0]);
            fajta_id = int.Parse(adatok[1]);
            nev_id = int.Parse(adatok[2]);
            eletkor = int.Parse(adatok[3]);
            orvosiEllenorzes = DateTime.Parse(adatok[4]);

            kutyafajtak = KutyaListak.kutyafajtak.Where(x=>x.id==fajta_id).FirstOrDefault();
            kutyanevek = KutyaListak.kutyanevek.Where(x=>x.id==nev_id).FirstOrDefault();
        }

    }
}
