using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gisunachweb.Models
{
    public class InfoPaciente
    {
        public int id { set; get; }
        public Paciente paciente { set; get; }
        public int numpersonas { set; get; }
        public Trabajo trabajo { set; get; }
        public Estudio estudio { set; get; }
        public string enfermedadc { set; get; }
        public string diabetes { set; get; }
        public string sobrepeso { set; get; }
        public string aseguradoiess { set; get; }
        public string nombrecemer { set; get; }
        public string celularemer { set; get; }
        public string correoemer { set; get; }

        public InfoPaciente(int id, Paciente paciente, int numpersonas, Trabajo trabajo, Estudio estudio, string enfermedadc, string diabetes, string sobrepeso, string aseguradoiess, string nombrecemer, string celularemer, string correoemer)
        {
            this.id = id;
            this.paciente = paciente;
            this.numpersonas = numpersonas;
            this.trabajo = trabajo;
            this.estudio = estudio;
            this.enfermedadc = enfermedadc;
            this.diabetes = diabetes;
            this.sobrepeso = sobrepeso;
            this.aseguradoiess = aseguradoiess;
            this.nombrecemer = nombrecemer;
            this.celularemer = celularemer;
            this.correoemer = correoemer;
        }

        public InfoPaciente()
        {
        }
    }
}