using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_hattertarolok
{
    public class Fajlstruktura : NotifyPropertyChangedBase
    {
        private string _fajlnev;

        public string fajlnev
        {
            get { return _fajlnev; }
            set { _fajlnev = value;  }
        }

        private int? _meret;

        public int? meret
        {
            get { return _meret; }
            set { _meret = value;  }
        }

        private bool _csakolvashato;

        public bool csakolvashato
        {
            get { return _csakolvashato; }
            set { _csakolvashato = value;  }
        }

        private bool _rendszer;

        public bool rendszer
        {
            get { return _rendszer; }
            set { _rendszer = value;  }
        }

        private bool _rejtettfajl;

        public bool rejtettfajl
        {
            get { return _rejtettfajl; }
            set { _rejtettfajl = value;  }
        }







    }
}
