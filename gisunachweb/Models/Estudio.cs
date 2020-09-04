﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gisunachweb.Models
{
    public class Estudio
    {
        public int id { set; get; }
        public string nombre { set; get; }
        public string direccion { set; get; }
        public string telefono { set; get; }
        public Estudio()
        {

        }
        public Estudio(int pid, string pnombre, string pdireccion, string ptelefono)
        {
            this.id = pid;
            this.nombre = pnombre;
            this.direccion = pdireccion;
            this.telefono = ptelefono;
        }
    }
}