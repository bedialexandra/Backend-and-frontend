using System;
using System.Collections.Generic;
using System.Text;

using MySql.Data.MySqlClient;
using System.Configuration;
using System.Collections.ObjectModel;


namespace wpf17_papirgyujtes.Models
{
    public class TanuloModel
    {
        private int _tazon;

        public int tazon
        {
            get { return _tazon; }
            set { _tazon = value; }
        }

        private string _nev;

        public string nev
        {
            get { return _nev; }
            set { _nev = value; }
        }

        private string _osztaly;

        public string osztaly
        {
            get { return _osztaly; }
            set { _osztaly = value; }
        }

        public TanuloModel()    { }

        public TanuloModel(MySqlDataReader reader)
        {
            this.tazon = Convert.ToInt32(reader["tazon"]);
            this.nev = reader["nev"].ToString();
            this.osztaly = reader["osztaly"].ToString();
        }

        public static ObservableCollection<TanuloModel> select()
        {
            var lista = new ObservableCollection<TanuloModel>();

            using (var con = new MySqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString))
            {
                con.Open();
                var sql = "SELECT * FROM tanulok";
                using (var cmd = new MySqlCommand(sql, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new TanuloModel(reader));
                        }
                    }
                }
            }
            return lista;
        }
    }
}
