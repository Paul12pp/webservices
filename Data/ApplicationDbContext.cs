using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using LeeryEscribir;
using Microsoft.EntityFrameworkCore;

namespace WebServices
{
    public partial class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        //public ApplicationDbContext()
        //    : base("name=DbContext")
        //{
        //}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {

        }

        public virtual Microsoft.EntityFrameworkCore.DbSet<Empleados> Empleados { get; set; }
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleados>()
                .Property(e => e.Cedula)
                .IsUnicode(false);

            modelBuilder.Entity<Empleados>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Empleados>()
                .Property(e => e.Sueldo)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Empleados>()
                .Property(e => e.Moneda)
                .IsUnicode(false);
        }
    }
}
