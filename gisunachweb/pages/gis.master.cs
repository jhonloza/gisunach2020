using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gisunachweb.pages
{
    public partial class gis : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Cerrar_Sesion(object sender, EventArgs e)
        {
            Response.Redirect("~/");
        }

        protected void Ir_Inicio(object sender, EventArgs e)
        {
            Response.Redirect("~/pages/registro.aspx");
        }
    }
}