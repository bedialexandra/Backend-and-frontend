using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;

namespace ef03_EgyATobbKapcsolat
{
    public class IskolaContext :DbContext
    {
        public DbSet<Tanulo> Tanulok { get; set; }
        public DbSet<Osztaly> Osztalyok { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=14a_Iskola;Uid=root;Pwd=;",ServerVersion.AutoDetect("Server=localhost;Database=14a_Iskola;Uid=root;Pwd=;"));
        }
    }
}
