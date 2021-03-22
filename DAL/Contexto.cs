using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea8CrearRegistroConLogin.Entidades;

namespace Tarea8CrearRegistroConLogin.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Permisos> Permisos { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source = DATA/GestionUsuarios.Db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Permisos>().HasData(
                new Permisos() { PermisoID = 1, NombrePermiso = "Descuenta", DescripcionPermiso = "Este permiso puede modificar el precio" },
                new Permisos() { PermisoID = 2, NombrePermiso = "Vende", DescripcionPermiso = "Este permiso puede vender productos" },
                new Permisos() { PermisoID = 3, NombrePermiso = "Cobra", DescripcionPermiso = "Este permiso puede cobrar dinero" }
            );
            modelBuilder.Entity<Usuarios>().HasData(new Usuarios()
            {
                UsuarioID = 1,
                NombreUsuario = "Anneury",
                AliasUsuario = "Sosa",
                Clave = "5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5",
                Email = "Admin@outlook.com",
                FechaUsuario = new DateTime(2021, 05, 22),
                Rol = "admin",
                Activo = true
            });
        }
    }
}
