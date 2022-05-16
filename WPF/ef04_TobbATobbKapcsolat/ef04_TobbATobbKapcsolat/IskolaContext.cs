using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;

namespace ef04_TobbATobbKapcsolat
{
    public class IskolaContext :DbContext
    {
        public DbSet<Tanulo> Tanulok { get; set; }
        public DbSet<Teszt> Teszt { get; set; }
        public DbSet<TesztEredmenyek> tesztEredmenyek { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=14a_Iskola2;Uid=root;Pwd=;",ServerVersion.AutoDetect("Server=localhost;Database=14a_Iskola2;Uid=root;Pwd=;"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TesztEredmenyek>().HasKey(te => new { te.tanuloId, te.tesztId });
        }
    }
}
