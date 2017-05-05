using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionKullanımı
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["ToplamZiyaretci"] ==null)
            {
                Application["ToplamZiyaretci"] = 0;
            }
            Application["ToplamZiyaretci"] =((int)Application["ToplamZiyaretci"])+1;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Default.aspx?");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Sayfa1.aspx?");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Sayfa2.aspx?");
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            Session["Kimlik"] = txtName.Text;
            
        }
    }
}