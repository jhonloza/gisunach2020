using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Web;

namespace gisunachweb.Models
{
    public class Paciente
    {
        public int id { set; get; }
        public string geometry { set; get; }
        public double x { set; get; }
        public double y { set; get; }
        public string nombres { set; get; }
        public string apellidos { set; get; }
        public DateTime fechanac { set; get; }
        public string direccion { set; get; }
        public string cedula { set; get; }
        public string telfconv { set; get; }
        public string celular { set; get; }
        public string correoelec { set; get; }
        public string sexo { set; get; }

        public Paciente()
        {
        }
        public Paciente(int id, string geometry, double x, double y, string nombres, string apellidos, DateTime fechanac, string direccion, string cedula, string telfconv, string celular, string correoelec, string sexo)
        {
            this.id = id;
            this.geometry = geometry;
            this.x = x;
            this.y = y;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.fechanac = fechanac;
            this.direccion = direccion;
            this.cedula = cedula;
            this.telfconv = telfconv;
            this.celular = celular;
            this.correoelec = correoelec;
            this.sexo = sexo;
        }
    }
}