using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace P6_Sister_1116_Exercise3_Service
{
    /// <summary>
    /// Summary description for AngkaService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AngkaService : System.Web.Services.WebService
    {

        [WebMethod]
        public string Bilangan(int angka)
        {
            string teks = "";
            if (angka % 2 == 0)
            {
                teks = "Bilangan Genap";
            } else {
                teks = "Bilangan Ganjil";
            }
            return teks;
        }
    }
}
