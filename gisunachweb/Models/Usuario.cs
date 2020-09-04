using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gisunachweb.Models
{
    public class Usuario
    {
        public int id { set; get; }
        public string usuario { set; get; }
        public string pass { set; get; }
        public string nombres { set; get; }
        public string apellidos { set; get; }
        public DateTime fechanacimiento { set; get; }
        public string cedula { set; get; }
        public string telefono { set; get; }

        public Usuario()
        {
        }

        public Usuario(int id, string usuario, string pass, string nombres, string apellidos, DateTime fechanacimiento, string cedula, string telefono)
        {
            this.id = id;
            this.usuario = usuario;
            this.pass = pass;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.fechanacimiento = fechanacimiento;
            this.cedula = cedula;
            this.telefono = telefono;
        }
    }
}