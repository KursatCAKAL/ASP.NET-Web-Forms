using AspNetSql.Models;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetSql
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["Sepet"]!=null)
            {
                #region YORUMSATIRI
                //List<int> sepetUrunIdListesi = (List<int>)Session["Sepet"];
                //NorthwindEntities db = new NorthwindEntities();
                //List<Product> urunListesi = new List<Product>();
                //foreach (int id in sepetUrunIdListesi)
                //{
                // !!   Product urun = db.Products.FirstOrDefault(x => x.ProductID == id);//SessinSepet içinden o anki ıd eşit olanı bulduk
                //}
                //rptSepetUrunListesi.DataSource = urunListesi;
                //rptSepetUrunListesi.DataBind(); 
                #endregion

                List<SessionItem> sepetUrunListesi = (List<SessionItem>) Session["Sepet"];

                #region [Silinecek nesne kontrolü]
                if (Request.QueryString["delid"]!=null)
                {
                    int silinecekid = Convert.ToInt32(Request.QueryString["delid"]);
                  
                    SessionItem silinecekUrun = sepetUrunListesi.FirstOrDefault(x => x.Product.ProductID == silinecekid);

                    sepetUrunListesi.Remove(silinecekUrun);
                }
                #endregion
                #region [Arttırılacak nesne kontrolü]
                if (Request.QueryString["arttirid"] != null)
                {

                    NorthwindEntities1 db = new NorthwindEntities1();


                    int arttirilacakid = Convert.ToInt32(Request.QueryString["arttirid"]);

                    Product degisecekUrun = db.Products.FirstOrDefault(x => x.ProductID == arttirilacakid);

           
                    SessionItem arttirilacakUrun = sepetUrunListesi.FirstOrDefault(x => x.Product.ProductID == arttirilacakid);
                    int sayiTut = arttirilacakUrun.Count;
                    Product urunTut = arttirilacakUrun.Product;
                    sepetUrunListesi.Remove(arttirilacakUrun);

                    arttirilacakUrun.Count = sayiTut + 1;
                    arttirilacakUrun.Product = urunTut;


                    List<SessionItem> sepettekiUrunler = new List<SessionItem>();

                    if (Session["Sepet"] != null)
                    {
                        sepettekiUrunler = (List<SessionItem>)Session["Sepet"];
                    }

                    sepettekiUrunler.Add(arttirilacakUrun);
                    Session["Sepet"] = sepettekiUrunler;
                    Response.Redirect("/Cart.aspx");
                    Page_Load(sender, e);
                }
                #endregion
                #region [Azaltilacak nesne kontrolü]
                if (Request.QueryString["azaltid"] != null)
                {
                    NorthwindEntities1 db = new NorthwindEntities1();
                

                    int azaltilacakid = Convert.ToInt32(Request.QueryString["azaltid"]);

                    Product degisecekUrun = db.Products.FirstOrDefault(x => x.ProductID == azaltilacakid);
                  


                    SessionItem azaltilacakUrun = sepetUrunListesi.FirstOrDefault(x => x.Product.ProductID == azaltilacakid);
                    int sayiTut = azaltilacakUrun.Count;
                    Product urunTut = azaltilacakUrun.Product;
                    sepetUrunListesi.Remove(azaltilacakUrun);//içine nesne tipinden değer alır Remove

                    azaltilacakUrun.Count =sayiTut-1;
                    azaltilacakUrun.Product = urunTut;


                    List<SessionItem> sepettekiUrunler = new List<SessionItem>();

                    if (Session["Sepet"] != null)
                    {
                        sepettekiUrunler = (List<SessionItem>)Session["Sepet"];
                    }

                    sepettekiUrunler.Add(azaltilacakUrun);
                    Session["Sepet"] = sepettekiUrunler;
                    Response.Redirect("/Cart.aspx");
                    Page_Load(sender, e);
                }
                #endregion

                List<CartItem> cartItemList = new List<CartItem>();
              
                foreach (SessionItem s in sepetUrunListesi)
                {
                    CartItem c = new CartItem();
                    c.ProductId = s.Product.ProductID;
                    c.UnitPrice = (decimal)s.Product.UnitPrice;
                    c.ImageUrl = s.Product.ImageURL;
                    c.ProductName = s.Product.ProductName;
                    c.TotalPrice = s.Count * (decimal)s.Product.UnitPrice;
                    c.Count = s.Count;

                    cartItemList.Add(c);
                }

                rptSepetUrunListesi.DataSource = cartItemList.OrderBy(x=>x.ProductId);
                rptSepetUrunListesi.DataBind();
            }
            else//Sepette ürün yoksa ana sayfaya ya da sepette ürün yoktur diye yazarsın.
            {
                Response.Redirect("/");
            }
        }

        protected void btnArttir_Click(object sender, EventArgs e)
        {
         
        }
        protected void btnAzalt_Click(object sender, EventArgs e)
        {
           
        }
    }
}