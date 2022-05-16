using System;
using System.Collections.Generic;
using System.Text;

using MySql.Data.MySqlClient;
using System.Configuration;
using System.Collections.ObjectModel;

namespace wpf17_papirgyujtes.Models
{
    public class StatisztikaModel
    {
        public string nev { get; set; }
        public int osszesen { get; set; }


        public string osztaly { get; set; }
        public int legkisebb { get; set; }
        public int legnagyobb { get; set; }
        public int darab { get; set; }


        public StatisztikaModel()    {  }

        public static ObservableCollection<StatisztikaModel> selectOsztalyTanuloOsszesen(string osztalyAzon)
        {
            var lista = new ObservableCollection<StatisztikaModel>();

            using (var con = new MySqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString))
            {
                con.Open();
                var sql = "SELECT tanulok.nev, SUM(leadasok.mennyiseg) AS osszesen FROM leadasok RIGHT JOIN tanulok ON leadasok.tanulo = tanulok.tazon WHERE tanulok.osztaly=@osztalyAzon GROUP BY tanulok.nev ORDER BY osszesen DESC;";
                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@osztalyAzon", osztalyAzon);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new StatisztikaModel()
                            {
                                nev = reader["nev"].ToString(),
                                osszesen = reader["osszesen"] == DBNull.Value ? 0 : Convert.ToInt32(reader["osszesen"])
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public static ObservableCollection<StatisztikaModel> selectLegkevesebbLegtobbMennyiseg(string osztalyAzon, string irany)
        {
            var lista = new ObservableCollection<StatisztikaModel>();

            using (var con = new MySqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString))
            {
                con.Open();
                var sql = "SELECT tanulok.nev, SUM(leadasok.mennyiseg) AS osszesen FROM leadasok RIGHT JOIN tanulok ON leadasok.tanulo = tanulok.tazon WHERE tanulok.osztaly=@osztalyAzon GROUP BY tanulok.nev HAVING osszesen <=> (SELECT SUM(leadasok.mennyiseg) AS osszesen FROM leadasok RIGHT JOIN tanulok ON leadasok.tanulo = tanulok.tazon WHERE tanulok.osztaly = @osztalyAzon GROUP BY tanulok.nev ORDER BY osszesen "+irany+"  LIMIT 1) ORDER BY tanulok.nev";
                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@osztalyAzon", osztalyAzon);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new StatisztikaModel()
                            {
                                nev = reader["nev"].ToString(),
                                osszesen = reader["osszesen"] == DBNull.Value ? 0 : Convert.ToInt32(reader["osszesen"])
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public static ObservableCollection<StatisztikaModel> selectMennyisegOsztaly()
        {
            var lista = new ObservableCollection<StatisztikaModel>();

            using (var con = new MySqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString))
            {
                con.Open();
                var sql = "SELECT tanulok.osztaly, SUM(leadasok.mennyiseg) AS osszesen, MIN(leadasok.mennyiseg) AS legkisebb, MAX(leadasok.mennyiseg) AS legnagyobb, COUNT(leadasok.mennyiseg) AS darab FROM leadasok RIGHT JOIN tanulok ON leadasok.tanulo = tanulok.tazon GROUP BY tanulok.osztaly ORDER BY osszesen DESC";
                using (var cmd = new MySqlCommand(sql, con))
                {
                   
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new StatisztikaModel()
                            {
                                osztaly = reader["osztaly"].ToString(),
                                osszesen = reader["osszesen"] == DBNull.Value ? 0 : Convert.ToInt32(reader["osszesen"]),
                                legkisebb = reader["legkisebb"] == DBNull.Value ? 0 : Convert.ToInt32(reader["legkisebb"]),
                                legnagyobb = reader["legnagyobb"] == DBNull.Value ? 0 : Convert.ToInt32(reader["legnagyobb"]),
                                darab = reader["darab"] == DBNull.Value ? 0 : Convert.ToInt32(reader["darab"])
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}
