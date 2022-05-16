using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kutyak
{
    class Program
    {
        static List<KutyaNevek> kutyanevek = new List<KutyaNevek>();
        static List<KutyaFajtak> kutyafajtak = new List<KutyaFajtak>();
        static List<Kutyak> kutyak = new List<Kutyak>();

        static void Main(string[] args)
        {

            kutyaNevekBeolvasas();
            Console.WriteLine("3. feladat: Kutyanevek száma: {0}",kutyanevek.Count);
            KutyaFajtakBeolvas();
            KutyakBeolvas();
            double atlagkor = 0;
            foreach (var item in kutyak)
            {
                atlagkor += item.eletkor;
            }
            Console.WriteLine("4. feladat: Kutyák átlag életkora: {0:F}\n",atlagkor/kutyak.Count);

            int max = 0;
            int maxId = 0;
            foreach (var item in kutyak)
            {
                if (max<item.eletkor)
                {
                    max = item.eletkor;
                    maxId = item.id;
                }
            }
            foreach (var item in kutyak)
            {
                foreach (var fajta in kutyafajtak)
                {
                    foreach (var nev in kutyanevek)
                    {
                        if (item.id==maxId&&fajta.id==item.fajta_id&&nev.id==item.nev_id)
                        {
                            Console.WriteLine("7. feladat: A legidősebb kutya neve és Fajtája: {0}, {1}",nev.kutyanev, fajta.nev);
                        }   
                    }
                        
                }
               
            }



            
            Console.WriteLine("8. feladat: Január 10.-én vizsgált kutya fajták: ");
           

             

        }

        private static void kutyaNevekBeolvasas()
        {
            StreamReader sr = new StreamReader("KutyaNevek.csv");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                kutyanevek.Add(new KutyaNevek(sr.ReadLine()));
            }
        }

        private static void KutyaFajtakBeolvas()
        {
            StreamReader sr = new StreamReader("KutyaFajtak.csv");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                kutyafajtak.Add(new KutyaFajtak(sr.ReadLine()));
            }
        }

        private static void KutyakBeolvas()
        {
            StreamReader sr = new StreamReader("Kutyak.csv");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                kutyak.Add(new Kutyak(sr.ReadLine()));
            }
        }

    }
}
