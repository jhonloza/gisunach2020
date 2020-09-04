using gisunachweb.Logica;
using gisunachweb.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using NetTopologySuite;
using NetTopologySuite.Geometries;

namespace gisunachweb.pages
{
    public partial class registro : System.Web.UI.Page
    {
        NumberFormatInfo nfi = new NumberFormatInfo();
        
        LPaciente lp = new LPaciente();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegistrarPaciente(object sender, EventArgs e)
        {
            try
            {
                var factoryGeo = NtsGeometryServices.Instance.CreateGeometryFactory(32717);
                Paciente np = new Paciente();
                DateTime fechan = Convert.ToDateTime(txtfechan.Text);
                np.id = 1;
                
                np.nombres = txtnombre.Text;
                np.apellidos = txtapellido.Text;
                np.cedula = txtcedula.Text;
                np.celular = txtcelular.Text;
                np.correoelec = txtemail.Text;
                np.direccion = txtdir.Text;
                np.fechanac = fechan;
                np.x = Convert.ToDouble(txtlat.Text) / 1000000;
                np.y = Convert.ToDouble(txtlong.Text) / 1000000;
                np.geometry = factoryGeo.CreatePoint(new Coordinate(np.x, np.y)).ToString();
                np.sexo = ddsex.SelectedItem.Value;
                np.telfconv = txttelf.Text;
                lp.insertarPaciente(np);
                Response.Redirect("~/pages/gestionpaciente.aspx");
            }
            catch(Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
            }
        }
    }
}