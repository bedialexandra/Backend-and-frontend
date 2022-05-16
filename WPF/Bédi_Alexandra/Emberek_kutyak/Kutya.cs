using System;
using System.Collections.Generic;
using System.Text;

namespace Emberek_kutyak
{
    public class Kutya
    {
        private string _kutyaNev;

        public string kutyaNev
        {
            get { return _kutyaNev; }
            set { _kutyaNev = value; }
        }

        private string _fajta;

        public string fajta
        {
            get { return _fajta; }
            set { _fajta = value; }
        }

        private bool _huseges;

        public bool huseges
        {
            get { return _huseges; }
            set { _huseges = value; }
        }






    }
}
