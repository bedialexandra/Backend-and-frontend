using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Emberek_kutyak
{
    public class Ember
    {
        private string _nev;

        public string nev
        {
            get { return _nev; }
            set { _nev = value; }
        }

        private int? _eletkor;

        public int? eletkor
        {
            get { return _eletkor; }
            set { _eletkor = value; }
        }

        private int _kutyakszama;

        public int kutyakszama
        {
            get { return _kutyakszama; }
            set { _kutyakszama = value; }
        }

        private bool _nagyfulu;

        public bool nagyfulu
        {
            get { return _nagyfulu; }
            set { _nagyfulu = value; }
        }



        private ObservableCollection<Kutya> _kutyak = new ObservableCollection<Kutya>();

        public ObservableCollection<Kutya> kutyak
        {
            get { return _kutyak; }
            
        }

        public Ember()
        {

        }

        public virtual void Hozzaad(Kutya ujKutya)
        {
            kutyak.Add(new Kutya() {
                kutyaNev = ujKutya.kutyaNev,
                fajta = ujKutya.fajta,
                huseges = ujKutya.huseges
            }); 
            this.kutyakszama++;
        }

        

       


    }
}
