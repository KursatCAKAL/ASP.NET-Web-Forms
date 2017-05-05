using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_POSTBACK
{
    public partial class Defult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)//Her tıklama sonunda buraya gelir ve buna yaşam döngüsü denir.Sonrasında bileşenin bağlı olduğu event çalışır.
        {
            //if (IsPostBack)//Sayfanın ilk açılış olayında false döner her hangi bir bileşen ile etkileşime girildiğinde true olarak değişir.-ONEMLI
            //{
            
            //}
            if (!IsPostBack)
            {
                 ddlCinsiyet.Items.Add(new ListItem() { Text = "Kadın", Value = "1" });
                 ddlCinsiyet.Items.Add(new ListItem() { Text = "Erkek", Value = "1" });
            }
        }
        //List<Kisi> kisiLst = new List<Kisi>();//global'e değişken tanımlayıp üstünde veri tutamazsın .c# da ki mantık ile daha farklı.
        //Verinin çağrılma yöntemleri var,her sunucu için farklı session(oturum açılır)bunlar sunucudan sayfa talep eder.
        List<Kisi> kisiLst = new List<Kisi>();

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Session["liste"] != null)
            {
                kisiLst = (List<Kisi>)Session["liste"];
            }

            Kisi person = new Kisi()
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Cinsiyet = ddlCinsiyet.SelectedValue,
                DogumTarihi = cldDogum.SelectedDate

            };
            //string deger = TextBox1.Text;
            //Label1.Text = deger;

            kisiLst.Add(person);
            Session["liste"] = kisiLst;
        }
    }
}