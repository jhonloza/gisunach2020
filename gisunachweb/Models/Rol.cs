using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gisunachweb.Models
{
    public class Rol
    {
        public int id { set; get; }
        public Usuario usuario { set; get; }
        public string tipo { set; get; }
        public Rol()
        {
        }
        public Rol(int id, Usuario usuario, string tipo)
        {
            this.id = id;
            this.usuario = usuario;
            this.tipo = tipo;
        }
    }
}