using gisunachweb.Logica;
using gisunachweb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace gisunachweb
{
    /// <summary>
    /// Descripción breve de APIWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class APIWeb : System.Web.Services.WebService
    {
        LPaciente lpaciente = new LPaciente();
        [WebMethod]
        public void InsertarPaciente(Paciente paciente)
        {
            lpaciente.insertarPaciente(paciente);
        }
        [WebMethod]
        public void ActualizarPaciente(Paciente paciente)
        {
            lpaciente.actualizarPaciente(paciente);
        }
        [WebMethod]
        public void EliminarPaciente(int idPaciente)
        {
            lpaciente.eliminarPaciente(idPaciente);
        }
        [WebMethod]
        public Paciente ObtenerPaciente(int idPaciente)
        {
            return lpaciente.obtenerPacienteID(idPaciente);
        }
        [WebMethod]
        public List<Paciente> ListarPacientes()
        {
            return lpaciente.listarPacientes();
        }
    }
}
