using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea8CrearRegistroConLogin.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioID { get; set; }
        public string NombreUsuario { get; set; }
        public string AliasUsuario { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public DateTime FechaUsuario { get; set; }
        public string Rol { get; set; }
        public bool Activo { get; set; }

        public Usuarios()
        {
            UsuarioID = 0;
            NombreUsuario = string.Empty;
            AliasUsuario = string.Empty;
            Email = string.Empty;
            Clave = string.Empty;
            FechaUsuario = DateTime.Now;
            Rol = string.Empty;
            Activo = false;
        }
    }
}
