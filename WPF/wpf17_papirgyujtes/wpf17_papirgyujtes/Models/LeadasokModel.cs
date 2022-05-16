using System;
using System.Collections.Generic;
using System.Text;

using System.Collections.ObjectModel;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.ComponentModel;

namespace wpf17_papirgyujtes.Models
{
    public class LeadasokModel : IDataErrorInfo
    {
        private int _sorsz;

        public int sorsz
        {
            get { return _sorsz; }
            set { _sorsz = value; }
        }
        private int _tanulo;

        public int tanulo
        {
            get { return _tanulo; }
            set { _tanulo = value; }
        }

        private DateTime _idopont;

        public DateTime idopont
        {
            get { return _idopont; }
            set { _idopont = value; }
        }
        private int _mennyiseg;

        public int mennyiseg
        {
            get { return _mennyiseg; }
            set { _mennyiseg = value; }
        }

 

        public LeadasokModel()  { }

        public LeadasokModel(MySqlDataReader reader)
        {
            this.sorsz = Convert.ToInt32(reader["sorsz"]);
            this.tanulo = Convert.ToInt32(reader["tanulo"]);
            this.idopont = Convert.ToDateTime(reader["idopont"]);
            this.mennyiseg = Convert.ToInt32(reader["mennyiseg"]);
        }

        public static ObservableCollection<LeadasokModel> select(int tanuloAzon)
        {
            var lista = new ObservableCollection<LeadasokModel>();

            using (var con = new MySqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString))
            {
                con.Open();
                var sql = "SELECT * FROM leadasok WHERE tanulo=@tanuloAzon";
                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@tanuloAzon", tanuloAzon);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new LeadasokModel(reader));
                        }
                    }
                }
            }
            return lista;
        }


        public static int insert(LeadasokModel model)
        {
            using (var con = new MySqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString))
            {
                con.Open();
                var sql = "INSERT INTO leadasok (tanulo,idopont,mennyiseg) VALUES (@tanulo,@idopont,@mennyiseg)";
                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@tanulo", model.tanulo);
                    cmd.Parameters.AddWithValue("@idopont", model.idopont);
                    cmd.Parameters.AddWithValue("@mennyiseg", model.mennyiseg);

                    cmd.ExecuteNonQuery();
                    return (int)cmd.LastInsertedId;
                }
            }
        }


        public string Error => throw new NotImplementedException();

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case "mennyiseg":
                        if (mennyiseg<=0 )
                        {
                            return "Csak pozitív szám lehet!";
                        }

                    break;
                }
                return null; // nincs hiba
            }
        }


    }
}
