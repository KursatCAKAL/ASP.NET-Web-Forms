using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetSql
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                NorthwindEntities1 db = new NorthwindEntities1();

                if (Request.QueryString["id"] != null)
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    rptFeaturedItems.DataSource = db.Products.Where(x => x.CategoryID == id).ToList();
                    rptFeaturedItems.DataBind();
                }
                else
                {
                    rptFeaturedItems.DataSource = db.Products.Take(9).ToList();
                    rptFeaturedItems.DataBind();
                }
            }
        }
    }
}