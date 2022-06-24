using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace P6_Sister_1116_Exercise2_Service
{
    /// <summary>
    /// Summary description for WarnaService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WarnaService : System.Web.Services.WebService
    {

        [WebMethod]
        public string Warna(int nomor)
        {
            string teks= "";
            if (nomor > 7 || nomor == 0)
            {
                teks = "Nomor antara 1 - 7";
            }
            switch (nomor)
            {
                case (1):
                    teks = "Merah";
                    break;
                case (2):
                    teks = "Jingga";
                    break;
                case (3):
                    teks = "Kuning";
                    break;
                case (4):
                    teks = "Hijau";
                    break;
                case (5):
                    teks = "Biru";
                    break;
                case (6):
                    teks = "Nila";
                    break;
                case (7):
                    teks = "Ungu";
                    break;
            }
            return teks;
        }
    }
}
