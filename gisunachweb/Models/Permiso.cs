using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gisunachweb.Models
{
    public class Permiso
    {
        public int id { set; get; }
        public Usuario usuario { set; get; }
        public string modulo { set; get; }
        public int estado { set; get; }
        public Permiso()
        {
        }
        public Permiso(int id, Usuario usuario, string modulo, int estado)
        {
            this.id = id;
            this.usuario = usuario;
            this.modulo = modulo;
            this.estado = estado;
        }
    }
}