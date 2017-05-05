using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace SessionKullanımı
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
        }
       protected void Session_Start(object sender, EventArgs e)
{
            /*Uygulama seviyesinde bir değişken kullanmak istediğimizden Application nesnesini kullandık. Eğer ilk kez oturum açılıyor ise varsayılan değeri 1 olarak ayarlıyoruz. İlk kez açılmıyorsa var olan değeri 1 arttırıyoruz.*/
            if (Application["ToplamZiyaretci"] == null)
            {
                Application["ToplamZiyaretci"] = 0;
            }

            Application["ToplamZiyaretci"] = ((int)Application["ToplamZiyaretci"]) + 1;
        }
 
protected void Session_End(object sender, EventArgs e)
{
            /* Oturum kapatıldığında devereye giren bu olayda, uygulama seviyesindeki Application nesnesinde saklanan değerini 1 azaltıyoruz. Böylece online ziyaretçi sayısını 1 azaltmış oluyoruz.*/
            Application["ToplamZiyaretci"] = (int)Application["ToplamZiyaretci"]-1;
  
}
    }
}