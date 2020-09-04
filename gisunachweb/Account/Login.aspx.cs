using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using gisunachweb.Models;
using gisunachweb.dbconnection;
using gisunachweb.Logica;

namespace gisunachweb.Account
{
    public partial class Login : Page
    {
        LUsuario logicaU = new LUsuario();
        protected void btningreso_Click(object sender, EventArgs e)
        {
            try {
                Usuario usr = new Usuario();
                usr = logicaU.obtenerUsuario(usuariotxt.Text, pass.Text);
                if(usr != null)
                {
                    Response.Redirect("~/pages/registro.aspx");
                }
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
            }
        }
    }
}