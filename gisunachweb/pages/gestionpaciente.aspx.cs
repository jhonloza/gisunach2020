using gisunachweb.Logica;
using gisunachweb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gisunachweb.pages
{
    public partial class gestionpaciente : System.Web.UI.Page
    {
        LGestion lip = new LGestion();
        LTrabajo lt = new LTrabajo();
        LEstudio le = new LEstudio();
        LPaciente lp = new LPaciente();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresarGestion_Click(object sender, EventArgs e)
        {
            
            try
            {
                List<Paciente> listaF = new List<Paciente>();
                listaF = lp.listarPacientes();
                int ultimo = listaF.Count;
                Paciente ultimoP = listaF[ultimo-1];
                Trabajo tr = new Trabajo();
                Estudio est = new Estudio();
                if(txtnombretrab.Text.Equals("n/a") && txtdirtrab.Text.Equals("n/a") && txttelftrab.Text.Equals("n/a"))
                {
                    tr = lt.obtenerTrabajoID(1);
                }
                else
                {
                    tr = new Trabajo(1, txtnombretrab.Text, txtdirtrab.Text, txttelftrab.Text);
                    lt.insertarTrabajo(tr);
                    List<Trabajo> ltrab = new List<Trabajo>();
                    ltrab = lt.listarTrabajo();
                    int numtrab = ltrab.Count;
                    tr = ltrab[numtrab - 1];
                }
                if (txtnombest.Text.Equals("n/a") && txtdirest.Text.Equals("n/a") && txttelfest.Text.Equals("n/a"))
                {
                    est = le.obtenerEstudioID(1);
                }
                else
                {
                    est = new Estudio(1, txtnombest.Text, txtdirest.Text, txttelfest.Text);
                    le.insertarEstudio(est);
                    List<Estudio> lest = new List<Estudio>();
                    lest = le.listarEstudios();
                    int numest = lest.Count;
                    est = lest[numest - 1];
                }
                InfoPaciente infp = new InfoPaciente(1, ultimoP, Convert.ToInt32(txtpersonas.Text), tr, est, ddec.SelectedItem.Value, dddiabe.SelectedItem.Value, ddsobrep.SelectedItem.Value, ddseguro.SelectedItem.Value, txtnombemer.Text, txttelfemer.Text, txtcorreoemer.Text);
                lip.insertariPaciente(infp);
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Insetado Correctamente" + "');", true);
                Response.Redirect("~/pages/registro.aspx");
            }
            catch (Exception ex){
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
            }
        }
    }
}