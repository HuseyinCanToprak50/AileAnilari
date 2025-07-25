using AileAnilari.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileAnilari
{
    public class AileAnilariDbContext:DbContext
    {
        public DbSet<Kullanicilar> Kullanicilar { get; set; }
        public DbSet<Anilar> Anilar { get; set; }
        public DbSet<AileGrubu>AileGrubu { get; set; }

        public DbSet<Kategori> Kategori { get; set; }   
        public DbSet<Medya> Medya { get; set; }
        public DbSet<Tavsiyeler> Tavsiyeler { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite("Data Source=AileAnilari.db");
        }
    }
}
