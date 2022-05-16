using System;
using System.Collections.Generic;
using System.IO;

namespace Kektura
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Utvonalak> utvonalak = new List<Utvonalak>();
            StreamReader sr = new StreamReader("kektura.csv");
            int magassag=int.Parse(sr.ReadLine());
            
            while (!sr.EndOfStream)
            {
                
                utvonalak.Add(new Utvonalak(sr.ReadLine()));
            }
            sr.Close();

            double teljhossz = 0;

            foreach (var item in utvonalak)
            {
                teljhossz += item.hossz;
            }

            double minhossz = utvonalak[0].hossz;

            foreach (var item in utvonalak)
            {
                if (minhossz>item.hossz)
                {
                    minhossz = item.hossz;
                }
            }

            string kezdet = "";
            string veg = "";
            double tav = 0;
            foreach (var item in utvonalak)
            {
                if (minhossz==item.hossz)
                {
                    kezdet = item.kiinduloPont;
                    veg = item.vegPont;
                    tav = item.hossz;
                }
            }


            


            Console.WriteLine("3. feladat: Szakaszok száma: {0} db", utvonalak.Count);
            Console.WriteLine("4. feladat: A túra teljes hossza: {0} km", teljhossz);
            Console.WriteLine("5.feladat: A legrövidebb szakasz adatai: ");
            Console.WriteLine("\t Kezdete: {0}",kezdet);
            Console.WriteLine("\t Vége: {0}",veg);
            Console.WriteLine("\t Távolság: {0} km",tav);
            Console.WriteLine("7.feladat: Hiányos állomásnevek: ");
            int hianydarab = 0;
            foreach (var item in utvonalak)
            {
                if (item.pecsetelohely=="n")
                {
                    Console.WriteLine("\t {0}",item.kiinduloPont);
                    hianydarab++;
                }
                
            }
          
            if (hianydarab==0)
            {
                Console.WriteLine("\t Nincs hiányos állomásnév!");
            }



            List<double> tengerszintmag = new List<double>();
            double tengerszint = magassag;
            foreach (var item in utvonalak)
            {
                
                tengerszint += item.emelkedes;
                tengerszint -= item.lejtes;
                tengerszintmag.Add(tengerszint);
                
            }
            tengerszint = tengerszintmag[0];
            foreach (var item in tengerszintmag)
            {
                if (tengerszint<item)
                {
                    tengerszint = item;
                }
            }

            
            Console.WriteLine("8.feladat: A túra legmagasabban fekvő végpontja: ");
            Console.WriteLine("\t A végpont neve: {0}");
            Console.WriteLine("\t A végpont tengerszint feletti magassága: {0} m", tengerszint);
        }
    }
}
