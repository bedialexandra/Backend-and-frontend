using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_hattertarolok
{
    public class Floppy : Hattertarolo
    {
        public Floppy(int maxkapacitas=1440) : base(maxkapacitas)
        {
            this.irasvedett = false;
        }
        private bool _irasvedett;

        public bool irasvedett
        {
            get { return _irasvedett; }
            set 
            { 
                _irasvedett = value;
                if (!this._irasvedett)
                {
                    hibauzenet = "";
                }
            }
        }

        public bool lezarvaFloppyMutat
        {
            get
            {
                return true;
            }
        }
        public override void torol(int sorszam)
        {
            if (!this._irasvedett)
            {
                base.torol(sorszam);
            }
            else
            {
                hibauzenet = "Szüntesse meg az írásvédettséget!";
            }
            
        }

        public override void formaz()
        {
            if (!this._irasvedett)
            {
                base.formaz();
            }
            else
            {
                hibauzenet = "Szüntesse meg az írásvédettséget!";
            }
        }

        public override void Hozzaad(Fajlstruktura ujfajl)
        {
            if (!this._irasvedett)
            {
                base.Hozzaad(ujfajl);
            }
            else
            {
                hibauzenet = "Szüntesse meg az írásvédettséget!";
            }
            
        }

        private string _hibauzenet = "";

        public string hibauzenet
        {
            get { return _hibauzenet = ""; }
            set { _hibauzenet = value; onPropertyChanged("hibauzenet"); }
        }

    }
    
}
