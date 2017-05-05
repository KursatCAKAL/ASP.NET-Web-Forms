using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionKullanımı
{
    public partial class Sayfa2 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Label4.Text = Session["Kimlik"].ToString();
            Label2.Text = Application["ToplamZiyaretçi"].ToString();
        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("/Default.aspx?");
        }

        protected void LinkButton2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("/Sayfa1.aspx?");
        }

        protected void LinkButton3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("/Sayfa2.aspx?");
        }
    }
}