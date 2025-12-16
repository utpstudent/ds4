using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using parcial3.Models;

namespace parcial3.Models
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext() : base("DefaultConnection") { }

        public DbSet<Usuario> MM_Usuarios { get; set; }
        public DbSet<Articulo> MM_Articulos { get; set; }
        public DbSet<Revista> MM_Revistas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Usuario>().ToTable("MM_Usuarios");
            modelBuilder.Entity<Articulo>().ToTable("MM_Articulos");
            modelBuilder.Entity<Revista>().ToTable("MM_Revistas");
        }
    }
}