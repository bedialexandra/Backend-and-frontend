using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Bédi_Alexandra_Munkavállalók
{
    public class Munkavállaló
    {

		private string _nev;

		public string nev
		{
			get { return _nev; }
			set { _nev = value; }
		}

		private int _fizetesiKategoria;

		public int fizetesiKategoria
		{
			get { return _fizetesiKategoria; }
			set { _fizetesiKategoria = value; }
		}

		private int _evesSzabadsag;

		public int evesSzabadsag
		{
			get { return _evesSzabadsag; }
			set { _evesSzabadsag = value; }
		}

		public Munkavállaló(string nev, int fizetesiKategoria)
		{
			this.nev = nev;
			this.fizetesiKategoria = fizetesiKategoria;
		}

		public Munkavállaló(string nev, int fizetesiKategoria,int evesSzabadsag)
		{
			this.nev = nev;
			this.fizetesiKategoria = fizetesiKategoria;
			this.evesSzabadsag = evesSzabadsag;
		}

		

        

        private int _osszkivettSzabadsag;

        public int osszkivettSzabadsag
        {
            get { return _osszkivettSzabadsag; }
            set { _osszkivettSzabadsag = value; }
        }

        

        public int maradekSzabadsag
        {
            get
            {
				return evesSzabadsag - osszkivettSzabadsag;
            }
        }

		

        private ObservableCollection<int> _kivettszabadsagok;
        

        public ObservableCollection<int> kivettszabadsagok
        {
            get { return _kivettszabadsagok; }
            set { _kivettszabadsagok = value; }
        }

        public Munkavállaló()
        {
                
        }

        private int _kivettszabi;

        public int kivettszabi
        {
            get { return _kivettszabi; }
            set { _kivettszabi = value; }
        }

        
        

        public void Hozzaad(int kivettszabi)
        {
            this.kivettszabi = kivettszabi;
            this.kivettszabadsagok.Add(this.kivettszabi);
        }
    }
}
