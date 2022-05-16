using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Linq;
using System.ComponentModel;

namespace WPF_hattertarolok
{
    public class Hattertarolo : NotifyPropertyChangedBase
    {

        private int _maxkapacitas;

        public int maxkapacitas
        {
            get { return _maxkapacitas; }
            set { _maxkapacitas = value; }
        }

        public int? foglaltKapacitas
        {
            get
            {
                return fajlok.Sum(x => x.meret);
            }
        }
        public int? szabadKapacitas
        {
            get
            {
                return maxkapacitas - foglaltKapacitas;
            }
        }

        private ObservableCollection<Fajlstruktura> _fajlok = new ObservableCollection<Fajlstruktura>();

        public ObservableCollection<Fajlstruktura> fajlok
        {
            get { return _fajlok; }
            
        }



        public Hattertarolo(int maxkapacitas)
        {
            this.maxkapacitas = maxkapacitas;
        }

        public virtual void Hozzaad(Fajlstruktura ujfajl)
        {
            fajlok.Add(new Fajlstruktura()
            {
                fajlnev = ujfajl.fajlnev,
                meret = ujfajl.meret,
                csakolvashato = ujfajl.csakolvashato,
                rendszer = ujfajl.rendszer,
                rejtettfajl = ujfajl.rejtettfajl
            });
            KapacitasFrissites();
        }

        private void KapacitasFrissites()
        {
            onPropertyChanged("foglaltKapacitas");
            onPropertyChanged("szabadKapacitas");
        }

        public virtual void torol(int sorszam)
        {
            this._fajlok.RemoveAt(sorszam);
            KapacitasFrissites();
        }

        public virtual void formaz()
        {
            this.fajlok.Clear();
            KapacitasFrissites();
        }

        public string keres(string fajlnev)
        {
            foreach (var egyfajl in this._fajlok)
            {
                if (egyfajl.fajlnev==fajlnev)
                {
                    return $"Fájlnév: {egyfajl.fajlnev+Environment.NewLine}Méret: {egyfajl.meret}";
                }

            }
            return "A fájl nem található!";
        }

    }
}
